namespace LojaDeMateriaisParaConstrucao.Telas.Pedido
{
    partial class FrmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedido));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(650, 206);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(473, 206);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 206);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(643, 230);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(477, 230);
            // 
            // label9
            // 
            this.label9.Size = new System.Drawing.Size(273, 36);
            this.label9.Text = "TOTAL DO PEDIDO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(802, 229);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.txtDest);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.SetChildIndex(this.label13, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtDest, 0);
            this.groupBox1.Controls.SetChildIndex(this.pictureBox5, 0);
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
            this.groupBox1.Controls.SetChildIndex(this.button2, 0);
            this.groupBox1.Controls.SetChildIndex(this.button4, 0);
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "Nome";
            this.comboBox2.Size = new System.Drawing.Size(384, 29);
            this.comboBox2.ValueMember = "CodigoFormaPgto";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.Size = new System.Drawing.Size(388, 29);
            this.comboBox1.ValueMember = "CodigoFormaPgto";
            // 
            // label12
            // 
            this.label12.Size = new System.Drawing.Size(273, 36);
            this.label12.Text = "TOTAL DO PEDIDO";
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Location = new System.Drawing.Point(7, 170);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(7, 146);
            // 
            // cbProduto
            // 
            this.cbProduto.DisplayMember = "Nome";
            this.cbProduto.Location = new System.Drawing.Point(7, 230);
            this.cbProduto.ValueMember = "CodigoProduto";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Click += new System.EventHandler(this.FinalizarPedido);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(439, 112);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 27);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.SelecionarDestinatario);
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(10, 112);
            this.txtDest.Name = "txtDest";
            this.txtDest.ReadOnly = true;
            this.txtDest.Size = new System.Drawing.Size(434, 27);
            this.txtDest.TabIndex = 26;
            this.txtDest.Click += new System.EventHandler(this.SelecionarDestinatario);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 21);
            this.label13.TabIndex = 25;
            this.label13.Text = "Destinatario";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(482, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 26);
            this.button2.TabIndex = 28;
            this.button2.Text = "Novo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1021, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.FinalizarPedido);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(802, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 100);
            this.button4.TabIndex = 29;
            this.button4.Text = "Finalizar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.FinalizarPedido);
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 781);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmPedido";
            this.Text = "FrmPedido";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.TextBox txtDest;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}