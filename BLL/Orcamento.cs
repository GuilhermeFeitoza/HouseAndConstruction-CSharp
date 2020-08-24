using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
    public class Orcamento
    {


        private int _CodigoOrcamento;
        private int _CodigoCliente;
        private int _CodigoFuncionario;
        private DateTime _DataOrcamento;
        private Double _ValorTotal;


        TCC_Inf2Dm.ClasseParaManipularBancoDeDados c = new TCC_Inf2Dm.ClasseParaManipularBancoDeDados();

        public static String instrucaoSql;

        public int CodigoOrcamento
        {
            get
            {
                return _CodigoOrcamento;
            }

            set
            {
                _CodigoOrcamento = value;
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

        public DateTime DataOrcamento
        {
            get
            {
                return _DataOrcamento;
            }

            set
            {
                _DataOrcamento = value;
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

        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@CodigoCliente",SqlDbType.Int) {Value = CodigoCliente },
                   new SqlParameter("@CodigoFuncionario",SqlDbType.Int) {Value = CodigoFuncionario },
                   new SqlParameter("@DataOrcamento",SqlDbType.DateTime) {Value = DataOrcamento },
                   new SqlParameter("@ValorTotal",SqlDbType.Decimal) {Value = ValorTotal }
                   
                };
                //criar o objeto 'listaComParametros' a partir da classe 'sqlparameter' definida como uma lista '[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros.  Cada parametro foi definido com a identificação '@....' + um tipo de dado 'SqlDbType' +  um valor '{Value = _.....}'
                instrucaoSql = "INSERT INTO tbOrcamento (CodigoCliente, CodigoFuncionario, DataOrcamento, ValorTotal) VALUES (@CodigoCliente, @CodigoFuncionario, @DataOrcamento, @ValorTotal)";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet ListarOrcamento(string parteNome)
        {
            try
            {
                instrucaoSql = " SELECT tbOrcamento.CodigoOrcamento, Cliente.CodigoCliente, Cliente.Nome As  Nome_cliente, tbFuncionario.CodigoFuncionario, tbFuncionario.Nome AS FuncionarioResponsavel, tbItem_Orcamento.CodigoProduto, tbProduto.Nome AS NomeProduto FROM tbCliente as Cliente INNER JOIN tbOrcamento ON tbOrcamento.CodigoCliente = Cliente.CodigoCliente INNER JOIN tbFuncionario ON tbOrcamento.CodigoFuncionario = tbFuncionario.CodigoFuncionario INNER JOIN tbItem_Orcamento ON tbOrcamento.CodigoOrcamento = tbItem_Orcamento.CodigoOrcamento INNER JOIN tbProduto ON tbItem_Orcamento.CodigoProduto = tbProduto.CodigoProduto   Order by CodigoOrcamento";
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


        public int RetornarOrcamento()
        {
            try
            {
                instrucaoSql = "Select max(CodigoOrcamento)from tbOrcamento";
                return c.RetornarExecuteScalar(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }







    }
}
