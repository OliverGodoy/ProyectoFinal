using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using ProyectoFinal.Data.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Data
{
    internal class ConexionMySql
    {
        // Información de conexión a la base de datos
        private string connectionString = "Server=localhost;Database=db_champions;Uid=root;Pwd=Lg_(098765);";
        private MySqlConnection connection;

        public ConexionMySql()
        {
            connection = new MySqlConnection(connectionString);
        }

        //prueba de conexion
        public bool ProbarConexion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        // Método para leer todos los personajes
        public DataTable LeerFinales()
        {
            DataTable finales = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "select * from champions_finales;";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(finales);
                    }
                }
            }

            return finales;
        }


        //Ingresar datos por referencia
        public void Insertar(int anio, string finalista1, string finalista2, string campeon, string resultado, DateTime fecha, string cede, string goleador, int cantidad)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                try
                {
                    string query = "INSERT INTO champions_finales (año, finalista1, finalista2, campeon, resultado, fecha, cede, goleador, cantidad) VALUES (@año, @finalista1, @finalista2, @campeon, @resultado, @fecha, @cede, @goleador, @cantidad)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@año", anio);
                    cmd.Parameters.AddWithValue("@finalista1", finalista1);
                    cmd.Parameters.AddWithValue("@finalista2", finalista2);
                    cmd.Parameters.AddWithValue("@campeon", campeon);
                    cmd.Parameters.AddWithValue("@resultado", resultado);
                    cmd.Parameters.AddWithValue("@fecha", DateTime.Parse(fecha.ToString("yyyy-MM-dd")));
                    cmd.Parameters.AddWithValue("@cede", cede);
                    cmd.Parameters.AddWithValue("@goleador", goleador);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el registro: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }



        //Ingresar nuevo registro utilizando la clase Final
        public void Insertar1(Final fn)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string query = "INSERT INTO champions_finales (año, finalista1, finalista2, campeon, resultado, fecha, cede, goleador, cantidad) VALUES (@año, @finalista1, @finalista2, @campeon, @resultado, @fecha, @cede, @goleador, @cantidad)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@año", fn.anio);
                    cmd.Parameters.AddWithValue("@finalista1", fn.finalista1);
                    cmd.Parameters.AddWithValue("@finalista2", fn.finalista2);
                    cmd.Parameters.AddWithValue("@campeon", fn.campeon);
                    cmd.Parameters.AddWithValue("@resultado", fn.resultado);
                    cmd.Parameters.AddWithValue("@fecha", fn.fecha);
                    cmd.Parameters.AddWithValue("@cede", fn.cede);
                    cmd.Parameters.AddWithValue("@goleador", fn.goleador);
                    cmd.Parameters.AddWithValue("@cantidad", fn.cantidad);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el registro: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }


        //Metodo para buscar la final basandose por el año
        public DataTable BuscarPorAño(int anio)
        {
            DataTable final = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM champions_finales WHERE año = @año";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@año", anio);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(final);
                    }
                }
            }

            return final;
        }


        //Metodo para actualizar datos utilizando la clase Final
        public void ActualizarFinal(Final fn)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string query = "update champions_finales SET finalista1 = @finalista1, finalista2 = @finalista2, campeon = @campeon, resultado = @resultado, fecha= @fecha, cede= @cede, goleador = @goleador, cantidad= @cantidad WHERE año = @año";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@año", fn.anio);
                    cmd.Parameters.AddWithValue("@finalista1", fn.finalista1);
                    cmd.Parameters.AddWithValue("@finalista2", fn.finalista2);
                    cmd.Parameters.AddWithValue("@campeon", fn.campeon);
                    cmd.Parameters.AddWithValue("@resultado", fn.resultado);
                    cmd.Parameters.AddWithValue("@fecha", fn.fecha);
                    cmd.Parameters.AddWithValue("@cede", fn.cede);
                    cmd.Parameters.AddWithValue("@goleador", fn.goleador);
                    cmd.Parameters.AddWithValue("@cantidad", fn.cantidad);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el registro: " + ex.Message);
                }
                finally { connection.Close(); }
            }

        }

        //Metodo para eliminar registro basandose en el año
        public bool EliminarRegistro(int anio)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "delete from champions_finales where año = @año";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@año", anio);
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }



    }
}
