namespace LojaDeMateriaisParaConstrucao.Telas.Listagem
{
    partial class FrmListagemFormaDePagamento
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
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(351, 22);
            this.label2.Size = new System.Drawing.Size(540, 45);
            this.label2.Text = "Listagem de Formas de pagamento";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(-8, 700);
            this.btnConsultar.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(568, 793);
            this.btnEditar.Click += new System.EventHandler(this.AbrirEdicao);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(803, 793);
            this.btnExcluir.Click += new System.EventHandler(this.Fixar);
            // 
            // btnAtivar
            // 
            this.btnAtivar.Location = new System.Drawing.Point(-8, 588);
            this.btnAtivar.Visible = false;
            // 
            // btnDesativar
            // 
            this.btnDesativar.Location = new System.Drawing.Point(-8, 644);
            this.btnDesativar.Visible = false;
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.Click += new System.EventHandler(this.Exibir);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 793);
            this.button1.Click += new System.EventHandler(this.NovaForma);
            // 
            // FrmListagemFormaDePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 879);
            this.Name = "FrmListagemFormaDePagamento";
            this.Text = "FrmListagemFormaDePagamento";
            this.Load += new System.EventHandler(this.Exibir);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}