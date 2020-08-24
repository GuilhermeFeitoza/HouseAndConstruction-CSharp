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
    public partial class ListagemNivelAcesso : Modelos.FrmConsulta
    {
        public ListagemNivelAcesso()
        {
            InitializeComponent();
        }

        private void NovoNivelDeAcesso(object o  , EventArgs e) {

            Telas.Cadastrar.FrmNIvelAcesso n = new Cadastrar.FrmNIvelAcesso();
            n.ShowDialog();




        }
        public void CarregarDadosGrid()
        {
            try
            {
                BLL.NivelAcesso niv = new BLL.NivelAcesso();
                dataGridView1.DataSource = niv.Listar(textBox1.Text.Trim().ToUpper(), 1).Tables[0];
                textBox1.Focus();
                //a propriedade DATASOURCE do datagrid é a fonte de dados. Esta propriedade recebe (=) do objeto USU o método LISTAR usando como parametro o texto TEXT.TRIM().TOUPPER() digitado no TEXTBOX1. Esse DATASOURCE usará a tabela zero TABLES[0] do método LISTAR

                if (dataGridView1.Rows.Count == 0)
                {
                    btnEditar.Enabled = false;
                    btnConsultar.Enabled = false;
                    btnAtivar.Enabled = false;
                    btnDesativar.Enabled = false;
                    btnExcluir.Enabled = false;



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
        public void Exibir(Object o, EventArgs e)
        {
            CarregarDadosGrid();
            if (o == btnfiltrar)
            {
                textBox1.Text = String.Empty;
            }
            textBox1.Focus();

        }

        private void ConsultarNivel(object o, EventArgs e) {

            Cadastrar.FrmNIvelAcesso n = new Cadastrar.FrmNIvelAcesso();
            n.label5.Text = "Consultando nivel de acesso";
            n.cbClientes.Enabled = false;
            n.cbFuncionarios.Enabled = false;
            n.cbFornecedores.Enabled = false;
            n.cbProdutos.Enabled = false;
            n.cbContas.Enabled = false;
            n.cbVender.Enabled = false;
            n.cbOrcamento.Enabled = false;
            n.cbUsuarios.Enabled = false;
            n.txtAbrevNivelAcesso.ReadOnly = true;
            n.txtDesc.ReadOnly = true;
            n.txtNomeNivelAcesso.ReadOnly = true;
            n.btnCadastrar.Visible = false;
            n.groupBox1.Text = "Dados do nivel de acesso";
            n.txtNomeNivelAcesso.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            n.txtAbrevNivelAcesso.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            n.txtDesc.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            if (Convert.ToInt16(dataGridView1.CurrentRow.Cells[4].Value) == 1)
            {
                n.cbUsuarios.Checked = true;

            }
            else
            {
                n.cbUsuarios.Checked = false;
            }
            if (Convert.ToInt16(dataGridView1.CurrentRow.Cells[5].Value) == 1)
            {
                n.cbClientes.Checked = true;

            }
            else
            {
                n.cbClientes.Checked = false;
            }

            if (Convert.ToInt16(dataGridView1.CurrentRow.Cells[6].Value) == 1)
            {
                n.cbFuncionarios.Checked = true;

            }
            else
            {
                n.cbFuncionarios.Checked = false;
            }

            if (Convert.ToInt16(dataGridView1.CurrentRow.Cells[7].Value) == 1)
            {
                n.cbFornecedores.Checked = true;

            }
            else
            {
                n.cbFornecedores.Checked = false;
            }

            if (Convert.ToInt16(dataGridView1.CurrentRow.Cells[8].Value) == 1)
            {
                n.cbProdutos.Checked = true;

            }
            else
            {
                n.cbProdutos.Checked = false;
            }

            if (Convert.ToInt16(dataGridView1.CurrentRow.Cells[9].Value) == 1)
            {
                n.cbContas.Checked = true;

            }
            else
            {
                n.cbContas.Checked = false;
            }

            if (Convert.ToInt16(dataGridView1.CurrentRow.Cells[10].Value) == 1)
            {
                n.cbVender.Checked = true;

            }
            else
            {
                n.cbVender.Checked = false;
            }

            if (Convert.ToInt16(dataGridView1.CurrentRow.Cells[11].Value) == 1)
            {
                n.cbOrcamento.Checked = true;

            }
            else
            {
                n.cbOrcamento.Checked = false;
            }

            n.ShowDialog();


        }

        private void EditarNivel(object o ,EventArgs e) {



            Editar.FrmEdicaoNivelAcesso n = new Editar.FrmEdicaoNivelAcesso();
            n.label5.Text = "Editando nivel de acesso";
            n.CodigoNiv =Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            n.groupBox1.Text = "Dados do nivel de acesso";
          
            n.txtNomeNivelAcesso.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            n.txtAbrevNivelAcesso.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            n.txtDesc.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            if (Convert.ToInt16(dataGridView1.CurrentRow.Cells[4].Value) == 1)
            {
                n.cbUsuarios.Checked = true;

            }
            else
            {
                n.cbUsuarios.Checked = false;
            }
            if (Convert.ToInt16(dataGridView1.CurrentRow.Cells[5].Value) == 1)
            {
                n.cbClientes.Checked = true;

            }
            else
            {
                n.cbClientes.Checked = false;
            }

            if (Convert.ToInt16(dataGridView1.CurrentRow.Cells[6].Value) == 1)
            {
                n.cbFuncionarios.Checked = true;

            }
            else
            {
                n.cbFuncionarios.Checked = false;
            }

            if (Convert.ToInt16(dataGridView1.CurrentRow.Cells[7].Value) == 1)
            {
                n.cbFornecedores.Checked = true;

            }
            else
            {
                n.cbFornecedores.Checked = false;
            }

            if (Convert.ToInt16(dataGridView1.CurrentRow.Cells[8].Value) == 1)
            {
                n.cbProdutos.Checked = true;

            }
            else
            {
                n.cbProdutos.Checked = false;
            }

            if (Convert.ToInt16(dataGridView1.CurrentRow.Cells[9].Value) == 1)
            {
                n.cbContas.Checked = true;

            }
            else
            {
                n.cbContas.Checked = false;
            }

            if (Convert.ToInt16(dataGridView1.CurrentRow.Cells[10].Value) == 1)
            {
                n.cbVender.Checked = true;

            }
            else
            {
                n.cbVender.Checked = false;
            }

            if (Convert.ToInt16(dataGridView1.CurrentRow.Cells[11].Value) == 1)
            {
                n.cbOrcamento.Checked = true;

            }
            else
            {
                n.cbOrcamento.Checked = false;
            }

            n.ShowDialog();
            Dispose();
         


        }



        private void Fixar(Object o, EventArgs e)
        {
            try
            {
                //o é objeto que foi clicado
                var b = (Button)o;
                //variávl 'b' é o botão 'o'
                if (MessageBox.Show(b.Text, "Atencao", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                BLL.NivelAcesso forn = new BLL.NivelAcesso();
                forn.CodigoNivelAcesso = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                //propriedade '.codigo' do objeto 'usu' recebe '=' o valor 'value' da primeira coluna 'cells[0]' da linha atual 'currentrow' do grid 'datagridview1'
                switch (b.Text)
                {
                    case "Excluir": forn.Excluir(); break;
                    case "Ativar": forn.Ativar(); break;
                    case "Desativar": forn.Desativar(); break;

                }
                String msg = "";
                if (b.Text == "Editar")
                {
                    msg = "Nivel de acesso editado com sucesso";


                }
                if (b.Text == "Ativar")

                {
                    msg = "Nivel de acesso  ativado com sucesso";
                }
                if (b.Text == "Desativar")

                {
                    msg = "Nivel de acesso  desativado com sucesso";
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
