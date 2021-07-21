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
using project.Form_Kuan;
using System.IO;
using project.Form_育政;
using System.Runtime.Serialization.Formatters.Binary;

namespace Delicious_Kashir
{
    public partial class RecipePage : Form
    {
        DeliciousEntities Delicious = new DeliciousEntities();
        public CMember memberData { get; set; }
        int rpid = 0;//全域變數recipeID 供喜歡&收藏用
        int cmid = 0;//全域變數CommentID 供檢舉&編輯&刪除用
        int floor = 0; //全域變數供判斷評論樓層用
        bool likeOrNot;
        public RecipePage(int recipeID)
        {
            InitializeComponent();
            LoadRecipe(recipeID);
            rpid = recipeID;//全域變數recipeID 供喜歡&收藏用
            this.memberData = Viewbag.member;
            var q = Delicious.Recipe_Table.Where(r => r.MemberID == memberData.MemberID && r.RecipeID == recipeID).Count();
            if (q > 0)
            {
                btn_deleterecipe.Visible = true;
                btn_update.Visible = true;
            }
            LoadComment();
        }

        private void RecipePage_Load(object sender, EventArgs e)
        {
            CommentShade();
        }

        private void LoadComment()
        {
            var q = Delicious.CommentSection_Table.Where(c => c.RecipeID == rpid && c.DisVisible == false).Select(c => new
            {
                樓層 = c.CommentFloor,
                圖片 = c.Picture,
                暱稱 = c.Member_Table.MemberName,
                留言 = c.Comment,
                影片 = c.Video,
                喜歡數 = c.LikeComment_Table.Where(c2 => c2.CommentID == c.CommentID).Count(),
                留言時間 = c.PostTime,
                ID = c.MemberID,
                CMID = c.CommentID,
                刪除 = c.DeleteOrNot,
                檢舉 = c.DisVisible
            }).OrderBy(o => o.樓層).ToList();
            floor = q.Count();
            dgv_comment.DataSource = q;

            dgv_comment.Columns["ID"].Visible = false;
            dgv_comment.Columns["CMID"].Visible = false;
            dgv_comment.Columns["刪除"].Visible = false;
            dgv_comment.Columns["檢舉"].Visible = false;
            CommentShade();
        }

