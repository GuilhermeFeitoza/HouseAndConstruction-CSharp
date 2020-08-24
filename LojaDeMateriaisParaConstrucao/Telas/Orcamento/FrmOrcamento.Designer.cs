namespace LojaDeMateriaisParaConstrucao.Telas.Orcamento
{
    partial class FrmOrcamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrcamento));
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // lblValorTotalDaVenda
            // 
            this.lblValorTotalDaVenda.Location = new System.Drawing.Point(58, 49);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(87, 10);
            this.label9.Size = new System.Drawing.Size(355, 36);
            this.label9.Text = "TOTAL DO ORÇAMENTO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.SetChildIndex(this.button1, 0);
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtVendedor, 0);
            this.groupBox1.Controls.SetChildIndex(this.label3, 0);
            this.groupBox1.Controls.SetChildIndex(this.label4, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtQuantidade, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtTotal, 0);
            this.groupBox1.Controls.SetChildIndex(this.label5, 0);
            this.groupBox1.Controls.SetChildIndex(this.label6, 0);
            this.groupBox1.Controls.SetChildIndex(this.label8, 0);
            this.groupBox1.Controls.SetChildIndex(this.pictureBox2, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtCliente, 0);
            this.groupBox1.Controls.SetChildIndex(this.cbProduto, 0);
            this.groupBox1.Controls.SetChildIndex(this.pictureBox3, 0);
            this.groupBox1.Controls.SetChildIndex(this.pictureBox4, 0);
            this.groupBox1.Controls.SetChildIndex(this.label11, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtCodBarras, 0);
            this.groupBox1.Controls.SetChildIndex(this.button3, 0);
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "CodigoFormaPgto";
            this.comboBox2.Size = new System.Drawing.Size(384, 29);
            this.comboBox2.ValueMember = "CodigoFormaPgto";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "CodigoFormaPgto";
            this.comboBox1.Size = new System.Drawing.Size(388, 29);
            this.comboBox1.ValueMember = "CodigoFormaPgto";
            // 
            // lblTotalVenda2
            // 
            this.lblTotalVenda2.Location = new System.Drawing.Point(86, 69);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(114, 10);
            this.label12.Size = new System.Drawing.Size(355, 36);
            this.label12.Text = "TOTAL DO ORÇAMENTO";
            // 
            // cbProduto
            // 
            this.cbProduto.DisplayMember = "Nome";
            this.cbProduto.ValueMember = "CodigoProduto";
            // 
            // groupBox3
            // 
            this.groupBox3.Size = new System.Drawing.Size(584, 231);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(1212, 773);
            this.btnFinalizar.Text = "Finalizar Orçamento";
            this.btnFinalizar.Click += new System.EventHandler(this.GerarPDF3);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(807, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 57);
            this.button3.TabIndex = 25;
            this.button3.Text = "Finalizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.FinalizarOrcamento);
            // 
            // FrmOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1364, 749);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmOrcamento";
            this.Text = "Gerar Orçamento";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}