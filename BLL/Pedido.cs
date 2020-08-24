using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace BLL
{
    public class Pedido
        
    {
        private int _CodigoPedido;
        private int _CodigoCliente;
        private int _CodigoFuncionario;
        private DateTime _DataPedido;
        private DateTime _DataEntrega;
        private decimal _ValorTotalPedido;
        private int _CodigoDestinatario;
        private int _CodigoPgto_Pedido;
        private byte _StatusPedido;



        TCC_Inf2Dm.ClasseParaManipularBancoDeDados c = new TCC_Inf2Dm.ClasseParaManipularBancoDeDados();

        public static String instrucaoSql;

        public int CodigoPedido
        {
            get
            {
                return _CodigoPedido;
            }

            set
            {
                _CodigoPedido = value;
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

        public DateTime DataPedido
        {
            get
            {
                return _DataPedido;
            }

            set
            {
                _DataPedido = value;
            }
        }

        public DateTime DataEntrega
        {
            get
            {
                return _DataEntrega;
            }

            set
            {
                _DataEntrega = value;
            }
        }

        public decimal ValorTotalPedido
        {
            get
            {
                return _ValorTotalPedido;
            }

            set
            {
                _ValorTotalPedido = value;
            }
        }

        public int CodigoDestinatario
        {
            get
            {
                return _CodigoDestinatario;
            }

            set
            {
                _CodigoDestinatario = value;
            }
        }

        public int CodigoPgto_Pedido
        {
            get
            {
                return _CodigoPgto_Pedido;
            }

            set
            {
                _CodigoPgto_Pedido = value;
            }
        }

        public byte StatusPedido
        {
            get
            {
                return _StatusPedido;
            }

            set
            {
                _StatusPedido = value;
            }
        }

        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@CodigoCliente",SqlDbType.Int) {Value = CodigoCliente },
                   new SqlParameter("@CodigoFuncionario",SqlDbType.Int) {Value = CodigoFuncionario },
                   new SqlParameter("@DataPedido",SqlDbType.DateTime) {Value = _DataPedido },
                   new SqlParameter("@DataEntrega",SqlDbType.DateTime) {Value = _DataEntrega },
                    new SqlParameter("@ValorTotalPedido",SqlDbType.Decimal) {Value = _ValorTotalPedido },
                   new SqlParameter("@CodigoDestinatario",SqlDbType.Int) {Value = _CodigoDestinatario },
                   new SqlParameter("@StatusPedido",SqlDbType.Bit) {Value = _StatusPedido }
                };
                //criar o objeto 'listaComParametros' a partir da classe 'sqlparameter' definida como uma lista '[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros.  Cada parametro foi definido com a identificação '@....' + um tipo de dado 'SqlDbType' +  um valor '{Value = _.....}'
                instrucaoSql = "INSERT INTO tbPedido (CodigoCliente, CodigoFuncionario, DataPedido, DataEntrega, ValorTotalPedido,CodigoDestinatario,StatusPedido) VALUES (@CodigoCliente, @CodigoFuncionario, @DataPedido,@DataEntrega, @ValorTotalPedido,@CodigoDestinatario,@StatusPedido)";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int RetornarPedido()
        {
            try
            {
                instrucaoSql = "Select max(CodigoPedido)from tbPedido";
                return c.RetornarExecuteScalar(instrucaoSql);

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
                instrucaoSql = "SELECT*FROM VW_ListarPedido";
                if (parteNome.Length != 0)
                {
                    instrucaoSql = instrucaoSql + " WHERE DataPedido = " + parteNome; //avisado sobre comportamento
                }
                return c.RetornarDataSet(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }









    }
}















