using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDeMateriaisParaConstrucao.Telas.Venda
{
    public partial class FrmListagemVendas : Modelos.FrmConsulta
    {
        public FrmListagemVendas()
        {
          
            InitializeComponent();
        
          
        }


        public void CarregarDadosGrid()
        {
            try
            {
                BLL.Venda ven = new BLL.Venda();
                dataGridView1.DataSource = ven.ListarVendas(textBox1.Text.Trim().ToUpper()).Tables[0];
                textBox1.Focus();


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

        private void NovaVenda(object o , EventArgs e) {

            Venda.FrmVendas v = new FrmVendas();
            v.ShowDialog();



        }
        private void GerarPDF3(object o, EventArgs e)
        {


            //Cria O documento
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 10, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Venda.pdf", FileMode.Create));
            doc.Open();
            //Adiciona o logo
            iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance("Logo.png");
            PNG.ScalePercent(85f);
            doc.Add(PNG);
            //Titulo
            Paragraph header = new Paragraph("Informações da venda ", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14f, iTextSharp.text.Font.BOLD, BaseColor.BLACK));
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
            var descriptionChunk = new Chunk(Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value) + "\n", redListTextFont);
            var phrase = new Phrase(imageCliente);
            phrase.Add(titleChunk);
            phrase.Add(descriptionChunk);
            doc.Add(phrase);




            //Funcionario
            iTextSharp.text.Image image3 = iTextSharp.text.Image.GetInstance("User_32px.png");
            image3.ScaleToFit(20f, 20f);
            Chunk imageChunk3 = new Chunk(image3, 0, -4);

            var FuncionarioChunk = new Chunk("  Funcionário Responsavel: ", blackListTextFont);
            var nomeFuncionarioChunk = new Chunk(Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value) + "\n", redListTextFont);
            var phraseFuncionario = new Phrase(imageChunk3);
            phraseFuncionario.Add(FuncionarioChunk);
            phraseFuncionario.Add(nomeFuncionarioChunk);
            doc.Add(phraseFuncionario);


            //ValorDaVenda

            iTextSharp.text.Image image2 = iTextSharp.text.Image.GetInstance("Duration Finance_50px.png");
            image2.ScaleToFit(20f, 20f);
            Chunk imageChunk2 = new Chunk(image2, 0, -4);
            var titleChunk2 = new Chunk("  Valor da Venda: ", blackListTextFont);
            var descriptionChunk2 = new Chunk(Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value) + "\n", redListTextFont);
            var phrase2 = new Phrase(imageChunk2);
            phrase2.Add(titleChunk2);
            phrase2.Add(descriptionChunk2);
            doc.Add(phrase2);

            //DataVenda

            iTextSharp.text.Image imagemData = iTextSharp.text.Image.GetInstance("Schedule_50px.png");
            imagemData.ScaleToFit(20f, 20f);
            Chunk imagemChunkData = new Chunk(imagemData, 0, -4);
            var titleChunk3 = new Chunk("  Data da Venda: ", blackListTextFont);
            var descriptionChunk3 = new Chunk(Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value) + "\n", redListTextFont);
            var phrase3 = new Phrase(imagemChunkData);
            phrase3.Add(titleChunk3);
            phrase3.Add(descriptionChunk3);
            doc.Add(phrase3);


            BLL.Venda v = new BLL.Venda();


            System.Data.SqlClient.SqlDataReader ddr;
            ddr = v.RetornarForma(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
            ddr.Read();
            if (ddr.HasRows)
            {
                //Frma
                iTextSharp.text.Image imagemPgto = iTextSharp.text.Image.GetInstance("Bank Cards_48px.png");
                imagemPgto.ScaleToFit(20f, 20f);
                Chunk imagemChunkPgto = new Chunk(imagemPgto, 0, -6);
                var titleChunk4 = new Chunk("  Forma de pagamento: ", blackListTextFont);
                var descriptionChunk4 = new Chunk(ddr["Nome"]+ "\n", redListTextFont);
                var phrase4 = new Phrase(imagemChunkPgto);
                phrase4.Add(titleChunk4);
                phrase4.Add(descriptionChunk4);
                doc.Add(phrase4);

            }




            //Titulo2
            Paragraph paragraph = new Paragraph("Produtos da Venda \n              ", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20f, iTextSharp.text.Font.BOLD, BaseColor.BLACK));
            paragraph.Alignment = Element.ALIGN_CENTER;
            doc.Add(paragraph);
            int CodigoVenda = 0;
            CodigoVenda = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            ;
            dgImpressao.DataSource = v.ListarItensVenda(CodigoVenda).Tables[0];

            PdfPTable table = new PdfPTable(dgImpressao.Columns.Count);
    
       



            //table.AddCell(cell);

            for (int i = 0; i < dgImpressao.Columns.Count; i++)
            {
                table.AddCell(new Phrase(dgImpressao.Columns[i].HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9f, iTextSharp.text.Font.BOLD, BaseColor.BLACK)));
            }
            table.HeaderRows = 1;
            for (int i = 0; i < dgImpressao.Rows.Count; i++)
            {
                for (int k = 0; k < dgImpressao.Columns.Count; k++)
                {
                    if (dgImpressao[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(dgImpressao[k, i].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8f, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)));
                    }

                }
            }

            doc.Add(table);
            //Finaliza o pdf
            doc.Close();

            //Abre o Pdf Gerado
            System.Diagnostics.Process.Start("Venda.pdf");





        }




    }
}