        private void LoadRecipe(int SelectrecipeID)
        {
            var s = Delicious.Recipe_Table.Where(A => A.RecipeID == SelectrecipeID).Select(A => new
            {
                MemberName = Delicious.Member_Table.Where(B => B.MemberID == A.MemberID).Select(C => C.MemberName).FirstOrDefault(),
                A.PostTime,
                A.RecipeName,
                A.Picture,
                A.ForHowMany,
                A.TimeNeed,
                A.RecipeDescription,
                A.Views,
                Ingredients = Delicious.Ingredient_Record_Table.Where(E => E.RecipeID == SelectrecipeID).Select(D => new
                {
                    IngredientsName = Delicious.Ingredient_Table.Where(G => G.IngredientID == D.IngredientID).Select(H => H.Ingredient).FirstOrDefault(),
                    ForUse = Delicious.Ingredient_Record_Table.Select(I => I.IngredientAmountForUse).FirstOrDefault(),
                    Unt = Delicious.Ingredient_Record_Table.Select(J => J.Unt).FirstOrDefault()
                }),
                Steps = Delicious.Steps_Table.Where(K => K.RecipeID == SelectrecipeID).Select(L => new
                {
                    StepNumber = L.StepsNumber,
                    Step = L.Steps
                })

            }).FirstOrDefault();
            if (s.Picture != null)
            {
                MemoryStream memory = new MemoryStream(s.Picture);
                pb_RecipeIMG.Image = Image.FromStream(memory);
            }
            lb_Recipename.Text = s.RecipeName;
            lb_member.Text = s.MemberName;
            lb_Posttime.Text = $"{s.PostTime}";
            lb_Howmany.Text = $"{s.ForHowMany}";
            lb_Time.Text = $"{(s.TimeNeed / 60)}分";
            tb_RecipeDescription.Text = $"{s.RecipeDescription}";
            tb_Ingredients.Text = "";
            foreach (var item in s.Ingredients)
            {
                tb_Ingredients.Text += $"{item.IngredientsName}{item.ForUse}{item.Unt} ";
            }
            dgv_Step.DataSource = s.Steps.ToList();
            Delicious.Recipe_Table.Single(r => r.RecipeID == SelectrecipeID).Views++;
            Delicious.SaveChanges();
            lb_View.Text = $"👁{s.Views}";

            CCustomerMsg Img = new CCustomerMsg(); //給予Picturebox拖拉
            Img.setPicturebox(pb_UploadIMG);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確定刪除?", "系統提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Recipe_Table table = Delicious.Recipe_Table.First(r => r.MemberID == memberData.MemberID);
                    table.DeleteOrNot = false;
                    Delicious.SaveChanges();
                    MessageBox.Show("刪除成功");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("刪除失敗,請聯絡管理員");
                }
            }
        }

        //按下喜歡的按鈕後將選定的食譜加入喜歡
        private void btn_Like_Click(object sender, EventArgs e)
        {
            Addintolike(rpid);
        }
        //(方法)將此頁的食譜加入喜歡
        private void Addintolike(int rpid)
        {//確認使用者是否已加入喜歡過
            var countsame = this.Delicious.LikeRecipe_Table.Where(m => m.MemberID == memberData.MemberID && m.RecipeID == rpid).Count();
            if (countsame > 0)
            {
                MessageBox.Show("已加入喜歡過");
                btn_Like.Enabled = false;
            }
            else
            {
                var q = this.Delicious.Recipe_Table.Where(m => m.MemberID == memberData.MemberID && m.RecipeID == rpid);
                LikeRecipe_Table likeRp_Table = new LikeRecipe_Table()
                {
                    RecipeID = rpid,
                    MemberID = memberData.MemberID
                };
                Delicious.LikeRecipe_Table.Add(likeRp_Table);
                Delicious.SaveChanges();
                MessageBox.Show("成功加入我的喜歡");
            }
            btn_Like.ForeColor = Color.Red;
        }

        //按下喜歡的按鈕後將選定的食譜加入收藏
        private void btn_Favorites_Click(object sender, EventArgs e)
        {
            Addintocoln(rpid);
        }

        //(方法)將此頁的食譜加入收藏
        private void Addintocoln(int rpid)
        {
            var countsame = this.Delicious.Collection_Table.Where(m => m.CollectionFolder_Table.MemberID == memberData.MemberID && m.ReicipeID == rpid).Count();
            if (countsame > 0)
            {
                MessageBox.Show("已加入收藏過");
                btn_Favorites.Enabled = false;
            }
            else
            {
                var q = this.Delicious.CollectionFolder_Table.Where(m => m.MemberID == memberData.MemberID && m.CollectionFolder == "我的最愛").Select(m => m.CollectionFolderID).FirstOrDefault();
                Collection_Table coln_table = new Collection_Table()
                {
                    CollectionFolderID = q,
                    ReicipeID = rpid,
                    Datetime = DateTime.Now
                };
                this.Delicious.Collection_Table.Add(coln_table);
                this.Delicious.SaveChanges();
                MessageBox.Show("成功加入我的收藏");
            }
            btn_Favorites.ForeColor = Color.Yellow;
        }

        private void btn_deleterecipe_Click(object sender, EventArgs e) //僅供發表者刪除食譜
        {
            DialogResult result = MessageBox.Show("確定是否刪除?", "通知", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var S = Delicious.Recipe_Table.Single(A => A.RecipeID == rpid).DeleteOrNot = true;
                Delicious.SaveChanges();
                this.Close();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否進入編輯食譜頁面", "通知", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                UpdataRecipePage r = new UpdataRecipePage(rpid);
                r.Show();
                this.Close();
            }
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            FSelectAccuseID Report = new FSelectAccuseID("0", rpid);
            Report.Show();
        }

        //評論區
        private void btn_SendComment_Click(object sender, EventArgs e)
        {
            string comment = tb_Comment.Text.Trim();
            string URL = tb_CommentVideo.Text;
            byte[] bytes;
            MemoryStream ms = new MemoryStream();//建立一個資料流物件
            if (pb_UploadIMG.Image != null)
            {
                pb_UploadIMG.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);//儲存成jpeg格式到ms
                bytes = ms.GetBuffer();//將資料流轉換成byte[]陣列
            }
            else
            {
                bytes = null;
            }

            if (comment == "")
            {
                MessageBox.Show("評論不可為空白");
            }
            else if (URL != "" && (!URL.Contains("youtu.be") && !URL.Contains("youtube")))
            {
                MessageBox.Show("非YouTube網址");
            }
            else
            {
                try
                {
                    CommentSection_Table table = new CommentSection_Table()
                    {
                        RecipeID = rpid,
                        CommentFloor = floor + 1,
                        MemberID = memberData.MemberID,
                        Comment = comment,
                        Picture = bytes,
                        Video = URL,
                        PostTime = DateTime.Now,
                        DisVisible = false,
                        DeleteOrNot = false
                    };
                    Delicious.CommentSection_Table.Add(table);
                    Delicious.SaveChanges();
                    MessageBox.Show("新增評論成功");
                    LoadComment();
                    CommentShade();
                    tb_Comment.Text = "";
                    tb_CommentVideo.Text = "";
                    pb_UploadIMG.Image = null;
                }
                catch (Exception)
                {
                    MessageBox.Show("新增評論失敗,請聯絡管理員");
                }
            }
        }

        private void btn_EditComment_Click(object sender, EventArgs e)
        {
            cmid = (int)dgv_comment.CurrentRow.Cells["CMID"].Value;
            btn_EditComment.Click -= btn_EditComment_Click;
            btn_EditComment.Click += btn_CancelEditComment_Click;
            btn_SendComment.Click -= btn_SendComment_Click;
            btn_SendComment.Click += btn_UpdateComment_Click;
            btn_deComment.Enabled = false;
            btn_EditComment.Text = "取消編輯";
            btn_SendComment.Text = "完成編輯";

            if (dgv_comment.CurrentRow.Cells["圖片"].Value != null)
            {
                MemoryStream ms = new MemoryStream((byte[])dgv_comment.CurrentRow.Cells["圖片"].Value);
                pb_UploadIMG.Image = Image.FromStream(ms);
            }

            if (dgv_comment.CurrentRow.Cells["留言"].Value != null)
            {
                tb_Comment.Text = dgv_comment.CurrentRow.Cells["留言"].Value.ToString();
            }
            else
            {
                tb_Comment.Text = "";
            }

            if (dgv_comment.CurrentRow.Cells["影片"].Value != null)
            {
                tb_CommentVideo.Text = dgv_comment.CurrentRow.Cells["影片"].Value.ToString();
            }
            else
            {
                tb_CommentVideo.Text = "";
            }
        }

        private void btn_CancelEditComment_Click(object sender, EventArgs e)
        {
            btn_SendComment.Click -= btn_UpdateComment_Click;
            btn_SendComment.Click += btn_SendComment_Click;
            btn_EditComment.Click -= btn_CancelEditComment_Click;
            btn_EditComment.Click += btn_EditComment_Click;
            btn_deComment.Enabled = true;
            pb_UploadIMG.Image = null;
            btn_EditComment.Text = "編輯";
            btn_SendComment.Text = "發表評論";
            tb_Comment.Text = "";
            tb_CommentVideo.Text = "";
        }

        private void btn_UpdateComment_Click(object sender, EventArgs e)
        {
            string comment = tb_Comment.Text.Trim();
            string URL = tb_CommentVideo.Text;
            byte[] bytes;
            try
            {
                MemoryStream ms = new MemoryStream();
                CommentSection_Table commentTB = Delicious.CommentSection_Table.Where(c => c.CommentID == cmid).FirstOrDefault();
                if (pb_UploadIMG.Image != null)
                {
                    pb_UploadIMG.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);//儲存成jpeg格式到ms
                    bytes = ms.GetBuffer();//將資料流轉換成byte[]陣列
                }
                else
                {
                    bytes = null;
                }

                if (comment == "")
                {
                    MessageBox.Show("評論不可為空白");
                }
                else if (URL != "" && (!URL.Contains("youtu.be") && !URL.Contains("youtube")))
                {
                    MessageBox.Show("非YouTube網址");
                }
                else
                {
                    commentTB.Comment = comment;
                    commentTB.Picture = bytes;
                    commentTB.Video = URL;
                    Delicious.SaveChanges();
                    MessageBox.Show("評論更新成功");
                    LoadComment();
                    CommentShade();
                    btn_SendComment.Click -= btn_UpdateComment_Click;
                    btn_SendComment.Click += btn_SendComment_Click;
                    btn_EditComment.Click -= btn_CancelEditComment_Click;
                    btn_EditComment.Click += btn_EditComment_Click;
                    btn_deComment.Enabled = true;
                    btn_EditComment.Text = "編輯";
                    btn_SendComment.Text = "發表評論";
                    pb_UploadIMG.Image = null;
                    tb_Comment.Text = "";
                    tb_CommentVideo.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("更新失敗");
            }
        }

        private void btn_deComment_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確定刪除?", "系統提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    CommentSection_Table table = Delicious.CommentSection_Table.Where(c => c.CommentID == cmid).FirstOrDefault();
                    table.DeleteOrNot = true;
                    Delicious.SaveChanges();
                    MessageBox.Show("刪除留言成功");

                }
                catch (Exception)
                {
                    MessageBox.Show("刪除失敗");
                }
            }
            LoadComment();
            CommentShade();
        }

        private void btn_ReportComment_Click(object sender, EventArgs e)
        {
            FSelectAccuseID Report = new FSelectAccuseID("1", cmid);
            Report.Show();
        }

        private void dgv_comment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_comment.CurrentRow.Cells["ID"].Value != null && dgv_comment.CurrentRow.Cells["CMID"].Value != null)
            {
                btn_LikeComment.Enabled = true;
                cmid = (int)dgv_comment.CurrentRow.Cells["CMID"].Value;
                if ((int)dgv_comment.CurrentRow.Cells["ID"].Value == memberData.MemberID)
                {
                    btn_EditComment.Enabled = true;
                    btn_deComment.Enabled = true;
                    btn_Report.Enabled = false;
                }
                else
                {
                    btn_EditComment.Enabled = false;
                    btn_deComment.Enabled = false;
                    btn_ReportComment.Enabled = true;
                }
                var q = Delicious.LikeComment_Table.Where(l => l.CommentID == cmid && l.MemberID == memberData.MemberID).ToList();
                if (q.Count != 0)
                {
                    btn_LikeComment.Text = "♥";
                    likeOrNot = true;
                }
                else
                {
                    btn_LikeComment.Text = "♡";
                    likeOrNot = false;
                }
            }
            else
            {
                btn_EditComment.Enabled = false;
                btn_deComment.Enabled = false;
                btn_ReportComment.Enabled = false;
            }
        }

        private void 移除圖片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pb_UploadIMG.Image = null;
        }

        private void CommentShade()
        {
            for (int i = 0; i < dgv_comment.RowCount; i++)
            {
                if ((bool)dgv_comment.Rows[i].Cells["刪除"].Value == true)
                {
                    dgv_comment.Rows[i].DefaultCellStyle.BackColor = Color.Black;
                    dgv_comment.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
                if ((bool)dgv_comment.Rows[i].Cells["檢舉"].Value == true)
                {
                    dgv_comment.Rows[i].DefaultCellStyle.BackColor = Color.Black;
                    dgv_comment.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void btn_LikeComment_Click(object sender, EventArgs e)
        {
            if (likeOrNot)
            {
                try
                {
                    Delicious.LikeComment_Table.Remove(Delicious.LikeComment_Table.Where(l => l.CommentID == cmid && l.MemberID == memberData.MemberID).FirstOrDefault());
                    Delicious.SaveChanges();
                    btn_LikeComment.Text = "♡";
                    likeOrNot = false;
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("發生問題");
                }
            }
            else
            {
                try
                {
                    Delicious.LikeComment_Table.Add(new LikeComment_Table() { CommentID=cmid,MemberID=memberData.MemberID});
                    Delicious.SaveChanges();
                    btn_LikeComment.Text = "♥";
                    likeOrNot = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("發生問題"+ex.Message);
                }
            }
            LoadComment();
        }
    }
}
