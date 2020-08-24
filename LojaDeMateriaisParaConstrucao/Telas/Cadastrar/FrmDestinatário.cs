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
    public partial class FrmDestinatário : Modelos.FrmCabeçalhoECorp
    {
        public FrmDestinatário()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CadastrarDestinatario(object o, EventArgs e) {

            try
                
            {
                BLL.Destinatario d = new BLL.Destinatario();
                d.NomeDestinatario = txtDestinatario.Text;
                d.EnderecoDestinatario = txtLogradouro.Text;
                d.BairroDestinatario = txtBairro.Text;
                d.CidadeDestinatario = txtCidade.Text;
                d.CEPDestinatario = txtCEP.Text;
                d.NumeroDestinatario = Convert.ToInt32(txtNum.Text);
                d.ComplementoDestinatario = txtComplemento.Text;
                d.TelDestinatario = txtTel.Text;
                d.UFDestinatario = cbUf.Text;
                d.StatusDestinatario = 0;
                d.IncluirComParametro();

                MessageBox.Show("Cadastrado com sucesso!!!");

            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
                throw;
            }








        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
