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
    public partial class FrmOrderSearch : Form
    {
        public FrmOrderSearch()
        {
            InitializeComponent();
        }
  DeliciousEntities dbcontext = new DeliciousEntities();
        private void bt_SrhOrder_Click(object sender, EventArgs e)
        {
            
            
                var q = dbcontext.Order_Table.Where(n => n.Member_Table.CellNumber == this.tb_SrhWrds.Text).Select(n => new { 訂購單號 = n.OrderID, 訂單日期 = n.OrderDate, 訂購人 = n.Member_Table.MemberName, 訂單狀態 = n.OrderStatus });
                this.bindingSource1.DataSource = q.ToList();  
                this.dgv_orders.DataSource = this.bindingSource1;
                bindingSource1_CurrentChanged(null, null);
            

        }

  

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            if (this.dgv_orders.DataSource!= null)
            {
                if (this.dgv_orders.Rows.Count > 0)
                {
                   

                    int OrderID = Convert.ToInt32(this.dgv_orders.Rows[this.bindingSource1.Position].Cells["訂購單號"].Value);
                    this.tb_OrderID.Text = OrderID.ToString();
                    var q = this.dbcontext.Order_Detail_Table.Where(n => n.OrderiD == OrderID).Select(n => new { n.IngredientID, n.Ingredient_Table.Ingredient, n.Price, n.InCartQuantity });
                    this.dgv_OrderDetail.DataSource = q.ToList();
                 
                }
                else
                { return; }
            }
            else
            { return; }
        }

        private void cb_OrderStatusCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dgv_orders.DataSource = null;
            this.dgv_OrderDetail.DataSource = null;
            if (this.cb_OrderStatusCat.Text=="全部")
            { var q = dbcontext.Order_Table.Where(n => n.Member_Table.CellNumber == this.tb_SrhWrds.Text).Select(n => new { 訂購單號 = n.OrderID, 訂單日期 = n.OrderDate, 訂購人 = n.Member_Table.MemberName, 訂單狀態 = n.OrderStatus });
                this.bindingSource1.DataSource = q.ToList();
            }
            else
            { var q = dbcontext.Order_Table.Where(n=> n.Member_Table.CellNumber == this.tb_SrhWrds.Text && n.OrderStatus == this.cb_OrderStatusCat.Text ).Select(n => new { 訂購單號 = n.OrderID, 訂單日期 = n.OrderDate, 訂購人 = n.Member_Table.MemberName, 訂單狀態 = n.OrderStatus });
                this.bindingSource1.DataSource = q.ToList();
            } 
            
            this.dgv_orders.DataSource = this.bindingSource1;
            bindingSource1_CurrentChanged(null, null);

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var q = dbcontext.Order_Table.Select(n => new { 訂購單號 = n.OrderID, 訂單日期 = n.OrderDate, 訂購人 = n.Member_Table.MemberName, 訂單狀態 = n.OrderStatus });
            this.bindingSource1.DataSource = q.ToList();
            this.dgv_orders.DataSource = this.bindingSource1;
            bindingSource1_CurrentChanged(null, null);
        }
    }
}
