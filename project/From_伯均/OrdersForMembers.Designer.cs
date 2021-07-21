
namespace project.From_伯均
{
    partial class OrdersForMembers
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbc_OrdersForM = new System.Windows.Forms.TabControl();
            this.tbp_OrderM = new System.Windows.Forms.TabPage();
            this.btn_ToOrderDetailsM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_OrderForM = new System.Windows.Forms.DataGridView();
            this.tbp_OderDetailsM = new System.Windows.Forms.TabPage();
            this.pb_OdersM = new System.Windows.Forms.PictureBox();
            this.lb_OrderDetails = new System.Windows.Forms.Label();
            this.dgv_OrderDetailsM = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tbc_OrdersForM.SuspendLayout();
            this.tbp_OrderM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderForM)).BeginInit();
            this.tbp_OderDetailsM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_OdersM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderDetailsM)).BeginInit();
            this.SuspendLayout();
            // 
            // tbc_OrdersForM
            // 
            this.tbc_OrdersForM.Controls.Add(this.tbp_OrderM);
            this.tbc_OrdersForM.Controls.Add(this.tbp_OderDetailsM);
            this.tbc_OrdersForM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc_OrdersForM.Location = new System.Drawing.Point(0, 0);
            this.tbc_OrdersForM.Name = "tbc_OrdersForM";
            this.tbc_OrdersForM.SelectedIndex = 0;
            this.tbc_OrdersForM.Size = new System.Drawing.Size(800, 450);
            this.tbc_OrdersForM.TabIndex = 0;
            // 
            // tbp_OrderM
            // 
            this.tbp_OrderM.Controls.Add(this.btn_ToOrderDetailsM);
            this.tbp_OrderM.Controls.Add(this.label1);
            this.tbp_OrderM.Controls.Add(this.dgv_OrderForM);
            this.tbp_OrderM.Location = new System.Drawing.Point(4, 22);
            this.tbp_OrderM.Name = "tbp_OrderM";
            this.tbp_OrderM.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_OrderM.Size = new System.Drawing.Size(792, 424);
            this.tbp_OrderM.TabIndex = 0;
            this.tbp_OrderM.Text = "tabPage1";
            this.tbp_OrderM.UseVisualStyleBackColor = true;
            // 
            // btn_ToOrderDetailsM
            // 
            this.btn_ToOrderDetailsM.Location = new System.Drawing.Point(482, 60);
            this.btn_ToOrderDetailsM.Name = "btn_ToOrderDetailsM";
            this.btn_ToOrderDetailsM.Size = new System.Drawing.Size(75, 23);
            this.btn_ToOrderDetailsM.TabIndex = 2;
            this.btn_ToOrderDetailsM.Text = "查看細項";
            this.btn_ToOrderDetailsM.UseVisualStyleBackColor = true;
            this.btn_ToOrderDetailsM.Click += new System.EventHandler(this.btn_ToOrderDetailsM_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(58, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "您的訂單";
            // 
            // dgv_OrderForM
            // 
            this.dgv_OrderForM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OrderForM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_OrderForM.Location = new System.Drawing.Point(3, 107);
            this.dgv_OrderForM.Name = "dgv_OrderForM";
            this.dgv_OrderForM.RowTemplate.Height = 24;
            this.dgv_OrderForM.Size = new System.Drawing.Size(786, 314);
            this.dgv_OrderForM.TabIndex = 0;
            // 
            // tbp_OderDetailsM
            // 
            this.tbp_OderDetailsM.Controls.Add(this.pb_OdersM);
            this.tbp_OderDetailsM.Controls.Add(this.lb_OrderDetails);
            this.tbp_OderDetailsM.Controls.Add(this.dgv_OrderDetailsM);
            this.tbp_OderDetailsM.Location = new System.Drawing.Point(4, 22);
            this.tbp_OderDetailsM.Name = "tbp_OderDetailsM";
            this.tbp_OderDetailsM.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_OderDetailsM.Size = new System.Drawing.Size(792, 424);
            this.tbp_OderDetailsM.TabIndex = 1;
            this.tbp_OderDetailsM.Text = "tabPage2";
            this.tbp_OderDetailsM.UseVisualStyleBackColor = true;
            // 
            // pb_OdersM
            // 
            this.pb_OdersM.Location = new System.Drawing.Point(568, 6);
            this.pb_OdersM.Name = "pb_OdersM";
            this.pb_OdersM.Size = new System.Drawing.Size(138, 120);
            this.pb_OdersM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_OdersM.TabIndex = 3;
            this.pb_OdersM.TabStop = false;
            // 
            // lb_OrderDetails
            // 
            this.lb_OrderDetails.AutoSize = true;
            this.lb_OrderDetails.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_OrderDetails.Location = new System.Drawing.Point(61, 58);
            this.lb_OrderDetails.Name = "lb_OrderDetails";
            this.lb_OrderDetails.Size = new System.Drawing.Size(123, 35);
            this.lb_OrderDetails.TabIndex = 2;
            this.lb_OrderDetails.Text = "訂單細項";
            // 
            // dgv_OrderDetailsM
            // 
            this.dgv_OrderDetailsM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OrderDetailsM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_OrderDetailsM.Location = new System.Drawing.Point(3, 132);
            this.dgv_OrderDetailsM.Name = "dgv_OrderDetailsM";
            this.dgv_OrderDetailsM.RowTemplate.Height = 24;
            this.dgv_OrderDetailsM.Size = new System.Drawing.Size(786, 289);
            this.dgv_OrderDetailsM.TabIndex = 0;
            this.dgv_OrderDetailsM.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClick);
            // 
            // OrdersForMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbc_OrdersForM);
            this.Name = "OrdersForMembers";
            this.Text = "OrdersForMembers";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tbc_OrdersForM.ResumeLayout(false);
            this.tbp_OrderM.ResumeLayout(false);
            this.tbp_OrderM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderForM)).EndInit();
            this.tbp_OderDetailsM.ResumeLayout(false);
            this.tbp_OderDetailsM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_OdersM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderDetailsM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TabControl tbc_OrdersForM;
        private System.Windows.Forms.TabPage tbp_OrderM;
        private System.Windows.Forms.DataGridView dgv_OrderForM;
        private System.Windows.Forms.TabPage tbp_OderDetailsM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ToOrderDetailsM;
        private System.Windows.Forms.DataGridView dgv_OrderDetailsM;
        private System.Windows.Forms.Label lb_OrderDetails;
        private System.Windows.Forms.PictureBox pb_OdersM;
    }
}