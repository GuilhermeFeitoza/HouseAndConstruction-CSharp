using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{


   public class Estoque
    {

        private int _CodigoProduto;
        private int _Quantidade;
        private DateTime _Data;

                


        public static string instrucaoSql;
        TCC_Inf2Dm.ClasseParaManipularBancoDeDados c = new TCC_Inf2Dm.ClasseParaManipularBancoDeDados();

        public int CodigoProduto
        {
            get
            {
                return _CodigoProduto;
            }

            set
            {
                _CodigoProduto = value;
            }
        }

        public int Quantidade
        {
            get
            {
                return _Quantidade;
            }

            set
            {
                _Quantidade = value;
            }
        }

        public DateTime Data
        {
            get
            {
                return _Data;
            }

            set
            {
                _Data = value;
            }
        }

        public void RegistrarEntradaProd()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                new SqlParameter("@CodigoProduto", SqlDbType.Int) { Value = CodigoProduto },
                new SqlParameter("@Quantidade", SqlDbType.Int) { Value = Quantidade },
                new SqlParameter("@DataEntrada", SqlDbType.DateTime) { Value = Data}
                };
                //criar o objeto 'listaComParametros' a partir da classe 'sqlparameter' definida como uma lista '[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros.  Cada parametro foi definido com a identificação '@....' + um tipo de dado 'SqlDbType' +  um valor '{Value = _.....}'
                instrucaoSql = "INSERT INTO tbLog_Entrada_Produto (CodigoProduto,Quantidade,DataEntrada) VALUES (@CodigoProduto, @Quantidade,@DataEntrada)";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AtualizarEstoque() {

            // UPDATE produtos SET quantidade = quantidade+1 WHERE nome_produto = 'Tênis de Futebol'
            try
            {
                SqlParameter[] listaComParametros = {new SqlParameter("@CodigoProduto",SqlDbType.Int) {Value = _CodigoProduto },
                   new SqlParameter("@Quantidade",SqlDbType.Int) {Value = _Quantidade }
                 
                };

                instrucaoSql = "UPDATE tbEstoque SET QuantidadeAtual=QuantidadeAtual+@Quantidade WHERE CodigoProduto=@CodigoProduto";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);



            }
            catch (Exception ex)
            {

                throw ex;
            }






        }

        public DataSet ExibirEstoque(string partenome) {


            if (partenome.Length != 0)
            {
                instrucaoSql = "Select Nome,Descricao ,tbFornecedores.NomeFantasia as Fornecedor,tbEstoque.QuantidadeAtual as Quantidade_Atual,EstoqueMinimo,EstoqueMaximo from tbProduto INNER JOIN tbFornecedores ON tbProduto.CodigoFornecedor = tbFornecedores.CodigoFornecedor INNER JOIN tbEstoque ON tbProduto.CodigoProduto = tbEstoque.CodigoProduto WHERE Nome Like'%"+partenome+"%' Order by tbProduto.CodigoProduto";
            }
            else
            {
                instrucaoSql = "Select Nome,Descricao ,tbFornecedores.NomeFantasia as Fornecedor,tbEstoque.QuantidadeAtual as Quantidade_Atual,EstoqueMinimo,EstoqueMaximo from tbProduto INNER JOIN tbFornecedores ON tbProduto.CodigoFornecedor = tbFornecedores.CodigoFornecedor INNER JOIN tbEstoque ON tbProduto.CodigoProduto = tbEstoque.CodigoProduto Order by tbProduto.CodigoProduto";

            }
           
            return c.RetornarDataSet(instrucaoSql);


        }

 

    }
}
