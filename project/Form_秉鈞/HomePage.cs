using m_project;
using project;
using project.Form_Kuan;
using project.Form_育政;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project.Form_瑋;
using project.Form_明萱;
using MarketPages;
using project.Model_秉鈞;

namespace Delicious_Kashir
{
    public partial class HomePage : Form
    {
        DeliciousEntities dbcontext = new DeliciousEntities();
        SearchByTagClass sbt = new SearchByTagClass();
        public CMember memberData { get; set; }
        public HomePage()
        {
            InitializeComponent();
            this.PageControl.SelectedIndex = 0;
            cb_Sort.SelectedIndex = 1;
            memberData = Viewbag.member;
            if (Viewbag.member != null)
            {
                lb_User.Text = "您好!親愛的 "+memberData.Nickname;
                btn_Login.Text = "個人頁面";
                btn_Login.Click -= btn_Login_Click;
                btn_Login.Click += btn_PersonPage_Click;
                try
                {
                    pb_figure.Image = Image.FromFile(memberData.Figure);
                }
                catch (Exception)
                {
                    MessageBox.Show("找不到頭貼路徑");
                }
            }
            LinkLabels.Add(linkLabel1);
            LinkLabels.Add(linkLabel2);
            LinkLabels.Add(linkLabel3);
            LinkLabels.Add(linkLabel4);
            LinkLabels.Add(linkLabel5);
            checkBox1.Hide();
            Load_All_recipe();
            Load_Hot_recipe();
            Load_Hot_Search();
            linkLabel2.Left = linkLabel1.Left + linkLabel1.Width + 10;
            linkLabel3.Left = linkLabel2.Left + linkLabel2.Width + 10;
            linkLabel4.Left = linkLabel3.Left + linkLabel3.Width + 10;
            linkLabel5.Left = linkLabel4.Left + linkLabel4.Width + 10;
            linkOther.Left = linkLabel5.Left + linkLabel5.Width + 10;
        }

        private void Load_All_recipe()
        {
            var q = (from r in dbcontext.Recipe_Table.AsEnumerable()
                    let like = (from r2 in dbcontext.LikeRecipe_Table.AsEnumerable() where r2.RecipeID == r.RecipeID select r2).Count()
                    select new
                    {
                        r.RecipeID,
                        r.Picture,
                        r.RecipeName,
                        r.Member_Table.Nickname,
                        r.Views,
                        like = like
                    }).ToList();
            foreach (var item in q)
            {
                RecipeControl recipe = new RecipeControl(item.RecipeID);
                recipe.setAll(item.Picture,item.RecipeName,item.Nickname,item.Views,item.like); 
                flp_AllRecipe.Controls.Add(recipe);
            }
        }

        List<LinkLabel> LinkLabels = new List<LinkLabel>();
        private void Load_Hot_Search()
        {
            var q = ((from r in dbcontext.Recipe_Table
                      where r.DisVisible == false && r.DeleteOrNot == false
                      orderby r.Views descending
                      select r.RecipeName).Take(5)).ToList();
            for (int i = 0; i < LinkLabels.Count; i++)
            {
                LinkLabels[i].Text = q[i];
            }
        }
        private void Load_Hot_recipe() //點選切換跳轉
        {
            PageControl.SelectedIndex = 1;

            var q = ((from l in dbcontext.LikeRecipe_Table.AsEnumerable()
                     group l by new
                      {
                          l.Recipe_Table.RecipeName,
                          l.RecipeID,
                          l.Recipe_Table.PostTime.Year,
                          l.Recipe_Table.DisVisible,
                          l.Recipe_Table.DeleteOrNot,
                          l.Member_Table.Nickname,
                          l.Recipe_Table.Picture,
                          l.Recipe_Table.Views,
                          season = SeasonSort(l.Recipe_Table.PostTime.Month)
                      } into g
                      where g.Key.season == "第二季" && g.Key.Year == DateTime.Now.Year && g.Key.DisVisible == false && g.Key.DeleteOrNot == false
                      select new
                      {
                          g.Key.RecipeName,
                          g.Key.RecipeID,
                          g.Key.Nickname,
                          g.Key.Picture,
                          g.Key.Views,
                          LikeCount = g.Count(),
                      }).OrderByDescending(r => r.LikeCount).Take(5)).ToList();

            foreach (var item in q)
            {
                RecipeControl recipe = new RecipeControl(item.RecipeID);
                recipe.setAll(item.Picture, item.RecipeName, item.Nickname, item.Views, item.LikeCount);
                flp_HotRecipe.Controls.Add(recipe);
            }
        }
        private string SeasonSort(int month)
        {
            if (month <= 3) return "第一季";
            else if (month <= 6) return "第二季";
            else if (month <= 9) return "第三季";
            else return "第四季";
        }

