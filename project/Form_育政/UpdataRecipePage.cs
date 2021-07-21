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
using project.Form_Kuan;

namespace project.Form_育政
{
    public partial class UpdataRecipePage : Form
    {
        DeliciousEntities Delicious = new DeliciousEntities();
        int NowID;
        public UpdataRecipePage(int RecipeID)
        {
            InitializeComponent();
            NowID = RecipeID;
            LoadElement();
            LoadRecipe(RecipeID);

        }
        byte[] RecipeByte; //食譜照存取

        List<int> ID_List = new List<int>();                  //食材暫存區
        List<double> ForUse_List = new List<double>();
        List<string> Unt_List = new List<string>();

        List<string> Step_List = new List<string>();       //步驟暫存
        List<byte[]> StepImg_List = new List<byte[]>();

        private void LoadElement()
        {
            var RecipeCategoryName = from n in Delicious.RecipeCategory_Table
                                     select n.RecipeCategory;
            var Now = Delicious.Recipe_Table.Where(A => A.RecipeID == NowID).Select(A => A.RecipeCategory_Table.RecipeCategory).FirstOrDefault();


            this.cb_RecipeCategory.DataSource = RecipeCategoryName.ToList(); //食譜類別欄資料           
            this.cb_RecipeCategory.SelectedItem = Now;

            var IngredientCategoryName = Delicious.IngredientCategory_Table.Select(N => N.IngredientCategory);
            this.cb_IngredientCategory.DataSource = IngredientCategoryName.ToList(); //食材類別欄
            this.cb_IngredientCategory.SelectedItem = 1;

            CCustomerMsg Img = new CCustomerMsg();
            CCustomerMsg Img2 = new CCustomerMsg();//給予Picturebox拖拉
            Img.setPicturebox(pb_RecipeIMG);
            Img2.setPicturebox(pb_StepIMG);

        }
        private void cb_IngredientCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var IngredientName = Delicious.Ingredient_Table.AsEnumerable().Where(A => A.IngredientCategory_Table.IngredientCategory == cb_IngredientCategory.SelectedItem.ToString()).Select(A => A.Ingredient);

            this.cb_Ingredient.DataSource = IngredientName.ToList(); //灌入食材細項

        }

        private void LoadRecipe(int recipeID)
        {

            var Recipe = Delicious.Recipe_Table.Where(A => A.RecipeID == recipeID).Select(A => new
            {
                A.Picture,
                A.RecipeName,
                A.RecipeDescription,
                A.ForHowMany,
                A.TimeNeed,
                A.Video,
                RecipeCategory = Delicious.RecipeCategory_Table.Where(B => B.RecipeCategoryID == A.RecipeCategoryID).Select(B => B.RecipeCategory),
                Ingredients = Delicious.Ingredient_Record_Table.Where(C => C.RecipeID == A.RecipeID).Select(C => new
                {
                    IngredientName = Delicious.Ingredient_Table.Where(D => D.IngredientID == C.IngredientID).Select(D => D.Ingredient).FirstOrDefault(),
                    ForUse = Delicious.Ingredient_Record_Table.Select(I => I.IngredientAmountForUse).FirstOrDefault(),
                    Unt = Delicious.Ingredient_Record_Table.Select(J => J.Unt).FirstOrDefault()
                }),
                Steps = Delicious.Steps_Table.Where(F => F.RecipeID == A.RecipeID).Select(F => new {
                    F.StepsNumber,
                    F.Steps,
                    //F.Picture
                })
            }).FirstOrDefault();

            if (Recipe.Picture != null)
            {
                MemoryStream memory = new MemoryStream(Recipe.Picture);
                pb_RecipeIMG.Image = Image.FromStream(memory);
            }
            tb_RecipeName.Text = Recipe.RecipeName;
            cb_RecipeCategory.SelectedItem = Recipe.RecipeCategory.ToString();
            tb_Howmany.Text = $"{Recipe.ForHowMany}";
            tb_Time.Text = $"{(Recipe.TimeNeed / 60)}";
            tb_RecipeDescription.Text = $"{Recipe.RecipeDescription}";

            var IngredientID = Delicious.Ingredient_Record_Table.Where(K => K.RecipeID == recipeID && K.IngredientID == K.Ingredient_Table.IngredientID).Select(K => K.IngredientID).ToList();
            foreach (var id in IngredientID)
            {
                ID_List.Add(id);
            }

            foreach (var item in Recipe.Ingredients)
            {
                lbox_Ingredient.Items.Add($"{item.IngredientName}{item.ForUse}{item.Unt}");
                ForUse_List.Add(item.ForUse);
                Unt_List.Add(item.Unt);
            }

            var S_Img = Delicious.Steps_Table.Where(F => F.RecipeID == recipeID).Select(F => F.Picture).ToList();
            foreach (var img in S_Img)
            {
                StepImg_List.Add(img);
            }

            foreach (var step in Recipe.Steps)
            {
                Step_List.Add(step.Steps);
                lbox_Step.Items.Add(step.Steps);
            }
        }

