using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
	public partial class FormVenda : Form
	{
		public FormVenda(int idVenda)
		{
			InitializeComponent();
			labelIdVenda.Text = idVenda.ToString();
			CarregarTipos();
			CarregaVenda(idVenda);
		}

		private void FormVenda_Load(object sender, EventArgs e)
		{

		}

		private void CalculaValor(object sender, EventArgs e)
		{
			try
			{
				var idTipoQuentinha = 0;
				if (inputTipoQuentinha.SelectedValue != null)
					int.TryParse(inputTipoQuentinha.SelectedValue.ToString(), out idTipoQuentinha);
				var quantidade = 0;
				int.TryParse(inputQuantidade.Text.ToString(), out quantidade);

				if (idTipoQuentinha > 0)
					using (var context = new ApplicationDbContext())
					{
						var tipoQuentinha = context.TiposQuentinha.Where(x => x.Id == idTipoQuentinha).FirstOrDefault();
						if (tipoQuentinha == null)
							throw new Exception("Tipo não encontrado");

						var valorLabel = quantidade >= 5 ? (tipoQuentinha.Valor * 0.9785M) : tipoQuentinha.Valor;

						valorUnit.Text = valorLabel.ToString("C", CultureInfo.CurrentUICulture);
						valorTotal.Text = (quantidade * valorLabel).ToString("C", CultureInfo.CurrentUICulture);
					}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro");
			}
		}

		private void InserirItem(object sender, EventArgs e)
		{
			try
			{
				var idVenda = int.Parse(labelIdVenda.Text.ToString());
				var idTipoQuentinha = 0;
				if (inputTipoQuentinha.SelectedValue != null)
					int.TryParse(inputTipoQuentinha.SelectedValue.ToString(), out idTipoQuentinha);
				var quantidade = 0;
				int.TryParse(inputQuantidade.Text.ToString(), out quantidade);

				if (idTipoQuentinha == 0)
					throw new Exception("Selecione um Tipo de Quentinha");

				if (quantidade == 0)
					throw new Exception("Preencha corretamente o campo de Quantidade");

				using (var context = new ApplicationDbContext())
				{
					var tipoQuentinha = context.TiposQuentinha.Where(x => x.Id == idTipoQuentinha).FirstOrDefault();
					if (tipoQuentinha == null)
						throw new Exception("Tipo não encontrado");

					var valorPagoUnidade = quantidade >= 5 ? (tipoQuentinha.Valor * 0.9785M) : tipoQuentinha.Valor;

					var venda = context.Vendas.FirstOrDefault(x => x.Id == idVenda);
					if (venda == null)
						throw new Exception("Venda não encontrada");

					var itemVenda = new VendaItem();
					itemVenda.VendaId = idVenda;
					itemVenda.Quantidade = quantidade;
					itemVenda.ValorPagoUnidade = valorPagoUnidade;
					itemVenda.TipoQuentinhaId = idTipoQuentinha;

					context.VendaItens.Add(itemVenda);
					context.SaveChanges();

					CarregaValorVenda(sender, e);
					CarregaItensVenda(idVenda);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro");
			}
		}

		private void SelecionaItem(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				var id = int.Parse(listaItens.Rows[e.RowIndex].Cells["Id"].Value.ToString());
				labelVendaItemId.Text = listaItens.Rows[e.RowIndex].Cells["Id"].Value.ToString();
				btnExcluir.Visible = true;
			}
		}

		private void ExcluirItem(object sender, EventArgs e)
		{
			try
			{
				var idVenda = int.Parse(labelIdVenda.Text.ToString());
				var idVendaItem = int.Parse(labelVendaItemId.Text.ToString());
				using (var context = new ApplicationDbContext())
				{
					var vendaItem = context.VendaItens.Where(x => x.Id == idVendaItem).FirstOrDefault();
					if (vendaItem == null)
						throw new Exception("Item não encontrado");

					context.VendaItens.Remove(vendaItem);
					context.SaveChanges();

					CarregaValorVenda(sender,e);
					CarregaItensVenda(idVenda);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro");
			}
		}

		private void AnotarPedido(object sender, EventArgs e)
		{
			try
			{
				var idVenda = int.Parse(labelIdVenda.Text.ToString());

				using (var context = new ApplicationDbContext())
				{

					var venda = context.Vendas.FirstOrDefault(x => x.Id == idVenda);
					if (venda == null)
						throw new Exception("Venda não encontrada");

					venda.DataPedido = DateTime.Now;
					decimal valorFrete = 0;
					decimal.TryParse(inputValorFrete.Text.Replace("R$", String.Empty), out valorFrete);

					venda.ValorFrete = valorFrete;

					context.SaveChanges();

					MessageBox.Show("Pedido anotado!", "Sucesso");
					this.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro");
			}
		}

		private void CarregarTipos()
		{
			List<TipoQuentinha> tiposQuentinha;

			using (var context = new ApplicationDbContext())
			{
				tiposQuentinha = context.TiposQuentinha.ToList();
			}


			inputTipoQuentinha.DataSource = tiposQuentinha;
			inputTipoQuentinha.ValueMember = "Id";
			inputTipoQuentinha.DisplayMember = "Descricao";
			inputTipoQuentinha.SelectedItem = null;
		}

		private void CarregaValorVenda(object sender, EventArgs e)
		{

			var idVenda = int.Parse(labelIdVenda.Text.ToString());

			List<VendaItem> vendaItens;
			using (var context = new ApplicationDbContext())
			{
				vendaItens = context.VendaItens.Include(x => x.Venda).Include(x => x.TipoQuentinha).Where(x => x.VendaId == idVenda).ToList();
			}

			var listaDadoItens = vendaItens.Select(x => new
			{
				Id = x.Id,
				Quentinha = x.TipoQuentinha.Descricao,
				Quantidade = x.Quantidade,
				Valor = x.ValorPagoUnidade * x.Quantidade
			}).ToList();

			var valorTotal = listaDadoItens.Sum(x => x.Valor);
			decimal valorFrete = 0;
			decimal.TryParse(inputValorFrete.Text.Replace("R$", String.Empty), out valorFrete);

			valorTotalVenda.Text = (valorFrete + valorTotal).ToString("C", CultureInfo.CurrentUICulture);
		}

		private void CarregaItensVenda(int idVenda)
		{
			List<VendaItem> vendaItens;			

			using (var context = new ApplicationDbContext())
			{
				vendaItens = context.VendaItens.Include(x => x.TipoQuentinha).Where(x => x.VendaId == idVenda).ToList();				
			}

			var listaDadoItens = vendaItens.Select(x => new
			{
				Id = x.Id,
				Quentinha = x.TipoQuentinha.Descricao,
				Quantidade = x.Quantidade,
				Valor = (x.ValorPagoUnidade * x.Quantidade).ToString("C")
			}).ToList();		

			listaItens.DataSource = listaDadoItens;
			listaItens.AutoResizeColumns();
			listaItens.ClearSelection();
		}

		private void CarregaVenda(int idVenda)
		{
			List<VendaItem> vendaItens;
			Venda venda;

			using (var context = new ApplicationDbContext())
			{
				vendaItens = context.VendaItens.Include(x => x.TipoQuentinha).Where(x => x.VendaId == idVenda).ToList();

				venda = context.Vendas.Where(x => x.Id == idVenda).FirstOrDefault();
			}

			var listaDadoItens = vendaItens.Select(x => new
			{
				Id = x.Id,
				Quentinha = x.TipoQuentinha.Descricao,
				Quantidade = x.Quantidade,
				Valor = (x.ValorPagoUnidade * x.Quantidade).ToString("C")
			}).ToList();

			string formato = "R$ 000.00";
			inputValorFrete.Text = venda.ValorFrete != null ? venda.ValorFrete.Value.ToString(formato) : "";

			if (venda.DataEntrega != null || venda.DataCancelado != null)
			{
				btnAnotarPedido.Enabled = false;
				btnInserirItem.Enabled = false;
			}

			listaItens.DataSource = listaDadoItens;
			listaItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			listaItens.ClearSelection();
		}
	}
}
