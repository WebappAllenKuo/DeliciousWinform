using project.Form_Chia;
using project.Model_秉鈞;
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

namespace project.Form_秉鈞
{
    public partial class adlogin : Form
    {
        public adlogin()
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
            var q = dbcontext.Admin_Table.Where(m => (m.AccountName == tb_account.Text && m.Password == password)).Select(m => m).ToList();
            if (q.Count() != 0)
            {
                var q2 = q[0];
                CAdmin admin = new CAdmin()
                {
                    AdminID = q2.AdminID,
                    AdminName = q2.AdminName,
                    AccountName = q2.AccountName,
                };

                Viewbag.Admin = admin;
                FrmManageHomePage f = new FrmManageHomePage();
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
            adregister f = new adregister();
            f.Show();
        }
    }
}