        private void lbox_Step_MouseClick(object sender, MouseEventArgs e)
        {
            int index = lbox_Step.IndexFromPoint(e.X, e.Y);
            lbox_Step.SelectedIndex = index;
            var IMG = Delicious.Steps_Table.AsEnumerable().Where(A => A.RecipeID == NowID && A.StepsNumber == lbox_Step.IndexFromPoint(e.X, e.Y)).Select(A => A.Picture).FirstOrDefault();
            if (IMG != null)
            {
                MemoryStream memory = new MemoryStream(IMG);
                pb_StepIMG.Image = Image.FromStream(memory);
            }
        }

        private void tb_RecipeName_KeyPress(object sender, KeyPressEventArgs e) //僅能輸入中文與英文
        {
            Regex rg = new Regex("^[\u4e00-\u9fa5a-zA-Z\b]$");
            if (!rg.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void tb_Howmany_KeyPress(object sender, KeyPressEventArgs e) //僅數字
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

        private void tb_Time_KeyPress(object sender, KeyPressEventArgs e) //僅數字
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

        private void tb_ForUse_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tb_Unt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex rg = new Regex("^[\u4e00-\u9fa5a-zA-Z\b]$");
            if (!rg.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void btn_AddIngredient_Click(object sender, EventArgs e)
        {
            try
            {

                var IngredienID = Delicious.Ingredient_Table.AsEnumerable().Where(a => a.Ingredient == cb_Ingredient.SelectedItem.ToString()).Select(a => a.IngredientID).FirstOrDefault();


                double A;

                if (double.TryParse(tb_ForUse.Text, out A) && tb_Unt.Text != "")
                {

                    tb_ForUse.Text = A.ToString("#.##");
                    this.lbox_Ingredient.Items.Add($"{cb_Ingredient.Text} {tb_ForUse.Text} {tb_Unt.Text}");
                    ID_List.Add(IngredienID);
                    ForUse_List.Add(Convert.ToDouble(tb_ForUse.Text));
                    Unt_List.Add(tb_Unt.Text);
                }
                else
                {
                    MessageBox.Show("數量及單位其一不得為空", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("缺少必要資料", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_RemoveIngredient_Click(object sender, EventArgs e)
        {
            try
            {
                int i = this.lbox_Ingredient.SelectedIndex;
                this.lbox_Ingredient.Items.RemoveAt(i);
                ID_List.RemoveAt(i);
                ForUse_List.RemoveAt(i);
                Unt_List.RemoveAt(i);
            }
            catch (Exception)
            {
                MessageBox.Show("無選中之資料可刪除", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_AddStep_Click(object sender, EventArgs e)
        {
            MemoryStream memory = new MemoryStream();
            if (tb_Step.Text != "")
            {
                if (pb_StepIMG.Image != null)
                {
                    pb_StepIMG.Image.Save(memory, ImageFormat.Png);
                    StepImg_List.Add(memory.GetBuffer());
                }
                else
                {
                    StepImg_List.Add(new byte[0]);
                }
                Step_List.Add(tb_Step.Text);
                lbox_Step.Items.Add($"{tb_Step.Text}");
                pb_StepIMG.Image = null; //新增完清除資料
                tb_Step.Text = "";  //同上
            }
            else
            {
                MessageBox.Show("步驟欄不得為空", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_RemoveStep_Click(object sender, EventArgs e)
        {
            try
            {
                int i = this.lbox_Step.SelectedIndex;
                this.lbox_Step.Items.RemoveAt(i);
                this.Step_List.RemoveAt(i);
                this.StepImg_List.RemoveAt(i);
                this.pb_StepIMG.Image = null;
            }
            catch (Exception)
            {
                MessageBox.Show("無項目可刪除", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("放棄編輯?", "通知", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確認更正?", "通知", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {              
                if (tb_RecipeName.Text == null)
                {
                    MessageBox.Show("未填寫食譜名稱", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
                else if (pb_RecipeIMG.Image == null) //判斷是否未上傳圖片
                {
                    MessageBox.Show("食譜圖片不得為空", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tb_Howmany.Text == "" || tb_Time.Text == "") //判斷是否為空
                {
                    MessageBox.Show("人數及時間欄位不得為空", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tb_RecipeDescription.Text == "")
                {
                    MessageBox.Show("食譜描述不得為空", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tb_Video.Text != "" && (!tb_Video.Text.Contains("youtu.be") && !tb_Video.Text.Contains("youtube"))) //判斷是否為Youtube網址
                {
                    MessageBox.Show("非YouTube網址", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(ID_List.Count == 0)
                {
                    MessageBox.Show("食譜食材不得為空", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(Step_List.Count == 0)
                {
                    MessageBox.Show("步驟不可為空", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else //全部確認完成
                {
                    
                    MemoryStream memory = new MemoryStream();
                    pb_RecipeIMG.Image.Save(memory, ImageFormat.Png);
                    RecipeByte = memory.GetBuffer();

                    var Update = Delicious.Recipe_Table.AsEnumerable().Where(A => A.RecipeID == NowID).Select(A => A);
                    foreach (var item in Update)
                    {
                        item.Picture = RecipeByte;
                        item.RecipeName = tb_RecipeName.Text;
                        item.RecipeDescription = tb_RecipeDescription.Text;
                        item.RecipeCategoryID = cb_RecipeCategory.SelectedIndex + 1;
                        item.ForHowMany = Convert.ToInt32(tb_Howmany.Text);
                        item.TimeNeed = Convert.ToInt32(tb_Time.Text);
                        item.Video = tb_Video.Text;
                    }
                    Delicious.SaveChanges();

                    var Update2 = Delicious.Ingredient_Record_Table.AsEnumerable().Where(B => B.RecipeID == NowID);
                    Delicious.Ingredient_Record_Table.RemoveRange(Update2);
                    Delicious.SaveChanges();
                    for (int i = 0; i < ID_List.Count; i++)
                    {
                        var Ingredient = new Ingredient_Record_Table()
                        {
                            IngredientID = ID_List[i],
                            RecipeID = NowID,
                            Unt = Unt_List[i],
                            IngredientAmountForUse = ForUse_List[i],
                        };
                        Delicious.Ingredient_Record_Table.Add(Ingredient);
                    }
                    Delicious.SaveChanges();

                    var Update3 = Delicious.Steps_Table.AsEnumerable().Where(C => C.RecipeID == NowID);
                    Delicious.Steps_Table.RemoveRange(Update3);
                    Delicious.SaveChanges();

                    for (int i = 0; i < Step_List.Count; i++)
                    {
                        var AddStep = new Steps_Table()
                        {
                            RecipeID = NowID,
                            StepsNumber = i + 1,
                            Steps = Step_List[i],
                            Picture = StepImg_List[i]
                        };
                        Delicious.Steps_Table.Add(AddStep);
                    }
                    Delicious.SaveChanges();
                    MessageBox.Show("修改成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
