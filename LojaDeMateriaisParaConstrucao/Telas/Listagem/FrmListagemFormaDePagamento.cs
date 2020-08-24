using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDeMateriaisParaConstrucao.Telas.Listagem
{
    public partial class FrmListagemFormaDePagamento : Modelos.FrmConsulta
    {
        public FrmListagemFormaDePagamento()
        {
            InitializeComponent();
        }

        private void NovaForma(object o , EventArgs e) {
            Cadastrar.FrmFormaDePagamento f = new Cadastrar.FrmFormaDePagamento();
            f.ShowDialog();


        }
        private void AbrirEdicao(object o, EventArgs e) {

            Cadastrar.FrmFormaDePagamento f = new Cadastrar.FrmFormaDePagamento();
            f.lblTitulo.Text = "Editar forma de pagamento ";
            f.txtNome.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            f.Codigo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            f.btnCadastrar.Click -= f.CadastrarForma;
            f.btnCadastrar.Click += f.EditarForma;
            f.btnCadastrar.Text = "Editar";
            f.ShowDialog();


                

        }

        private void Fixar(Object o, EventArgs e)
        {
            try
            {
              
                var b = (Button)o;
                //variávl 'b' é o botão 'o'
                if (MessageBox.Show(b.Text, "Atencao", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                BLL.FormaPagamento forn = new BLL.FormaPagamento();
                forn.CodigoForma = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                //propriedade '.codigo' do objeto 'usu' recebe '=' o valor 'value' da primeira coluna 'cells[0]' da linha atual 'currentrow' do grid 'datagridview1'
                switch (b.Text)
                {
                    case "Excluir": forn.Excluir(); break;
                 

                }
                String msg = "";
                if (b.Text == "Excluir")
                {
                    msg = "Forma de pagamento excluida com sucesso";


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

        public void CarregarDadosGrid()
        {
            try
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                BLL.FormaPagamento f = new BLL.FormaPagamento();
                dataGridView1.DataSource = f.Listar(textBox1.Text.Trim().ToUpper(), 1).Tables[0];
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


    }
}
