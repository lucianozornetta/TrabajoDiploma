using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BE;

namespace DAL
{
    public class Acceso
    {
        
        string cadena = @"Data Source=.;Initial Catalog=BDPROYECTOCAMPO;Integrated Security=True";
        private SqlConnection ocon = new SqlConnection(@"Data Source=.;Initial Catalog=BDPROYECTOCAMPO;Integrated Security=True");
        private SqlCommand ocomand;
        private SqlTransaction trans;

        public DataTable Leer(string consulta, Hashtable hashdatos)
        {
            DataTable grilla = new DataTable();
            SqlDataAdapter adapter;
        
            ocomand = new SqlCommand(consulta, ocon);
            ocomand.CommandType = CommandType.StoredProcedure;

            try
            {
                adapter = new SqlDataAdapter(ocomand);

                if ((hashdatos != null))
                {
                
                    foreach (string dato in hashdatos.Keys)
                    {
                        
                        ocomand.Parameters.AddWithValue(dato, hashdatos[dato]);
                    }
                }
            }

            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
            adapter.Fill(grilla);
            return grilla;
        }


        public bool LeerScalar(string consulta, Hashtable Hdatos)
        {
            ocon.Open();

            ocomand = new SqlCommand(consulta, ocon);

            try
            {
                if (Hdatos != null)
                {
                    foreach (string dato in Hdatos.Keys)
                    {
                        ocomand.Parameters.AddWithValue(dato, Hdatos[dato]);
                    }
                }
                ocomand.CommandType = CommandType.StoredProcedure;
                int Respuesta = Convert.ToInt32(ocomand.ExecuteScalar());
                ocon.Close();
                if (Respuesta > 0)
                { return true; }
                else
                { return false; }
            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }


        public bool Escribir(string consulta, Hashtable Hdatos)
        {
            if (ocon.State == ConnectionState.Closed)
            {
                ocon.ConnectionString = cadena;
                ocon.Open();
            }
            try
            {
                trans = ocon.BeginTransaction();
                ocomand = new SqlCommand(consulta, ocon, trans);
                ocomand.CommandType = CommandType.StoredProcedure;

                if ((Hdatos != null))
                {
                     
                    foreach (string dato in Hdatos.Keys)
                    {
                        
                        ocomand.Parameters.AddWithValue(dato, Hdatos[dato]);
                    }
                }
                int respuesta = ocomand.ExecuteNonQuery();
                trans.Commit();
                return true;
            }
            catch (SqlException ex)
            {
                trans.Rollback();

                return false;
                throw ex;
            }
            catch (Exception ex)
            {
                trans.Rollback();
                return false;
                throw ex;
            }
            finally
            { ocon.Close(); }
        }      

        
        
    }

}


