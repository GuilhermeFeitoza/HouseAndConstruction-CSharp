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
    public partial class FrmListagemProdutos : Modelos.FrmConsulta
    {
        public FrmListagemProdutos()
        {
            InitializeComponent();
        }

        public void CarregarDadosGrid()
        {
            try
            {
                BLL.Produto p = new BLL.Produto();
                dataGridView1.DataSource = p.Listar(textBox1.Text.Trim().ToUpper(), 1).Tables[0];
                textBox1.Focus();

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

        private void Fixar(Object o, EventArgs e)
        {
            try
            {
                //o é objeto que foi clicado
                var b = (Button)o;
                //variávl 'b' é o botão 'o'
                if (MessageBox.Show(b.Text, "Atencao", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                BLL.Produto p = new BLL.Produto();
                p.CodigoProduto = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                //propriedade '.codigo' do objeto 'usu' recebe '=' o valor 'value' da primeira coluna 'cells[0]' da linha atual 'currentrow' do grid 'datagridview1'
                switch (b.Text)
                {
                    case "Excluir": p.Excluir(); break;
                    case "Ativar": p.Ativar(); break;
                    case "Desativar": p.Desativar(); break;

                }
                String msg = "";
                if (b.Text == "Editar")
                {
                    msg = "Produto editado com sucesso";


                }
                if (b.Text == "Ativar")

                {
                    msg = "Produto ativado com sucesso";
                }
                if (b.Text == "Desativar")

                {
                    msg = "Prouduto desativado com sucesso";
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

        public void CadastrarNovo(object o , EventArgs e) {

            Cadastrar.FrmProduto p = new Cadastrar.FrmProduto();
            p.ShowDialog();



        }


        public void ConsultarProduto(object o, EventArgs e) {

            Cadastrar.FrmProduto p = new Cadastrar.FrmProduto();
            p.label1.Text = "Consultando produto";
            p.txtNomeProduto.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            p.cbUnidadeVenda.SelectedValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            p.cbFornecedor.SelectedValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
            p.cbCategoria.SelectedValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
            p.txtValor.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);

            p.txtNomeProduto.ReadOnly = true;
            p.txtValor.ReadOnly = true;
            p.button1.Visible = false;
            p.ShowDialog();

        }

        public void EditarProduto(object o, EventArgs e) {

            Telas.Editar.FrmEditarProduto p = new Editar.FrmEditarProduto();
            p.txtCodigo.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            p.txtNomeProduto.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            p.cbUnidadeVenda.SelectedValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            p.cbFornecedor.SelectedValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
            p.cbCategoria.SelectedValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
            p.txtValor.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
            p.ShowDialog();







        }
    }
}
