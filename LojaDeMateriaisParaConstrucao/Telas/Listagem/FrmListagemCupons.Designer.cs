namespace LojaDeMateriaisParaConstrucao.Telas.Listagem
{
    partial class FrmListagemCupons
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
            this.label2.Location = new System.Drawing.Point(331, 18);
            this.label2.Size = new System.Drawing.Size(246, 36);
            this.label2.Text = "Listagem de cupons";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(1, 533);
            this.btnConsultar.Size = new System.Drawing.Size(75, 39);
            this.btnConsultar.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(338, 650);
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(1, 533);
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtivar
            // 
            this.btnAtivar.Location = new System.Drawing.Point(506, 650);
            // 
            // btnDesativar
            // 
            this.btnDesativar.Location = new System.Drawing.Point(639, 650);
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.Click += new System.EventHandler(this.Exibir);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 650);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(179, 23);
            this.label1.Text = "Pesquisar por código:";
            // 
            // FrmListagemCupons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 701);
            this.Name = "FrmListagemCupons";
            this.Text = "FrmListagemCupons";
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