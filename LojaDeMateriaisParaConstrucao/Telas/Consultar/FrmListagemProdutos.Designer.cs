namespace LojaDeMateriaisParaConstrucao.Telas.Consultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListagemProdutos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbAtivos = new System.Windows.Forms.CheckBox();
            this.cbInativos = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(309, 22);
            this.label2.Size = new System.Drawing.Size(269, 36);
            this.label2.Text = "Listagem de produtos";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Click += new System.EventHandler(this.ConsultarProduto);
            // 
            // btnEditar
            // 
            this.btnEditar.Click += new System.EventHandler(this.EditarProduto);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(477, 653);
            this.btnExcluir.Click += new System.EventHandler(this.Fixar);
            // 
            // btnAtivar
            // 
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
            this.btnDesativar.Click += new System.EventHandler(this.Fixar);
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.Click += new System.EventHandler(this.Exibir);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAtivos);
            this.groupBox1.Controls.Add(this.cbInativos);
            this.groupBox1.Controls.SetChildIndex(this.textBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnfiltrar, 0);
            this.groupBox1.Controls.SetChildIndex(this.cbInativos, 0);
            this.groupBox1.Controls.SetChildIndex(this.cbAtivos, 0);
            // 
            // button1
            // 
            this.button1.Click += new System.EventHandler(this.CadastrarNovo);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // cbAtivos
            // 
            this.cbAtivos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAtivos.Location = new System.Drawing.Point(551, 103);
            this.cbAtivos.Name = "cbAtivos";
            this.cbAtivos.Size = new System.Drawing.Size(70, 23);
            this.cbAtivos.TabIndex = 14;
            this.cbAtivos.Text = "Ativos";
            this.cbAtivos.UseVisualStyleBackColor = true;
            // 
            // cbInativos
            // 
            this.cbInativos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInativos.Location = new System.Drawing.Point(637, 103);
            this.cbInativos.Name = "cbInativos";
            this.cbInativos.Size = new System.Drawing.Size(81, 23);
            this.cbInativos.TabIndex = 15;
            this.cbInativos.Text = "Inativos";
            this.cbInativos.UseVisualStyleBackColor = true;
            // 
            // FrmListagemProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 701);
            this.Name = "FrmListagemProdutos";
            this.Text = "FrmListagemProdutos";
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
        private System.Windows.Forms.CheckBox cbAtivos;
        private System.Windows.Forms.CheckBox cbInativos;
    }
}