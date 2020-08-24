namespace LojaDeMateriaisParaConstrucao.Telas.Listagem
{
    partial class FrmListagemCategoria
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
            this.label2.Location = new System.Drawing.Point(308, 18);
            this.label2.Size = new System.Drawing.Size(284, 36);
            this.label2.Text = "Listagem de categorias";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Click += new System.EventHandler(this.ConsultarCategoria);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Click += new System.EventHandler(this.Fixar);
            // 
            // btnAtivar
            // 
            this.btnAtivar.Location = new System.Drawing.Point(578, 653);
            this.btnAtivar.Click += new System.EventHandler(this.Fixar);
            // 
            // btnDesativar
            // 
            this.btnDesativar.Location = new System.Drawing.Point(681, 653);
            this.btnDesativar.Click += new System.EventHandler(this.Fixar);
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.Click += new System.EventHandler(this.Exibir);
            // 
            // button1
            // 
            this.button1.Click += new System.EventHandler(this.CadastrarCategoria);
            // 
            // FrmListagemCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 714);
            this.Name = "FrmListagemCategoria";
            this.Text = "Listagem de Categorias";
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