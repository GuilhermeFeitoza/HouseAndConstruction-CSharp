using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class UnidadeMedida
    {
        public static string instrucaoSql;

        private int _codigoUnidadeMedida;
        private string _nomeUnidadeMedida;
        private string _abreviacao;  

        

        public int CodigoUnidadeMedida
        {
            get
            {
                return _codigoUnidadeMedida;
            }

            set
            {
                _codigoUnidadeMedida = value;
            }
        }

        public string NomeUnidadeMedida
        {
            get
            {
                return _nomeUnidadeMedida;
            }

            set
            {
                _nomeUnidadeMedida = value;
            }
        }

        public string Abreviacao
        {
            get
            {
                return _abreviacao;
            }

            set
            {
                _abreviacao = value;
            }
        }

        

        TCC_Inf2Dm.ClasseParaManipularBancoDeDados c = new TCC_Inf2Dm.ClasseParaManipularBancoDeDados();

        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@CodigoUnidadeMedida",SqlDbType.Int) {Value = _codigoUnidadeMedida },
                   new SqlParameter("@NomeUnidadeMedida",SqlDbType.VarChar) {Value = _nomeUnidadeMedida },
                   new SqlParameter("@Abreviacao",SqlDbType.Char) {Value = _abreviacao },
                };
                //criar o objeto 'listaComParametros' a partir da classe 'sqlparameter' definida como uma lista '[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros.  Cada parametro foi definido com a identificação '@....' + um tipo de dado 'SqlDbType' +  um valor '{Value = _.....}'
                instrucaoSql = "INSERT INTO tbUnidadeMedida (CodigoUnidadeMedida, NomeUnidadeMedida, Abreviacao) VALUES (@CodigoUnidadeMedida, @NomeUnidadeMedida, @Abreviacao)";
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
                   new SqlParameter("@CodigoUnidadeMedida",SqlDbType.Int) {Value = _codigoUnidadeMedida },
                   new SqlParameter("@NomeUnidadeMedida",SqlDbType.VarChar) {Value = _nomeUnidadeMedida },
                   new SqlParameter("@Abreviacao",SqlDbType.Char) {Value = _abreviacao }
                };

                instrucaoSql = "UPDATE tbUnidadeMedida SET CodigoUnidadeMedida=@CodigoUnidadeMedida,NomeUnidadeMedida=@NomeUnidadeMedida, Abreviacao=@Abreviacao, WHERE CodigoUnidadeMedida=@CodigoUnidadeMedida";
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
                instrucaoSql = "DELETE FROM tbUnidadeMedida  WHERE CodigoUnidadeMedida=" + _codigoUnidadeMedida;
                c.ExecutarComando(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }














    }
}
