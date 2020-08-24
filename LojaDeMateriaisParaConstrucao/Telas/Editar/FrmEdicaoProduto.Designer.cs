namespace LojaDeMateriaisParaConstrucao.Telas.Editar
{
    partial class FrmEdicaoProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEdicaoProduto));
            this.txtEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstqMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstqMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuant)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Size = new System.Drawing.Size(236, 45);
            this.label5.Text = "Editar Produto";
            // 
            // txtNome
            // 
            this.txtNome.Margin = new System.Windows.Forms.Padding(5);
            // 
            // txtDesc
            // 
            this.txtDesc.Margin = new System.Windows.Forms.Padding(5);
            // 
            // txtCodB
            // 
            this.txtCodB.Margin = new System.Windows.Forms.Padding(5);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(527, 316);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(5);
            // 
            // cbCategoria
            // 
            this.cbCategoria.DisplayMember = "NomeCategoria";
            this.cbCategoria.ValueMember = "CodigoCategoria";
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.DisplayMember = "NomeFantasia";
            this.cbFornecedor.ValueMember = "CodigoFornecedor";
            // 
            // cbUnidadeVenda
            // 
            this.cbUnidadeVenda.DisplayMember = "Abreviacao";
            this.cbUnidadeVenda.ValueMember = "CodigoUnidadeVenda";
            // 
            // txtEstqMax
            // 
            this.txtEstqMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // txtEstqMinimo
            // 
            this.txtEstqMinimo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // txtQuant
            // 
            this.txtQuant.Visible = false;
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Margin = new System.Windows.Forms.Padding(5);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(929, 405);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Visible = false;
            // 
            // button2
            // 
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtValor
            // 
            this.txtValor.Margin = new System.Windows.Forms.Padding(5);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEditar);
            this.groupBox1.Controls.SetChildIndex(this.label1, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtValor, 0);
            this.groupBox1.Controls.SetChildIndex(this.pcbFoto, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtNome, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtQuant, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtDataEntrada, 0);
            this.groupBox1.Controls.SetChildIndex(this.cbUnidadeVenda, 0);
            this.groupBox1.Controls.SetChildIndex(this.cbFornecedor, 0);
            this.groupBox1.Controls.SetChildIndex(this.cbCategoria, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtDesc, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtEstqMinimo, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtEstqMax, 0);
            this.groupBox1.Controls.SetChildIndex(this.button1, 0);
            this.groupBox1.Controls.SetChildIndex(this.button2, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtCodB, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtMarca, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtEditar, 0);
            // 
            // txtEditar
            // 
            this.txtEditar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtEditar.Location = new System.Drawing.Point(929, 405);
            this.txtEditar.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditar.Name = "txtEditar";
            this.txtEditar.Size = new System.Drawing.Size(200, 58);
            this.txtEditar.TabIndex = 38;
            this.txtEditar.Text = "Editar";
            this.txtEditar.UseVisualStyleBackColor = false;
            this.txtEditar.Click += new System.EventHandler(this.EditarProduto);
            // 
            // FrmEdicaoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 592);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FrmEdicaoProduto";
            this.Text = "Editar produto";
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstqMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstqMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuant)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button txtEditar;
    }
}