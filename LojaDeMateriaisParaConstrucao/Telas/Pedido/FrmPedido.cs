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

namespace LojaDeMateriaisParaConstrucao.Telas.Pedido
{
    public partial class FrmPedido : Telas.Venda.FrmVendas
    {
        public FrmPedido()
        {
            InitializeComponent();
        }
        int CodigoDestinatario;
        decimal ValorTotalPedido;
        private void button2_Click(object sender, EventArgs e)
        {
            Cadastrar.FrmDestinatário dest = new Cadastrar.FrmDestinatário();
            dest.ShowDialog();

        }

        private void SelecionarDestinatario(object o, EventArgs e)
        {

            Telas.Pedido.SelecionarDestinatario s = new Telas.Pedido.SelecionarDestinatario();


            s.ShowDialog();

            txtDest.Text = s.Destinatario1;
            CodigoDestinatario = s.CodigoDestinatario1;




        }
        private void FinalizarPedido(object o, EventArgs e)
        {
            try
            {
                BLL.Pedido ped = new BLL.Pedido();
                ped.CodigoCliente = Codigo;
                ped.CodigoFuncionario = CodigoVendedor;
                ped.DataPedido = DateTime.Today;
                ped.DataEntrega = DateTime.Today.AddDays(10);

                foreach (DataGridViewRow row in dataGridView1.Rows.Cast<DataGridViewRow>()
                .Where(t => !string.IsNullOrEmpty(t.Cells["ValorTot"].Value?.ToString())))
                {
                    ValorTotalPedido += Convert.ToDecimal(row.Cells["ValorTot"].Value);



                }

                ped.ValorTotalPedido = Convert.ToDecimal(ValorTotalPedido);
                ped.CodigoDestinatario = CodigoDestinatario;
                ped.IncluirComParametro();
                RegistrarLogSaida();
                AtualizarEstoque();
                SalvarPagamentoVenda();
                BuscarDestinatario();

                MessageBox.Show("Pedido finalizado com sucesso");
                GerarPDF3(o, e);
                Close();


            }
            catch (Exception ex)

            {

                throw ex;
            }










        }
        String EnderecoDestinatarioPrint;
        String NomeDestinatarioPrint;

