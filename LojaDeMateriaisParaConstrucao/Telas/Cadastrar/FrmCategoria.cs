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
    public partial class FrmCategoria : Modelos.FrmCabeçalhoECorp
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }
       private void CadastrarCategoria(object o , EventArgs e)
        {
            BLL.Categoria c = new BLL.Categoria();
            c.NomeCategoria = txtNome.Text.ToUpper();
            c.DescricaoCategoria = txtDescricao.Text;
            c.IncluirComParametro();
            MessageBox.Show("Categoria cadastrada com sucesso !!");
            DialogResult dr = MessageBox.Show("Deseja Cadastrar outra Categoria ?", "Categoria", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                txtNome.Clear();
                txtDescricao.Clear();
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
