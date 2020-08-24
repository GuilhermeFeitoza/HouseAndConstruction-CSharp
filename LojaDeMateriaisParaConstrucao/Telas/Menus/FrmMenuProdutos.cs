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
    public partial class FrmMenuProdutos : Modelos.FrmModeloMenu
    {
        public FrmMenuProdutos()
        {
            InitializeComponent();
        }

        private void FrmMenuProdutos_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Cadastrar.FrmProduto p = new Cadastrar.FrmProduto();
            p.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Listagem.FrmListagemProdutos p = new Listagem.FrmListagemProdutos();
            p.ShowDialog();
        }

    
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Listagem.FrmListagemCategoria c = new Listagem.FrmListagemCategoria();
            c.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Listagem.FrmListagemUnidade c = new Listagem.FrmListagemUnidade();
            c.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Telas.ControleDeEstoque.FrmControleDeEstoque f = new ControleDeEstoque.FrmControleDeEstoque();
            f.ShowDialog();
        }
    }
}
