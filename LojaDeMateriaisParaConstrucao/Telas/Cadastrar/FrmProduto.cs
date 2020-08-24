using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDeMateriaisParaConstrucao.Telas.Cadastrar
{
    public partial class FrmProduto : Modelos.FrmCabeçalhoECorp

    {
        public String imagem;
        public FrmProduto()
        {
            InitializeComponent();
        }



        public void SalvarFoto(object o, EventArgs e)
        {


            if (txtNome.Text =="")
            {

                MessageBox.Show("Insira um nome para o produto");
                txtNome.Focus();
                return;


            }
               
            try
            {
                openFileDialog1.ShowDialog();
                Bitmap bmp = new Bitmap(openFileDialog1.FileName);
                Bitmap bmp2 = new Bitmap(bmp, pictureBox1.Size);
                pcbFoto.Image = bmp2;
                string CaminhoSite = @"Z:\PROJETO HAC\HAC-18-10\HouseAndConstruction\LojaMateriaisParaConstrucao\Content\img\";
                pcbFoto.Image.Save(CaminhoSite+ txtNome.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
                pcbFoto.Image.Save(Application.StartupPath.ToString() + "\\ImagensProdutos\\" + txtNome.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);

               //imagem = openFileDialog1.FileName;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Inserir imagem : " + erro);
            }
        }
        public void CadastrarProduto(object o, EventArgs e)
        {
            try
            {

                //imagem = Application.StartupPath.ToString() + "\\ImagensProdutos\\" + txtNome.Text + ".png";
                imagem = @"~\Content\img\" + txtNome.Text + ".png";
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
                
                p.IncluirComParametro();
                p.NovoEstoque();
                MessageBox.Show("Produto cadastrado com sucesso!!");
                DialogResult dr = MessageBox.Show("Deseja Cadastrar outro produto ?", "Produto", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    txtCodB.Clear();
                    txtNome.Clear();
                    txtDesc.Clear();
                    openFileDialog1.Reset();
                    //Limpar text e colocar foco no txt nome

                }
                else
                {
                    Telas.Listagem.FrmListagemProdutos pro = new Listagem.FrmListagemProdutos();
                    Dispose();
                    pro.ShowDialog();


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }

        }

        private void CarregarCombos(object o, EventArgs e)
        {

            BLL.Categoria c = new BLL.Categoria();

            cbCategoria.DataSource = c.Listar(String.Empty, (byte)BLL.FuncoesGerais.TipoStatus.Ativo).Tables[0];
            cbCategoria.DisplayMember = "NomeCategoria";
            cbCategoria.ValueMember = "CodigoCategoria";

            BLL.UnidadeVenda u = new BLL.UnidadeVenda();
            cbUnidadeVenda.DataSource = u.Listar(String.Empty, (byte)BLL.FuncoesGerais.TipoStatus.Ativo).Tables[0];
            cbUnidadeVenda.DisplayMember = "Abreviacao";
            cbUnidadeVenda.ValueMember = "CodigoUnidadeVenda";

            BLL.Fornecedor f = new BLL.Fornecedor();
            cbFornecedor.DataSource = f.Listar(String.Empty, (byte)BLL.FuncoesGerais.TipoStatus.Ativo).Tables[0];
            cbFornecedor.ValueMember = "CodigoFornecedor";
            cbFornecedor.DisplayMember = "NomeFantasia";















        }



        private void Checardata(object o, EventArgs e)
        {


            //Validação da data 
            if (!BLL.FuncoesGerais.IsDataValida(txtDataEntrada.Text))
            {
                MessageBox.Show("Data invalida");
                txtDataEntrada.Clear();
                txtDataEntrada.Focus();
                return;
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }



   
        
    }

