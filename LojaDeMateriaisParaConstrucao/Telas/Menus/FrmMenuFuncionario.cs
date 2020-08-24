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
    public partial class FrmMenuFuncionario : Modelos.FrmModeloMenu
    {
        public FrmMenuFuncionario()
        {
            InitializeComponent();
        }

        private void FrmMenuFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Cadastrar.FrmFuncionario f = new Cadastrar.FrmFuncionario();
            f.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Consultar.FrmListagemFuncionario f = new Consultar.FrmListagemFuncionario();
            f.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cadastrar.FrmCargo c = new Cadastrar.FrmCargo();
            c.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Consultar.FrmListagemCargo c = new Consultar.FrmListagemCargo();
            c.ShowDialog();
        }
    }
}
