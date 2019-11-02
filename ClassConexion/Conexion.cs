using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ClassConexion
{
    public class Conexion
    {
        //SqlConnection MiCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Miconexion"].ConnectionString);

        SqlConnection MiCon = new SqlConnection("Data Source=198.27.89.45; user id=Emp2_User; password=Xantana123; Initial Catalog=DBEmpresa2");

        //AGREGO UNA CONEXION PARA LA DATATABLE ONLINE QUE TENDRA LA INFORMACION COMPRATIDA DE TODAS LAS SUCURSALES
        SqlConnection MiCon2 = new SqlConnection(ConfigurationManager.ConnectionStrings["MiconexionOnline"].ConnectionString);
        SqlCommand MiComando = null;
        SqlDataAdapter adapter = new SqlDataAdapter();

        OleDbConnection MiConAccess = new OleDbConnection("Provider=Microsoft.ACE.OLDB.12.0; Data Source= C:\\IMPREDAVID\\DBAfip.mdb");
        OleDbCommand cmd = new OleDbCommand();


        //string CS = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;

        void AbrirConexion()
        {
            if (MiCon.State != ConnectionState.Open) try
                {
                    MiCon.Open();
                }
                catch (Exception)
                {

                    throw new Exception("Errror : no se pudo abrir la base de datos");
                }

        }

        public void CreateQuery(string Query)
        {
           

            MiComando = new SqlCommand(Query, MiCon);
            MiComando.CommandType = CommandType.Text;

        }

        

        public void CerrarConexion()
        {
            MiCon.Close();
        }

        protected void CrearComando(string ProcedureName)
        {
            MiComando = new SqlCommand(ProcedureName, MiCon);
            MiComando.CommandType = CommandType.StoredProcedure;
            
        }

        public void ActLista(string ProcedureName, DataTable dtProductos, string NombDT)
        {
            MiComando = new SqlCommand(ProcedureName, MiCon);
            MiComando.CommandType = CommandType.StoredProcedure;
            SqlParameter dt = MiComando.Parameters.AddWithValue(NombDT, dtProductos);
            dt.SqlDbType = SqlDbType.Structured;

            AbrirConexion();
            try
            {
                MiComando.ExecuteNonQuery();
                //int id = int.Parse(MiComando.ExecuteScalar().ToString());
                //return id;
                int id = 0;
                //return id;
            }
            catch (Exception err)
            {

                
            }
            finally { MiCon.Close(); }


            
        }


        //GENERO LOS METODOS PARA ABRIR LA CONEXION EN LA BASE DE DATOS ONLINE

        public bool TestConectionOnline()
        {
            try
            {
                MiCon2.Open();
                
                MiCon2.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

            
            
        }


        void AbrirConexion2()
        {
            if (MiCon2.State != ConnectionState.Open) try
                {
                    MiCon2.Open();
                }
                catch (Exception)
                {

                    throw new Exception("Errror : no se pudo abrir la base de datos");
                }

        }

       

        public void CerrarConexion2()
        {
            MiCon2.Close();
        }


        protected void CrearComandoOnline(string ProcedureName)
        {
            MiComando = new SqlCommand(ProcedureName, MiCon2);
            MiComando.CommandType = CommandType.StoredProcedure;
        }

        protected void ParametersAddVarchar(string Name, int Length, string Value)
        {
            MiComando.Parameters.Add("@" + Name, SqlDbType.VarChar, Length).Value = Value;

        }
        protected void ParametersAddInt(string Name, int Value)
        {
            MiComando.Parameters.Add("@" + Name, SqlDbType.Int).Value = Value;

        }

        protected void ParametersAddLong(string Name, Int64 Value)
        {
            MiComando.Parameters.Add("@" + Name, SqlDbType.BigInt).Value = Value;
        }
        protected void ParametersAddText(string Name, string Value)
        {
            MiComando.Parameters.Add("@" + Name, SqlDbType.Text).Value = Value;

        }
        protected void ParametersAddfloat(string Name, double Value)
        {
            MiComando.Parameters.Add("@" + Name, SqlDbType.Float).Value = Value;

        }
        protected void ParametersAddDateTime(string Name, DateTime Value)
        {
            MiComando.Parameters.Add("@" + Name, SqlDbType.SmallDateTime).Value = Value.ToString();
        }
        protected void ParametersAddDateTimeOffSet(string Name, DateTimeOffset Value)
        {
            MiComando.Parameters.Add("@" + Name, SqlDbType.DateTimeOffset).Value = Value.ToString();
        }
        protected void ParametersAddDateTimeNull(string Name, DateTime? Value)
        {
            MiComando.Parameters.Add("@" + Name, SqlDbType.SmallDateTime).Value = Value;
        }

        protected void ParametersAddBit(string Name, bool Value)
        {
            MiComando.Parameters.Add("@" + Name, SqlDbType.Bit).Value = Value;
        }
        protected DataTable List(string Errormsg)
        {
            AbrirConexion();
            try
            {
                DataTable DT = new DataTable();
                DT.Load(MiComando.ExecuteReader());
                return DT;

            }
            catch (Exception)
            {

                throw new Exception(Errormsg);
            }
            finally { MiCon.Close(); }
        }
        protected DataRow Find(string Errormsg)
        {
            AbrirConexion();
            try
            {
                DataTable DT = new DataTable();
                DT.Load(MiComando.ExecuteReader());
                return DT.Rows[0];

            }
            catch (Exception)
            {

                throw new Exception(Errormsg);
            }
            finally { MiCon.Close(); }
        }
        protected int Insert(string Errormsg)
        {
            AbrirConexion();
            try
            {
                //MiComando.ExecuteNonQuery();
                int id = int.Parse(MiComando.ExecuteScalar().ToString());
               //return id;
                int pp = 0;
                return id;
            }
            catch (Exception)
            {

                throw new Exception(Errormsg);
            }
            finally { MiCon.Close(); }

        }

        protected int InsertCId(string Errormsg)
        {
            AbrirConexion();
            try
            {
                //MiComando.ExecuteNonQuery();
                int id = int.Parse(MiComando.ExecuteScalar().ToString());
                return id;
                //int pp = 0;
                //return id;
            }
            catch (Exception)
            {

                throw new Exception(Errormsg);
            }
            finally { MiCon.Close(); }

        }
        protected void Update(string Errormsg)
        {
            AbrirConexion();
            try
            {

                MiComando.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw new Exception(Errormsg);
            }
            finally { MiCon.Close(); }

        }

        //METODOS PARA LA BASE ONLINE
        protected DataTable ListOnline(string Errormsg)
        {
            AbrirConexion2();
            try
            {
                DataTable DT = new DataTable();
                DT.Load(MiComando.ExecuteReader());
                return DT;

            }
            catch (Exception)
            {

                throw new Exception(Errormsg);
            }
            finally { MiCon2.Close(); }
        }
        protected DataRow FindOnline(string Errormsg)
        {
            AbrirConexion2();
            try
            {
                DataTable DT = new DataTable();
                DT.Load(MiComando.ExecuteReader());
                return DT.Rows[0];

            }
            catch (Exception)
            {

                throw new Exception(Errormsg);
            }
            finally { MiCon2.Close(); }
        }
        protected int InsertOnline(string Errormsg)
        {
            AbrirConexion2();
            try
            {
                MiComando.ExecuteNonQuery();
               
                //int id = int.Parse(MiComando.ExecuteScalar().ToString());
                //return id;
                int id = 0;
                return id;
            }
            catch (Exception)
            {

                throw new Exception(Errormsg);
            }
            finally { MiCon2.Close(); }

        }
        protected void UpdateOnline(string Errormsg)
        {
            AbrirConexion2();
            try
            {

                MiComando.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw new Exception(Errormsg);
            }
            finally { MiCon2.Close(); }

        }



        void AbrirConexionAccess()
        {
            if (MiConAccess.State != ConnectionState.Open) try
                {
                    MiConAccess.Open();
                }
                catch (Exception)
                {

                    throw new Exception("Errror : no se pudo abrir la base de datos de Access");
                }

        }

        void CerrarConexionAcces()
        {
            MiConAccess.Close();
        }

        protected int InsertAccess(string Errormsg)
        {
            AbrirConexionAccess();
            try
            {
                MiComando.ExecuteNonQuery();

                //int id = int.Parse(MiComando.ExecuteScalar().ToString());
                //return id;
                int id = 0;
                return id;
            }
            catch (Exception)
            {

                throw new Exception(Errormsg);
            }
            finally { MiCon2.Close(); }

        }

    }
}
