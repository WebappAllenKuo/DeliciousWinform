namespace project
{
    partial class ForgetPassword
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
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lb_account = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.btn_SendPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_email.Location = new System.Drawing.Point(113, 99);
            this.tb_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(235, 32);
            this.tb_email.TabIndex = 2;
            // 
            // lb_account
            // 
            this.lb_account.AutoSize = true;
            this.lb_account.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_account.Location = new System.Drawing.Point(150, 34);
            this.lb_account.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_account.Name = "lb_account";
            this.lb_account.Size = new System.Drawing.Size(166, 28);
            this.lb_account.TabIndex = 3;
            this.lb_account.Text = "密碼重設驗證信";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(110, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "輸入您註冊的信箱";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.BackColor = System.Drawing.Color.Transparent;
            this.lb_password.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_password.ForeColor = System.Drawing.Color.Red;
            this.lb_password.Location = new System.Drawing.Point(111, 132);
            this.lb_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(53, 12);
            this.lb_password.TabIndex = 48;
            this.lb_password.Text = "錯誤訊息";
            this.lb_password.Visible = false;
            // 
            // btn_SendPassword
            // 
            this.btn_SendPassword.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_SendPassword.Location = new System.Drawing.Point(113, 146);
            this.btn_SendPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SendPassword.Name = "btn_SendPassword";
            this.btn_SendPassword.Size = new System.Drawing.Size(105, 33);
            this.btn_SendPassword.TabIndex = 49;
            this.btn_SendPassword.Text = "寄出臨時密碼";
            this.btn_SendPassword.UseVisualStyleBackColor = true;
            this.btn_SendPassword.Click += new System.EventHandler(this.btn_SendPassword_Click);
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 217);
            this.Controls.Add(this.btn_SendPassword);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_account);
            this.Controls.Add(this.tb_email);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ForgetPassword";
            this.Text = "忘記密碼";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lb_account;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Button btn_SendPassword;
    }
}