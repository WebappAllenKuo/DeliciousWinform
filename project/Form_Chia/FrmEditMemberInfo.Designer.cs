namespace project.Form_Chia
{
    partial class FrmEditMemberInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditMemberInfo));
            this.btn_CheckEdit = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.pb_birthday = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.tb_cellnumber = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_Accountname = new System.Windows.Forms.TextBox();
            this.tb_Nickname = new System.Windows.Forms.TextBox();
            this.tb_MemberName = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_account = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Mid = new System.Windows.Forms.TextBox();
            this.btn_Finished = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CheckEdit
            // 
            this.btn_CheckEdit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_CheckEdit.Location = new System.Drawing.Point(634, 307);
            this.btn_CheckEdit.Name = "btn_CheckEdit";
            this.btn_CheckEdit.Size = new System.Drawing.Size(154, 46);
            this.btn_CheckEdit.TabIndex = 114;
            this.btn_CheckEdit.Tag = "6";
            this.btn_CheckEdit.Text = "完成修改";
            this.btn_CheckEdit.UseVisualStyleBackColor = true;
            this.btn_CheckEdit.Click += new System.EventHandler(this.btn_checkedit_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Edit.Location = new System.Drawing.Point(634, 242);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(154, 46);
            this.btn_Edit.TabIndex = 113;
            this.btn_Edit.Tag = "5";
            this.btn_Edit.Text = "修改";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // pb_birthday
            // 
            this.pb_birthday.CalendarFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pb_birthday.Enabled = false;
            this.pb_birthday.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pb_birthday.Location = new System.Drawing.Point(343, 237);
            this.pb_birthday.Name = "pb_birthday";
            this.pb_birthday.Size = new System.Drawing.Size(278, 37);
            this.pb_birthday.TabIndex = 94;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label21.Location = new System.Drawing.Point(195, 244);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 31);
            this.label21.TabIndex = 102;
            this.label21.Text = "生日";
            // 
            // tb_cellnumber
            // 
            this.tb_cellnumber.Enabled = false;
            this.tb_cellnumber.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_cellnumber.Location = new System.Drawing.Point(341, 399);
            this.tb_cellnumber.MaxLength = 10;
            this.tb_cellnumber.Name = "tb_cellnumber";
            this.tb_cellnumber.Size = new System.Drawing.Size(280, 34);
            this.tb_cellnumber.TabIndex = 100;
            this.tb_cellnumber.Tag = "6";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label19.Location = new System.Drawing.Point(195, 406);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(110, 31);
            this.label19.TabIndex = 99;
            this.label19.Text = "手機號碼";
            // 
            // tb_email
            // 
            this.tb_email.Enabled = false;
            this.tb_email.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_email.Location = new System.Drawing.Point(341, 348);
            this.tb_email.MaxLength = 255;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(280, 34);
            this.tb_email.TabIndex = 93;
            this.tb_email.Tag = "5";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(195, 355);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 31);
            this.label14.TabIndex = 92;
            this.label14.Text = "E-mail";
            // 
            // cb_gender
            // 
            this.cb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_gender.Enabled = false;
            this.cb_gender.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "男",
            "女",
            "不願透漏"});
            this.cb_gender.Location = new System.Drawing.Point(341, 300);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(280, 36);
            this.cb_gender.TabIndex = 91;
            this.cb_gender.Tag = "4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(195, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 31);
            this.label11.TabIndex = 90;
            this.label11.Text = "性別";
            // 
            // tb_Accountname
            // 
            this.tb_Accountname.Enabled = false;
            this.tb_Accountname.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Accountname.Location = new System.Drawing.Point(343, 187);
            this.tb_Accountname.Name = "tb_Accountname";
            this.tb_Accountname.Size = new System.Drawing.Size(278, 37);
            this.tb_Accountname.TabIndex = 89;
            this.tb_Accountname.Tag = "3";
            // 
            // tb_Nickname
            // 
            this.tb_Nickname.Enabled = false;
            this.tb_Nickname.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Nickname.Location = new System.Drawing.Point(341, 135);
            this.tb_Nickname.MaxLength = 15;
            this.tb_Nickname.Name = "tb_Nickname";
            this.tb_Nickname.Size = new System.Drawing.Size(280, 37);
            this.tb_Nickname.TabIndex = 88;
            this.tb_Nickname.Tag = "2";
            // 
            // tb_MemberName
            // 
            this.tb_MemberName.Enabled = false;
            this.tb_MemberName.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_MemberName.Location = new System.Drawing.Point(343, 86);
            this.tb_MemberName.MaxLength = 4;
            this.tb_MemberName.Name = "tb_MemberName";
            this.tb_MemberName.Size = new System.Drawing.Size(278, 37);
            this.tb_MemberName.TabIndex = 87;
            this.tb_MemberName.Tag = "1";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_name.Location = new System.Drawing.Point(195, 93);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(110, 31);
            this.lb_name.TabIndex = 85;
            this.lb_name.Text = "會員姓名";
            // 
            // lb_account
            // 
            this.lb_account.AutoSize = true;
            this.lb_account.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_account.Location = new System.Drawing.Point(195, 194);
            this.lb_account.Name = "lb_account";
            this.lb_account.Size = new System.Drawing.Size(110, 31);
            this.lb_account.TabIndex = 84;
            this.lb_account.Text = "會員帳號";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(195, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 31);
            this.label2.TabIndex = 86;
            this.label2.Text = "暱稱";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(195, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 121;
            this.label1.Text = "會員編號";
            // 
            // tb_Mid
            // 
            this.tb_Mid.Enabled = false;
            this.tb_Mid.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Mid.Location = new System.Drawing.Point(341, 37);
            this.tb_Mid.Name = "tb_Mid";
            this.tb_Mid.Size = new System.Drawing.Size(280, 37);
            this.tb_Mid.TabIndex = 122;
            // 
            // btn_Finished
            // 
            this.btn_Finished.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Finished.Location = new System.Drawing.Point(634, 372);
            this.btn_Finished.Name = "btn_Finished";
            this.btn_Finished.Size = new System.Drawing.Size(154, 44);
            this.btn_Finished.TabIndex = 123;
            this.btn_Finished.Tag = "1";
            this.btn_Finished.Text = "結束修改";
            this.btn_Finished.UseVisualStyleBackColor = true;
            this.btn_Finished.Click += new System.EventHandler(this.btn_Finished_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 124;
            this.pictureBox1.TabStop = false;
            // 
            // FrmEditMemberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Finished);
            this.Controls.Add(this.tb_Mid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CheckEdit);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.pb_birthday);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.tb_cellnumber);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_Accountname);
            this.Controls.Add(this.tb_Nickname);
            this.Controls.Add(this.tb_MemberName);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.lb_account);
            this.Controls.Add(this.label2);
            this.Name = "FrmEditMemberInfo";
            this.Text = "EditMemberInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_CheckEdit;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.DateTimePicker pb_birthday;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tb_cellnumber;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_Accountname;
        private System.Windows.Forms.TextBox tb_Nickname;
        private System.Windows.Forms.TextBox tb_MemberName;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_account;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Mid;
        private System.Windows.Forms.Button btn_Finished;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}