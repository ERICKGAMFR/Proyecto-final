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
    public class CD_PERMISO
    {
        public List<PERMISO> Listar(int id_usuario)
        {
            List<PERMISO> lista = new List<PERMISO>();

            using (MySqlConnection oconexion = new MySqlConnection(ConexionBD.cadena))
            {
                try
                {
                    // Mostrar el valor de id_usuario antes de usarlo en la consulta
                    Console.WriteLine($"ID de usuario recibido: {id_usuario}");

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.id_rol, p.NombreMenu from permiso p");
                    query.AppendLine("inner join ROL r on r.id_rol = p.id_rol");
                    query.AppendLine("inner join USUARIO u on u.id_rol = r.id_rol");
                    query.AppendLine("Where u.id_usuario =@id_usuario");

                    MySqlCommand cmd = new MySqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new PERMISO()
                            {
                                oROL = new ROL() { Id_Rol = Convert.ToInt32(dr["Id_rol"]) },
                                Nombremenu = dr["Nombremenu"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar los Permisos: " + ex.Message + " | StackTrace: " + ex.StackTrace, ex);
                }
            }
            return lista;
        }
    }
}
