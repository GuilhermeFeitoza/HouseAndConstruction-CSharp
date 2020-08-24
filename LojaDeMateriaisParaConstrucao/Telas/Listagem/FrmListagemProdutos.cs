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
    public partial class FrmListagemProdutos : Modelos.FrmConsulta
    {
        public FrmListagemProdutos()
        {
            InitializeComponent();
            CarregarDadosGrid();

        }



        public void CarregarDadosGrid()
        {
            try
            {
                BLL.Produto prod = new BLL.Produto();
                dataGridView1.DataSource = prod.Listar(textBox1.Text.Trim().ToUpper(), 1).Tables[0];
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
                if (MessageBox.Show("Deseja " + b.Text + " o produto ?", "Atencao", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                BLL.Produto prod = new BLL.Produto();
                prod.CodigoProduto = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                //propriedade '.codigo' do objeto 'usu' recebe '=' o valor 'value' da primeira coluna 'cells[0]' da linha atual 'currentrow' do grid 'datagridview1'
                switch (b.Text)
                {
                    case "Excluir": prod.Excluir(); break;
                    case "Ativar": prod.Ativar(); break;
                    case "Desativar": prod.Desativar(); break;

                }
                MessageBox.Show("Sucesso em  " + b.Text + " o produto", "Sucesso");
                CarregarDadosGrid();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void ConsultarProduto(Object o, EventArgs e)
        {
            try
            {
                Telas.Cadastrar.FrmProduto p = new Cadastrar.FrmProduto();
                p.txtNome.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                p.txtDesc.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                p.cbUnidadeVenda.SelectedValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
                p.txtCodB.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
               // p.txtQuant.Value =  Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);
                p.txtEstqMinimo.Value = Convert.ToInt16(dataGridView1.CurrentRow.Cells[6].Value);
                p.txtEstqMax.Value = Convert.ToInt16(dataGridView1.CurrentRow.Cells[7].Value);
                p.cbFornecedor.SelectedValue = Convert.ToInt16(dataGridView1.CurrentRow.Cells[8].Value);
                p.cbCategoria.SelectedValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[9].Value);
                p.txtDataEntrada.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[10].Value);
                p.txtMarca.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[11].Value);
                p.imagem = Convert.ToString(dataGridView1.CurrentRow.Cells[12].Value);
                p.txtValor.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[14].Value);

                p.pcbFoto.ImageLocation = p.imagem;
                p.pcbFoto.Click -= p.SalvarFoto;
                p.button1.Visible = true;
                p.txtDesc.ReadOnly = true;
                p.txtQuant.ReadOnly = true;
                p.label1.Visible = false;
                p.txtQuant.Visible = false;
                p.txtNome.ReadOnly = true;
                p.cbUnidadeVenda.Enabled = true;
                p.txtCodB.ReadOnly = true;
                p.txtEstqMinimo.ReadOnly = true;
                p.txtEstqMax.ReadOnly = true;
                p.cbCategoria.Enabled = true;
                p.txtDataEntrada.ReadOnly = true;
                p.txtMarca.ReadOnly = true;
                p.cbFornecedor.Enabled = true;
                p.label5.Text = "Consultando Produto";
                p.button1.Visible = false;
                p.ShowDialog();
                





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                throw ex;
            }


        }

        private void EditarProduto(object o, EventArgs e)
        {
            Telas.Editar.FrmEdicaoProduto p = new Editar.FrmEdicaoProduto();
            p.Codigo = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            p.txtNome.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            p.txtDesc.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            p.cbUnidadeVenda.SelectedValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
            p.txtCodB.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            // p.txtQuant.Value =  Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);
            p.txtEstqMinimo.Value = Convert.ToInt16(dataGridView1.CurrentRow.Cells[6].Value);
            p.txtEstqMax.Value = Convert.ToInt16(dataGridView1.CurrentRow.Cells[7].Value);
            p.cbFornecedor.SelectedValue = Convert.ToInt16(dataGridView1.CurrentRow.Cells[8].Value);
            p.cbCategoria.SelectedValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[9].Value);
            p.txtDataEntrada.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[10].Value);
            p.txtMarca.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[11].Value);
            p.imagem = Convert.ToString(dataGridView1.CurrentRow.Cells[12].Value);
            p.txtValor.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[14].Value);
            p.pcbFoto.ImageLocation = p.imagem;

            p.ShowDialog();


        }





        private void button1_Click(object sender, EventArgs e)
        {
            Cadastrar.FrmProduto p = new Cadastrar.FrmProduto();


            p.ShowDialog();

        }
    }
}
