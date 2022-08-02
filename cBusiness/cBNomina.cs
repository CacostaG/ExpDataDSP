using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cData;
using System.Data.SqlClient;
using System.Configuration;


namespace cBusiness
{
    public class CbNomina
    {

        CmbNomina nomina = new CmbNomina();

        public bool SelectNomina()
        {
            return nomina.ParametroNomina();
        }
      


    }
}
