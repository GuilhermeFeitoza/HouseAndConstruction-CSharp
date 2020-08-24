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
    public partial class FrmSelecionarCliente : Modelos.FrmConsulta
    {
        public FrmSelecionarCliente()
        {
            InitializeComponent();
        }



        private String cliente;
        private int codigoCliente;
        public string Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
            }
        }

        public int CodigoCliente
        {
            get
            {
                return codigoCliente;
            }

            set
            {
                codigoCliente = value;
            }
        }

        public void CarregarDadosGrid()
        {
            try
            {
                BLL.Cliente cli = new BLL.Cliente();
                dataGridView1.DataSource = cli.Listar(textBox1.Text.Trim().ToUpper(), 1).Tables[0];
                textBox1.Focus();

                if (dataGridView1.Rows.Count == 0)
                {
                    btnEditar.Enabled = false;
                    btnConsultar.Enabled = false;
                    btnDesativar.Enabled = false;
                    btnAtivar.Enabled = false;
                    btnExcluir.Enabled = false;
                    button2.Enabled = false;
                        
                    
                }
                else
                {
                    btnEditar.Enabled = true;
                    btnConsultar.Enabled = true;
                    btnDesativar.Enabled = true;
                    btnAtivar.Enabled = true;
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
        private void ConsultarCliente(Object o, EventArgs e)
        {
            try
            {
                Telas.Cadastrar.FrmCliente fcu = new Cadastrar.FrmCliente();
                fcu.label1.Text = "Consultando o Cliente";
                fcu.txtNome.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                fcu.txtData.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                fcu.txtEndereco.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                fcu.txtBairro.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
                fcu.txtCidade.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
                fcu.txtComplemento.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
                fcu.txtNumero.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);

                fcu.txtUF.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[8].Value);
                fcu.txtCEP.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[9].Value);
                fcu.txtRg.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[10].Value);
                fcu.txtCPF.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[11].Value);
                if (Convert.ToString(dataGridView1.CurrentRow.Cells[12].Value) == "f")
                {
                    fcu.rbFem.Checked = true;
                    fcu.rbFem.Enabled = false;
                    fcu.rbMasc.Enabled = false;
                }
                else
                {
                    fcu.rbMasc.Checked = true;
                    fcu.rbMasc.Enabled = false;
                    fcu.rbFem.Enabled = false;

                }
                fcu.txtTelefone.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[13].Value);
                fcu.txtEmail.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[14].Value);

                fcu.btnAceitar.Visible = false;
                fcu.txtNome.ReadOnly = true;
                fcu.txtData.ReadOnly = true;
                fcu.txtEndereco.ReadOnly = true;
                fcu.txtBairro.ReadOnly = true;
                fcu.txtCidade.ReadOnly = true;
                fcu.txtComplemento.ReadOnly = true;
                fcu.txtRg.ReadOnly = true;
                fcu.txtCPF.ReadOnly = true;
                fcu.txtTelefone.ReadOnly = true;
                fcu.txtEmail.ReadOnly = true;
                fcu.txtCEP.ReadOnly = true;
                fcu.txtNumero.ReadOnly = true;



                fcu.ShowDialog();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
        private void SelecionarCliente(object o ,EventArgs e)
        {
            CodigoCliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Cliente = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
           
            Venda.FrmVendas v = new FrmVendas();
            
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
