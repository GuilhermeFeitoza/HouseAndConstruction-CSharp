using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDeMateriaisParaConstrucao.Telas.Pedido
{
    public partial class SelecionarDestinatario : Modelos.FrmConsulta
    {
        public SelecionarDestinatario()
        {
            InitializeComponent();
        }

        private String Destinatario;
        private int CodigoDestinatario;

       
public string Destinatario1
        {
            get
            {
                return Destinatario;
            }

            set
            {
                Destinatario = value;
            }
        }

        public int CodigoDestinatario1
        {
            get
            {
                return CodigoDestinatario;
            }

            set
            {
                CodigoDestinatario = value;
            }
        }

        public void CarregarDadosGrid()
        {
            try
            {
                BLL.Destinatario dest = new BLL.Destinatario();
                dataGridView1.DataSource = dest.Listar(textBox1.Text.Trim().ToUpper(), 1).Tables[0];
                textBox1.Focus();

                if (dataGridView1.Rows.Count == 0)
                {
                    btnEditar.Enabled = false;
                    btnConsultar.Enabled = false;
                    btnDesativar.Enabled = false;
                    btnAtivar.Enabled = false;
                    btnExcluir.Enabled = false;
                


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
        private void ConsultarDestinatario(Object o, EventArgs e)
        {
            try
            {
                Telas.Cadastrar.FrmDestinatário fcu = new Cadastrar.FrmDestinatário();
                fcu.lblTitulo.Text = "Consultando o Destinatario";
                fcu.txtDestinatario.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                fcu.txtLogradouro.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                fcu.txtBairro.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                fcu.txtCidade.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
                fcu.cbUf.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
                fcu.txtCEP.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
                fcu.txtNum.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);

                           fcu.txtTel.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[9].Value);
                
                
                fcu.btnCadastrar.Visible = false;
                fcu.txtDestinatario.ReadOnly = true;
                fcu.txtLogradouro.ReadOnly = true;
                fcu.txtBairro.ReadOnly = true;
                fcu.txtCidade.ReadOnly = true;
                //fcu.cbUf.DropDown = true;
                fcu.txtComplemento.ReadOnly = true;
                fcu.txtCEP.ReadOnly = true;
                fcu.txtNum.ReadOnly = true;
                fcu.txtTel.ReadOnly = true;
              



                fcu.ShowDialog();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
        private void Selecionar(object o, EventArgs e)
        {
            CodigoDestinatario1 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Destinatario1 = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);

            Venda.FrmVendas v = new Venda.FrmVendas();

            Close();
        }






















        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
