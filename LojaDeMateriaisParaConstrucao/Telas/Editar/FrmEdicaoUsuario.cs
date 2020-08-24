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
    public partial class FrmEdicaoUsuario : Form
    {
        public FrmEdicaoUsuario()
        {
            InitializeComponent();
           
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void EditandoUSU(object o , EventArgs e) {

            Telas.Consultar.FrmConsultaUsuario n = new Telas.Consultar.FrmConsultaUsuario();
            BLL.Usuario usu = new BLL.Usuario();
            usu.NomeUsuario = txtNomeEdicao.Text;
            usu.SenhaUsuario = txtSenhaEdicao.Text;
            usu.CodigoUsuario = Convert.ToInt32(textBox1.Text);
            usu.StatusUsuario = 1;
            usu.CodigoNivelAcesso = Convert.ToInt32(cbNivelEdicao.SelectedValue);
             usu.AlterarComParametro();
            MessageBox.Show("Usuário alterado!!!");
            Close();
            n.ShowDialog();
            
            
            
           



        }
        private void CarregarCombo(object o, EventArgs e)
        {

            BLL.NivelAcesso n = new BLL.NivelAcesso();

            cbNivelEdicao.DataSource = n.Listar(String.Empty, (byte)BLL.FuncoesGerais.TipoStatus.Ativo).Tables[0];
            cbNivelEdicao.DisplayMember = "NomeNivelAcesso";
            cbNivelEdicao.ValueMember = "CodigoNivelAcesso";






        }
    }
}
