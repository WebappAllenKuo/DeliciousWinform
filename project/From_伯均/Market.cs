using project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using project.Form_育政;
using project.From_伯均;
using Delicious_Kashir;

namespace MarketPages
{
    public partial class Market : Form
    {
        public CMember MemberData { get; set; }
        DeliciousEntities dbContext = new DeliciousEntities();

        public Market()
        {
            InitializeComponent();
            if (Viewbag.member != null)
            {
                MemberData = Viewbag.member;
            }
            CartLoad();
            ToShelf();
            int HowManyInCart = dbContext.Shopping_Cart_table.Where(M => M.MemberID == MemberData.MemberID).Select(M => M).Count();
            llb_toCart.Text = $"（{HowManyInCart}）購物車";
            llb_ToCart2.Text = $"（{HowManyInCart}）購物車";
        }


        //菜市場
        private void SearchIngredientButton_Click(object sender, EventArgs e)
        {
            dgv_Goods.DataSource = null;
            PBProduct.DataBindings.Clear();
            String keyword = tb_MarketSearch.Text;


            var result = dbContext.Ingredient_Table
                .Where(i => i.Ingredient.Contains(keyword) && i.InStoreOrNot == true)  //Contians會出錯?
                .Select(i =>
                new
                {
                    商品編號 = i.IngredientID,
                    名稱 = i.Ingredient,
                    價格 = i.Price,
                    單位 = i.IngredientUnit,
                    類型 = dbContext.IngredientCategory_Table.
                    Where(c => c.IngredientCategoryID == i.IngredientCategoryID)
                    .Select(c => c.IngredientCategory).FirstOrDefault(),

                    商品描述 = i.MerchandiseDescription,

                    商品圖片 = dbContext.Merchandise_Picture_Table.
                    Where(p => p.IngredientID == i.IngredientID)
                    .Select(p => p.MerchandisePicture).FirstOrDefault()
                }
                ).ToList();

            dgv_Goods.DataSource = result;
        }

