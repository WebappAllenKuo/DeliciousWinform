
namespace project.Model_秉鈞
{
    partial class RecipeControl
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_recipePB = new System.Windows.Forms.PictureBox();
            this.lb_RecipeName = new System.Windows.Forms.Label();
            this.lb_NickName = new System.Windows.Forms.Label();
            this.lb_Views = new System.Windows.Forms.Label();
            this.lb_Like = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_recipePB)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_recipePB
            // 
            this.pb_recipePB.Location = new System.Drawing.Point(3, 4);
            this.pb_recipePB.Name = "pb_recipePB";
            this.pb_recipePB.Size = new System.Drawing.Size(144, 102);
            this.pb_recipePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_recipePB.TabIndex = 0;
            this.pb_recipePB.TabStop = false;
            this.pb_recipePB.Click += new System.EventHandler(this.pb_Click);
            // 
            // lb_RecipeName
            // 
            this.lb_RecipeName.AutoSize = true;
            this.lb_RecipeName.BackColor = System.Drawing.Color.Transparent;
            this.lb_RecipeName.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_RecipeName.ForeColor = System.Drawing.Color.White;
            this.lb_RecipeName.Location = new System.Drawing.Point(-1, 108);
            this.lb_RecipeName.Name = "lb_RecipeName";
            this.lb_RecipeName.Size = new System.Drawing.Size(53, 19);
            this.lb_RecipeName.TabIndex = 1;
            this.lb_RecipeName.Text = "label1";
            // 
            // lb_NickName
            // 
            this.lb_NickName.AutoSize = true;
            this.lb_NickName.BackColor = System.Drawing.Color.Transparent;
            this.lb_NickName.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_NickName.ForeColor = System.Drawing.Color.White;
            this.lb_NickName.Location = new System.Drawing.Point(1, 136);
            this.lb_NickName.Name = "lb_NickName";
            this.lb_NickName.Size = new System.Drawing.Size(33, 12);
            this.lb_NickName.TabIndex = 2;
            this.lb_NickName.Text = "label2";
            // 
            // lb_Views
            // 
            this.lb_Views.AutoSize = true;
            this.lb_Views.BackColor = System.Drawing.Color.Transparent;
            this.lb_Views.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Views.ForeColor = System.Drawing.Color.White;
            this.lb_Views.Location = new System.Drawing.Point(108, 108);
            this.lb_Views.Name = "lb_Views";
            this.lb_Views.Size = new System.Drawing.Size(43, 16);
            this.lb_Views.TabIndex = 3;
            this.lb_Views.Text = "label2";
            // 
            // lb_Like
            // 
            this.lb_Like.AutoSize = true;
            this.lb_Like.BackColor = System.Drawing.Color.Transparent;
            this.lb_Like.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Like.ForeColor = System.Drawing.Color.White;
            this.lb_Like.Location = new System.Drawing.Point(108, 132);
            this.lb_Like.Name = "lb_Like";
            this.lb_Like.Size = new System.Drawing.Size(43, 16);
            this.lb_Like.TabIndex = 4;
            this.lb_Like.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "❤︎";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "👁︎";
            // 
            // RecipeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Like);
            this.Controls.Add(this.lb_Views);
            this.Controls.Add(this.lb_NickName);
            this.Controls.Add(this.lb_RecipeName);
            this.Controls.Add(this.pb_recipePB);
            this.MaximumSize = new System.Drawing.Size(150, 150);
            this.MinimumSize = new System.Drawing.Size(150, 150);
            this.Name = "RecipeControl";
            ((System.ComponentModel.ISupportInitialize)(this.pb_recipePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_recipePB;
        private System.Windows.Forms.Label lb_RecipeName;
        private System.Windows.Forms.Label lb_NickName;
        private System.Windows.Forms.Label lb_Views;
        private System.Windows.Forms.Label lb_Like;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
