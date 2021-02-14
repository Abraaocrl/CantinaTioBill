
namespace WindowsFormsApp1
{
	partial class FormTipoQuentinha
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
			this.btnNovoTipoQuentinha = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.labelId = new System.Windows.Forms.Label();
			this.listaClientes = new System.Windows.Forms.DataGridView();
			this.btnSalvaTipoQuentinha = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.inputDescricao = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.inputValor = new System.Windows.Forms.MaskedTextBox();
			((System.ComponentModel.ISupportInitialize)(this.listaClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// btnNovoTipoQuentinha
			// 
			this.btnNovoTipoQuentinha.Location = new System.Drawing.Point(18, 318);
			this.btnNovoTipoQuentinha.Name = "btnNovoTipoQuentinha";
			this.btnNovoTipoQuentinha.Size = new System.Drawing.Size(196, 35);
			this.btnNovoTipoQuentinha.TabIndex = 21;
			this.btnNovoTipoQuentinha.Text = "Novo Tipo Quentinha";
			this.btnNovoTipoQuentinha.UseVisualStyleBackColor = true;
			this.btnNovoTipoQuentinha.Visible = false;
			this.btnNovoTipoQuentinha.Click += new System.EventHandler(this.NovoTipo);
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(545, 383);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(241, 47);
			this.btnExcluir.TabIndex = 20;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseCompatibleTextRendering = true;
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Visible = false;
			this.btnExcluir.Click += new System.EventHandler(this.ExcluiTipo);
			// 
			// labelId
			// 
			this.labelId.AutoSize = true;
			this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelId.Location = new System.Drawing.Point(14, 20);
			this.labelId.Name = "labelId";
			this.labelId.Size = new System.Drawing.Size(70, 24);
			this.labelId.TabIndex = 19;
			this.labelId.Text = "#Novo";
			// 
			// listaClientes
			// 
			this.listaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.listaClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.listaClientes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.listaClientes.Location = new System.Drawing.Point(285, 67);
			this.listaClientes.MultiSelect = false;
			this.listaClientes.Name = "listaClientes";
			this.listaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.listaClientes.Size = new System.Drawing.Size(501, 286);
			this.listaClientes.TabIndex = 18;
			this.listaClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarregaTipo);
			// 
			// btnSalvaTipoQuentinha
			// 
			this.btnSalvaTipoQuentinha.Location = new System.Drawing.Point(18, 277);
			this.btnSalvaTipoQuentinha.Name = "btnSalvaTipoQuentinha";
			this.btnSalvaTipoQuentinha.Size = new System.Drawing.Size(196, 35);
			this.btnSalvaTipoQuentinha.TabIndex = 17;
			this.btnSalvaTipoQuentinha.Text = "Salvar Tipo de Quentinha";
			this.btnSalvaTipoQuentinha.UseVisualStyleBackColor = true;
			this.btnSalvaTipoQuentinha.Click += new System.EventHandler(this.SalvarTipo);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "Valor";
			// 
			// inputDescricao
			// 
			this.inputDescricao.Location = new System.Drawing.Point(18, 80);
			this.inputDescricao.Name = "inputDescricao";
			this.inputDescricao.Size = new System.Drawing.Size(196, 20);
			this.inputDescricao.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Descrição";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// inputValor
			// 
			this.inputValor.Location = new System.Drawing.Point(18, 129);
			this.inputValor.Mask = "$ 999.00";
			this.inputValor.Name = "inputValor";
			this.inputValor.Size = new System.Drawing.Size(196, 20);
			this.inputValor.TabIndex = 22;
			// 
			// FormTipoQuentinha
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.inputValor);
			this.Controls.Add(this.btnNovoTipoQuentinha);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.labelId);
			this.Controls.Add(this.listaClientes);
			this.Controls.Add(this.btnSalvaTipoQuentinha);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.inputDescricao);
			this.Controls.Add(this.label1);
			this.Name = "FormTipoQuentinha";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "FormTipoQuentinha";
			((System.ComponentModel.ISupportInitialize)(this.listaClientes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnNovoTipoQuentinha;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Label labelId;
		private System.Windows.Forms.DataGridView listaClientes;
		private System.Windows.Forms.Button btnSalvaTipoQuentinha;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox inputDescricao;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MaskedTextBox inputValor;
	}
}