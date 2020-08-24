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
    public partial class FrmFormaDePagamento : Modelos.FrmCabeçalhoECorp
    {
        public FrmFormaDePagamento()
        {
            InitializeComponent();
        }

        public int Codigo;
        public void CadastrarForma(object o , EventArgs e)
        {
            BLL.FormaPagamento f = new BLL.FormaPagamento();
            f.NomeForma = txtNome.Text.ToUpper();
            f.IncluirComParametro();
            MessageBox.Show("Cadastrado com sucesso !!!");



        }
        public void EditarForma(object o, EventArgs e) {
            BLL.FormaPagamento f = new BLL.FormaPagamento();
            f.CodigoForma = Codigo;
            f.NomeForma = txtNome.Text;
            f.AlterarComParametro();
            MessageBox.Show("Forma de pagamento alterada com sucesso");





        }
        private void Cancelar(object o, EventArgs e) {


            Close();

        }
    }
}
