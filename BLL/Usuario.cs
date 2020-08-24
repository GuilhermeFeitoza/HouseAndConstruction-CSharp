using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
   public class Usuario
    {
        public static string instrucaoSql;

        private int _CodigoUsuario;
        private string _NomeUsuario;
        private string _SenhaUsuario;
        private byte _StatusUsuario;
        private DateTime _DataAcessoUsuario;
        private DateTime _DataCadastroUsuario;
        private int _CodigoNivelAcesso;
     

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

        public string NomeUsuario
        {
            get
            {
                return _NomeUsuario;
            }

            set
            {
                _NomeUsuario = value;
            }
        }

        public string SenhaUsuario
        {
            get
            {
                return _SenhaUsuario;
            }

            set
            {
                _SenhaUsuario = value;
            }
        }

        public byte StatusUsuario
        {
            get
            {
                return _StatusUsuario;
            }

            set
            {
                _StatusUsuario = value;
            }
        }

        public DateTime DataAcessoUsuario
        {
            get
            {
                return _DataAcessoUsuario;
            }

            set
            {
                _DataAcessoUsuario = value;
            }
        }

        public DateTime DataCadastroUsuario
        {
            get
            {
                return _DataCadastroUsuario;
            }

            set
            {
                _DataCadastroUsuario = value;
            }
        }



        public int CodigoNivelAcesso
        {
            get
            {
                return _CodigoNivelAcesso;
            }

            set
            {
                _CodigoNivelAcesso = value;
            }
        }
    
        //instancia
        TCC_Inf2Dm.ClasseParaManipularBancoDeDados c = new TCC_Inf2Dm.ClasseParaManipularBancoDeDados();



        public void Incluir()
        {
            try
            {
                instrucaoSql = "INSERT INTO tbUsuario (NomeUsuario, SenhaUsuario, DataAcessoUsuario,DataCadastroUsuario, StatusUsuario) Values ('" + _NomeUsuario + "', '" + _SenhaUsuario + "', #" + _DataAcessoUsuario + "#, #"+_DataCadastroUsuario+"#" + _StatusUsuario + ")";
                c.ExecutarComando(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@NomeUsuario",SqlDbType.VarChar) {Value = _NomeUsuario },
                   new SqlParameter("@SenhaUsuario",SqlDbType.VarChar) {Value = _SenhaUsuario },
                   new SqlParameter("@DataAcessoUsuario",SqlDbType.DateTime) {Value = _DataAcessoUsuario },
                   new SqlParameter("@DataCadastroUsuario",SqlDbType.DateTime) {Value = _DataCadastroUsuario },
                   new SqlParameter("@Status",SqlDbType.Bit) {Value = _StatusUsuario },
                   new SqlParameter("@CodigoNivelAcesso",SqlDbType.Int) {Value = _CodigoNivelAcesso }
                };
                //criar o objeto 'listaComParametros' a partir da classe 'sqlparameter' definida como uma lista '[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros.  Cada parametro foi definido com a identificação '@....' + um tipo de dado 'SqlDbType' +  um valor '{Value = _.....}'
                instrucaoSql = "INSERT INTO tbUsuario (NomeUsuario, SenhaUsuario, StatusUsuario, DataAcessoUsuario,DataCadastroUsuario,CodigoNivelAcesso) VALUES (@NomeUsuario, @SenhaUsuario, @Status, @DataAcessoUsuario,@DataCadastroUsuario,@CodigoNivelAcesso)";
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
                SqlParameter[] listaComParametros = {new SqlParameter("@CodigoUsuario",SqlDbType.Int) {Value = _CodigoUsuario },
                   new SqlParameter("@NomeUsuario",SqlDbType.VarChar) {Value = _NomeUsuario },
                   new SqlParameter("@SenhaUsuario",SqlDbType.VarChar) {Value = _SenhaUsuario },
                   //new SqlParameter("@DataAcessoUsuario",SqlDbType.DateTime) {Value = _DataAcessoUsuario },
                   new SqlParameter("@StatusUsuario",SqlDbType.Bit) {Value = _StatusUsuario },
                    new SqlParameter("@CodigoNivelAcesso",SqlDbType.Int) {Value = _CodigoNivelAcesso }
                };

                instrucaoSql = "UPDATE tbUsuario SET NomeUsuario=@NomeUsuario, SenhaUsuario=@SenhaUsuario,StatusUsuario=@StatusUsuario,CodigoNivelAcesso=@CodigoNivelAcesso WHERE CodigoUsuario=@CodigoUsuario";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);



            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void TrocarSenhaComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {new SqlParameter("@CodigoUsuario",SqlDbType.Int) {Value = _CodigoUsuario },

                   new SqlParameter("@SenhaUsuario",SqlDbType.VarChar) {Value = _SenhaUsuario }


                };

                instrucaoSql = "UPDATE tbUsuario SET SenhaUsuario=@SenhaUsuario WHERE CodigoUsuario=@CodigoUsuario";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);




            }
            catch (Exception ex)
            {

                throw ex;
            }
        }





        public int IncluirRetornarNumeroAutomatico()
        {
            try
            {
                instrucaoSql = "INSERT INTO tbUsuario (NomeUsuario, SenhaUsuario, DataAcessoUsuario, StatusUsuario) Values ('" + _NomeUsuario + "', '" + _SenhaUsuario + "', #" + _DataAcessoUsuario + "#, " + _StatusUsuario + ")";
                return c.RecuperarUltimoCodigoNumeracaoAutomatica(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Alterar()
        {
            try
            {
                instrucaoSql = "UPDATE tbUsuario SET NomeUsuario='_NomeUsuario', SenhaUsuario='_SenhaUsuario', DataAcessoUsuario=#_DataAcessoUsuario#,DataCadastroUsuario=#_DataCadastroUsuario#, StatusUsuario=_StatusUsuario   Where CodigoUsuario=_CodigoUsuario";
                c.ExecutarComando(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void TrocarSenha()
        {
            try
            {
                instrucaoSql = "UPDATE tbUsuario SET SenhaUsuario=_SenhaUsuario   WHERE  CodigoUsuario=_CodigoUsuario";
                c.ExecutarComando(instrucaoSql);
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
                instrucaoSql = "UPDATE tbUsuario SET StatusUsuario=1   WHERE CodigoUsuario=" + _CodigoUsuario;
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
                instrucaoSql = "UPDATE tbUsuario SET StatusUsuario=0  WHERE CodigoUsuario=" + _CodigoUsuario;
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
                instrucaoSql = "DELETE FROM tbUsuario  WHERE CodigoUsuario=" + _CodigoUsuario;
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
                instrucaoSql = "SELECT * FROM tbUsuario  WHERE CodigoUsuario=" + _CodigoUsuario;
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
                instrucaoSql = "SELECT * FROM tbUsuario";
                if (parteNome.Length != 0)
                {
                    instrucaoSql = instrucaoSql + " WHERE NomeUsuario LIKE '%" + parteNome + "%'"; //avisado sobre comportamento
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
                instrucaoSql = "SELECT CodigoUsuario, NomeUsuario, StatusUsuario FROM tbUsuario WHERE StatusUsuario=1";
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
                instrucaoSql = "SELECT CodigoUsuario, NomeUsuario FROM tbUsuario WHERE StatusUsuario=0";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }





        public int Logar()
        {
            try
            {
                //instrucaoSql = "SELECT NomeUsuario, SenhaUsuario, CodigoUsuario, StatusUsuario FROM tbUsuario WHERE NomeUsuario='" + _NomeUsuario + "'  AND  SenhaUsuario='" + _SenhaUsuario + "'  AND StatusUsuario=1";
                instrucaoSql = "SELECT NomeUsuario, SenhaUsuario, CodigoUsuario,CodigoNivelAcesso, StatusUsuario FROM tbUsuario WHERE NomeUsuario='" + _NomeUsuario + "'  AND  SenhaUsuario='" + _SenhaUsuario + "'  AND StatusUsuario=1";
                SqlDataReader dr;
                dr = c.RetornarDataReader(instrucaoSql);
                dr.Read();
                if (dr.HasRows)
                {
                    _StatusUsuario = Convert.ToByte(dr["StatusUsuario"]);

                    _CodigoUsuario = Convert.ToInt32(dr["CodigoUsuario"]);
                    _CodigoNivelAcesso = Convert.ToInt32(dr["CodigoNivelAcesso"]);
                    _DataAcessoUsuario = DateTime.Today;
                    AlterarComParametro();
                    return Convert.ToInt32(dr["CodigoUsuario"]);
                }
                else
                {
                    return 0;
                }
                //return dr.HasRows;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }








    }
}
