using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
  public class Fornecedor
    {
        public static string instrucaoSql;
        TCC_Inf2Dm.ClasseParaManipularBancoDeDados c = new TCC_Inf2Dm.ClasseParaManipularBancoDeDados();
        private int _CodigoFornecedor;
        private string _NomeFantasia;
        private string _RazaoSocial;
        private string _CNPJ;
        private string _CEP;
        private string _Complemento;
        private int _Numero;
        private string _Tel;
        private string _Email;
        private int _StatusFornecedor;

        public int CodigoFornecedor
        {
            get
            {
                return _CodigoFornecedor;
            }

            set
            {
                _CodigoFornecedor = value;
            }
        }

        public string NomeFantasia
        {
            get
            {
                return _NomeFantasia;
            }

            set
            {
                _NomeFantasia = value;
            }
        }

        public string RazaoSocial
        {
            get
            {
                return _RazaoSocial;
            }

            set
            {
                _RazaoSocial = value;
            }
        }
         
        public string CNPJ
        {
            get
            {
                return _CNPJ;
            }

            set
            {
                _CNPJ = value;
            }
        }

        public string CEP
        {
            get
            {
                return _CEP;
            }

            set
            {
                _CEP = value;
            }
        }

        public string Complemento
        {
            get
            {
                return _Complemento;
            }

            set
            {
                _Complemento = value;
            }
        }

        public int Numero
        {
            get
            {
                return _Numero;
            }

            set
            {
                _Numero = value;
            }
        }

        public string Tel
        {
            get
            {
                return _Tel;
            }

            set
            {
                _Tel = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }

        public int StatusFornecedor
        {
            get
            {
                return _StatusFornecedor;
            }

            set
            {
                _StatusFornecedor = value;
            }
        }

        public void Incluir()
        {
            try
            {
                instrucaoSql = "INSERT INTO tbFornecedores (NomeFantasia, RazaoSocial,CNPJ,CEP,Complemento,Numero,Tel,Email,StatusFornecedor) Values ('" + _NomeFantasia + "','" + _RazaoSocial + "','" + _CNPJ + "','" + _CEP + "','" + _Complemento + "','" + _Numero + "','" + _Email + "','" + _CEP + "', +_StatusFornecedor +  )";
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
                   new SqlParameter("@NomeFantasia",SqlDbType.VarChar) {Value = _NomeFantasia },
                   new SqlParameter("@RazaoSocial",SqlDbType.VarChar) {Value = _RazaoSocial },
                   new SqlParameter("@CNPJ",SqlDbType.VarChar) {Value = _CNPJ},
                   new SqlParameter("@CEP",SqlDbType.VarChar) {Value = _CEP },
                   new SqlParameter("@Complemento",SqlDbType.VarChar) {Value = _Complemento },
                   new SqlParameter("@Numero",SqlDbType.Int) {Value = _Numero },
                   new  SqlParameter("@Tel",SqlDbType.VarChar) {Value = _Tel },
                   new SqlParameter("@Email",SqlDbType.VarChar) {Value = _Email },
                   new SqlParameter("@StatusFornecedor",SqlDbType.Int) {Value = StatusFornecedor }
                };
                //criar o objeto 'listaComParametros' a partir da classe 'sqlparameter' definida como uma lista '[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros.  Cada parametro foi definido com a identificação '@....' + um tipo de dado 'SqlDbType' +  um valor '{Value = _.....}'
                instrucaoSql = "INSERT INTO tbFornecedores (NomeFantasia, RazaoSocial, CNPJ,CEP,Complemento,Numero,Tel,Email,StatusFornecedor) VALUES (@NomeFantasia, @RazaoSocial, @CNPJ,@CEP,@Complemento,@Numero,@Tel,@Email,@StatusFornecedor)";
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
                SqlParameter[] listaComParametros = {new SqlParameter("@CodigoFornecedor",SqlDbType.Int) {Value = _CodigoFornecedor },
                   new SqlParameter("@NomeFantasia", SqlDbType.VarChar) { Value = _NomeFantasia },
                   new SqlParameter("@RazaoSocial", SqlDbType.VarChar) { Value = _RazaoSocial },
                   new SqlParameter("@CNPJ", SqlDbType.VarChar) { Value = _CNPJ },
                   new SqlParameter("@CEP", SqlDbType.VarChar) { Value = _CEP },
                   new SqlParameter("@Complemento", SqlDbType.VarChar) { Value = Complemento },
                   new SqlParameter("@Numero",SqlDbType.VarChar) {Value = _Numero },
                   new SqlParameter("@Tel", SqlDbType.VarChar) { Value = _Tel },
                   new SqlParameter("@Email", SqlDbType.VarChar) { Value = _Email },
                   new SqlParameter("@StatusFornecedor", SqlDbType.Int) { Value = StatusFornecedor }
                    };


                instrucaoSql = "UPDATE tbFornecedores SET NomeFantasia=@NomeFantasia, RazaoSocial=@RazaoSocial,CNPJ=@CNPJ,CEP=@CEP,Complemento=@Complemento,Numero=@Numero,Tel=@Tel,Email=@Email,StatusFornecedor=@StatusFornecedor WHERE CodigoFornecedor=@CodigoFornecedor";
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
                instrucaoSql = "INSERT INTO tbFornecedores (NomeFantasia, RazaoSocial,CNPJ,CEP,Complemento,Numero,Tel,Email,StatusFornecedor) Values ('" + _NomeFantasia + "','" + _RazaoSocial + "','" + _CNPJ + "','" + _CEP + "','" + _Complemento + "','" + _Numero + "','" + _Tel + "','" + _Email + "','" + _CEP + "', +_StatusFornecedor +  )";
                return c.RecuperarUltimoCodigoNumeracaoAutomatica(instrucaoSql);
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
                instrucaoSql = "UPDATE tbFornecedores SET StatusFornecedor=1   WHERE CodigoFornecedor=" + _CodigoFornecedor;
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
                instrucaoSql = "UPDATE tbFornecedores SET StatusFornecedor=0  WHERE CodigoFornecedor=" + _CodigoFornecedor;
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
                instrucaoSql = "DELETE FROM tbFornecedores  WHERE CodigoFornecedor=" + _CodigoFornecedor;
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
                instrucaoSql = "SELECT * FROM tbFornecedores  WHERE CodigoFornecedor=" + _CodigoFornecedor;
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
                instrucaoSql = "SELECT * FROM tbFornecedores";
                if (parteNome.Length != 0)
                {
                    instrucaoSql = instrucaoSql + " WHERE NomeFantasia LIKE '%" + parteNome + "%'"; //avisado sobre comportamento
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
                instrucaoSql = "SELECT CodigoFornecedor, NomeFantasia, StatusFornecedor FROM tbFornecedores WHERE StatusFornecedor=1";
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
                instrucaoSql = "SELECT CodigoFornecedor, NomeFantasia, StatusFornecedor FROM tbFornecedores WHERE StatusFornecedor=0";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }













    }
}
