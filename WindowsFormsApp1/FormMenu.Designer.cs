
namespace WindowsFormsApp1
{
	partial class FormMenu
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.listaVendas = new System.Windows.Forms.DataGridView();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnEntregar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.idVenda = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.listaVendas)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(32, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(187, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cantina do Tio Bill";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 31);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(182, 37);
			this.button1.TabIndex = 1;
			this.button1.Text = "Clientes";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.AbrirFormCliente);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(8, 84);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(182, 37);
			this.button2.TabIndex = 2;
			this.button2.Text = "Tipo Quentinha";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.AbrirFormTipoQuentinha);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(37, 79);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(182, 37);
			this.button3.TabIndex = 3;
			this.button3.Text = "Iniciar Venda";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.AbrirFormIniciarVenda);
			// 
			// listaVendas
			// 
			this.listaVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.listaVendas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.listaVendas.Location = new System.Drawing.Point(287, 79);
			this.listaVendas.Name = "listaVendas";
			this.listaVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.listaVendas.Size = new System.Drawing.Size(477, 265);
			this.listaVendas.TabIndex = 4;
			this.listaVendas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelecionaItem);
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(287, 364);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(144, 38);
			this.btnEditar.TabIndex = 5;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Visible = false;
			this.btnEditar.Click += new System.EventHandler(this.AbrirFormVenda);
			// 
			// btnEntregar
			// 
			this.btnEntregar.Location = new System.Drawing.Point(458, 364);
			this.btnEntregar.Name = "btnEntregar";
			this.btnEntregar.Size = new System.Drawing.Size(141, 38);
			this.btnEntregar.TabIndex = 6;
			this.btnEntregar.Text = "Entregar";
			this.btnEntregar.UseVisualStyleBackColor = true;
			this.btnEntregar.Visible = false;
			this.btnEntregar.Click += new System.EventHandler(this.EntregarPedido);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(623, 364);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(141, 38);
			this.btnCancelar.TabIndex = 7;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Visible = false;
			this.btnCancelar.Click += new System.EventHandler(this.CancelarPedido);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Location = new System.Drawing.Point(29, 260);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 142);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Cadastros";
			// 
			// idVenda
			// 
			this.idVenda.AutoSize = true;
			this.idVenda.Location = new System.Drawing.Point(728, 44);
			this.idVenda.Name = "idVenda";
			this.idVenda.Size = new System.Drawing.Size(35, 13);
			this.idVenda.TabIndex = 9;
			this.idVenda.Text = "label2";
			this.idVenda.Visible = false;
			// 
			// FormMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.idVenda);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnEntregar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.listaVendas);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label1);
			this.Name = "FormMenu";
			this.Text = "FormMenu";
			this.Activated += new System.EventHandler(this.CarregaListaVendasFoco);
			((System.ComponentModel.ISupportInitialize)(this.listaVendas)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.DataGridView listaVendas;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnEntregar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label idVenda;
	}
}