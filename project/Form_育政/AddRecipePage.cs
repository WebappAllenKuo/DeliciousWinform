using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;

namespace project.Form_育政
{
    public partial class AddRecipePage : Form
    {
        public AddRecipePage()
        {
            InitializeComponent();
            this.tab_AddIngredient.Parent = null; //隱藏
            this.tab_AddStep.Parent = null; //隱藏
            this.tab_AddRecipe.Parent = this.tabControl1; //顯示
        }
        DeliciousEntities Delicious = new DeliciousEntities();

        //==================================================================================================================
        private void AddRecipePage_Load(object sender, EventArgs e) //視窗讀取並匯入資料
        {
            var CategoryName = from n in Delicious.RecipeCategory_Table
                               select n.RecipeCategory;

            this.cb_CategoryName.DataSource = CategoryName.ToList(); //類別欄資料
            this.cb_CategoryName.SelectedIndex = -1;

            this.pb_RecipeIMG.AllowDrop = true;
            this.pb_RecipeIMG.DragDrop += Pb_RecipeIMG_DragDrop;
            this.pb_RecipeIMG.DragEnter += Pb_RecipeIMG_DragEnter;

            this.pb_StepIMG.AllowDrop = true;
            this.pb_StepIMG.DragDrop += Pb_StepIMG_DragDrop;
            this.pb_StepIMG.DragEnter += Pb_StepIMG_DragEnter;
        }

