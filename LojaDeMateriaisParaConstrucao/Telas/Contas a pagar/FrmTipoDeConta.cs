using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDeMateriaisParaConstrucao.Telas.Contas_a_pagar
{
    public partial class FrmTipoDeConta : Form
    {
        public FrmTipoDeConta()
        {
            InitializeComponent();
        }


        private void CadastrarTitulo(object o, EventArgs e) {


            BLL.Titulo tit = new BLL.Titulo();

            tit.DescricaoTitulo = txtTitulo.Text.ToUpper() ;
            tit.StatusTitulo = 0;
            if (checkBox1.Checked)
            {
                tit.StatusTitulo = 1;
            }
            tit.Incluir();
            MessageBox.Show("Titulo Cadastrado com sucesso");
            Close();



        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
