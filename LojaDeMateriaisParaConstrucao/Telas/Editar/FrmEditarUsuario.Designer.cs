namespace LojaDeMateriaisParaConstrucao.Telas.Editar
{
    partial class FrmEditarUsuario
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
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.Text = "Editar Usuário";
            // 
            // txtSenha
            // 
            this.txtSenha.PasswordChar = '\0';
            // 
            // txtSenha2
            // 
            this.txtSenha2.Location = new System.Drawing.Point(137, 119);
            this.txtSenha2.Visible = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Visible = false;
            // 
            // button1
            // 
            this.button1.Text = "Editar";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 264);
            this.Name = "FrmEditarUsuario";
            this.Text = "FrmEditarUsuario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}