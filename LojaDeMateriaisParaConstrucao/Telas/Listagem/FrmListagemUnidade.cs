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
    public partial class FrmListagemUnidade : Modelos.FrmConsulta
    {
        public FrmListagemUnidade()
        {
            InitializeComponent();
        }
        public void CarregarDadosGrid()
        {
            try
            {
                BLL.UnidadeVenda u = new BLL.UnidadeVenda();
                dataGridView1.DataSource = u.Listar(textBox1.Text.Trim().ToUpper(), 1).Tables[0];
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

        private void CadastrarUnidade(object o, EventArgs e)
        {

            Telas.Cadastrar.FrmUnidadeVenda f = new Cadastrar.FrmUnidadeVenda();
            f.ShowDialog();


        }




        private void ConsultarUnidade(object o, EventArgs e)
        {
            Cadastrar.FrmUnidadeVenda fcu = new Cadastrar.FrmUnidadeVenda();
            fcu.txtNome.ReadOnly = true;
            fcu.txtAbreviacao.ReadOnly = true;
            fcu.txtNome.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            fcu.txtAbreviacao.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            fcu.label5.Text = "Consultando Unidade";
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
                BLL.UnidadeVenda cl = new BLL.UnidadeVenda();
                cl.CodigoUnidadeVenda = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                //propriedade '.codigo' do objeto 'usu' recebe '=' o valor 'value' da primeira coluna 'cells[0]' da linha atual 'currentrow' do grid 'datagridview1'
                switch (b.Text)
                {
                    case "Excluir": cl.Excluir(); break;


                }
                String msg = "";
                if (b.Text == "Editar")
                {
                    msg = "Unidade editado com sucesso";


                }
                if (b.Text == "Ativar")

                {
                    msg = "Unidade ativado com sucesso";
                }
                if (b.Text == "Desativar")

                {
                    msg = "Unidade desativado com sucesso";
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
