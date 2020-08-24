using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Cliente

    {
        TCC_Inf2Dm.ClasseParaManipularBancoDeDados c = new TCC_Inf2Dm.ClasseParaManipularBancoDeDados();
        public static string instrucaoSql;

        private string _CEP;

        private int _CodigoCliente;
        private string _Nome;
        private DateTime _DataNascimento;
        private string _Endereco;
        private string _Bairro;
        private string _Cidade;
        private string _Complemento;
        private string _UF;
        private string _Rg;
        private string _Cpf;
        private string _Sexo;
        private string _Telefone;
        private string _Email;
        private int _StatusCliente;
        private int _Numero;
        private string _Senha;

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

        public string Nome
        {
            get
            {
                return _Nome;
            }

            set
            {
                _Nome = value;
            }
        }

        public DateTime DataNascimento
        {
            get
            {
                return _DataNascimento;
            }

            set
            {
                _DataNascimento = value;
            }
        }

        public string Endereco
        {
            get
            {
                return _Endereco;
            }

            set
            {
                _Endereco = value;
            }
        }

        public string Bairro
        {
            get
            {
                return _Bairro;
            }

            set
            {
                _Bairro = value;
            }
        }

        public string Cidade
        {
            get
            {
                return _Cidade;
            }

            set
            {
                _Cidade = value;
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

        public string UF
        {
            get
            {
                return _UF;
            }

            set
            {
                _UF = value;
            }
        }

        public string Rg
        {
            get
            {
                return _Rg;
            }

            set
            {
                _Rg = value;
            }
        }

        public string Cpf
        {
            get
            {
                return _Cpf;
            }

            set
            {
                _Cpf = value;
            }
        }

        

        public string Sexo
        {
            get
            {
                return _Sexo;
            }

            set
            {
                _Sexo = value;
            }
        }

        public string Telefone
        {
            get
            {
                return _Telefone;
            }

            set
            {
                _Telefone = value;
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

        public int StatusCliente
        {
            get
            {
                return _StatusCliente;
            }

            set
            {
                _StatusCliente = value;
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

        public string Senha
        {
            get
            {
                return _Senha;
            }

            set
            {
                _Senha = value;
            }
        }




        //---------METODOS------
        public void Incluir()
        {
            try
            {
                instrucaoSql = "INSERT INTO tbCliente (Nome, DataNascimento, Endereco,Bairro,Cidade,Complemento,Numero,UF,CEP,Rg,Cpf,Sexo,Telefone,Email,StatusCliente) Values ('" + _Nome + "', #" + _DataNascimento + "#,'" + _Endereco + "','"+_Bairro+ "','" + _Cidade + "','" + _Complemento + "','"+_Numero+"','" + _UF + "','" + _CEP + "','" + _Rg + "','" + _Cpf + "','" + _Sexo + "','" + _Telefone + "','" + _Email + "','" + _Cidade + "', +_StatusCliente +  )";
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
                Senha = "123";
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@Nome",SqlDbType.VarChar) {Value = _Nome },
                   new SqlParameter("@DataNascimento ",SqlDbType.DateTime) {Value = _DataNascimento },
                   new SqlParameter("@Endereco",SqlDbType.VarChar) {Value = _Endereco },
                   new SqlParameter("@Bairro",SqlDbType.VarChar) {Value = _Bairro},
                   new SqlParameter("@Cidade",SqlDbType.VarChar) {Value = _Cidade },
                   new SqlParameter("@Complemento",SqlDbType.VarChar) {Value = _Complemento },
                   new SqlParameter("@Numero",SqlDbType.Int) {Value = _Numero },
                   new SqlParameter("@UF",SqlDbType.VarChar) {Value = _UF },
                   new SqlParameter("@CEP",SqlDbType.VarChar) {Value = _CEP },
                   new SqlParameter("@Rg",SqlDbType.VarChar) {Value = _Rg },
                   new SqlParameter("@Cpf",SqlDbType.VarChar) {Value = _Cpf },
                   new SqlParameter("@Sexo",SqlDbType.VarChar) {Value = _Sexo},
                   new  SqlParameter("@Telefone",SqlDbType.VarChar) {Value = _Telefone },
                   new SqlParameter("@Email",SqlDbType.VarChar) {Value = _Email },
                   new SqlParameter("@Senha",SqlDbType.VarChar) {Value = _Senha },

                   new SqlParameter("@StatusCliente",SqlDbType.Int) {Value = _StatusCliente }
                };
                Senha = "123";
                //criar o objeto 'listaComParametros' a partir da classe 'sqlparameter' definida como uma lista '[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros.  Cada parametro foi definido com a identificação '@....' + um tipo de dado 'SqlDbType' +  um valor '{Value = _.....}'
                instrucaoSql = "INSERT INTO tbCliente (Nome, DataNascimento, Endereco,Bairro,Cidade,Complemento,Numero,UF,CEP,Rg,Cpf,Sexo,Telefone,Email,StatusCliente,Senha) VALUES (@Nome, @DataNascimento, @Endereco,@Bairro,@Cidade,@Complemento,@Numero,@UF,@CEP,@Rg,@Cpf,@Sexo,@Telefone,@Email,@StatusCliente,@Senha)";
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
                    SqlParameter[] listaComParametros = {new SqlParameter("@CodigoCliente",SqlDbType.Int) {Value = _CodigoCliente },
                   new SqlParameter("@Nome", SqlDbType.VarChar) { Value = _Nome },
                   new SqlParameter("@DataNascimento ", SqlDbType.DateTime) { Value = _DataNascimento },
                   new SqlParameter("@Endereco", SqlDbType.VarChar) { Value = _Endereco },
                   new SqlParameter("@Bairro", SqlDbType.VarChar) { Value = _Bairro },
                   new SqlParameter("@Cidade", SqlDbType.VarChar) { Value = _Cidade },
                   new SqlParameter("@Complemento", SqlDbType.VarChar) { Value = Complemento },
                   new SqlParameter("@Numero",SqlDbType.VarChar) {Value = _Numero },
                   new SqlParameter("@UF", SqlDbType.VarChar) { Value = _UF },
                   new SqlParameter("@CEP", SqlDbType.VarChar) { Value = _CEP },
                   new SqlParameter("@Rg", SqlDbType.VarChar) { Value = _Rg },
                   new SqlParameter("@Cpf", SqlDbType.VarChar) { Value = _Cpf },
                   new SqlParameter("@Sexo", SqlDbType.VarChar) { Value = _Sexo },
                   new SqlParameter("@Telefone", SqlDbType.VarChar) { Value = _Telefone },
                   new SqlParameter("@Email", SqlDbType.VarChar) { Value = _Email },
                   new SqlParameter("@StatusCliente", SqlDbType.Int) { Value = _StatusCliente }
                    };


                instrucaoSql = "UPDATE tbCliente SET Nome=@Nome, DataNascimento=@DataNascimento, Endereco=@Endereco,Bairro=@Bairro,Cidade=@Cidade,Complemento=@Complemento,Numero=@Numero,UF=@UF,CEP=@CEP,Rg=@Rg,Cpf=@Cpf,Sexo=@Sexo,Telefone=@Telefone,Email=@Email,StatusCliente=@StatusCliente WHERE CodigoCliente=@CodigoCliente";
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
                instrucaoSql = "INSERT INTO tbCliente (Nome, DataNascimento, Endereco,Bairro,Cidade,Complemento,Numero,UF,CEP,Rg,Cpf,Sexo,Telefone,Email,StatusCliente) Values ('" + _Nome + "', #" + _DataNascimento + "#,'" + _Endereco + "','" + _Bairro + "','" + _Cidade + "','" + _Complemento + "','" + _Numero + "','" + _UF + "','" + _CEP + "','" + _Rg + "','" + _Cpf + "','" + _Sexo + "','" + _Telefone + "','" + _Email + "','" + _Cidade + "', +_StatusCliente +  )";
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
                instrucaoSql = "UPDATE tbCliente SET StatusCliente=1   WHERE CodigoCliente=" + _CodigoCliente;
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
                instrucaoSql = "UPDATE tbCliente SET StatusCliente=0  WHERE CodigoCliente=" + _CodigoCliente;
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
                instrucaoSql = "DELETE FROM tbCliente  WHERE CodigoCliente=" + _CodigoCliente;
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
                instrucaoSql = "SELECT * FROM tbCliente  WHERE CodigoCliente=" + _CodigoCliente;
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
                instrucaoSql = "SELECT * FROM tbCliente";
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

        public DataSet ListarAtivos()
        {
            try
            {
                instrucaoSql = "SELECT CodigoCliente, Nome, StatusCliente FROM tbCliente WHERE StatusCliente=1";
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
                instrucaoSql = "SELECT CodigoCliente, Nome, StatusCliente FROM tbCliente WHERE StatusCliente=0";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public SqlDataReader BuscarPorCodigo()
        {
            try
            {
                instrucaoSql = "SELECT * FROM tbCliente  WHERE CodigoCliente=" + _CodigoCliente;
                return c.RetornarDataReader(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }






    }
}
