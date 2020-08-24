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
    public partial class FrmCupom : Modelos.FrmCabeçalhoECorp
    {
        public FrmCupom()
            
        {
            InitializeComponent();
        }
        public int Codigo;
        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.Cupom c = new BLL.Cupom();
                c.CodigoCupom = txtCodB.Text.ToUpper();
                c.Descricao = txtDesc.Text;
                c.ValorCupom = Convert.ToDecimal(txtValor.Text);
                c.DataInicio = Convert.ToDateTime(mskDataIni.Text);
                c.DataFim = Convert.ToDateTime(mskDatafim.Text);
                c.StatusCupom = 1;
                c.NovoCupom();
                MessageBox.Show("Cadastrado com sucesso!!");
                Close();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void Alterar(object o, EventArgs e)
        
         {

            BLL.Cupom c = new BLL.Cupom();
            c.CodigoCupom = txtCodB.Text.ToUpper();
            c.Descricao = txtDesc.Text;
            c.ValorCupom = Convert.ToDecimal(txtValor.Text);
            c.DataInicio = Convert.ToDateTime(mskDataIni.Text);
            c.DataFim = Convert.ToDateTime(mskDatafim.Text);
            c.StatusCupom = 1;
            c.AlterarCupom();
            MessageBox.Show("Alterado com sucesso!!");






        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
