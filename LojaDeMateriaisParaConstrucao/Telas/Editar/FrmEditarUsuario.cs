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
    public partial class FrmEditarUsuario : Cadastrar.FrmUsuario
    {
        public FrmEditarUsuario()
        {
            InitializeComponent();

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL.Usuario usu = new BLL.Usuario();
            usu.NomeUsuario = txtNome.Text;
            usu.SenhaUsuario = txtSenha.Text;
            usu.AlterarComParametro();
        }
    }
}
