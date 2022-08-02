using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using cCommon.Temp;


namespace cData
{
    public class UserDao : conData
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    SqlCommand command = new SqlCommand("spLogin", connection);
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            /*UserCache.idDatosUsuario = reader.GetInt32(0);*/
                            UserCache.NombrePersonal = reader.GetString(0);
                            /*UserCache.ApPaterno = reader.GetString(2);
                            UserCache.RFC = reader.GetString(3);*/
                            UserCache.Usuario = reader.GetString(1);
                            UserCache.TipoUsuario = reader.GetString(2);
                            /*UserCache.Pass = reader.GetString(6);*/
                        }
                        return true;
                    }
                    else
                        return false;
                }


            }
        }
    }
}


