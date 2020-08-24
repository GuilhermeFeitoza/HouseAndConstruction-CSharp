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
    public partial class FrmMenuClientes : Modelos.FrmModeloMenu
    {
        public FrmMenuClientes()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Cadastrar.FrmCliente f = new Cadastrar.FrmCliente();
            f.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Consultar.FrmListagemClientes f = new Consultar.FrmListagemClientes();
            f.ShowDialog();

        }
    }
}
