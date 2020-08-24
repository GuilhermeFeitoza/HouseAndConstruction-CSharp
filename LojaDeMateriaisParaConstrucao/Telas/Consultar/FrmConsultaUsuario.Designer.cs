namespace LojaDeMateriaisParaConstrucao.Telas.Consultar
{
    partial class FrmConsultaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaUsuario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(329, 8);
            this.label2.Size = new System.Drawing.Size(265, 36);
            this.label2.Text = "Listagem de Usuarios";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Size = new System.Drawing.Size(80, 39);
            this.btnConsultar.Click += new System.EventHandler(this.ConsultarUsuario);
            // 
            // btnEditar
            // 
            this.btnEditar.Click += new System.EventHandler(this.EditarUsuario);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(460, 653);
            this.btnExcluir.Click += new System.EventHandler(this.Fixar);
            // 
            // btnAtivar
            // 
            this.btnAtivar.Location = new System.Drawing.Point(553, 653);
            this.btnAtivar.Click += new System.EventHandler(this.Fixar);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.pictureBox1, 0);
            // 
            // btnDesativar
            // 
            this.btnDesativar.Location = new System.Drawing.Point(643, 653);
            this.btnDesativar.Size = new System.Drawing.Size(79, 39);
            this.btnDesativar.Click += new System.EventHandler(this.Fixar);
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.Click += new System.EventHandler(this.Exibir);
            // 
            // button1
            // 
            this.button1.Click += new System.EventHandler(this.NovoUsuario);
            // 
            // rbInativos
            // 
           // this.rbInativos.Click += new System.EventHandler(this.ExibirInativos);
            // 
            // rbTodos
            // 
           // this.rbTodos.Click += new System.EventHandler(this.Exibir);
            // 
            // rbAtivos
            // 
           // this.rbAtivos.Click += new System.EventHandler(this.ExibirAtivos);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // FrmConsultaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 701);
            this.Name = "FrmConsultaUsuario";
            this.Text = "Consulta de Usuário";
            this.Load += new System.EventHandler(this.Exibir);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}