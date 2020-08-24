using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class NivelDeAcesso
    {
        public static string instrucaoSql;
        TCC_Inf2Dm.ClasseParaManipularBancoDeDados c = new TCC_Inf2Dm.ClasseParaManipularBancoDeDados();

        private int _CodigoNivelAcesso; 
        private string _NomeNivelAcesso;
        private string _Abreviacao; 
	    private string _Descricao;
        private byte _StatusNivel;


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

        public string NomeNivelAcesso
        {
            get
            {
                return _NomeNivelAcesso;
            }

            set
            {
                _NomeNivelAcesso = value;
            }
        }

        public string Abreviacao
        {
            get
            {
                return _Abreviacao;
            }

            set
            {
                _Abreviacao = value;
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

        public byte StatusNivel
        {
            get
            {
                return _StatusNivel;
            }

            set
            {
                _StatusNivel = value;
            }
        }


        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@NomeNivelAcesso",SqlDbType.VarChar) {Value = _NomeNivelAcesso },
                   new SqlParameter("@Abreviacao",SqlDbType.VarChar) {Value = _Abreviacao },
                   new SqlParameter("@Descricao",SqlDbType.VarChar) {Value = _Descricao },
                 
                   new SqlParameter("@StatusNivel",SqlDbType.Bit) {Value = _StatusNivel }
                };
                //criar o objeto 'listaComParametros' a partir da classe 'sqlparameter' definida como uma lista '[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros.  Cada parametro foi definido com a identificação '@....' + um tipo de dado 'SqlDbType' +  um valor '{Value = _.....}'
                instrucaoSql = "INSERT INTO tbNivelAcesso (NomeNivelAcesso, Abreviacao, Descricao,StatusNivel) VALUES (@NomeNivelAcesso, @Abreviacao, @Descricao,@StatusNivel)";
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
                SqlParameter[] listaComParametros = {new SqlParameter("@CodigoNivelAcesso",SqlDbType.Int) {Value = _CodigoNivelAcesso },
                   new SqlParameter("@NomeNivelAcesso",SqlDbType.VarChar) {Value = _NomeNivelAcesso },
                   new SqlParameter("@Abreviacao",SqlDbType.VarChar) {Value = _Abreviacao },
                   new SqlParameter("@Descricao",SqlDbType.VarChar) {Value = _Descricao },
                   new SqlParameter("@StatusNivel",SqlDbType.Bit) {Value = _StatusNivel }
                };

                instrucaoSql = "UPDATE tbNivelAcesso SET NomeNivelAcesso=@NomeNivelAcesso, Abreviacao=@Abreviacao,Descricao=@Descricao,StatusNivel=@StatusNivel WHERE CodigoNivelAcesso=@CodigoNivelAcesso";
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
                instrucaoSql = "UPDATE tbNivelAcesso SET StatusNivel=1   WHERE CodigoNivelAcesso=" + _CodigoNivelAcesso;
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
                instrucaoSql = "UPDATE tbNivelAcesso SET StatusNivel=0  WHERE CodigoNivelAcesso=" + _CodigoNivelAcesso;
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
                instrucaoSql = "DELETE FROM tbNivelAcesso  WHERE CodigoNivelAcesso=" + _CodigoNivelAcesso;
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
                instrucaoSql = "SELECT * FROM tbNivelAcesso  WHERE CodigoNivelAcesso=" + _CodigoNivelAcesso;
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
                instrucaoSql = "SELECT * FROM tbNivelAcesso";
                if (parteNome.Length != 0)
                {
                    instrucaoSql = instrucaoSql + " WHERE NomeNivelAcesso LIKE '%" + parteNome + "%'"; //avisado sobre comportamento
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
                instrucaoSql = "SELECT CodigoNivelAcesso, NomeNivelAcesso, StatusNivel FROM tbNivelAcesso WHERE StatusNivel=1";
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
                instrucaoSql = "SELECT CodigoNivelAcesso, NomeNivelAcesso FROM tbNivelAcesso WHERE StatusNivel=0";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }




    }
}
