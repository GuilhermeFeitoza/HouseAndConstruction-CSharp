using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDeMateriaisParaConstrucao.Telas.Consultar
{
    public partial class FrmListagemCargo : Modelos.FrmConsulta
    {
        public FrmListagemCargo()
        {
            InitializeComponent();
        }


        private void ExibirAtivos(Object o, EventArgs e)
        {

        }

        private void ExibirInativos(Object o, EventArgs e)
        {

        }

        public void CarregarDadosGrid()
        {
            try
            {
                BLL.Cargo c = new BLL.Cargo();
                dataGridView1.DataSource = c.Listar(textBox1.Text.Trim().ToUpper(), 1).Tables[0];
                textBox1.Focus();
                //a propriedade DATASOURCE do datagrid é a fonte de dados. Esta propriedade recebe (=) do objeto USU o método LISTAR usando como parametro o texto TEXT.TRIM().TOUPPER() digitado no TEXTBOX1. Esse DATASOURCE usará a tabela zero TABLES[0] do método LISTAR

                if (dataGridView1.Rows.Count == 0)
                {
                    btnEditar.Enabled = false;
                }
                else
                {
                    btnEditar.Enabled = true;
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

       private void NovoCargo(object o , EventArgs e)
        {

            Telas.Cadastrar.FrmCargo f = new Cadastrar.FrmCargo();
            f.ShowDialog();
            Close();

        }


        private void EditarCargo(object o, EventArgs e)
        {
            try
            {
                Editar.FrmEditarCargo fcu = new Editar.FrmEditarCargo();
                fcu.txtCodCargo.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                fcu.txtCargo.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                fcu.txtAbreviacao.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                fcu.txtDescricao.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);


                fcu.ShowDialog();



            }
            catch (Exception ex)
            {
                /*if (dataGridView1.CurrentCell.Value = )
                {

                }*/
                MessageBox.Show(ex.Message);
                //throw;
            }
        }


        private void ConsultarCargo(object o ,EventArgs e) {
            Cadastrar.FrmCargo fcu = new Cadastrar.FrmCargo();
            fcu.txtCodCargo.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            fcu.txtCargo.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            fcu.txtAbreviacao.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            fcu.txtDescricao.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            fcu.txtCargo.ReadOnly = true;
            fcu.txtAbreviacao.ReadOnly = true;
            fcu.txtDescricao.ReadOnly = true;
            fcu.label5.Text = "Consultando Cargo";
            fcu.btnCadastrar.Visible = false;
            fcu.ShowDialog();

        }


        private void Fixar(Object o, EventArgs e)
        {
            try
            {
                //o é objeto que foi clicado
                var b = (Button)o;
                //variávl 'b' é o botão 'o'
                if (MessageBox.Show(b.Text, "Atencao", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                BLL.Cargo cl = new BLL.Cargo();
                cl.CodigoCargo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                //propriedade '.codigo' do objeto 'usu' recebe '=' o valor 'value' da primeira coluna 'cells[0]' da linha atual 'currentrow' do grid 'datagridview1'
                switch (b.Text)
                {
                    case "Excluir": cl.Excluir(); break;
                    case "Ativar": cl.Ativar(); break;
                    case "Desativar": cl.Desativar(); break;

                }
                String msg = "";
                if (b.Text == "Editar")
                {
                    msg = "Cliente editado com sucesso";


                }
                if (b.Text == "Ativar")

                {
                    msg = "Cliente ativado com sucesso";
                }
                if (b.Text == "Desativar")

                {
                    msg = "Cliente desativado com sucesso";
                }
                MessageBox.Show(msg, "Sucesso");
                CarregarDadosGrid();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }











    }
}
