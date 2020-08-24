using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace BLL
{
    public class FormaPagamento
    {
        private int _CodigoForma;
        private string _NomeForma;

        TCC_Inf2Dm.ClasseParaManipularBancoDeDados c = new TCC_Inf2Dm.ClasseParaManipularBancoDeDados();

        public static string instrucaoSql;

        public int CodigoForma
        {
            get
            {
                return _CodigoForma;
            }

            set
            {
                _CodigoForma = value;
            }
        }

        public string NomeForma
        {
            get
            {
                return _NomeForma;
            }

            set
            {
                _NomeForma = value;
            }
        }

        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@CodigoForma",SqlDbType.Int) {Value = CodigoForma },
                   new SqlParameter("@NomeForma",SqlDbType.VarChar) {Value = NomeForma }

                };

                //criar o objeto 'listaComParametros' a partir da classe 'sqlparameter' definida como uma lista '[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros.  Cada parametro foi definido com a identificação '@....' + um tipo de dado 'SqlDbType' +  um valor '{Value = _.....}'
                instrucaoSql = "INSERT INTO tbFormaPgto (Nome) VALUES (@NomeForma)";
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
                   new SqlParameter("@CodigoForma",SqlDbType.Int) {Value = CodigoForma },
                   new SqlParameter("@NomeForma",SqlDbType.VarChar) {Value = NomeForma }
               
                };

                instrucaoSql = "UPDATE tbFormaPgto SET Nome=@NomeForma WHERE CodigoFormaPgto=@CodigoForma";
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
                instrucaoSql = "DELETE FROM tbFormaPgto  WHERE CodigoFormaPgto=" + CodigoForma;
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
                instrucaoSql = "SELECT * FROM tbFormaPgto";
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


    }
}
