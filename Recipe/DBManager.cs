using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe
{
    class DBManager
    {

        private string ConnectionString { get; set; }
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        private string SQL;

        public DBManager(string sql)
        {
          
            ConnectionString = "Data Source=LAPTOP-DB6PV3D8;Initial Catalog=RecipeBook;Integrated Security=True;";

            SQL = sql;
        }

        public DataTable ExecuteSQL()
        {
            DataTable tbl = new DataTable();

            using (conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                cmd = new SqlCommand(SQL, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(tbl);
            }

            return tbl;
        }
        
        public void ExecuteSQLNoReturn()
        {
            using (conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                cmd = new SqlCommand(SQL, conn);
                cmd.ExecuteNonQuery();
            }
        }

    }
}


    