        private void buttonToDescription_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Goods.Rows.Count == 0)
                {
                    MessageBox.Show("請選出一項材料！");
                    return;
                }
                else
                { 
                PBProduct.DataBindings.Clear();
                String keyword = tb_MarketSearch.Text;

                byte[] PPicB = (byte[])dgv_Goods.CurrentRow.Cells[6].Value;
                MemoryStream PPic = new MemoryStream(PPicB);
                PBProduct.Image = Image.FromStream(PPic);

                String PN = dgv_Goods.CurrentRow.Cells[1].Value.ToString();
                String PPrice = dgv_Goods.CurrentRow.Cells[2].Value.ToString();
                String PD = dgv_Goods.CurrentRow.Cells[5].Value.ToString();
                String IID = dgv_Goods.CurrentRow.Cells[0].Value.ToString();

                lb_Mname.Text = PN;
                lb_MPrice.Text = PPrice;
                tb_PDescription.Text = PD;

                ToDescription();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("出現未預期錯誤。", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //直接加入購物車
        private void FastBuy_Click(object sender, EventArgs e)
        {
            InID = (int)dgv_Goods.CurrentRow.Cells[0].Value;
            int Amount = dbContext.Ingredient_Table.Where(A => A.IngredientID == InID).Select(A => A.AmountInStore).FirstOrDefault();
            try
            {
                if (dgv_Goods.Rows.Count == 0)
                {
                    MessageBox.Show("請選出一項材料！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if(Amount ==0)
                {
                    MessageBox.Show("很抱歉，該商品已無存貨。", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    //InID = (int)dgv_Goods.CurrentRow.Cells[0].Value;
                    IAmount = 1;
                    AddToCart();
                    CartLoad();
                }              
            }
            catch (Exception)
            {
                MessageBox.Show("出現未預期錯誤。", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //點選結果進入食譜
        private void SearchRecipeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Goods.Rows.Count == 0)
                {
                    MessageBox.Show("請選出一項材料！");
                    return;
                }
                else
                {
                    String keyword = dgv_Goods.CurrentRow.Cells[1].Value.ToString();
                    //跨表單查詢
                    int[] Data = dbContext.Ingredient_Table.
                         Where(K => K.Ingredient.ToString() == keyword).
                         Select(R => R.IngredientID).ToArray();

                    int[] Recipe = dbContext.Ingredient_Record_Table.GroupBy(GR => GR.RecipeID).
                        Where(G => Data.Any(id => G.Where(R => R.IngredientID == id).Count() != 0)).
                        Select(G => G.Key).ToArray();

                    GoodsToR ToR = new GoodsToR(Recipe);
                    ToR.Show();
                }             
            }
            catch (Exception)
            {
                MessageBox.Show("出現未預期錯誤。", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //產品描述
        //填入數量
        private void cb_amount_DropDown(object sender, EventArgs e)
        {
            InID = (int)dgv_Goods.CurrentRow.Cells[0].Value;
            int AmountLeft = dbContext.Ingredient_Table.Where(A => A.IngredientID == InID).Select(A => A.AmountInStore).FirstOrDefault();

            if (AmountLeft == 0)
            {
                cb_amount.Enabled = false;
                cb_amount.Text = "已無存貨！";
            }
            else
            {
                if (AmountLeft >=20)
                {
                    for (int i = 1; i <=20; i += 1)
                    {
                        cb_amount.Items.Add(i);
                    }
                }
                else
                {
                    for (int i = 1; i <= AmountLeft; i += 1)
                    {
                        cb_amount.Items.Add(i);
                    }
                }
               
            }
        }

        //放入購物車
        private void btn_IntoCart_Click(object sender, EventArgs e)
        {
            if (cb_amount.Text == null || cb_amount.Text == "")
            {
                MessageBox.Show("請選擇採購數量！");
            }
            else if(cb_amount.Text == "已無存貨！")
            {
                MessageBox.Show("很抱歉，該商品已無存貨。", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int A = (int)cb_amount.SelectedItem;
                InID = (int)dgv_Goods.CurrentRow.Cells[0].Value;
                IAmount = A;
                AddToCart();
            }
        }

        //前往購物車
        private void btn_GoToCart_Click(object sender, EventArgs e)
        {
            CartLoad();
            ToCart();
        }

        //回到市場
        private void buttonToMarket_Click(object sender, EventArgs e)
        {
            ToShelf();
        }


        //購物車
        //回到市場
        private void button1_Click(object sender, EventArgs e)
        {
            ToShelf();
        }

        //前往交易資訊
        private void buttonToDeal_Click(object sender, EventArgs e)
        {
            if(dgv_Cart.RowCount==0)
            {
                return;
            }
            ToDeal();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("按「確定」回到菜市場", "確定要嗎？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                ToShelf();
            }
        }

        private void btn_DeleteChoosed_Click(object sender, EventArgs e)
        {
            if (dgv_Cart.RowCount == 0) {
                MessageBox.Show("購物車內已無商品", "系統提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; 
            }
            DialogResult result = MessageBox.Show("確定刪除?", "系統提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                
                int cartID = dgv_Cart.CurrentRow.Index;
                IAmount = (int)dgv_Cart.CurrentRow.Cells[2].Value;
                InID = (int)dgv_Cart.CurrentRow.Cells[0].Value;


                var deleteSingleCart =
                from details in dbContext.Shopping_Cart_table
                where  details.MemberID == MemberData.MemberID
                select details;
                int each_count = 0;
                foreach (var detail in deleteSingleCart)
                {
                    if (each_count == cartID)
                    {
                       
                        dbContext.Shopping_Cart_table.Remove(detail);
                    }
                    each_count++;
                }

                try
                {
                    dbContext.SaveChanges();
                }
                catch (Exception )
                {
                    MessageBox.Show("error");
                }
                    CartLoad();
            }
        }

        private void btn_CleanCart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確定刪除?", "系統提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var RCart = dbContext.Shopping_Cart_table.Where(RC => RC.MemberID == MemberData.MemberID).Select(N => N);
                    foreach (var item in RCart)
                    {
                        dbContext.Shopping_Cart_table.Remove(item);
                    }
                    dbContext.SaveChanges();
                    //CartAmount = 0;
                }
                catch (Exception)
                {
                    MessageBox.Show("出現未預期錯誤。");
                }
                CartLoad();
            }
        }

        //送貨資訊

        //全台縣市-鄉鎮
        #region 
        String[] Taipei = { "士林區", "北投區", "中山區", "大同區", "松山區", "內湖區", "中正區", "萬華區", "大安區", "文山區", "信義區", "南港區" };
        String[] NTaipei = { "板橋區", "新莊區", "中和區", "永和區", "土城區", "樹林區", "三峽區", "鶯歌區", "三重區", "蘆洲區", "五股區", "泰山區", "林口區", "八里區", "淡水區", "三芝區", "石門區", "金山區", "萬里區", "汐止區", "瑞芳區", "貢寮區", "平溪區", "雙溪區", "新店區", "深坑區", "石碇區", "坪林區", "烏來區" };
        String[] Taoyuan = { "桃園區", "中壢區", "平鎮區", "八德區", "楊梅區", "蘆竹區", "大溪區", "龍潭區", "龜山區", "大園區", "觀音區", "新屋區", "復興區" };
        String[] Taichung = { "中區", "東區", "南區", "西區", "北區", "北屯區", "西屯區", "南屯區", "太平區", "大里區", "霧峰區", "烏日區", "豐原區", "后里區", "石岡區", "東勢區", "新社區", "潭子區", "大雅區", "神岡區", "大肚區", "沙鹿區", "龍井區", "梧棲區", "清水區", "大甲區", "外埔區", "大安區", "和平區" };
        String[] Tainan = { "中西區", "東區", "南區", "北區", "安平區", "安南區", "永康區", "歸仁區", "新化區", "左鎮區", "玉井區", "楠西區", "南化區", "仁德區", "關廟區", "龍崎區", "官田區", "麻豆區", "佳里區", "西港區", "七股區", "將軍區", "學甲區", "北門區", "新營區", "後壁區", "白河區", "東山區", "六甲區", "下營區", "柳營區", "鹽水區", "善化區", "大內區", "山上區", "新市區", "安定區" };
        String[] Kaohsiung = { "楠梓區", "左營區", "鼓山區", "三民區", "鹽埕區", "前金區", "新興區", "苓雅區", "前鎮區", "旗津區", "小港區", "鳳山區", "大寮區", "鳥松區", "林園區", "仁武區", "大樹區", "大社區", "岡山區", "路竹區", "橋頭區", "梓官區", "彌陀區", "永安區", "燕巢區", "田寮區", "阿蓮區", "茄萣區", "湖內區", "旗山區", "美濃區", "內門區", "杉林區", "甲仙區", "六龜區", "茂林區", "桃源區", "那瑪夏區" };
        String[] Keelung = { "仁愛區", "中正區", "信義區", "中山區", "安樂區", "暖暖區", "七堵區" };
        String[] HsinchuCi = { "東區", "北區", "香山區" };
        String[] ChiayiCi = { "東區", "西區" };
        String[] Hsinchu = { "竹北市", "竹東鎮", "新埔鎮", "關西鎮", "湖口鄉", "新豐鄉", "峨眉鄉", "寶山鄉", "北埔鄉", "芎林鄉", "橫山鄉", "尖石鄉", "五峰鄉" };
        String[] Changhua = { "彰化市", "員林市", "和美鎮", "鹿港鎮", "溪湖鎮", "二林鎮", "田中鎮", "北斗鎮", "花壇鄉", "芬園鄉", "大村鄉", "永靖鄉", "伸港鄉", "線西鄉", "福興鄉", "秀水鄉", "埔心鄉", "埔鹽鄉", "大城鄉", "芳苑鄉", "竹塘鄉", "社頭鄉", "二水鄉", "田尾鄉", "埤頭鄉", "溪州鄉" };
        String[] Chiayi = { "太保市", "朴子市", "布袋鎮", "大林鎮", "民雄鄉", "溪口鄉", "新港鄉", "六腳鄉", "東石鄉", "義竹鄉", "鹿草鄉", "水上鄉", "中埔鄉", "竹崎鄉", "梅山鄉", "番路鄉", "大埔鄉", "阿里山鄉" };
        String[] Hualien = { "花蓮市", "鳳林鎮", "玉里鎮", "新城鄉", "吉安鄉", "壽豐鄉", "光復鄉", "豐濱鄉", "瑞穗鄉", "富里鄉", "秀林鄉", "萬榮鄉", "卓溪鄉" };
        String[] Miaoli = { "苗栗市", "頭份市", "竹南鎮", "後龍鎮", "通霄鎮", "苑裡鎮", "卓蘭鎮", "造橋鄉", "西湖鄉", "頭屋鄉", "公館鄉", "銅鑼鄉", "三義鄉", "大湖鄉", "獅潭鄉", "三灣鄉", "南庄鄉", "泰安鄉" };
        String[] Nantou = { "南投市", "埔里鎮", "草屯鎮", "竹山鎮", "集集鎮", "名間鄉", "鹿谷鄉", "中寮鄉", "魚池鄉", "國姓鄉", "水里鄉", "信義鄉", "仁愛鄉" };
        String[] Pingtung = { "屏東市", "潮州鎮", "東港鎮", "恆春鎮", "萬丹鄉", "長治鄉", "麟洛鄉", "九如鄉", "里港鄉", "鹽埔鄉", "高樹鄉", "萬巒鄉", "內埔鄉", "竹田鄉", "新埤鄉", "枋寮鄉", "新園鄉", "崁頂鄉", "林邊鄉", "南州鄉", "佳冬鄉", "琉球鄉", "車城鄉", "滿州鄉", "枋山鄉", "霧臺鄉", "瑪家鄉", "泰武鄉", "來義鄉", "春日鄉", "獅子鄉", "牡丹鄉", "三地門鄉" };
        String[] Taitung = { "臺東市", "成功鎮", "關山鎮", "長濱鄉", "池上鄉", "東河鄉", "鹿野鄉", "卑南鄉", "大武鄉", "綠島鄉", "太麻里鄉", "海端鄉", "延平鄉", "金峰鄉", "達仁鄉", "蘭嶼鄉" };
        String[] Yilan = { "宜蘭市", "頭城鎮", "羅東鎮", "蘇澳鎮", "礁溪鄉", "壯圍鄉", "員山鄉", "冬山鄉", "五結鄉", "三星鄉", "大同鄉", "南澳鄉" };
        String[] Yunlin = { "斗六市", "斗南鎮", "虎尾鎮", "西螺鎮", "土庫鎮", "北港鎮", "林內鄉", "古坑鄉", "大埤鄉", "莿桐鄉", "褒忠鄉", "二崙鄉", "崙背鄉", "麥寮鄉", "臺西鄉", "東勢鄉", "元長鄉", "四湖鄉", "口湖鄉", "水林鄉" };
        String[] Penghu = { "馬公市", "湖西鄉", "白沙鄉", "西嶼鄉", "望安鄉", "七美鄉" };
        String[] Kinmen = { "金城鎮", "金湖鎮", "金沙鎮", "金寧鄉", "烈嶼鄉", "烏坵鄉" };
        String[] Lienggong = { "南竿鄉", "北竿鄉", "莒光鄉", "東引鄉" };
        #endregion //鄉鎮市區

        private void buttonConfirmPay_Click(object sender, EventArgs e)
        {
            if (cb_County.Text == "" || cb_District.Text == "" || tb_Address.Text == "")
            {
                MessageBox.Show("請輸入收件資訊！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cb_PayWay.Text == "")
            {
                MessageBox.Show("請選擇付費方式！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cb_HowtoRecieve.Text == "超商領貨" && cb_ChooseConStore.Text=="")
            {
                MessageBox.Show("請選擇您要寄送的便利商店！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cb_PayWay.Text == "信用卡付款" && (tb_Credit1.Text == "" || tb_Credit2.Text == "" || tb_Credit3.Text == "" || tb_Credit4.Text == "" || tb_CreditSaveCode.Text == ""))
            {
                MessageBox.Show("請輸入信用卡資訊！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (tb_NameT.Text == "")
            {
                MessageBox.Show("請輸入姓名！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                ToConfrim();
                Order NewOrder = new Order();
            }

            if (cb_PayWay.Text == "信用卡付款")
            {
                tb_TradeConfirm.Text = "姓名：" + tb_NameT.Text + "\r\n" + "\r\n"
               + "領貨方式：" + cb_HowtoRecieve.Text + "\r\n" + "\r\n"
               + "送達地址：" + cb_County2.Text + cb_District2.Text + tb_Address2.Text + "\r\n" + "\r\n"
               + "付費方式：" + cb_PayWay.Text + "\r\n" + "\r\n"
               + "信用卡卡號：" + tb_Credit1.Text + "－" + tb_Credit2.Text + "－" + tb_Credit3.Text + "－" + tb_Credit4.Text + "\r\n" + "\r\n"
               + "安全碼：" + tb_CreditSaveCode.Text + "\r\n" + "\r\n";
            }
            else if (cb_PayWay.Text == "行動支付")
            {
                tb_TradeConfirm.Text = "姓名：" + tb_NameT.Text + "\r\n" + "\r\n"
                  + "領貨方式：" + cb_HowtoRecieve.Text + "\r\n" + "\r\n"
                 + "送達地址：" + cb_County2.Text + cb_District2.Text + tb_Address2.Text + "\r\n" + "\r\n"
                 + "付費方式：" + cb_PayWay.Text + "\r\n" + "\r\n"
                  + "行動支付方式：" + cb_MPay.Text + "\r\n";
            }
            else
            {
                tb_TradeConfirm.Text = "姓名：" + tb_NameT.Text + "\r\n" + "\r\n"
                 + "領貨方式：" + cb_HowtoRecieve.Text + "\r\n" + "\r\n"
                + "送達地址：" + cb_County2.Text + cb_District2.Text + tb_Address2.Text + "\r\n" + "\r\n"
                + "付費方式：" + cb_PayWay.Text + "\r\n";
            }
            CartLoad();
        }

        private void cb_HowtoRecieve_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_HowtoRecieve.Text == "送貨到府")
            {
                PL_where.Visible = true;
                tabAddress.Visible = true;
                this.tab_ConStore.Parent = null;
                this.tab_address.Parent = this.tabAddress;
            }
            else if (cb_HowtoRecieve.Text == "超商領貨")
            {
                PL_where.Visible = true;
                this.tabAddress.Visible = true;
                this.tab_ConStore.Parent = this.tabAddress;
                tab_address.Parent = null;
            }
            else
            {
                PL_where.Visible = false;
                tabAddress.Visible = false;
            }
        }

        private void cb_PayWay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_PayWay.Text == "信用卡付款")
            {
                PL_pay.Visible = true;
                tbc_HowPay.Visible = true;
                this.tab_CreditCard.Parent = this.tbc_HowPay;
                this.tab_EPay.Parent = null;

            }
            else if (cb_PayWay.Text == "行動支付")
            {
                PL_pay.Visible = true;
                tbc_HowPay.Visible = true;
                this.tab_CreditCard.Parent = null;
                this.tab_EPay.Parent = this.tbc_HowPay;
            }
        }

        private void CBCounty_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region
            if (cb_County.Text == "臺北市")
            {
                cb_District.Items.Clear();
                foreach (var item in Taipei)
                {
                    cb_District.Items.Add(item);
                }
            }
            else if (cb_County.Text == "新北市")
            {
                cb_District.Items.Clear();
                foreach (var item in NTaipei)
                {
                    cb_District.Items.Add(item);
                }
            }
            else if (cb_County.Text == "桃園市")
            {
                cb_District.Items.Clear();
                foreach (var item in Taoyuan)
                {
                    cb_District.Items.Add(item);
                }
            }
            else if (cb_County.Text == "臺中市")
            {
                cb_District.Items.Clear();
                foreach (var item in Taichung)
                {
                    cb_District.Items.Add(item);
                }
            }
            else if (cb_County.Text == "臺南市")
            {
                cb_District.Items.Clear();
                foreach (var item in Tainan)
                {
                    cb_District.Items.Add(item);
                }
            }
            else if (cb_County.Text == "高雄市")
            {
                cb_District.Items.Clear();
                foreach (var item in Kaohsiung)
                {
                    cb_District.Items.Add(item);
                }
            }
            else if (cb_County.Text == "基隆市")
            {
                cb_District.Items.Clear();
                foreach (var item in Keelung)
                {
                    cb_District.Items.Add(item);
                }
            }
            else if (cb_County.Text == "新竹市")
            {
                cb_District.Items.Clear();
                foreach (var item in HsinchuCi)
                {
                    cb_District.Items.Add(item);
                }
            }
            else if (cb_County.Text == "嘉義市")
            {
                cb_District.Items.Clear();
                foreach (var item in ChiayiCi)
                {
                    cb_District.Items.Add(item);
                }
            }
            else if (cb_County.Text == "新竹縣")
            {
                cb_District.Items.Clear();
                foreach (var item in HsinchuCi)
                {
                    cb_District.Items.Add(item);
                }
            }
            else if (cb_County.Text == "苗栗縣")
            {
                cb_District.Items.Clear();
                foreach (var item in Miaoli)
                {
                    cb_District.Items.Add(item);
                }
            }
            else if (cb_County.Text == "彰化縣")
            {
                cb_District.Items.Clear();
                foreach (var item in Changhua)
                {
                    cb_District.Items.Add(item);
                }
            }
            else if (cb_County.Text == "雲林縣")
            {
                cb_District.Items.Clear();
                foreach (var item in Yunlin)
                {
                    cb_District.Items.Add(item);
                }
            }
            else if (cb_County.Text == "嘉義縣")
            {
                cb_District.Items.Clear();
                foreach (var item in Chiayi)
                {
                    cb_District.Items.Add(item);
                }
            }
            else if (cb_County.Text == "屏東縣")
            {
                cb_District.Items.Clear();
                foreach (var item in Pingtung)
                {
                    cb_District.Items.Add(item);
                }
            }
            else if (cb_County.Text == "宜蘭縣")
            {
                cb_District.Items.Clear();
                foreach (var item in Yilan)
                {
                    cb_District.Items.Add(item);
                }
            }
            else if (cb_County.Text == "花蓮縣")
            {
                cb_District.Items.Clear();
                foreach (var item in Hualien)
                {
                    cb_District.Items.Add(item);
                }
            }
            else if (cb_County.Text == "臺東縣")
            {
                cb_District.Items.Clear();
                foreach (var item in Taitung)
                {
                    cb_District.Items.Add(item);
                }
            }
            else if (cb_County.Text == "澎湖縣")
            {
                cb_District.Items.Clear();
                foreach (var item in Penghu)
                {
                    cb_District.Items.Add(item);
                }
            }
            else if (cb_County.Text == "金門縣")
            {
                cb_District.Items.Clear();
                foreach (var item in Kinmen)
                {
                    cb_District.Items.Add(item);
                }
            }
            else if (cb_County.Text == "連江縣")
            {
                cb_District.Items.Clear();
                foreach (var item in Lienggong)
                {
                    cb_District.Items.Add(item);
                }
            }
            #endregion
        }

        private void chb_address_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_address.Checked == true)
            {
                cb_County2.Text = cb_County.Text;
                cb_District2.Text = cb_County.Text;
                tb_Address2.Text = tb_Address.Text;
            }
            else
            {
                cb_County2.Text = "";
                cb_District2.Text = "";
                tb_Address2.Text = "";
            }
        }

        private void cb_County2_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region
            if (cb_County2.Text == "臺北市")
            {
                cb_District2.Items.Clear();
                foreach (var item in Taipei)
                {
                    cb_District2.Items.Add(item);
                }
            }
            else if (cb_County2.Text == "新北市")
            {
                cb_District2.Items.Clear();
                foreach (var item in NTaipei)
                {
                    cb_District2.Items.Add(item);
                }
            }
            else if (cb_County2.Text == "桃園市")
            {
                cb_District2.Items.Clear();
                foreach (var item in Taoyuan)
                {
                    cb_District2.Items.Add(item);
                }
            }
            else if (cb_County2.Text == "臺中市")
            {
                cb_District2.Items.Clear();
                foreach (var item in Taichung)
                {
                    cb_District2.Items.Add(item);
                }
            }
            else if (cb_County2.Text == "臺南市")
            {
                cb_District2.Items.Clear();
                foreach (var item in Tainan)
                {
                    cb_District2.Items.Add(item);
                }
            }
            else if (cb_County2.Text == "高雄市")
            {
                cb_District2.Items.Clear();
                foreach (var item in Kaohsiung)
                {
                    cb_District2.Items.Add(item);
                }
            }
            else if (cb_County2.Text == "基隆市")
            {
                cb_District2.Items.Clear();
                foreach (var item in Keelung)
                {
                    cb_District2.Items.Add(item);
                }
            }
            else if (cb_County2.Text == "新竹市")
            {
                cb_District2.Items.Clear();
                foreach (var item in HsinchuCi)
                {
                    cb_District2.Items.Add(item);
                }
            }
            else if (cb_County2.Text == "嘉義市")
            {
                cb_District2.Items.Clear();
                foreach (var item in ChiayiCi)
                {
                    cb_District2.Items.Add(item);
                }
            }
            else if (cb_County2.Text == "新竹縣")
            {
                cb_District2.Items.Clear();
                foreach (var item in HsinchuCi)
                {
                    cb_District2.Items.Add(item);
                }
            }
            else if (cb_County2.Text == "苗栗縣")
            {
                cb_District2.Items.Clear();
                foreach (var item in Miaoli)
                {
                    cb_District2.Items.Add(item);
                }
            }
            else if (cb_County2.Text == "彰化縣")
            {
                cb_District2.Items.Clear();
                foreach (var item in Changhua)
                {
                    cb_District2.Items.Add(item);
                }
            }
            else if (cb_County2.Text == "雲林縣")
            {
                cb_District2.Items.Clear();
                foreach (var item in Yunlin)
                {
                    cb_District2.Items.Add(item);
                }
            }
            else if (cb_County2.Text == "嘉義縣")
            {
                cb_District2.Items.Clear();
                foreach (var item in Chiayi)
                {
                    cb_District2.Items.Add(item);
                }
            }
            else if (cb_County2.Text == "屏東縣")
            {
                cb_District2.Items.Clear();
                foreach (var item in Pingtung)
                {
                    cb_District2.Items.Add(item);
                }
            }
            else if (cb_County2.Text == "宜蘭縣")
            {
                cb_District2.Items.Clear();
                foreach (var item in Yilan)
                {
                    cb_District2.Items.Add(item);
                }
            }
            else if (cb_County2.Text == "花蓮縣")
            {
                cb_District2.Items.Clear();
                foreach (var item in Hualien)
                {
                    cb_District2.Items.Add(item);
                }
            }
            else if (cb_County2.Text == "臺東縣")
            {
                cb_District2.Items.Clear();
                foreach (var item in Taitung)
                {
                    cb_District2.Items.Add(item);
                }
            }
            else if (cb_County2.Text == "澎湖縣")
            {
                cb_District2.Items.Clear();
                foreach (var item in Penghu)
                {
                    cb_District2.Items.Add(item);
                }
            }
            else if (cb_County2.Text == "金門縣")
            {
                cb_District2.Items.Clear();
                foreach (var item in Kinmen)
                {
                    cb_District2.Items.Add(item);
                }
            }
            else if (cb_County2.Text == "連江縣")
            {
                cb_District2.Items.Clear();
                foreach (var item in Lienggong)
                {
                    cb_District2.Items.Add(item);
                }
            }
            #endregion
        }

        //確認交易資訊
        private void Editbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("按「確定」回到上一頁", "重填送件資訊？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                ToDeal();
            }
        }

        private void btn_ConfirmTrade_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確定送出訂單？", "系統提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                var NOrder = new Order_Table()
                {
                    MemberID = MemberData.MemberID,
                    OrderDate = DateTime.Now,
                    DeliveryCounty = cb_County2.Text,
                    DeliveryDistrict = cb_District2.Text,
                    DeliveryAddress = tb_Address2.Text,
                    PayMethod = cb_PayWay.Text,
                    DeliveredDate = null,
                    OrderStatus = "處理中",
                    RecieveMethod = cb_HowtoRecieve.Text
                };
                dbContext.Order_Table.Add(NOrder);
                dbContext.SaveChanges();

                var _NOID = from M in dbContext.Order_Table
                    where  M.MemberID == MemberData.MemberID 
                    select   M.OrderID;
                int NOID = _NOID.AsEnumerable().Last();

                for (int i = 0; i < dgv_Cart.Rows.Count; i++)
                {
                    var NOrderDetails = new Order_Detail_Table()
                    {
                        OrderiD = NOID,
                        IngredientID = (int)dgv_Cart.Rows[i].Cells[0].Value,
                        Price = (decimal)dgv_Cart.Rows[i].Cells[3].Value,
                        Discount = 0,
                        InCartQuantity = (int)dgv_Cart.Rows[i].Cells[2].Value
                    };
                    dbContext.Order_Detail_Table.Add(NOrderDetails);

                    int SellID = (int)dgv_Cart.Rows[i].Cells[0].Value;
                    int Sell = (int)dgv_Cart.Rows[i].Cells[2].Value;

                    var NIAmount = dbContext.Ingredient_Table.Where(I => I.IngredientID == SellID).Select(I => I).FirstOrDefault();
                    NIAmount.AmountInStore = NIAmount.AmountInStore - Sell;
                }

                var RCart = dbContext.Shopping_Cart_table.Where(RC => RC.MemberID == MemberData.MemberID).Select(N => N);
                foreach (var item in RCart)
                {
                    dbContext.Shopping_Cart_table.Remove(item);
                }
                dbContext.SaveChanges();
                dgv_Cart.DataSource = null;

                MessageBox.Show("成交！我們將盡速為您處裡訂單！","成交！",MessageBoxButtons.OK,MessageBoxIcon.Information);
                ToShelf();
                int HowManyInCart = dbContext.Shopping_Cart_table.Where(M => M.MemberID == MemberData.MemberID).Select(M => M).Count();
                llb_toCart.Text = $"（{HowManyInCart}）購物車";
                llb_ToCart2.Text = $"（{HowManyInCart}）購物車";
            }
        }

        //購物車方法      
        private void CartLoad()
        {
            var CurrentCart = dbContext.Shopping_Cart_table.
                Where(Mid => Mid.MemberID == MemberData.MemberID).
                Select(M => new
                {
                    商品編號 = M.IngredientID,
                    產品名稱 = dbContext.Ingredient_Table.Where(Iid => Iid.IngredientID == M.IngredientID).Select(N => N.Ingredient).FirstOrDefault(),
                    數量 = M.InCartQuantity,
                    單價 = dbContext.Ingredient_Table.Where(Iid => Iid.IngredientID == M.IngredientID).Select(N => N.Price).FirstOrDefault(),
                    小計 = M.InCartQuantity * (dbContext.Ingredient_Table.Where(Iid => Iid.IngredientID == M.IngredientID).Select(N => N.Price)).FirstOrDefault()
                }).ToList();

            dgv_Cart.DataSource = CurrentCart;
            dgv_GoodsConfirm.DataSource = CurrentCart;

            if (dgv_Cart.Rows.Count > 0)
            {
                dgv_Cart.Rows[0].Selected = true;
            }

            decimal sum = 0;
            for (int i = 0; i < dgv_Cart.Rows.Count; i += 1)
            {
                sum += (decimal)dgv_Cart.Rows[i].Cells[4].Value;
            }

            lb_Sum.Text = sum.ToString("C");

            int HowManyInCart = dbContext.Shopping_Cart_table.Where(M => M.MemberID == MemberData.MemberID).Select(M => M).Count();
            llb_toCart.Text = $"（{HowManyInCart}）購物車";
            llb_ToCart2.Text = $"（{HowManyInCart}）購物車";
        }

        int InID;
        int IAmount;
        private void AddToCart()
        {
            int IngID = InID;
            int Amount = IAmount;
            int MID = (int)MemberData.MemberID;
            var NCart = new Shopping_Cart_table()
            {
                IngredientID = IngID,
                MemberID = MID,
                InCartQuantity = Amount
            };

            //檢查購物車內是否有重複商品
            int CartG = dbContext.Shopping_Cart_table.Where(M => M.MemberID == MemberData.MemberID).Where(M=>M.IngredientID==IngID).Select(M => M.IngredientID).FirstOrDefault();
            if (CartG==IngID)
            {
                var AUpdate = dbContext.Shopping_Cart_table.AsEnumerable().Where(N => N.IngredientID == IngID).Where(M=>M.MemberID==MemberData.MemberID);
                foreach (var item in AUpdate)
                {
                    item.MemberID = MemberData.MemberID;
                    item.IngredientID = IngID;
                    item.InCartQuantity = item.InCartQuantity + Amount;
                }
                dbContext.SaveChanges();
            }
            else
            {
                dbContext.Shopping_Cart_table.Add(NCart);
                dbContext.SaveChanges();
            }

            //改變購物車數量
            int HowManyInCart = dbContext.Shopping_Cart_table.Where(M => M.MemberID == MemberData.MemberID).Select(M => M).Count();
            llb_toCart.Text = $"（{HowManyInCart}）購物車";
            llb_ToCart2.Text = $"（{HowManyInCart}）購物車";
        }


        private void llb_toCart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ToCart();
            CartLoad();
        }

        private void lb_ToCart2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ToCart();
            CartLoad();
        }

        //移動方法
        #region
        private void ToShelf()
        {
            this.tab_PDescription.Parent = null;
            this.tab_Cart.Parent = null;
            this.tab_Dealing.Parent = null;
            this.tab_DealingConfirmation.Parent = null;
            this.tab_Shelf.Parent = this.tbc_Market;
        }

        private void ToDescription()
        {
            this.tab_PDescription.Parent = this.tbc_Market;
            this.tab_Cart.Parent = null;
            this.tab_Dealing.Parent = null;
            this.tab_DealingConfirmation.Parent = null;
            this.tab_Shelf.Parent = null;
        }

        private void ToCart()
        {
            this.tab_PDescription.Parent = null;
            this.tab_Cart.Parent = this.tbc_Market;
            this.tab_Dealing.Parent = null;
            this.tab_DealingConfirmation.Parent = null;
            this.tab_Shelf.Parent = null;
        }

        private void ToDeal()
        {
            this.tab_PDescription.Parent = null;
            this.tab_Cart.Parent = null;
            this.tab_Dealing.Parent = this.tbc_Market;
            this.tab_DealingConfirmation.Parent = null;
            this.tab_Shelf.Parent = null;
        }

        private void ToConfrim()
        {
            this.tab_PDescription.Parent = null;
            this.tab_Cart.Parent = null;
            this.tab_Dealing.Parent = null;
            this.tab_DealingConfirmation.Parent = this.tbc_Market;
            this.tab_Shelf.Parent = null;
        }
        #endregion

        private void pb_logoM1_Click(object sender, EventArgs e)
        {
            HomePage HM = new HomePage();
            HM.Show();   
        }

        private void pb_logoM2_Click(object sender, EventArgs e)
        {
            HomePage HM = new HomePage();
            
            HM.Show();
        }

        private void pb_logoM3_Click(object sender, EventArgs e)
        {
            HomePage HM = new HomePage();
            HM.Show();
        }

    }
}
