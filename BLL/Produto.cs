using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
   public class Produto
    {

        private int _CodigoProduto;
        private string _Nome;
        private string _Descricao;
        private int _CodigoUnidadeVenda;
        private string _CodigoBarra;
        private int _CodigoFornecedor;
        private int _CodigoCategoria;
        private DateTime _DataEntrada;
        private string _Marca;
        private string _Imagem;
        private int _StatusProduto;
        private double _ValorUnit;

        private int _Quantidade;
        private int _EstoqueMaximo;
        private int _EstoqueMinimo;

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

        public string Nome
        {
            get
            {
                return _Nome;
            }

            set
            {
                _Nome = value;
            }
        }

        public string Descricao
        {
            get
            {
                return _Descricao;
            }

            set
            {
                _Descricao = value;
            }
        }

        public int CodigoUnidadeVenda
        {
            get
            {
                return _CodigoUnidadeVenda;
            }

            set
            {
                _CodigoUnidadeVenda = value;
            }
        }

        public string CodigoBarra
        {
            get
            {
                return _CodigoBarra;
            }

            set
            {
                _CodigoBarra = value;
            }
        }

        public int CodigoFornecedor
        {
            get
            {
                return _CodigoFornecedor;
            }

            set
            {
                _CodigoFornecedor = value;
            }
        }

        public int CodigoCategoria
        {
            get
            {
                return _CodigoCategoria;
            }

            set
            {
                _CodigoCategoria = value;
            }
        }

        public DateTime DataEntrada
        {
            get
            {
                return _DataEntrada;
            }

            set
            {
                _DataEntrada = value;
            }
        }

        public string Marca
        {
            get
            {
                return _Marca;
            }

            set
            {
                _Marca = value;
            }
        }

        public string Imagem
        {
            get
            {
                return _Imagem;
            }

            set
            {
                _Imagem = value;
            }
        }

        public int StatusProduto
        {
            get
            {
                return _StatusProduto;
            }

            set
            {
                _StatusProduto = value;
            }
        }

        public double ValorUnit
        {
            get
            {
                return _ValorUnit;
            }

            set
            {
                _ValorUnit = value;
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

        public int EstoqueMaximo
        {
            get
            {
                return _EstoqueMaximo;
            }

            set
            {
                _EstoqueMaximo = value;
            }
        }

        public int EstoqueMinimo
        {
            get
            {
                return _EstoqueMinimo;
            }

            set
            {
                _EstoqueMinimo = value;
            }
        }

        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@Nome",SqlDbType.VarChar) {Value = Nome },
                   new SqlParameter("@Descricao",SqlDbType.VarChar) {Value = Descricao },
                   new SqlParameter("@CodigoUnidadeVenda",SqlDbType.Int) {Value = CodigoUnidadeVenda},
                   new SqlParameter("@EstoqueMaximo",SqlDbType.Int) {Value = EstoqueMaximo },
                   new SqlParameter("@EstoqueMinimo",SqlDbType.Int) {Value = EstoqueMinimo },
                   new SqlParameter("@CodigoBarra",SqlDbType.VarChar) {Value = CodigoBarra },
                   new SqlParameter("@CodigoFornecedor",SqlDbType.VarChar) {Value = CodigoFornecedor },
                   new SqlParameter("@CodigoCategoria",SqlDbType.Int) {Value = CodigoCategoria },
                   new SqlParameter("@DataEntrada",SqlDbType.DateTime) {Value = DataEntrada },
                   new  SqlParameter("@Marca",SqlDbType.VarChar) {Value = Marca },
                   new SqlParameter("@Imagem",SqlDbType.VarChar) {Value = Imagem },
                   new SqlParameter("@ValorUnit",SqlDbType.Decimal) {Value = ValorUnit },
                   new SqlParameter("@StatusProduto",SqlDbType.Int) {Value = StatusProduto

                   }
                };
                //criar o objeto 'listaComParametros' a partir da classe 'sqlparameter' definida como uma lista '[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros.  Cada parametro foi definido com a identificação '@....' + um tipo de dado 'SqlDbType' +  um valor '{Value = _.....}'
                instrucaoSql = "INSERT INTO tbProduto (Nome, Descricao, CodigoUnidadeVenda,CodigoBarra,CodigoFornecedor,CodigoCategoria,DataEntrada,Marca,Imagem,ValorUnit,StatusProduto,EstoqueMinimo,EstoqueMaximo) VALUES (@Nome, @Descricao, @CodigoUnidadeVenda,@CodigoBarra,@CodigoFornecedor,@CodigoCategoria,@DataEntrada,@Marca,@Imagem,@ValorUnit,@StatusProduto,@EstoqueMinimo,@EstoqueMaximo)";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AlterarComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@CodigoProduto",SqlDbType.Int) {Value = CodigoProduto},
                   new SqlParameter("@Nome",SqlDbType.VarChar) {Value = Nome },
                   new SqlParameter("@Descricao",SqlDbType.VarChar) {Value = Descricao },
                   new SqlParameter("@CodigoUnidadeVenda",SqlDbType.Int) {Value = CodigoUnidadeVenda},
                   new SqlParameter("@EstoqueMaximo",SqlDbType.Int) {Value = EstoqueMaximo },
                   new SqlParameter("@EstoqueMinimo",SqlDbType.Int) {Value = EstoqueMinimo },


                   new SqlParameter("@CodigoBarra",SqlDbType.VarChar) {Value = CodigoBarra },
                   new SqlParameter("@CodigoFornecedor",SqlDbType.VarChar) {Value = CodigoFornecedor },
                   new SqlParameter("@CodigoCategoria",SqlDbType.Int) {Value = CodigoCategoria },
                   new SqlParameter("@DataEntrada",SqlDbType.DateTime) {Value = DataEntrada },
                   new  SqlParameter("@Marca",SqlDbType.VarChar) {Value = Marca },
                   new SqlParameter("@Imagem",SqlDbType.VarChar) {Value = Imagem },
                   new SqlParameter("@ValorUnit",SqlDbType.Decimal) {Value = ValorUnit },
                   new SqlParameter("@StatusProduto",SqlDbType.Int) {Value = StatusProduto

                   }
                };


                instrucaoSql = "UPDATE tbProduto SET Nome=@Nome, Descricao=@Descricao,CodigoUnidadeVenda=@CodigoUnidadeVenda,CodigoBarra=@CodigoBarra,CodigoFornecedor=@CodigoFornecedor,CodigoCategoria=@CodigoCategoria,DataEntrada=@DataEntrada,Marca=@Marca,Imagem=@Imagem,ValorUnit=@ValorUnit,StatusProduto=@StatusProduto,EstoqueMaximo=EstoqueMaximo,EstoqueMinimo=@EstoqueMinimo WHERE CodigoProduto=@CodigoProduto";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);



            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        
        public void Ativar()
        {
            try
            {
                instrucaoSql = "UPDATE tbProduto SET StatusProduto=1   WHERE CodigoProduto=" + CodigoProduto;
                c.ExecutarComando(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Desativar()
        {
            try
            {
                instrucaoSql = "UPDATE tbProduto SET StatusProduto=1   WHERE CodigoProduto=" + CodigoProduto;
                c.ExecutarComando(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Excluir()
        {
            try
            {
                instrucaoSql = "DELETE FROM tbProduto  WHERE CodigoProduto=" + CodigoProduto;
                c.ExecutarComando(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public SqlDataReader Consultar()
        {
            try
            {
                instrucaoSql = "SELECT * FROM tbProduto  WHERE CodigoProduto=" + CodigoProduto;
                return c.RetornarDataReader(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public SqlDataReader ConsultarCodBarras()
        {
            try
            {
                instrucaoSql = "SELECT * FROM tbProduto  WHERE CodigoBarra='" + CodigoBarra +"'";
                return c.RetornarDataReader(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataSet Listar(string parteNome, byte tipostatus)
        {
            try
            {
                instrucaoSql = "SELECT * FROM tbProduto";
                if (parteNome.Length != 0)
                {
                    instrucaoSql = instrucaoSql + " WHERE Nome LIKE '%" + parteNome + "%'"; //avisado sobre comportamento
                }
                return c.RetornarDataSet(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet ListarAtivos()
        {
            try
            {
                instrucaoSql = "SELECT CodigoProduto, Produto, DataEntrada,StatusProduto FROM tbProduto WHERE Status=1";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet ListarInativos()
        {
            try
            {
                instrucaoSql = "SELECT CodigoProduto, Produto, DataEntrada,StatusProduto FROM tbProduto WHERE Status=1";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        public SqlDataReader ListarProdComQuant(int Codigo, byte tipostatus) {


            instrucaoSql = "SELECT CodigoProduto,Nome,ValorUnit FROM tbProduto where CodigoProduto = "+Codigo;
            return c.RetornarDataReader(instrucaoSql);



        }




        public int RetornarProduto()
        {
            try
            {
                instrucaoSql = "Select max(CodigoProduto)from tbPRoduto";
                return c.RetornarExecuteScalar(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void NovoEstoque() {

            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@CodigoProduto",SqlDbType.Int) {Value = RetornarProduto() },
                   new SqlParameter("@Quantidade",SqlDbType.Int) {Value = _Quantidade }
                  
                 
                };
              
                instrucaoSql = "INSERT INTO tbEstoque (CodigoProduto, QuantidadeAtual) VALUES (@CodigoProduto, @Quantidade)";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

        public DataSet ListarAbaixoDoEstoque()
        {
            try
            {
                instrucaoSql = "SELECT DISTINCT tbProduto.CodigoProduto, tbProduto.Nome ,tbProduto.EstoqueMinimo,tbEstoque.QuantidadeAtual  FROM tbProduto INNER JOIN tbEstoque ON tbProduto.CodigoProduto = tbEstoque.CodigoProduto WHERE QuantidadeAtual < EstoqueMinimo AND tbProduto.StatusProduto = 1";
                return c.RetornarDataSet(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



    }
}
