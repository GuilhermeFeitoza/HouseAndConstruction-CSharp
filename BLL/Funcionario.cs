using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
   public class Funcionario
    {
        TCC_Inf2Dm.ClasseParaManipularBancoDeDados c = new TCC_Inf2Dm.ClasseParaManipularBancoDeDados();
        public static string instrucaoSql;


        private int _CodigoFuncionario;
        private string _Nome;
        private string _Sexo;
        private DateTime _DataNascimento;
        private string _CPF;
        private string _RG;
        private string _CEP;
        private int _Numero;
        private string _Complemento;
        private string _Email;
        private string _Telefone;
        private string _Foto;
        private int _CodigoCargo;
        private DateTime _DataAdmissao;
      
        private double _Salario;

        private byte _StatusFuncionario;

        public int CodigoFuncionario
        {
            get
            {
                return _CodigoFuncionario;
            }

            set
            {
                _CodigoFuncionario = value;
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

        public string CPF
        {
            get
            {
                return _CPF;
            }

            set
            {
                _CPF = value;
            }
        }

        public string RG
        {
            get
            {
                return _RG;
            }

            set
            {
                _RG = value;
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

        public string Foto
        {
            get
            {
                return _Foto;
            }

            set
            {
                _Foto = value;
            }
        }

        public int CodigoCargo
        {
            get
            {
                return _CodigoCargo;
            }

            set
            {
                _CodigoCargo = value;
            }
        }

        public byte StatusFuncionario
        {
            get
            {
                return _StatusFuncionario;
            }

            set
            {
                _StatusFuncionario = value;
            }
        }

        public double Salario
        {
            get
            {
                return _Salario;
            }

            set
            {
                _Salario = value;
            }
        }

        public DateTime DataAdmissao
        {
            get
            {
                return _DataAdmissao;
            }

            set
            {
                _DataAdmissao = value;
            }
        }

        public void Incluir()
        {
            try
            {
                instrucaoSql = "INSERT INTO tbFuncionario (Nome,Sexo,DataNascimento,CPF,RG,CEP,Numero,Bairro,Complemento,Email,Telefone,Foto,CodigoCargo,StatusFuncionario) Values ('" + _Nome + "','" + _Sexo + "', #" + _DataNascimento + "#,'" + _CPF + "',+_Numero + ,'" + _RG + "','" + _CEP + "','" + _Complemento + "','" + _Email + "','" + _Telefone + "','" + _Foto + "','" + _CodigoCargo + "', +_StatusFuncionario +  )";
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
                   new SqlParameter("@Nome",SqlDbType.VarChar) {Value = _Nome },
                   new SqlParameter("@Sexo",SqlDbType.VarChar) {Value = _Sexo},
                   new SqlParameter("@DataNascimento ",SqlDbType.DateTime) {Value = _DataNascimento },
                   new SqlParameter("@CPF",SqlDbType.VarChar) {Value = _CPF },
                   new SqlParameter("@RG",SqlDbType.VarChar) {Value = _RG },
                   new SqlParameter("@CEP",SqlDbType.VarChar) {Value = _CEP },
                   new SqlParameter("@Numero",SqlDbType.Int) {Value = _Numero },
                   new SqlParameter("@Complemento",SqlDbType.VarChar) {Value = _Complemento },
                   new SqlParameter("@Email",SqlDbType.VarChar) {Value = _Email },
                   new  SqlParameter("@Telefone",SqlDbType.VarChar) {Value = _Telefone },
                   new SqlParameter("@Foto",SqlDbType.VarChar) {Value = _Foto },
                   new SqlParameter("@CodigoCargo",SqlDbType.Int) {Value = _CodigoCargo },
                   new SqlParameter("@Salario",SqlDbType.Decimal) {Value = _Salario },
                   new SqlParameter("@DataAdmissao ",SqlDbType.DateTime) {Value = _DataAdmissao },
                   new SqlParameter("@StatusFuncionario",SqlDbType.Bit) {Value = _StatusFuncionario }
                };
                //criar o objeto 'listaComParametros' a partir da classe 'sqlparameter' definida como uma lista '[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros.  Cada parametro foi definido com a identificação '@....' + um tipo de dado 'SqlDbType' +  um valor '{Value = _.....}'
                instrucaoSql = "INSERT INTO tbFuncionario (Nome,Sexo,DataNascimento,CPF,RG,CEP,Numero,Complemento,Email,Telefone,Foto,CodigoCargo,Salario,DataAdmissao,StatusFuncionario) VALUES (@Nome,@Sexo, @DataNascimento, @CPF,@RG,@CEP,@Numero,@Complemento,@Email,@Telefone,@Foto,@CodigoCargo,@Salario,@DataAdmissao,@StatusFuncionario)";
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
                SqlParameter[] listaComParametros = {new SqlParameter("@CodigoFuncionario",SqlDbType.Int) {Value = _CodigoFuncionario },
                   new SqlParameter("@Nome",SqlDbType.VarChar) {Value = _Nome },
                   new SqlParameter("@Sexo",SqlDbType.VarChar) {Value = _Sexo},
                   new SqlParameter("@DataNascimento ",SqlDbType.DateTime) {Value = _DataNascimento },
                   new SqlParameter("@CPF",SqlDbType.VarChar) {Value = _CPF },
                   new SqlParameter("@RG",SqlDbType.VarChar) {Value = _RG },
                   new SqlParameter("@CEP",SqlDbType.VarChar) {Value = _CEP },
                   new SqlParameter("@Numero",SqlDbType.Int) {Value = _Numero },
                   new SqlParameter("@Complemento",SqlDbType.VarChar) {Value = _Complemento },
                   new SqlParameter("@Email",SqlDbType.VarChar) {Value = _Email },
                   new  SqlParameter("@Telefone",SqlDbType.VarChar) {Value = _Telefone },
                   new SqlParameter("@Foto",SqlDbType.VarChar) {Value = _Foto },
                   new SqlParameter("@CodigoCargo",SqlDbType.Int) {Value = _CodigoCargo },
                   new SqlParameter("@Salario",SqlDbType.Decimal) {Value = _Salario },
                   new SqlParameter("@DataAdmissao ",SqlDbType.DateTime) {Value = DataAdmissao },
                   new SqlParameter("@StatusFuncionario",SqlDbType.Bit) {Value = StatusFuncionario }
                    };


                instrucaoSql = "UPDATE tbFuncionario SET Nome=@Nome,Sexo=@Sexo, DataNascimento=@DataNascimento, CPF=@CPF,RG=@RG,CEP=@CEP,Numero=@Numero,Complemento=@Complemento,Email=@Email,Telefone=@Telefone,Foto=@Foto,CodigoCargo=@CodigoCargo,Salario=@Salario,DataAdmissao=@DataAdmissao,StatusFuncionario=@StatusFuncionario WHERE CodigoFuncionario=@CodigoFuncionario";
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
                instrucaoSql = "INSERT INTO tbFuncionario (Nome,Sexo,DataNascimento,CPF,RG,CEP,Bairro,Complemento,Email,Telefone,Foto,CodigoCargo,StatusFuncionario) Values ('" + _Nome + "','" + _Sexo + "', #" + _DataNascimento + "#,'" + _CPF + "','" + _RG + "','" + _CEP + "'," + _Complemento + "','" + _Email + "','" + _Telefone + "','" + _Foto + "','" + _CodigoCargo + "', +_StatusFuncionario +  )";
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
                instrucaoSql = "UPDATE tbFuncionario SET StatusFuncionario=1   WHERE CodigoFuncionario=" + _CodigoFuncionario;
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
                instrucaoSql = "UPDATE tbFuncionario SET StatusFuncionario=0  WHERE CodigoFuncionario=" + _CodigoFuncionario;
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
                instrucaoSql = "DELETE FROM tbFuncionario  WHERE CodigoFuncionario=" + _CodigoFuncionario;
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
                instrucaoSql = "SELECT * FROM tbFuncionario  WHERE CodigoFuncionario=" + _CodigoFuncionario;
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
                instrucaoSql = "SELECT * FROM tbFuncionario";
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
                instrucaoSql = "SELECT CodigoFuncionario, Nome, StatusFuncionario FROM tbFuncionario WHERE StatusFuncionario=1";
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
                instrucaoSql = "SELECT CodigoFuncionario, Nome, StatusFuncionario FROM tbFuncionario WHERE StatusFuncionario=0";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
