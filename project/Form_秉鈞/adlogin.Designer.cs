namespace project.Form_秉鈞
{
    partial class adlogin
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
            this.lb_PasswordError = new System.Windows.Forms.Label();
            this.lb_AccountError = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_account = new System.Windows.Forms.TextBox();
            this.lb_account = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_PasswordError
            // 
            this.lb_PasswordError.AutoSize = true;
            this.lb_PasswordError.BackColor = System.Drawing.Color.Transparent;
            this.lb_PasswordError.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_PasswordError.ForeColor = System.Drawing.Color.Red;
            this.lb_PasswordError.Location = new System.Drawing.Point(68, 214);
            this.lb_PasswordError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_PasswordError.Name = "lb_PasswordError";
            this.lb_PasswordError.Size = new System.Drawing.Size(53, 12);
            this.lb_PasswordError.TabIndex = 58;
            this.lb_PasswordError.Text = "錯誤訊息";
            this.lb_PasswordError.Visible = false;
            // 
            // lb_AccountError
            // 
            this.lb_AccountError.AutoSize = true;
            this.lb_AccountError.BackColor = System.Drawing.Color.Transparent;
            this.lb_AccountError.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_AccountError.ForeColor = System.Drawing.Color.Red;
            this.lb_AccountError.Location = new System.Drawing.Point(68, 145);
            this.lb_AccountError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_AccountError.Name = "lb_AccountError";
            this.lb_AccountError.Size = new System.Drawing.Size(53, 12);
            this.lb_AccountError.TabIndex = 57;
            this.lb_AccountError.Text = "錯誤訊息";
            this.lb_AccountError.Visible = false;
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_login.Location = new System.Drawing.Point(70, 237);
            this.btn_login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(117, 33);
            this.btn_login.TabIndex = 54;
            this.btn_login.Text = "登入";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_password.Location = new System.Drawing.Point(71, 182);
            this.tb_password.Margin = new System.Windows.Forms.Padding(2);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '●';
            this.tb_password.Size = new System.Drawing.Size(248, 32);
            this.tb_password.TabIndex = 53;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_password.Location = new System.Drawing.Point(68, 162);
            this.lb_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(64, 18);
            this.lb_password.TabIndex = 52;
            this.lb_password.Text = "輸入密碼";
            // 
            // tb_account
            // 
            this.tb_account.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_account.Location = new System.Drawing.Point(71, 112);
            this.tb_account.Margin = new System.Windows.Forms.Padding(2);
            this.tb_account.Name = "tb_account";
            this.tb_account.Size = new System.Drawing.Size(248, 32);
            this.tb_account.TabIndex = 51;
            // 
            // lb_account
            // 
            this.lb_account.AutoSize = true;
            this.lb_account.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_account.Location = new System.Drawing.Point(68, 92);
            this.lb_account.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_account.Name = "lb_account";
            this.lb_account.Size = new System.Drawing.Size(78, 18);
            this.lb_account.TabIndex = 50;
            this.lb_account.Text = "管理員帳號";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 44);
            this.label1.TabIndex = 59;
            this.label1.Text = "瘋廚網後台登入系統";
            // 
            // btn_register
            // 
            this.btn_register.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_register.Location = new System.Drawing.Point(209, 237);
            this.btn_register.Margin = new System.Windows.Forms.Padding(2);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(110, 33);
            this.btn_register.TabIndex = 60;
            this.btn_register.Text = "註冊";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // adlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 339);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_PasswordError);
            this.Controls.Add(this.lb_AccountError);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.tb_account);
            this.Controls.Add(this.lb_account);
            this.Name = "adlogin";
            this.Text = "adlogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_PasswordError;
        private System.Windows.Forms.Label lb_AccountError;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox tb_account;
        private System.Windows.Forms.Label lb_account;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_register;
    }
}