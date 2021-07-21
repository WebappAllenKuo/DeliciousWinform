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
    public partial class AddColnfolderForm : Form
    {
        int mid;
        int recipeid;

        CMember memdata = new CMember();        

        public AddColnfolderForm(int MID,int RecipeID)
        {
            InitializeComponent();
            //Todo
            //顯示目前使用者暱稱
            //lb_lkname.Text = memdata.Nickname+ "您好";
            //Todo
            //顯示目前使用者等級名稱
            //var q = this.dbcontext.Member_Table.Where(m => m.MemberID == mid).Select(m => m.Member_Rank_Table.RankName).ToList();
            //lb_lkuser_rank.Text = "目前等級:" + q[0];

            this.mid = MID;
            this.recipeid = RecipeID;

            //(方法)把user收藏的資料夾+cb_colnsrhfolder
            cb_colnfolder();
        }        

        DeliciousEntities dbcontext = new DeliciousEntities();               

        //新增收藏夾
        private void btn_addcolnfolder_Click(object sender, EventArgs e)
        {
            Caddcolnfolder caddcolnfolder = new Caddcolnfolder();//Class

            //新增的收藏夾名稱未重複執行以下
            if (caddcolnfolder.addCaddcolnfolder(tb_addcolnfolder.Text, mid) ==true)
            {
                MessageBox.Show("新增收藏夾成功");
                tb_addcolnfolder.Text = "";
                cb_colnfolder();                
            }
            else
            {//新增的收藏夾名稱重複執行以下
                MessageBox.Show("請重新命名收藏夾名稱");
                btn_yes.Enabled = false;
            }
        }

        //(方法)把user收藏的資料夾+cb_colnsrhfolder
        private void cb_colnfolder()
        {
            cb_colnsrhfolder.Items.Clear();
            var q = this.dbcontext.CollectionFolder_Table.Where(m => m.MemberID == mid).Select(m => m.CollectionFolder);

            foreach(var item in q)
            {
                this.cb_colnsrhfolder.Items.Add(item);
            }
            this.cb_colnsrhfolder.SelectedIndex = 0;
        }

        //如果第一次使用者輸入重複收藏夾名稱後確認鍵會不可按，當重新輸入收藏夾名稱，確認鍵回復成可以按
        private void tb_addcolnfolder_TextChanged(object sender, EventArgs e)
        {
            btn_yes.Enabled = true;
        }

        //確認鍵
        private void btn_yes_Click(object sender, EventArgs e)
        {
            likeintoColn(recipeid, cb_colnsrhfolder.Text, mid);
        }

        //(方法)將喜歡的食譜+進收藏夾
        private void likeintoColn(int RecipeID,string FolderName,int Mid)
        {
            var q = (this.dbcontext.CollectionFolder_Table.Where(m => m.MemberID == Mid && m.CollectionFolder == FolderName).Select(m => m.CollectionFolderID)).FirstOrDefault();
            int id = Convert.ToInt32(q);
            Collection_Table _collection = new Collection_Table()
            {
                CollectionFolderID = id,
                ReicipeID = RecipeID,
                Datetime = DateTime.Now
            };
            dbcontext.Collection_Table.Add(_collection);
            dbcontext.SaveChanges();
            MessageBox.Show("成功加入收藏夾");
            Close();
        }

        //取消鍵
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            cb_colnsrhfolder.Text = null;
            tb_addcolnfolder.Clear();           
        }
    }
}
