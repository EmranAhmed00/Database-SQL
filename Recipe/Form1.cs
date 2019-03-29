using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipe
{
    public partial class textCategory : Form
    {
        
        public textCategory()
        {
            InitializeComponent();
        }

        // Combo Box Category
        private void Form1_Load(object sender, EventArgs e)
        {
            Recipe r = new Recipe();
            ComboCategory.DisplayMember = "CategoryName";
            ComboCategory.ValueMember = "CategoryId";
            ComboCategory.DataSource = r.LoadCategories();
        }

        //  Category :

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Recipe r = new Recipe();
            string Title = textBox1.Text;
            string Category = ComboCategory.Text;
            r.CategoryObject.CategoryName = Category;
            DataTable tbl = r.Search(Title);
            listRecipe.DisplayMember = "Title";
            listRecipe.ValueMember = "RecipeId";
            listRecipe.DataSource = tbl;

        }

        // Description and Ingredients:
        private void listRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            Recipe recipe = new Recipe();
           
            int id = (int)listRecipe.SelectedValue;
            recipe.GetRecipe(id);

            textDescription.Text = recipe.Description;
            textIng.Text = recipe.Ingredients;
            
        }

        // Add new Recipe:

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            Recipe recipe = new Recipe();

            recipe.Title = textBoxTitle.Text;
            recipe.Ingredients = textBoxIngredients.Text;
            recipe.Description = textBoxDescription.Text;
            recipe.CategoryObject.CategoryId = (int)ComboCategory.SelectedValue;
            recipe.AddRecipe(recipe);

            MessageBox.Show("Recipe has been Added");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        //Update Recipe:
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Recipe recipe = new Recipe();
            recipe.RecipeId = (int)listRecipe.SelectedValue;

            recipe.Title = textBoxTitle.Text;
            recipe.Ingredients = textBoxIngredients.Text;
            recipe.Description = textBoxDescription.Text;
            recipe.CategoryObject.CategoryId = (int)ComboCategory.SelectedValue;
            recipe.UpdateRecipe(recipe);

            MessageBox.Show(" Updated!!!");
        }
  
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        // Delete Recipe:

        private void btnDeleteRecipe_Click(object sender, EventArgs e)
        {
            Recipe r = new Recipe();
            string id = listRecipe.SelectedValue.ToString();
            r.DeleteRecipe(id);
            MessageBox.Show("Deleted");
        }

        //Search by Title or Category
        private void searchTitle_Click(object sender, EventArgs e)
        {
            Recipe r = new Recipe();
            string Title = textBox1.Text;
            string Category = ComboCategory.Text;
            r.CategoryObject.CategoryName = Category;
            listRecipe.DisplayMember = "Title";
            listRecipe.ValueMember = "RecipeId";
            listRecipe.DataSource = r.SearchTitleOrCategory(Title);
        }

        private void textIngredients_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
