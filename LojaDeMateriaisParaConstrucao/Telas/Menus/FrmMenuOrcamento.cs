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
    public partial class FrmMenuOrcamento : Modelos.FrmModeloMenu
    {
        public FrmMenuOrcamento()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Telas.Orcamento.FrmOrcamento o = new Orcamento.FrmOrcamento();
            o.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Telas.Orcamento.FrmListagemOrcamento o = new Orcamento.FrmListagemOrcamento();
            o.ShowDialog();
        }
    }
}
