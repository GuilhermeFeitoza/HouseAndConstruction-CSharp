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
    public partial class FrmCadastrarPeriodo : Modelos.FrmCabeçalhoECorp
    {
        public FrmCadastrarPeriodo()
        {
            InitializeComponent();
        }


        private void CadastrarPeriodo(object o, EventArgs e)
        {
            try
            {
                BLL.Periodo peri = new BLL.Periodo();

                if (txtDesc.Text == "")
                {
                    MessageBox.Show("Insira uma descrição para o periodo que deseja cadastrar!!");
                    txtDesc.Focus();

                }



                if (txtValor.Text == "")
                {
                    MessageBox.Show("Insira um Valor para o periodo que deseja cadastrar!!");
                    txtValor.Focus();

                }

                peri.DescricaoPeriodo = txtDesc.Text.ToUpper();
                peri.ValorPeriodo = Convert.ToInt16(txtValor.Text);
                peri.SinalPeriodo = "-";
                if (rbProximo.Checked)
                {
                    peri.SinalPeriodo = "+";
                }
                peri.StatusPeriodo = 0;
                if (cbAtivo.Checked == true)
                {
                    peri.StatusPeriodo = 1;
                }

                peri.Incluir();
                MessageBox.Show("Periodo cadastrado com sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso");
            }
        }







        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
