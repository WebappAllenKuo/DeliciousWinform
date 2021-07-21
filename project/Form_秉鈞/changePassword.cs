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
    public partial class changePassword : Form
    {
        public CMember memberData { get; set; }
        public changePassword()
        {
            InitializeComponent();
            this.memberData = Viewbag.member;
        }
        DeliciousEntities dbcontext = new DeliciousEntities();
        Judgment j = new Judgment();
        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            string oldPassword = tb_oldPassword.Text;
            string Password1 = tb_newPassword1.Text;
            string Password2 = tb_newPassword2.Text;
            for (int i = 0; i < 100; i++)
            {
                oldPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(oldPassword, "SHA256");
            }
            var q = (from m in dbcontext.Member_Table
                     where m.AccountName == memberData.AccountName && m.Password == oldPassword
                     select m).ToList();
            if (q.Count == 0)
            {
                lb_passwordError.Visible = true;
                lb_passwordError.Text = "請輸入正確舊密碼";
            }
            else
            {
                if (j.PasswordJdg(Password1, Password2) != null)
                {
                    lb_passwordError.Visible = true;
                    lb_passwordError.Text = j.PasswordJdg(Password1, Password2);
                }
                else
                {
                    Member_Table member = dbcontext.Member_Table.First(m => m.AccountName == memberData.AccountName);
                    member.Password = Password1;
                    for (int i = 0; i < 100; i++)
                    {
                        member.Password = FormsAuthentication.HashPasswordForStoringInConfigFile(member.Password, "SHA256");
                    }
                    try
                    {
                        dbcontext.SaveChanges();
                        MessageBox.Show("密碼更改成功,正在為您跳轉頁面");
                        PersonalPage f = new PersonalPage(memberData.MemberID);
                        f.Show();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("錯誤:" + ex);
                    }
                }
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            PersonalPage f = new PersonalPage(memberData.MemberID);
            f.Show();
            this.Close();
        }
    }
}
