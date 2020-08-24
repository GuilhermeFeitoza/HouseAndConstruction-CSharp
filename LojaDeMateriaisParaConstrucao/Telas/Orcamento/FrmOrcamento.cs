using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace LojaDeMateriaisParaConstrucao.Telas.Orcamento
{
    public partial class FrmOrcamento : Venda.FrmVendas
    {
        public FrmOrcamento()
        {
            InitializeComponent();
            btnFinalizar.Click -=FinalizarVenda;

        }
        public Decimal totalOrcamento;
        private void FinalizarOrcamento(object o, EventArgs e) {
            try
            {
                BLL.Orcamento or = new BLL.Orcamento();
                or.CodigoCliente = Codigo;
                or.CodigoFuncionario = CodigoVendedor;
                or.DataOrcamento = DateTime.Today;



                foreach (DataGridViewRow row in dataGridView1.Rows.Cast<DataGridViewRow>()
                .Where(t => !string.IsNullOrEmpty(t.Cells["ValorTot"].Value?.ToString())))
                {
                    totalOrcamento += Convert.ToDecimal(row.Cells["ValorTot"].Value);



                }

                or.ValorTotal = Convert.ToDouble(totalOrcamento);
                or.IncluirComParametro();
                SalvarProdutosOrcamento();                        
                MessageBox.Show("Orçamento finalizado com sucesso");
                GerarPDF3(o, e);
                   Close();

            }
            catch (Exception ex)

            {

                throw ex;
            }










        }
        private void SalvarProdutosOrcamento() {



            BLL.Orcamento v = new BLL.Orcamento();
            int CodigoUltimoOrcamento = v.RetornarOrcamento();
            int CodigoProdutoGrid = 0;
            //foreachzinho para pegar linha por linha e depois ir inserindo na tabela linha por linha
            foreach (DataGridViewRow row in dataGridView1.Rows.Cast<DataGridViewRow>()
                    .Where(t => !string.IsNullOrEmpty(t.Cells["CodProd"].Value?.ToString())))
            {

                try
                {
                    CodigoProdutoGrid = Convert.ToInt32(row.Cells["CodProd"].Value);
                    TCC_Inf2Dm.ClasseParaManipularBancoDeDados c = new TCC_Inf2Dm.ClasseParaManipularBancoDeDados();

                    string comando;

                    SqlParameter[] listaComParametros = {
                   new SqlParameter("@CodigoOrcamento",SqlDbType.Int) {Value = CodigoUltimoOrcamento },
                   new SqlParameter("@CodigoProduto",SqlDbType.Int) {Value = CodigoProdutoGrid },

                };

                    comando = "INSERT INTO tbItem_Orcamento(CodigoOrcamento,CodigoProduto) Values (@CodigoOrcamento,@CodigoProduto)";
                    c.ExecutarComandoParametro(comando, listaComParametros);


                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }











        }

        private void GerarPDF3(object o, EventArgs e)
        {


            //Cria O documento
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 10, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Orcamento.pdf", FileMode.Create));
            doc.Open();
            //Adiciona o logo
            iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance("Logo.png");
            PNG.ScalePercent(85f);
            doc.Add(PNG);
            //Titulo
            Paragraph header = new Paragraph("Informações do Orçamento ", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14f, iTextSharp.text.Font.BOLD, BaseColor.BLACK));
            header.Alignment = Element.ALIGN_LEFT;
            doc.Add(header);


            //Info sobre venda
            var blackListTextFont = FontFactory.GetFont("Calibri_BOLD", 14, BaseColor.BLACK);
            var redListTextFont = FontFactory.GetFont("Calibri", 12, BaseColor.BLACK);

            //Cli:

            iTextSharp.text.Image cliente = iTextSharp.text.Image.GetInstance("User_32px.png");
            cliente.ScaleToFit(20f, 20f);
            Chunk imageCliente = new Chunk(cliente, 0, -4);

            var titleChunk = new Chunk("  Cliente: ", blackListTextFont);
            var descriptionChunk = new Chunk(txtCliente.Text + "\n", redListTextFont);
            var phrase = new Phrase(imageCliente);
            phrase.Add(titleChunk);
            phrase.Add(descriptionChunk);
            doc.Add(phrase);




            //Funcionario
            iTextSharp.text.Image image3 = iTextSharp.text.Image.GetInstance("User_32px.png");
            image3.ScaleToFit(20f, 20f);
            Chunk imageChunk3 = new Chunk(image3, 0, -4);

            var FuncionarioChunk = new Chunk("  Funcionário Responsavel: ", blackListTextFont);
            var nomeFuncionarioChunk = new Chunk(txtVendedor.Text + "\n", redListTextFont);
            var phraseFuncionario = new Phrase(imageChunk3);
            phraseFuncionario.Add(FuncionarioChunk);
            phraseFuncionario.Add(nomeFuncionarioChunk);
            doc.Add(phraseFuncionario);


            //ValorOrcamento

            iTextSharp.text.Image image2 = iTextSharp.text.Image.GetInstance("Duration Finance_50px.png");
            image2.ScaleToFit(20f, 20f);
            Chunk imageChunk2 = new Chunk(image2, 0, -4);
            var titleChunk2 = new Chunk("  Valor do Orçamento: ", blackListTextFont);
            var descriptionChunk2 = new Chunk(lblValorTotalDaVenda.Text + "\n", redListTextFont);
            var phrase2 = new Phrase(imageChunk2);
            phrase2.Add(titleChunk2);
            phrase2.Add(descriptionChunk2);
            doc.Add(phrase2);

            //DataOrçamento

            iTextSharp.text.Image imagemData = iTextSharp.text.Image.GetInstance("Schedule_50px.png");
            imagemData.ScaleToFit(20f, 20f);
            Chunk imagemChunkData = new Chunk(imagemData, 0, -4);
            var titleChunk3 = new Chunk("  Data do Orçamento: ", blackListTextFont);
            var descriptionChunk3 = new Chunk(Convert.ToString(DateTime.Now) + "\n", redListTextFont);
            var phrase3 = new Phrase(imagemChunkData);
            phrase3.Add(titleChunk3);
            phrase3.Add(descriptionChunk3);
            doc.Add(phrase3);


            //Frma
            iTextSharp.text.Image imagemPgto = iTextSharp.text.Image.GetInstance("Bank Cards_48px.png");
            imagemPgto.ScaleToFit(20f, 20f);
            Chunk imagemChunkPgto = new Chunk(imagemPgto, 0, -6);
            var titleChunk4 = new Chunk("  Forma de pagamento: ", blackListTextFont);
            var descriptionChunk4 = new Chunk(comboBox1.Text + "\n", redListTextFont);
            var phrase4 = new Phrase(imagemChunkPgto);
            phrase4.Add(titleChunk4);
            phrase4.Add(descriptionChunk4);
            doc.Add(phrase4);

            //Titulo2
            Paragraph paragraph = new Paragraph("Produtos do Orçamento \n              ", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20f, iTextSharp.text.Font.BOLD, BaseColor.BLACK));
            paragraph.Alignment = Element.ALIGN_CENTER;
            doc.Add(paragraph);


            //Produtos do Orçamento

            PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);

            //table.AddCell(cell);

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                table.AddCell(new Phrase(dataGridView1.Columns[i].HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9f, iTextSharp.text.Font.BOLD, BaseColor.BLACK)));
            }
            table.HeaderRows = 1;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int k = 0; k < dataGridView1.Columns.Count; k++)
                {
                    if (dataGridView1[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(dataGridView1[k, i].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8f, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)));
                    }

                }
            }

            doc.Add(table);
            //Finaliza o pdf
            doc.Close();

            //Abre o Pdf Gerado
            System.Diagnostics.Process.Start("Orcamento.pdf");





        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
