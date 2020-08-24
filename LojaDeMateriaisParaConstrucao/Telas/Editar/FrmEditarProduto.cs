using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDeMateriaisParaConstrucao.Telas.Editar
{
    public partial class FrmEditarProduto : Cadastrar.FrmProduto

    {
        public FrmEditarProduto()
        {
            InitializeComponent();
        }

       private void EditarProduto(object o , EventArgs e) {

            BLL.Produto p = new BLL.Produto();
            p.CodigoProduto = Convert.ToInt32(txtCodigo.Text);
            p.Nome = Convert.ToString(txtNomeProduto.Text);
            p.ValorUnit = Convert.ToDecimal(txtValor.Text);
            p.CodigoCategoria = Convert.ToInt32(cbCategoria.SelectedValue);
            p.CodigoFornecedor = Convert.ToInt32(cbFornecedor.SelectedValue);
            p.CodigoUnidadeVenda = Convert.ToInt32(cbUnidadeVenda.SelectedValue);
            p.AlterarComParametro();
            MessageBox.Show("Produto Alterado!!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
