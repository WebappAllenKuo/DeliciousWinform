using Delicious_Kashir;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.Form_明萱
{
    public partial class LikeCollectionForm : Form
    {                
        public LikeCollectionForm()
        {//LikeCollectionForm執行時
         
            InitializeComponent();

            //顯示目前使用者暱稱
            //lb_lkname.Text = Viewbag.member.Nickname + "您好";
            //lb_colname.Text = Viewbag.member.Nickname + "您好";

            //顯示目前使用者等級名稱
            var q = this.dbcontext.Member_Table.Where(m => m.MemberID == Mid).Select(m => m.Member_Rank_Table.RankName).ToList();
            lb_lkuser_rank.Text = "目前等級:" + q[0];
            lb_colmember_rank.Text = "目前等級:" + q[0];

            //(方法)把user喜歡的全部食譜show
            dgv_likeload();

            //(方法)把user喜歡的食譜類別+cb_lksearch
            cb_lksearchload();

            //(方法)把user收藏的全部食譜show
            dgv_colnload();

            //(方法)把user收藏的資料夾+cb_colnsrhfolder
            cb_colnfolder();

            //(方法)把user收藏的類別+cb_colncgy
            cb_colncgy();
           // dgv_like_CellClick(null,null);


        }      

        DeliciousEntities dbcontext = new DeliciousEntities();

        int Mid = 2;//todo

        //(方法)LikeCollectionForm執行時把user喜歡的食譜類別+cb_lksearch
        private void cb_lksearchload()
        {
            var q = this.dbcontext.LikeRecipe_Table.Where(m => m.MemberID == Mid).Select(m => m.Recipe_Table.RecipeCategory_Table.RecipeCategory).Distinct();

            this.cb_lksearch.Items.Add("全部");

            foreach (var item in q)
            {
                this.cb_lksearch.Items.Add(item);
            }

            this.cb_lksearch.SelectedIndex=0;            
        }

        int RecipeID = 0;

        //(方法)LikeCollectionForm執行時把user喜歡的全部食譜show在DataGridview dgv_like
        private void dgv_likeload()
        {          
                var q = this.dbcontext.LikeRecipe_Table.Where(m => m.MemberID == Mid).Select(m => new
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

        //(事件)btn_lksearch_Click執行時把user喜歡的食譜資料show
        private void btn_lksearch_Click(object sender, EventArgs e)
        {
            if(this.cb_lksearch.Text=="全部")
            {
                dgv_likeload();
            }
            else
            {
                var q = this.dbcontext.LikeRecipe_Table.Where(m => m.MemberID == Mid && m.Recipe_Table.RecipeCategory_Table.RecipeCategory == this.cb_lksearch.Text).Select(m => new
                {
                    食譜類別 = m.Recipe_Table.RecipeCategory_Table.RecipeCategory,
                    食譜名稱 = m.Recipe_Table.RecipeName,
                    食譜簡述 = m.Recipe_Table.RecipeDescription,
                    份數 = m.Recipe_Table.ForHowMany,
                    製作時間 = m.Recipe_Table.TimeNeed,
                    食譜編號=m.RecipeID
                }).Distinct();
                
                this.dgv_like.DataSource = q.ToList();
                this.dgv_like.Columns["食譜編號"].Visible = false;

                if (this.dgv_like.CurrentRow != null)
                {
                    RecipeID = (int)this.dgv_like.CurrentRow.Cells["食譜編號"].Value;
                }
            }            
        }
        //todo
        //喜歡的食譜頁面當DataGridView-dgv_like點擊後跳轉被點擊的食譜頁面 
        private void dgv_like_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           //RecipePage recipePage = new RecipePage(/*RecipeID*/);
            //recipePage.Show();
        }

        //判斷DataGridView上點選的喜歡食譜是否已重複收藏
        int repeat = 0;
        private void dgv_like_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgv_like.CurrentRow != null)
            {
                RecipeID = (int)this.dgv_like.CurrentRow.Cells["食譜編號"].Value;
            }
            var countsame = this.dbcontext.Collection_Table.Where(m => m.CollectionFolder_Table.MemberID == Mid && m.ReicipeID == RecipeID).Select(m => m.ReicipeID).Count();
            if (countsame > 0)
            {
                repeat = 1;//如果重複收藏 將repeat值改為1
                btn_lkaddtocoln.Enabled = false;
            }
            else
            {
                repeat = 0;
                btn_lkaddtocoln.Enabled = true;//未重複 repeat值為0
            }            
        }
        //Todo
        //將喜歡的食譜加入收藏
        private void btn_lkaddtocoln_Click(object sender, EventArgs e)
        {
            //if (this.dgv_like.CurrentRow != null)
            //{
            //    RecipeID = (int)this.dgv_like.CurrentRow.Cells["食譜編號"].Value;
            //}
            //var countsame = this.dbcontext.Collection_Table.Where(m => m.CollectionFolder_Table.MemberID == Mid && m.ReicipeID == RecipeID).Select(m => m.ReicipeID).Count();
            //if (countsame>0)
            //{
            //    MessageBox.Show("已經收藏過此食譜");
            //}
            //else
            //{
                AddColnfolderForm addColnfolder = new AddColnfolderForm(Mid, RecipeID);
                addColnfolder.Show();
            //}
        }

        //在收藏的食譜頁面新增收藏夾
        private void btn_addcolnfolder_Click(object sender, EventArgs e)
        {
            Caddcolnfolder caddcolnfolder = new Caddcolnfolder();//Class
            caddcolnfolder.addCaddcolnfolder(tb_addcolnfolder.Text, Mid);
            cb_colnfolder();
        }
      
        //刪除喜歡的食譜
        private void btn_lkdelike_Click(object sender, EventArgs e)
        {
            RecipeID = (int)this.dgv_like.CurrentRow.Cells["食譜編號"].Value;
            var q = (this.dbcontext.LikeRecipe_Table.Where(n => n.MemberID == Mid && n.RecipeID == RecipeID).Select(n => n)).FirstOrDefault();

            if (q == null) return;
            this.dbcontext.LikeRecipe_Table.Remove(q);
            this.dbcontext.SaveChanges();

            MessageBox.Show("刪除成功");
            this.Read_RefreshDataGridView();            
        }
        void Read_RefreshDataGridView()
        {
            this.dgv_like.DataSource = null;
            dgv_likeload();
        }

        //(方法)把user收藏的類別+cb_colnsrhfolder
        private void cb_colncgy()
        {
            var q = this.dbcontext.Collection_Table.Where(m => m.CollectionFolder_Table.MemberID == Mid).Select(m => m.Recipe_Table.RecipeCategory_Table.RecipeCategory).Distinct();

            this.cb_colnsrhcgy.Items.Add("全部");
            foreach (var item in q)
            {
                this.cb_colnsrhcgy.Items.Add(item);
            }
            this.cb_colnsrhcgy.SelectedIndex = 0;
        }

        //(方法)把user收藏的全部食譜show在DataGridview dgv_coln
        private void dgv_colnload()
        {
            
            var q = this.dbcontext.Collection_Table.Where(m => m.CollectionFolder_Table.MemberID == Mid).Select(m => new
            {
                收藏資料夾編號=m.CollectionFolderID,
                收藏資料夾名稱 = m.CollectionFolder_Table.CollectionFolder,
                食譜類別 = m.Recipe_Table.RecipeCategory_Table.RecipeCategory,
                食譜名稱 = m.Recipe_Table.RecipeName,
                食譜簡述 = m.Recipe_Table.RecipeDescription,
                份數 = m.Recipe_Table.ForHowMany,
                製作時間 = m.Recipe_Table.TimeNeed,
                食譜編號 = m.Recipe_Table.RecipeID
            }).Distinct();
            this.dgv_coln.DataSource = q.ToList();
            this.dgv_like.Columns["食譜編號"].Visible = false;

            if (this.dgv_coln.CurrentRow != null)
            {
                RecipeID = (int)this.dgv_coln.CurrentRow.Cells["食譜編號"].Value;
            }
        }

        //(方法)LikeCollectionForm執行時把user收藏的資料夾+cb_colnsrhfolder
        private void cb_colnfolder()
        {
            //var q = dbcontext.Collection_Table.Where(m => m.CollectionFolder_Table.MemberID == Mid).Select(m => m.CollectionFolder_Table.CollectionFolder);
            //var q = from p in dbcontext.Collection_Table
            //        where p.CollectionFolder_Table.MemberID==2
            //        select p.CollectionFolder_Table.CollectionFolder;
            //List<string> L1 = new List<string>();
            var q = this.dbcontext.CollectionFolder_Table.Where(n => n.MemberID == Mid).Select(m => m.CollectionFolder).Distinct();            
            foreach (var item in q)
            {
                this.cb_colnsrhfolder.Items.Add(item.ToString());
            }
        }

        //(事件)cb_colnsrhcgy_SelectedIndexChanged執行時把user收藏的的食譜類別show
        private void cb_colnsrhcgy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cb_colnsrhcgy.Text == "全部")
            {
                dgv_colnload();
            }
            else
            {
                var q = this.dbcontext.Collection_Table.Where(m => m.CollectionFolder_Table.MemberID == Mid && m.Recipe_Table.RecipeCategory_Table.RecipeCategory == this.cb_colnsrhcgy.Text).Select(m => new
                {
                    收藏資料夾編號 = m.CollectionFolderID,
                    收藏資料夾名稱 = m.CollectionFolder_Table.CollectionFolder,
                    食譜類別 = m.Recipe_Table.RecipeCategory_Table.RecipeCategory,
                    食譜名稱 = m.Recipe_Table.RecipeName,
                    食譜簡述 = m.Recipe_Table.RecipeDescription,
                    份數 = m.Recipe_Table.ForHowMany,
                    製作時間 = m.Recipe_Table.TimeNeed,
                    食譜編號 = m.Recipe_Table.RecipeID
                }).Distinct();

                this.dgv_coln.DataSource = q.ToList();
                this.dgv_like.Columns["食譜編號"].Visible = false;

                if (this.dgv_coln.CurrentRow != null)
                {
                    RecipeID = (int)this.dgv_coln.CurrentRow.Cells["食譜編號"].Value;
                }
            }
        }

        //(事件)cb_cb_colnsrhfolder_SelectedIndexChanged執行時把user收藏的的食譜資料夾show
        private void cb_colnsrhfolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            var q = this.dbcontext.Collection_Table.Where(m => m.CollectionFolder_Table.MemberID == Mid && m.CollectionFolder_Table.CollectionFolder == this.cb_colnsrhfolder.Text).Select(m => new
            {
                收藏資料夾編號 = m.CollectionFolderID,
                收藏資料夾名稱 = m.CollectionFolder_Table.CollectionFolder,
                食譜類別 = m.Recipe_Table.RecipeCategory_Table.RecipeCategory,
                食譜名稱 = m.Recipe_Table.RecipeName,
                食譜簡述 = m.Recipe_Table.RecipeDescription,
                份數 = m.Recipe_Table.ForHowMany,
                製作時間 = m.Recipe_Table.TimeNeed,
                食譜編號 = m.Recipe_Table.RecipeID
            }).Distinct();

            this.dgv_coln.DataSource = q.ToList();
            this.dgv_like.Columns["食譜編號"].Visible = false;

            if (this.dgv_coln.CurrentRow != null)
            {
                RecipeID = (int)this.dgv_coln.CurrentRow.Cells["食譜編號"].Value;
            }
        }

        //todo
        //收藏的食譜頁面 當DataGridView-dgv_coln點擊後跳轉被點擊的食譜頁面 
        private void dgv_coln_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //RecipePage recipePage = new RecipePage(/*RecipeID*/);
            //recipePage.Show();
        }        
    }
}
