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
    public partial class FrmListagemCategoria : Modelos.FrmConsulta
    {
        public FrmListagemCategoria()
        {
            InitializeComponent();
        }
        public void CarregarDadosGrid()
        {
            try
            {
                BLL.Categoria c = new BLL.Categoria();
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

        private void CadastrarCategoria(object o, EventArgs e)
        {

            Telas.Cadastrar.FrmCategoria f = new Cadastrar.FrmCategoria();
            f.ShowDialog();


        }


      

        private void ConsultarCategoria(object o, EventArgs e)
        {
            Cadastrar.FrmCategoria fcu = new Cadastrar.FrmCategoria();
            fcu.txtNome.ReadOnly = true;
            fcu.txtDescricao.ReadOnly = true;
            fcu.txtNome.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            fcu.txtDescricao.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            fcu.label5.Text = "Consultando Categoria";
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
                BLL.Categoria cl = new BLL.Categoria();
                cl.CodigoCategoria = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                //propriedade '.codigo' do objeto 'usu' recebe '=' o valor 'value' da primeira coluna 'cells[0]' da linha atual 'currentrow' do grid 'datagridview1'
                switch (b.Text)
                {
                    case "Excluir": cl.Excluir(); break;
                   

                }
                String msg = "";
                if (b.Text == "Editar")
                {
                    msg = "Categoria editado com sucesso";


                }
                if (b.Text == "Ativar")

                {
                    msg = "Categoria ativado com sucesso";
                }
                if (b.Text == "Desativar")

                {
                    msg = "Categoria desativado com sucesso";
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
