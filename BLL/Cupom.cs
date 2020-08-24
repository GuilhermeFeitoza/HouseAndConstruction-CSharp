using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace BLL
{
    public class Cupom
    {
        public static string instrucaosql;
        TCC_Inf2Dm.ClasseParaManipularBancoDeDados c = new TCC_Inf2Dm.ClasseParaManipularBancoDeDados();


        private int _Id;
        private string _Descricao;
        private string _CodigoCupom;
        private decimal _ValorCupom;
        private DateTime _DataInicio;
        private DateTime _DataFim;
        private int _StatusCupom;

        public int Id
        {
            get
            {
                return _Id;
            }

            set
            {
                _Id = value;
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

        public string CodigoCupom
        {
            get
            {
                return _CodigoCupom;
            }

            set
            {
                _CodigoCupom = value;
            }
        }

        public decimal ValorCupom
        {
            get
            {
                return _ValorCupom;
            }

            set
            {
                _ValorCupom = value;
            }
        }

        public DateTime DataInicio
        {
            get
            {
                return _DataInicio;
            }

            set
            {
                _DataInicio = value;
            }
        }

        public DateTime DataFim
        {
            get
            {
                return _DataFim;
            }

            set
            {
                _DataFim = value;
            }
        }

        public int StatusCupom
        {
            get
            {
                return _StatusCupom;
            }

            set
            {
                _StatusCupom = value;
            }
        }



        //ID int primary key identity,
        //Descricao varchar(100),
        //CodigoCupom varchar(10),
        //TipoCupom char (1),--V Valor, P porcentagem
        // ValorCupom decimal (7,2),
        //DataInicio datetime,
        //DataFim datetime,
        //StatusCupom int




        public DataSet ListarCupons(string parteNome)
        {
            try
            {
                instrucaosql = "Select*from tbCupom";
                return c.RetornarDataSet(instrucaosql);
            }
            catch (Exception ex)
            {

                throw ex;
            }






        }

        public void NovoCupom()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@CodigoCupom",SqlDbType.VarChar) {Value = CodigoCupom },
                   new SqlParameter("@Descricao ",SqlDbType.VarChar) {Value = Descricao },
                   new SqlParameter("@ValorCupom ",SqlDbType.Decimal) {Value = ValorCupom },
                   new SqlParameter("@DataInicio",SqlDbType.DateTime) {Value = DataInicio },
                   new SqlParameter("@DataFim",SqlDbType.DateTime) {Value = DataFim},
                   new SqlParameter("@StatusCupom",SqlDbType.Int) {Value = StatusCupom }


                };
                instrucaosql = "INSERT INTO tbCupom (CodigoCupom, Descricao, DataInicio,ValorCupom,DataFim,StatusCupom) VALUES (@CodigoCupom, @Descricao, @DataInicio,@ValorCupom,@DataFim,@StatusCupom)";

                c.ExecutarComandoParametro(instrucaosql, listaComParametros);


            }
            catch (Exception ex)
            {

                throw ex;
            }




        }

        public void AlterarCupom() {
            
            try
            {

                SqlParameter[] listaComParametros = {
                     new SqlParameter("@ID",SqlDbType.Int) {Value = Id },
                    new SqlParameter("@CodigoCupom",SqlDbType.VarChar) {Value = CodigoCupom },
                   new SqlParameter("@Descricao ",SqlDbType.VarChar) {Value = Descricao },
                   new SqlParameter("@ValorCupom ",SqlDbType.Decimal) {Value = ValorCupom },
                   new SqlParameter("@DataInicio",SqlDbType.DateTime) {Value = DataInicio },
                   new SqlParameter("@DataFim",SqlDbType.DateTime) {Value = DataFim},
                   new SqlParameter("@StatusCupom",SqlDbType.Int) {Value = StatusCupom }


                };
                instrucaosql = "UPDATE tbCupom SET CodigoCupom=@CodigoCupom, Descricao=@Descricao, DataInicio=@DataInicio,ValorCupom=@ValorCupom,DataFim=@DataFim,StatusCupom=@StatusCupom WHERE ID = @ID";

                c.ExecutarComandoParametro(instrucaosql, listaComParametros);

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
                instrucaosql = "UPDATE tbCupom SET StatusCupom=1   WHERE ID=" + _Id;
                c.ExecutarComando(instrucaosql);
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
                instrucaosql = "UPDATE tbCupom SET StatusCupom=0   WHERE ID=" + _Id;
                c.ExecutarComando(instrucaosql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public SqlDataReader VerificarCupom() {

            try
            {
                instrucaosql = "SELECT * FROM tbCupom WHERE CodigoCupom = '"+CodigoCupom+"'";
                return c.RetornarDataReader(instrucaosql);
            }
            catch (Exception ex)
            {

                throw ex;
            }







        }

        public  void VerificarCupomCliente(int CodigoCliente)
        {
            try
            {
                

              
            }
            catch (Exception)
            {

                throw;
            }
       


        }
    }
}
