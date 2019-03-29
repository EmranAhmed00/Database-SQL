namespace Recipe
{
    partial class textCategory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listRecipe = new System.Windows.Forms.ListBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteRecipe = new System.Windows.Forms.Button();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxIngredients = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.AddTitle = new System.Windows.Forms.Label();
            this.AddIngredients = new System.Windows.Forms.Label();
            this.AddDescription = new System.Windows.Forms.Label();
            this.labelRecipeDescription = new System.Windows.Forms.Label();
            this.labelRecipelist = new System.Windows.Forms.Label();
            this.ComboCategory = new System.Windows.Forms.ComboBox();
            this.LCategory = new System.Windows.Forms.Label();
            this.searchTitle = new System.Windows.Forms.Button();
            this.textIng = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(8, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(38, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listRecipe
            // 
            this.listRecipe.FormattingEnabled = true;
            this.listRecipe.ItemHeight = 20;
            this.listRecipe.Location = new System.Drawing.Point(2, 176);
            this.listRecipe.Name = "listRecipe";
            this.listRecipe.Size = new System.Drawing.Size(325, 204);
            this.listRecipe.TabIndex = 5;
            this.listRecipe.SelectedIndexChanged += new System.EventHandler(this.listRecipe_SelectedIndexChanged);
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(371, 108);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(221, 94);
            this.textDescription.TabIndex = 6;
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.BackColor = System.Drawing.Color.Aquamarine;
            this.btnAddRecipe.ForeColor = System.Drawing.Color.Blue;
            this.btnAddRecipe.Location = new System.Drawing.Point(623, 364);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(147, 41);
            this.btnAddRecipe.TabIndex = 7;
            this.btnAddRecipe.Text = "New Recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = false;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FloralWhite;
            this.btnUpdate.ForeColor = System.Drawing.Color.Blue;
            this.btnUpdate.Location = new System.Drawing.Point(817, 364);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(158, 41);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "UpdateRecipe";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteRecipe
            // 
            this.btnDeleteRecipe.BackColor = System.Drawing.Color.White;
            this.btnDeleteRecipe.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteRecipe.Location = new System.Drawing.Point(992, 364);
            this.btnDeleteRecipe.Name = "btnDeleteRecipe";
            this.btnDeleteRecipe.Size = new System.Drawing.Size(160, 41);
            this.btnDeleteRecipe.TabIndex = 9;
            this.btnDeleteRecipe.Text = "DeleteRecipe";
            this.btnDeleteRecipe.UseVisualStyleBackColor = false;
            this.btnDeleteRecipe.Click += new System.EventHandler(this.btnDeleteRecipe_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(917, 105);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(136, 26);
            this.textBoxTitle.TabIndex = 10;
            // 
            // textBoxIngredients
            // 
            this.textBoxIngredients.Location = new System.Drawing.Point(917, 166);
            this.textBoxIngredients.Multiline = true;
            this.textBoxIngredients.Name = "textBoxIngredients";
            this.textBoxIngredients.Size = new System.Drawing.Size(136, 52);
            this.textBoxIngredients.TabIndex = 12;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(917, 233);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(147, 81);
            this.textBoxDescription.TabIndex = 13;
            // 
            // AddTitle
            // 
            this.AddTitle.AutoSize = true;
            this.AddTitle.Location = new System.Drawing.Point(834, 111);
            this.AddTitle.Name = "AddTitle";
            this.AddTitle.Size = new System.Drawing.Size(38, 20);
            this.AddTitle.TabIndex = 15;
            this.AddTitle.Text = "Title";
            // 
            // AddIngredients
            // 
            this.AddIngredients.AutoSize = true;
            this.AddIngredients.Location = new System.Drawing.Point(813, 176);
            this.AddIngredients.Name = "AddIngredients";
            this.AddIngredients.Size = new System.Drawing.Size(89, 20);
            this.AddIngredients.TabIndex = 16;
            this.AddIngredients.Text = "Ingredients";
            // 
            // AddDescription
            // 
            this.AddDescription.AutoSize = true;
            this.AddDescription.Location = new System.Drawing.Point(813, 245);
            this.AddDescription.Name = "AddDescription";
            this.AddDescription.Size = new System.Drawing.Size(89, 20);
            this.AddDescription.TabIndex = 17;
            this.AddDescription.Text = "Deccription";
            // 
            // labelRecipeDescription
            // 
            this.labelRecipeDescription.AutoSize = true;
            this.labelRecipeDescription.Location = new System.Drawing.Point(417, 75);
            this.labelRecipeDescription.Name = "labelRecipeDescription";
            this.labelRecipeDescription.Size = new System.Drawing.Size(89, 20);
            this.labelRecipeDescription.TabIndex = 18;
            this.labelRecipeDescription.Text = "Description";
            // 
            // labelRecipelist
            // 
            this.labelRecipelist.AutoSize = true;
            this.labelRecipelist.Location = new System.Drawing.Point(-2, 144);
            this.labelRecipelist.Name = "labelRecipelist";
            this.labelRecipelist.Size = new System.Drawing.Size(78, 20);
            this.labelRecipelist.TabIndex = 19;
            this.labelRecipelist.Text = "Recipelist";
            // 
            // ComboCategory
            // 
            this.ComboCategory.FormattingEnabled = true;
            this.ComboCategory.Location = new System.Drawing.Point(77, 54);
            this.ComboCategory.Name = "ComboCategory";
            this.ComboCategory.Size = new System.Drawing.Size(221, 28);
            this.ComboCategory.TabIndex = 20;
            this.ComboCategory.SelectedIndexChanged += new System.EventHandler(this.comboCategory_SelectedIndexChanged);
            // 
            // LCategory
            // 
            this.LCategory.AutoSize = true;
            this.LCategory.Location = new System.Drawing.Point(-2, 54);
            this.LCategory.Name = "LCategory";
            this.LCategory.Size = new System.Drawing.Size(73, 20);
            this.LCategory.TabIndex = 21;
            this.LCategory.Text = "Category";
            // 
            // searchTitle
            // 
            this.searchTitle.Location = new System.Drawing.Point(313, 12);
            this.searchTitle.Name = "searchTitle";
            this.searchTitle.Size = new System.Drawing.Size(193, 49);
            this.searchTitle.TabIndex = 22;
            this.searchTitle.Text = "Search Title or Category";
            this.searchTitle.UseVisualStyleBackColor = true;
            this.searchTitle.Click += new System.EventHandler(this.searchTitle_Click);
            // 
            // textIng
            // 
            this.textIng.Location = new System.Drawing.Point(371, 245);
            this.textIng.Multiline = true;
            this.textIng.Name = "textIng";
            this.textIng.Size = new System.Drawing.Size(221, 69);
            this.textIng.TabIndex = 23;
            this.textIng.TextChanged += new System.EventHandler(this.textIngredients_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ingredients";
            // 
            // textCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1161, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textIng);
            this.Controls.Add(this.searchTitle);
            this.Controls.Add(this.LCategory);
            this.Controls.Add(this.ComboCategory);
            this.Controls.Add(this.labelRecipelist);
            this.Controls.Add(this.labelRecipeDescription);
            this.Controls.Add(this.AddDescription);
            this.Controls.Add(this.AddIngredients);
            this.Controls.Add(this.AddTitle);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxIngredients);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.btnDeleteRecipe);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.listRecipe);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelTitle);
            this.Name = "textCategory";
            this.Text = " RecipeBook";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listRecipe;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleteRecipe;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxIngredients;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label AddTitle;
        private System.Windows.Forms.Label AddIngredients;
        private System.Windows.Forms.Label AddDescription;
        private System.Windows.Forms.Label labelRecipeDescription;
        private System.Windows.Forms.Label labelRecipelist;
        private System.Windows.Forms.ComboBox ComboCategory;
        private System.Windows.Forms.Label LCategory;
        private System.Windows.Forms.Button searchTitle;
        private System.Windows.Forms.TextBox textIng;
        private System.Windows.Forms.Label label1;
    }
}

