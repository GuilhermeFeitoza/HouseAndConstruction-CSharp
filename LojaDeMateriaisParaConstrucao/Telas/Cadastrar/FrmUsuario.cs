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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }
        private void Cadastrar (Object o, EventArgs e)
        {
            try
            {
                BLL.Usuario usu = new BLL.Usuario();
                if (txtSenha.Text == txtSenha2.Text)
                {

                    usu.NomeUsuario = txtNome.Text;
                    usu.SenhaUsuario = txtSenha.Text;
                    usu.DataAcessoUsuario = DateTime.Today;
                    usu.DataCadastroUsuario = DateTime.Today;
                    usu.StatusUsuario = 1;
                    usu.CodigoNivelAcesso = Convert.ToInt32(cbNivel.SelectedValue);
                    // usu.CodigoNivelAcesso = ;
                    usu.IncluirComParametro();
                    MessageBox.Show("Usuario Cadastrado");
                    txtNome.Clear();
                    txtSenha.Clear();
                    cbNivel.SelectedIndex = -1;
                    txtSenha2.Clear();


                }
                else
                {
                    MessageBox.Show("As senhas não condizem ,por favor tente novamente");
                    txtSenha.Clear();
                    txtSenha2.Clear();
                    txtSenha.Focus();

                }
            }
            catch (Exception ex)
            {

                throw ex ;
            }


        }
        private void CarregarCombo(object o, EventArgs e)
        {

            BLL.NivelAcesso n = new BLL.NivelAcesso();

            cbNivel.DataSource = n.Listar(String.Empty, (byte)BLL.FuncoesGerais.TipoStatus.Ativo).Tables[0];
            cbNivel.DisplayMember = "NomeNivelAcesso";
            cbNivel.ValueMember = "CodigoNivelAcesso";
            
        }







        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
