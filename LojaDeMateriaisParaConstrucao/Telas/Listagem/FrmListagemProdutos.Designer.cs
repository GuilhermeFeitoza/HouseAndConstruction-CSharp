namespace LojaDeMateriaisParaConstrucao.Telas.Listagem
{
    partial class FrmListagemProdutos
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
            this.label2.Location = new System.Drawing.Point(327, 20);
            this.label2.Size = new System.Drawing.Size(269, 36);
            this.label2.Text = "Listagem de Produtos";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(307, 653);
            this.btnConsultar.Click += new System.EventHandler(this.ConsultarProduto);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(425, 653);
            this.btnEditar.Click += new System.EventHandler(this.EditarProduto);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.Fixar);
            // 
            // btnAtivar
            // 
            this.btnAtivar.Location = new System.Drawing.Point(537, 653);
            this.btnAtivar.Click += new System.EventHandler(this.Fixar);
            // 
            // btnDesativar
            // 
            this.btnDesativar.Location = new System.Drawing.Point(641, 653);
            this.btnDesativar.Click += new System.EventHandler(this.Fixar);
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.Click += new System.EventHandler(this.Exibir);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 653);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmListagemProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 719);
            this.Name = "FrmListagemProdutos";
            this.Text = "Listagem de Produtos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}