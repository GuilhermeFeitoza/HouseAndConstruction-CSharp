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
    public partial class FrmUnidadeVenda : Modelos.FrmCabeçalhoECorp
    {
        public FrmUnidadeVenda()
        {
            InitializeComponent();
        }

        private void CadastrarUnidade(object sender, EventArgs e)
        {
            BLL.UnidadeVenda u = new BLL.UnidadeVenda();
            u.Abreviacao = txtAbreviacao.Text.ToUpper();
            u.NomeUnidadeVenda = txtNome.Text.ToUpper();
            u.IncluirComParametro();
            MessageBox.Show("Unidade cadastrada com sucesso!!");
            DialogResult dr = MessageBox.Show("Deseja cadastrar outra unidade de venda ?", "Unidade de venda", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                txtNome.Clear();
                txtAbreviacao.Clear();
               
                txtNome.Focus();
                //Limpar text e colocar foco no txt nome

            }
            else
            {
                Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
