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
    public partial class FrmEdicaoFuncionario : Telas.Cadastrar.FrmFuncionario
    {
        public FrmEdicaoFuncionario()
        {
            InitializeComponent();
        }

        private void EditandoFuncionario(object o, EventArgs e)
        {

            Telas.Consultar.FrmListagemFuncionario n = new Telas.Consultar.FrmListagemFuncionario();
            BLL.Funcionario Fcu = new BLL.Funcionario();
            Fcu.CodigoFuncionario = Convert.ToInt32(txtCod.Text);
            Fcu.Nome = txtNome.Text;
            if (rbFem.Checked = true)
            {
                Fcu.Sexo = "f";
            }
            else
            {
                Fcu.Sexo = "m";
            }

            Fcu.DataNascimento = Convert.ToDateTime(txtData.Text);
            Fcu.CPF = txtCPF.Text;
            Fcu.RG = txtRg.Text;
            Fcu.CEP = txtCEP.Text;
            Fcu.Numero = Convert.ToInt32(txtNumero.Text);
            Fcu.Complemento = txtComplemento.Text;
            Fcu.Email = txtEmail.Text;
            Fcu.CPF = txtCPF.Text;
            Fcu.Salario = Convert.ToDouble(txtSalario);
            Fcu.CodigoCargo = Convert.ToInt32(cbCargo.SelectedValue);
                 
            Fcu.StatusFuncionario = 1;
            Fcu.AlterarComParametro();
            MessageBox.Show("Funcionario alterado!!!");
           







        }


    }
}
