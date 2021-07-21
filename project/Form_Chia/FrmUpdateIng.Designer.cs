namespace project.Form_Chia
{
    partial class FrmUpdateIng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdateIng));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_CancelEdit = new System.Windows.Forms.Button();
            this.btn_CheckEdit = new System.Windows.Forms.Button();
            this.cb_IngrCat = new System.Windows.Forms.ComboBox();
            this.tb_IngUnt = new System.Windows.Forms.TextBox();
            this.tb_IngPr = new System.Windows.Forms.TextBox();
            this.tb_IngSto = new System.Windows.Forms.TextBox();
            this.tb_Ingdes = new System.Windows.Forms.TextBox();
            this.tb_IngrName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cb_IsSell = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.flp_Pics = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_SrhIng = new System.Windows.Forms.TextBox();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_CancelSrh = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_adminname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_CancelEdit
            // 
            this.btn_CancelEdit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_CancelEdit.Location = new System.Drawing.Point(195, 392);
            this.btn_CancelEdit.Name = "btn_CancelEdit";
            this.btn_CancelEdit.Size = new System.Drawing.Size(153, 64);
            this.btn_CancelEdit.TabIndex = 17;
            this.btn_CancelEdit.Text = "取消修改";
            this.btn_CancelEdit.UseVisualStyleBackColor = true;
            this.btn_CancelEdit.Click += new System.EventHandler(this.btn_CancelEdit_Click);
            // 
            // btn_CheckEdit
            // 
            this.btn_CheckEdit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_CheckEdit.Location = new System.Drawing.Point(27, 392);
            this.btn_CheckEdit.Name = "btn_CheckEdit";
            this.btn_CheckEdit.Size = new System.Drawing.Size(153, 64);
            this.btn_CheckEdit.TabIndex = 16;
            this.btn_CheckEdit.Text = "確認修改";
            this.btn_CheckEdit.UseVisualStyleBackColor = true;
            this.btn_CheckEdit.Click += new System.EventHandler(this.btn_CheckEdit_Click);
            // 
            // cb_IngrCat
            // 
            this.cb_IngrCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_IngrCat.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_IngrCat.FormattingEnabled = true;
            this.cb_IngrCat.Location = new System.Drawing.Point(210, 80);
            this.cb_IngrCat.Name = "cb_IngrCat";
            this.cb_IngrCat.Size = new System.Drawing.Size(203, 38);
            this.cb_IngrCat.TabIndex = 14;
            // 
            // tb_IngUnt
            // 
            this.tb_IngUnt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_IngUnt.Location = new System.Drawing.Point(210, 122);
            this.tb_IngUnt.Name = "tb_IngUnt";
            this.tb_IngUnt.Size = new System.Drawing.Size(203, 39);
            this.tb_IngUnt.TabIndex = 13;
            // 
            // tb_IngPr
            // 
            this.tb_IngPr.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_IngPr.Location = new System.Drawing.Point(210, 167);
            this.tb_IngPr.Name = "tb_IngPr";
            this.tb_IngPr.Size = new System.Drawing.Size(203, 39);
            this.tb_IngPr.TabIndex = 12;
            // 
            // tb_IngSto
            // 
            this.tb_IngSto.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_IngSto.Location = new System.Drawing.Point(210, 213);
            this.tb_IngSto.Name = "tb_IngSto";
            this.tb_IngSto.Size = new System.Drawing.Size(203, 39);
            this.tb_IngSto.TabIndex = 11;
            // 
            // tb_Ingdes
            // 
            this.tb_Ingdes.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Ingdes.Location = new System.Drawing.Point(210, 259);
            this.tb_Ingdes.Name = "tb_Ingdes";
            this.tb_Ingdes.Size = new System.Drawing.Size(203, 39);
            this.tb_Ingdes.TabIndex = 10;
            // 
            // tb_IngrName
            // 
            this.tb_IngrName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_IngrName.Location = new System.Drawing.Point(210, 31);
            this.tb_IngrName.Name = "tb_IngrName";
            this.tb_IngrName.Size = new System.Drawing.Size(203, 39);
            this.tb_IngrName.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // cb_IsSell
            // 
            this.cb_IsSell.AutoSize = true;
            this.cb_IsSell.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_IsSell.Location = new System.Drawing.Point(210, 313);
            this.cb_IsSell.Name = "cb_IsSell";
            this.cb_IsSell.Size = new System.Drawing.Size(111, 34);
            this.cb_IsSell.TabIndex = 8;
            this.cb_IsSell.Text = "販賣中";
            this.cb_IsSell.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(21, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 36);
            this.label6.TabIndex = 5;
            this.label6.Text = "食材單位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(21, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "商品售價";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(21, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "商品庫存";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(21, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "商品描述";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(21, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "商品販賣狀況";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "食材名稱";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_CancelEdit);
            this.panel1.Controls.Add(this.btn_CheckEdit);
            this.panel1.Controls.Add(this.cb_IngrCat);
            this.panel1.Controls.Add(this.tb_IngUnt);
            this.panel1.Controls.Add(this.tb_IngPr);
            this.panel1.Controls.Add(this.tb_IngSto);
            this.panel1.Controls.Add(this.tb_Ingdes);
            this.panel1.Controls.Add(this.tb_IngrName);
            this.panel1.Controls.Add(this.cb_IsSell);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(913, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 471);
            this.panel1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(21, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 36);
            this.label7.TabIndex = 6;
            this.label7.Text = "食材分類";
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_close.Location = new System.Drawing.Point(1549, 569);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(177, 64);
            this.btn_close.TabIndex = 18;
            this.btn_close.Text = "關閉";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(216, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 36);
            this.label8.TabIndex = 13;
            this.label8.Text = "修改食材頁面";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(905, 423);
            this.dataGridView1.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(12, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 36);
            this.label9.TabIndex = 15;
            this.label9.Text = "所有食材頁面";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(213, 180);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator1.Size = new System.Drawing.Size(266, 33);
            this.bindingNavigator1.TabIndex = 16;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(40, 28);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 30);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.dgv_Moving);
            // 
            // flp_Pics
            // 
            this.flp_Pics.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flp_Pics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_Pics.Location = new System.Drawing.Point(1341, 173);
            this.flp_Pics.Name = "flp_Pics";
            this.flp_Pics.Size = new System.Drawing.Size(385, 302);
            this.flp_Pics.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(546, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 36);
            this.label10.TabIndex = 19;
            this.label10.Text = "搜尋食材";
            // 
            // tb_SrhIng
            // 
            this.tb_SrhIng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_SrhIng.Location = new System.Drawing.Point(704, 118);
            this.tb_SrhIng.Name = "tb_SrhIng";
            this.tb_SrhIng.Size = new System.Drawing.Size(203, 39);
            this.tb_SrhIng.TabIndex = 19;
            this.tb_SrhIng.TextChanged += new System.EventHandler(this.tb_Srh_TextChanged);
            // 
            // btn_Next
            // 
            this.btn_Next.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Next.Location = new System.Drawing.Point(671, 175);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(102, 42);
            this.btn_Next.TabIndex = 20;
            this.btn_Next.Text = "下一個";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_CancelSrh
            // 
            this.btn_CancelSrh.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_CancelSrh.Location = new System.Drawing.Point(779, 175);
            this.btn_CancelSrh.Name = "btn_CancelSrh";
            this.btn_CancelSrh.Size = new System.Drawing.Size(128, 42);
            this.btn_CancelSrh.TabIndex = 21;
            this.btn_CancelSrh.Text = "取消搜尋";
            this.btn_CancelSrh.UseVisualStyleBackColor = true;
            this.btn_CancelSrh.Click += new System.EventHandler(this.btn_CancelSrh_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Previous.Location = new System.Drawing.Point(552, 177);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(113, 42);
            this.btn_Previous.TabIndex = 22;
            this.btn_Previous.Text = "上一個";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_delete.Location = new System.Drawing.Point(1545, 490);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(181, 64);
            this.btn_delete.TabIndex = 24;
            this.btn_delete.Text = "刪除此筆資料";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(1335, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 36);
            this.label11.TabIndex = 25;
            this.label11.Text = "食材圖片拖放";
            // 
            // lb_adminname
            // 
            this.lb_adminname.AutoSize = true;
            this.lb_adminname.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_adminname.Location = new System.Drawing.Point(222, 83);
            this.lb_adminname.Name = "lb_adminname";
            this.lb_adminname.Size = new System.Drawing.Size(95, 30);
            this.lb_adminname.TabIndex = 26;
            this.lb_adminname.Text = "label12";
            // 
            // FrmUpdateIng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1738, 660);
            this.Controls.Add(this.lb_adminname);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Previous);
            this.Controls.Add(this.btn_CancelSrh);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.tb_SrhIng);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.flp_Pics);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Name = "FrmUpdateIng";
            this.Text = "UpdateIng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_CancelEdit;
        private System.Windows.Forms.Button btn_CheckEdit;
        private System.Windows.Forms.ComboBox cb_IngrCat;
        private System.Windows.Forms.TextBox tb_IngUnt;
        private System.Windows.Forms.TextBox tb_IngPr;
        private System.Windows.Forms.TextBox tb_IngSto;
        private System.Windows.Forms.TextBox tb_Ingdes;
        private System.Windows.Forms.TextBox tb_IngrName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cb_IsSell;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.FlowLayoutPanel flp_Pics;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_SrhIng;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_CancelSrh;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_adminname;
    }
}