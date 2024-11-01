using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class CD_CLIENTE
    {
        String conectadobb = ConexionBD.cadena;
        public List<CLIENTE> Listar()
        {
            List<CLIENTE> lista = new List<CLIENTE>();
            using (MySqlConnection ocadena = new MySqlConnection(conectadobb))
            {
                try
                {

                    /*
                     SELECT e.est_descricion,c.Cli_Nombre,c.Cli_Telefono,c.Cli_Telefono_Emer,c.Cli_Correo,c.Cli_Domicilio,c.Cli_Colonia,
                            c.Est_id,c.Fecha_Creacion,c.Fecha_termina
                            FROM Estatus e
                            INNER JOIN cliente c ON c.Est_id =  e.Est_id;
                     */
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT e.est_descricion,c.Cli_Id,c.Cli_Nombre,c.Cli_Edad,c.Cli_Telefono,c.Cli_Telefono_Emer,c.Cli_Correo,c.Cli_Domicilio,c.Cli_Colonia,");
                    query.AppendLine(" c.Est_id,c.Fecha_Creacion,c.Fecha_termina FROM cliente c  INNER JOIN Estatus e  ON c.Est_id =  e.Est_id;");


                    MySqlCommand cmd = new MySqlCommand(query.ToString(), ocadena);
                    cmd.CommandType = CommandType.Text;

                    ocadena.Open();

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new CLIENTE()
                            {
                                Cli_Id = Convert.ToInt32(dr["Cli_Id"]),
                                Cli_Nombre = dr["Cli_Nombre"].ToString(),
                                Cli_Edad = Convert.ToInt32(dr["Cli_Edad"]),
                                Cli_Telefono = dr["Cli_Telefono"].ToString(),
                                Cli_Telefono_Emer = dr["Cli_Telefono_Emer"].ToString(),
                                Cli_Correo = dr["Cli_Correo"].ToString(),
                                Cli_Domicilio = dr["Cli_Domicilio"].ToString(),
                                Cli_Colonia = dr["Cli_Colonia"].ToString(),
                                oestatus = new ESTATUS()
                                {
                                    est_id = Convert.ToInt32(dr["est_id"]),
                                    Est_descricion = dr["Est_descricion"].ToString()
                                },
                                Fecha_Creacion = dr["Fecha_Creacion"].ToString(),
                                Fecha_termina = dr["Fecha_termina"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar los clientes: " + ex.Message + " | StackTrace: " + ex.StackTrace, ex);
                }
            }
            return lista;
        }

        public void ingresar_cliente(string nombre, int edad, string telefono, string telefono911, string correo, string domicilio, string colonia, int estadoId)
        {
            string insertQuery = "INSERT INTO Cliente (Cli_Nombre, Cli_Edad, Cli_Telefono, Cli_Telefono_Emer, Cli_Correo, Cli_Domicilio, Cli_Colonia, Est_id, Fecha_Creacion, Fecha_termina) " +
                                 "VALUES (@Nombre, @Edad, @Telefono, @Telefono911, @Correo, @Domicilio, @Colonia, @EstadoId, NOW(), DATE_ADD(NOW(), INTERVAL 1 MONTH))";

            using (MySqlConnection connection = new MySqlConnection(conectadobb))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Edad", edad);
                        command.Parameters.AddWithValue("@Telefono", telefono);
                        command.Parameters.AddWithValue("@Telefono911", telefono911);
                        command.Parameters.AddWithValue("@Correo", correo);
                        command.Parameters.AddWithValue("@Domicilio", domicilio);
                        command.Parameters.AddWithValue("@Colonia", colonia);
                        command.Parameters.AddWithValue("@EstadoId", estadoId);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al ingresar el cliente: " + ex.Message + " | StackTrace: " + ex.StackTrace, ex);
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }



    }
}
