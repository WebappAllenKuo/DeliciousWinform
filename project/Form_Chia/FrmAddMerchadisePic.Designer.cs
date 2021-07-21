namespace project.Form_Chia
{
    partial class FrmAddMerchadisePic
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
            this.btn_uppic = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.bt_udpics = new System.Windows.Forms.Button();
            this.flp_PicsForMerch = new System.Windows.Forms.FlowLayoutPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lb_IngName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_uppic
            // 
            this.btn_uppic.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_uppic.Location = new System.Drawing.Point(331, 20);
            this.btn_uppic.Name = "btn_uppic";
            this.btn_uppic.Size = new System.Drawing.Size(144, 39);
            this.btn_uppic.TabIndex = 18;
            this.btn_uppic.Text = "上傳圖片";
            this.btn_uppic.UseVisualStyleBackColor = true;
            this.btn_uppic.Click += new System.EventHandler(this.bt_uppic_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(41, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 36);
            this.label9.TabIndex = 17;
            this.label9.Text = "商品";
            // 
            // bt_udpics
            // 
            this.bt_udpics.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt_udpics.Location = new System.Drawing.Point(32, 383);
            this.bt_udpics.Name = "bt_udpics";
            this.bt_udpics.Size = new System.Drawing.Size(212, 54);
            this.bt_udpics.TabIndex = 19;
            this.bt_udpics.Text = "確認上傳";
            this.bt_udpics.UseVisualStyleBackColor = true;
            this.bt_udpics.Click += new System.EventHandler(this.bt_udpics_Click);
            // 
            // flp_PicsForMerch
            // 
            this.flp_PicsForMerch.AutoScroll = true;
            this.flp_PicsForMerch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flp_PicsForMerch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_PicsForMerch.Location = new System.Drawing.Point(12, 70);
            this.flp_PicsForMerch.Name = "flp_PicsForMerch";
            this.flp_PicsForMerch.Size = new System.Drawing.Size(469, 295);
            this.flp_PicsForMerch.TabIndex = 20;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // lb_IngName
            // 
            this.lb_IngName.AutoSize = true;
            this.lb_IngName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_IngName.Location = new System.Drawing.Point(119, 33);
            this.lb_IngName.Name = "lb_IngName";
            this.lb_IngName.Size = new System.Drawing.Size(190, 24);
            this.lb_IngName.TabIndex = 21;
            this.lb_IngName.Text = "Merchadise Name";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(261, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 54);
            this.button1.TabIndex = 22;
            this.button1.Text = "取消上傳";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btncancelupd_Click);
            // 
            // FrmAddMerchadisePic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_IngName);
            this.Controls.Add(this.flp_PicsForMerch);
            this.Controls.Add(this.bt_udpics);
            this.Controls.Add(this.btn_uppic);
            this.Controls.Add(this.label9);
            this.Name = "FrmAddMerchadisePic";
            this.Text = "AddPicforIng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_uppic;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_udpics;
        private System.Windows.Forms.FlowLayoutPanel flp_PicsForMerch;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lb_IngName;
        private System.Windows.Forms.Button button1;
    }
}