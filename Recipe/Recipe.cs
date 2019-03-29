using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe
{
    class Recipe

    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public Category CategoryObject { get; set; }
        public int RecipeId { get; set; }


        public Recipe()
        {
            CategoryObject = new Category();  
        }

        public DataTable Search(string title)
        {
            string Title = title;
            
            DBManager DB = new DBManager("select * From Recipe " +
           "INNER JOIN Category ON Recipe.CategoryId = Category.CategoryId " +
           $"WHERE Category.CategoryName = '{CategoryObject.CategoryName}'");

            DataTable tbl = DB.ExecuteSQL();
            return tbl;
        }
        // description, Ingredients :

        public Recipe GetRecipe (int id)
        {

            RecipeId = id;

            DBManager db = new DBManager(" Select * From Recipe " +
           $"Where RecipeId = {RecipeId}");
            DataTable tb2 = db.ExecuteSQL();
           
            Description = (from DataRow dr in tb2.Rows
                             select dr["Description"]).FirstOrDefault().ToString();
            Ingredients = (from DataRow dr in tb2.Rows
                             select dr["Ingredients"]).FirstOrDefault().ToString();
            return this;
        }


        public void AddRecipe(Recipe recipe)
        {

           DBManager db = new DBManager(
             
          "Insert into Recipe (Title,Ingredients,Description,CategoryId) " +
           $"Values('{recipe.Title}', '{recipe.Ingredients}', '{recipe.Description}', '{(recipe.CategoryObject.CategoryId)}')") ;
               db.ExecuteSQLNoReturn();
        }
        
        public void UpdateRecipe(Recipe recipe)
        {
            
            DBManager db3 = new DBManager($"UPDATE Recipe SET Title = '{recipe.Title}', " +

            $"Ingredients= '{recipe.Ingredients}', Description= '{recipe.Description}', CategoryId = '{(recipe.CategoryObject.CategoryId)}'" +
            $"Where recipeid = {(recipe.RecipeId)}");
            
            db3.ExecuteSQLNoReturn();
        }
        public void DeleteRecipe(string id )
        {
            DBManager db3 = new DBManager("DELETE FROM  Recipe " +

            $"Where RecipeId= {int.Parse(id)} ");
            db3.ExecuteSQLNoReturn();
        }
        public DataTable SearchTitleOrCategory(string Title)
        {
            DBManager DB;
            if (CategoryObject.CategoryName == "")
            {
                DB = new DBManager("select * From Recipe " +
          "INNER JOIN Category ON Recipe.CategoryId = Category.CategoryId " +
          $"WHERE (Title LIKE '{Title}%') ");
            }

            else
            {
                DB = new DBManager("select * From Recipe " +
            "INNER JOIN Category ON Recipe.CategoryId = Category.CategoryId " +
            $"WHERE (Title LIKE '{Title}%') AND Category.CategoryName = '{CategoryObject.CategoryName}' ");
            }

            return DB.ExecuteSQL();

        }

        public DataTable LoadCategories()
        {
            return CategoryObject.GetCategories();
        }
    }
}

