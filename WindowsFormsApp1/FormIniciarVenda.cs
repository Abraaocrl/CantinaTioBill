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
	public partial class FormIniciarVenda : Form
	{
		public FormIniciarVenda()
		{
			InitializeComponent();
			CarregarClientes();
		}

		private void AbrirFormCliente(object sender, EventArgs e)
		{
			var formCliente = new FormCliente();
			formCliente.ShowDialog();
		}

		private void IniciarVenda(object sender, EventArgs e)
		{
			try
			{
				var cliente = inputCliente.SelectedValue;

				using (var context = new ApplicationDbContext())
				{
					var venda = new Venda();
					var verificaCliente = context.Clientes.Where(x => x.Id == int.Parse(cliente.ToString())).FirstOrDefault();
					if (verificaCliente == null)
						throw new Exception("Cliente não encontrado");

					venda.ClienteId = int.Parse(cliente.ToString());

					context.Vendas.Add(venda);
					context.SaveChanges();

					var formVenda = new FormVenda(venda.Id);
					formVenda.ShowDialog();

					this.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Sucesso");
			}
		}

		private void CarregarClientes()
		{
			List<Cliente> clientes;

			using (var context = new ApplicationDbContext())
			{
				clientes = context.Clientes.ToList();
			}


			inputCliente.DataSource = clientes;
			inputCliente.ValueMember = "Id";
			inputCliente.DisplayMember = "Nome";
			inputCliente.SelectedItem = null;
		}

	}
}
