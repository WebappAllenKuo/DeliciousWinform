namespace project.Form_Chia
{
    partial class FrmGetMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGetMember));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_SrhCondition = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Srh = new System.Windows.Forms.Button();
            this.dgv_MemInfo = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_adminname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MemInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(228, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "會員資料搜尋";
            // 
            // tb_SrhCondition
            // 
            this.tb_SrhCondition.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_SrhCondition.Location = new System.Drawing.Point(240, 74);
            this.tb_SrhCondition.Name = "tb_SrhCondition";
            this.tb_SrhCondition.Size = new System.Drawing.Size(227, 36);
            this.tb_SrhCondition.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(235, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "僅供手機號碼/會員名稱/Email查詢";
            // 
            // btn_Srh
            // 
            this.btn_Srh.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Srh.Location = new System.Drawing.Point(486, 74);
            this.btn_Srh.Name = "btn_Srh";
            this.btn_Srh.Size = new System.Drawing.Size(110, 42);
            this.btn_Srh.TabIndex = 3;
            this.btn_Srh.Text = "搜尋";
            this.btn_Srh.UseVisualStyleBackColor = true;
            this.btn_Srh.Click += new System.EventHandler(this.btn_Srh_Click);
            // 
            // dgv_MemInfo
            // 
            this.dgv_MemInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MemInfo.Location = new System.Drawing.Point(22, 164);
            this.dgv_MemInfo.Name = "dgv_MemInfo";
            this.dgv_MemInfo.RowHeadersWidth = 62;
            this.dgv_MemInfo.RowTemplate.Height = 31;
            this.dgv_MemInfo.Size = new System.Drawing.Size(1019, 267);
            this.dgv_MemInfo.TabIndex = 4;
            this.dgv_MemInfo.DoubleClick += new System.EventHandler(this.dgv_Member_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 125;
            this.pictureBox1.TabStop = false;
            // 
            // lb_adminname
            // 
            this.lb_adminname.AutoSize = true;
            this.lb_adminname.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_adminname.Location = new System.Drawing.Point(453, 16);
            this.lb_adminname.Name = "lb_adminname";
            this.lb_adminname.Size = new System.Drawing.Size(85, 31);
            this.lb_adminname.TabIndex = 126;
            this.lb_adminname.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(28, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 25);
            this.label3.TabIndex = 127;
            this.label3.Text = "雙擊兩下即可修改會員資料";
            // 
            // FrmGetMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 490);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_adminname);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv_MemInfo);
            this.Controls.Add(this.btn_Srh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_SrhCondition);
            this.Controls.Add(this.label1);
            this.Name = "FrmGetMember";
            this.Text = "GetMember";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MemInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_SrhCondition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Srh;
        private System.Windows.Forms.DataGridView dgv_MemInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_adminname;
        private System.Windows.Forms.Label label3;
    }
}