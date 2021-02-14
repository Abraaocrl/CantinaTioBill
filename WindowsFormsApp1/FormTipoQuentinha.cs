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
	public partial class FormTipoQuentinha : Form
	{
		public FormTipoQuentinha()
		{
			InitializeComponent();
			CarregarTiposQuentinha();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void NovoTipo(object sender, EventArgs e)
		{
			labelId.Text = "#Novo";
			inputDescricao.Text = "";
			inputValor.Text = "";

			btnExcluir.Visible = false;
			btnNovoTipoQuentinha.Visible = false;
			listaClientes.ClearSelection();
		}

		private void SalvarTipo(object sender, EventArgs e)
		{
			try
			{
				var textId = labelId.Text;
				var id = textId.Contains("Novo") ? 0 : int.Parse(textId.Substring(1));
				var descricao = inputDescricao.Text;
				var valor = decimal.Parse(inputValor.Text.Replace("R$", String.Empty));


				using (var context = new ApplicationDbContext())
				{
					TipoQuentinha tipoQuentinhaDb;
					var verificaTipo = context.TiposQuentinha.Where(x => x.Descricao == descricao && x.Id != id).FirstOrDefault();
					if (verificaTipo != null)
						throw new Exception("Tipo com mesma descrição cadastrado");

					if (id == 0)
					{
						tipoQuentinhaDb = new TipoQuentinha();
					}
					else
					{
						tipoQuentinhaDb = context.TiposQuentinha.Where(x => x.Id == id).FirstOrDefault();
						if (tipoQuentinhaDb == null)
							throw new Exception("Tipo não encontrado");
					}

					tipoQuentinhaDb.Descricao = descricao;
					tipoQuentinhaDb.Valor = valor;					

					if (id == 0)
						context.TiposQuentinha.Add(tipoQuentinhaDb);

					context.SaveChanges();
				}

				MessageBox.Show("Tipo de Quentinha cadastrado!", "Sucesso!");
				CarregarTiposQuentinha();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro");
			}
		}

		private void CarregaTipo(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				var id = int.Parse(listaClientes.Rows[e.RowIndex].Cells["Id"].Value.ToString());
				labelId.Text = "#" + listaClientes.Rows[e.RowIndex].Cells["Id"].Value.ToString();
				btnExcluir.Visible = true;
				btnNovoTipoQuentinha.Visible = true;

				using (var context = new ApplicationDbContext())
				{
					var tipoQuentinha = context.TiposQuentinha.Where(x => x.Id == id).FirstOrDefault();
					if (tipoQuentinha == null)
						throw new Exception("Tipo não encontrado");

					inputDescricao.Text = tipoQuentinha.Descricao;

					string formato = "R$ 000.00";
					inputValor.Text = tipoQuentinha.Valor.ToString(formato);					
				}

				listaClientes.ClearSelection();
			}
		}

		private void ExcluiTipo(object sender, EventArgs e)
		{
			try
			{
				var textId = labelId.Text;
				var id = textId.Contains("Novo") ? 0 : int.Parse(textId.Substring(1));

				if (id == 0)
					throw new Exception("Nenhum tipo foi selecionado para ser excluído");

				using (var context = new ApplicationDbContext())
				{
					var verificaTipo = context.TiposQuentinha.Where(x => x.Id == id).FirstOrDefault();
					if (verificaTipo == null)
						throw new Exception("Tipo não encontrado");

					context.TiposQuentinha.Remove(verificaTipo);
					context.SaveChanges();
				}

				CarregarTiposQuentinha();
				NovoTipo(sender, e);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro");
			}
		}

		private void CarregarTiposQuentinha()
		{
			List<TipoQuentinha> tipoQuentinhas;

			using (var context = new ApplicationDbContext())
			{
				tipoQuentinhas = context.TiposQuentinha.ToList();
			}

			var listaTipo = tipoQuentinhas.Select(x => new
			{
				Id = x.Id,
				Descricao = x.Descricao,
				Valor = x.Valor.ToString("C")
			}).ToList();

			listaClientes.DataSource = listaTipo;
			listaClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			listaClientes.ClearSelection();
		}
	}
}
