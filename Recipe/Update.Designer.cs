namespace Recipe
{
    partial class Update
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
            this.AddDescription = new System.Windows.Forms.Label();
            this.AddIngredients = new System.Windows.Forms.Label();
            this.AddTitle = new System.Windows.Forms.Label();
            this.AddCategory = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxIngredients = new System.Windows.Forms.TextBox();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddDescription
            // 
            this.AddDescription.AutoSize = true;
            this.AddDescription.Location = new System.Drawing.Point(161, 269);
            this.AddDescription.Name = "AddDescription";
            this.AddDescription.Size = new System.Drawing.Size(89, 20);
            this.AddDescription.TabIndex = 25;
            this.AddDescription.Text = "Deccription";
            // 
            // AddIngredients
            // 
            this.AddIngredients.AutoSize = true;
            this.AddIngredients.Location = new System.Drawing.Point(161, 215);
            this.AddIngredients.Name = "AddIngredients";
            this.AddIngredients.Size = new System.Drawing.Size(89, 20);
            this.AddIngredients.TabIndex = 24;
            this.AddIngredients.Text = "Ingredients";
            // 
            // AddTitle
            // 
            this.AddTitle.AutoSize = true;
            this.AddTitle.Location = new System.Drawing.Point(188, 98);
            this.AddTitle.Name = "AddTitle";
            this.AddTitle.Size = new System.Drawing.Size(38, 20);
            this.AddTitle.TabIndex = 23;
            this.AddTitle.Text = "Title";
            // 
            // AddCategory
            // 
            this.AddCategory.AutoSize = true;
            this.AddCategory.Location = new System.Drawing.Point(177, 157);
            this.AddCategory.Name = "AddCategory";
            this.AddCategory.Size = new System.Drawing.Size(73, 20);
            this.AddCategory.TabIndex = 22;
            this.AddCategory.Text = "Category";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(265, 266);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(184, 26);
            this.textBoxDescription.TabIndex = 21;
            // 
            // textBoxIngredients
            // 
            this.textBoxIngredients.Location = new System.Drawing.Point(265, 209);
            this.textBoxIngredients.Name = "textBoxIngredients";
            this.textBoxIngredients.Size = new System.Drawing.Size(184, 26);
            this.textBoxIngredients.TabIndex = 20;
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(265, 154);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(184, 26);
            this.textBoxCategory.TabIndex = 19;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(265, 98);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(184, 26);
            this.textBoxTitle.TabIndex = 18;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 408);
            this.Controls.Add(this.AddDescription);
            this.Controls.Add(this.AddIngredients);
            this.Controls.Add(this.AddTitle);
            this.Controls.Add(this.AddCategory);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxIngredients);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.textBoxTitle);
            this.Name = "Update";
            this.Text = "UpdateRecipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddDescription;
        private System.Windows.Forms.Label AddIngredients;
        private System.Windows.Forms.Label AddTitle;
        private System.Windows.Forms.Label AddCategory;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxIngredients;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.TextBox textBoxTitle;
    }
}