
namespace project.Form_明萱
{
    partial class LikeCollectionForm
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
            this.tabControl_LikeCollection = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_lkdelike = new System.Windows.Forms.Button();
            this.btn_lkaddtocoln = new System.Windows.Forms.Button();
            this.cb_lksearch = new System.Windows.Forms.ComboBox();
            this.lb_lksearch = new System.Windows.Forms.Label();
            this.btn_lksearch = new System.Windows.Forms.Button();
            this.lb_lkuser_rank = new System.Windows.Forms.Label();
            this.lb_lkname = new System.Windows.Forms.Label();
            this.dgv_like = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_updatecolnfolder = new System.Windows.Forms.Button();
            this.btn_delcolnfolder = new System.Windows.Forms.Button();
            this.tb_addcolnfolder = new System.Windows.Forms.TextBox();
            this.cb_colnsrhfolder = new System.Windows.Forms.ComboBox();
            this.lb_colnsrhfolder = new System.Windows.Forms.Label();
            this.dgv_coln = new System.Windows.Forms.DataGridView();
            this.btn_addcolnfolder = new System.Windows.Forms.Button();
            this.cb_colnsrhcgy = new System.Windows.Forms.ComboBox();
            this.lb_colnsrhcgy = new System.Windows.Forms.Label();
            this.lb_colmember_rank = new System.Windows.Forms.Label();
            this.lb_colname = new System.Windows.Forms.Label();
            this.tabControl_LikeCollection.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_like)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_coln)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_LikeCollection
            // 
            this.tabControl_LikeCollection.Controls.Add(this.tabPage1);
            this.tabControl_LikeCollection.Controls.Add(this.tabPage2);
            this.tabControl_LikeCollection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_LikeCollection.Location = new System.Drawing.Point(0, 0);
            this.tabControl_LikeCollection.Name = "tabControl_LikeCollection";
            this.tabControl_LikeCollection.SelectedIndex = 0;
            this.tabControl_LikeCollection.Size = new System.Drawing.Size(1146, 523);
            this.tabControl_LikeCollection.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_lkdelike);
            this.tabPage1.Controls.Add(this.btn_lkaddtocoln);
            this.tabPage1.Controls.Add(this.cb_lksearch);
            this.tabPage1.Controls.Add(this.lb_lksearch);
            this.tabPage1.Controls.Add(this.btn_lksearch);
            this.tabPage1.Controls.Add(this.lb_lkuser_rank);
            this.tabPage1.Controls.Add(this.lb_lkname);
            this.tabPage1.Controls.Add(this.dgv_like);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1138, 493);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "喜歡的食譜";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_lkdelike
            // 
            this.btn_lkdelike.Location = new System.Drawing.Point(1007, 75);
            this.btn_lkdelike.Name = "btn_lkdelike";
            this.btn_lkdelike.Size = new System.Drawing.Size(123, 30);
            this.btn_lkdelike.TabIndex = 8;
            this.btn_lkdelike.Text = "刪除喜歡";
            this.btn_lkdelike.UseVisualStyleBackColor = true;
            this.btn_lkdelike.Click += new System.EventHandler(this.btn_lkdelike_Click);
            // 
            // btn_lkaddtocoln
            // 
            this.btn_lkaddtocoln.Enabled = false;
            this.btn_lkaddtocoln.Location = new System.Drawing.Point(860, 77);
            this.btn_lkaddtocoln.Name = "btn_lkaddtocoln";
            this.btn_lkaddtocoln.Size = new System.Drawing.Size(123, 30);
            this.btn_lkaddtocoln.TabIndex = 7;
            this.btn_lkaddtocoln.Text = "加入至收藏";
            this.btn_lkaddtocoln.UseVisualStyleBackColor = true;
            this.btn_lkaddtocoln.Click += new System.EventHandler(this.btn_lkaddtocoln_Click);
            // 
            // cb_lksearch
            // 
            this.cb_lksearch.FormattingEnabled = true;
            this.cb_lksearch.Location = new System.Drawing.Point(64, 81);
            this.cb_lksearch.Name = "cb_lksearch";
            this.cb_lksearch.Size = new System.Drawing.Size(126, 24);
            this.cb_lksearch.TabIndex = 6;
            // 
            // lb_lksearch
            // 
            this.lb_lksearch.AutoSize = true;
            this.lb_lksearch.Location = new System.Drawing.Point(14, 84);
            this.lb_lksearch.Name = "lb_lksearch";
            this.lb_lksearch.Size = new System.Drawing.Size(44, 16);
            this.lb_lksearch.TabIndex = 5;
            this.lb_lksearch.Text = "搜尋:";
            // 
            // btn_lksearch
            // 
            this.btn_lksearch.Location = new System.Drawing.Point(195, 77);
            this.btn_lksearch.Name = "btn_lksearch";
            this.btn_lksearch.Size = new System.Drawing.Size(111, 30);
            this.btn_lksearch.TabIndex = 4;
            this.btn_lksearch.Text = "搜尋";
            this.btn_lksearch.UseVisualStyleBackColor = true;
            this.btn_lksearch.Click += new System.EventHandler(this.btn_lksearch_Click);
            // 
            // lb_lkuser_rank
            // 
            this.lb_lkuser_rank.AutoSize = true;
            this.lb_lkuser_rank.Location = new System.Drawing.Point(136, 21);
            this.lb_lkuser_rank.Name = "lb_lkuser_rank";
            this.lb_lkuser_rank.Size = new System.Drawing.Size(164, 16);
            this.lb_lkuser_rank.TabIndex = 3;
            this.lb_lkuser_rank.Text = "目前等級:見習廚師1級";
            // 
            // lb_lkname
            // 
            this.lb_lkname.AutoSize = true;
            this.lb_lkname.Location = new System.Drawing.Point(14, 21);
            this.lb_lkname.Name = "lb_lkname";
            this.lb_lkname.Size = new System.Drawing.Size(106, 16);
            this.lb_lkname.TabIndex = 2;
            this.lb_lkname.Text = "UserName您好";
            // 
            // dgv_like
            // 
            this.dgv_like.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_like.Location = new System.Drawing.Point(0, 113);
            this.dgv_like.Name = "dgv_like";
            this.dgv_like.RowHeadersWidth = 56;
            this.dgv_like.RowTemplate.Height = 29;
            this.dgv_like.Size = new System.Drawing.Size(1138, 380);
            this.dgv_like.TabIndex = 0;
            this.dgv_like.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_like_CellClick);
            this.dgv_like.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_like_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_updatecolnfolder);
            this.tabPage2.Controls.Add(this.btn_delcolnfolder);
            this.tabPage2.Controls.Add(this.tb_addcolnfolder);
            this.tabPage2.Controls.Add(this.cb_colnsrhfolder);
            this.tabPage2.Controls.Add(this.lb_colnsrhfolder);
            this.tabPage2.Controls.Add(this.dgv_coln);
            this.tabPage2.Controls.Add(this.btn_addcolnfolder);
            this.tabPage2.Controls.Add(this.cb_colnsrhcgy);
            this.tabPage2.Controls.Add(this.lb_colnsrhcgy);
            this.tabPage2.Controls.Add(this.lb_colmember_rank);
            this.tabPage2.Controls.Add(this.lb_colname);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1138, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "收藏的食譜";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_updatecolnfolder
            // 
            this.btn_updatecolnfolder.Location = new System.Drawing.Point(123, 286);
            this.btn_updatecolnfolder.Name = "btn_updatecolnfolder";
            this.btn_updatecolnfolder.Size = new System.Drawing.Size(125, 30);
            this.btn_updatecolnfolder.TabIndex = 19;
            this.btn_updatecolnfolder.Text = "修改收藏夾";
            this.btn_updatecolnfolder.UseVisualStyleBackColor = true;
            // 
            // btn_delcolnfolder
            // 
            this.btn_delcolnfolder.Location = new System.Drawing.Point(123, 332);
            this.btn_delcolnfolder.Name = "btn_delcolnfolder";
            this.btn_delcolnfolder.Size = new System.Drawing.Size(125, 30);
            this.btn_delcolnfolder.TabIndex = 18;
            this.btn_delcolnfolder.Text = "刪除收藏夾";
            this.btn_delcolnfolder.UseVisualStyleBackColor = true;
            // 
            // tb_addcolnfolder
            // 
            this.tb_addcolnfolder.Location = new System.Drawing.Point(6, 175);
            this.tb_addcolnfolder.Name = "tb_addcolnfolder";
            this.tb_addcolnfolder.Size = new System.Drawing.Size(111, 27);
            this.tb_addcolnfolder.TabIndex = 17;
            // 
            // cb_colnsrhfolder
            // 
            this.cb_colnsrhfolder.FormattingEnabled = true;
            this.cb_colnsrhfolder.Location = new System.Drawing.Point(123, 242);
            this.cb_colnsrhfolder.Name = "cb_colnsrhfolder";
            this.cb_colnsrhfolder.Size = new System.Drawing.Size(126, 24);
            this.cb_colnsrhfolder.TabIndex = 16;
            this.cb_colnsrhfolder.SelectedIndexChanged += new System.EventHandler(this.cb_colnsrhfolder_SelectedIndexChanged);
            // 
            // lb_colnsrhfolder
            // 
            this.lb_colnsrhfolder.AutoSize = true;
            this.lb_colnsrhfolder.Location = new System.Drawing.Point(3, 245);
            this.lb_colnsrhfolder.Name = "lb_colnsrhfolder";
            this.lb_colnsrhfolder.Size = new System.Drawing.Size(92, 16);
            this.lb_colnsrhfolder.TabIndex = 15;
            this.lb_colnsrhfolder.Text = "搜尋資料夾:";
            // 
            // dgv_coln
            // 
            this.dgv_coln.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_coln.Location = new System.Drawing.Point(328, 63);
            this.dgv_coln.Name = "dgv_coln";
            this.dgv_coln.RowHeadersWidth = 56;
            this.dgv_coln.RowTemplate.Height = 29;
            this.dgv_coln.Size = new System.Drawing.Size(809, 429);
            this.dgv_coln.TabIndex = 14;
            this.dgv_coln.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_coln_CellContentClick);
            // 
            // btn_addcolnfolder
            // 
            this.btn_addcolnfolder.Location = new System.Drawing.Point(123, 175);
            this.btn_addcolnfolder.Name = "btn_addcolnfolder";
            this.btn_addcolnfolder.Size = new System.Drawing.Size(125, 30);
            this.btn_addcolnfolder.TabIndex = 12;
            this.btn_addcolnfolder.Text = "新增收藏夾";
            this.btn_addcolnfolder.UseVisualStyleBackColor = true;
            this.btn_addcolnfolder.Click += new System.EventHandler(this.btn_addcolnfolder_Click);
            // 
            // cb_colnsrhcgy
            // 
            this.cb_colnsrhcgy.FormattingEnabled = true;
            this.cb_colnsrhcgy.Location = new System.Drawing.Point(123, 111);
            this.cb_colnsrhcgy.Name = "cb_colnsrhcgy";
            this.cb_colnsrhcgy.Size = new System.Drawing.Size(126, 24);
            this.cb_colnsrhcgy.TabIndex = 11;
            this.cb_colnsrhcgy.SelectedIndexChanged += new System.EventHandler(this.cb_colnsrhcgy_SelectedIndexChanged);
            // 
            // lb_colnsrhcgy
            // 
            this.lb_colnsrhcgy.AutoSize = true;
            this.lb_colnsrhcgy.Location = new System.Drawing.Point(9, 114);
            this.lb_colnsrhcgy.Name = "lb_colnsrhcgy";
            this.lb_colnsrhcgy.Size = new System.Drawing.Size(108, 16);
            this.lb_colnsrhcgy.TabIndex = 10;
            this.lb_colnsrhcgy.Text = "搜尋收藏類別:";
            // 
            // lb_colmember_rank
            // 
            this.lb_colmember_rank.AutoSize = true;
            this.lb_colmember_rank.Location = new System.Drawing.Point(137, 23);
            this.lb_colmember_rank.Name = "lb_colmember_rank";
            this.lb_colmember_rank.Size = new System.Drawing.Size(100, 16);
            this.lb_colmember_rank.TabIndex = 5;
            this.lb_colmember_rank.Text = "目前等級:000";
            // 
            // lb_colname
            // 
            this.lb_colname.AutoSize = true;
            this.lb_colname.Location = new System.Drawing.Point(15, 23);
            this.lb_colname.Name = "lb_colname";
            this.lb_colname.Size = new System.Drawing.Size(106, 16);
            this.lb_colname.TabIndex = 4;
            this.lb_colname.Text = "UserName您好";
            // 
            // LikeCollectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 523);
            this.Controls.Add(this.tabControl_LikeCollection);
            this.Name = "LikeCollectionForm";
            this.Text = "LikeCollectionForm";
            this.tabControl_LikeCollection.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_like)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_coln)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_LikeCollection;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv_like;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lb_lkuser_rank;
        private System.Windows.Forms.Label lb_lkname;
        private System.Windows.Forms.Label lb_colmember_rank;
        private System.Windows.Forms.Label lb_colname;
        private System.Windows.Forms.Label lb_lksearch;
        private System.Windows.Forms.Button btn_lksearch;
        private System.Windows.Forms.ComboBox cb_lksearch;
        private System.Windows.Forms.Button btn_lkdelike;
        private System.Windows.Forms.Button btn_lkaddtocoln;
        private System.Windows.Forms.Button btn_updatecolnfolder;
        private System.Windows.Forms.Button btn_delcolnfolder;
        private System.Windows.Forms.TextBox tb_addcolnfolder;
        private System.Windows.Forms.ComboBox cb_colnsrhfolder;
        private System.Windows.Forms.Label lb_colnsrhfolder;
        private System.Windows.Forms.DataGridView dgv_coln;
        private System.Windows.Forms.Button btn_addcolnfolder;
        private System.Windows.Forms.ComboBox cb_colnsrhcgy;
        private System.Windows.Forms.Label lb_colnsrhcgy;
    }
}