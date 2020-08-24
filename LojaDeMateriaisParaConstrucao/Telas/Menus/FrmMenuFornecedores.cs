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
    public partial class FrmMenuFornecedores : Modelos.FrmModeloMenu
    {
        public FrmMenuFornecedores()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Cadastrar.FrmFornecedor f = new Cadastrar.FrmFornecedor();
            f.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Telas.Consultar.FrmListagemFornecedores f = new Consultar.FrmListagemFornecedores();
            f.ShowDialog();
        }
    }
}
