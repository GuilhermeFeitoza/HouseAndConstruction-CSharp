using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDeMateriaisParaConstrucao.Telas.Venda
{
    public partial class FrmValidarCupom : Modelos.FrmCabeçalhoECorp
    {
        public FrmValidarCupom()
        {
            InitializeComponent();
        }
        BLL.Cupom c = new BLL.Cupom();
        public int CodigoCliente;
        public decimal ValorCupomValidacao;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            TCC_Inf2Dm.ClasseParaManipularBancoDeDados banco = new TCC_Inf2Dm.ClasseParaManipularBancoDeDados();
            System.Data.SqlClient.SqlDataReader ddr;
            c.CodigoCupom = textBox1.Text.ToUpper();
            ddr = c.VerificarCupom();
            ddr.Read();

            if (Convert.ToInt16(ddr["StatusCupom"]) == 1)//Valida o status do cupom
            {


                int CupomCliente = 0;
                int IDCupom = Convert.ToInt16(ddr["ID"]);
                CupomCliente = banco.RetornarExecuteScalar("SELECT COUNT(ID)FROM tbCupom_Cliente where ID =" + IDCupom + " AND CodigoCliente=" + CodigoCliente);

                if (CupomCliente == 0)
                {

                    MessageBox.Show("O cliente selecionado para venda não possui este cupom.");
                    return;
                }




                if (ddr.HasRows)
                {
                    lblValorCupom.Text = String.Format("{0:C}", ddr["ValorCupom"]);
                    ValorCupomValidacao = Convert.ToDecimal(ddr["ValorCupom"]);
                    lblDataInicio.Text = Convert.ToString(ddr["DataInicio"]);
                    lblDataFim.Text = Convert.ToString(ddr["DataFim"]);
                    textBox1.ReadOnly = true;

                }
                else
                {
                    MessageBox.Show("Cupom Invalido");
                    textBox1.Clear();

                }

            }
            else
            {
                MessageBox.Show("Cupom desativado");
                textBox1.Clear();
            }
        }










        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
