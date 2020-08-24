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
    public partial class FrmEdicaorFuncionario : Form
    {
        public FrmEdicaorFuncionario()
        {
            InitializeComponent();
        }

        public string imagem;

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




        public void BuscarEndereco(Object o, EventArgs e)
        {

            BLL.CEP Correios = new BLL.CEP();
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
        private void EditandoFuncionario(object o, EventArgs e)
        {
            try
            {
                Telas.Consultar.FrmListagemFuncionario n = new Telas.Consultar.FrmListagemFuncionario();
                BLL.Funcionario Fcu = new BLL.Funcionario();
                Fcu.CodigoFuncionario = Convert.ToInt32(txtCod.Text);
                Fcu.Nome = txtNome.Text;
                if (rbFem.Checked == true)
                {
                    Fcu.Sexo = "f";
                }
                else
                {
                    Fcu.Sexo = "m";
                }

                Fcu.DataNascimento = Convert.ToDateTime(txtData.Text);
                Fcu.CPF = txtCPF.Text;
                Fcu.RG = txtRg.Text;
                Fcu.CEP = txtCEP.Text;
                Fcu.Numero = Convert.ToInt32(txtNumero.Text);
                Fcu.Complemento = txtComplemento.Text;
                Fcu.Email = txtEmail.Text;
                Fcu.Telefone = txtTelefone.Text;
                Fcu.Foto = imagem;
                Fcu.CPF = txtCPF.Text;
                Fcu.Salario = Convert.ToDouble(txtSalario.Text);
                Fcu.CodigoCargo = Convert.ToInt32(cbCargo.SelectedValue);
                Fcu.DataAdmissao = Convert.ToDateTime(txtDataAdm.Text);
                Fcu.StatusFuncionario = 1;
                Fcu.AlterarComParametro();
                MessageBox.Show("Funcionario alterado!!!");




            }
            catch (Exception ex)
            {

                throw ex;
            }
           








        }
        private void CarregarCombo(object o, EventArgs e)
        {

            BLL.Cargo c = new BLL.Cargo();

            cbCargo.DataSource = c.Listar(String.Empty, (byte)BLL.FuncoesGerais.TipoStatus.Ativo).Tables[0];
            cbCargo.DisplayMember = "NomeCargo";
            cbCargo.ValueMember = "CodigoCargo";


           





        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    







}
}
