using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDeMateriaisParaConstrucao.Telas
{
    public partial class ResumoInicio : Form
    {
        public ResumoInicio()
        {
            InitializeComponent();
            CarregarGridProd();
            if (TablaProductos.RowCount == 0)
            {
                linkLabel1.Visible = false;
                pictureBox1.Visible = false;
                pcbFoto.Visible = true;
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss ");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        TCC_Inf2Dm.ClasseParaManipularBancoDeDados c = new TCC_Inf2Dm.ClasseParaManipularBancoDeDados();

        private void TablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblProdutosComEstq.Visible = true;
            TablaProductos.Visible = true;
            pcbFoto.Visible = false;

        }


        private void CarregarGridProd()
        {
            try
            {
                BLL.Produto prod = new BLL.Produto();
                TablaProductos.DataSource = prod.ListarAbaixoDoEstoque().Tables[0];



            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                throw;
            }




        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }
    }
}
