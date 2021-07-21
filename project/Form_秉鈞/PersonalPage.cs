using Delicious_Kashir;
using project.Model_秉鈞;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class PersonalPage : Form
    {
        Judgment jdg = new Judgment();
        DeliciousEntities dbcontext = new DeliciousEntities();
        private CMember memberData { get; set; }
        string Formfile = "";
        int RecipeID = 0;
        int Recipeid = 0;
        public PersonalPage(int MemberID)
        {
            InitializeComponent();
            if (Viewbag.member.MemberID != MemberID)
            {
                var q = dbcontext.Member_Table.Where(m => m.MemberID == MemberID).FirstOrDefault();
                if (q != null)
                {
                    CMember c = new CMember();
                    c.getdata(q);
                    this.memberData = c;
                }
                tabPage1.Parent = null;
                tabPage4.Parent = null;
                btn_lkaddtocoln.Enabled = false;
                btn_lkdelike.Enabled = false;
            }
            else
            { 
                this.memberData = Viewbag.member;
            }

        }
        private void PersonalPage_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadFolder();
            LoadRecipe();
            LoadMyRecipe();
            dgv_likeload();
            cb_lksearchload();
            lbox_Folder.SelectedIndex = 0;
        }

        private void LoadMyRecipe()
        {
            var q = (from r in dbcontext.Recipe_Table
                    let like = (from r2 in dbcontext.LikeRecipe_Table.AsEnumerable() where r2.RecipeID == r.RecipeID select r2).Count()
                    where r.MemberID == memberData.MemberID 
                    select new
                    {
                        r.RecipeID,
                        r.Picture,
                        r.RecipeName,
                        r.Member_Table.Nickname,
                        r.Views,
                        like = like,
                        r.DisVisible,
                        r.DeleteOrNot
                    }).ToList();
            foreach (var item in q)
            {
                if (!item.DeleteOrNot && !item.DisVisible)
                {
                    RecipeControl recipe = new RecipeControl(item.RecipeID);
                    recipe.setAll(item.Picture, item.RecipeName, item.Nickname, item.Views, item.like);
                    flp_myRecipe.Controls.Add(recipe);
                }
                else if (item.DeleteOrNot)
                {
                    RecipeControl recipe = new RecipeControl(item.RecipeID,Color.Red);
                    recipe.setAll(item.Picture, "此食譜已刪除", item.Nickname, item.Views, item.like);
                    flp_myRecipe.Controls.Add(recipe);
                }
                else
                {
                    RecipeControl recipe = new RecipeControl(item.RecipeID,Color.Black);
                    recipe.setAll(item.Picture, "此食譜已被檢舉", item.Nickname, item.Views, item.like);
                    flp_myRecipe.Controls.Add(recipe);
                }
            }
        }

        private void LoadData()
        {
            var q = (from m in dbcontext.Member_Table
                     where m.AccountName == memberData.AccountName
                     select m).ToList();
            if (q[0].ConfirmedOrNot_email == true)
            {
                btn_EmailConfirm.Enabled = false;
                btn_EmailConfirm.Text = "Email(已認證)";
            }
            if (q[0].ConfirmedOrNot_email == true)
            {
                btn_CellPhoneConfirm.Enabled = false;
                btn_CellPhoneConfirm.Text = "手機號碼(已認證)";
            }
            try
            {
                this.pb_sticker.Image = Image.FromFile(q[0].Figure);
            }
            catch (Exception)
            {
                MessageBox.Show("找不到頭貼路徑");
            }
            var q2 = (from m in dbcontext.Member_Table.AsEnumerable()
                      where m.MemberID == memberData.MemberID
                      let RecipeCount = (from r in dbcontext.Recipe_Table.AsEnumerable() where r.MemberID == q[0].MemberID select r).Count()
                      let LikeRecipeCount = (from lr in dbcontext.LikeRecipe_Table.AsEnumerable() where lr.MemberID == q[0].MemberID select lr).Count()
                      select new
                      {
                          m,
                          m.Member_Rank_Table.RankName,
                          RecipeCount,
                          LikeRecipeCount
                      }).ToList()[0];

            lb_NickName.Text = q2.m.Nickname;
            lb_MemberRank.Text = q2.RankName;
            lb_RankScore.Text = q2.m.PersonalRankScore.ToString();
            lb_LikeRecipeCount.Text = q2.LikeRecipeCount.ToString();
            lb_RecipeCount.Text = q2.RecipeCount.ToString();
            lb_Info.Text = q2.m.Info;
            tb_MemberName.Text = q2.m.MemberName;
            tb_Nickname.Text = q2.m.Nickname;
            tb_Accountname.Text = q2.m.AccountName;
            birthdayPicker.Value = q2.m.Birthday;
            cb_gender.Text = q2.m.Gender;
            tb_email.Text = q2.m.Email;
            tb_cellnumber.Text = q2.m.CellNumber;
            tb_info.Text = q2.m.Info;
        }

        private void LoadFolder()
        {
            lbox_Folder.Items.Clear();
            lbox_FolderID.Items.Clear();
            var q = dbcontext.CollectionFolder_Table.Where(m => m.MemberID == memberData.MemberID).ToList();
            if (q[0] != null)
            {
                foreach (var item in q)
                {
                    lbox_Folder.Items.Add(item.CollectionFolder);
                }
                foreach (var item in q)
                {
                    lbox_FolderID.Items.Add(item.CollectionFolderID.ToString());
                }
            }
            //var q2 = from c in dbcontext.Collection_Table
            //         where c.CollectionID == c.CollectionFolder_Table.

        }
        private void LoadRecipe()
        {
            flp_LikeRecipe.Controls.Clear();
            int  result;
            if (int.TryParse(lbox_FolderID.Text, out result))
            {
                var q = (from c in dbcontext.Collection_Table.AsEnumerable()
                         let like = (from r2 in dbcontext.LikeRecipe_Table.AsEnumerable() where r2.RecipeID == c.ReicipeID select r2).Count()
                         where c.CollectionFolderID == result
                         select new 
                         { 
                             c.ReicipeID, 
                             c.Recipe_Table.RecipeName,
                             c.Recipe_Table.Member_Table.Nickname,
                             c.Recipe_Table.Picture,
                             c.Recipe_Table.Views,
                             like = like
                         }).ToList();
                foreach (var item in q)
                {
                    RecipeControl recipe = new RecipeControl(item.ReicipeID);
                    recipe.setAll(item.Picture, item.RecipeName, item.Nickname, item.Views, item.like);
                    recipe.ContextMenuStrip = contextMenuStrip1;
                    flp_LikeRecipe.Controls.Add(recipe);
                }

                //foreach (var item in q)
                //{
                //    Panel p = new Panel();
                //    Label l = new Label();
                //    PictureBox pb = new PictureBox();
                //    MemoryStream ms = new MemoryStream(item.Picture);
                //    pb.Image = Image.FromStream(ms);
                //    l.Text = item.RecipeName;
                //    pb.BackColor = Color.AliceBlue;
                //    p.Controls.Add(l);
                //    p.Controls.Add(pb);
                //    p.ContextMenuStrip = contextMenuStrip1;
                //    p.Name = item.ReicipeID.ToString();
                //    flp_LikeRecipe.Controls.Add(p);
                //}
            }
            else
            {
                return;
            }
        }

        private void dgv_likeload()
        {
            var q = this.dbcontext.LikeRecipe_Table.Where(m => m.MemberID == memberData.MemberID).Select(m => new
            {
                食譜類別 = m.Recipe_Table.RecipeCategory_Table.RecipeCategory,
                食譜名稱 = m.Recipe_Table.RecipeName,
                食譜簡述 = m.Recipe_Table.RecipeDescription,
                份數 = m.Recipe_Table.ForHowMany,
                製作時間 = m.Recipe_Table.TimeNeed,
                食譜編號 = m.RecipeID
            }).Distinct();

            this.dgv_like.DataSource = q.ToList();
            this.dgv_like.Columns["食譜編號"].Visible = false;

            if (this.dgv_like.CurrentRow != null)
            {
                RecipeID = (int)this.dgv_like.CurrentRow.Cells["食譜編號"].Value;
            }
        }

        private void cb_lksearchload()
        {
            var q = this.dbcontext.LikeRecipe_Table.Where(m => m.MemberID == memberData.MemberID).Select(m => m.Recipe_Table.RecipeCategory_Table.RecipeCategory).Distinct();

            this.cb_lksearch.Items.Add("全部");

            foreach (var item in q)
            {
                this.cb_lksearch.Items.Add(item);
            }

            this.cb_lksearch.SelectedIndex = 0;
        }

        private void btn_ChangePhoto_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "*.png|*.png|*.gif|*.gif|*.jpeg|*.jpeg";
            var q = (from m in dbcontext.Member_Table
                     where m.AccountName == memberData.AccountName
                     select m).ToList();
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (Bitmap myBitmap = new Bitmap(this.openFileDialog1.FileName))
                        {
                            //儲存圖片到 MemoryStream 物件，並且指定儲存影像之格式
                            myBitmap.Save(ms,ImageFormat.Png);
                            //設定資料流位置
                            ms.Position = 0;
                            //設定 buffer 長度
                            byte[] data = new byte[ms.Length];
                            //將資料寫入 buffer
                            ms.Read(data, 0, Convert.ToInt32(ms.Length));
                            //將所有緩衝區的資料寫入資料流
                            ms.Flush();
                            this.pb_sticker.Image = Image.FromStream(ms);
                        }
                    }
                    Formfile = $".\\..\\..\\Figure\\{memberData.AccountName}.png";
                    this.pb_sticker.Image.Save(Formfile, ImageFormat.Png);
                    if (q[0].Figure != Formfile)
                    {
                        Member_Table member = dbcontext.Member_Table.First(m => m.AccountName == memberData.AccountName);
                        member.Figure = Formfile;
                        dbcontext.SaveChanges();
                    }
                    MessageBox.Show("更改頭貼成功");
                }
                catch (Exception ex)
                {
                    
                }
            }
        }
        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            changePassword f = new changePassword();
            f.Show();
            this.Close();
        }

        private void btn_EmailConfirm_Click(object sender, EventArgs e)
        {
            EmailConfirm f = new EmailConfirm();
            f.Show();
            this.Close();
        }
        private void btn_CellPhoneConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("功能未開發");
        }

        private void btn_EditMembername_Click(object sender, EventArgs e)
        {
            tb_MemberName.Enabled = true;
            btn_EditMembername.Enabled = false;
            btn_OKMembername.Visible = true;
            btn_EditCancel.Visible = true;
        }
        private void btn_OKMembername_Click(object sender, EventArgs e)
        {
            string Error = jdg.NameJdg(tb_MemberName.Text);
            if (Error == null)
            {
                Member_Table member = dbcontext.Member_Table.First(m => m.AccountName == memberData.AccountName);
                member.MemberName = tb_MemberName.Text;
                try
                {
                    dbcontext.SaveChanges();
                    MessageBox.Show("更改成功");
                    tb_MemberName.Enabled = false;
                    btn_EditMembername.Enabled = true;
                    btn_OKMembername.Visible = false;
                    btn_EditCancel.Visible = false;
                    lb_ErrorMemberName.Visible = false;

                }
                catch (Exception)
                {
                    lb_ErrorMemberName.Visible = true;
                    lb_ErrorMemberName.Text = Error + "更改失敗,請聯絡管理員";
                }
            }
            else
            {
                lb_ErrorMemberName.Visible = true;
                lb_ErrorMemberName.Text = Error;
            }
        }

        private void btn_EditNickname_Click(object sender, EventArgs e)
        {
            tb_Nickname.Enabled = true;
            btn_EditNickname.Enabled = false;
            btn_OKNickname.Visible = true;
            btn_EditCancel2.Visible = true;
        }
        private void btn_OKNickname_Click(object sender, EventArgs e)
        {
            string Error = jdg.Nickname(tb_Nickname.Text);
            if (Error == null)
            {
                Member_Table member = dbcontext.Member_Table.First(m => m.AccountName == memberData.AccountName);
                member.Nickname = tb_Nickname.Text;
                try
                {
                    dbcontext.SaveChanges();
                    MessageBox.Show("更改成功");
                    tb_Nickname.Enabled = false;
                    btn_EditNickname.Enabled = true;
                    btn_OKNickname.Visible = false;
                    btn_EditCancel2.Visible = false;
                    lb_ErrorNickname.Visible = false;

                }
                catch (Exception)
                {
                    lb_ErrorNickname.Visible = true;
                    lb_ErrorNickname.Text = Error + "更改失敗,請聯絡管理員";
                }
            }
            else
            {
                lb_ErrorNickname.Visible = true;
                lb_ErrorNickname.Text = Error;
            }
        }

        private void btn_EditAccountName_Click(object sender, EventArgs e)
        {
            tb_Accountname.Enabled = true;
            btn_EditAccountName.Enabled = false;
            btn_OKAccountname.Visible = true;
            btn_EditCancel3.Visible = true;
        }
        private void btn_OKAccountname_Click(object sender, EventArgs e)
        {
            string Error = jdg.AccountJdg(tb_Accountname.Text);
            if (Error == null)
            {
                Member_Table member = dbcontext.Member_Table.First(m => m.AccountName == memberData.AccountName);
                member.AccountName = tb_Accountname.Text;
                try
                {
                    dbcontext.SaveChanges();
                    MessageBox.Show("更改成功");
                    tb_Accountname.Enabled = false;
                    btn_EditAccountName.Enabled = true;
                    btn_OKAccountname.Visible = false;
                    btn_EditCancel3.Visible = false;
                    lb_ErrorAccountName.Visible = false;

                }
                catch (Exception)
                {
                    lb_ErrorAccountName.Visible = true;
                    lb_ErrorAccountName.Text = Error + "更改失敗,請聯絡管理員";
                }
            }
            else
            {
                lb_ErrorAccountName.Visible = true;
                lb_ErrorAccountName.Text = Error;
            }
        }

        private void btn_EditGender_Click(object sender, EventArgs e)
        {
            cb_gender.Enabled = true;
            btn_EditGender.Enabled = false;
            btn_OKGender.Visible = true;
            btn_EditCancel4.Visible = true;
        }
        private void btn_OKGender_Click(object sender, EventArgs e)
        {
            Member_Table member = dbcontext.Member_Table.First(m => m.AccountName == memberData.AccountName);
            member.Gender = cb_gender.Text;
            try
            {
                dbcontext.SaveChanges();
                MessageBox.Show("更改成功");
                cb_gender.Enabled = false;
                btn_EditGender.Enabled = true;
                btn_OKGender.Visible = false;
                btn_EditCancel4.Visible = false;
                lb_ErrorGender.Visible = false;

            }
            catch (Exception)
            {
                lb_ErrorGender.Visible = true;
                lb_ErrorGender.Text = "更改失敗,請聯絡管理員";
            }
        }

        private void btn_EditEmail_Click(object sender, EventArgs e)
        {
            tb_email.Enabled = true;
            btn_EditEmail.Enabled = false;
            btn_OKEmail.Visible = true;
            btn_EditCancel5.Visible = true;
        }

        private void btn_OKEmail_Click(object sender, EventArgs e)
        {
            string Error = jdg.EmailJdg(tb_email.Text);
            if (Error == null)
            {
                Member_Table member = dbcontext.Member_Table.First(m => m.AccountName == memberData.AccountName);
                member.Email = tb_email.Text;
                try
                {
                    dbcontext.SaveChanges();
                    MessageBox.Show("更改成功");
                    tb_email.Enabled = false;
                    btn_EditEmail.Enabled = true;
                    btn_OKEmail.Visible = false;
                    btn_EditCancel5.Visible = false;
                    lb_ErrorEmail.Visible = false;

                }
                catch (Exception)
                {
                    lb_ErrorEmail.Visible = true;
                    lb_ErrorEmail.Text = Error + "更改失敗,請聯絡管理員";
                }
            }
            else
            {
                lb_ErrorEmail.Visible = true;
                lb_ErrorEmail.Text = Error;
            }
        }

        private void btn_EditCellphone_Click(object sender, EventArgs e)
        {
            tb_cellnumber.Enabled = true;
            btn_EditCellphone.Enabled = false;
            btn_OKCellphone.Visible = true;
            btn_EditCancel6.Visible = true;
        }
        private void btn_OKCellphone_Click(object sender, EventArgs e)
        {
            string Error = jdg.CellNumberJdg(tb_cellnumber.Text);
            if (Error == null)
            {
                Member_Table member = dbcontext.Member_Table.First(m => m.AccountName == memberData.AccountName);
                member.CellNumber = tb_cellnumber.Text;
                try
                {
                    dbcontext.SaveChanges();
                    MessageBox.Show("更改成功");
                    tb_cellnumber.Enabled = false;
                    btn_EditCellphone.Enabled = true;
                    btn_OKCellphone.Visible = false;
                    btn_EditCancel6.Visible = false;
                    lb_ErrorCellphone.Visible = false;

                }
                catch (Exception)
                {
                    lb_ErrorCellphone.Visible = true;
                    lb_ErrorCellphone.Text = Error + "更改失敗,請聯絡管理員";
                }
            }
            else
            {
                lb_ErrorCellphone.Visible = true;
                lb_ErrorCellphone.Text = Error;
            }
        }

        private void btn_EditInfo_Click(object sender, EventArgs e)
        {
            tb_info.Enabled = true;
            btn_EditInfo.Enabled = false;
            btn_OKInfo.Visible = true;
            btn_EditCancel7.Visible = true;
        }
        private void btn_OKInfo_Click(object sender, EventArgs e)
        {
            Member_Table member = dbcontext.Member_Table.First(m => m.AccountName == memberData.AccountName);
            member.Info = tb_info.Text;
            try
            {
                dbcontext.SaveChanges();
                MessageBox.Show("更改成功");
                tb_info.Enabled = false;
                btn_EditInfo.Enabled = true;
                btn_OKInfo.Visible = false;
                btn_EditCancel7.Visible = false;
                lb_ErrorEmail.Visible = false;

            }
            catch (Exception)
            {
                lb_ErrorEmail.Visible = true;
                lb_ErrorEmail.Text = "更改失敗,請聯絡管理員";
            }
            LoadData();
        }

        private void btn_EditCancel_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;

            tb_MemberName.Enabled = false;
            tb_Nickname.Enabled = false;
            tb_Accountname.Enabled = false;
            cb_gender.Enabled = false;
            tb_email.Enabled = false;
            tb_cellnumber.Enabled = false;
            tb_info.Enabled = false;

            btn_EditMembername.Enabled = true;
            btn_EditNickname.Enabled = true;
            btn_EditAccountName.Enabled = true;
            btn_EditGender.Enabled = true;
            btn_EditEmail.Enabled = true;
            btn_EditCellphone.Enabled = true;
            btn_EditInfo.Enabled = true;

            btn_OKMembername.Visible = false;
            btn_OKNickname.Visible = false;
            btn_OKAccountname.Visible = false;
            btn_OKGender.Visible = false;
            btn_OKEmail.Visible = false;
            btn_OKCellphone.Visible = false;
            btn_OKInfo.Visible = false;

            lb_ErrorMemberName.Visible = false;
            lb_ErrorNickname.Visible = false;
            lb_ErrorAccountName.Visible = false;
            lb_ErrorGender.Visible = false;
            lb_ErrorEmail.Visible = false;
            lb_ErrorCellphone.Visible = false;

            b.Visible = false;
            LoadData();
        }

        private void btn_AddFolder_Click(object sender, EventArgs e)
        {
            string folder = (tb_FolderName.Text).Trim();
            if (folder != "")
            {
                CollectionFolder_Table c = new CollectionFolder_Table
                {
                    CollectionFolder = folder,
                    MemberID = memberData.MemberID,
                };
                dbcontext.CollectionFolder_Table.Add(c);
                try
                {
                    dbcontext.SaveChanges();
                    MessageBox.Show("新增成功");
                    tb_FolderName.Text = "";
                }
                catch
                {
                    MessageBox.Show("新增失敗");
                }
                finally
                {
                    LoadFolder();
                    LoadRecipe();
                }
            }
            else
            {
                MessageBox.Show("收藏夾名稱不可為空白");
            }    
        }
        private void lbox_Folder_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbox_FolderID.SelectedIndex = lbox_Folder.SelectedIndex;
            LoadRecipe();
        }

        private void 儲存至其他收藏夾ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem clickedItem = sender as ToolStripItem;
            ContextMenuStrip owner = clickedItem.Owner as ContextMenuStrip;
            RecipeControl p = owner.SourceControl as RecipeControl;

            Recipeid = Convert.ToInt32(p.Name);

            Form AddForm = new Form();
            var q = dbcontext.CollectionFolder_Table.Where(f => f.MemberID == memberData.MemberID).Select(f2 => f2.CollectionFolder).ToList();

            var q2 = dbcontext.Collection_Table.Where(f => f.CollectionFolder_Table.MemberID == memberData.MemberID && f.ReicipeID == Recipeid).Select(f2 => f2.CollectionFolder_Table.CollectionFolder).ToList();

            int x = 10;
            int y = 10;
            foreach (var item in q)
            {
                CheckBox cb = new CheckBox();
                cb.Location = new Point(x, y);
                y += 30;
                if (q2.Contains(item))
                {
                    cb.Checked = true;
                }
                cb.CheckedChanged += Cb_FolderCurrentChanged;
                cb.Name = item;
                AddForm.Controls.Add(cb);
            }

            x = 110;
            y = 10;
            foreach (var item in q)
            {
                Label lb = new Label();
                lb.Text = item;
                lb.ForeColor = Color.Black;
                lb.Location = new Point(x, y);
                y += 30;
                AddForm.Controls.Add(lb);
            }
            AddForm.Text = dbcontext.Recipe_Table.Where(r => r.RecipeID == Recipeid).Select(r2 => r2.RecipeName).FirstOrDefault();
            AddForm.Show();
        }
        private void btn_deleteFolder_Click(object sender, EventArgs e)
        {
            if (lbox_Folder.Text != "我的最愛")
            {
                int folderID = Convert.ToInt32(lbox_FolderID.Text);
                try
                {
                    dbcontext.Collection_Table.RemoveRange(dbcontext.Collection_Table.Where(c => c.CollectionFolderID == folderID));
                    dbcontext.CollectionFolder_Table.Remove(dbcontext.CollectionFolder_Table.Where(c => c.CollectionFolderID == folderID && c.MemberID == memberData.MemberID).FirstOrDefault());
                    dbcontext.SaveChanges();
                    MessageBox.Show("刪除此收藏夾成功");
                    lbox_Folder.SelectedIndex = 0;
                }
                catch (Exception)
                {
                    MessageBox.Show("刪除失敗,請聯絡管理員");
                }
                finally
                {
                    LoadFolder();
                    LoadRecipe();
                }
            }
            else
            {
                MessageBox.Show("不可刪除此收藏夾");
            }
        }
        private void Cb_FolderCurrentChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (!cb.Checked)
            {
                //刪除
                Collection_Table table = dbcontext.Collection_Table.AsEnumerable().First(c => c.ReicipeID == Recipeid && c.CollectionFolder_Table.CollectionFolder == cb.Name&&c.CollectionFolder_Table.MemberID==memberData.MemberID);
                dbcontext.Collection_Table.Remove(table);
                try
                {
                    dbcontext.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("發生錯誤");
                }
            }
            else
            {
                //新增
                var table = new Collection_Table()
                {
                    CollectionFolderID = dbcontext.CollectionFolder_Table.FirstOrDefault(c=>c.CollectionFolder == cb.Name&&c.MemberID==memberData.MemberID).CollectionFolderID,
                    ReicipeID = Recipeid,
                    Datetime = DateTime.Now
                };
                dbcontext.Collection_Table.Add(table);
                try
                {
                    dbcontext.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("修改失敗");
                }
            }
            LoadRecipe();
        }

        private void dgv_myRecipe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView ID = sender as DataGridView;
            RecipePage recipePage = new RecipePage((int)ID.CurrentRow.Cells["ID"].Value);
            recipePage.Show();
        }

        private void btn_lksearch_Click(object sender, EventArgs e)
        {
            if (this.cb_lksearch.Text == "全部")
            {
                dgv_likeload();
            }
            else
            {
                var q = this.dbcontext.LikeRecipe_Table.Where(m => m.MemberID == memberData.MemberID && m.Recipe_Table.RecipeCategory_Table.RecipeCategory == this.cb_lksearch.Text).Select(m => new
                {
                    食譜類別 = m.Recipe_Table.RecipeCategory_Table.RecipeCategory,
                    食譜名稱 = m.Recipe_Table.RecipeName,
                    食譜簡述 = m.Recipe_Table.RecipeDescription,
                    份數 = m.Recipe_Table.ForHowMany,
                    製作時間 = m.Recipe_Table.TimeNeed,
                    食譜編號 = m.RecipeID
                }).Distinct();

                this.dgv_like.DataSource = q.ToList();
                this.dgv_like.Columns["食譜編號"].Visible = false;

                if (this.dgv_like.CurrentRow != null)
                {
                    RecipeID = (int)this.dgv_like.CurrentRow.Cells["食譜編號"].Value;
                }
            }
        }

        private void dgv_like_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgv_like.CurrentRow != null)
            {
                RecipeID = (int)this.dgv_like.CurrentRow.Cells["食譜編號"].Value;
            }
            var countsame = this.dbcontext.Collection_Table.Where(m => m.CollectionFolder_Table.MemberID == memberData.MemberID && m.ReicipeID == RecipeID).Select(m => m.ReicipeID).Count();
            if (countsame > 0)
            {
                btn_lkaddtocoln.Enabled = false;
            }
            else
            {
                btn_lkaddtocoln.Enabled = true;
            }
        }

        private void dgv_like_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView ID = sender as DataGridView;
            RecipePage recipePage = new RecipePage(RecipeID);
            recipePage.Show();
        }

        private void btn_lkdelike_Click(object sender, EventArgs e)
        {
            if (this.dgv_like.CurrentRow != null)
            {
                RecipeID = (int)this.dgv_like.CurrentRow.Cells["食譜編號"].Value;
                var q = (this.dbcontext.LikeRecipe_Table.Where(n => n.MemberID == memberData.MemberID && n.RecipeID == RecipeID).Select(n => n)).FirstOrDefault();

                if (q == null) return;
                this.dbcontext.LikeRecipe_Table.Remove(q);
                this.dbcontext.SaveChanges();

                MessageBox.Show("刪除成功");
                this.dgv_like.DataSource = null;
                dgv_likeload();
            }
            else
            {
                return;
            }
        }

        private void btn_lkaddtocoln_Click(object sender, EventArgs e)
        {
            if (this.dgv_like.CurrentRow != null)
            {
                try
                {
                    RecipeID = (int)this.dgv_like.CurrentRow.Cells["食譜編號"].Value;
                    Collection_Table table = new Collection_Table()
                    {
                        CollectionFolderID = dbcontext.CollectionFolder_Table.Where(c => c.CollectionFolder == "我的最愛" && c.MemberID == memberData.MemberID).Select(s => s.CollectionFolderID).ToList()[0],
                        ReicipeID = RecipeID,
                        Datetime = DateTime.Now
                    };
                    dbcontext.Collection_Table.Add(table);
                    dbcontext.SaveChanges();
                    MessageBox.Show("收藏成功");
                    btn_lkaddtocoln.Enabled = false;
                    LoadRecipe();
                }
                catch (Exception)
                {
                    MessageBox.Show("收藏失敗");
                }
            }
            else
            {
                return;
            }
        }
    }
}
