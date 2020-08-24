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
namespace LojaDeMateriaisParaConstrucao.Telas.Venda
{



    public partial class FrmVendas : Form
    {
        public FrmVendas()
        {
            InitializeComponent();


            dataGridView1.Columns["ValorTot"].DefaultCellStyle.Format = "C2";
            SalvarProdutos();
          
        }


        private static int codigoVendedor;
        public static int Codigo { get; set; }
        public static String NomeCliente { get; set; }

        public static int CodigoVendedor
        {
            get
            {
                return codigoVendedor;
            }

            set
            {
                codigoVendedor = value;
            }
        }


        private void SelecionarCliente(object o, EventArgs e)
        {

            Telas.Venda.FrmSelecionarCliente s = new Telas.Venda.FrmSelecionarCliente();


            s.ShowDialog();

            txtCliente.Text = s.Cliente;
            Codigo = s.CodigoCliente;



        }
        private void SelecionarVendedor(object o, EventArgs e)
        {

            Telas.Venda.FrmSelecionarVendedor s = new Telas.Venda.FrmSelecionarVendedor();


            s.ShowDialog();

            txtVendedor.Text = s.Vendedor;
            CodigoVendedor = s.Codigo1;



        }

       
        private void CarregarCombo(object o, EventArgs e)
        {

            BLL.Produto c = new BLL.Produto();
            BLL.FormaPagamento f = new BLL.FormaPagamento();

            cbProduto.DataSource = c.Listar(String.Empty, (byte)BLL.FuncoesGerais.TipoStatus.Ativo).Tables[0];
            cbProduto.DisplayMember = "Nome";
            cbProduto.ValueMember = "CodigoProduto";
            comboBox1.DataSource = f.Listar(String.Empty, (byte)BLL.FuncoesGerais.TipoStatus.Ativo).Tables[0];
            comboBox1.DisplayMember = "NomeFormaPgto";
            comboBox1.ValueMember = "CodigoFormaPgto";
            comboBox2.DataSource = f.Listar(String.Empty, (byte)BLL.FuncoesGerais.TipoStatus.Ativo).Tables[0];
            comboBox2.DisplayMember = "NomeFormaPgto";
            comboBox2.ValueMember = "CodigoFormaPgto";
            cbProduto.SelectedIndex = -1;


        }


