
namespace project
{
    partial class EmailConfirm
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
            this.btn_Back = new System.Windows.Forms.Button();
            this.lb_Sended = new System.Windows.Forms.Label();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_SendEmail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_EmailConfirm = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Back.Location = new System.Drawing.Point(451, 291);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(184, 46);
            this.btn_Back.TabIndex = 11;
            this.btn_Back.Text = "返回個人頁面";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lb_Sended
            // 
            this.lb_Sended.AutoSize = true;
            this.lb_Sended.BackColor = System.Drawing.Color.Transparent;
            this.lb_Sended.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Sended.ForeColor = System.Drawing.Color.SteelBlue;
            this.lb_Sended.Location = new System.Drawing.Point(264, 261);
            this.lb_Sended.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Sended.Name = "lb_Sended";
            this.lb_Sended.Size = new System.Drawing.Size(112, 22);
            this.lb_Sended.TabIndex = 10;
            this.lb_Sended.Text = "認證信已發送";
            this.lb_Sended.Visible = false;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.Color.Transparent;
            this.btn_Confirm.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Confirm.Location = new System.Drawing.Point(268, 291);
            this.btn_Confirm.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(179, 49);
            this.btn_Confirm.TabIndex = 9;
            this.btn_Confirm.Text = "確認";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_SendEmail
            // 
            this.btn_SendEmail.BackColor = System.Drawing.Color.Transparent;
            this.btn_SendEmail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_SendEmail.Location = new System.Drawing.Point(643, 221);
            this.btn_SendEmail.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SendEmail.Name = "btn_SendEmail";
            this.btn_SendEmail.Size = new System.Drawing.Size(240, 39);
            this.btn_SendEmail.TabIndex = 8;
            this.btn_SendEmail.Text = "發送認證信";
            this.btn_SendEmail.UseVisualStyleBackColor = false;
            this.btn_SendEmail.Click += new System.EventHandler(this.btn_SendEmail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(75, 224);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "E-mail認證碼 : ";
            // 
            // tb_EmailConfirm
            // 
            this.tb_EmailConfirm.Enabled = false;
            this.tb_EmailConfirm.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_EmailConfirm.Location = new System.Drawing.Point(264, 221);
            this.tb_EmailConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.tb_EmailConfirm.Name = "tb_EmailConfirm";
            this.tb_EmailConfirm.Size = new System.Drawing.Size(369, 34);
            this.tb_EmailConfirm.TabIndex = 6;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.BackColor = System.Drawing.Color.Transparent;
            this.lb_email.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_email.ForeColor = System.Drawing.Color.Red;
            this.lb_email.Location = new System.Drawing.Point(265, 265);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(67, 15);
            this.lb_email.TabIndex = 50;
            this.lb_email.Text = "錯誤訊息";
            this.lb_email.Visible = false;
            // 
            // EmailConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lb_Sended);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.btn_SendEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_EmailConfirm);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmailConfirm";
            this.Text = "EmailConfirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lb_Sended;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_SendEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_EmailConfirm;
        private System.Windows.Forms.Label lb_email;
    }
}