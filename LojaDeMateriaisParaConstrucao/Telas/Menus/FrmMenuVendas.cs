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
    public partial class FrmMenuVendas : Modelos.FrmModeloMenu
    {
        public FrmMenuVendas()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Telas.Venda.FrmVendas v = new Venda.FrmVendas();
            v.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Telas.Venda.FrmListagemVendas l = new Venda.FrmListagemVendas();
            l.ShowDialog();
        }
    }
}
