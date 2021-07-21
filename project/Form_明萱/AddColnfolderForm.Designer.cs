
namespace project.Form_明萱
{
    partial class AddColnfolderForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_addcolnfolder = new System.Windows.Forms.Button();
            this.tb_addcolnfolder = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_yes = new System.Windows.Forms.Button();
            this.cb_colnsrhfolder = new System.Windows.Forms.ComboBox();
            this.lb_colnsrhfolder = new System.Windows.Forms.Label();
            this.lb_lkuser_rank = new System.Windows.Forms.Label();
            this.lb_lkname = new System.Windows.Forms.Label();
            this.lb_addintocoln = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_addcolnfolder);
            this.groupBox1.Controls.Add(this.tb_addcolnfolder);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_yes);
            this.groupBox1.Controls.Add(this.cb_colnsrhfolder);
            this.groupBox1.Controls.Add(this.lb_colnsrhfolder);
            this.groupBox1.Location = new System.Drawing.Point(56, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 349);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_addcolnfolder
            // 
            this.btn_addcolnfolder.Location = new System.Drawing.Point(370, 108);
            this.btn_addcolnfolder.Name = "btn_addcolnfolder";
            this.btn_addcolnfolder.Size = new System.Drawing.Size(115, 30);
            this.btn_addcolnfolder.TabIndex = 18;
            this.btn_addcolnfolder.Text = "新增收藏夾";
            this.btn_addcolnfolder.UseVisualStyleBackColor = true;
            this.btn_addcolnfolder.Click += new System.EventHandler(this.btn_addcolnfolder_Click);
            // 
            // tb_addcolnfolder
            // 
            this.tb_addcolnfolder.Location = new System.Drawing.Point(174, 108);
            this.tb_addcolnfolder.Name = "tb_addcolnfolder";
            this.tb_addcolnfolder.Size = new System.Drawing.Size(175, 27);
            this.tb_addcolnfolder.TabIndex = 19;
            this.tb_addcolnfolder.TextChanged += new System.EventHandler(this.tb_addcolnfolder_TextChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(174, 199);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(115, 30);
            this.btn_cancel.TabIndex = 21;
            this.btn_cancel.Text = "取消加入";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "新增收藏夾:";
            // 
            // btn_yes
            // 
            this.btn_yes.Location = new System.Drawing.Point(21, 199);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(115, 30);
            this.btn_yes.TabIndex = 20;
            this.btn_yes.Text = "確認加入";
            this.btn_yes.UseVisualStyleBackColor = true;
            this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
            // 
            // cb_colnsrhfolder
            // 
            this.cb_colnsrhfolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_colnsrhfolder.FormattingEnabled = true;
            this.cb_colnsrhfolder.Location = new System.Drawing.Point(174, 58);
            this.cb_colnsrhfolder.Name = "cb_colnsrhfolder";
            this.cb_colnsrhfolder.Size = new System.Drawing.Size(175, 24);
            this.cb_colnsrhfolder.TabIndex = 17;
            // 
            // lb_colnsrhfolder
            // 
            this.lb_colnsrhfolder.AutoSize = true;
            this.lb_colnsrhfolder.Location = new System.Drawing.Point(18, 61);
            this.lb_colnsrhfolder.Name = "lb_colnsrhfolder";
            this.lb_colnsrhfolder.Size = new System.Drawing.Size(140, 16);
            this.lb_colnsrhfolder.TabIndex = 12;
            this.lb_colnsrhfolder.Text = "加入至現有收藏夾:";
            // 
            // lb_lkuser_rank
            // 
            this.lb_lkuser_rank.AutoSize = true;
            this.lb_lkuser_rank.Location = new System.Drawing.Point(134, 18);
            this.lb_lkuser_rank.Name = "lb_lkuser_rank";
            this.lb_lkuser_rank.Size = new System.Drawing.Size(164, 16);
            this.lb_lkuser_rank.TabIndex = 5;
            this.lb_lkuser_rank.Text = "目前等級:見習廚師1級";
            // 
            // lb_lkname
            // 
            this.lb_lkname.AutoSize = true;
            this.lb_lkname.Location = new System.Drawing.Point(12, 18);
            this.lb_lkname.Name = "lb_lkname";
            this.lb_lkname.Size = new System.Drawing.Size(106, 16);
            this.lb_lkname.TabIndex = 4;
            this.lb_lkname.Text = "UserName您好";
            // 
            // lb_addintocoln
            // 
            this.lb_addintocoln.AutoSize = true;
            this.lb_addintocoln.Font = new System.Drawing.Font("新細明體", 19.93846F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_addintocoln.Location = new System.Drawing.Point(12, 50);
            this.lb_addintocoln.Name = "lb_addintocoln";
            this.lb_addintocoln.Size = new System.Drawing.Size(254, 36);
            this.lb_addintocoln.TabIndex = 6;
            this.lb_addintocoln.Text = "將xxx加入收藏";
            // 
            // AddColnfolderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_addintocoln);
            this.Controls.Add(this.lb_lkuser_rank);
            this.Controls.Add(this.lb_lkname);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddColnfolderForm";
            this.Text = "AddColnfolderForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_lkuser_rank;
        private System.Windows.Forms.Label lb_lkname;
        private System.Windows.Forms.Label lb_addintocoln;
        private System.Windows.Forms.TextBox tb_addcolnfolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addcolnfolder;
        private System.Windows.Forms.Label lb_colnsrhfolder;
        private System.Windows.Forms.ComboBox cb_colnsrhfolder;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_yes;
    }
}