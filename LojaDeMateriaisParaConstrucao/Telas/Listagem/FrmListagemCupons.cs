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
    public partial class FrmListagemCupons : Modelos.FrmConsulta
    {
        public FrmListagemCupons()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
        public void CarregarDadosGrid()
        {
            try
            {
                BLL.Cupom c = new BLL.Cupom();
                dataGridView1.DataSource = c.ListarCupons(textBox1.Text.Trim().ToUpper()).Tables[0];
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cadastrar.FrmCupom c = new Cadastrar.FrmCupom();
            c.Text = "Alterar Cupom";
            c.label5.Text = "Alterar  cupom";
            c.Codigo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            c.txtDesc.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            c.txtCodB.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            c.txtValor.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            c.mskDataIni.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            c.mskDatafim.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            c.button1.Text = "Alterar";
            c.button1.Click -= c.button1_Click;
            c.button1.Click += c.Alterar;
               
            c.ShowDialog();
            CarregarDadosGrid();


        }

        private void Fixar(Object o, EventArgs e)
        {
            try
            {
                //o é objeto que foi clicado
                var b = (Button)o;
                //variávl 'b' é o botão 'o'
                if (MessageBox.Show(b.Text, "Atencao", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                BLL.Cupom cl = new BLL.Cupom();
                cl.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                //propriedade '.codigo' do objeto 'usu' recebe '=' o valor 'value' da primeira coluna 'cells[0]' da linha atual 'currentrow' do grid 'datagridview1'
                switch (b.Text)
                {
                  

                }
                String msg = "";
                if (b.Text == "Editar")
                {
                    msg = "Cupom editado com sucesso";


                }
                if (b.Text == "Ativar")

                {
                    msg = "Cupom ativado com sucesso";
                }
                if (b.Text == "Desativar")

                {
                    msg = "Cupom desativado com sucesso";
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
