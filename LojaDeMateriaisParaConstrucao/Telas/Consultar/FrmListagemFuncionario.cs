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
    public partial class FrmListagemFuncionario : Modelos.FrmConsulta
    {
        public FrmListagemFuncionario()
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
                BLL.Funcionario fcu = new BLL.Funcionario();
                dataGridView1.DataSource = fcu.Listar(textBox1.Text.Trim().ToUpper(), 1).Tables[0];
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

        private void EditarFuncionario(Object o, EventArgs e)
        {
            try
            {
                Telas.Editar.FrmEdicaorFuncionario fcu = new Editar.FrmEdicaorFuncionario();
                fcu.label1.Text = "Editando Funcionário";
                fcu.txtCod.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
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
                fcu.txtComplemento.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[8].Value);
                fcu.txtEmail.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[9].Value);
                fcu.txtTelefone.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[10].Value);
                //fcu..Text = Convert.ToString(dataGridView1.CurrentRow.Cells[11].Value);
                fcu.txtSalario.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[12].Value);
                fcu.cbCargo.SelectedValue = Convert.ToString(dataGridView1.CurrentRow.Cells[13].Value);
                fcu.txtDataAdm.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[14].Value);
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

        private void ConsultarFuncionario(Object o, EventArgs e)
        {
            try
            {
                Telas.Cadastrar.FrmFuncionario fcu = new Cadastrar.FrmFuncionario();
                fcu.label1.Text = "Consultando o Funcionário";
                fcu.txtNome.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                if (Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value)== "f")
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
                fcu.txtComplemento.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[8].Value);
                fcu.txtEmail.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[9].Value);
                fcu.txtTelefone.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[10].Value);
                //fcu..Text = Convert.ToString(dataGridView1.CurrentRow.Cells[11].Value);
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
                fcu.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void NovoFuncionario(object o, EventArgs e)
        {
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
                if (MessageBox.Show("Deseja "+ b.Text + " o funcionário ?", "Atencao", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                BLL.Funcionario fuc = new BLL.Funcionario();
                fuc.CodigoFuncionario = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                //propriedade '.codigo' do objeto 'usu' recebe '=' o valor 'value' da primeira coluna 'cells[0]' da linha atual 'currentrow' do grid 'datagridview1'
                switch (b.Text)
                {
                    case "Excluir": fuc.Excluir(); break;
                    case "Ativar": fuc.Ativar(); break;
                    case "Desativar": fuc.Desativar(); break;

                }
                MessageBox.Show("Suceeso em "+ b.Text + "o funcionário", "Sucesso");
                CarregarDadosGrid();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Telas.Cadastrar.FrmFuncionario f = new Cadastrar.FrmFuncionario();
            f.ShowDialog();



        }
    }
}