        private void SalvarPagamentoVenda()
        {
            try
            {
                BLL.Pedido ped = new BLL.Pedido();
                int CodigoUltimoPedido = ped.RetornarPedido();
                if (checkBox1.Checked)
                {

                    TCC_Inf2Dm.ClasseParaManipularBancoDeDados c = new TCC_Inf2Dm.ClasseParaManipularBancoDeDados();
                    string comando;
                    SqlParameter[] listaComParametros = {
                         new SqlParameter("@CodigoPedido",SqlDbType.Int) {Value = CodigoUltimoPedido },
                         new SqlParameter("@CodigoFormaPgto",SqlDbType.Int) {Value = Convert.ToInt32(comboBox1.SelectedValue) },
                         new SqlParameter ("@Valor",SqlDbType.Decimal) { Value = totalVenda/2}
                            };
                    comando = "INSERT INTO tbPgto_Pedido(CodigoPedido,CodigoFormaPgto,ValorForma) Values (@CodigoPedido,@CodigoFormaPgto,@Valor)";
                    c.ExecutarComandoParametro(comando, listaComParametros);

                    SqlParameter[] listaComParametros2 = {
                         new SqlParameter("@CodigoPedido",SqlDbType.Int) {Value = CodigoUltimoPedido },
                         new SqlParameter("@CodigoFormaPgto2",SqlDbType.Int) {Value = Convert.ToInt32(comboBox2.SelectedValue) },
                         new SqlParameter ("@Valor",SqlDbType.Decimal) { Value = totalVenda/2}
                            };
                    comando = "INSERT INTO tbPgto_Pedido(CodigoPedido,CodigoFormaPgto,ValorForma) Values (@CodigoVenda,@CodigoFormaPgto2,@Valor)";
                    c.ExecutarComandoParametro(comando, listaComParametros2);


                }
                else
                {

                    TCC_Inf2Dm.ClasseParaManipularBancoDeDados c = new TCC_Inf2Dm.ClasseParaManipularBancoDeDados();
                    string comando;
                    SqlParameter[] listaComParametros = {
                         new SqlParameter("@CodigoPedido",SqlDbType.Int) {Value = CodigoUltimoPedido },
                         new SqlParameter("@CodigoFormaPgto",SqlDbType.Int) {Value = Convert.ToInt32(comboBox1.SelectedValue)},
                         new SqlParameter ("@Valor",SqlDbType.Decimal) { Value = totalVenda}
                            };
                    comando = "INSERT INTO tbPgto_Pedido(CodigoPedido,CodigoFormaPgto,ValorForma) Values (@CodigoPedido,@CodigoFormaPgto,@Valor)";
                    c.ExecutarComandoParametro(comando, listaComParametros);



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }









        }

        private void BuscarDestinatario()
        {
            BLL.Destinatario d = new BLL.Destinatario();
            SqlDataReader ddr =
                d.RetornarEndereco(CodigoDestinatario);
            ddr.Read();
            if (ddr.HasRows)
            {

                EnderecoDestinatarioPrint = Convert.ToString(ddr["EnderecoDestinatario"])+","+Convert.ToString(ddr["NumeroDestinatario"]);
                NomeDestinatarioPrint = Convert.ToString(ddr["NomeDestinatario"]);
            }






        }

        private void GerarPDF3(object o, EventArgs e)
        {


            //Cria O documento
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 10, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Pedido.pdf", FileMode.Create));
            doc.Open();
            //Adiciona o logo
            iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance("Logo.png");
            PNG.ScalePercent(85f);
            doc.Add(PNG);
            //Titulo
            Paragraph header = new Paragraph("Informações do Pedido ", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14f, iTextSharp.text.Font.BOLD, BaseColor.BLACK));
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


            //ValorDaVenda

            iTextSharp.text.Image image2 = iTextSharp.text.Image.GetInstance("Duration Finance_50px.png");
            image2.ScaleToFit(20f, 20f);
            Chunk imageChunk2 = new Chunk(image2, 0, -4);
            var titleChunk2 = new Chunk("  Valor do Pedido: ", blackListTextFont);
            var descriptionChunk2 = new Chunk(lblValorTotalDaVenda.Text + "\n", redListTextFont);
            var phrase2 = new Phrase(imageChunk2);
            phrase2.Add(titleChunk2);
            phrase2.Add(descriptionChunk2);
            doc.Add(phrase2);

            //DataVenda

            iTextSharp.text.Image imagemData = iTextSharp.text.Image.GetInstance("Schedule_50px.png");
            imagemData.ScaleToFit(20f, 20f);
            Chunk imagemChunkData = new Chunk(imagemData, 0, -4);
            var titleChunk3 = new Chunk("  Data do Pedido: ", blackListTextFont);
            var descriptionChunk3 = new Chunk(Convert.ToString(DateTime.Now) + "\n", redListTextFont);
            var phrase3 = new Phrase(imagemChunkData);
            phrase3.Add(titleChunk3);
            phrase3.Add(descriptionChunk3);
            doc.Add(phrase3);


            //DataVenda



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


            //INfo Entrega
            Paragraph header1 = new Paragraph("Informações da Entrega ", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14f, iTextSharp.text.Font.BOLD, BaseColor.BLACK));
            header.Alignment = Element.ALIGN_LEFT;
            doc.Add(header1);




            //Endereço da entrega 
            iTextSharp.text.Image imagemEnd2 = iTextSharp.text.Image.GetInstance("User_32px.png");
            imagemEnd2.ScaleToFit(20f, 20f);
            Chunk imagemChunkEnd2 = new Chunk(imagemEnd2, 0, -6);
            var titleChunckEnd2 = new Chunk("  Nome do destinatario : ", blackListTextFont);
            // BuscarDestinatario();
            var DescriptionEnd2 = new Chunk(NomeDestinatarioPrint + "\n", redListTextFont);
            var phraseEnd2 = new Phrase(imagemChunkEnd2);
            phraseEnd2.Add(titleChunckEnd2);
            phraseEnd2.Add(DescriptionEnd2);
            doc.Add(phraseEnd2);



            iTextSharp.text.Image imagemEnd = iTextSharp.text.Image.GetInstance("icons8_Marker_64px_1.png");
            imagemEnd.ScaleToFit(20f, 20f);
           Chunk imagemChunkEnd = new Chunk(imagemEnd, 0, -6);
            var titleChunckEnd = new Chunk("  Endereço de entrega: ", blackListTextFont);
            // BuscarDestinatario();
            var DescriptionEnd = new Chunk(EnderecoDestinatarioPrint + "\n" + "\n", redListTextFont);
            var phraseEnd = new Phrase(imagemChunkEnd);
            phraseEnd.Add(titleChunckEnd);
            phraseEnd.Add(DescriptionEnd);
            doc.Add(phraseEnd);



