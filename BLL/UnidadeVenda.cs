using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class UnidadeVenda
    {
        public static string instrucaoSql;

        private int _CodigoUnidadeVenda;
        private string _NomeUnidadeVenda;
        private string _Abreviacao;


        


        TCC_Inf2Dm.ClasseParaManipularBancoDeDados c = new TCC_Inf2Dm.ClasseParaManipularBancoDeDados();

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

        public string NomeUnidadeVenda
        {
            get
            {
                return _NomeUnidadeVenda;
            }

            set
            {
                _NomeUnidadeVenda = value;
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

        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@CodigoUnidadeVenda",SqlDbType.Int) {Value = CodigoUnidadeVenda },
                   new SqlParameter("@NomeUnidadeVenda",SqlDbType.VarChar) {Value = NomeUnidadeVenda },
                   new SqlParameter("@Abreviacao",SqlDbType.Char) {Value = _Abreviacao },
                };
                //criar o objeto 'listaComParametros' a partir da classe 'sqlparameter' definida como uma lista '[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros.  Cada parametro foi definido com a identificação '@....' + um tipo de dado 'SqlDbType' +  um valor '{Value = _.....}'
                instrucaoSql = "INSERT INTO tbUnidadeVenda ( NomeUnidadeVenda, Abreviacao) VALUES (@CodigoUnidadeVenda, @NomeUnidadeVenda, @Abreviacao)";
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
                   new SqlParameter("@CodigoUnidadeVenda",SqlDbType.Int) {Value = CodigoUnidadeVenda },
                   new SqlParameter("@NomeUnidadeVenda",SqlDbType.VarChar) {Value = NomeUnidadeVenda },
                   new SqlParameter("@Abreviacao",SqlDbType.Char) {Value = _Abreviacao }
                };

                instrucaoSql = "UPDATE tbUnidadeVenda SET NomeUnidadeVenda=@NomeUnidadeVenda, Abreviacao=@Abreviacao, WHERE CodigoUnidadeVenda=@CodigoUnidadeVenda";
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
                instrucaoSql = "DELETE FROM tbUnidadeVenda  WHERE CodigoUnidadeVenda=" + CodigoUnidadeVenda;
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
                instrucaoSql = "SELECT * FROM tbUnidadeVenda";
                if (parteNome.Length != 0)
                {
                    instrucaoSql = instrucaoSql + " WHERE NomeUnidadeVenda LIKE '%" + parteNome + "%'"; //avisado sobre comportamento
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
