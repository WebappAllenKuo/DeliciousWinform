using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.Form_Chia
{
    public partial class FrmAddIngr : Form
    {
        public FrmAddIngr()
        {
            InitializeComponent();
            AddCBCatforIng();
            lb_adminname.Text = "管理員 " + Viewbag.Admin.AdminName + " 您好 ";

        }

        private void AddCBCatforIng()
        {
            var q = from p in this.dbcontext.IngredientCategory_Table
                    select new { ID = p.IngredientCategoryID + ":" + p.IngredientCategory };
            foreach (var item in q)
            { cb_IngrCat.Items.Add(item.ID.ToString()); }
            cb_IngrCat.SelectedIndex = 0;
        }
        int CIDforNew = 0;
        DeliciousEntities dbcontext = new DeliciousEntities();
        private void btn_addIngredient_Click(object sender, EventArgs e)
        {

            try
            {
                if (checkContent())
                {
                    int i = cb_IngrCat.Text.ToString().IndexOf(':');
                    CIDforNew = Convert.ToInt32(cb_IngrCat.Text.ToString().Substring(0, i));
                    var NewIngredient = new Ingredient_Table
                    {
                        Ingredient = tb_IngrName.Text,
                        IngredientCategoryID = CIDforNew,
                        IngredientUnit = tb_IngUnt.Text,
                        Price = Convert.ToInt32(tb_IngPr.Text),
                        AmountInStore = Convert.ToInt32(tb_IngSto.Text),
                        MerchandiseDescription = tb_Ingdes.Text,
                        InStoreOrNot = this.cb_IsSell.Checked
                    };
                    dbcontext.Ingredient_Table.Add(NewIngredient);

                    try
                    {
                        dbcontext.SaveChanges();
                        MessageBox.Show("新增食材成功");
                        FrmAddMerchadisePic picforIng = new FrmAddMerchadisePic(tb_IngrName.Text);/*開啟插入圖片的表單*/
                        picforIng.ShowDialog();
                        Clearcontent();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                else { return; }
            }
            catch (Exception) { }

        }

        private bool checkContent()
        {

            var hasnums = new Regex("[0-9]+");
            var hasSymbolChar = new Regex(@"[!@#$%^&*().,=';_\x2f\x2d\x5b\x5d\x22\x20\x5c]+");
            if (String.IsNullOrEmpty(tb_IngrName.Text)){ MessageBox.Show("請輸入食材名稱"); return false; }
            if (String.IsNullOrEmpty(CIDforNew.ToString())){ MessageBox.Show("請輸入食材種類"); return false; }
            if (String.IsNullOrEmpty(tb_IngUnt.Text)){ MessageBox.Show("請輸入食材單位"); return false; }
            if (String.IsNullOrEmpty(tb_IngPr.Text)){ MessageBox.Show("請輸入食材價格"); return false; }
            if (String.IsNullOrEmpty(tb_IngSto.Text)){ MessageBox.Show("請輸入庫存量"); return false; }
            if (String.IsNullOrEmpty(tb_Ingdes.Text)){ MessageBox.Show("請輸入食材描述"); return false; }
            var countthesame = this.dbcontext.Ingredient_Table.Where(n => n.Ingredient == tb_IngrName.Text).Select(n => n.Ingredient).Count();
            if (countthesame > 0) { MessageBox.Show("食材名稱重複"); tb_IngrName.Text = null; return false; }
               if (string.IsNullOrWhiteSpace(this.tb_IngrName.Text)) { MessageBox.Show("食材名稱不可含有空白"); return false; }
            if (hasSymbolChar.IsMatch(this.tb_IngrName.Text) || hasnums.IsMatch(this.tb_IngrName.Text)) { MessageBox.Show("食材名稱不可含有空白/特殊字元/數字"); return false; }
            if (this.tb_IngrName.Text.Length > 10) { MessageBox.Show("食材名稱不可超過10個字"); return false; }
           
            if(hasSymbolChar.IsMatch(this.tb_IngUnt.Text)) { MessageBox.Show("食材單位不可含有空白/特殊字元/數字"); return false; } 
            if (!hasnums.IsMatch(tb_IngSto.Text)) { MessageBox.Show("數量需為數字"); return false; }
            if (!hasnums.IsMatch(tb_IngPr.Text)) { MessageBox.Show("價錢需為數字"); return false; }
            return true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clearcontent();     
        }

        private void Clearcontent()
        {
            tb_IngrName.Text = null;
            cb_IngrCat.SelectedIndex=0;
            tb_IngUnt.Text = null;
            tb_IngPr.Text = null;
            tb_IngSto.Text = null;
            tb_Ingdes.Text = null;
            this.cb_IsSell.Checked = false;
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

