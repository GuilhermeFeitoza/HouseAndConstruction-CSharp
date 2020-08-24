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
    public partial class FrmMenuCupons : Modelos.FrmModeloMenu
    {
        public FrmMenuCupons()
        {
            InitializeComponent();
        }

        private void FrmMenuCupons_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            Cadastrar.FrmCupom c = new Cadastrar.FrmCupom();
            c.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Listagem.FrmListagemCupons c = new Listagem.FrmListagemCupons();
            c.ShowDialog();
        }
    }
}
