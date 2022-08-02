using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;


namespace cData
{
    public  abstract class conData
    {

        private readonly string conexionBD;

        public conData()
        {
          
                conexionBD = "Data Source=DESKTOP-1H6H9IH\\SQLEXPRESS;Initial Catalog=SistematizacionLocal;Integrated Security=True";
           
            
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(conexionBD);
        }




    }
}
