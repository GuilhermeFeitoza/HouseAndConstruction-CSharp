namespace LojaDeMateriaisParaConstrucao.Telas.Editar
{
    partial class FrmEdicaoFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEdicaoFuncionario));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceitar
            // 
            this.btnAceitar.Text = "Editar";
            this.btnAceitar.Click += new System.EventHandler(this.EditandoFuncionario);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.Text = "Editar Funcionário";
            // 
            // cbCargo
            // 
            this.cbCargo.DisplayMember = "NomeCargo";
            this.cbCargo.ValueMember = "CodigoCargo";
            // 
            // FrmEdicaoFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 602);
            this.Name = "FrmEdicaoFuncionario";
            this.Text = "FrmEdicaoFuncionario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}