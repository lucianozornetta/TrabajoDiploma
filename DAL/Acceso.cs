﻿using System;
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
   
        
        string cadena = @"Data Source=.\SQLEXPRESS01;Initial Catalog=BDPROYECTOCAMPO;Integrated Security=True;Encrypt=False";
        private SqlConnection ocon = new SqlConnection(@"Data Source=.\SQLEXPRESS01;Initial Catalog=BDPROYECTOCAMPO;Integrated Security=True;Encrypt=False");
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

        public bool Transaccion(List<string> consultas, List<Hashtable> HdatosList)
        {
            if (ocon.State == ConnectionState.Closed)
            {
                ocon.ConnectionString = cadena;
                ocon.Open();
            }

            SqlTransaction trans = null;

            try
            {
                trans = ocon.BeginTransaction();

                for (int i = 0; i < consultas.Count; i++)
                {
                    string consulta = consultas[i];
                    Hashtable Hdatos = HdatosList[i];

                    SqlCommand ocomand = new SqlCommand(consulta, ocon, trans);
                    ocomand.CommandType = CommandType.StoredProcedure;

                    if (Hdatos != null)
                    {
                        foreach (string dato in Hdatos.Keys)
                        {
                            ocomand.Parameters.AddWithValue(dato, Hdatos[dato]);
                        }
                    }

                    int respuesta = ocomand.ExecuteNonQuery();


                }

                trans.Commit(); 
                return true;
            }
            catch (SqlException ex)
            {
                if (trans != null)
                    trans.Rollback(); 

                return false;
                throw ex;
            }
            catch (Exception ex)
            {
                if (trans != null)
                    trans.Rollback();

                return false;
                throw ex;
            }
            finally
            {
                ocon.Close();
            }
        }

        public bool CrearBackup(string ruta)
        {
            string query = $"BACKUP DATABASE [BDPROYECTOCAMPO] TO DISK = @Ruta";
            try
            {
                using (SqlConnection connection = new SqlConnection(cadena))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Ruta", ruta);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public bool RestaurarDesdeBackup(string ruta)
        {
            string bd = "BDPROYECTOCAMPO";
            string restoreQuery = $@"
            USE master;
             ALTER DATABASE [{bd}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
            RESTORE DATABASE [{bd}] FROM DISK = @Ruta WITH REPLACE;
            ALTER DATABASE [{bd}] SET MULTI_USER;
            ";
            string connectionstring = @"Data Source=.\SQLEXPRESS01;Initial Catalog= master;Integrated Security=True;Encrypt=False";
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(restoreQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Ruta", ruta);
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
    }

}


