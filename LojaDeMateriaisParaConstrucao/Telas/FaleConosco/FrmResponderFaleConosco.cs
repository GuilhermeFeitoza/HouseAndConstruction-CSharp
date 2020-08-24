using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDeMateriaisParaConstrucao.Telas.FaleConosco
{
    public partial class FrmResponderFaleConosco : Form
    {
        public FrmResponderFaleConosco()
        {
            InitializeComponent();
        }
        public int Codigo;

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            BLL.FaleConosco fale = new BLL.FaleConosco();
            fale.Resposta = txtMensagem.Text;
            fale.CodigoContato = Codigo;
            fale.CodigoUsuario = BLL.Session.Instance.UserID;
            fale.StatusContato = 1;
            fale.AlterarComParametro();
            MessageBox.Show("Resposta enviada!!");
            Close();
        }
    }
}
