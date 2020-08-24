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
    public partial class Menu : Form
    {
        public Menu()
        {
            
            InitializeComponent();

        


        }


        private int _NivelAcesso;



        TCC_Inf2Dm.ClasseParaManipularBancoDeDados c = new TCC_Inf2Dm.ClasseParaManipularBancoDeDados();

        public int NivelAcesso
        {
            get
            {
                return _NivelAcesso;
            }

            set
            {
                _NivelAcesso = value;
            }
        }

        public void Carregartools(object o, EventArgs e) {

            try
            {

              


            }
            catch (Exception)
            {

                //throw
            }



        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar.FrmUsuario f = new Cadastrar.FrmUsuario();
            f.ShowDialog();
        }


        private void IniciarForm(Object o, EventArgs e)
        {
            if (NivelAcesso == 1)
            {
                cadastrarToolStripMenuItem.Visible = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text =  Convert.ToString(DateTime.Now);
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Telas.Consultar.FrmConsultaUsuario f = new Telas.Consultar.FrmConsultaUsuario();
            f.ShowDialog();

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.Cadastrar.FrmCliente f = new Cadastrar.FrmCliente();
            f.ShowDialog();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Telas.Consultar.FrmListagemClientes f = new Consultar.FrmListagemClientes();
            f.ShowDialog();
        }
    }
}
