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
	public partial class FormCliente : Form
	{
		public FormCliente()
		{
			InitializeComponent();
			CarregarClientes();
		}

		private void FormCliente_Load(object sender, EventArgs e)
		{

		}

		private void NovoCliente(object sender, EventArgs e)
		{
			labelId.Text = "#Novo";
			inputNome.Text = "";
			inputCelular.Text = "";
			inputEmail.Text = "";

			btnExcluir.Visible = false;
			btnNovoCliente.Visible = false;
			listaClientes.ClearSelection();
		}

		private void SalvarCliente(object sender, EventArgs e)
		{
			try
			{
				var textId = labelId.Text;
				var id = textId.Contains("Novo") ? 0 : int.Parse(textId.Substring(1));
				var nome = inputNome.Text;
				var celular = inputCelular.Text;
				var email = inputEmail.Text;

				if(!string.IsNullOrEmpty(email) && !email.Contains("@"))
					throw new Exception("Email inválido");

				if(string.IsNullOrEmpty(nome))
					throw new Exception("O campo de Nome deve ser preenchido!");

				using (var context = new ApplicationDbContext())
				{
					var clienteDb = new Cliente();
					if (id == 0)
					{
						var verificaCliente = context.Clientes.Where(x => (x.Email == email || x.Celular == celular) && x.Id != id).FirstOrDefault();
						if (verificaCliente != null)
							throw new Exception("Cliente com mesmo email cadastrado");
					}
					else
					{
						clienteDb = context.Clientes.Where(x => x.Id == id).FirstOrDefault();
						if (clienteDb == null)
							throw new Exception("Cliente não encontrado");
					}

					clienteDb.Nome = nome;
					clienteDb.Email = email;
					clienteDb.Celular = celular;

					if (id == 0)
						context.Clientes.Add(clienteDb);

					context.SaveChanges();
				}

				MessageBox.Show("Cliente cadastrado!", "Sucesso!");
				CarregarClientes();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro");
			}
		}

		private void CarregaCliente(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1)
			{
				var id = int.Parse(listaClientes.Rows[e.RowIndex].Cells["Id"].Value.ToString());
				labelId.Text = "#" + listaClientes.Rows[e.RowIndex].Cells["Id"].Value.ToString();
				btnExcluir.Visible = true;
				btnNovoCliente.Visible = true;

				using (var context = new ApplicationDbContext())
				{
					var cliente = context.Clientes.Where(x => x.Id == id).FirstOrDefault();
					if (cliente == null)
						throw new Exception("Cliente não encontrado");

					inputNome.Text = cliente.Nome;
					inputCelular.Text = cliente.Celular;
					inputEmail.Text = cliente.Email;
				}

				listaClientes.ClearSelection();
			}		
		}

		private void ExcluiCliente(object sender, EventArgs e)
		{
			try
			{
				var textId = labelId.Text;
				var id = textId.Contains("Novo") ? 0 : int.Parse(textId.Substring(1));

				if (id == 0)
					throw new Exception("Nenhum cliente foi selecionado para ser excluído");

				using (var context = new ApplicationDbContext())
				{
					var verificaCliente = context.Clientes.Where(x => x.Id == id).FirstOrDefault();
					if (verificaCliente == null)
						throw new Exception("Cliente não encontrado");

					context.Clientes.Remove(verificaCliente);
					context.SaveChanges();
				}

				CarregarClientes();
				NovoCliente(sender, e);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro");
			}
		}

		private void CarregarClientes()
		{
			List<Cliente> clientes;

			using (var context = new ApplicationDbContext())
			{
				clientes = context.Clientes.ToList();
			}

			listaClientes.DataSource = clientes;			
			listaClientes.ClearSelection();
		}

	}
}
