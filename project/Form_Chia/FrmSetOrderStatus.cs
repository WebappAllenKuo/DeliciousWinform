using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.Form_Chia
{
    public partial class FrmSetOrderStatus : Form
    {
        public FrmSetOrderStatus()
        {
            InitializeComponent();
            this.cb_OrderStatusCat.SelectedIndex = 0;
            lb_adminname.Text = "管理員 " + Viewbag.Admin.AdminName + " 您好 ";


        }

        private void DataBindindAdd()
        {
            this.tb_OrderID.DataBindings.Add("Text", bindingSource1, "OrderID");
            this.tb_OrderDate.DataBindings.Add("Text", bindingSource1, "OrderDate");
            this.tb_DelCounty.DataBindings.Add("Text", bindingSource1, "DeliveryCounty");
            this.tb_DelDate.DataBindings.Add("Text", bindingSource1, "DeliveredDate");
            this.tb_PayMethod.DataBindings.Add("Text", bindingSource1, "PayMethod");
            this.tb_OrderStatus.DataBindings.Add("Text", bindingSource1, "OrderStatus");
        }
        bool again = true;
        private void cb_OrderStatusCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            
          
            Fill_Dvg_Order();
           
      
            if (again) { DataBindindAdd(); again = false; }
            if (this.cb_OrderStatusCat.Text == "處理中")
            {
                this.btn_Delivering.Enabled = true;
                this.btn_Delivered.Enabled = false;
                this.btn_Canceled.Enabled = true;
            }
            else if (this.cb_OrderStatusCat.Text == "出貨中")
            {
                this.btn_Delivering.Enabled = false;
                this.btn_Delivered.Enabled = true;
                this.btn_Canceled.Enabled = true;
            }
            else if (this.cb_OrderStatusCat.Text == "已送達")
            {
                this.btn_Delivering.Enabled = false;
                this.btn_Delivered.Enabled = false;
                this.btn_Canceled.Enabled = false;
            }
            else
            {
                this.btn_Delivering.Enabled = false;
                this.btn_Delivered.Enabled = false;
                this.btn_Canceled.Enabled = false;
            }

        }

        private void Fill_Dvg_Order()
        {
            DeliciousEntities dbcontext = new DeliciousEntities();
            var q = dbcontext.Order_Table.Where(n => n.OrderStatus == this.cb_OrderStatusCat.Text).Select(n => new { n.OrderID, n.OrderDate, n.OrderStatus, n.DeliveredDate, n.DeliveryCounty, n.PayMethod });
            this.bindingSource1.DataSource = q.ToList();
            this.dgv_Order.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
        }

        private void btn_Delivering_Click(object sender, EventArgs e)
        {
            if (this.dgv_Order.Rows.Count <= 0) { MessageBox.Show("目前無資料"); return; }
            DeliciousEntities dbcontext = new DeliciousEntities();
            var q = dbcontext.Order_Table.AsEnumerable().Single(n => n.OrderID == Convert.ToInt32(this.tb_OrderID.Text));
            q.OrderStatus = "出貨中";
          
            dbcontext.SaveChanges();
            Fill_Dvg_Order();
        }

        private void btn_Delivered_Click(object sender, EventArgs e)
        {
            if (this.dgv_Order.Rows.Count <= 0) { MessageBox.Show("目前無資料"); return; }
            DeliciousEntities dbcontext = new DeliciousEntities();
            var q = dbcontext.Order_Table.AsEnumerable().Single(n => n.OrderID == Convert.ToInt32(this.tb_OrderID.Text));
            q.OrderStatus = "已送達";
            q.DeliveredDate = DateTime.Now;
            dbcontext.SaveChanges();
            Fill_Dvg_Order();
        }

        private void btn_Canceled_Click(object sender, EventArgs e)
        {
            if (this.dgv_Order.Rows.Count <= 0) { MessageBox.Show("目前無資料"); return; }
            DeliciousEntities dbcontext = new DeliciousEntities();
            var q = dbcontext.Order_Table.AsEnumerable().Single(n => n.OrderID == Convert.ToInt32(this.tb_OrderID.Text));
           
            var qc = dbcontext.Order_Detail_Table.AsEnumerable().Where(n => n.OrderiD == Convert.ToInt32(this.tb_OrderID.Text)).Select(n=>n);
            foreach (var item in qc)
            {
                var qd = dbcontext.Ingredient_Table.Single(n => n.IngredientID == item.IngredientID);
                qd.AmountInStore = qd.AmountInStore + item.InCartQuantity;

            }
            q.OrderStatus = "已取消";
            dbcontext.SaveChanges();
            Fill_Dvg_Order();
        }
    }
}
