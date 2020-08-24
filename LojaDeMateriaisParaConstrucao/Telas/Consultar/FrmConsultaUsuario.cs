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
    public partial class FrmConsultaUsuario : Modelos.FrmConsulta
    {
        public FrmConsultaUsuario()
        {
            InitializeComponent();
        }


        private void ExibirAtivos(Object o, EventArgs e)
        {
            try
            {
                BLL.Usuario usu = new BLL.Usuario();
                dataGridView1.DataSource = usu.ListarAtivos().Tables[0];

                if (dataGridView1.Rows.Count == 0)
                {
                    btnEditar.Visible = false;
                    btnConsultar.Enabled = false;
                }
                else
                {
                    btnEditar.Visible = true;
                    btnConsultar.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void ExibirInativos(Object o, EventArgs e)
        {
            try
            {
                BLL.Usuario usu = new BLL.Usuario();
                dataGridView1.DataSource = usu.ListarInativos().Tables[0];

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



        public void CarregarDadosGrid()
        {
            try
            {
                BLL.Usuario usu = new BLL.Usuario();
                dataGridView1.DataSource = usu.Listar(textBox1.Text.Trim().ToUpper(), 1).Tables[0];
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

        private void EditarUsuario(Object o, EventArgs e)
        {
            try
            {
                Telas.Editar.FrmEdicaoUsuario frm = new Editar.FrmEdicaoUsuario();
                frm.textBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                frm.txtNomeEdicao.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                frm.txtSenhaEdicao.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                this.Close();
                frm.ShowDialog();
                //  Form menu = new frm2();
                



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


        private void ConsultarUsuario(Object o, EventArgs e)
        {
            try
            {
                Telas.Cadastrar.FrmUsuario fcu = new Cadastrar.FrmUsuario();
                fcu.label1.Text = "Consultando o Usuário";
                fcu.txtNome.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                fcu.txtSenha.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                fcu.txtNome.ReadOnly = true;
                fcu.txtSenha.ReadOnly = true;
                fcu.txtSenha.PasswordChar = '\0';
                fcu.label4.Visible = false;
                fcu.txtSenha2.Visible = false;
                fcu.button1.Visible = false;
               
                fcu.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void NovoUsuario(object o, EventArgs e) {
            Telas.Cadastrar.FrmUsuario f = new Telas.Cadastrar.FrmUsuario();
            f.ShowDialog();
                
            
                



        }
            



        private void Fixar(Object o, EventArgs e)
        {
            try
            {
                //o é objeto que foi clicado
                var b = (Button)o;
                //variávl 'b' é o botão 'o'
                if (MessageBox.Show(b.Text, "Atencao", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                BLL.Usuario usu = new BLL.Usuario();
                usu.CodigoUsuario = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                //propriedade '.codigo' do objeto 'usu' recebe '=' o valor 'value' da primeira coluna 'cells[0]' da linha atual 'currentrow' do grid 'datagridview1'
                switch (b.Text)
                {
                    case "Excluir": usu.Excluir(); break;
                    case "Ativar": usu.Ativar(); break;
                    case "Desativar": usu.Desativar(); break;

                }
                MessageBox.Show(b.Text, "Sucesso");
                CarregarDadosGrid();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
