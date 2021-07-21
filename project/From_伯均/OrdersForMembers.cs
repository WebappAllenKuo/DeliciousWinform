using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.From_伯均
{
    public partial class OrdersForMembers : Form
    {
        public CMember MemberData { get; set; }
        DeliciousEntities dbContext = new DeliciousEntities();
        public OrdersForMembers()
        {
            InitializeComponent();
            if (Viewbag.member != null)
            {
                this.MemberData = Viewbag.member;
            }

            var result = dbContext.Order_Table.
                Where(KK => KK.MemberID == MemberData.MemberID).
                Select(KK => new
            {
                編號 = KK.OrderID,
                訂單日期 = KK.OrderDate,
                付費方式 = KK.PayMethod,
                送達日期 = KK.DeliveredDate,
                處裡狀態 = KK.OrderStatus
            }).ToList() ;

            dgv_OrderForM.DataSource = result;
        }

        private void btn_ToOrderDetailsM_Click(object sender, EventArgs e)
        {
            dgv_OrderDetailsM.DataSource = null;
            pb_OdersM.Image = null;
            tbc_OrdersForM.SelectedTab = tbp_OderDetailsM;
            int OID =(int)dgv_OrderForM.CurrentRow.Cells[0].Value;

            lb_OrderDetails.Text = $"訂單編號：{OID}";

            var result = dbContext.Order_Detail_Table.
                Where(KK => KK.OrderiD == OID).
                Select(KK => new
                {
                    訂單編號 = KK.OrderiD,
                    商品編號 = KK.IngredientID,
                    商品名稱 = dbContext.Ingredient_Table.Where(Name => Name.IngredientID == KK.IngredientID).Select(Name => Name.Ingredient).FirstOrDefault(),
                    商品圖片 = dbContext.Merchandise_Picture_Table.Where(Pic => Pic.IngredientID == KK.IngredientID).Select(Pic => Pic.MerchandisePicture).FirstOrDefault(),
                    訂購數量 = KK.InCartQuantity,
                    總金額 = (KK.Price * (int)KK.Discount * KK.InCartQuantity)
                }).ToList() ;
            dgv_OrderDetailsM.DataSource = result;

            byte[] PPicB = (byte[])dgv_OrderDetailsM.CurrentRow.Cells[3].Value;
            MemoryStream PPic = new MemoryStream(PPicB);
            pb_OdersM.Image = Image.FromStream(PPic);
        }

        private void MouseClick(object sender, MouseEventArgs e)
        {
            pb_OdersM.Image = null;
            byte[] PPicB = (byte[])dgv_OrderDetailsM.CurrentRow.Cells[3].Value;
            MemoryStream PPic = new MemoryStream(PPicB);
            pb_OdersM.Image = Image.FromStream(PPic);
        }
    }
}
