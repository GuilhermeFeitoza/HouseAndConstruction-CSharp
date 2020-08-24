using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDeMateriaisParaConstrucao.Telas.Contas_a_pagar
{
    public partial class FrmCadastroLançamentoDeContas : Form
    {
        public FrmCadastroLançamentoDeContas()
        {
            InitializeComponent();
            
            cboConta.SelectedItem = null;
          


        }


        private void Checardata(object o, EventArgs e)
        {


            //Validação da data 
            if (!BLL.FuncoesGerais.IsDataValida(txtData.Text))
            {
                MessageBox.Show("Data invalida");
                txtData.Clear();
                txtData.Focus();
                return;
            }



        }


        private void SalvarConta(object o , EventArgs e) {
            try
            {
                              
            
                BLL.Lancamento l = new BLL.Lancamento();
                l.CodigoTitulo = Convert.ToInt16(cboConta.SelectedValue);
                l.ValorTitulo = Convert.ToDouble(txtValor.Text);
                l.DataVencimento = Convert.ToDateTime(txtData.Text);
                l.CodigoUsuario = BLL.Session.Instance.UserID;
                //l.DataPagamento = Convert.ToDateTime(txtDataP.Text);
                l.StatusPagTitulo = 0;
               

            
                 if (numVezes.Value == 1)
                {
                    l.Incluir();
                    MessageBox.Show("Conta cadastrada com sucesso!!");
                    DialogResult dr = MessageBox.Show("Deseja Cadastrar outra conta ?", "Contas a pagar", MessageBoxButtons.YesNo);

                    if (dr == DialogResult.Yes)
                    {
                        txtData.Clear();

                        CarregarCombo(o,e);
                        //txtDataP.Clear();
                        txtValor.Clear();
                       
                        //Limpar text e colocar foco no txt nome

                    }
                    else
                    {
                        Telas.Contas_a_pagar.FrmGestaoDeContasAPagar c = new FrmGestaoDeContasAPagar();
                        Dispose();
                        c.ShowDialog();
                     
                       
                    }
                }
                else
                {
                    for (int i = 0; i <= numVezes.Value; i++)
                    {
                        l.Incluir();
                        l.DataVencimento = Convert.ToDateTime(txtData.Text).AddMonths(i + 1);
                    }
                }
              
              
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
           


        }
        private void CarregarGrid(object o  , EventArgs e )
        {
            BLL.Lancamento l = new BLL.Lancamento();
            dataGridView1.DataSource = l.ListarTitulosEmAberto(Convert.ToInt32(cboConta.SelectedValue)).Tables[0];
            dataGridView1.AutoResizeColumns();

        }

        private void CarregarCombo(object o, EventArgs e)
        {
                       
            BLL.Titulo c = new BLL.Titulo();
                   

            cboConta.DataSource = c.Listar(String.Empty, (byte)BLL.FuncoesGerais.TipoStatus.Ativo).Tables[0];
            cboConta.DisplayMember = "DescricaoTitulo";
            cboConta.ValueMember = "CodigoTitulo";
            CarregarGrid(o,e);
        }
        private void Sair(object o, EventArgs e) {

            Close();



        }

     

       

      
           
    }
}
