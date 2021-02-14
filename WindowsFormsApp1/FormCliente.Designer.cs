
namespace WindowsFormsApp1
{
	partial class FormCliente
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
			this.inputNome = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSalvaCliente = new System.Windows.Forms.Button();
			this.listaClientes = new System.Windows.Forms.DataGridView();
			this.labelId = new System.Windows.Forms.Label();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnNovoCliente = new System.Windows.Forms.Button();
			this.inputEmail = new System.Windows.Forms.TextBox();
			this.inputCelular = new System.Windows.Forms.MaskedTextBox();
			((System.ComponentModel.ISupportInitialize)(this.listaClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome";
			// 
			// inputNome
			// 
			this.inputNome.Location = new System.Drawing.Point(41, 69);
			this.inputNome.Name = "inputNome";
			this.inputNome.Size = new System.Drawing.Size(196, 20);
			this.inputNome.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(38, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Email";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(38, 153);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Celular";
			// 
			// btnSalvaCliente
			// 
			this.btnSalvaCliente.Location = new System.Drawing.Point(41, 266);
			this.btnSalvaCliente.Name = "btnSalvaCliente";
			this.btnSalvaCliente.Size = new System.Drawing.Size(196, 35);
			this.btnSalvaCliente.TabIndex = 6;
			this.btnSalvaCliente.Text = "Salvar Cliente";
			this.btnSalvaCliente.UseVisualStyleBackColor = true;
			this.btnSalvaCliente.Click += new System.EventHandler(this.SalvarCliente);
			// 
			// listaClientes
			// 
			this.listaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.listaClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.listaClientes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.listaClientes.Location = new System.Drawing.Point(308, 56);
			this.listaClientes.MultiSelect = false;
			this.listaClientes.Name = "listaClientes";
			this.listaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.listaClientes.Size = new System.Drawing.Size(501, 286);
			this.listaClientes.TabIndex = 7;
			this.listaClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarregaCliente);
			// 
			// labelId
			// 
			this.labelId.AutoSize = true;
			this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelId.Location = new System.Drawing.Point(37, 9);
			this.labelId.Name = "labelId";
			this.labelId.Size = new System.Drawing.Size(70, 24);
			this.labelId.TabIndex = 8;
			this.labelId.Text = "#Novo";
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(568, 372);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(241, 47);
			this.btnExcluir.TabIndex = 9;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseCompatibleTextRendering = true;
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Visible = false;
			this.btnExcluir.Click += new System.EventHandler(this.ExcluiCliente);
			// 
			// btnNovoCliente
			// 
			this.btnNovoCliente.Location = new System.Drawing.Point(41, 307);
			this.btnNovoCliente.Name = "btnNovoCliente";
			this.btnNovoCliente.Size = new System.Drawing.Size(196, 35);
			this.btnNovoCliente.TabIndex = 10;
			this.btnNovoCliente.Text = "Novo Cliente";
			this.btnNovoCliente.UseVisualStyleBackColor = true;
			this.btnNovoCliente.Visible = false;
			this.btnNovoCliente.Click += new System.EventHandler(this.NovoCliente);
			// 
			// inputEmail
			// 
			this.inputEmail.Location = new System.Drawing.Point(41, 119);
			this.inputEmail.Name = "inputEmail";
			this.inputEmail.Size = new System.Drawing.Size(196, 20);
			this.inputEmail.TabIndex = 3;
			// 
			// inputCelular
			// 
			this.inputCelular.Location = new System.Drawing.Point(41, 169);
			this.inputCelular.Mask = "(##) # ####-####";
			this.inputCelular.Name = "inputCelular";
			this.inputCelular.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.inputCelular.Size = new System.Drawing.Size(196, 20);
			this.inputCelular.TabIndex = 11;
			// 
			// FormCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(872, 450);
			this.Controls.Add(this.inputCelular);
			this.Controls.Add(this.btnNovoCliente);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.labelId);
			this.Controls.Add(this.listaClientes);
			this.Controls.Add(this.btnSalvaCliente);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.inputEmail);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.inputNome);
			this.Controls.Add(this.label1);
			this.Name = "FormCliente";
			this.Text = "Cadastro de Clientes";
			this.Load += new System.EventHandler(this.FormCliente_Load);
			((System.ComponentModel.ISupportInitialize)(this.listaClientes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox inputNome;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSalvaCliente;
		private System.Windows.Forms.DataGridView listaClientes;
		private System.Windows.Forms.Label labelId;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnNovoCliente;
		private System.Windows.Forms.TextBox inputEmail;
		private System.Windows.Forms.MaskedTextBox inputCelular;
	}
}

