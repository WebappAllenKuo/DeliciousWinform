
namespace project.Form_育政
{
    partial class AddRecipePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRecipePage));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_AddRecipe = new System.Windows.Forms.TabPage();
            this.lb_RecipeDescription = new System.Windows.Forms.Label();
            this.tb_RecipeDescription = new System.Windows.Forms.TextBox();
            this.tb_RecipeName = new System.Windows.Forms.TextBox();
            this.lb_RecipeName = new System.Windows.Forms.Label();
            this.tb_howmany = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.tb_Video = new System.Windows.Forms.TextBox();
            this.lb_Video = new System.Windows.Forms.Label();
            this.tb_Time = new System.Windows.Forms.TextBox();
            this.lb_Time = new System.Windows.Forms.Label();
            this.lb_howmany = new System.Windows.Forms.Label();
            this.lb_CategoryName = new System.Windows.Forms.Label();
            this.pb_RecipeIMG = new System.Windows.Forms.PictureBox();
            this.cb_CategoryName = new System.Windows.Forms.ComboBox();
            this.tab_AddIngredient = new System.Windows.Forms.TabPage();
            this.tb_Unt = new System.Windows.Forms.TextBox();
            this.tb_Foruse = new System.Windows.Forms.TextBox();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.Ingredient_listBox = new System.Windows.Forms.ListBox();
            this.lb_Unt = new System.Windows.Forms.Label();
            this.lb_IngredientAmountForUse = new System.Windows.Forms.Label();
            this.lb_Ingredient = new System.Windows.Forms.Label();
            this.cb_Ingredient = new System.Windows.Forms.ComboBox();
            this.lb_IngredientCategory = new System.Windows.Forms.Label();
            this.cb_IngredientCategory = new System.Windows.Forms.ComboBox();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.tab_AddStep = new System.Windows.Forms.TabPage();
            this.btn_StepDelete = new System.Windows.Forms.Button();
            this.btn_StepAdd = new System.Windows.Forms.Button();
            this.tb_Step = new System.Windows.Forms.TextBox();
            this.Step_listBox = new System.Windows.Forms.ListBox();
            this.btn_Cancel3 = new System.Windows.Forms.Button();
            this.pb_StepIMG = new System.Windows.Forms.PictureBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.openIMGDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tab_AddRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_RecipeIMG)).BeginInit();
            this.tab_AddIngredient.SuspendLayout();
            this.tab_AddStep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_StepIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_AddRecipe);
            this.tabControl1.Controls.Add(this.tab_AddIngredient);
            this.tabControl1.Controls.Add(this.tab_AddStep);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1077, 618);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_AddRecipe
            // 
            this.tab_AddRecipe.Controls.Add(this.lb_RecipeDescription);
            this.tab_AddRecipe.Controls.Add(this.tb_RecipeDescription);
            this.tab_AddRecipe.Controls.Add(this.tb_RecipeName);
            this.tab_AddRecipe.Controls.Add(this.lb_RecipeName);
            this.tab_AddRecipe.Controls.Add(this.tb_howmany);
            this.tab_AddRecipe.Controls.Add(this.btn_OK);
            this.tab_AddRecipe.Controls.Add(this.tb_Video);
            this.tab_AddRecipe.Controls.Add(this.lb_Video);
            this.tab_AddRecipe.Controls.Add(this.tb_Time);
            this.tab_AddRecipe.Controls.Add(this.lb_Time);
            this.tab_AddRecipe.Controls.Add(this.lb_howmany);
            this.tab_AddRecipe.Controls.Add(this.lb_CategoryName);
            this.tab_AddRecipe.Controls.Add(this.pb_RecipeIMG);
            this.tab_AddRecipe.Controls.Add(this.cb_CategoryName);
            this.tab_AddRecipe.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tab_AddRecipe.Location = new System.Drawing.Point(4, 22);
            this.tab_AddRecipe.Name = "tab_AddRecipe";
            this.tab_AddRecipe.Padding = new System.Windows.Forms.Padding(3);
            this.tab_AddRecipe.Size = new System.Drawing.Size(1069, 592);
            this.tab_AddRecipe.TabIndex = 0;
            this.tab_AddRecipe.Text = "食譜新增";
            this.tab_AddRecipe.UseVisualStyleBackColor = true;
            // 
            // lb_RecipeDescription
            // 
            this.lb_RecipeDescription.AutoSize = true;
            this.lb_RecipeDescription.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_RecipeDescription.Location = new System.Drawing.Point(426, 282);
            this.lb_RecipeDescription.Name = "lb_RecipeDescription";
            this.lb_RecipeDescription.Size = new System.Drawing.Size(69, 35);
            this.lb_RecipeDescription.TabIndex = 33;
            this.lb_RecipeDescription.Text = "簡述";
            // 
            // tb_RecipeDescription
            // 
            this.tb_RecipeDescription.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_RecipeDescription.Location = new System.Drawing.Point(506, 282);
            this.tb_RecipeDescription.MaxLength = 500;
            this.tb_RecipeDescription.Multiline = true;
            this.tb_RecipeDescription.Name = "tb_RecipeDescription";
            this.tb_RecipeDescription.Size = new System.Drawing.Size(457, 124);
            this.tb_RecipeDescription.TabIndex = 32;
            // 
            // tb_RecipeName
            // 
            this.tb_RecipeName.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_RecipeName.Location = new System.Drawing.Point(387, 81);
            this.tb_RecipeName.MaxLength = 30;
            this.tb_RecipeName.Name = "tb_RecipeName";
            this.tb_RecipeName.Size = new System.Drawing.Size(274, 43);
            this.tb_RecipeName.TabIndex = 31;
            this.tb_RecipeName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_RecipeName_KeyPress);
            // 
            // lb_RecipeName
            // 
            this.lb_RecipeName.AutoSize = true;
            this.lb_RecipeName.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_RecipeName.Location = new System.Drawing.Point(381, 43);
            this.lb_RecipeName.Name = "lb_RecipeName";
            this.lb_RecipeName.Size = new System.Drawing.Size(123, 35);
            this.lb_RecipeName.TabIndex = 30;
            this.lb_RecipeName.Text = "食譜名稱";
            // 
            // tb_howmany
            // 
            this.tb_howmany.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_howmany.Location = new System.Drawing.Point(387, 200);
            this.tb_howmany.MaxLength = 3;
            this.tb_howmany.Name = "tb_howmany";
            this.tb_howmany.Size = new System.Drawing.Size(274, 43);
            this.tb_howmany.TabIndex = 28;
            this.tb_howmany.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_howmany_KeyPress);
            // 
            // btn_OK
            // 
            this.btn_OK.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_OK.Location = new System.Drawing.Point(902, 493);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(110, 38);
            this.btn_OK.TabIndex = 27;
            this.btn_OK.Text = "食譜確認";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // tb_Video
            // 
            this.tb_Video.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Video.Location = new System.Drawing.Point(208, 431);
            this.tb_Video.Name = "tb_Video";
            this.tb_Video.Size = new System.Drawing.Size(804, 43);
            this.tb_Video.TabIndex = 26;
            // 
            // lb_Video
            // 
            this.lb_Video.AutoSize = true;
            this.lb_Video.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Video.Location = new System.Drawing.Point(25, 434);
            this.lb_Video.Name = "lb_Video";
            this.lb_Video.Size = new System.Drawing.Size(177, 35);
            this.lb_Video.TabIndex = 25;
            this.lb_Video.Text = "分享影片連結";
            // 
            // tb_Time
            // 
            this.tb_Time.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Time.Location = new System.Drawing.Point(689, 200);
            this.tb_Time.MaxLength = 10;
            this.tb_Time.Name = "tb_Time";
            this.tb_Time.Size = new System.Drawing.Size(274, 43);
            this.tb_Time.TabIndex = 24;
            this.tb_Time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Time_KeyPress);
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Time.Location = new System.Drawing.Point(683, 162);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(168, 35);
            this.lb_Time.TabIndex = 23;
            this.lb_Time.Text = "烹飪時間(分)";
            // 
            // lb_howmany
            // 
            this.lb_howmany.AutoSize = true;
            this.lb_howmany.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_howmany.Location = new System.Drawing.Point(381, 162);
            this.lb_howmany.Name = "lb_howmany";
            this.lb_howmany.Size = new System.Drawing.Size(114, 35);
            this.lb_howmany.TabIndex = 22;
            this.lb_howmany.Text = "份數(人)";
            // 
            // lb_CategoryName
            // 
            this.lb_CategoryName.AutoSize = true;
            this.lb_CategoryName.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_CategoryName.Location = new System.Drawing.Point(683, 43);
            this.lb_CategoryName.Name = "lb_CategoryName";
            this.lb_CategoryName.Size = new System.Drawing.Size(123, 35);
            this.lb_CategoryName.TabIndex = 20;
            this.lb_CategoryName.Text = "食譜分類";
            // 
            // pb_RecipeIMG
            // 
            this.pb_RecipeIMG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_RecipeIMG.BackgroundImage")));
            this.pb_RecipeIMG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_RecipeIMG.Location = new System.Drawing.Point(31, 30);
            this.pb_RecipeIMG.Name = "pb_RecipeIMG";
            this.pb_RecipeIMG.Size = new System.Drawing.Size(330, 330);
            this.pb_RecipeIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_RecipeIMG.TabIndex = 18;
            this.pb_RecipeIMG.TabStop = false;
            this.pb_RecipeIMG.DoubleClick += new System.EventHandler(this.pb_RecipeIMG_DoubleClick);
            // 
            // cb_CategoryName
            // 
            this.cb_CategoryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CategoryName.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_CategoryName.FormattingEnabled = true;
            this.cb_CategoryName.Location = new System.Drawing.Point(689, 81);
            this.cb_CategoryName.Name = "cb_CategoryName";
            this.cb_CategoryName.Size = new System.Drawing.Size(274, 43);
            this.cb_CategoryName.TabIndex = 19;
            // 
            // tab_AddIngredient
            // 
            this.tab_AddIngredient.Controls.Add(this.tb_Unt);
            this.tab_AddIngredient.Controls.Add(this.tb_Foruse);
            this.tab_AddIngredient.Controls.Add(this.btn_Next);
            this.tab_AddIngredient.Controls.Add(this.btn_Delete);
            this.tab_AddIngredient.Controls.Add(this.btn_Add);
            this.tab_AddIngredient.Controls.Add(this.Ingredient_listBox);
            this.tab_AddIngredient.Controls.Add(this.lb_Unt);
            this.tab_AddIngredient.Controls.Add(this.lb_IngredientAmountForUse);
            this.tab_AddIngredient.Controls.Add(this.lb_Ingredient);
            this.tab_AddIngredient.Controls.Add(this.cb_Ingredient);
            this.tab_AddIngredient.Controls.Add(this.lb_IngredientCategory);
            this.tab_AddIngredient.Controls.Add(this.cb_IngredientCategory);
            this.tab_AddIngredient.Controls.Add(this.btn_Previous);
            this.tab_AddIngredient.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tab_AddIngredient.Location = new System.Drawing.Point(4, 22);
            this.tab_AddIngredient.Name = "tab_AddIngredient";
            this.tab_AddIngredient.Padding = new System.Windows.Forms.Padding(3);
            this.tab_AddIngredient.Size = new System.Drawing.Size(1069, 592);
            this.tab_AddIngredient.TabIndex = 1;
            this.tab_AddIngredient.Text = "食材新增";
            this.tab_AddIngredient.UseVisualStyleBackColor = true;
            // 
            // tb_Unt
            // 
            this.tb_Unt.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Unt.Location = new System.Drawing.Point(33, 431);
            this.tb_Unt.Name = "tb_Unt";
            this.tb_Unt.Size = new System.Drawing.Size(235, 43);
            this.tb_Unt.TabIndex = 40;
            this.tb_Unt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Unt_KeyPress);
            // 
            // tb_Foruse
            // 
            this.tb_Foruse.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Foruse.Location = new System.Drawing.Point(33, 313);
            this.tb_Foruse.Name = "tb_Foruse";
            this.tb_Foruse.Size = new System.Drawing.Size(235, 43);
            this.tb_Foruse.TabIndex = 39;
            this.tb_Foruse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Foruse_KeyPress);
            // 
            // btn_Next
            // 
            this.btn_Next.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Next.Location = new System.Drawing.Point(752, 521);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(121, 40);
            this.btn_Next.TabIndex = 38;
            this.btn_Next.Text = "下一頁";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(943, 244);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(98, 51);
            this.btn_Delete.TabIndex = 37;
            this.btn_Delete.Text = "刪除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(314, 244);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(98, 51);
            this.btn_Add.TabIndex = 36;
            this.btn_Add.Text = "新增";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // Ingredient_listBox
            // 
            this.Ingredient_listBox.FormattingEnabled = true;
            this.Ingredient_listBox.ItemHeight = 21;
            this.Ingredient_listBox.Location = new System.Drawing.Point(441, 29);
            this.Ingredient_listBox.Name = "Ingredient_listBox";
            this.Ingredient_listBox.Size = new System.Drawing.Size(473, 445);
            this.Ingredient_listBox.TabIndex = 35;
            // 
            // lb_Unt
            // 
            this.lb_Unt.AutoSize = true;
            this.lb_Unt.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Unt.Location = new System.Drawing.Point(27, 383);
            this.lb_Unt.Name = "lb_Unt";
            this.lb_Unt.Size = new System.Drawing.Size(69, 35);
            this.lb_Unt.TabIndex = 34;
            this.lb_Unt.Text = "單位";
            // 
            // lb_IngredientAmountForUse
            // 
            this.lb_IngredientAmountForUse.AutoSize = true;
            this.lb_IngredientAmountForUse.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_IngredientAmountForUse.Location = new System.Drawing.Point(27, 260);
            this.lb_IngredientAmountForUse.Name = "lb_IngredientAmountForUse";
            this.lb_IngredientAmountForUse.Size = new System.Drawing.Size(69, 35);
            this.lb_IngredientAmountForUse.TabIndex = 32;
            this.lb_IngredientAmountForUse.Text = "數量";
            // 
            // lb_Ingredient
            // 
            this.lb_Ingredient.AutoSize = true;
            this.lb_Ingredient.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Ingredient.Location = new System.Drawing.Point(27, 144);
            this.lb_Ingredient.Name = "lb_Ingredient";
            this.lb_Ingredient.Size = new System.Drawing.Size(150, 35);
            this.lb_Ingredient.TabIndex = 30;
            this.lb_Ingredient.Text = "請選擇食材";
            // 
            // cb_Ingredient
            // 
            this.cb_Ingredient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Ingredient.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_Ingredient.FormattingEnabled = true;
            this.cb_Ingredient.Location = new System.Drawing.Point(33, 192);
            this.cb_Ingredient.Name = "cb_Ingredient";
            this.cb_Ingredient.Size = new System.Drawing.Size(235, 43);
            this.cb_Ingredient.TabIndex = 29;
            // 
            // lb_IngredientCategory
            // 
            this.lb_IngredientCategory.AutoSize = true;
            this.lb_IngredientCategory.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_IngredientCategory.Location = new System.Drawing.Point(27, 28);
            this.lb_IngredientCategory.Name = "lb_IngredientCategory";
            this.lb_IngredientCategory.Size = new System.Drawing.Size(204, 35);
            this.lb_IngredientCategory.TabIndex = 28;
            this.lb_IngredientCategory.Text = "請選擇食材類別";
            // 
            // cb_IngredientCategory
            // 
            this.cb_IngredientCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_IngredientCategory.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_IngredientCategory.FormattingEnabled = true;
            this.cb_IngredientCategory.Location = new System.Drawing.Point(33, 76);
            this.cb_IngredientCategory.Name = "cb_IngredientCategory";
            this.cb_IngredientCategory.Size = new System.Drawing.Size(235, 43);
            this.cb_IngredientCategory.TabIndex = 27;
            this.cb_IngredientCategory.SelectionChangeCommitted += new System.EventHandler(this.cb_IngredientCategory_SelectionChangeCommitted);
            // 
            // btn_Previous
            // 
            this.btn_Previous.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Previous.Location = new System.Drawing.Point(896, 521);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(121, 40);
            this.btn_Previous.TabIndex = 26;
            this.btn_Previous.Text = "返回上一頁";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // tab_AddStep
            // 
            this.tab_AddStep.Controls.Add(this.btn_StepDelete);
            this.tab_AddStep.Controls.Add(this.btn_StepAdd);
            this.tab_AddStep.Controls.Add(this.tb_Step);
            this.tab_AddStep.Controls.Add(this.Step_listBox);
            this.tab_AddStep.Controls.Add(this.btn_Cancel3);
            this.tab_AddStep.Controls.Add(this.pb_StepIMG);
            this.tab_AddStep.Controls.Add(this.btn_Save);
            this.tab_AddStep.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tab_AddStep.Location = new System.Drawing.Point(4, 22);
            this.tab_AddStep.Name = "tab_AddStep";
            this.tab_AddStep.Size = new System.Drawing.Size(1069, 592);
            this.tab_AddStep.TabIndex = 2;
            this.tab_AddStep.Text = "步驟新增";
            this.tab_AddStep.UseVisualStyleBackColor = true;
            // 
            // btn_StepDelete
            // 
            this.btn_StepDelete.Location = new System.Drawing.Point(156, 471);
            this.btn_StepDelete.Name = "btn_StepDelete";
            this.btn_StepDelete.Size = new System.Drawing.Size(98, 51);
            this.btn_StepDelete.TabIndex = 38;
            this.btn_StepDelete.Text = "刪除";
            this.btn_StepDelete.UseVisualStyleBackColor = true;
            this.btn_StepDelete.Click += new System.EventHandler(this.btn_StepDelete_Click);
            // 
            // btn_StepAdd
            // 
            this.btn_StepAdd.Location = new System.Drawing.Point(34, 471);
            this.btn_StepAdd.Name = "btn_StepAdd";
            this.btn_StepAdd.Size = new System.Drawing.Size(98, 51);
            this.btn_StepAdd.TabIndex = 37;
            this.btn_StepAdd.Text = "新增";
            this.btn_StepAdd.UseVisualStyleBackColor = true;
            this.btn_StepAdd.Click += new System.EventHandler(this.btn_StepAdd_Click);
            // 
            // tb_Step
            // 
            this.tb_Step.Location = new System.Drawing.Point(34, 272);
            this.tb_Step.Multiline = true;
            this.tb_Step.Name = "tb_Step";
            this.tb_Step.Size = new System.Drawing.Size(552, 151);
            this.tb_Step.TabIndex = 27;
            // 
            // Step_listBox
            // 
            this.Step_listBox.FormattingEnabled = true;
            this.Step_listBox.ItemHeight = 21;
            this.Step_listBox.Location = new System.Drawing.Point(34, 23);
            this.Step_listBox.Name = "Step_listBox";
            this.Step_listBox.Size = new System.Drawing.Size(552, 214);
            this.Step_listBox.TabIndex = 26;
            // 
            // btn_Cancel3
            // 
            this.btn_Cancel3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Cancel3.Location = new System.Drawing.Point(857, 482);
            this.btn_Cancel3.Name = "btn_Cancel3";
            this.btn_Cancel3.Size = new System.Drawing.Size(121, 40);
            this.btn_Cancel3.TabIndex = 25;
            this.btn_Cancel3.Text = "返回上一頁";
            this.btn_Cancel3.UseVisualStyleBackColor = true;
            this.btn_Cancel3.Click += new System.EventHandler(this.btn_Cancel3_Click);
            // 
            // pb_StepIMG
            // 
            this.pb_StepIMG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_StepIMG.BackgroundImage")));
            this.pb_StepIMG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_StepIMG.Location = new System.Drawing.Point(633, 23);
            this.pb_StepIMG.Name = "pb_StepIMG";
            this.pb_StepIMG.Size = new System.Drawing.Size(398, 400);
            this.pb_StepIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_StepIMG.TabIndex = 24;
            this.pb_StepIMG.TabStop = false;
            this.pb_StepIMG.Click += new System.EventHandler(this.pb_StepIMG_Click);
            this.pb_StepIMG.DoubleClick += new System.EventHandler(this.pb_StepIMG_DoubleClick);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Save.Location = new System.Drawing.Point(694, 482);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(121, 40);
            this.btn_Save.TabIndex = 20;
            this.btn_Save.Text = "確認儲存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // openIMGDialog
            // 
            this.openIMGDialog.FileName = "openFileDialog1";
            // 
            // AddRecipePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 618);
            this.Controls.Add(this.tabControl1);
            this.Name = "AddRecipePage";
            this.Text = "AddRecipePage";
            this.Load += new System.EventHandler(this.AddRecipePage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_AddRecipe.ResumeLayout(false);
            this.tab_AddRecipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_RecipeIMG)).EndInit();
            this.tab_AddIngredient.ResumeLayout(false);
            this.tab_AddIngredient.PerformLayout();
            this.tab_AddStep.ResumeLayout(false);
            this.tab_AddStep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_StepIMG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_AddRecipe;
        private System.Windows.Forms.TabPage tab_AddIngredient;
        private System.Windows.Forms.TabPage tab_AddStep;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TextBox tb_Video;
        private System.Windows.Forms.Label lb_Video;
        private System.Windows.Forms.TextBox tb_Time;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.Label lb_howmany;
        private System.Windows.Forms.Label lb_CategoryName;
        private System.Windows.Forms.PictureBox pb_RecipeIMG;
        private System.Windows.Forms.ComboBox cb_CategoryName;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_Cancel3;
        private System.Windows.Forms.PictureBox pb_StepIMG;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ListBox Ingredient_listBox;
        private System.Windows.Forms.Label lb_Unt;
        private System.Windows.Forms.Label lb_IngredientAmountForUse;
        private System.Windows.Forms.Label lb_Ingredient;
        private System.Windows.Forms.ComboBox cb_Ingredient;
        private System.Windows.Forms.Label lb_IngredientCategory;
        private System.Windows.Forms.ComboBox cb_IngredientCategory;
        private System.Windows.Forms.TextBox tb_howmany;
        private System.Windows.Forms.OpenFileDialog openIMGDialog;
        private System.Windows.Forms.TextBox tb_Unt;
        private System.Windows.Forms.TextBox tb_Foruse;
        private System.Windows.Forms.TextBox tb_Step;
        private System.Windows.Forms.ListBox Step_listBox;
        private System.Windows.Forms.Button btn_StepAdd;
        private System.Windows.Forms.Button btn_StepDelete;
        private System.Windows.Forms.TextBox tb_RecipeName;
        private System.Windows.Forms.Label lb_RecipeName;
        private System.Windows.Forms.Label lb_RecipeDescription;
        private System.Windows.Forms.TextBox tb_RecipeDescription;
    }
}