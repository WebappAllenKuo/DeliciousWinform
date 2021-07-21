
namespace project.Form_Chia
{
    partial class FrmAddIngr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddIngr));
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Canceladd = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.cb_IngrCat = new System.Windows.Forms.ComboBox();
            this.tb_IngUnt = new System.Windows.Forms.TextBox();
            this.tb_IngPr = new System.Windows.Forms.TextBox();
            this.tb_IngSto = new System.Windows.Forms.TextBox();
            this.tb_Ingdes = new System.Windows.Forms.TextBox();
            this.tb_IngrName = new System.Windows.Forms.TextBox();
            this.cb_IsSell = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Close = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lb_adminname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(197, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 36);
            this.label8.TabIndex = 10;
            this.label8.Text = "新增食材頁面";
            // 
            // btn_Canceladd
            // 
            this.btn_Canceladd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Canceladd.Location = new System.Drawing.Point(200, 373);
            this.btn_Canceladd.Name = "btn_Canceladd";
            this.btn_Canceladd.Size = new System.Drawing.Size(153, 64);
            this.btn_Canceladd.TabIndex = 17;
            this.btn_Canceladd.Text = "取消新增";
            this.btn_Canceladd.UseVisualStyleBackColor = true;
            this.btn_Canceladd.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Add.Location = new System.Drawing.Point(27, 373);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(153, 64);
            this.btn_Add.TabIndex = 16;
            this.btn_Add.Text = "確認新增";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_addIngredient_Click);
            // 
            // cb_IngrCat
            // 
            this.cb_IngrCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_IngrCat.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_IngrCat.FormattingEnabled = true;
            this.cb_IngrCat.Location = new System.Drawing.Point(210, 77);
            this.cb_IngrCat.Name = "cb_IngrCat";
            this.cb_IngrCat.Size = new System.Drawing.Size(203, 38);
            this.cb_IngrCat.TabIndex = 14;
            // 
            // tb_IngUnt
            // 
            this.tb_IngUnt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_IngUnt.Location = new System.Drawing.Point(210, 122);
            this.tb_IngUnt.Name = "tb_IngUnt";
            this.tb_IngUnt.Size = new System.Drawing.Size(203, 39);
            this.tb_IngUnt.TabIndex = 13;
            // 
            // tb_IngPr
            // 
            this.tb_IngPr.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_IngPr.Location = new System.Drawing.Point(210, 167);
            this.tb_IngPr.Name = "tb_IngPr";
            this.tb_IngPr.Size = new System.Drawing.Size(203, 39);
            this.tb_IngPr.TabIndex = 12;
            // 
            // tb_IngSto
            // 
            this.tb_IngSto.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_IngSto.Location = new System.Drawing.Point(210, 213);
            this.tb_IngSto.Name = "tb_IngSto";
            this.tb_IngSto.Size = new System.Drawing.Size(203, 39);
            this.tb_IngSto.TabIndex = 11;
            // 
            // tb_Ingdes
            // 
            this.tb_Ingdes.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Ingdes.Location = new System.Drawing.Point(210, 259);
            this.tb_Ingdes.Name = "tb_Ingdes";
            this.tb_Ingdes.Size = new System.Drawing.Size(203, 39);
            this.tb_Ingdes.TabIndex = 10;
            // 
            // tb_IngrName
            // 
            this.tb_IngrName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_IngrName.Location = new System.Drawing.Point(210, 31);
            this.tb_IngrName.Name = "tb_IngrName";
            this.tb_IngrName.Size = new System.Drawing.Size(203, 39);
            this.tb_IngrName.TabIndex = 9;
            // 
            // cb_IsSell
            // 
            this.cb_IsSell.AutoSize = true;
            this.cb_IsSell.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_IsSell.Location = new System.Drawing.Point(210, 313);
            this.cb_IsSell.Name = "cb_IsSell";
            this.cb_IsSell.Size = new System.Drawing.Size(111, 34);
            this.cb_IsSell.TabIndex = 8;
            this.cb_IsSell.Text = "販賣中";
            this.cb_IsSell.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(21, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 36);
            this.label7.TabIndex = 6;
            this.label7.Text = "食材分類";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(21, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 36);
            this.label6.TabIndex = 5;
            this.label6.Text = "食材單位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(21, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "商品售價";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(21, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "商品庫存";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(21, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "商品描述";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(21, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "商品販賣狀況";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "食材名稱";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_Close);
            this.panel1.Controls.Add(this.btn_Canceladd);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.cb_IngrCat);
            this.panel1.Controls.Add(this.tb_IngUnt);
            this.panel1.Controls.Add(this.tb_IngPr);
            this.panel1.Controls.Add(this.tb_IngSto);
            this.panel1.Controls.Add(this.tb_Ingdes);
            this.panel1.Controls.Add(this.tb_IngrName);
            this.panel1.Controls.Add(this.cb_IsSell);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 482);
            this.panel1.TabIndex = 8;
            // 
            // bt_Close
            // 
            this.bt_Close.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.bt_Close.Location = new System.Drawing.Point(374, 373);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(74, 64);
            this.bt_Close.TabIndex = 18;
            this.bt_Close.Text = "關閉";
            this.bt_Close.UseVisualStyleBackColor = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lb_adminname
            // 
            this.lb_adminname.AutoSize = true;
            this.lb_adminname.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_adminname.Location = new System.Drawing.Point(206, 77);
            this.lb_adminname.Name = "lb_adminname";
            this.lb_adminname.Size = new System.Drawing.Size(85, 31);
            this.lb_adminname.TabIndex = 11;
            this.lb_adminname.Text = "label9";
            // 
            // FrmAddIngr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 676);
            this.Controls.Add(this.lb_adminname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAddIngr";
            this.Text = "IngredientAdd";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Canceladd;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ComboBox cb_IngrCat;
        private System.Windows.Forms.TextBox tb_IngUnt;
        private System.Windows.Forms.TextBox tb_IngPr;
        private System.Windows.Forms.TextBox tb_IngSto;
        private System.Windows.Forms.TextBox tb_Ingdes;
        private System.Windows.Forms.TextBox tb_IngrName;
        private System.Windows.Forms.CheckBox cb_IsSell;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bt_Close;
        private System.Windows.Forms.Label lb_adminname;
    }
}