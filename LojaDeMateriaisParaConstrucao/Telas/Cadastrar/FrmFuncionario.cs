using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LojaDeMateriaisParaConstrucao.Telas.Cadastrar
{
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
         
            
        }
        public String imagem;

        private void CadastrarFuncionario(object o , EventArgs e) {

            try
            {
                BLL.Funcionario f = new BLL.Funcionario();
                f.Nome = txtNome.Text;
                f.CPF = txtCPF.Text;
                f.DataNascimento = Convert.ToDateTime(txtData.Text);
                if (rbFem.Checked)
                {
                    f.Sexo = "f";
                }
                else
                {
                    f.Sexo = "m";
                }
                f.RG = txtRg.Text;
                f.DataNascimento = Convert.ToDateTime(txtData.Text);
                f.Telefone = txtTelefone.Text;
                f.Email = txtEmail.Text;
                f.CEP = txtCEP.Text;
                f.Complemento = txtComplemento.Text;
                f.Numero = Convert.ToInt32(txtNumero.Text);
                f.CodigoCargo = Convert.ToInt32(cbCargo.SelectedValue);
                f.Salario = Convert.ToDouble(txtSalario.Text);
                f.StatusFuncionario = 1;
                f.DataAdmissao = Convert.ToDateTime(txtDataAdm.Text);
                f.Foto = imagem;
                f.IncluirComParametro();
               
                MessageBox.Show("Funcionario cadastrado com sucesso!!!!");

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        private void CarregarCombo(object o, EventArgs e) {

            BLL.Cargo c = new BLL.Cargo();

            cbCargo.DataSource = c.Listar(String.Empty, (byte)BLL.FuncoesGerais.TipoStatus.Ativo).Tables[0];
            cbCargo.DisplayMember = "NomeCargo";
            cbCargo.ValueMember = "CodigoCargo";
           





        }
        public void BuscarEndereco(Object o, EventArgs e)
        {
            try
            {
                BLL.CEP Correios = new BLL.CEP();
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
                    cbUF.Text = Convert.ToString(ddr["UF"]);

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


        public void SalvarFoto(object o, EventArgs e)
        {


            if (txtNome.Text == "")
            {

                MessageBox.Show("Insira um nome para o produto");
                txtNome.Focus();
                return;


            }

            try
            {
                openFileDialog1.ShowDialog();
                Bitmap bmp = new Bitmap(openFileDialog1.FileName);
                Bitmap bmp2 = new Bitmap(bmp, pcbFoto.Size);
                pcbFoto.Image = bmp2;
                pcbFoto.Image.Save(Application.StartupPath.ToString() + "\\ImagensProdutos\\" + txtNome.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
                imagem = openFileDialog1.FileName;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Inserir imagem : " + erro);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