            iTextSharp.text.Image imagemData1 = iTextSharp.text.Image.GetInstance("Schedule_50px.png" + "\n");
            imagemData1.ScaleToFit(20f, 20f);
            Chunk imagemChunkData1 = new Chunk(imagemData, 0, -4);
            var titleChunk31 = new Chunk("  Data de Entrega: ", blackListTextFont);
            DateTime date = DateTime.Today.AddDays(10);


            var descriptionChunk31 = new Chunk(date.ToString("dd/MM/yyyy"), redListTextFont);
            var phrase31 = new Phrase(imagemChunkData1);
            phrase31.Add(titleChunk31);
            phrase31.Add(descriptionChunk31);
            doc.Add(phrase31);








            //Titulo2
            Paragraph paragraph = new Paragraph("Produtos do Pedido \n              ", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20f, iTextSharp.text.Font.BOLD, BaseColor.BLACK));
            paragraph.Alignment = Element.ALIGN_CENTER;
            doc.Add(paragraph);


            //Produtos da venda

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
            System.Diagnostics.Process.Start("Pedido.pdf");





        }

        private void AtualizarEstoque()
        {




            BLL.Estoque est = new BLL.Estoque();
            int CodigoProdutoGrid = 0;
            int QuantidadeProdutoGrid = 0;
            //foreachzinho para pegar linha por linha e depois ir inserindo na tabela linha por linha
            foreach (DataGridViewRow row in dataGridView1.Rows.Cast<DataGridViewRow>()
                    .Where(t => !string.IsNullOrEmpty(t.Cells["CodProd"].Value?.ToString())))
            {

                try
                {
                    CodigoProdutoGrid = Convert.ToInt32(row.Cells["CodProd"].Value);
                    QuantidadeProdutoGrid = Convert.ToInt32(row.Cells["QuantProd"].Value);
                    TCC_Inf2Dm.ClasseParaManipularBancoDeDados c = new TCC_Inf2Dm.ClasseParaManipularBancoDeDados();

                    string comando;

                    SqlParameter[] listaComParametros = {

                   new SqlParameter("@CodigoProduto",SqlDbType.Int) {Value = CodigoProdutoGrid },
                    new SqlParameter("@Quantidade",SqlDbType.Int) {Value = QuantidadeProdutoGrid },

                };

                    comando = "UPDATE tbEstoque SET QuantidadeAtual=QuantidadeAtual-@Quantidade WHERE CodigoProduto=@CodigoProduto";
                    c.ExecutarComandoParametro(comando, listaComParametros);


                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }



















        }
        private void RegistrarLogSaida()
        {

            BLL.Estoque est = new BLL.Estoque();
            int CodigoProdutoGrid = 0;
            int QuantidadeProdutoGrid = 0;
            //foreachzinho para pegar linha por linha e depois ir inserindo na tabela linha por linha
            foreach (DataGridViewRow row in dataGridView1.Rows.Cast<DataGridViewRow>()
                    .Where(t => !string.IsNullOrEmpty(t.Cells["CodProd"].Value?.ToString())))
            {

                try
                {
                    CodigoProdutoGrid = Convert.ToInt32(row.Cells["CodProd"].Value);
                    QuantidadeProdutoGrid = Convert.ToInt32(row.Cells["QuantProd"].Value);
                    TCC_Inf2Dm.ClasseParaManipularBancoDeDados c = new TCC_Inf2Dm.ClasseParaManipularBancoDeDados();

                    string comando;

                    SqlParameter[] listaComParametros = {

                    new SqlParameter("@CodigoProduto",SqlDbType.Int) {Value = CodigoProdutoGrid },
                    new SqlParameter("@Quantidade",SqlDbType.Int) {Value = QuantidadeProdutoGrid },
                    new SqlParameter("@Data",SqlDbType.DateTime) {Value = DateTime.Today },

                };

                    comando = "INSERT INTO tbLog_Saida_Produto(CodigoProduto,Quantidade,DataSaida) VALUES (@CodigoProduto, @Quantidade,@Data)";
                    c.ExecutarComandoParametro(comando, listaComParametros);


                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }



















        }





    }
}
