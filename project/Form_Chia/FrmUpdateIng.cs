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
    public partial class FrmUpdateIng : Form
    {
        public FrmUpdateIng()
        {
            InitializeComponent();     
            Add_CB_CatForIng(); 
            GetDataForIng();
            lb_adminname.Text = "管理員 " + Viewbag.Admin.AdminName + " 您好 ";

            this.flp_Pics.DragEnter += flp_Pic_DragEnter;
            this.flp_Pics.DragDrop += flp_Pic_DragDrop;
            this.flp_Pics.AllowDrop = true;
        }
        int IngID = 0;
        private void flp_Pic_DragDrop(object sender, DragEventArgs e)
        {

            try
            {
                DeliciousEntities dbcontext = new DeliciousEntities();
                if (CountPic > 0)
                {
                    IngID = Convert.ToInt32(this.dataGridView1.Rows[this.bindingSource1.Position].Cells["食材編號"].Value);
                   
                    string[] filenames = (string[])(e.Data.GetData(DataFormats.FileDrop));
                    for (int i = 0; i < filenames.Length&&CountPic>0; i++)
                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        Image.FromFile(filenames[i]).Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] bytes;
                        bytes = ms.GetBuffer();
                        Merchandise_Picture_Table TableNew = new Merchandise_Picture_Table()
                        {
                            IngredientID = IngID,
                            MerchandisePicture = bytes
                        };
                        dbcontext.Merchandise_Picture_Table.Add(TableNew);
                        dbcontext.SaveChanges();
                        CountPic--;
                    }
                }
                else { MessageBox.Show("圖片超過5張了"); }
                ShowPic();
            }
            catch (Exception) { }

        }

        private void flp_Pic_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

       
        
        private void Add_CB_CatForIng()
        {
            DeliciousEntities dbcontext = new DeliciousEntities();
            var q = from p in dbcontext.IngredientCategory_Table
                    select new { ID = p.IngredientCategoryID + ":" + p.IngredientCategory };
            foreach (var item in q)
            { cb_IngrCat.Items.Add(item.ID.ToString()); }
            cb_IngrCat.SelectedIndex = 0;
        }
        private void GetDataForIng()
        {
            DeliciousEntities dbcontext = new DeliciousEntities();
            var q = dbcontext.Ingredient_Table.Select(n => new { 食材名稱 = n.Ingredient, 食材分類 = n.IngredientCategoryID + ":" + n.IngredientCategory_Table.IngredientCategory, 食材單位 = n.IngredientUnit, 商品售價 = n.Price, 商品庫存 =n.AmountInStore,商品描述=n.MerchandiseDescription,商品販賣狀況=n.InStoreOrNot,食材編號 =n.IngredientID }) ;
            this.bindingSource1.DataSource = q.ToList();
            this.dataGridView1.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            
            this.dataGridView1.Columns["食材編號"].Visible = false;
            FormContent();

        }

        private void btn_CheckEdit_Click(object sender, EventArgs e)
        {
            DeliciousEntities dbcontext = new DeliciousEntities();
            var countsamename = dbcontext.Ingredient_Table.Where(n => n.Ingredient == tb_IngrName.Text).Select(n => n).Count();
            if (countsamename > 1) { MessageBox.Show("食材名稱重複，無法使用該名稱"); return; }
            var hasnums = new Regex("[0-9]+");
            var hasSymbolChar = new Regex(@"[!@#$%^&*().,=';_\x2f\x2d\x5b\x5d\x22\x20\x5c]+");
            if (string.IsNullOrWhiteSpace(this.tb_IngrName.Text)) { MessageBox.Show("食材名稱不可含有空白"); return; }
            if (hasSymbolChar.IsMatch(this.tb_IngrName.Text)||hasnums.IsMatch(this.tb_IngrName.Text)) { MessageBox.Show("食材名稱不可含有空白/特殊字元/數字"); return; }
            if (this.tb_IngrName.Text.Length > 10) { MessageBox.Show("食材名稱不可超過10個字"); return; }
            if (hasSymbolChar.IsMatch(this.tb_IngUnt.Text)) { MessageBox.Show("食材單位不可含有空白/特殊字元/數字"); return; }
            if (!hasnums.IsMatch(tb_IngSto.Text)) { MessageBox.Show("數量需為數字"); return; }
            if (!hasnums.IsMatch(tb_IngPr.Text)) { MessageBox.Show("價錢需為數字"); return; }
            try
            {
               
                int i = cb_IngrCat.Text.ToString().IndexOf(':');
                int CIDforNew = Convert.ToInt32(cb_IngrCat.Text.ToString().Substring(0, i));
                
                var q = dbcontext.Ingredient_Table.Where(n => n.IngredientID == IngID).Select(n => n);
                foreach (var item in q)
                {
                    item.Ingredient = this.tb_IngrName.Text;
                    item.IngredientCategoryID = CIDforNew;
                    item.IngredientUnit = this.tb_IngUnt.Text;
                    item.Price = Convert.ToDecimal(this.tb_IngPr.Text);
                    item.AmountInStore = Convert.ToInt32(this.tb_IngSto.Text);
                    item.MerchandiseDescription = this.tb_Ingdes.Text;
                    item.InStoreOrNot = this.cb_IsSell.Checked;

                    // ingri.IngPics = item.Merchandise_Picture_Table.FirstOrDefault();

                }
                dbcontext.SaveChanges();
                GetDataForIng();
                MessageBox.Show("修改成功");
            }
            catch (Exception) { }
        }
      
        private void dgv_Moving(object sender, EventArgs e)
        {
            FormContent();
                
        }
        
        private void FormContent()
        {
            try
            {
                DeliciousEntities dbcontext = new DeliciousEntities();

                IngID = Convert.ToInt32(this.dataGridView1.Rows[this.bindingSource1.Position].Cells["食材編號"].Value);

                var q = dbcontext.Ingredient_Table.Where(n => n.IngredientID == IngID).Select(n => n);
                foreach (var item in q)
                {
                    this.tb_IngrName.Text = item.Ingredient;
                    this.cb_IngrCat.Text = item.IngredientCategoryID + ":" + item.IngredientCategory_Table.IngredientCategory;
                    this.tb_IngUnt.Text = item.IngredientUnit;
                    this.tb_IngPr.Text = item.Price.ToString();
                    this.tb_IngSto.Text = item.AmountInStore.ToString();
                    this.tb_Ingdes.Text = item.MerchandiseDescription;
                    this.cb_IsSell.Checked = item.InStoreOrNot;

                }
   
                ShowPic();

            }
            catch (Exception) { }
        }
        int CountPic = 5;
        private void ShowPic()
        {
            DeliciousEntities dbcontext = new DeliciousEntities();
            this.flp_Pics.Controls.Clear();
            var pic = dbcontext.Merchandise_Picture_Table.Where(n => n.IngredientID == IngID).Select(n => n);
            CountPic = 5;
            foreach (var item in pic)
            {
                byte[] bytes = (byte[])(item.MerchandisePicture);
                PictureBox picbox = new PictureBox();
                System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                picbox.Image = Image.FromStream(ms);
                picbox.SizeMode = PictureBoxSizeMode.StretchImage;
                flp_Pics.Controls.Add(picbox);
                picbox.DoubleClick += Picbox_DoubleClick;
                picbox.Name = item.MerchandisePicID.ToString();
                CountPic--;
            }
        }

       
        private void Picbox_DoubleClick(object sender, EventArgs e)
        {
            DeliciousEntities dbcontext = new DeliciousEntities();
            PictureBox picdelete = (PictureBox)sender;
            int DeleteID = Convert.ToInt32(picdelete.Name);
            var pic = (dbcontext.Merchandise_Picture_Table.Where(n => n.MerchandisePicID== DeleteID).Select(n => n)).FirstOrDefault();
            dbcontext.Merchandise_Picture_Table.Remove(pic);
            dbcontext.SaveChanges();
            ShowPic();

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CancelEdit_Click(object sender, EventArgs e)
        {
            FormContent();
        }
        List<int> IDsForSearch = new List<int>();
        int countforIDs;
        private void tb_Srh_TextChanged(object sender, EventArgs e)
        {
            countforIDs = 0;
            IDsForSearch.Clear();

          

            for (int i =0;i<this.dataGridView1.Rows.Count;i++)
            {
                if(this.dataGridView1.Rows[i].Cells["食材名稱"].Value.ToString().Contains(this.tb_SrhIng.Text))
                IDsForSearch.Add(i);
                    }
          if (IDsForSearch.Count == 0) { MessageBox.Show("未有此食材名稱"); return; } 
            this.bindingSource1.Position = IDsForSearch[0];
         
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            if (IDsForSearch.Count == 0) { MessageBox.Show("未有此食材名稱"); return; }
            countforIDs--;
            if (countforIDs < 0) { countforIDs = 0; }
            this.bindingSource1.Position = IDsForSearch[countforIDs];
          
            

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (IDsForSearch.Count <= 0) { MessageBox.Show("未有此食材名稱");return; }
            countforIDs++;
            if (countforIDs >= IDsForSearch.Count) { countforIDs = IDsForSearch.Count-1; } 
            this.bindingSource1.Position = IDsForSearch[countforIDs];
         
        }

        private void btn_CancelSrh_Click(object sender, EventArgs e)
        {
            FormContent();
            this.bindingSource1.Position = 0;
            this.tb_SrhIng.Text = "";
        }

     

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DeliciousEntities dbcontext = new DeliciousEntities();
            var countused = dbcontext.Ingredient_Record_Table.Where(n => n.IngredientID == IngID).Select(n => n).Count();
            if (countused > 0) { MessageBox.Show("此食材已被使用過，無法刪除"); return; }
          
         
            FrmAnswerYesNo yesNoFrm = new FrmAnswerYesNo(IngID);
            yesNoFrm.ShowDialog();
            GetDataForIng();
            this.bindingSource1.Position = 0;
        }

       
    }
}
