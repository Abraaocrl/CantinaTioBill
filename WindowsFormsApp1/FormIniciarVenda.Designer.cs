
namespace WindowsFormsApp1
{
	partial class FormIniciarVenda
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
			this.label2 = new System.Windows.Forms.Label();
			this.inputCliente = new System.Windows.Forms.ComboBox();
			this.btnCriarCliente = new System.Windows.Forms.Button();
			this.btnIniciarVenda = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(7, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Iniciar Venda";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(9, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Cliente";
			// 
			// inputCliente
			// 
			this.inputCliente.FormattingEnabled = true;
			this.inputCliente.Location = new System.Drawing.Point(12, 122);
			this.inputCliente.Name = "inputCliente";
			this.inputCliente.Size = new System.Drawing.Size(316, 21);
			this.inputCliente.TabIndex = 2;
			// 
			// btnCriarCliente
			// 
			this.btnCriarCliente.Location = new System.Drawing.Point(279, 94);
			this.btnCriarCliente.Name = "btnCriarCliente";
			this.btnCriarCliente.Size = new System.Drawing.Size(49, 22);
			this.btnCriarCliente.TabIndex = 3;
			this.btnCriarCliente.Text = "Criar";
			this.btnCriarCliente.UseVisualStyleBackColor = true;
			this.btnCriarCliente.Click += new System.EventHandler(this.AbrirFormCliente);
			// 
			// btnIniciarVenda
			// 
			this.btnIniciarVenda.Location = new System.Drawing.Point(12, 191);
			this.btnIniciarVenda.Name = "btnIniciarVenda";
			this.btnIniciarVenda.Size = new System.Drawing.Size(316, 49);
			this.btnIniciarVenda.TabIndex = 4;
			this.btnIniciarVenda.Text = "Confirmar";
			this.btnIniciarVenda.UseVisualStyleBackColor = true;
			this.btnIniciarVenda.Click += new System.EventHandler(this.IniciarVenda);
			// 
			// FormIniciarVenda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(340, 252);
			this.Controls.Add(this.btnIniciarVenda);
			this.Controls.Add(this.btnCriarCliente);
			this.Controls.Add(this.inputCliente);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormIniciarVenda";
			this.Text = "FormIniciarVenda";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox inputCliente;
		private System.Windows.Forms.Button btnCriarCliente;
		private System.Windows.Forms.Button btnIniciarVenda;
	}
}