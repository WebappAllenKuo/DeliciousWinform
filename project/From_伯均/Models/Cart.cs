using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.From_伯均
{
    public class NewCart
    {
        //自動生成的流水號不適合用在還未進入資料庫的資料
        public int MemberID { get; set; }
        public int IngredientID { get; set; }
        public int InCartQuantity { get; set; }
    }

    public class NewOrder
    {
        public int MemberID { get; set; }
        public DateTime OrderDate { get; set; }
        public string DeliveryAddress { get; set; }
        public string PayMethod { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
    }

    public class Order
    {
        public int OrderID { get; set; }
        public int MemberID { get; set; }
        public DateTime OrderDate { get; set; }
        public string DeliveryAddress { get; set; }
        public string PayMethod { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
    }

    public class OrderDetails
    {
        //public int OrderDetailsID { get; set; }
        //public int OrderID { get; set; }
        public int IngredientID { get; set; }
        public int Price { get; set; }
        public float Discount { get; set; }
        public DateTime OrderDate { get; set; }
        public int InCartQuantity { get; set; }
    }
}
