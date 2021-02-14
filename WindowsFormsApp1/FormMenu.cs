using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
	public partial class FormMenu : Form
	{
		public FormMenu()
		{
			InitializeComponent();
			CarregaListaVendas();
		}

		private void CarregaListaVendasFoco(object sender, EventArgs e)
		{
			CarregaListaVendas();
		}

		private void AbrirFormIniciarVenda(object sender, EventArgs e)
		{
			var formIniciarVenda = new FormIniciarVenda();
			formIniciarVenda.ShowDialog();
		}

		private void AbrirFormCliente(object sender, EventArgs e)
		{
			var formCliente = new FormCliente();
			formCliente.ShowDialog();
		}

		private void AbrirFormTipoQuentinha(object sender, EventArgs e)
		{
			var formTipoQuentinha = new FormTipoQuentinha();
			formTipoQuentinha.ShowDialog();
		}

		private void AbrirFormVenda(object sender, EventArgs e)
		{
			var formTipoQuentinha = new FormVenda(int.Parse(idVenda.Text.ToString()));
			formTipoQuentinha.ShowDialog();
		}	

		private void SelecionaItem(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				var id = int.Parse(listaVendas.Rows[e.RowIndex].Cells["Id"].Value.ToString());
				idVenda.Text = listaVendas.Rows[e.RowIndex].Cells["Id"].Value.ToString();
				btnEditar.Visible = true;
				btnCancelar.Visible = true;
				btnEntregar.Visible = true;
			}
		}

		private void EntregarPedido(object sender, EventArgs e)
		{
			try
			{
				var vendaId = int.Parse(idVenda.Text.ToString());

				using (var context = new ApplicationDbContext())
				{

					var venda = context.Vendas.FirstOrDefault(x => x.Id == vendaId);
					if (venda == null)
						throw new Exception("Venda não encontrada");

					if (venda.DataEntrega != null)
						throw new Exception("Pedido já entregue previamente");
					if (venda.DataCancelado != null)
						throw new Exception("Venda cancelada, portanto não pode ser entregue");

					venda.DataEntrega = DateTime.Now;					

					context.SaveChanges();

					MessageBox.Show("Pedido foi entregue!", "Sucesso");
					CarregaListaVendas();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro");
			}
		}

		private void CancelarPedido(object sender, EventArgs e)
		{
			try
			{
				var vendaId = int.Parse(idVenda.Text.ToString());

				using (var context = new ApplicationDbContext())
				{

					var venda = context.Vendas.FirstOrDefault(x => x.Id == vendaId);
					if (venda == null)
						throw new Exception("Venda não encontrada");

					if (venda.DataCancelado != null)
						throw new Exception("Pedido já cancelado previamente");
					if (venda.DataEntrega != null)
						throw new Exception("Pedido já foi entregue, portanto não pode ser cancelado");

					venda.DataCancelado = DateTime.Now;

					context.SaveChanges();

					MessageBox.Show("Pedido foi cancelado!", "Concluído");
					CarregaListaVendas();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro");
			}
		}

		private void CarregaListaVendas()
		{
			try
			{
				var vendas = new List<Venda>();

				using(var context = new ApplicationDbContext())
				{
					vendas = context.Vendas.Include(x => x.Cliente).OrderByDescending(x => x.DataPedido).ToList();

					var listaVendaComValor = vendas.Select(x => new
					{
						Id = x.Id,
						Cliente = x.Cliente.Nome,
						Valor = ((context.VendaItens.Where(y => y.VendaId == x.Id).Sum(y => y.ValorPagoUnidade * y.Quantidade) + x.ValorFrete) ?? 0).ToString("C"),
						Situação = x.DataCancelado != null ? "CANCELADO": (x.DataEntrega != null? "ENTREGUE" :(x.DataPedido != null? "PEDIDO":"PEDIDO INCOMPLETO"))
					}).ToList();

					listaVendas.DataSource = listaVendaComValor;
					listaVendas.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
					listaVendas.ClearSelection();
				}				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro");
			}
		}
			
	}
}