        private void Pb_StepIMG_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void Pb_StepIMG_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string filename = (e.Data.GetData((DataFormats.FileDrop)) as string[])[0]; //取得檔案位置
                if (pb_StepIMG.Image != null) //判斷PictureBox是否有圖片
                {
                    pb_StepIMG.Image = null; //清除PictureBox裡的圖片                   
                }
                pb_StepIMG.Image = Image.FromFile(filename); //顯示
            }
            catch (Exception)
            {
                MessageBox.Show("非圖片格式", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pb_RecipeIMG_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy; //拖曳效果
        }

        byte[] RecipeByte;
        private void Pb_RecipeIMG_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                MemoryStream memory = new MemoryStream();             
                string filename = (e.Data.GetData((DataFormats.FileDrop)) as string[])[0]; //取得檔案位置
                if (pb_RecipeIMG.Image != null) //判斷PictureBox是否有圖片
                {
                    pb_RecipeIMG.Image = null; //清除PictureBox裡的圖片                   
                }
                pb_RecipeIMG.Image = Image.FromFile(filename); //顯示
                pb_RecipeIMG.Image.Save(memory, ImageFormat.Png);
                RecipeByte = memory.GetBuffer();
            }
            catch(Exception)
            {
               MessageBox.Show("非圖片格式", "錯誤",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
 
        }
     
        private void pb_RecipeIMG_DoubleClick(object sender, EventArgs e) //雙擊載入食譜圖片
        {
            MemoryStream memory = new MemoryStream();
            this.openIMGDialog.Filter = "*.jpg|*.jpg|*.png|*.png|*.jpeg|*.jpeg|*.bmp|*.bmp";
            if (this.openIMGDialog.ShowDialog() == DialogResult.OK)
            {
                this.pb_RecipeIMG.Image = Image.FromFile(this.openIMGDialog.FileName);
                pb_RecipeIMG.Image.Save(memory, ImageFormat.Png);
                RecipeByte = memory.GetBuffer();
            }

        }
        private void tb_RecipeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex rg = new Regex("^[\u4e00-\u9fa5a-zA-Z\b]$");
            if (!rg.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void tb_howmany_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex rg = new Regex(@"^[0-9]$");
            if (!rg.IsMatch(e.KeyChar.ToString()))
            {
                if (e.KeyChar == 8)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void tb_Time_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex rg = new Regex(@"^[0-9]$");
            if (!rg.IsMatch(e.KeyChar.ToString()))
            {
                if (e.KeyChar == 8 || e.KeyChar == 46)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void btn_OK_Click(object sender, EventArgs e) //確認食譜資料進入編輯食譜食材
        {
            string Name = tb_RecipeName.Text;
            string Howmany = tb_howmany.Text;
            string Time = tb_Time.Text;
            string URL = tb_Video.Text;
            double A;
            int B;

            if(tb_RecipeName.Text == null)
            {
                MessageBox.Show("未填寫食譜名稱", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cb_CategoryName.SelectedIndex == -1)
            {
                MessageBox.Show("尚未選擇分類", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pb_RecipeIMG.Image == null) //判斷是否未上傳圖片
            {
                MessageBox.Show("食譜圖片不得為空", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tb_howmany.Text=="" ||tb_Time.Text == "") //判斷是否為空
            {
                MessageBox.Show("人數及時間欄位不得為空", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(tb_RecipeDescription.Text == "")
            {
                MessageBox.Show("食譜描述不得為空", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (URL != "" && (!URL.Contains("youtu.be") && !URL.Contains("youtube"))) //判斷是否為Youtube網址
            {
                MessageBox.Show("非YouTube網址", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double.TryParse(Time, out A);
                int.TryParse(Howmany, out B);                
                tb_Time.Text = A.ToString();
                tb_howmany.Text = B.ToString();
                this.tab_AddRecipe.Parent = null;  //確認資料正確性後轉入增加食材頁面
                this.tab_AddIngredient.Parent = this.tabControl1;
                Load_Ingredient();
            }            
        }
//==================================================================================================================

        private void Load_Ingredient() //按下確認食譜後載入生鮮食材類別
        {
            var IngredientCategoryName = from n in Delicious.IngredientCategory_Table
                                 select n.IngredientCategory;

            this.cb_IngredientCategory.DataSource = IngredientCategoryName.ToList();
            //this.cb_IngredientCategory.SelectedIndex = -1;
        }

        private void cb_IngredientCategory_SelectionChangeCommitted(object sender, EventArgs e) //點選主大類後顯示細項
        {
            var IngredientName = from n in Delicious.Ingredient_Table
                                 where n.IngredientCategory_Table.IngredientCategory == cb_IngredientCategory.SelectedItem.ToString()
                                 select n.Ingredient;

            this.cb_Ingredient.DataSource = IngredientName.ToList();
        }
        List<int> ID_List = new List<int>();
        List<double> ForUse_List = new List<double>();
        List<string> Unt_List = new List<string>();
        private void btn_Add_Click(object sender, EventArgs e) //加入list顯示,並暫存於List
        {
            try
            {
                var IngredienID = from n in Delicious.Ingredient_Table
                                  where n.Ingredient == cb_Ingredient.SelectedItem.ToString()
                                  select n.IngredientID;
                int ID = 0;
                foreach (var item in IngredienID)
                {
                    ID = item;
                }
                double A;
                /*(Regex.IsMatch(tb_Foruse.Text, @"^[0-9]+$") || Regex.IsMatch(tb_Foruse.Text,@"^[0-9]+.[0-9]{1,2}$")) && */
                if (double.TryParse(tb_Foruse.Text,out A) && tb_Unt.Text!="")
                {

                    tb_Foruse.Text = A.ToString("#.##");
                    this.Ingredient_listBox.Items.Add($"{cb_Ingredient.Text} {tb_Foruse.Text} {tb_Unt.Text}");
                    ID_List.Add(ID);
                    ForUse_List.Add(Convert.ToDouble(tb_Foruse.Text));
                    Unt_List.Add(tb_Unt.Text);
                }               
                else
                { 
                    MessageBox.Show("數量及單位其一不得為空", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception)
            {
                MessageBox.Show("缺少必要資料", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e) //刪除選中項目
        {
            try
            {
                int i = this.Ingredient_listBox.SelectedIndex;
                this.Ingredient_listBox.Items.RemoveAt(i);
                ID_List.RemoveAt(i);
                ForUse_List.RemoveAt(i);
                Unt_List.RemoveAt(i);
            }
            catch (Exception)
            {
                MessageBox.Show("無選中之資料可刪除", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tb_Unt_KeyPress(object sender, KeyPressEventArgs e) //tb_Unt欄位禁止輸入數字及標點符號等無意義字串
        {
            Regex rg = new Regex("^[\u4e00-\u9fa5a-zA-Z\b]$");
            if (!rg.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
        private void tb_Foruse_KeyPress(object sender, KeyPressEventArgs e) //tb_Foruse欄位禁止輸入非數字等無意義字串
        {
            Regex rg = new Regex( @"^[0-9]$");
            if (!rg.IsMatch(e.KeyChar.ToString()))
            {
                if (e.KeyChar == 8)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void btn_Previous_Click(object sender, EventArgs e) //返回上一頁
        {
            this.tab_AddIngredient.Parent = null; //隱藏           
            this.tab_AddRecipe.Parent = this.tabControl1; //顯示
        }

        private void btn_Next_Click(object sender, EventArgs e) //確認資料型態並前往下一頁
        {
            if(Ingredient_listBox.Items.Count == 0)
            {
                MessageBox.Show("請新增食譜食材", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.tab_AddIngredient.Parent = null; //隱藏           
                this.tab_AddStep.Parent = this.tabControl1; //顯示
            }
        }
//=========================================================================================================
        private void btn_Cancel3_Click(object sender, EventArgs e)
        {           
            this.tab_AddStep.Parent = null; //隱藏
            this.tab_AddIngredient.Parent = this.tabControl1; //顯示
        }

        private void pb_StepIMG_DoubleClick(object sender, EventArgs e)
        {
            this.openIMGDialog.Filter = "*.jpg|*.jpg|*.png|*.png|*.jpeg|*.jpeg|*.bmp|*.bmp";
            if (this.openIMGDialog.ShowDialog() == DialogResult.OK)
            {
                this.pb_StepIMG.Image = Image.FromFile(this.openIMGDialog.FileName);
            }
        }

        private void pb_StepIMG_Click(object sender, EventArgs e)
        {
            this.pb_StepIMG.Image = null;
        }

        List<string> Step = new List<string>();
        List<byte[]> Img = new List<byte[]>();       
        private void btn_StepAdd_Click(object sender, EventArgs e)
        {
            MemoryStream memory = new MemoryStream();
            if(tb_Step.Text != "")
            {
                if (pb_StepIMG.Image != null)
                {
                    pb_StepIMG.Image.Save(memory, ImageFormat.Png);
                    Img.Add(memory.GetBuffer());
                }
                else
                {
                    Img.Add(new byte[0]);
                }
                this.Step_listBox.Items.Add($"{tb_Step.Text}");
                Step.Add(tb_Step.Text);
                pb_StepIMG.Image = null; //新增完清除資料
                tb_Step.Text = "";  //同上    
            }
            else
            {
                MessageBox.Show("步驟欄不得為空", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_StepDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int i = this.Step_listBox.SelectedIndex;
                this.Step_listBox.Items.RemoveAt(i);
                this.Step.RemoveAt(i);
                this.Img.RemoveAt(i);
            }
            catch (Exception)
            {
                MessageBox.Show("無項目可刪除", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("確認新增?", "通知", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    var Recipe = new Recipe_Table()
                    {
                        MemberID = Viewbag.member.MemberID,
                        Picture = RecipeByte,
                        RecipeName = tb_RecipeName.Text,
                        RecipeCategoryID = cb_CategoryName.SelectedIndex + 1,
                        ForHowMany = Convert.ToInt32(tb_howmany.Text),
                        TimeNeed = Convert.ToInt32(tb_Time.Text) * 60,
                        RecipeDescription = tb_RecipeDescription.Text,
                        Video = tb_Video.Text,
                        PostTime = DateTime.Now,
                        ShareLink = "https://www.youtube.com/watch?v=072tU1tamd0",
                        DeleteOrNot = false,
                        DisVisible = false
                    };
                    Delicious.Recipe_Table.Add(Recipe);

                    Delicious.SaveChanges();

                    var NowRecipeID = (from A in Delicious.Recipe_Table
                                       select A.RecipeID).Max();

                    for (int i = 0; i < ID_List.Count; i++)
                    {
                        var Ingredient = new Ingredient_Record_Table()
                        {
                            IngredientID = ID_List[i],
                            RecipeID = NowRecipeID,
                            Unt = Unt_List[i],
                            IngredientAmountForUse = ForUse_List[i],

                        };
                        Delicious.Ingredient_Record_Table.Add(Ingredient);
                    }
                    Delicious.SaveChanges();

                    for (int i = 0; i < Step.Count; i++)
                    {
                        var AddStep = new Steps_Table()
                        {
                            RecipeID = NowRecipeID,
                            StepsNumber = i + 1,
                            Steps = Step[i],
                            Picture = Img[i]
                        };
                        Delicious.Steps_Table.Add(AddStep);
                    }
                    Delicious.SaveChanges();
                    MessageBox.Show("新增成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("新增失敗", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }     
    }
}
