using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LojaDeMateriaisParaConstrucao.Telas.ControleDeEstoque
{
    public partial class FrmRegistrarEntrada : Modelos.FrmCabeçalhoECorp
    {
        public FrmRegistrarEntrada()
        {
            InitializeComponent();
            txtDataEntrada.Text = Convert.ToString(DateTime.Today);
        }
        private void CarregarCombo(object o, EventArgs e)
        {

            BLL.Produto c = new BLL.Produto();

            cbProduto.DataSource = c.Listar(String.Empty, (byte)BLL.FuncoesGerais.TipoStatus.Ativo).Tables[0];
            cbProduto.DisplayMember = "Nome";
            cbProduto.ValueMember = "CodigoProduto";





        }

        private void RegistrarEntrada(object o, EventArgs e) {

            BLL.Estoque est = new BLL.Estoque();
            est.CodigoProduto =Convert.ToInt32(cbProduto.SelectedValue);
            est.Quantidade = Convert.ToInt32(txtQuant.Value);
            est.Data = Convert.ToDateTime(txtDataEntrada.Text);
            est.RegistrarEntradaProd();
            est.AtualizarEstoque();
            MessageBox.Show("Registrado com sucesso!!");
            Close();
            
      
    }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
