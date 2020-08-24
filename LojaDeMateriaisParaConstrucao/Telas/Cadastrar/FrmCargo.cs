using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDeMateriaisParaConstrucao.Telas.Cadastrar
{
    public partial class FrmCargo : Form
    {
        public FrmCargo()
        {
            InitializeComponent();
            txtCargo.MaxLength = 3;
        }
        private void CadastrarCargo(object o , EventArgs e) {
            BLL.Cargo c = new BLL.Cargo();
            c.NomeCargo = txtCargo.Text;
            c.StatusCargo = 1;
            c.Abreviacao = txtAbreviacao.Text;
            c.DescricaoCargo = txtDescricao.Text;

            if (txtAbreviacao.Text == "" || txtCargo.Text == "" || txtDescricao.Text == "")
            {
                MessageBox.Show("Por favor Preencha todos os campos!!!");

            }
            else {
                c.IncluirComParametro();
                MessageBox.Show("Cargo Cadastrado com sucesso !!!");




            }
            


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
