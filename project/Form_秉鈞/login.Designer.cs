namespace project
{
    partial class login
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_account = new System.Windows.Forms.Label();
            this.tb_account = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_forget = new System.Windows.Forms.Button();
            this.lb_AccountError = new System.Windows.Forms.Label();
            this.lb_PasswordError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_account
            // 
            this.lb_account.AutoSize = true;
            this.lb_account.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_account.Location = new System.Drawing.Point(142, 64);
            this.lb_account.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_account.Name = "lb_account";
            this.lb_account.Size = new System.Drawing.Size(64, 18);
            this.lb_account.TabIndex = 0;
            this.lb_account.Text = "會員帳號";
            // 
            // tb_account
            // 
            this.tb_account.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_account.Location = new System.Drawing.Point(145, 84);
            this.tb_account.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_account.Name = "tb_account";
            this.tb_account.Size = new System.Drawing.Size(248, 32);
            this.tb_account.TabIndex = 1;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_password.Location = new System.Drawing.Point(145, 154);
            this.tb_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '●';
            this.tb_password.Size = new System.Drawing.Size(248, 32);
            this.tb_password.TabIndex = 3;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_password.Location = new System.Drawing.Point(142, 134);
            this.lb_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(64, 18);
            this.lb_password.TabIndex = 2;
            this.lb_password.Text = "輸入密碼";
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_login.Location = new System.Drawing.Point(145, 210);
            this.btn_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(80, 33);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "登入";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_register
            // 
            this.btn_register.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_register.Location = new System.Drawing.Point(229, 210);
            this.btn_register.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(80, 33);
            this.btn_register.TabIndex = 5;
            this.btn_register.Text = "註冊";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_forget
            // 
            this.btn_forget.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_forget.Location = new System.Drawing.Point(313, 210);
            this.btn_forget.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_forget.Name = "btn_forget";
            this.btn_forget.Size = new System.Drawing.Size(80, 33);
            this.btn_forget.TabIndex = 6;
            this.btn_forget.Text = "忘記密碼";
            this.btn_forget.UseVisualStyleBackColor = true;
            this.btn_forget.Click += new System.EventHandler(this.btn_forget_Click);
            // 
            // lb_AccountError
            // 
            this.lb_AccountError.AutoSize = true;
            this.lb_AccountError.BackColor = System.Drawing.Color.Transparent;
            this.lb_AccountError.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_AccountError.ForeColor = System.Drawing.Color.Red;
            this.lb_AccountError.Location = new System.Drawing.Point(142, 117);
            this.lb_AccountError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_AccountError.Name = "lb_AccountError";
            this.lb_AccountError.Size = new System.Drawing.Size(53, 12);
            this.lb_AccountError.TabIndex = 48;
            this.lb_AccountError.Text = "錯誤訊息";
            this.lb_AccountError.Visible = false;
            // 
            // lb_PasswordError
            // 
            this.lb_PasswordError.AutoSize = true;
            this.lb_PasswordError.BackColor = System.Drawing.Color.Transparent;
            this.lb_PasswordError.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_PasswordError.ForeColor = System.Drawing.Color.Red;
            this.lb_PasswordError.Location = new System.Drawing.Point(142, 186);
            this.lb_PasswordError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_PasswordError.Name = "lb_PasswordError";
            this.lb_PasswordError.Size = new System.Drawing.Size(53, 12);
            this.lb_PasswordError.TabIndex = 49;
            this.lb_PasswordError.Text = "錯誤訊息";
            this.lb_PasswordError.Visible = false;
            // 
            // login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 360);
            this.Controls.Add(this.lb_PasswordError);
            this.Controls.Add(this.lb_AccountError);
            this.Controls.Add(this.btn_forget);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.tb_account);
            this.Controls.Add(this.lb_account);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "login";
            this.Text = "登入";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_account;
        private System.Windows.Forms.TextBox tb_account;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_forget;
        private System.Windows.Forms.Label lb_AccountError;
        private System.Windows.Forms.Label lb_PasswordError;
    }
}

