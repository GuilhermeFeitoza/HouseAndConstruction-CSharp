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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
            rbMasc.Checked = true;
        }

        BLL.FuncoesGerais fuc = new BLL.FuncoesGerais();
        BLL.CEP Correios = new BLL.CEP();



        private void Checardata(object o, EventArgs e) {
            
          
            //Validação da data 
            if (!BLL.FuncoesGerais.IsDataValida(txtData.Text))
            {
                MessageBox.Show("Data invalida");
                txtData.Clear();
                txtData.Focus();
                return;
            }



        }
        private void ChecarCPF(object o, EventArgs e) {

       


            if (!BLL.FuncoesGerais.IsCpf(txtCPF.Text))
            {
                MessageBox.Show("CPF invalido");
                txtCPF.Clear();
                txtCPF.Focus();
                
            }





        }

        private void VerificarCpfCadastrado()
        {
            TCC_Inf2Dm.ClasseParaManipularBancoDeDados c = new TCC_Inf2Dm.ClasseParaManipularBancoDeDados();

            int cpfCadastrado = 0;
            cpfCadastrado = c.RetornarExecuteScalar("SELECT COUNT(CodigoCliente)FROM tbCliente where Cpf ='" + txtCPF.Text + "'");

            if (cpfCadastrado > 0)
            {
                MessageBox.Show("Cpf já cadastrado no sistema ");
                txtCPF.Clear();
                txtCPF.Focus();
                return;
            }



        }
        private void VerificarRGCadastrado()
        {

            TCC_Inf2Dm.ClasseParaManipularBancoDeDados c = new TCC_Inf2Dm.ClasseParaManipularBancoDeDados();

            int rgCadastrado = 0;
            rgCadastrado = c.RetornarExecuteScalar("SELECT COUNT(CodigoCliente)FROM tbCliente where Rg ='" + txtRg.Text + "'");

            if (rgCadastrado > 0)
            {
                MessageBox.Show("RG já cadastrado no sistema ");
                txtRg.Clear();
                txtRg.Focus();
                return;
            }






        }
        private void ChecarEmail(object o , EventArgs e) {

   
            if (!BLL.FuncoesGerais.ValidarEmailRegEx(txtEmail.Text))
            {
                MessageBox.Show("Email Invalido!!!");
                txtEmail.Clear();
                txtEmail.Focus();
            }








        }

        private void Cadastrar(Object o, EventArgs e)
        {
            if (txtCPF.Text.Length >0)
            {
                VerificarCpfCadastrado();
                VerificarRGCadastrado();
              
            }
           

            if (txtNome.Text == "" || txtData.Text == "" || txtEndereco.Text == "" || txtBairro.Text == "" || txtCidade.Text == "" || txtComplemento.Text == "" || txtUF.Text == "" || txtRg.Text == "" || txtCPF.Text == "")
            {
                MessageBox.Show("Por favor prencha todos os dados!!");
            }
            else
            {
                //Declarando o valor dos membros
                BLL.Cliente cl = new BLL.Cliente();
                cl.Nome = txtNome.Text;
                cl.DataNascimento = Convert.ToDateTime(txtData.Text);
              

              
                //Declarando o valor dos membros
                cl.Endereco = txtEndereco.Text;
                cl.Bairro = txtBairro.Text;
                cl.Cidade = txtCidade.Text;
                cl.Complemento = txtComplemento.Text;
                cl.UF = txtUF.Text;
                cl.Rg = txtRg.Text;
                cl.Cpf = txtCPF.Text;
                //Definindo valor que vai ir para o banco de dados 
                if (rbFem.Checked)
                {
                    cl.Sexo = "f";

                }
                else
                {
                    cl.Sexo = "m";
                                    }
                
                cl.Telefone = txtTelefone.Text;
                cl.Email = txtEmail.Text;
                cl.StatusCliente = 1;
                cl.CEP = txtCEP.Text;
                cl.Numero = Convert.ToInt32(txtNumero.Text);
                cl.IncluirComParametro();

                MessageBox.Show("Cliente cadastrado");



                DialogResult dr = MessageBox.Show("Deseja Cadastrar outro cliente ?", "Cliente", MessageBoxButtons.YesNo);

                if (dr==DialogResult.Yes)
                {
                    txtNome.Clear();
                    txtData.Clear();
                    txtEndereco.Clear();
                    txtBairro.Clear();
                    txtCidade.Clear();
                    txtEmail.Clear();
                    txtTelefone.Clear();
                    txtNumero.Clear();
                    txtCEP.Clear();
                    txtUF.Clear();
                    txtComplemento.Clear();
                    txtRg.Clear();
                    txtCPF.Clear();
                    txtNome.Focus();
                    //Limpar text e colocar foco no txt nome

                }
                else                 {
                   Close();
                }
            }
            }

        


       

        private void BuscarEndereco(Object o, EventArgs e)
        {
            try
            {
                if (txtCEP.Text.Length == 0)
                {
                    MessageBox.Show("Por favor digite o cep");
                    return;
                }
                Correios.NumeroCep = txtCEP.Text;
                System.Data.SqlClient.SqlDataReader ddr;
                ddr = Correios.ConsultarCEP();
                ddr.Read();
                if (ddr.HasRows)
                {
                    txtEndereco.Text = Convert.ToString(ddr["Logradouro"]);
                    txtBairro.Text = Convert.ToString(ddr["Bairro"]);
                    txtCidade.Text = Convert.ToString(ddr["Cidade"]);
                    txtUF.Text = Convert.ToString(ddr["UF"]);
                    
                }
                else
                {
                    MessageBox.Show("Cep incorreto");
                    txtCEP.Clear();
                    txtCEP.Focus();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tCCDataSet.Estado' table. You can move, or remove it, as needed.
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
