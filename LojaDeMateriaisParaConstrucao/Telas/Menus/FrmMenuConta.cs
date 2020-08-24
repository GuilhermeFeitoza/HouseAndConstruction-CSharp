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
    public partial class FrmMenuConta : Form
    {
        public FrmMenuConta()
        {
            InitializeComponent();

            

        }

        private void  AbrirPeriodo(object o , EventArgs e)
        {

            Telas.Contas_a_pagar.FrmCadastrarPeriodo p = new Contas_a_pagar.FrmCadastrarPeriodo();
            p.ShowDialog();

            
            

        }

        private void AbrirTipoConta(object o, EventArgs e) {


            Telas.Contas_a_pagar.FrmTipoDeConta t = new Contas_a_pagar.FrmTipoDeConta();
            t.ShowDialog();


        }

        private void AbrirLancamento(object o , EventArgs e)
        {

            Contas_a_pagar.FrmGestaoDeContasAPagar gc = new Contas_a_pagar.FrmGestaoDeContasAPagar();
            gc.ShowDialog();





        }
    }
}
