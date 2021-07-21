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
    public partial class MemberRankForm : Form
    {
        
        public MemberRankForm()
        {//MemberRankForm表單一執行時

            InitializeComponent();

            //(方法)把食譜人氣榜Load進去
            hotMemberRankLoad();

            //(方法)把食譜累積榜Load進去
            recipecountLoad();
        }        

        DeliciousEntities dbcontext = new DeliciousEntities();

        //(方法)把食譜人氣榜Load進去
        private void hotMemberRankLoad()
        {
            var q = this.dbcontext.Member_Table.OrderByDescending(m => m.PersonalRankScore).Select(m => new
            {
                ID = m.MemberID,
                Figure = m.Figure,
                暱稱 = m.Nickname,
                等級積分 = m.PersonalRankScore
            }).Take(10);

            foreach (var item in q)
            {
                Label lb_hotrpname = new Label();
                PictureBox pb_hotrpic = new PictureBox();
                Panel p_hotmember = new Panel();

                p_hotmember.Name = item.ID.ToString();
                pb_hotrpic.Name = item.ID.ToString();
                lb_hotrpname.Name = item.ID.ToString();

                lb_hotrpname.Text = item.暱稱;
                pb_hotrpic.Image = Image.FromFile(item.Figure);
                pb_hotrpic.SizeMode = PictureBoxSizeMode.StretchImage;
                pb_hotrpic.Size = new Size(100, 100);
                p_hotmember.Controls.Add(lb_hotrpname);
                p_hotmember.Controls.Add(pb_hotrpic);
                p_hotmember.BorderStyle = BorderStyle.FixedSingle;

                this.flp_hotrecipe.Controls.Add(p_hotmember);
                p_hotmember.Margin = new Padding(110, 10, 0, 10);
                p_hotmember.Width = 120;
                p_hotmember.Click += P_hotmember_Click;
                lb_hotrpname.Click += P_hotmember_Click;
                pb_hotrpic.Click += P_hotmember_Click;

            }
        }        

        //(方法)把食譜累積榜Load進去
        private void recipecountLoad()
        {
            var q = dbcontext.Recipe_Table.GroupBy(r => r.MemberID).Select(g => new
            {
                ID = dbcontext.Member_Table.Where(m => m.MemberID == g.Key).Select(m => m.MemberID).FirstOrDefault(),
                Figure = dbcontext.Member_Table.Where(m => m.MemberID == g.Key).Select(m => m.Figure).FirstOrDefault(),
                暱稱 = dbcontext.Member_Table.Where(m => m.MemberID == g.Key).Select(m => m.Nickname).FirstOrDefault(),
                食譜發表總數 = g.Count()
            }).OrderByDescending(g => g.食譜發表總數).Take(10).ToList();

            foreach (var item in q)
            {
                Label lb_rpcount = new Label();
                PictureBox pb_rpcount = new PictureBox();
                Panel p_rpcount = new Panel();
                p_rpcount.Name = item.ID.ToString();
                pb_rpcount.Name = item.ID.ToString();
                lb_rpcount.Name = item.ID.ToString();

                lb_rpcount.Text = item.暱稱;
                pb_rpcount.Image = Image.FromFile(item.Figure);
                pb_rpcount.SizeMode = PictureBoxSizeMode.StretchImage;
                pb_rpcount.Size = new Size(100, 100);
                p_rpcount.Controls.Add(lb_rpcount);
                p_rpcount.Controls.Add(pb_rpcount);
                p_rpcount.BorderStyle = BorderStyle.FixedSingle;

                this.flp_recipecount.Controls.Add(p_rpcount);
                p_rpcount.Margin = new Padding(110, 10, 0, 10);
                p_rpcount.Width = 120;

                p_rpcount.Click += P_hotmember_Click;
                lb_rpcount.Click += P_hotmember_Click;
                pb_rpcount.Click += P_hotmember_Click;
            }
        }

        //(事件)點擊個人Panel後跳轉被點擊的個人簡介
        private void P_hotmember_Click(object sender, EventArgs e)
        {
            int id;
            PictureBox pb = (sender as PictureBox);
            Label lb = (sender as Label);
            Panel p = (sender as Panel);
            if (pb != null)
            {
                id = Convert.ToInt32(pb.Name);
                PersonalPage pg = new PersonalPage(id);
                pg.Show();
            }
            else if (lb != null)
            {
                id = Convert.ToInt32(lb.Name);
                PersonalPage pg = new PersonalPage(id);
                pg.Show();
            }
            else
            {
                id = Convert.ToInt32(p.Name);
                PersonalPage pg = new PersonalPage(id);
                pg.Show();
            }
        }
    }
}
