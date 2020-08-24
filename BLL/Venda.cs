using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
    public class Venda
    {

        private int _CodigoVenda;
        private int _CodigoCliente;
        private int _CodigoFuncionario;
        private DateTime _DataVenda;
        private Double _ValorTotal;

        public int CodigoVenda
        {
            get
            {
                return _CodigoVenda;
            }

            set
            {
                _CodigoVenda = value;
            }
        }

        public int CodigoCliente
        {
            get
            {
                return _CodigoCliente;
            }

            set
            {
                _CodigoCliente = value;
            }
        }

        public int CodigoFuncionario
        {
            get
            {
                return _CodigoFuncionario;
            }

            set
            {
                _CodigoFuncionario = value;
            }
        }

        public DateTime DataVenda
        {
            get
            {
                return _DataVenda;
            }

            set
            {
                _DataVenda = value;
            }
        }

        public double ValorTotal
        {
            get
            {
                return _ValorTotal;
            }

            set
            {
                _ValorTotal = value;
            }
        }


        TCC_Inf2Dm.ClasseParaManipularBancoDeDados c = new TCC_Inf2Dm.ClasseParaManipularBancoDeDados();

        public static String instrucaoSql;

        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@CodigoCliente",SqlDbType.Int) {Value = _CodigoCliente },
                   new SqlParameter("@CodigoFuncionario",SqlDbType.Int) {Value = _CodigoFuncionario },
                   new SqlParameter("@DataVenda",SqlDbType.DateTime) {Value = _DataVenda },
                   new SqlParameter("@ValorTotal",SqlDbType.Decimal) {Value = _ValorTotal }
                   //new SqlParameter("@CodigoNivelAcesso",SqlDbType.Int) {Value = _CodigoNivelAcesso }
                };
                //criar o objeto 'listaComParametros' a partir da classe 'sqlparameter' definida como uma lista '[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros.  Cada parametro foi definido com a identificação '@....' + um tipo de dado 'SqlDbType' +  um valor '{Value = _.....}'
                instrucaoSql = "INSERT INTO tbVenda (CodigoCliente, CodigoFuncionario, DataVenda, ValorTotal) VALUES (@CodigoCliente, @CodigoFuncionario, @DataVenda, @ValorTotal)";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet ListarVendas(string parteNome)
        {
            try
            {
                instrucaoSql = " SELECT tbVenda.CodigoVenda,tbVenda.ValorTotal,tbVenda.DataVenda, Cliente.CodigoCliente, Cliente.Nome As  Nome_cliente, tbFuncionario.CodigoFuncionario, tbFuncionario.Nome AS FuncionarioResponsavel  FROM tbCliente as Cliente INNER JOIN tbVenda ON tbVenda.CodigoCliente = Cliente.CodigoCliente INNER JOIN tbFuncionario ON tbVenda.CodigoFuncionario = tbFuncionario.CodigoFuncionario";
                if (parteNome.Length != 0)
                {
                    instrucaoSql = instrucaoSql + " WHERE Cliente.Nome LIKE '%" + parteNome + "%'"; //avisado sobre comportamento
                }
                return c.RetornarDataSet(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public int RetornarVenda()
        {
            try
            {
                instrucaoSql = "Select max(CodigoVenda)from tbVenda";
                return c.RetornarExecuteScalar(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }




        public DataSet ListarItensVenda(int CodigoVenda)
        {

            try
            {

                instrucaoSql = "SELECT tbItem_Venda.CodigoProduto , tbProduto.Nome, tbProduto.ValorUnit FROM tbVenda  INNER JOIN tbItem_Venda ON tbVenda.CodigoVenda=tbItem_Venda.CodigoVenda INNER JOIN tbProduto  ON tbItem_Venda.CodigoProduto = tbProduto.CodigoProduto   WHERE  tbVenda.CodigoVenda = " + CodigoVenda;
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }


        public SqlDataReader RetornarForma(int CodigoVenda)
        {

            try
            {
                instrucaoSql = "select Nome FROM tbFormaPgto WHERE CodigoFormaPgto=  (SELECT tbPgto_Venda.CodigoFormaPgto FROM tbPgto_Venda INNER JOIN tbVenda ON  tbPgto_Venda.CodigoVenda = tbVenda.CodigoVenda WHERE tbVenda.CodigoVenda=" + CodigoVenda + ")";
                return c.RetornarDataReader(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }








       
            


    }
}
