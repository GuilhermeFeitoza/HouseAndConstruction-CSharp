using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Categoria
    {
        public static string instrucaoSql;

        private int _CodigoCategoria;
        private string _NomeCategoria;
        private string _DescricaoCategoria;





        TCC_Inf2Dm.ClasseParaManipularBancoDeDados c = new TCC_Inf2Dm.ClasseParaManipularBancoDeDados();

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

        public string NomeCategoria
        {
            get
            {
                return _NomeCategoria;
            }

            set
            {
                _NomeCategoria = value;
            }
        }

        public string DescricaoCategoria
        {
            get
            {
                return _DescricaoCategoria;
            }

            set
            {
                _DescricaoCategoria = value;
            }
        }

        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@CodigoCategoria",SqlDbType.Int) {Value = CodigoCategoria },
                   new SqlParameter("@NomeCategoria",SqlDbType.VarChar) {Value = NomeCategoria },
                   new SqlParameter("@DescricaoCategoria",SqlDbType.VarChar) {Value = _DescricaoCategoria },
                };
                //criar o objeto 'listaComParametros' a partir da classe 'sqlparameter' definida como uma lista '[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros.  Cada parametro foi definido com a identificação '@....' + um tipo de dado 'SqlDbType' +  um valor '{Value = _.....}'
                instrucaoSql = "INSERT INTO tbCategoria ( NomeCategoria, DescricaoCategoria) VALUES (@NomeCategoria, @DescricaoCategoria)";
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
                   new SqlParameter("@CodigoCategoria",SqlDbType.Int) {Value = CodigoCategoria },
                   new SqlParameter("@NomeCategoria",SqlDbType.VarChar) {Value = NomeCategoria },
                   new SqlParameter("@DescricaoCategoria",SqlDbType.VarChar) {Value = _DescricaoCategoria }
                };

                instrucaoSql = "UPDATE tbCategoria SET NomeCategoria=@NomeCategoria, DescricaoCategoria=@DescricaoCategoria, WHERE CodigoCategoria=@CodigoCategoria";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);



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
                instrucaoSql = "DELETE FROM tbCategoria  WHERE CodigoCategoria=" + CodigoCategoria;
                c.ExecutarComando(instrucaoSql);
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
                instrucaoSql = "SELECT * FROM tbCategoria";
                if (parteNome.Length != 0)
                {
                    instrucaoSql = instrucaoSql + " WHERE NomeCategoria LIKE '%" + parteNome + "%'"; //avisado sobre comportamento
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
