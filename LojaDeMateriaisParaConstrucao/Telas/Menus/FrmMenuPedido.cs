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
    public partial class FrmMenuPedido : Modelos.FrmModeloMenu
    {
        public FrmMenuPedido()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Pedido.FrmPedido p  = new Pedido.FrmPedido();
            p.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Listagem.FrmListagemPedidos p = new Listagem.FrmListagemPedidos();
            p.ShowDialog();

        }
    }
}
