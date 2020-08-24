using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDeMateriaisParaConstrucao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void TrocarSenha(Object o, EventArgs e)
        {
            LojaDeMateriaisParaConstrucao.FrmTrocaDeSenha f = new LojaDeMateriaisParaConstrucao.FrmTrocaDeSenha();
            f.ShowDialog();
        }


        private void Sair(Object o,EventArgs e)
        {
            Application.Exit();
        }


        TCC_Inf2Dm.ClasseParaManipularBancoDeDados c = new TCC_Inf2Dm.ClasseParaManipularBancoDeDados();

        private void Confirmar(Object o, EventArgs e)
        {
          


            try
            {

                if (VerificarDigitacao() == false)
                {
                    return;
                }

           

                BLL.Usuario usu = new BLL.Usuario();
                usu.NomeUsuario = txtNome.Text;
                usu.SenhaUsuario = txtSenha.Text;
                if (usu.Logar() != 0)
                {
                    
                   // MessageBox.Show("Seja bem-vindo !!!");

                    
                    // f.NivelAcesso = usu.CodigoNivelAcesso;


                    // f.NivelAcesso = 0;
                    Telas.Menu2 m = new Telas.Menu2();
                    m.lblUsuarioLogado.Text = txtNome.Text;
                    m.lblNivel.Text = Convert.ToString(usu.CodigoNivelAcesso);
                    m.CodigoUsuario = usu.CodigoUsuario;

                    /*pega o valor da classe session que é uma classe 
                    que mantem um valor armazenado durante toda a execução do programa podendo ser usado em outros forms */
                    BLL.Session.Instance.UserID = usu.CodigoUsuario;

                    m.ShowDialog();
                    Close();
                    

                }
                else
                {
                    MessageBox.Show("Erro Usuário/Senha");
                    txtSenha.Clear();
                    txtNome.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
           
            
        }


        private bool VerificarDigitacao()
        {
            bool Situacao = true;

            if (txtNome.Text.Trim().Length == 0)
            {
                erro.SetError(txtNome, "Digite um nome");
                Situacao = false;
            }
            else
            {
                erro.SetError(txtNome, "");

            }

            if (txtSenha.Text.Trim().Length == 0)
            {
                erro.SetError(txtSenha, "Digite uma senha");
                Situacao = false;
            }
            else
            {
                erro.SetError(txtSenha, "");

            }


            return Situacao;
        }


    }
}
