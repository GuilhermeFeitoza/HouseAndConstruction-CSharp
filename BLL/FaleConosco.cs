using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace BLL
{
    public class FaleConosco
    {

        TCC_Inf2Dm.ClasseParaManipularBancoDeDados c = new TCC_Inf2Dm.ClasseParaManipularBancoDeDados();
        public static string instrucaoSql;

         private int _CodigoContato;
        private string _NomeContato;
        private string _EmailContato;
        private string _AssuntoContato;
        private string _TelContato;
        private DateTime _DataContato;
        private string _Mensagem;
        private int  _StatusContato;
        private string _Resposta;
        private int _CodigoUsuario;
        public int CodigoContato
        {
            get
            {
                return _CodigoContato;
            }

            set
            {
                _CodigoContato = value;
            }
        }

        public string NomeContato
        {
            get
            {
                return _NomeContato;
            }

            set
            {
                _NomeContato = value;
            }
        }

        public string EmailContato
        {
            get
            {
                return _EmailContato;
            }

            set
            {
                _EmailContato = value;
            }
        }

        public string AssuntoContato
        {
            get
            {
                return _AssuntoContato;
            }

            set
            {
                _AssuntoContato = value;
            }
        }

        public string TelContato
        {
            get
            {
                return _TelContato;
            }

            set
            {
                _TelContato = value;
            }
        }

        public DateTime DataContato
        {
            get
            {
                return _DataContato;
            }

            set
            {
                _DataContato = value;
            }
        }

        public string Mensagem
        {
            get
            {
                return _Mensagem;
            }

            set
            {
                _Mensagem = value;
            }
        }

        public int StatusContato
        {
            get
            {
                return _StatusContato;
            }

            set
            {
                _StatusContato = value;
            }
        }

        public string Resposta
        {
            get
            {
                return _Resposta;
            }

            set
            {
                _Resposta = value;
            }
        }

        public int CodigoUsuario
        {
            get
            {
                return _CodigoUsuario;
            }

            set
            {
                _CodigoUsuario = value;
            }
        }

        public DataSet ListarMensagem() {
            try
            {
                instrucaoSql = "Select *from tbContato";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public DataSet ListarMensagemPendentes()
        {
            try
            {
                instrucaoSql = "SELECT * FROM tbContato WHERE StatusContato = 0";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public DataSet ListarMensagemRespondidas()
        {
            try
            {
                instrucaoSql = "SELECT * FROM tbContato WHERE StatusContato = 1";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public SqlDataReader RetornarMensagem(int Codigo )
        {
            try
            {
              
                    instrucaoSql = "Select CodigoContato,NomeContato,EmailContato,AssuntoContato,TelContato,DataContato,Mensagem,StatusContato,Resposta,tbUsuario.NomeUsuario from tbContato INNER JOIN tbUsuario ON tbContato.CodigoUsuario =tbUsuario.CodigoUsuario WHERE CodigoContato =" + _CodigoContato;                             
                    return c.RetornarDataReader(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int RetornarMensagemMaisAntiga()
        {
            try
            {
                instrucaoSql = "Select min(CodigoContato)from tbContato";
                return c.RetornarExecuteScalar(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int RetornarMensagemMaisRecente()
        {
            try
            {
                instrucaoSql = "Select Max(CodigoContato)from tbContato";
                return c.RetornarExecuteScalar(instrucaoSql);

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
                   new SqlParameter("@CodigoContato",SqlDbType.Int) {Value = CodigoContato },
                   new SqlParameter("@Resposta ",SqlDbType.VarChar) {Value = Resposta },
                     new SqlParameter("@CodigoUsuario ",SqlDbType.Int) {Value = CodigoUsuario },
                         new SqlParameter("@StatusContato ",SqlDbType.Bit) {Value = StatusContato },
                };


                instrucaoSql = "UPDATE tbContato SET Resposta=@Resposta,CodigoUsuario=@CodigoUsuario,StatusContato=@StatusContato WHERE CodigoContato=@CodigoContato";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);



            }
            catch (Exception ex)
            {

                throw ex;
            }
        }









    }
}
