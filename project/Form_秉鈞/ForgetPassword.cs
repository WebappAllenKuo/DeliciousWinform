using project.Model;
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
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }
        DeliciousEntities dbcontext = new DeliciousEntities();
        Random r = new Random();
        private void btn_SendPassword_Click(object sender, EventArgs e)
        {
            var q = (from m in dbcontext.Member_Table
                     where m.Email == tb_email.Text
                     select m).ToList();

            string RandomChar = "abcdefghijklmnopqrstuvwxyz";
            string RandomResult = "";
            for (int i = 0; i < 10; i++)
            {
                if (i <= 3)
                {
                    RandomResult += RandomChar[r.Next(0, 25)];
                }
                else
                {
                    RandomResult += r.Next(0, 9).ToString();
                }
            }

            Member_Table member = dbcontext.Member_Table.First(m => m.Email == tb_email.Text);
            member.Password = RandomResult;
            for (int i = 0; i < 100; i++)
            {
                member.Password = FormsAuthentication.HashPasswordForStoringInConfigFile(member.Password, "SHA256");
            }
            try
            {
                dbcontext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("錯誤:"+ex);
            }

            if (q.Count == 0)
            {
                lb_password.Enabled = true;
                lb_password.Text = "請輸入正確信箱";
            }
            else
            {
                SendEmail sendEmail = new SendEmail();
                sendEmail.email = tb_email.Text;
                sendEmail.conform = RandomResult;
                sendEmail.Subject = "瘋廚網臨時密碼信";
                sendEmail.Body = "您的新密碼為 : ";
                sendEmail.Result = "認證碼已發送\r為您跳轉登入畫面";
                MessageBox.Show(sendEmail.send());
                btn_SendPassword.Enabled = false;

                login f = new login();
                f.Show();
                //this.Close();
                }
            }
        }
    }
