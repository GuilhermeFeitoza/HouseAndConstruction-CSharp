using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDeMateriaisParaConstrucao.Telas.ControleDeEstoque
{
    public partial class FrmControleDeEstoque : Modelos.FrmCabeçalhoECorp
    {
        public FrmControleDeEstoque()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void CarregarGrid() {
            BLL.Estoque est = new BLL.Estoque();
            dataGridView1.DataSource = est.ExibirEstoque(txtPesquisaTitulo.Text.Trim().ToUpper()).Tables[0];
           
            //a propriedade DATASOURCE do datagrid é a fonte de dados. Esta propriedade recebe (=) do objeto USU o método LISTAR usando como parametro o texto TEXT.TRIM().TOUPPER() digitado no TEXTBOX1. Esse DATASOURCE usará a tabela zero TABLES[0] do método LISTAR



        }

        private void Exibir(Object o, EventArgs e)
        {
            CarregarGrid();
            if (o == btnFiltrar)
            {
                txtPesquisaTitulo.Text = String.Empty;
            }
            txtPesquisaTitulo.Focus();

        }

        private void RegistrarEntrada(Object o, EventArgs e) {
            FrmRegistrarEntrada f = new FrmRegistrarEntrada();
            f.ShowDialog();
            Dispose();



        }

        private void GerarPDF2(object o, EventArgs e)
        {
            MessageBox.Show("Para uma melhor visualização do relatório é recomendavel que seja impresso no modo paisagem.");
            Impressão.DGVPrinter p = new Impressão.DGVPrinter();

            p.Title = "Estoque";
            p.SubTitle = string.Format("Data : " +DateTime.Today);
            p.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            p.PageNumbers = true;
            p.PageNumberInHeader = false;
            p.PorportionalColumns = true;
            p.HeaderCellAlignment = StringAlignment.Near;
            p.Footer = "House and Construction";
            p.FooterSpacing = 15;
            p.PrintDataGridView(dataGridView1);






        }


    }
}
