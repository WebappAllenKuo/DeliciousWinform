
namespace project.Form_明萱
{
    partial class MemberRankForm
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
            this.flp_recipecount = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_AddRecipeMemberRank = new System.Windows.Forms.Label();
            this.flp_hotrecipe = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_HotMemberRank = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flp_recipecount
            // 
            this.flp_recipecount.AutoScroll = true;
            this.flp_recipecount.Location = new System.Drawing.Point(621, 47);
            this.flp_recipecount.Name = "flp_recipecount";
            this.flp_recipecount.Size = new System.Drawing.Size(429, 443);
            this.flp_recipecount.TabIndex = 3;
            // 
            // lb_AddRecipeMemberRank
            // 
            this.lb_AddRecipeMemberRank.AutoSize = true;
            this.lb_AddRecipeMemberRank.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_AddRecipeMemberRank.Location = new System.Drawing.Point(792, 9);
            this.lb_AddRecipeMemberRank.Name = "lb_AddRecipeMemberRank";
            this.lb_AddRecipeMemberRank.Size = new System.Drawing.Size(120, 22);
            this.lb_AddRecipeMemberRank.TabIndex = 4;
            this.lb_AddRecipeMemberRank.Text = "食譜累積榜";
            // 
            // flp_hotrecipe
            // 
            this.flp_hotrecipe.AutoScroll = true;
            this.flp_hotrecipe.Location = new System.Drawing.Point(84, 47);
            this.flp_hotrecipe.Name = "flp_hotrecipe";
            this.flp_hotrecipe.Size = new System.Drawing.Size(450, 443);
            this.flp_hotrecipe.TabIndex = 2;
            // 
            // lb_HotMemberRank
            // 
            this.lb_HotMemberRank.AutoSize = true;
            this.lb_HotMemberRank.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_HotMemberRank.Location = new System.Drawing.Point(207, 9);
            this.lb_HotMemberRank.Name = "lb_HotMemberRank";
            this.lb_HotMemberRank.Size = new System.Drawing.Size(120, 22);
            this.lb_HotMemberRank.TabIndex = 3;
            this.lb_HotMemberRank.Text = "食譜人氣榜";
            // 
            // MemberRankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 520);
            this.Controls.Add(this.flp_hotrecipe);
            this.Controls.Add(this.lb_HotMemberRank);
            this.Controls.Add(this.lb_AddRecipeMemberRank);
            this.Controls.Add(this.flp_recipecount);
            this.Name = "MemberRankForm";
            this.Text = "廚神榜";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_AddRecipeMemberRank;
        private System.Windows.Forms.FlowLayoutPanel flp_hotrecipe;
        private System.Windows.Forms.FlowLayoutPanel flp_recipecount;
        private System.Windows.Forms.Label lb_HotMemberRank;
    }
}