using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe
{
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public DataTable GetCategories()
        {
            DBManager db4 = new DBManager("Select * from Category");

            return db4.ExecuteSQL();
        }
    }
}

