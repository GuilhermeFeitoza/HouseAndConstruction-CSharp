using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDeMateriaisParaConstrucao.Telas.Menus
{
    public partial class FrmMenuUsuario : Modelos.FrmModeloMenu
    {
        public FrmMenuUsuario()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Cadastrar.FrmUsuario u = new Cadastrar.FrmUsuario();
            u.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Consultar.FrmConsultaUsuario u = new Consultar.FrmConsultaUsuario();
            u.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cadastrar.FrmNIvelAcesso n = new Cadastrar.FrmNIvelAcesso();
            n.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Consultar.ListagemNivelAcesso l = new Consultar.ListagemNivelAcesso();
            l.ShowDialog();
        }
    }
}
