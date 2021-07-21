using project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class EmailConfirm : Form
    {
        private CMember memberData { get; set; }
        public EmailConfirm()
        {
            InitializeComponent();
            this.memberData = Viewbag.member;
        }

        DeliciousEntities dbcontext = new DeliciousEntities();
        private void btn_SendEmail_Click(object sender, EventArgs e)
        {
            tb_EmailConfirm.Enabled = true;
            var q = (from m in dbcontext.Member_Table
                     where m.AccountName == memberData.AccountName
                     select m).ToList()[0];
            
            SendEmail sendEmail = new SendEmail();
            sendEmail.email = q.Email;
            sendEmail.conform = q.EmailConfirm.ToString();
            sendEmail.Subject = "瘋廚網電子郵件認證信";
            sendEmail.Body = "電子郵件認證碼:";
            sendEmail.Result = "已送出";

            string result = sendEmail.send();
            if (result == "已送出")
            {
                btn_SendEmail.Enabled = false;
                lb_Sended.Visible = true;
            }
            else
            {
                MessageBox.Show("錯誤:"+result+"請聯絡管理員");
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            var q = (from m in dbcontext.Member_Table
                     where m.AccountName == memberData.AccountName
                     select m).ToList()[0];
            if (q.EmailConfirm.ToString() == tb_EmailConfirm.Text)
            {
                Member_Table member = dbcontext.Member_Table.First(m => m.AccountName == memberData.AccountName);
                member.ConfirmedOrNot_email = true;
                member.AuthorityID = 2;
                try
                {
                    dbcontext.SaveChanges();
                    lb_email.Visible = false;
                    lb_Sended.Visible = false;
                    MessageBox.Show("認證成功,為您跳轉畫面");
                    PersonalPage f = new PersonalPage(memberData.MemberID);
                    f.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("錯誤:" + ex);
                }
            }
            else
            {
                lb_email.Visible = true;
                lb_email.Text = "認證碼輸入錯誤";
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
