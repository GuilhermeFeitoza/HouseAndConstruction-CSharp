using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDeMateriaisParaConstrucao.Telas.Editar
{
    public partial class FrmEditarCargo : Form
    {
        public FrmEditarCargo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void EditarCargo(object o , EventArgs e) {
            BLL.Cargo c = new BLL.Cargo();
            c.CodigoCargo = Convert.ToInt32(txtCodCargo.Text);
            c.Abreviacao = txtAbreviacao.Text;
            c.NomeCargo = txtCargo.Text;
            c.DescricaoCargo = txtDescricao.Text;
            c.AlterarComParametro();
            MessageBox.Show("Cargo Alterado com sucesso!!!");


        }
    }

}
