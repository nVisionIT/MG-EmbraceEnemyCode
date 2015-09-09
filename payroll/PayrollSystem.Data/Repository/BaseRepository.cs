using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PayrollSystem.Data.Repository
{
    public class BaseRepository
    {
        public static string GenerateConnectionString()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            return connectionString;
        }

    }
}
