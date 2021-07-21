
namespace project.From_伯均
{
    partial class GoodsToR
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
            this.dgv_GoodsToR = new System.Windows.Forms.DataGridView();
            this.btn_ToR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GoodsToR)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_GoodsToR
            // 
            this.dgv_GoodsToR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GoodsToR.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_GoodsToR.Location = new System.Drawing.Point(0, 0);
            this.dgv_GoodsToR.Name = "dgv_GoodsToR";
            this.dgv_GoodsToR.RowTemplate.Height = 24;
            this.dgv_GoodsToR.Size = new System.Drawing.Size(459, 300);
            this.dgv_GoodsToR.TabIndex = 0;
            // 
            // btn_ToR
            // 
            this.btn_ToR.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_ToR.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ToR.Location = new System.Drawing.Point(170, 363);
            this.btn_ToR.Name = "btn_ToR";
            this.btn_ToR.Size = new System.Drawing.Size(121, 53);
            this.btn_ToR.TabIndex = 1;
            this.btn_ToR.Text = "查食譜";
            this.btn_ToR.UseVisualStyleBackColor = false;
            this.btn_ToR.Click += new System.EventHandler(this.btn_ToR_Click);
            // 
            // GoodsToR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(459, 450);
            this.Controls.Add(this.btn_ToR);
            this.Controls.Add(this.dgv_GoodsToR);
            this.Name = "GoodsToR";
            this.Text = "相關食譜";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GoodsToR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_GoodsToR;
        private System.Windows.Forms.Button btn_ToR;
    }
}