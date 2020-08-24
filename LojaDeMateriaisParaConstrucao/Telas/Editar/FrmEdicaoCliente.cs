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
    public partial class FrmEdicaoCliente : Form
    {
        public FrmEdicaoCliente()
        {
            InitializeComponent();
        }

        private void EditandoCliente(object o, EventArgs e)
        {

            Telas.Consultar.FrmListagemClientes n = new Telas.Consultar.FrmListagemClientes();
            BLL.Cliente cl = new BLL.Cliente();
            cl.CodigoCliente = Convert.ToInt32(txtCod.Text);
            cl.Nome = txtNome.Text;
            cl.DataNascimento = Convert.ToDateTime(txtData.Text);
                                   
            cl.Endereco = txtEndereco.Text;
            cl.Bairro = txtBairro.Text;
            cl.Cidade = txtCidade.Text;
            cl.Complemento = txtComplemento.Text;
            cl.UF = "SP";
            cl.Numero = Convert.ToInt32(txtNumero.Text);
            cl.CEP = txtCep.Text;
            cl.Rg = txtRg.Text;
            cl.Cpf = txtCPF.Text;
            
            if (rbFem.Checked)
            {
                cl.Sexo = "f";

            }
            else
            {
                cl.Sexo = "m";
            }

            cl.Telefone = txtTelefone.Text;
            cl.Email = txtEmail.Text;
            cl.StatusCliente = 1;
            cl.AlterarComParametro();
            MessageBox.Show("Cliente alterado!!!");
            Close();
            n.ShowDialog();







        }

        private void button1_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
