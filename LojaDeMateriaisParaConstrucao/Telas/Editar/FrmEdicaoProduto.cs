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
    public partial class FrmEdicaoProduto : Cadastrar.FrmProduto
    {
        public FrmEdicaoProduto()
        {
            InitializeComponent();
            Cadastrar.FrmProduto f = new Cadastrar.FrmProduto();
            button1.Click -= f.CadastrarProduto;



        }
        public int Codigo;

        private void EditarProduto(object o, EventArgs e)
        {
            try          
            {
                


                imagem = Application.StartupPath.ToString() + "\\ImagensProdutos\\" + txtNome.Text + ".png";
                BLL.Produto p = new BLL.Produto();
                p.Nome = txtNome.Text;
                p.CodigoBarra = txtCodB.Text;
                p.Descricao = txtDesc.Text;
                p.DataEntrada = Convert.ToDateTime(txtDataEntrada.Text);
                p.Imagem = imagem;
                p.CodigoUnidadeVenda = Convert.ToInt32(cbUnidadeVenda.SelectedValue);
                p.CodigoCategoria = Convert.ToInt32(cbCategoria.SelectedValue);
                p.CodigoFornecedor = Convert.ToInt32(cbFornecedor.SelectedValue);
                p.Quantidade = Convert.ToInt16(txtQuant.Value);
                p.ValorUnit = Convert.ToDouble(txtValor.Text);
                p.EstoqueMaximo = Convert.ToInt16(txtEstqMax.Value);
                p.EstoqueMinimo = Convert.ToInt16(txtEstqMinimo.Value);
                p.Marca = txtMarca.Text;
                p.CodigoProduto = Codigo;
                p.AlterarComParametro();
                MessageBox.Show("Produto alterado com sucesso");
                Close();


            }
            catch (Exception ex)
            {

                throw ex;
            }






        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
