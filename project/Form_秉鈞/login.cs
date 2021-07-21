
using Delicious_Kashir;
using MarketPages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace project
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        DeliciousEntities dbcontext = new DeliciousEntities();
        private void btn_login_Click(object sender, EventArgs e)
        {
            string password = tb_password.Text;
            for (int i = 0; i < 100; i++)
            {
                password = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "SHA256");
            }
            var q = dbcontext.Member_Table.Where(m => (m.AccountName == tb_account.Text && m.Password == password)).FirstOrDefault();
            if (q != null)
            {
                CMember memberData = new CMember();
                memberData.getdata(q);
                //memberData.AccountName = q2.AccountName;
                //memberData.Nickname = q2.Nickname;
                //memberData.MemberName = q2.MemberName;
                //memberData.CellNumber = q2.CellNumber;
                //memberData.Email = q2.Email;
                //memberData.Birthday = q2.Birthday;
                //memberData.Gender = q2.Gender;
                //memberData.info = q2.Info;
                //memberData.ConfirmedOrNot_email = q2.ConfirmedOrNot_email;
                //memberData.ConfirmedOrNot_phone = q2.ConfirmedOrNot_phone;
                //memberData.RigisterTime = q2.RegisterTime;
                //memberData.PersonalRankScore = q2.PersonalRankScore;
                //memberData.RankID = q2.RankID;
                //memberData.AuthorityID = q2.AuthorityID;
                //memberData.Figure = q2.Figure;

                Viewbag.member = memberData;
                HomePage f = new HomePage();
                this.Visible = false;
                f.ShowDialog();
                this.Visible = true;
            }
            else 
            {
                //震動特效
                Random ran = new Random((int)DateTime.Now.Ticks);
                Point point = this.Location;
                for (int i = 0; i < 5; i++)
                {
                    this.Location = new Point(point.X + ran.Next(10) - 4, point.Y + ran.Next(10) - 4);
                    System.Threading.Thread.Sleep(5);
                    this.Location = point;
                    System.Threading.Thread.Sleep(5);
                }

                lb_AccountError.Visible = true;
                lb_AccountError.Text = "請輸入正確帳號密碼";
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            register r = new register();
            r.Show();
        }

        private void btn_forget_Click(object sender, EventArgs e)
        {
            ForgetPassword f = new ForgetPassword();
            f.Show();
            //this.Close();
        }
    }
}
