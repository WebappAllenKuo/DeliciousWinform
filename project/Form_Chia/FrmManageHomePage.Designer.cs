
namespace project.Form_Chia
{
    partial class FrmManageHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageHomePage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_QA = new System.Windows.Forms.Button();
            this.btn_SendMail = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_UpdMemInfo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_HideComment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_HideRecipe = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_HashTagManage = new System.Windows.Forms.Button();
            this.btn_SrhOrder = new System.Windows.Forms.Button();
            this.btn_UpdDelIng = new System.Windows.Forms.Button();
            this.btn_AddIng = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ManageIngRecipe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_OrderManage = new System.Windows.Forms.Button();
            this.lb_adminname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btn_QA
            // 
            this.btn_QA.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_QA.Location = new System.Drawing.Point(32, 210);
            this.btn_QA.Name = "btn_QA";
            this.btn_QA.Size = new System.Drawing.Size(212, 62);
            this.btn_QA.TabIndex = 3;
            this.btn_QA.Text = "會員問答";
            this.btn_QA.UseVisualStyleBackColor = true;
            this.btn_QA.Click += new System.EventHandler(this.btn_QA_Click);
            // 
            // btn_SendMail
            // 
            this.btn_SendMail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_SendMail.Location = new System.Drawing.Point(32, 117);
            this.btn_SendMail.Name = "btn_SendMail";
            this.btn_SendMail.Size = new System.Drawing.Size(212, 62);
            this.btn_SendMail.TabIndex = 1;
            this.btn_SendMail.Text = "驗證信寄發";
            this.btn_SendMail.UseVisualStyleBackColor = true;
            this.btn_SendMail.Click += new System.EventHandler(this.btn_SendMail_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(624, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 40);
            this.label4.TabIndex = 15;
            this.label4.Text = "會員管理";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_QA);
            this.panel3.Controls.Add(this.btn_SendMail);
            this.panel3.Controls.Add(this.btn_UpdMemInfo);
            this.panel3.Location = new System.Drawing.Point(632, 226);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 358);
            this.panel3.TabIndex = 14;
            // 
            // btn_UpdMemInfo
            // 
            this.btn_UpdMemInfo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_UpdMemInfo.Location = new System.Drawing.Point(32, 28);
            this.btn_UpdMemInfo.Name = "btn_UpdMemInfo";
            this.btn_UpdMemInfo.Size = new System.Drawing.Size(212, 62);
            this.btn_UpdMemInfo.TabIndex = 0;
            this.btn_UpdMemInfo.Text = "會員資料修改";
            this.btn_UpdMemInfo.UseVisualStyleBackColor = true;
            this.btn_UpdMemInfo.Click += new System.EventHandler(this.btn_UpdMem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(28, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 40);
            this.label3.TabIndex = 13;
            this.label3.Text = "食譜管理";
            // 
            // btn_HideComment
            // 
            this.btn_HideComment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_HideComment.Location = new System.Drawing.Point(32, 117);
            this.btn_HideComment.Name = "btn_HideComment";
            this.btn_HideComment.Size = new System.Drawing.Size(212, 62);
            this.btn_HideComment.TabIndex = 3;
            this.btn_HideComment.Text = "屏蔽評論";
            this.btn_HideComment.UseVisualStyleBackColor = true;
            this.btn_HideComment.Click += new System.EventHandler(this.btn_HideComment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(324, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 40);
            this.label2.TabIndex = 12;
            this.label2.Text = "食材商城管理";
            // 
            // btn_HideRecipe
            // 
            this.btn_HideRecipe.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_HideRecipe.Location = new System.Drawing.Point(32, 28);
            this.btn_HideRecipe.Name = "btn_HideRecipe";
            this.btn_HideRecipe.Size = new System.Drawing.Size(212, 62);
            this.btn_HideRecipe.TabIndex = 1;
            this.btn_HideRecipe.Text = "屏蔽食譜";
            this.btn_HideRecipe.UseVisualStyleBackColor = true;
            this.btn_HideRecipe.Click += new System.EventHandler(this.btn_HideRecipe_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_HashTagManage);
            this.panel2.Controls.Add(this.btn_HideComment);
            this.panel2.Controls.Add(this.btn_HideRecipe);
            this.panel2.Location = new System.Drawing.Point(36, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 358);
            this.panel2.TabIndex = 11;
            // 
            // btn_HashTagManage
            // 
            this.btn_HashTagManage.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_HashTagManage.Location = new System.Drawing.Point(32, 210);
            this.btn_HashTagManage.Name = "btn_HashTagManage";
            this.btn_HashTagManage.Size = new System.Drawing.Size(212, 62);
            this.btn_HashTagManage.TabIndex = 4;
            this.btn_HashTagManage.Text = "HashTag管理";
            this.btn_HashTagManage.UseVisualStyleBackColor = true;
            this.btn_HashTagManage.Click += new System.EventHandler(this.btn_HashTagManage_Click);
            // 
            // btn_SrhOrder
            // 
            this.btn_SrhOrder.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_SrhOrder.Location = new System.Drawing.Point(39, 117);
            this.btn_SrhOrder.Name = "btn_SrhOrder";
            this.btn_SrhOrder.Size = new System.Drawing.Size(212, 62);
            this.btn_SrhOrder.TabIndex = 3;
            this.btn_SrhOrder.Text = "搜尋訂單";
            this.btn_SrhOrder.UseVisualStyleBackColor = true;
            this.btn_SrhOrder.Click += new System.EventHandler(this.btn_SearchOrder_Click);
            // 
            // btn_UpdDelIng
            // 
            this.btn_UpdDelIng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_UpdDelIng.Location = new System.Drawing.Point(32, 117);
            this.btn_UpdDelIng.Name = "btn_UpdDelIng";
            this.btn_UpdDelIng.Size = new System.Drawing.Size(212, 62);
            this.btn_UpdDelIng.TabIndex = 1;
            this.btn_UpdDelIng.Text = "刪修食材";
            this.btn_UpdDelIng.UseVisualStyleBackColor = true;
            this.btn_UpdDelIng.Click += new System.EventHandler(this.btn_UpdIng_Click);
            // 
            // btn_AddIng
            // 
            this.btn_AddIng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_AddIng.Location = new System.Drawing.Point(32, 28);
            this.btn_AddIng.Name = "btn_AddIng";
            this.btn_AddIng.Size = new System.Drawing.Size(212, 62);
            this.btn_AddIng.TabIndex = 0;
            this.btn_AddIng.Text = "新增食材";
            this.btn_AddIng.UseVisualStyleBackColor = true;
            this.btn_AddIng.Click += new System.EventHandler(this.btnAddIng_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ManageIngRecipe);
            this.panel1.Controls.Add(this.btn_UpdDelIng);
            this.panel1.Controls.Add(this.btn_AddIng);
            this.panel1.Location = new System.Drawing.Point(332, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 358);
            this.panel1.TabIndex = 10;
            // 
            // btn_ManageIngRecipe
            // 
            this.btn_ManageIngRecipe.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ManageIngRecipe.Location = new System.Drawing.Point(32, 210);
            this.btn_ManageIngRecipe.Name = "btn_ManageIngRecipe";
            this.btn_ManageIngRecipe.Size = new System.Drawing.Size(212, 62);
            this.btn_ManageIngRecipe.TabIndex = 2;
            this.btn_ManageIngRecipe.Text = "食材食譜管理";
            this.btn_ManageIngRecipe.UseVisualStyleBackColor = true;
            this.btn_ManageIngRecipe.Click += new System.EventHandler(this.btn_ManageIngRecipe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(256, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "管理者頁面";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(918, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 40);
            this.label5.TabIndex = 18;
            this.label5.Text = "訂單管理";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_SrhOrder);
            this.panel4.Controls.Add(this.btn_OrderManage);
            this.panel4.Location = new System.Drawing.Point(926, 226);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(278, 358);
            this.panel4.TabIndex = 17;
            // 
            // btn_OrderManage
            // 
            this.btn_OrderManage.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_OrderManage.Location = new System.Drawing.Point(39, 28);
            this.btn_OrderManage.Name = "btn_OrderManage";
            this.btn_OrderManage.Size = new System.Drawing.Size(212, 62);
            this.btn_OrderManage.TabIndex = 3;
            this.btn_OrderManage.Text = "訂單管理";
            this.btn_OrderManage.UseVisualStyleBackColor = true;
            this.btn_OrderManage.Click += new System.EventHandler(this.btn_OrderManage_Click);
            // 
            // lb_adminname
            // 
            this.lb_adminname.AutoSize = true;
            this.lb_adminname.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_adminname.Location = new System.Drawing.Point(274, 80);
            this.lb_adminname.Name = "lb_adminname";
            this.lb_adminname.Size = new System.Drawing.Size(98, 36);
            this.lb_adminname.TabIndex = 19;
            this.lb_adminname.Text = "label6";
            // 
            // FrmManageHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 608);
            this.Controls.Add(this.lb_adminname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmManageHomePage";
            this.Text = "ManageForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_QA;
        private System.Windows.Forms.Button btn_SendMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_UpdMemInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_HideComment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_HideRecipe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_SrhOrder;
        private System.Windows.Forms.Button btn_UpdDelIng;
        private System.Windows.Forms.Button btn_AddIng;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_OrderManage;
        private System.Windows.Forms.Label lb_adminname;
        private System.Windows.Forms.Button btn_HashTagManage;
        private System.Windows.Forms.Button btn_ManageIngRecipe;
    }
}