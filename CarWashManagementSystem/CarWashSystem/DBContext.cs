using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashSystemClassLibrary
{
    public class DBContext
    {
        private static DBContext instance;
        public SqlConnection dbContext;
        private string connectionString = "Data Source=TALSWDL009;Initial Catalog=TestDB;Integrated Security=True";

        // Private constructor to prevent external instantiation
        private DBContext()
        {
            dbContext = new SqlConnection(connectionString);
        }

        // Public static property to get the instance of the singleton
        public static DBContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DBContext();
                }
                return instance;
            }
        }


    }
}
