
namespace WindowsFormsApp1
{
	partial class FormVenda
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
			this.labelIdVenda = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.valorTotal = new System.Windows.Forms.Label();
			this.labelVt = new System.Windows.Forms.Label();
			this.valorUnit = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnInserirItem = new System.Windows.Forms.Button();
			this.inputQuantidade = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.inputTipoQuentinha = new System.Windows.Forms.ComboBox();
			this.listaItens = new System.Windows.Forms.DataGridView();
			this.btnAnotarPedido = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.valorTotalVenda = new System.Windows.Forms.Label();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.inputValorFrete = new System.Windows.Forms.MaskedTextBox();
			this.labelVendaItemId = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.listaItens)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Venda - #";
			// 
			// labelIdVenda
			// 
			this.labelIdVenda.AutoSize = true;
			this.labelIdVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelIdVenda.Location = new System.Drawing.Point(128, 23);
			this.labelIdVenda.Name = "labelIdVenda";
			this.labelIdVenda.Size = new System.Drawing.Size(25, 25);
			this.labelIdVenda.TabIndex = 1;
			this.labelIdVenda.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Tipo Quentinha";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.valorTotal);
			this.groupBox1.Controls.Add(this.labelVt);
			this.groupBox1.Controls.Add(this.valorUnit);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.btnInserirItem);
			this.groupBox1.Controls.Add(this.inputQuantidade);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.inputTipoQuentinha);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(12, 86);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(250, 180);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Inserir Itens";
			// 
			// valorTotal
			// 
			this.valorTotal.AutoSize = true;
			this.valorTotal.Location = new System.Drawing.Point(147, 105);
			this.valorTotal.Name = "valorTotal";
			this.valorTotal.Size = new System.Drawing.Size(45, 13);
			this.valorTotal.TabIndex = 10;
			this.valorTotal.Text = "R$ 0,00";
			// 
			// labelVt
			// 
			this.labelVt.AutoSize = true;
			this.labelVt.Location = new System.Drawing.Point(147, 86);
			this.labelVt.Name = "labelVt";
			this.labelVt.Size = new System.Drawing.Size(58, 13);
			this.labelVt.TabIndex = 9;
			this.labelVt.Text = "Valor Total";
			// 
			// valorUnit
			// 
			this.valorUnit.AutoSize = true;
			this.valorUnit.Location = new System.Drawing.Point(147, 57);
			this.valorUnit.Name = "valorUnit";
			this.valorUnit.Size = new System.Drawing.Size(45, 13);
			this.valorUnit.TabIndex = 8;
			this.valorUnit.Text = "R$ 0,00";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(147, 38);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Valor Unit";
			// 
			// btnInserirItem
			// 
			this.btnInserirItem.Location = new System.Drawing.Point(6, 151);
			this.btnInserirItem.Name = "btnInserirItem";
			this.btnInserirItem.Size = new System.Drawing.Size(238, 23);
			this.btnInserirItem.TabIndex = 6;
			this.btnInserirItem.Text = "Confirmar";
			this.btnInserirItem.UseVisualStyleBackColor = true;
			this.btnInserirItem.Click += new System.EventHandler(this.InserirItem);
			// 
			// inputQuantidade
			// 
			this.inputQuantidade.Location = new System.Drawing.Point(6, 102);
			this.inputQuantidade.Name = "inputQuantidade";
			this.inputQuantidade.Size = new System.Drawing.Size(135, 20);
			this.inputQuantidade.TabIndex = 5;
			this.inputQuantidade.TextChanged += new System.EventHandler(this.CalculaValor);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Quantidade";
			// 
			// inputTipoQuentinha
			// 
			this.inputTipoQuentinha.FormattingEnabled = true;
			this.inputTipoQuentinha.Location = new System.Drawing.Point(6, 54);
			this.inputTipoQuentinha.Name = "inputTipoQuentinha";
			this.inputTipoQuentinha.Size = new System.Drawing.Size(135, 21);
			this.inputTipoQuentinha.TabIndex = 3;
			this.inputTipoQuentinha.SelectedIndexChanged += new System.EventHandler(this.CalculaValor);
			// 
			// listaItens
			// 
			this.listaItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.listaItens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.listaItens.Location = new System.Drawing.Point(294, 86);
			this.listaItens.Name = "listaItens";
			this.listaItens.Size = new System.Drawing.Size(469, 275);
			this.listaItens.TabIndex = 4;
			this.listaItens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelecionaItem);
			// 
			// btnAnotarPedido
			// 
			this.btnAnotarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAnotarPedido.Location = new System.Drawing.Point(17, 389);
			this.btnAnotarPedido.Name = "btnAnotarPedido";
			this.btnAnotarPedido.Size = new System.Drawing.Size(244, 40);
			this.btnAnotarPedido.TabIndex = 5;
			this.btnAnotarPedido.Text = "Anotar Pedido";
			this.btnAnotarPedido.UseVisualStyleBackColor = true;
			this.btnAnotarPedido.Click += new System.EventHandler(this.AnotarPedido);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(573, 400);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(96, 20);
			this.label8.TabIndex = 6;
			this.label8.Text = "Valor Total";
			// 
			// valorTotalVenda
			// 
			this.valorTotalVenda.AutoSize = true;
			this.valorTotalVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.valorTotalVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.valorTotalVenda.Location = new System.Drawing.Point(675, 396);
			this.valorTotalVenda.Name = "valorTotalVenda";
			this.valorTotalVenda.Size = new System.Drawing.Size(94, 25);
			this.valorTotalVenda.TabIndex = 7;
			this.valorTotalVenda.Text = "R$ 0,00";
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(294, 394);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(134, 35);
			this.btnExcluir.TabIndex = 8;
			this.btnExcluir.Text = "Excluir Item";
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Visible = false;
			this.btnExcluir.Click += new System.EventHandler(this.ExcluirItem);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(18, 304);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Taxa Entrega";
			// 
			// inputValorFrete
			// 
			this.inputValorFrete.Location = new System.Drawing.Point(21, 320);
			this.inputValorFrete.Mask = "$ 999.00";
			this.inputValorFrete.Name = "inputValorFrete";
			this.inputValorFrete.Size = new System.Drawing.Size(132, 20);
			this.inputValorFrete.TabIndex = 10;
			this.inputValorFrete.TextChanged += new System.EventHandler(this.CarregaValorVenda);
			// 
			// labelVendaItemId
			// 
			this.labelVendaItemId.AutoSize = true;
			this.labelVendaItemId.Location = new System.Drawing.Point(706, 44);
			this.labelVendaItemId.Name = "labelVendaItemId";
			this.labelVendaItemId.Size = new System.Drawing.Size(35, 13);
			this.labelVendaItemId.TabIndex = 11;
			this.labelVendaItemId.Text = "label6";
			this.labelVendaItemId.Visible = false;
			// 
			// FormVenda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.labelVendaItemId);
			this.Controls.Add(this.inputValorFrete);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.valorTotalVenda);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnAnotarPedido);
			this.Controls.Add(this.listaItens);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.labelIdVenda);
			this.Controls.Add(this.label1);
			this.Name = "FormVenda";
			this.Text = "FormVenda";
			this.Load += new System.EventHandler(this.FormVenda_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.listaItens)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelIdVenda;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label valorTotal;
		private System.Windows.Forms.Label labelVt;
		private System.Windows.Forms.Label valorUnit;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnInserirItem;
		private System.Windows.Forms.TextBox inputQuantidade;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox inputTipoQuentinha;
		private System.Windows.Forms.DataGridView listaItens;
		private System.Windows.Forms.Button btnAnotarPedido;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label valorTotalVenda;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.MaskedTextBox inputValorFrete;
		private System.Windows.Forms.Label labelVendaItemId;
	}
}