using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Crud_En.NET_Sin_EntityFramework
{
    public class ConexionBD
    {
        private string conexBaDa = "Data Source=DESKTOP-3IMUAF6\\SQLEXPRESS;Initial Catalog=Actividad1_AccesoADatos;Integrated Security=True";

        public bool probarConexion()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(conexBaDa);
                conexion.Open();
            }
            catch
            {
                return false;
            }
            return true;  
        }


        public List<Datos> Get()
        {
            List<Datos> listaDeDatos = new List<Datos>();

            string querySelect = "Select * from EquiposFutbolTitulos";
            using (SqlConnection conexion = new SqlConnection(conexBaDa))
            {
                SqlCommand comando = new SqlCommand(querySelect, conexion);

                try
                {
                    conexion.Open();
                    SqlDataReader leerQuery = comando.ExecuteReader();
                    while (leerQuery.Read())
                    {
                        Datos dat = new Datos();
                        dat.idEquipo = leerQuery.GetInt32(0);
                        dat.NombreEquipo = leerQuery.GetString(1);
                        dat.Champions = leerQuery.GetInt32(2);
                        dat.Ligas = leerQuery.GetInt32(3);
                        dat.CopasDelRet = leerQuery.GetInt32(4);
                        dat.Supercopas = leerQuery.GetInt32(5);

                        listaDeDatos.Add(dat);
                    }
                    leerQuery.Close();
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en el query" + ex.Message);
                }

            }

            return listaDeDatos;
        }

        public void IngresarDatos(String NombreEquipo, int champions, int ligas, int copasDelRey, int Supercopas)
        {
            string query = "INSERT INTO EquiposFutbolTitulos(NombreEquipo, Champions, Ligas, CopasDelRey, Supercopas) VALUES (@Name,@Cham,@Lig,@CopRey,@Super)";

            using (SqlConnection conexion = new SqlConnection(conexBaDa))
            {
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Name", NombreEquipo);
                comando.Parameters.AddWithValue("@Cham", champions);
                comando.Parameters.AddWithValue("@Lig", ligas);
                comando.Parameters.AddWithValue("@CopRey", copasDelRey);
                comando.Parameters.AddWithValue("@Super", Supercopas);

                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();

                    conexion.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en el query" + ex.Message);
                }

            }
        }



        public void EditarDatos(String NombreEquipo, int champions, int ligas, int copasDelRey, int Supercopas, int idEquipo)
        {
            string query = "update EquiposFutbolTitulos set NombreEquipo=@Name, Champions=@Cham, Ligas=@Lig, CopasDelRey=@CopRey, Supercopas=@Super where idEquipo=@idEquipo";

            using (SqlConnection conexion = new SqlConnection(conexBaDa))
            {
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@idEquipo", idEquipo);
                comando.Parameters.AddWithValue("@Name", NombreEquipo);
                comando.Parameters.AddWithValue("@Cham", champions);
                comando.Parameters.AddWithValue("@Lig", ligas);
                comando.Parameters.AddWithValue("@CopRey", copasDelRey);
                comando.Parameters.AddWithValue("@Super", Supercopas);

                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();

                    conexion.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en el query" + ex.Message);
                }

            }
        }


        public Datos GetEdit(int idEquipo)
        {

            string querySelect = "Select * from EquiposFutbolTitulos where idEquipo=@idEquipo";
            
            using (SqlConnection conexion = new SqlConnection(conexBaDa))
            {
                SqlCommand comando = new SqlCommand(querySelect, conexion);
                comando.Parameters.AddWithValue("@idEquipo", idEquipo);

                try
                {
                    conexion.Open();
                    SqlDataReader leerQuery = comando.ExecuteReader();
                    leerQuery.Read();
                    
                    Datos dat = new Datos();
                    dat.idEquipo = leerQuery.GetInt32(0);
                    dat.NombreEquipo = leerQuery.GetString(1);
                    dat.Champions = leerQuery.GetInt32(2);
                    dat.Ligas = leerQuery.GetInt32(3);
                    dat.CopasDelRet = leerQuery.GetInt32(4);
                    dat.Supercopas = leerQuery.GetInt32(5);

                    leerQuery.Close();
                    conexion.Close();

                    return dat;
                    
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en el query" + ex.Message);
                }

            }

        }



        public void EliminarDatos (int idEquipo)
        {
            string query = "delete from EquiposFutbolTitulos where idEquipo=@idEquipo";

            using (SqlConnection conexion = new SqlConnection(conexBaDa))
            {
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@idEquipo", idEquipo);

                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();

                    conexion.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en el query" + ex.Message);
                }

            }
        }


    }


    public class Datos
    {
        public int idEquipo { get; set; }
        public string NombreEquipo { get; set; }
        public int Champions { get; set; }
        public int Ligas { get; set; }
        public int CopasDelRet { get; set; }
        public int Supercopas { get; set; }
    }



}
