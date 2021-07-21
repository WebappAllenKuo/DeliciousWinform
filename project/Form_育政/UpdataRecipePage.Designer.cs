
namespace project.Form_育政
{
    partial class UpdataRecipePage
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
            this.pb_RecipeIMG = new System.Windows.Forms.PictureBox();
            this.lb_RecipeName = new System.Windows.Forms.Label();
            this.tb_RecipeName = new System.Windows.Forms.TextBox();
            this.tb_Howmany = new System.Windows.Forms.TextBox();
            this.lb_Howmany = new System.Windows.Forms.Label();
            this.tb_Time = new System.Windows.Forms.TextBox();
            this.lb_Time = new System.Windows.Forms.Label();
            this.lb_RecipeCategory = new System.Windows.Forms.Label();
            this.lb_RecipeDescription = new System.Windows.Forms.Label();
            this.tb_RecipeDescription = new System.Windows.Forms.TextBox();
            this.tb_Video = new System.Windows.Forms.TextBox();
            this.lb_Video = new System.Windows.Forms.Label();
            this.lbox_Ingredient = new System.Windows.Forms.ListBox();
            this.btn_AddIngredient = new System.Windows.Forms.Button();
            this.btn_RemoveIngredient = new System.Windows.Forms.Button();
            this.lb_IngredientCategory = new System.Windows.Forms.Label();
            this.cb_IngredientCategory = new System.Windows.Forms.ComboBox();
            this.cb_Ingredient = new System.Windows.Forms.ComboBox();
            this.lb_Ingredient = new System.Windows.Forms.Label();
            this.lb_ForUse = new System.Windows.Forms.Label();
            this.lb_Unt = new System.Windows.Forms.Label();
            this.tb_ForUse = new System.Windows.Forms.TextBox();
            this.tb_Unt = new System.Windows.Forms.TextBox();
            this.tb_Step = new System.Windows.Forms.TextBox();
            this.btn_AddStep = new System.Windows.Forms.Button();
            this.btn_RemoveStep = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_RecipeCategory = new System.Windows.Forms.ComboBox();
            this.pb_StepIMG = new System.Windows.Forms.PictureBox();
            this.lbox_Step = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_RecipeIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_StepIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_RecipeIMG
            // 
            this.pb_RecipeIMG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_RecipeIMG.Location = new System.Drawing.Point(30, 25);
            this.pb_RecipeIMG.Name = "pb_RecipeIMG";
            this.pb_RecipeIMG.Size = new System.Drawing.Size(300, 300);
            this.pb_RecipeIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_RecipeIMG.TabIndex = 0;
            this.pb_RecipeIMG.TabStop = false;
            // 
            // lb_RecipeName
            // 
            this.lb_RecipeName.AutoSize = true;
            this.lb_RecipeName.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_RecipeName.Location = new System.Drawing.Point(349, 25);
            this.lb_RecipeName.Name = "lb_RecipeName";
            this.lb_RecipeName.Size = new System.Drawing.Size(123, 35);
            this.lb_RecipeName.TabIndex = 1;
            this.lb_RecipeName.Text = "食譜名稱";
            // 
            // tb_RecipeName
            // 
            this.tb_RecipeName.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_RecipeName.Location = new System.Drawing.Point(489, 17);
            this.tb_RecipeName.Name = "tb_RecipeName";
            this.tb_RecipeName.Size = new System.Drawing.Size(218, 43);
            this.tb_RecipeName.TabIndex = 2;
            this.tb_RecipeName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_RecipeName_KeyPress);
            // 
            // tb_Howmany
            // 
            this.tb_Howmany.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Howmany.Location = new System.Drawing.Point(489, 179);
            this.tb_Howmany.Name = "tb_Howmany";
            this.tb_Howmany.Size = new System.Drawing.Size(218, 43);
            this.tb_Howmany.TabIndex = 4;
            this.tb_Howmany.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Howmany_KeyPress);
            // 
            // lb_Howmany
            // 
            this.lb_Howmany.AutoSize = true;
            this.lb_Howmany.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Howmany.Location = new System.Drawing.Point(349, 187);
            this.lb_Howmany.Name = "lb_Howmany";
            this.lb_Howmany.Size = new System.Drawing.Size(114, 35);
            this.lb_Howmany.TabIndex = 3;
            this.lb_Howmany.Text = "份數(人)";
            // 
            // tb_Time
            // 
            this.tb_Time.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Time.Location = new System.Drawing.Point(535, 264);
            this.tb_Time.Name = "tb_Time";
            this.tb_Time.Size = new System.Drawing.Size(172, 43);
            this.tb_Time.TabIndex = 6;
            this.tb_Time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Time_KeyPress);
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Time.Location = new System.Drawing.Point(349, 272);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(168, 35);
            this.lb_Time.TabIndex = 5;
            this.lb_Time.Text = "烹飪時間(分)";
            // 
            // lb_RecipeCategory
            // 
            this.lb_RecipeCategory.AutoSize = true;
            this.lb_RecipeCategory.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_RecipeCategory.Location = new System.Drawing.Point(349, 100);
            this.lb_RecipeCategory.Name = "lb_RecipeCategory";
            this.lb_RecipeCategory.Size = new System.Drawing.Size(123, 35);
            this.lb_RecipeCategory.TabIndex = 7;
            this.lb_RecipeCategory.Text = "食譜分類";
            // 
            // lb_RecipeDescription
            // 
            this.lb_RecipeDescription.AutoSize = true;
            this.lb_RecipeDescription.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_RecipeDescription.Location = new System.Drawing.Point(774, 25);
            this.lb_RecipeDescription.Name = "lb_RecipeDescription";
            this.lb_RecipeDescription.Size = new System.Drawing.Size(123, 35);
            this.lb_RecipeDescription.TabIndex = 9;
            this.lb_RecipeDescription.Text = "食譜描述";
            // 
            // tb_RecipeDescription
            // 
            this.tb_RecipeDescription.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_RecipeDescription.Location = new System.Drawing.Point(780, 83);
            this.tb_RecipeDescription.Multiline = true;
            this.tb_RecipeDescription.Name = "tb_RecipeDescription";
            this.tb_RecipeDescription.Size = new System.Drawing.Size(327, 224);
            this.tb_RecipeDescription.TabIndex = 10;
            // 
            // tb_Video
            // 
            this.tb_Video.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Video.Location = new System.Drawing.Point(489, 341);
            this.tb_Video.Name = "tb_Video";
            this.tb_Video.Size = new System.Drawing.Size(618, 43);
            this.tb_Video.TabIndex = 12;
            // 
            // lb_Video
            // 
            this.lb_Video.AutoSize = true;
            this.lb_Video.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Video.Location = new System.Drawing.Point(349, 349);
            this.lb_Video.Name = "lb_Video";
            this.lb_Video.Size = new System.Drawing.Size(123, 35);
            this.lb_Video.TabIndex = 11;
            this.lb_Video.Text = "影片連結";
            // 
            // lbox_Ingredient
            // 
            this.lbox_Ingredient.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox_Ingredient.FormattingEnabled = true;
            this.lbox_Ingredient.ItemHeight = 21;
            this.lbox_Ingredient.Location = new System.Drawing.Point(355, 432);
            this.lbox_Ingredient.Name = "lbox_Ingredient";
            this.lbox_Ingredient.Size = new System.Drawing.Size(236, 487);
            this.lbox_Ingredient.TabIndex = 36;
            // 
            // btn_AddIngredient
            // 
            this.btn_AddIngredient.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_AddIngredient.Location = new System.Drawing.Point(30, 862);
            this.btn_AddIngredient.Name = "btn_AddIngredient";
            this.btn_AddIngredient.Size = new System.Drawing.Size(98, 51);
            this.btn_AddIngredient.TabIndex = 37;
            this.btn_AddIngredient.Text = "新增";
            this.btn_AddIngredient.UseVisualStyleBackColor = true;
            this.btn_AddIngredient.Click += new System.EventHandler(this.btn_AddIngredient_Click);
            // 
            // btn_RemoveIngredient
            // 
            this.btn_RemoveIngredient.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_RemoveIngredient.Location = new System.Drawing.Point(149, 862);
            this.btn_RemoveIngredient.Name = "btn_RemoveIngredient";
            this.btn_RemoveIngredient.Size = new System.Drawing.Size(98, 51);
            this.btn_RemoveIngredient.TabIndex = 38;
            this.btn_RemoveIngredient.Text = "刪除";
            this.btn_RemoveIngredient.UseVisualStyleBackColor = true;
            this.btn_RemoveIngredient.Click += new System.EventHandler(this.btn_RemoveIngredient_Click);
            // 
            // lb_IngredientCategory
            // 
            this.lb_IngredientCategory.AutoSize = true;
            this.lb_IngredientCategory.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_IngredientCategory.Location = new System.Drawing.Point(24, 381);
            this.lb_IngredientCategory.Name = "lb_IngredientCategory";
            this.lb_IngredientCategory.Size = new System.Drawing.Size(123, 35);
            this.lb_IngredientCategory.TabIndex = 39;
            this.lb_IngredientCategory.Text = "食材類別";
            // 
            // cb_IngredientCategory
            // 
            this.cb_IngredientCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_IngredientCategory.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_IngredientCategory.FormattingEnabled = true;
            this.cb_IngredientCategory.Location = new System.Drawing.Point(30, 432);
            this.cb_IngredientCategory.Name = "cb_IngredientCategory";
            this.cb_IngredientCategory.Size = new System.Drawing.Size(300, 43);
            this.cb_IngredientCategory.TabIndex = 40;
            this.cb_IngredientCategory.SelectedIndexChanged += new System.EventHandler(this.cb_IngredientCategory_SelectionChangeCommitted);
            this.cb_IngredientCategory.SelectionChangeCommitted += new System.EventHandler(this.cb_IngredientCategory_SelectionChangeCommitted);
            // 
            // cb_Ingredient
            // 
            this.cb_Ingredient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Ingredient.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_Ingredient.FormattingEnabled = true;
            this.cb_Ingredient.Location = new System.Drawing.Point(30, 540);
            this.cb_Ingredient.Name = "cb_Ingredient";
            this.cb_Ingredient.Size = new System.Drawing.Size(300, 43);
            this.cb_Ingredient.TabIndex = 42;
            // 
            // lb_Ingredient
            // 
            this.lb_Ingredient.AutoSize = true;
            this.lb_Ingredient.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Ingredient.Location = new System.Drawing.Point(24, 489);
            this.lb_Ingredient.Name = "lb_Ingredient";
            this.lb_Ingredient.Size = new System.Drawing.Size(69, 35);
            this.lb_Ingredient.TabIndex = 41;
            this.lb_Ingredient.Text = "食材";
            // 
            // lb_ForUse
            // 
            this.lb_ForUse.AutoSize = true;
            this.lb_ForUse.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_ForUse.Location = new System.Drawing.Point(24, 600);
            this.lb_ForUse.Name = "lb_ForUse";
            this.lb_ForUse.Size = new System.Drawing.Size(69, 35);
            this.lb_ForUse.TabIndex = 43;
            this.lb_ForUse.Text = "數量";
            // 
            // lb_Unt
            // 
            this.lb_Unt.AutoSize = true;
            this.lb_Unt.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Unt.Location = new System.Drawing.Point(24, 728);
            this.lb_Unt.Name = "lb_Unt";
            this.lb_Unt.Size = new System.Drawing.Size(69, 35);
            this.lb_Unt.TabIndex = 44;
            this.lb_Unt.Text = "單位";
            // 
            // tb_ForUse
            // 
            this.tb_ForUse.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_ForUse.Location = new System.Drawing.Point(30, 658);
            this.tb_ForUse.Name = "tb_ForUse";
            this.tb_ForUse.Size = new System.Drawing.Size(300, 43);
            this.tb_ForUse.TabIndex = 45;
            this.tb_ForUse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ForUse_KeyPress);
            // 
            // tb_Unt
            // 
            this.tb_Unt.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Unt.Location = new System.Drawing.Point(30, 781);
            this.tb_Unt.Name = "tb_Unt";
            this.tb_Unt.Size = new System.Drawing.Size(300, 43);
            this.tb_Unt.TabIndex = 46;
            this.tb_Unt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Unt_KeyPress);
            // 
            // tb_Step
            // 
            this.tb_Step.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Step.Location = new System.Drawing.Point(872, 687);
            this.tb_Step.Multiline = true;
            this.tb_Step.Name = "tb_Step";
            this.tb_Step.Size = new System.Drawing.Size(235, 149);
            this.tb_Step.TabIndex = 48;
            // 
            // btn_AddStep
            // 
            this.btn_AddStep.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_AddStep.Location = new System.Drawing.Point(780, 851);
            this.btn_AddStep.Name = "btn_AddStep";
            this.btn_AddStep.Size = new System.Drawing.Size(63, 62);
            this.btn_AddStep.TabIndex = 50;
            this.btn_AddStep.Text = "新增";
            this.btn_AddStep.UseVisualStyleBackColor = true;
            this.btn_AddStep.Click += new System.EventHandler(this.btn_AddStep_Click);
            // 
            // btn_RemoveStep
            // 
            this.btn_RemoveStep.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_RemoveStep.Location = new System.Drawing.Point(975, 851);
            this.btn_RemoveStep.Name = "btn_RemoveStep";
            this.btn_RemoveStep.Size = new System.Drawing.Size(63, 62);
            this.btn_RemoveStep.TabIndex = 51;
            this.btn_RemoveStep.Text = "刪除";
            this.btn_RemoveStep.UseVisualStyleBackColor = true;
            this.btn_RemoveStep.Click += new System.EventHandler(this.btn_RemoveStep_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Update.Location = new System.Drawing.Point(657, 954);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(186, 81);
            this.btn_Update.TabIndex = 52;
            this.btn_Update.Text = "確認修改";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(405, 954);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 81);
            this.button2.TabIndex = 53;
            this.button2.Text = "返回退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cb_RecipeCategory
            // 
            this.cb_RecipeCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_RecipeCategory.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_RecipeCategory.FormattingEnabled = true;
            this.cb_RecipeCategory.Location = new System.Drawing.Point(489, 92);
            this.cb_RecipeCategory.Name = "cb_RecipeCategory";
            this.cb_RecipeCategory.Size = new System.Drawing.Size(218, 43);
            this.cb_RecipeCategory.TabIndex = 54;
            // 
            // pb_StepIMG
            // 
            this.pb_StepIMG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_StepIMG.Location = new System.Drawing.Point(657, 687);
            this.pb_StepIMG.Name = "pb_StepIMG";
            this.pb_StepIMG.Size = new System.Drawing.Size(209, 149);
            this.pb_StepIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_StepIMG.TabIndex = 56;
            this.pb_StepIMG.TabStop = false;
            // 
            // lbox_Step
            // 
            this.lbox_Step.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox_Step.FormattingEnabled = true;
            this.lbox_Step.ItemHeight = 21;
            this.lbox_Step.Location = new System.Drawing.Point(657, 432);
            this.lbox_Step.Name = "lbox_Step";
            this.lbox_Step.Size = new System.Drawing.Size(450, 235);
            this.lbox_Step.TabIndex = 57;
            this.lbox_Step.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbox_Step_MouseClick);
            // 
            // UpdataRecipePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 1061);
            this.Controls.Add(this.lbox_Step);
            this.Controls.Add(this.pb_StepIMG);
            this.Controls.Add(this.cb_RecipeCategory);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_RemoveStep);
            this.Controls.Add(this.btn_AddStep);
            this.Controls.Add(this.tb_Step);
            this.Controls.Add(this.tb_Unt);
            this.Controls.Add(this.tb_ForUse);
            this.Controls.Add(this.lb_Unt);
            this.Controls.Add(this.lb_ForUse);
            this.Controls.Add(this.cb_Ingredient);
            this.Controls.Add(this.lb_Ingredient);
            this.Controls.Add(this.cb_IngredientCategory);
            this.Controls.Add(this.lb_IngredientCategory);
            this.Controls.Add(this.btn_RemoveIngredient);
            this.Controls.Add(this.btn_AddIngredient);
            this.Controls.Add(this.lbox_Ingredient);
            this.Controls.Add(this.tb_Video);
            this.Controls.Add(this.lb_Video);
            this.Controls.Add(this.tb_RecipeDescription);
            this.Controls.Add(this.lb_RecipeDescription);
            this.Controls.Add(this.lb_RecipeCategory);
            this.Controls.Add(this.tb_Time);
            this.Controls.Add(this.lb_Time);
            this.Controls.Add(this.tb_Howmany);
            this.Controls.Add(this.lb_Howmany);
            this.Controls.Add(this.tb_RecipeName);
            this.Controls.Add(this.lb_RecipeName);
            this.Controls.Add(this.pb_RecipeIMG);
            this.Name = "UpdataRecipePage";
            this.Text = "UpdataRecipePage";
            ((System.ComponentModel.ISupportInitialize)(this.pb_RecipeIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_StepIMG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_RecipeIMG;
        private System.Windows.Forms.Label lb_RecipeName;
        private System.Windows.Forms.TextBox tb_RecipeName;
        private System.Windows.Forms.TextBox tb_Howmany;
        private System.Windows.Forms.Label lb_Howmany;
        private System.Windows.Forms.TextBox tb_Time;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.Label lb_RecipeCategory;
        private System.Windows.Forms.Label lb_RecipeDescription;
        private System.Windows.Forms.TextBox tb_RecipeDescription;
        private System.Windows.Forms.TextBox tb_Video;
        private System.Windows.Forms.Label lb_Video;
        private System.Windows.Forms.ListBox lbox_Ingredient;
        private System.Windows.Forms.Button btn_AddIngredient;
        private System.Windows.Forms.Button btn_RemoveIngredient;
        private System.Windows.Forms.Label lb_IngredientCategory;
        private System.Windows.Forms.ComboBox cb_IngredientCategory;
        private System.Windows.Forms.ComboBox cb_Ingredient;
        private System.Windows.Forms.Label lb_Ingredient;
        private System.Windows.Forms.Label lb_ForUse;
        private System.Windows.Forms.Label lb_Unt;
        private System.Windows.Forms.TextBox tb_ForUse;
        private System.Windows.Forms.TextBox tb_Unt;
        private System.Windows.Forms.TextBox tb_Step;
        private System.Windows.Forms.Button btn_AddStep;
        private System.Windows.Forms.Button btn_RemoveStep;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cb_RecipeCategory;
        private System.Windows.Forms.PictureBox pb_StepIMG;
        private System.Windows.Forms.ListBox lbox_Step;
    }
}