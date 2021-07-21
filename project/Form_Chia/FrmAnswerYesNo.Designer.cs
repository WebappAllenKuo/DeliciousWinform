namespace project.Form_Chia
{
    partial class FrmAnswerYesNo
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_IngName = new System.Windows.Forms.Label();
            this.btn_realdelete = new System.Windows.Forms.Button();
            this.btn_canceldel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "確定要刪除此筆資料嗎?";
            // 
            // lb_IngName
            // 
            this.lb_IngName.AutoSize = true;
            this.lb_IngName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_IngName.Location = new System.Drawing.Point(136, 96);
            this.lb_IngName.Name = "lb_IngName";
            this.lb_IngName.Size = new System.Drawing.Size(81, 30);
            this.lb_IngName.TabIndex = 1;
            this.lb_IngName.Text = "label2";
            // 
            // btn_realdelete
            // 
            this.btn_realdelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_realdelete.Location = new System.Drawing.Point(90, 209);
            this.btn_realdelete.Name = "btn_realdelete";
            this.btn_realdelete.Size = new System.Drawing.Size(127, 67);
            this.btn_realdelete.TabIndex = 2;
            this.btn_realdelete.Text = "確定刪除";
            this.btn_realdelete.UseVisualStyleBackColor = true;
            this.btn_realdelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_canceldel
            // 
            this.btn_canceldel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_canceldel.Location = new System.Drawing.Point(256, 209);
            this.btn_canceldel.Name = "btn_canceldel";
            this.btn_canceldel.Size = new System.Drawing.Size(131, 67);
            this.btn_canceldel.TabIndex = 3;
            this.btn_canceldel.Text = "取消刪除";
            this.btn_canceldel.UseVisualStyleBackColor = true;
            this.btn_canceldel.Click += new System.EventHandler(this.btn_canceldel_Click);
            // 
            // FrmAnswerYesNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 331);
            this.Controls.Add(this.btn_canceldel);
            this.Controls.Add(this.btn_realdelete);
            this.Controls.Add(this.lb_IngName);
            this.Controls.Add(this.label1);
            this.Name = "FrmAnswerYesNo";
            this.Text = "YesNo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_IngName;
        private System.Windows.Forms.Button btn_realdelete;
        private System.Windows.Forms.Button btn_canceldel;
    }
}