using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Destinatario
    {
        TCC_Inf2Dm.ClasseParaManipularBancoDeDados c = new TCC_Inf2Dm.ClasseParaManipularBancoDeDados();
        public static string instrucaoSql;


        private String _NomeDestinatario;
        private String _EnderecoDestinatario;
        private String _BairroDestinatario;
        private String _CidadeDestinatario;
        private String _UFDestinatario;
        private String _CEPDestinatario;
        private String _ComplementoDestinatario;
        private int _NumeroDestinatario;


        private String _TelDestinatario;
        private byte _StatusDestinatario;

        public string ComplementoDestinatario
        {
            get
            {
                return ComplementoDestinatario1;
            }

            set
            {
                ComplementoDestinatario1 = value;
            }
        }

        public int NumeroDestinatario
        {
            get
            {
                return NumeroDestinatario1;
            }

            set
            {
                NumeroDestinatario1 = value;
            }
        }

        public string NomeDestinatario
        {
            get
            {
                return _NomeDestinatario;
            }

            set
            {
                _NomeDestinatario = value;
            }
        }

        public string EnderecoDestinatario
        {
            get
            {
                return _EnderecoDestinatario;
            }

            set
            {
                _EnderecoDestinatario = value;
            }
        }

        public string BairroDestinatario
        {
            get
            {
                return _BairroDestinatario;
            }

            set
            {
                _BairroDestinatario = value;
            }
        }

        public string CidadeDestinatario
        {
            get
            {
                return _CidadeDestinatario;
            }

            set
            {
                _CidadeDestinatario = value;
            }
        }

        public string UFDestinatario
        {
            get
            {
                return _UFDestinatario;
            }

            set
            {
                _UFDestinatario = value;
            }
        }

        public string CEPDestinatario
        {
            get
            {
                return _CEPDestinatario;
            }

            set
            {
                _CEPDestinatario = value;
            }
        }

        public string ComplementoDestinatario1
        {
            get
            {
                return _ComplementoDestinatario;
            }

            set
            {
                _ComplementoDestinatario = value;
            }
        }

        public int NumeroDestinatario1
        {
            get
            {
                return _NumeroDestinatario;
            }

            set
            {
                _NumeroDestinatario = value;
            }
        }

        public string TelDestinatario
        {
            get
            {
                return _TelDestinatario;
            }

            set
            {
                _TelDestinatario = value;
            }
        }

        public byte StatusDestinatario
        {
            get
            {
                return _StatusDestinatario;
            }

            set
            {
                _StatusDestinatario = value;
            }
        }

        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@NomeDestinatario",SqlDbType.VarChar) {Value = _NomeDestinatario },
                   new SqlParameter("@EnderecoDestinatario",SqlDbType.VarChar) {Value = _EnderecoDestinatario },
                   new SqlParameter("@BairroDestinatario",SqlDbType.VarChar) {Value = _BairroDestinatario},
                   new SqlParameter("@CidadeDestinatario",SqlDbType.VarChar) {Value = _CidadeDestinatario },
                   new SqlParameter("@ComplementoDestinatario",SqlDbType.VarChar) {Value = _ComplementoDestinatario },
                   new SqlParameter("@UFDestinatario",SqlDbType.VarChar) {Value = _UFDestinatario },
                   new SqlParameter("@NumeroDestinatario",SqlDbType.Int) {Value = _NumeroDestinatario },
                   new SqlParameter("@CEPDestinatario",SqlDbType.VarChar) {Value = _CEPDestinatario },
                   new  SqlParameter("@TelDestinatario",SqlDbType.VarChar) {Value = _TelDestinatario },
                   new SqlParameter("@StatusDestinatario",SqlDbType.Int) {Value = _StatusDestinatario }
                };
                //criar o objeto 'listaComParametros' a partir da classe 'sqlparameter' definida como uma lista '[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros.  Cada parametro foi definido com a identificação '@....' + um tipo de dado 'SqlDbType' +  um valor '{Value = _.....}'
                instrucaoSql = "INSERT INTO tbDestinatario (NomeDestinatario, EnderecoDestinatario, BairroDestinatario,CidadeDestinatario,ComplementoDestinatario,NumeroDestinatario,CEPDestinatario,TelDestinatario,StatusDestinatario) VALUES (@NomeDestinatario, @EnderecoDestinatario, @BairroDestinatario,@CidadeDestinatario,@ComplementoDestinatario,@NumeroDestinatario,@CEPDestinatario,@TelDestinatario,@StatusDestinatario)";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);
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
                instrucaoSql = "SELECT * FROM tbDestinatario";
                if (parteNome.Length != 0)
                {
                    instrucaoSql = instrucaoSql + " WHERE NomeDestinatario LIKE '%" + parteNome + "%'"; //avisado sobre comportamento
                }
                return c.RetornarDataSet(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        public SqlDataReader RetornarEndereco(int Cod)
        {
            try
            {
                instrucaoSql = "Select *From tbDestinatario Where CodigoDestinatario = "+ Cod;
                return c.RetornarDataReader(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }













    }
}
