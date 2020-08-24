using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDeMateriaisParaConstrucao.Telas.Venda
{
    public partial class FrmSelecionarVendedor : Modelos.FrmConsulta
    {


     
        public FrmSelecionarVendedor()
        {
            InitializeComponent();
            
        }

        private string vendedor;
        private int Codigo;

        public string Vendedor
        {
            get
            {
                return vendedor;
            }

            set
            {
                vendedor = value;
            }
        }

        public int Codigo1
        {
            get
            {
                return Codigo;
            }

            set
            {
                Codigo = value;
            }
        }

        public void CarregarDadosGrid()
        {
            try
            {
                BLL.Funcionario fcu = new BLL.Funcionario();
                dataGridView1.DataSource = fcu.Listar(textBox1.Text.Trim().ToUpper(), 1).Tables[0];
                textBox1.Focus();
                //a propriedade DATASOURCE do datagrid é a fonte de dados. Esta propriedade recebe (=) do objeto USU o método LISTAR usando como parametro o texto TEXT.TRIM().TOUPPER() digitado no TEXTBOX1. Esse DATASOURCE usará a tabela zero TABLES[0] do método LISTAR

                if (dataGridView1.Rows.Count == 0)
                {
                    btnEditar.Enabled = false;
                    btnConsultar.Enabled = false;
                    btnAtivar.Enabled = false;
                    btnDesativar.Enabled = false;
                    btnExcluir.Enabled = false;
                    button2.Enabled = false;


                }
                else
                {
                    btnEditar.Enabled = true;
                    btnConsultar.Enabled = true;
                    btnAtivar.Enabled = true;
                    btnDesativar.Enabled = true;
                    btnExcluir.Enabled = true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void Exibir(Object o, EventArgs e)
        {
            CarregarDadosGrid();
            if (o == btnfiltrar)
            {
                textBox1.Text = String.Empty;
            }
            textBox1.Focus();

        }


        private void SelecionarVendedor(object o, EventArgs e)
        {
 
            Vendedor = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            Codigo1 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Venda.FrmVendas v = new FrmVendas();

            Close();
        }

        private void ConsultarFuncionario(Object o, EventArgs e)
        {
            try
            {
                Telas.Cadastrar.FrmFuncionario fcu = new Cadastrar.FrmFuncionario();
                fcu.pcbFoto.Click -= fcu.SalvarFoto;
                fcu.label1.Text = "Consultando o Funcionário";
                fcu.txtNome.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                if (Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value) == "f")
                {
                    fcu.rbFem.Checked = true;
                }
                else
                {
                    fcu.rbMasc.Checked = true;
                }
                fcu.txtData.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                fcu.txtCPF.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
                fcu.txtRg.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
                fcu.txtCEP.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
                fcu.txtNumero.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);

                fcu.BuscarEndereco(o, e);

                fcu.txtComplemento.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[8].Value);
                fcu.txtEmail.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[9].Value);
                fcu.txtTelefone.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[10].Value);
                if (Convert.ToString(dataGridView1.CurrentRow.Cells[11].Value) != "")
                {
                    fcu.imagem = Convert.ToString(dataGridView1.CurrentRow.Cells[11].Value);
                    fcu.pcbFoto.ImageLocation = fcu.imagem;
                    fcu.pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;


                    //fcu.pcbFoto.Image.Width = 140;

                }
                else
                {

                    fcu.pcbFoto.ImageLocation = Application.StartupPath.ToString() + "\\FotosFuncionarios\\semimagem.png";

                }

                fcu.txtSalario.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[12].Value);
                fcu.cbCargo.SelectedValue = Convert.ToString(dataGridView1.CurrentRow.Cells[13].Value);
                fcu.txtDataAdm.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[14].Value);

                fcu.txtNome.ReadOnly = true;
                fcu.rbMasc.Enabled = false;
                fcu.rbFem.Enabled = false;
                fcu.txtCPF.ReadOnly = true;
                fcu.txtRg.ReadOnly = true;
                fcu.txtCEP.ReadOnly = true;
                fcu.txtNumero.ReadOnly = true;
                fcu.txtComplemento.ReadOnly = true;
                fcu.txtEmail.ReadOnly = true;
                fcu.txtTelefone.ReadOnly = true;
                fcu.txtSalario.ReadOnly = true;
                fcu.cbCargo.Enabled = false;
                fcu.txtDataAdm.ReadOnly = true;
                fcu.btnAceitar.Visible = false;
                fcu.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
