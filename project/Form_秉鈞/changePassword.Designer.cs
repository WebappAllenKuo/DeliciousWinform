namespace project
{
    partial class changePassword
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
            this.lb_passwordError = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_ChangePassword = new System.Windows.Forms.Button();
            this.tb_newPassword1 = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_oldPassword = new System.Windows.Forms.TextBox();
            this.lb_account = new System.Windows.Forms.Label();
            this.tb_newPassword2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_passwordError
            // 
            this.lb_passwordError.AutoSize = true;
            this.lb_passwordError.BackColor = System.Drawing.Color.Transparent;
            this.lb_passwordError.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_passwordError.ForeColor = System.Drawing.Color.Red;
            this.lb_passwordError.Location = new System.Drawing.Point(231, 282);
            this.lb_passwordError.Name = "lb_passwordError";
            this.lb_passwordError.Size = new System.Drawing.Size(67, 15);
            this.lb_passwordError.TabIndex = 57;
            this.lb_passwordError.Text = "錯誤訊息";
            this.lb_passwordError.Visible = false;
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Back.Location = new System.Drawing.Point(431, 314);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(133, 41);
            this.btn_Back.TabIndex = 55;
            this.btn_Back.Text = "返回個人頁面";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ChangePassword.Location = new System.Drawing.Point(234, 314);
            this.btn_ChangePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.Size = new System.Drawing.Size(107, 41);
            this.btn_ChangePassword.TabIndex = 54;
            this.btn_ChangePassword.Text = "確認更改";
            this.btn_ChangePassword.UseVisualStyleBackColor = true;
            this.btn_ChangePassword.Click += new System.EventHandler(this.btn_ChangePassword_Click);
            // 
            // tb_newPassword1
            // 
            this.tb_newPassword1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_newPassword1.Location = new System.Drawing.Point(233, 142);
            this.tb_newPassword1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_newPassword1.Name = "tb_newPassword1";
            this.tb_newPassword1.PasswordChar = '●';
            this.tb_newPassword1.Size = new System.Drawing.Size(329, 38);
            this.tb_newPassword1.TabIndex = 53;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_password.Location = new System.Drawing.Point(229, 118);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(95, 22);
            this.lb_password.TabIndex = 52;
            this.lb_password.Text = "設定新密碼";
            // 
            // tb_oldPassword
            // 
            this.tb_oldPassword.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_oldPassword.Location = new System.Drawing.Point(233, 56);
            this.tb_oldPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_oldPassword.Name = "tb_oldPassword";
            this.tb_oldPassword.PasswordChar = '●';
            this.tb_oldPassword.Size = new System.Drawing.Size(329, 38);
            this.tb_oldPassword.TabIndex = 51;
            // 
            // lb_account
            // 
            this.lb_account.AutoSize = true;
            this.lb_account.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_account.Location = new System.Drawing.Point(229, 31);
            this.lb_account.Name = "lb_account";
            this.lb_account.Size = new System.Drawing.Size(112, 22);
            this.lb_account.TabIndex = 50;
            this.lb_account.Text = "請輸入舊密碼";
            // 
            // tb_newPassword2
            // 
            this.tb_newPassword2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_newPassword2.Location = new System.Drawing.Point(233, 236);
            this.tb_newPassword2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_newPassword2.Name = "tb_newPassword2";
            this.tb_newPassword2.PasswordChar = '●';
            this.tb_newPassword2.Size = new System.Drawing.Size(329, 38);
            this.tb_newPassword2.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(229, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 59;
            this.label4.Text = "確認新密碼";
            // 
            // changePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_newPassword2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_passwordError);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_ChangePassword);
            this.Controls.Add(this.tb_newPassword1);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.tb_oldPassword);
            this.Controls.Add(this.lb_account);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "changePassword";
            this.Text = "changePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_passwordError;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_ChangePassword;
        private System.Windows.Forms.TextBox tb_newPassword1;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox tb_oldPassword;
        private System.Windows.Forms.Label lb_account;
        private System.Windows.Forms.TextBox tb_newPassword2;
        private System.Windows.Forms.Label label4;
    }
}