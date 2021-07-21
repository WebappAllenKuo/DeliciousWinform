namespace project.Form_Chia
{
    partial class FrmOrderSearch
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
            this.tb_SrhWrds = new System.Windows.Forms.TextBox();
            this.btn_SrhOrder = new System.Windows.Forms.Button();
            this.dgv_orders = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_OrderDetail = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tb_OrderID = new System.Windows.Forms.TextBox();
            this.cb_OrderStatusCat = new System.Windows.Forms.ComboBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_SrhWrds
            // 
            this.tb_SrhWrds.Location = new System.Drawing.Point(237, 13);
            this.tb_SrhWrds.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_SrhWrds.Name = "tb_SrhWrds";
            this.tb_SrhWrds.Size = new System.Drawing.Size(149, 22);
            this.tb_SrhWrds.TabIndex = 1;
            // 
            // btn_SrhOrder
            // 
            this.btn_SrhOrder.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_SrhOrder.Location = new System.Drawing.Point(390, 8);
            this.btn_SrhOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_SrhOrder.Name = "btn_SrhOrder";
            this.btn_SrhOrder.Size = new System.Drawing.Size(68, 32);
            this.btn_SrhOrder.TabIndex = 2;
            this.btn_SrhOrder.Text = "搜尋";
            this.btn_SrhOrder.UseVisualStyleBackColor = true;
            this.btn_SrhOrder.Click += new System.EventHandler(this.bt_SrhOrder_Click);
            // 
            // dgv_orders
            // 
            this.dgv_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orders.Location = new System.Drawing.Point(25, 41);
            this.dgv_orders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_orders.Name = "dgv_orders";
            this.dgv_orders.RowHeadersWidth = 62;
            this.dgv_orders.RowTemplate.Height = 31;
            this.dgv_orders.Size = new System.Drawing.Size(655, 108);
            this.dgv_orders.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(162, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "手機號碼";
            // 
            // dgv_OrderDetail
            // 
            this.dgv_OrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OrderDetail.Location = new System.Drawing.Point(25, 205);
            this.dgv_OrderDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_OrderDetail.Name = "dgv_OrderDetail";
            this.dgv_OrderDetail.RowHeadersWidth = 62;
            this.dgv_OrderDetail.RowTemplate.Height = 31;
            this.dgv_OrderDetail.Size = new System.Drawing.Size(655, 143);
            this.dgv_OrderDetail.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(30, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "訂單明細";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(131, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "訂單編號";
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // tb_OrderID
            // 
            this.tb_OrderID.Enabled = false;
            this.tb_OrderID.Location = new System.Drawing.Point(200, 174);
            this.tb_OrderID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_OrderID.Name = "tb_OrderID";
            this.tb_OrderID.Size = new System.Drawing.Size(97, 22);
            this.tb_OrderID.TabIndex = 8;
            // 
            // cb_OrderStatusCat
            // 
            this.cb_OrderStatusCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_OrderStatusCat.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_OrderStatusCat.FormattingEnabled = true;
            this.cb_OrderStatusCat.Items.AddRange(new object[] {
            "全部",
            "處理中",
            "出貨中",
            "已送達",
            "已取消"});
            this.cb_OrderStatusCat.Location = new System.Drawing.Point(551, 11);
            this.cb_OrderStatusCat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_OrderStatusCat.Name = "cb_OrderStatusCat";
            this.cb_OrderStatusCat.Size = new System.Drawing.Size(131, 28);
            this.cb_OrderStatusCat.TabIndex = 9;
            this.cb_OrderStatusCat.SelectedIndexChanged += new System.EventHandler(this.cb_OrderStatusCat_SelectedIndexChanged);
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Close.Location = new System.Drawing.Point(599, 159);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(81, 37);
            this.btn_Close.TabIndex = 10;
            this.btn_Close.Text = "關閉";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(30, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "搜尋個人訂單";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(462, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "搜尋全部";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmOrderSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 381);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.cb_OrderStatusCat);
            this.Controls.Add(this.tb_OrderID);
            this.Controls.Add(this.dgv_OrderDetail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_orders);
            this.Controls.Add(this.btn_SrhOrder);
            this.Controls.Add(this.tb_SrhWrds);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmOrderSearch";
            this.Text = "OrderSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_SrhWrds;
        private System.Windows.Forms.Button btn_SrhOrder;
        private System.Windows.Forms.DataGridView dgv_orders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_OrderDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox tb_OrderID;
        private System.Windows.Forms.ComboBox cb_OrderStatusCat;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}