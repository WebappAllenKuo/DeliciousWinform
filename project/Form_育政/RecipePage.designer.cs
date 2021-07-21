
namespace Delicious_Kashir
{
    partial class RecipePage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pb_RecipeIMG = new System.Windows.Forms.PictureBox();
            this.dgv_Step = new System.Windows.Forms.DataGridView();
            this.lb_Recipename = new System.Windows.Forms.Label();
            this.btn_Like = new System.Windows.Forms.Button();
            this.btn_Favorites = new System.Windows.Forms.Button();
            this.btn_Share = new System.Windows.Forms.Button();
            this.lb_Posttime = new System.Windows.Forms.Label();
            this.lb_member = new System.Windows.Forms.Label();
            this.lb_Lable1 = new System.Windows.Forms.Label();
            this.lb_Lable2 = new System.Windows.Forms.Label();
            this.lb_View = new System.Windows.Forms.Label();
            this.lb_Howmany = new System.Windows.Forms.Label();
            this.lb_Time = new System.Windows.Forms.Label();
            this.btn_deleterecipe = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.tb_Comment = new System.Windows.Forms.TextBox();
            this.tb_CommentVideo = new System.Windows.Forms.TextBox();
            this.btn_SendComment = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_Report = new System.Windows.Forms.Button();
            this.tb_Ingredients = new System.Windows.Forms.TextBox();
            this.tb_RecipeDescription = new System.Windows.Forms.TextBox();
            this.btn_LikeComment = new System.Windows.Forms.Button();
            this.btn_deComment = new System.Windows.Forms.Button();
            this.btn_ReportComment = new System.Windows.Forms.Button();
            this.btn_EditComment = new System.Windows.Forms.Button();
            this.dgv_comment = new System.Windows.Forms.DataGridView();
            this.pb_UploadIMG = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.移除圖片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pb_RecipeIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Step)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_comment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_UploadIMG)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_RecipeIMG
            // 
            this.pb_RecipeIMG.Location = new System.Drawing.Point(10, 10);
            this.pb_RecipeIMG.Name = "pb_RecipeIMG";
            this.pb_RecipeIMG.Size = new System.Drawing.Size(240, 240);
            this.pb_RecipeIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_RecipeIMG.TabIndex = 0;
            this.pb_RecipeIMG.TabStop = false;
            // 
            // dgv_Step
            // 
            this.dgv_Step.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Step.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Step.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Step.Location = new System.Drawing.Point(10, 368);
            this.dgv_Step.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Step.Name = "dgv_Step";
            this.dgv_Step.RowTemplate.Height = 24;
            this.dgv_Step.Size = new System.Drawing.Size(896, 223);
            this.dgv_Step.TabIndex = 1;
            // 
            // lb_Recipename
            // 
            this.lb_Recipename.AutoSize = true;
            this.lb_Recipename.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Recipename.Location = new System.Drawing.Point(297, 10);
            this.lb_Recipename.Name = "lb_Recipename";
            this.lb_Recipename.Size = new System.Drawing.Size(279, 47);
            this.lb_Recipename.TabIndex = 2;
            this.lb_Recipename.Text = "選定的食譜名稱";
            // 
            // btn_Like
            // 
            this.btn_Like.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Like.Location = new System.Drawing.Point(499, 79);
            this.btn_Like.Name = "btn_Like";
            this.btn_Like.Size = new System.Drawing.Size(77, 36);
            this.btn_Like.TabIndex = 5;
            this.btn_Like.Text = "❤︎喜歡";
            this.btn_Like.UseVisualStyleBackColor = true;
            this.btn_Like.Click += new System.EventHandler(this.btn_Like_Click);
            // 
            // btn_Favorites
            // 
            this.btn_Favorites.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Favorites.Location = new System.Drawing.Point(307, 79);
            this.btn_Favorites.Name = "btn_Favorites";
            this.btn_Favorites.Size = new System.Drawing.Size(77, 36);
            this.btn_Favorites.TabIndex = 6;
            this.btn_Favorites.Text = "🔖收藏";
            this.btn_Favorites.UseVisualStyleBackColor = true;
            this.btn_Favorites.Click += new System.EventHandler(this.btn_Favorites_Click);
            // 
            // btn_Share
            // 
            this.btn_Share.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Share.Location = new System.Drawing.Point(403, 79);
            this.btn_Share.Name = "btn_Share";
            this.btn_Share.Size = new System.Drawing.Size(77, 36);
            this.btn_Share.TabIndex = 7;
            this.btn_Share.Text = "🔗分享";
            this.btn_Share.UseVisualStyleBackColor = true;
            // 
            // lb_Posttime
            // 
            this.lb_Posttime.AutoSize = true;
            this.lb_Posttime.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Posttime.Location = new System.Drawing.Point(630, 323);
            this.lb_Posttime.Name = "lb_Posttime";
            this.lb_Posttime.Size = new System.Drawing.Size(86, 24);
            this.lb_Posttime.TabIndex = 11;
            this.lb_Posttime.Text = "投稿時間";
            // 
            // lb_member
            // 
            this.lb_member.AutoSize = true;
            this.lb_member.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_member.Location = new System.Drawing.Point(630, 282);
            this.lb_member.Name = "lb_member";
            this.lb_member.Size = new System.Drawing.Size(48, 24);
            this.lb_member.TabIndex = 12;
            this.lb_member.Text = "作者";
            // 
            // lb_Lable1
            // 
            this.lb_Lable1.AutoSize = true;
            this.lb_Lable1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Lable1.Location = new System.Drawing.Point(301, 269);
            this.lb_Lable1.Name = "lb_Lable1";
            this.lb_Lable1.Size = new System.Drawing.Size(69, 35);
            this.lb_Lable1.TabIndex = 13;
            this.lb_Lable1.Text = "份數";
            // 
            // lb_Lable2
            // 
            this.lb_Lable2.AutoSize = true;
            this.lb_Lable2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Lable2.Location = new System.Drawing.Point(440, 269);
            this.lb_Lable2.Name = "lb_Lable2";
            this.lb_Lable2.Size = new System.Drawing.Size(168, 35);
            this.lb_Lable2.TabIndex = 14;
            this.lb_Lable2.Text = "製作時間(分)";
            // 
            // lb_View
            // 
            this.lb_View.AutoSize = true;
            this.lb_View.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_View.Location = new System.Drawing.Point(710, 91);
            this.lb_View.Name = "lb_View";
            this.lb_View.Size = new System.Drawing.Size(32, 24);
            this.lb_View.TabIndex = 16;
            this.lb_View.Text = "👁︎";
            // 
            // lb_Howmany
            // 
            this.lb_Howmany.AutoSize = true;
            this.lb_Howmany.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Howmany.Location = new System.Drawing.Point(317, 323);
            this.lb_Howmany.Name = "lb_Howmany";
            this.lb_Howmany.Size = new System.Drawing.Size(31, 35);
            this.lb_Howmany.TabIndex = 17;
            this.lb_Howmany.Text = "0";
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Time.Location = new System.Drawing.Point(493, 323);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(31, 35);
            this.lb_Time.TabIndex = 18;
            this.lb_Time.Text = "0";
            // 
            // btn_deleterecipe
            // 
            this.btn_deleterecipe.Location = new System.Drawing.Point(745, 10);
            this.btn_deleterecipe.Name = "btn_deleterecipe";
            this.btn_deleterecipe.Size = new System.Drawing.Size(75, 23);
            this.btn_deleterecipe.TabIndex = 19;
            this.btn_deleterecipe.Text = "刪除";
            this.btn_deleterecipe.UseVisualStyleBackColor = true;
            this.btn_deleterecipe.Visible = false;
            this.btn_deleterecipe.Click += new System.EventHandler(this.btn_deleterecipe_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(826, 10);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 20;
            this.btn_update.Text = "編輯";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // tb_Comment
            // 
            this.tb_Comment.Location = new System.Drawing.Point(120, 280);
            this.tb_Comment.Multiline = true;
            this.tb_Comment.Name = "tb_Comment";
            this.tb_Comment.Size = new System.Drawing.Size(512, 91);
            this.tb_Comment.TabIndex = 22;
            // 
            // tb_CommentVideo
            // 
            this.tb_CommentVideo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_CommentVideo.Location = new System.Drawing.Point(638, 342);
            this.tb_CommentVideo.Name = "tb_CommentVideo";
            this.tb_CommentVideo.Size = new System.Drawing.Size(258, 29);
            this.tb_CommentVideo.TabIndex = 24;
            // 
            // btn_SendComment
            // 
            this.btn_SendComment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_SendComment.Location = new System.Drawing.Point(638, 280);
            this.btn_SendComment.Name = "btn_SendComment";
            this.btn_SendComment.Size = new System.Drawing.Size(258, 56);
            this.btn_SendComment.TabIndex = 25;
            this.btn_SendComment.Text = "發表評論";
            this.btn_SendComment.UseVisualStyleBackColor = true;
            this.btn_SendComment.Click += new System.EventHandler(this.btn_SendComment_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_Report);
            this.splitContainer1.Panel1.Controls.Add(this.tb_Ingredients);
            this.splitContainer1.Panel1.Controls.Add(this.tb_RecipeDescription);
            this.splitContainer1.Panel1.Controls.Add(this.pb_RecipeIMG);
            this.splitContainer1.Panel1.Controls.Add(this.btn_update);
            this.splitContainer1.Panel1.Controls.Add(this.dgv_Step);
            this.splitContainer1.Panel1.Controls.Add(this.btn_deleterecipe);
            this.splitContainer1.Panel1.Controls.Add(this.lb_Recipename);
            this.splitContainer1.Panel1.Controls.Add(this.lb_Time);
            this.splitContainer1.Panel1.Controls.Add(this.lb_Howmany);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Like);
            this.splitContainer1.Panel1.Controls.Add(this.lb_View);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Favorites);
            this.splitContainer1.Panel1.Controls.Add(this.lb_Lable2);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Share);
            this.splitContainer1.Panel1.Controls.Add(this.lb_Lable1);
            this.splitContainer1.Panel1.Controls.Add(this.lb_Posttime);
            this.splitContainer1.Panel1.Controls.Add(this.lb_member);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_LikeComment);
            this.splitContainer1.Panel2.Controls.Add(this.btn_deComment);
            this.splitContainer1.Panel2.Controls.Add(this.btn_ReportComment);
            this.splitContainer1.Panel2.Controls.Add(this.btn_EditComment);
            this.splitContainer1.Panel2.Controls.Add(this.dgv_comment);
            this.splitContainer1.Panel2.Controls.Add(this.pb_UploadIMG);
            this.splitContainer1.Panel2.Controls.Add(this.tb_Comment);
            this.splitContainer1.Panel2.Controls.Add(this.btn_SendComment);
            this.splitContainer1.Panel2.Controls.Add(this.tb_CommentVideo);
            this.splitContainer1.Size = new System.Drawing.Size(919, 992);
            this.splitContainer1.SplitterDistance = 603;
            this.splitContainer1.TabIndex = 27;
            // 
            // btn_Report
            // 
            this.btn_Report.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Report.Location = new System.Drawing.Point(596, 79);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(77, 36);
            this.btn_Report.TabIndex = 25;
            this.btn_Report.Text = "⚖檢舉";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // tb_Ingredients
            // 
            this.tb_Ingredients.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Ingredients.Location = new System.Drawing.Point(307, 137);
            this.tb_Ingredients.Multiline = true;
            this.tb_Ingredients.Name = "tb_Ingredients";
            this.tb_Ingredients.ReadOnly = true;
            this.tb_Ingredients.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb_Ingredients.Size = new System.Drawing.Size(563, 113);
            this.tb_Ingredients.TabIndex = 24;
            this.tb_Ingredients.Text = "食材區";
            // 
            // tb_RecipeDescription
            // 
            this.tb_RecipeDescription.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_RecipeDescription.Location = new System.Drawing.Point(10, 259);
            this.tb_RecipeDescription.Margin = new System.Windows.Forms.Padding(2);
            this.tb_RecipeDescription.Multiline = true;
            this.tb_RecipeDescription.Name = "tb_RecipeDescription";
            this.tb_RecipeDescription.ReadOnly = true;
            this.tb_RecipeDescription.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb_RecipeDescription.Size = new System.Drawing.Size(240, 105);
            this.tb_RecipeDescription.TabIndex = 23;
            this.tb_RecipeDescription.Text = "簡述";
            // 
            // btn_LikeComment
            // 
            this.btn_LikeComment.Enabled = false;
            this.btn_LikeComment.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_LikeComment.Location = new System.Drawing.Point(596, 13);
            this.btn_LikeComment.Name = "btn_LikeComment";
            this.btn_LikeComment.Size = new System.Drawing.Size(63, 23);
            this.btn_LikeComment.TabIndex = 29;
            this.btn_LikeComment.Text = "❤︎";
            this.btn_LikeComment.UseVisualStyleBackColor = true;
            this.btn_LikeComment.Click += new System.EventHandler(this.btn_LikeComment_Click);
            // 
            // btn_deComment
            // 
            this.btn_deComment.Enabled = false;
            this.btn_deComment.Location = new System.Drawing.Point(748, 13);
            this.btn_deComment.Name = "btn_deComment";
            this.btn_deComment.Size = new System.Drawing.Size(75, 23);
            this.btn_deComment.TabIndex = 28;
            this.btn_deComment.Text = "刪除";
            this.btn_deComment.UseVisualStyleBackColor = true;
            this.btn_deComment.Click += new System.EventHandler(this.btn_deComment_Click);
            // 
            // btn_ReportComment
            // 
            this.btn_ReportComment.Enabled = false;
            this.btn_ReportComment.Location = new System.Drawing.Point(829, 13);
            this.btn_ReportComment.Name = "btn_ReportComment";
            this.btn_ReportComment.Size = new System.Drawing.Size(75, 23);
            this.btn_ReportComment.TabIndex = 27;
            this.btn_ReportComment.Text = "檢舉";
            this.btn_ReportComment.UseVisualStyleBackColor = true;
            this.btn_ReportComment.Click += new System.EventHandler(this.btn_ReportComment_Click);
            // 
            // btn_EditComment
            // 
            this.btn_EditComment.Enabled = false;
            this.btn_EditComment.Location = new System.Drawing.Point(667, 13);
            this.btn_EditComment.Name = "btn_EditComment";
            this.btn_EditComment.Size = new System.Drawing.Size(75, 23);
            this.btn_EditComment.TabIndex = 26;
            this.btn_EditComment.Text = "編輯";
            this.btn_EditComment.UseVisualStyleBackColor = true;
            this.btn_EditComment.Click += new System.EventHandler(this.btn_EditComment_Click);
            // 
            // dgv_comment
            // 
            this.dgv_comment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_comment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_comment.Location = new System.Drawing.Point(10, 41);
            this.dgv_comment.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_comment.Name = "dgv_comment";
            this.dgv_comment.RowTemplate.Height = 24;
            this.dgv_comment.Size = new System.Drawing.Size(896, 222);
            this.dgv_comment.TabIndex = 21;
            this.dgv_comment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_comment_CellClick);
            // 
            // pb_UploadIMG
            // 
            this.pb_UploadIMG.ContextMenuStrip = this.contextMenuStrip1;
            this.pb_UploadIMG.Location = new System.Drawing.Point(11, 280);
            this.pb_UploadIMG.Margin = new System.Windows.Forms.Padding(2);
            this.pb_UploadIMG.Name = "pb_UploadIMG";
            this.pb_UploadIMG.Size = new System.Drawing.Size(91, 91);
            this.pb_UploadIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_UploadIMG.TabIndex = 22;
            this.pb_UploadIMG.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.移除圖片ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 26);
            // 
            // 移除圖片ToolStripMenuItem
            // 
            this.移除圖片ToolStripMenuItem.Name = "移除圖片ToolStripMenuItem";
            this.移除圖片ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.移除圖片ToolStripMenuItem.Text = "移除圖片";
            this.移除圖片ToolStripMenuItem.Click += new System.EventHandler(this.移除圖片ToolStripMenuItem_Click);
            // 
            // RecipePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(919, 992);
            this.Controls.Add(this.splitContainer1);
            this.Name = "RecipePage";
            this.Text = "RecipePage";
            this.Load += new System.EventHandler(this.RecipePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_RecipeIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Step)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_comment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_UploadIMG)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_RecipeIMG;
        private System.Windows.Forms.DataGridView dgv_Step;
        private System.Windows.Forms.Label lb_Recipename;
        private System.Windows.Forms.Button btn_Like;
        private System.Windows.Forms.Button btn_Favorites;
        private System.Windows.Forms.Button btn_Share;
        private System.Windows.Forms.Label lb_Posttime;
        private System.Windows.Forms.Label lb_member;
        private System.Windows.Forms.Label lb_Lable1;
        private System.Windows.Forms.Label lb_Lable2;
        private System.Windows.Forms.Label lb_View;
        private System.Windows.Forms.Label lb_Howmany;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.Button btn_deleterecipe;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox tb_Comment;
        private System.Windows.Forms.TextBox tb_CommentVideo;
        private System.Windows.Forms.Button btn_SendComment;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgv_comment;
        private System.Windows.Forms.PictureBox pb_UploadIMG;
        private System.Windows.Forms.TextBox tb_Ingredients;
        private System.Windows.Forms.TextBox tb_RecipeDescription;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_deComment;
        private System.Windows.Forms.Button btn_ReportComment;
        private System.Windows.Forms.Button btn_EditComment;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 移除圖片ToolStripMenuItem;
        private System.Windows.Forms.Button btn_LikeComment;
    }
}