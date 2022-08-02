using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace cData
{
    public class CmbNomina : conData
    {
       
        public bool ParametroNomina()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using ( var cmdNomina = new SqlCommand())
                {
                    cmdNomina.Connection = connection;
                    cmdNomina.CommandText = ("spExDataSelNomina");
                    cmdNomina.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdNomina);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                }
                return true;
            }
        }
     


    }
}