        private void btn_Category_Click(object sender, EventArgs e) //點選切換跳轉
        {
            PageControl.SelectedIndex = 1;
            Button b = sender as Button;
            Category_Search(b.Text);
        }

        private void Category_Search(string CategoryName)
        {
            var q = from r in dbcontext.Recipe_Table
                    let like = (from r2 in dbcontext.LikeRecipe_Table.AsEnumerable() where r2.RecipeID == r.RecipeID select r2).Count()
                    where r.RecipeCategory_Table.RecipeCategory == CategoryName && r.DeleteOrNot == false && r.DisVisible == false
                    select new
                    {
                        r.Picture,
                        r.RecipeName,
                        r.Member_Table.Nickname,
                        r.Views,
                        r.RecipeID,
                        like = like
                    };
            flp_Search.Controls.Clear();
            foreach (var item in q)
            {
                RecipeControl recipe = new RecipeControl(item.RecipeID);
                recipe.setAll(item.Picture, item.RecipeName, item.Nickname, item.Views, item.like);
                flp_Search.Controls.Add(recipe);
            }
        }

        private void pb_LogoBox_Click(object sender, EventArgs e) //點選切換跳轉
        {
            this.PageControl.SelectedIndex = 0;
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            List<Recipe_Table> recipes = new List<Recipe_Table>();

            PageControl.SelectedIndex = 1;
            if (cb_Sort.SelectedIndex == 0)
            {
                string s = tb_SearchValue.Text;
                string[] s2 = s.Split(' ');
                for (int i = 0; i < s2.Length; i++)
                {
                    var q = (from r in dbcontext.Recipe_Table.AsEnumerable()
                             where r.RecipeName.Contains(s2[i]) && r.DisVisible == false && r.DisVisible == false
                             select r).ToList();
                    if (q.Count != 0)
                    {
                        recipes.AddRange(q);
                    }
                }
                var q1 = from r in recipes
                         let like = (from r2 in dbcontext.LikeRecipe_Table.AsEnumerable() where r2.RecipeID == r.RecipeID select r2).Count()
                         select new
                         {
                             r.Picture,
                             r.RecipeName,
                             r.Member_Table.Nickname,
                             r.Views,
                             r.RecipeID,
                             like = like
                         };
                flp_Search.Controls.Clear();
                foreach (var item in q1)
                {
                    RecipeControl recipe = new RecipeControl(item.RecipeID);
                    recipe.setAll(item.Picture, item.RecipeName, item.Nickname, item.Views, item.like);
                    flp_Search.Controls.Add(recipe);
                }
            }

            if (cb_Sort.SelectedIndex == 1)
            {
                var q2 = (from r in dbcontext.Recipe_Table
                          let like = (from r2 in dbcontext.LikeRecipe_Table.AsEnumerable() where r2.RecipeID == r.RecipeID select r2).Count()
                          where r.Member_Table.Nickname.Contains(tb_SearchValue.Text) && r.DisVisible == false && r.DisVisible == false
                          select new
                          {
                              r.Picture,
                              r.RecipeName,
                              r.Member_Table.Nickname,
                              r.Views,
                              r.RecipeID,
                              like = like
                          }).ToList();
                if (q2.Count != 0)
                {
                    flp_Search.Controls.Clear();
                    foreach (var item in q2)
                    {
                        RecipeControl recipe = new RecipeControl(item.RecipeID);
                        recipe.setAll(item.Picture, item.RecipeName, item.Nickname, item.Views, item.like);
                        flp_Search.Controls.Add(recipe);
                    }
                }
                else
                {
                    MessageBox.Show("查無此作者");
                }
            }
            if (cb_Sort.SelectedIndex == 2)//食材找食譜
            {
                int[] tagids = sbt.IngdStringToIngdIds(dbcontext, tb_SearchValue.Text, checkBox1.Checked);
                int[] recipeids = sbt.IngdIdsToRecipeIds(dbcontext, tagids, !checkBox2.Checked);
                var hrecipes = dbcontext.Recipe_Table.Where(r => recipeids.Contains(r.RecipeID) && r.DisVisible == false && r.DeleteOrNot == false).Select(r => r);
                var hrecipes2 = (from r in hrecipes
                                let like = (from r2 in dbcontext.LikeRecipe_Table.AsEnumerable() where r2.RecipeID == r.RecipeID select r2).Count()
                                select new
                                {
                                    r.Picture,
                                    r.RecipeName,
                                    r.Member_Table.Nickname,
                                    r.Views,
                                    r.RecipeID,
                                    like = like
                                }).ToList();
                flp_Search.Controls.Clear();
                foreach (var item in hrecipes2)
                {
                    RecipeControl recipe = new RecipeControl(item.RecipeID);
                    recipe.setAll(item.Picture, item.RecipeName, item.Nickname, item.Views, item.like);
                    flp_Search.Controls.Add(recipe);
                }

                string stchar = "TagIds:";
                foreach (int id in tagids)
                {
                    stchar += id.ToString() + ",";
                }
            }
            if (cb_Sort.SelectedIndex == 3)//HashTag找食譜
            {
                int[] tagids = sbt.TagsStringToTagIds(dbcontext, tb_SearchValue.Text, checkBox1.Checked);
                int[] recipeids = sbt.TagIdsToRecipeIds(dbcontext, tagids, !checkBox2.Checked);
                var hrecipes = dbcontext.Recipe_Table.Where(r => recipeids.Contains(r.RecipeID)&&r.DisVisible == false && r.DeleteOrNot == false).Select(r => r);
                var hrecipes2 = (from r in hrecipes
                                 let like = (from r2 in dbcontext.LikeRecipe_Table.AsEnumerable() where r2.RecipeID == r.RecipeID select r2).Count()
                                 select new
                                 {
                                     r.Picture,
                                     r.RecipeName,
                                     r.Member_Table.Nickname,
                                     r.Views,
                                     r.RecipeID,
                                     like = like
                                 }).ToList();
                flp_Search.Controls.Clear();
                foreach (var item in hrecipes2)
                {
                    RecipeControl recipe = new RecipeControl(item.RecipeID);
                    recipe.setAll(item.Picture, item.RecipeName, item.Nickname, item.Views, item.like);
                    flp_Search.Controls.Add(recipe);
                }

                string stchar = "TagIds:";
                foreach (int id in tagids)
                {
                    stchar += id.ToString() + ",";
                }
            }

        }

