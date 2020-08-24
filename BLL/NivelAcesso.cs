using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class NivelAcesso
    {
        TCC_Inf2Dm.ClasseParaManipularBancoDeDados c = new TCC_Inf2Dm.ClasseParaManipularBancoDeDados();
        public static string instrucaoSql;

        private int _CodigoNivelAcesso;
        private string _NomeNivelAcesso;
        private string _Abreviacao;
        private string _Descricao;
        private byte _StatusNivel;
        private byte _Permissao_Usuarios;
        private byte _Permissao_Clientes;
        private byte _Permissao_Funcionarios;
        private byte _Permissao_Fornecedores;
        private byte _Permissao_Produtos;
        private byte _Permissao_Contas;
        private byte _Permissao_Vender;
        private byte _Permissao_Orcamento;

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

        public byte Permissao_Usuarios
        {
            get
            {
                return _Permissao_Usuarios;
            }

            set
            {
                _Permissao_Usuarios = value;
            }
        }

        public byte Permissao_Clientes
        {
            get
            {
                return _Permissao_Clientes;
            }

            set
            {
                _Permissao_Clientes = value;
            }
        }

        public byte Permissao_Funcionarios
        {
            get
            {
                return _Permissao_Funcionarios;
            }

            set
            {
                _Permissao_Funcionarios = value;
            }
        }

        public byte Permissao_Fornecedores
        {
            get
            {
                return _Permissao_Fornecedores;
            }

            set
            {
                _Permissao_Fornecedores = value;
            }
        }

        public byte Permissao_Produtos
        {
            get
            {
                return _Permissao_Produtos;
            }

            set
            {
                _Permissao_Produtos = value;
            }
        }

        public byte Permissao_Contas
        {
            get
            {
                return _Permissao_Contas;
            }

            set
            {
                _Permissao_Contas = value;
            }
        }

        public byte Permissao_Vender
        {
            get
            {
                return _Permissao_Vender;
            }

            set
            {
                _Permissao_Vender = value;
            }
        }

        public byte Permissao_Orcamento
        {
            get
            {
                return _Permissao_Orcamento;
            }

            set
            {
                _Permissao_Orcamento = value;
            }
        }

        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@CodigoNivelAcesso",SqlDbType.Int) {Value = _CodigoNivelAcesso },
                   new SqlParameter("@NomeNivelAcesso ",SqlDbType.VarChar) {Value = _NomeNivelAcesso },
                   new SqlParameter("@Abreviacao",SqlDbType.VarChar) {Value = _Abreviacao },
                   new SqlParameter("@Descricao",SqlDbType.VarChar) {Value = _Descricao},
                   new SqlParameter("@StatusNivel",SqlDbType.Bit) {Value = _StatusNivel },
                   new SqlParameter("@Permissao_Usuarios",SqlDbType.Bit) {Value = _Permissao_Usuarios },
                 
                   new SqlParameter("@Permissao_Clientes",SqlDbType.Bit) {Value = _Permissao_Clientes },
                   new SqlParameter("@Permissao_Funcionarios",SqlDbType.Bit) {Value = _Permissao_Funcionarios },
                   new SqlParameter("@Permissao_Fornecedores",SqlDbType.Bit) {Value = _Permissao_Fornecedores },
                   new SqlParameter("@Permissao_Produtos",SqlDbType.Bit) {Value = _Permissao_Produtos },
                   new SqlParameter("@Permissao_Contas",SqlDbType.Bit) {Value = _Permissao_Contas },
                   new SqlParameter("@Permissao_Vender",SqlDbType.Bit) {Value = _Permissao_Vender },
                   new SqlParameter("@Permissao_Orcamento",SqlDbType.Bit) {Value = _Permissao_Orcamento }
                };
                //criar o objeto 'listaComParametros' a partir da classe 'sqlparameter' definida como uma lista '[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros.  Cada parametro foi definido com a identificação '@....' + um tipo de dado 'SqlDbType' +  um valor '{Value = _.....}'
                instrucaoSql = "INSERT INTO tbNivelAcesso(NomeNivelAcesso,Abreviacao,Descricao,Permissao_Usuarios,Permissao_Clientes,Permissao_Funcionarios,Permissao_Fornecedores,Permissao_Produtos,Permissao_Contas,Permissao_Vender,Permissao_Orcamento,StatusNivel)VALUES(@NomeNivelAcesso,@Abreviacao,@Descricao,@Permissao_Usuarios,@Permissao_Clientes,@Permissao_Funcionarios,@Permissao_Fornecedores,@Permissao_Produtos,@Permissao_Contas,@Permissao_Vender,@Permissao_Orcamento,@StatusNivel)";
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
                   new SqlParameter("@CodigoNivelAcesso",SqlDbType.Int) {Value = _CodigoNivelAcesso },
                   new SqlParameter("@NomeNivelAcesso ",SqlDbType.VarChar) {Value = _NomeNivelAcesso },
                   new SqlParameter("@Abreviacao",SqlDbType.VarChar) {Value = _Abreviacao },
                   new SqlParameter("@Descricao",SqlDbType.VarChar) {Value = _Descricao},
                   new SqlParameter("@StatusNivel",SqlDbType.Bit) {Value = _StatusNivel },
                   new SqlParameter("@Permissao_Usuarios",SqlDbType.Bit) {Value = _Permissao_Usuarios },

                   new SqlParameter("@Permissao_Clientes",SqlDbType.Bit) {Value = _Permissao_Clientes },
                   new SqlParameter("@Permissao_Funcionarios",SqlDbType.Bit) {Value = _Permissao_Funcionarios },
                   new SqlParameter("@Permissao_Fornecedores",SqlDbType.Bit) {Value = _Permissao_Fornecedores },
                   new SqlParameter("@Permissao_Produtos",SqlDbType.Bit) {Value = _Permissao_Produtos },
                   new SqlParameter("@Permissao_Contas",SqlDbType.Bit) {Value = _Permissao_Contas },
                   new SqlParameter("@Permissao_Vender",SqlDbType.Bit) {Value = _Permissao_Vender },
                   new SqlParameter("@Permissao_Orcamento",SqlDbType.Bit) {Value = _Permissao_Orcamento }
                };


                instrucaoSql = "UPDATE tbNivelAcesso SET NomeNivelAcesso=@NomeNivelAcesso,Abreviacao=@Abreviacao,Descricao=@Descricao,Permissao_Usuarios=@Permissao_Usuarios,Permissao_Clientes=@Permissao_Clientes,Permissao_Funcionarios=@Permissao_Funcionarios,Permissao_Produtos=@Permissao_Produtos,Permissao_Contas=@Permissao_Contas,Permissao_Vender=@Permissao_Vender,@Permissao_Orcamento=@Permissao_Orcamento,StatusNivel=@StatusNivel WHERE CodigoNivelAcesso=@CodigoNivelAcesso";
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
                instrucaoSql = "SELECT CodigoNivelAcesso, Nome, StatusNivel FROM tbNivelAcesso WHERE StatusNivel=1";
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
                instrucaoSql = "SELECT CodigoNivelAcesso, NomeNivelAcesso, StatusNivel FROM tbNivelAcesso WHERE StatusNivel=0";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public string ConsultarNomeNivel()
        {
            try
            { BLL.Usuario usu = new Usuario();
                
                instrucaoSql = "SELECT NomeNivelAcesso FROM tbNivelAcesso WHERE CodigoNivelAcesso=" +usu.CodigoNivelAcesso;
                SqlDataReader dr;
                dr = c.RetornarDataReader(instrucaoSql);
                dr.Read();
                if (dr.HasRows)
                {


                    return Convert.ToString(dr["NomeNivelAcesso"]);
                }
                else
                {
                    return "teste";
                }
              
               

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }













    }
}
