namespace project.Form_Chia
{
    partial class FrmSendEmail
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSendEmail));
            this.dgv_MemberInfo = new System.Windows.Forms.DataGridView();
            this.btn_Srh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_SrhCondition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tb_AccountName = new System.Windows.Forms.TextBox();
            this.tb_MemberName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Send = new System.Windows.Forms.Button();
            this.tb_MID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_adminname = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MemberInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_MemberInfo
            // 
            this.dgv_MemberInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MemberInfo.Location = new System.Drawing.Point(226, 151);
            this.dgv_MemberInfo.Name = "dgv_MemberInfo";
            this.dgv_MemberInfo.RowHeadersWidth = 62;
            this.dgv_MemberInfo.RowTemplate.Height = 31;
            this.dgv_MemberInfo.Size = new System.Drawing.Size(437, 267);
            this.dgv_MemberInfo.TabIndex = 9;
            // 
            // btn_Srh
            // 
            this.btn_Srh.Location = new System.Drawing.Point(1085, 23);
            this.btn_Srh.Name = "btn_Srh";
            this.btn_Srh.Size = new System.Drawing.Size(92, 29);
            this.btn_Srh.TabIndex = 8;
            this.btn_Srh.Text = "搜尋";
            this.btn_Srh.UseVisualStyleBackColor = true;
            this.btn_Srh.Click += new System.EventHandler(this.btn_Srh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(831, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "僅供手機號碼/會員名稱/Email查詢";
            // 
            // tb_SrhCondition
            // 
            this.tb_SrhCondition.Location = new System.Drawing.Point(834, 23);
            this.tb_SrhCondition.Name = "tb_SrhCondition";
            this.tb_SrhCondition.Size = new System.Drawing.Size(227, 29);
            this.tb_SrhCondition.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(705, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "搜尋資料";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(42, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "會員帳號";
            // 
            // tb_AccountName
            // 
            this.tb_AccountName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_AccountName.Location = new System.Drawing.Point(178, 87);
            this.tb_AccountName.Name = "tb_AccountName";
            this.tb_AccountName.Size = new System.Drawing.Size(292, 39);
            this.tb_AccountName.TabIndex = 11;
            // 
            // tb_MemberName
            // 
            this.tb_MemberName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_MemberName.Location = new System.Drawing.Point(178, 140);
            this.tb_MemberName.Name = "tb_MemberName";
            this.tb_MemberName.Size = new System.Drawing.Size(292, 39);
            this.tb_MemberName.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(42, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "會員名稱";
            // 
            // tb_Email
            // 
            this.tb_Email.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Email.Location = new System.Drawing.Point(178, 191);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(292, 39);
            this.tb_Email.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(54, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email";
            // 
            // btn_Send
            // 
            this.btn_Send.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Send.Location = new System.Drawing.Point(710, 377);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(207, 52);
            this.btn_Send.TabIndex = 18;
            this.btn_Send.Text = "寄發認證信";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // tb_MID
            // 
            this.tb_MID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_MID.Location = new System.Drawing.Point(178, 34);
            this.tb_MID.Name = "tb_MID";
            this.tb_MID.Size = new System.Drawing.Size(292, 39);
            this.tb_MID.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(42, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 30);
            this.label7.TabIndex = 19;
            this.label7.Text = "會員編號";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 125;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_MID);
            this.groupBox1.Controls.Add(this.tb_AccountName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_MemberName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_Email);
            this.groupBox1.Location = new System.Drawing.Point(703, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 269);
            this.groupBox1.TabIndex = 126;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "會員聯絡資訊";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(220, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 36);
            this.label8.TabIndex = 127;
            this.label8.Text = "寄發驗證信";
            // 
            // lb_adminname
            // 
            this.lb_adminname.AutoSize = true;
            this.lb_adminname.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_adminname.Location = new System.Drawing.Point(234, 67);
            this.lb_adminname.Name = "lb_adminname";
            this.lb_adminname.Size = new System.Drawing.Size(81, 30);
            this.lb_adminname.TabIndex = 128;
            this.lb_adminname.Text = "label9";
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Close.Location = new System.Drawing.Point(947, 377);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(226, 52);
            this.btn_Close.TabIndex = 129;
            this.btn_Close.Text = "關閉";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // FrmSendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 450);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lb_adminname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.dgv_MemberInfo);
            this.Controls.Add(this.btn_Srh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_SrhCondition);
            this.Controls.Add(this.label1);
            this.Name = "FrmSendEmail";
            this.Text = "SendEmail";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MemberInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_MemberInfo;
        private System.Windows.Forms.Button btn_Srh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_SrhCondition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_AccountName;
        private System.Windows.Forms.TextBox tb_MemberName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox tb_MID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_adminname;
        private System.Windows.Forms.Button btn_Close;
    }
}