        private void add_recipe_Click(object sender, EventArgs e)
        {
            AddRecipePage Recipe_Form = new AddRecipePage();
            Recipe_Form.Show();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            login f = new login();
            f.Show();
        }
        private void btn_PersonPage_Click(object sender, EventArgs e)
        {
            PersonalPage f = new PersonalPage(memberData.MemberID);
            f.Show();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            FCustomerMsg fCustomerMsg = new FCustomerMsg();
            fCustomerMsg.Show();
        }

        private void btn_Message_Click(object sender, EventArgs e)
        {
            FCustomerchat fCustomerchat = new FCustomerchat();
            fCustomerchat.Show();
        }

        private void cb_Sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cb_Sort.SelectedIndex == 2) || (cb_Sort.SelectedIndex == 3))
            {
                checkBox1.Show();
                checkBox2.Show();
            }
            else
            {
                checkBox1.Hide();
                checkBox2.Hide();
            }
        }

        private void tb_SearchValue_TextChanged(object sender, EventArgs e)
        {
            if (cb_Sort.SelectedIndex == 2) sbt.IngdTips(dbcontext, tb_SearchValue, toolTip1);
            else if (cb_Sort.SelectedIndex == 3) sbt.TagTips(dbcontext, tb_SearchValue, toolTip1);
            else return;
        }

        private void btn_Level_Click(object sender, EventArgs e)
        {
            MemberRankForm f = new MemberRankForm();
            f.Show();
        }
        
        private void btn_Shop_Click(object sender, EventArgs e)
        {
           Market NM = new Market();
            NM.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var q = dbcontext.Recipe_Table.Where(r => r.RecipeName == linkLabel1.Text).Select(r => r.RecipeID).FirstOrDefault();
            RecipePage recipePage = new RecipePage(q);
            recipePage.ShowDialog();
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var q = dbcontext.Recipe_Table.Where(r => r.RecipeName == linkLabel2.Text).Select(r => r.RecipeID).FirstOrDefault();
            RecipePage recipePage = new RecipePage(q);
            recipePage.ShowDialog();
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var q = dbcontext.Recipe_Table.Where(r => r.RecipeName == linkLabel3.Text).Select(r => r.RecipeID).FirstOrDefault();
            RecipePage recipePage = new RecipePage(q);
            recipePage.ShowDialog();
        }
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var q = dbcontext.Recipe_Table.Where(r => r.RecipeName == linkLabel4.Text).Select(r => r.RecipeID).FirstOrDefault();
            RecipePage recipePage = new RecipePage(q);
            recipePage.ShowDialog();
        }
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var q = dbcontext.Recipe_Table.Where(r => r.RecipeName == linkLabel5.Text).Select(r => r.RecipeID).FirstOrDefault();
            RecipePage recipePage = new RecipePage(q);
            recipePage.ShowDialog();
        }

        private void linkOther_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TagForm tf = new TagForm();
            tf.Show();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            this.PageControl.SelectedIndex = 0;
        }
    }
}