        private void PreencherQuantidade(object o, EventArgs e)
        {

            try
            {
                BLL.Produto c = new BLL.Produto();
                if (cbProduto.SelectedIndex > 0)
                {
                    System.Data.SqlClient.SqlDataReader ddr;
                    ddr = c.ListarProdComQuant(Convert.ToInt16(cbProduto.SelectedValue), (byte)BLL.FuncoesGerais.TipoStatus.Ativo);
                    if (ddr.HasRows)
                    {
                        ddr.Read();
                        txtTotal.Text = Convert.ToString(ddr["ValorUnit"]);
                        txtQuantidade.Text = "1";
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }



        }
        private void AdicionarProduto(object o, EventArgs e)
        {

            try
            {

                if (cbProduto.SelectedIndex > 0)

                {

                    Double ValorTotal;

                    BLL.Produto p = new BLL.Produto();
                    System.Data.SqlClient.SqlDataReader ddr;
                    p.CodigoProduto = Convert.ToInt16(cbProduto.SelectedValue);
                    ddr = p.Consultar();
                    String ProdutoSelecionado = "";
                    ddr.Read();
                    if (ddr.HasRows)
                    {

                        ProdutoSelecionado = Convert.ToString(ddr["Nome"]);
                    }

                    if (Convert.ToInt16(txtQuantidade.Text) > 0)
                    {
                        //Mais de um produto
                        ValorTotal = Convert.ToDouble(txtTotal.Text) * Convert.ToDouble(txtQuantidade.Text);
                        dataGridView1.Rows.Add(cbProduto.SelectedValue, ProdutoSelecionado, txtQuantidade.Text, ValorTotal);
                        txtQuantidade.Clear();
                        txtTotal.Clear();
                        cbProduto.SelectedIndex = -1;
                        cbProduto.Focus();
                        dataGridView1.AutoResizeColumns();
                    }
                    else
                    {
                        //Somente um produto
                        dataGridView1.Rows.Add(cbProduto.SelectedValue, Convert.ToString(cbProduto.SelectedText), txtQuantidade.Text, txtTotal.Text);
                        txtQuantidade.Clear();
                        cbProduto.SelectedIndex = -1;
                        cbProduto.Focus();
                        dataGridView1.AutoResizeColumns();
                    }
                    Decimal total = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows.Cast<DataGridViewRow>()
                    .Where(t => !string.IsNullOrEmpty(t.Cells["ValorTot"].Value?.ToString())))
                    {
                        total += Convert.ToDecimal(row.Cells["ValorTot"].Value);
                        //totalVenda+= Convert.ToDecimal(row.Cells["ValorTot"].Value);
                        lblValorTotalDaVenda.Text = string.Format("{0:C}", total);
                        lblTotalVenda2.Text = lblValorTotalDaVenda.Text;
                        totalVenda = total;
                    }

                }
                else
                {
                    MessageBox.Show("Escolha um produto para adicionar à venda!!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }




        }

        private void BuscarProdCodBarra(object o, EventArgs e)
        {
            try
            {
                BLL.Produto p = new BLL.Produto();
                if (txtCodBarras.Text.Length == 0)
                {
                    MessageBox.Show("Por favor digite o codigo de barras");
                    return;
                }
                System.Data.SqlClient.SqlDataReader ddr;
                p.CodigoBarra = txtCodBarras.Text;
                ddr = p.ConsultarCodBarras();
                ddr.Read();
                if (ddr.HasRows)
                {
                    cbProduto.SelectedValue = Convert.ToString(ddr["CodigoProduto"]);
                    PreencherQuantidade(o,e);
                   // AdicionarProduto(o,e);

                }
                else
                {
                    MessageBox.Show("Codigo incorreto");
                    txtCodBarras.Clear();

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
        private void SalvarProdutos()
        {

            BLL.Venda v = new BLL.Venda();
            int CodigoUltimaVenda = v.RetornarVenda();
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
                   new SqlParameter("@CodigoVenda",SqlDbType.Int) {Value = CodigoUltimaVenda },
                   new SqlParameter("@CodigoProduto",SqlDbType.Int) {Value = CodigoProdutoGrid },

                };

                    comando = "INSERT INTO tbItem_Venda(CodigoVenda,CodigoProduto) Values (@CodigoVenda,@CodigoProduto)";
                    c.ExecutarComandoParametro(comando, listaComParametros);


                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
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
        private void SalvarPagamentoVenda()
        {
            try
            {
                BLL.Venda v = new BLL.Venda();
                int CodigoUltimaVenda = v.RetornarVenda();
                if (checkBox1.Checked)
                {

                    TCC_Inf2Dm.ClasseParaManipularBancoDeDados c = new TCC_Inf2Dm.ClasseParaManipularBancoDeDados();
                    string comando;
                    SqlParameter[] listaComParametros = {
                         new SqlParameter("@CodigoVenda",SqlDbType.Int) {Value = CodigoUltimaVenda },
                         new SqlParameter("@CodigoFormaPgto",SqlDbType.Int) {Value = Convert.ToInt32(comboBox1.SelectedValue) },
                         new SqlParameter ("@Valor",SqlDbType.Decimal) { Value = totalVenda/2}
                            };
                    comando = "INSERT INTO tbPgto_Venda(CodigoVenda,CodigoFormaPgto,ValorForma) Values (@CodigoVenda,@CodigoFormaPgto,@Valor)";
                    c.ExecutarComandoParametro(comando, listaComParametros);

                    SqlParameter[] listaComParametros2= {
                         new SqlParameter("@CodigoVenda",SqlDbType.Int) {Value = CodigoUltimaVenda },
                         new SqlParameter("@CodigoFormaPgto2",SqlDbType.Int) {Value = Convert.ToInt32(comboBox2.SelectedValue) },
                         new SqlParameter ("@Valor",SqlDbType.Decimal) { Value = totalVenda/2}
                            };
                    comando = "INSERT INTO tbPgto_Venda(CodigoVenda,CodigoFormaPgto,ValorForma) Values (@CodigoVenda,@CodigoFormaPgto2,@Valor)";
                    c.ExecutarComandoParametro(comando, listaComParametros2);


                }
                else
                {

                    TCC_Inf2Dm.ClasseParaManipularBancoDeDados c = new TCC_Inf2Dm.ClasseParaManipularBancoDeDados();
                    string comando;
                    SqlParameter[] listaComParametros = {
                         new SqlParameter("@CodigoVenda",SqlDbType.Int) {Value = CodigoUltimaVenda },
                         new SqlParameter("@CodigoFormaPgto",SqlDbType.Int) {Value = Convert.ToInt32(comboBox1.SelectedValue)},
                         new SqlParameter ("@Valor",SqlDbType.Decimal) { Value = totalVenda}
                            };
                    comando = "INSERT INTO tbPgto_Venda(CodigoVenda,CodigoFormaPgto,ValorForma) Values (@CodigoVenda,@CodigoFormaPgto,@Valor)";
                    c.ExecutarComandoParametro(comando, listaComParametros);



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }









        }
        private void CalcularValorVenda() {

            foreach (DataGridViewRow row in dataGridView1.Rows.Cast<DataGridViewRow>()
             .Where(t => !string.IsNullOrEmpty(t.Cells["ValorTot"].Value?.ToString())))
            {
                totalVenda += Convert.ToDecimal(row.Cells["ValorTot"].Value);



            }








        }

        public Decimal totalVenda = 0;
        public void FinalizarVenda(object o, EventArgs e)
        {
            try
            {
                BLL.Venda v = new BLL.Venda();
                v.CodigoCliente = Codigo;
                v.CodigoFuncionario = CodigoVendedor;
                v.DataVenda = DateTime.Today;

                

                //foreach (DataGridViewRow row in dataGridView1.Rows.Cast<DataGridViewRow>()
                //.Where(t => !string.IsNullOrEmpty(t.Cells["ValorTot"].Value?.ToString())))
                //{
                //    totalVenda += Convert.ToDecimal(row.Cells["ValorTot"].Value);



                //}

                v.ValorTotal = Convert.ToDouble(totalVenda);
                v.IncluirComParametro();
                SalvarProdutos();
                AtualizarEstoque();
                RegistrarLogSaida();
                SalvarPagamentoVenda();
                MessageBox.Show("Venda finalizada com sucesso");
                GerarPDF3(o, e);
                Close();

            }
            catch (Exception ex)

            {

                throw ex;
            }







        }
        private void button1_Click(object sender, EventArgs e)
        {
            Cadastrar.FrmCliente f = new Cadastrar.FrmCliente();
            f.ShowDialog();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox2.Visible = true;
                lblForma2.Visible = true;

            }
            if (checkBox1.Checked == false)
            {
                lblForma2.Visible = false;
                comboBox2.Visible = false;

            }
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
            var descriptionChunk = new Chunk(txtCliente.Text+"\n", redListTextFont);
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
            var titleChunk2 = new Chunk("  Valor da Venda: ", blackListTextFont);
            var descriptionChunk2 = new Chunk(lblValorTotalDaVenda.Text + "\n", redListTextFont);
            var phrase2 = new Phrase(imageChunk2);
            phrase2.Add(titleChunk2);
            phrase2.Add(descriptionChunk2);
            doc.Add(phrase2);

            //DataVenda

            iTextSharp.text.Image imagemData = iTextSharp.text.Image.GetInstance("Schedule_50px.png");
            imagemData.ScaleToFit(20f, 20f);
            Chunk imagemChunkData = new Chunk(imagemData, 0, -4);
            var titleChunk3 = new Chunk("  Data da Venda: ", blackListTextFont);
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
            Paragraph paragraph = new Paragraph("Produtos da Venda \n              ", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20f, iTextSharp.text.Font.BOLD, BaseColor.BLACK));
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
            System.Diagnostics.Process.Start("Venda.pdf");





        }

        private void tbPedido_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmValidarCupom f = new FrmValidarCupom();
            f.CodigoCliente = Codigo;
            f.ShowDialog();
            totalVenda= totalVenda- f.ValorCupomValidacao;
            lblValorTotalDaVenda.Text = string.Format("{0:C}", totalVenda);
            lblTotalVenda2.Text =  string.Format("{0:C}", totalVenda);
        }
    }
}
