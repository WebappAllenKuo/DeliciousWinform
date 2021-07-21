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

namespace project
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
            DateTime dt = DateTime.Now;
            birthdayPicker.MaxDate = dt;
            cb_gender.SelectedIndex = 0;
        }
        Random r = new Random();
        DeliciousEntities dbcontext = new DeliciousEntities();
        private void btn_Registered_Click(object sender, EventArgs e)
        {
            Judgment jdg = new Judgment(); //建立判斷物件
            RMember m = new RMember();
            m.MemberName = tb_MemberName.Text;
            m.AccountName = tb_account.Text;
            m.Password1 = tb_password1.Text;
            m.Password2 = tb_password2.Text;
            m.Birthday = birthdayPicker.Value;
            m.Gender = cb_gender.Text;
            m.Email = tb_email.Text;
            m.CellNumber = tb_phone.Text;

            if (checkBox1.Checked == true)  //會員權益說明
            {
                if (!jdg.AllJdg(m,out string MemberNameMessage, out string AccountMessage, out string PasswordMessage, out string EmailMessage, out string CellNumberMessage))
                //使用者資訊丟進jdg判斷,無錯誤回傳true,有錯則回傳false,並傳回錯誤訊息
                {
                    lb_ErrorMemberName.Visible = true;
                    lb_account.Visible = true;
                    lb_password.Visible = true;
                    lb_email.Visible = true;
                    lb_phone.Visible = true;
                    lb_ErrorMemberName.Text = MemberNameMessage;
                    lb_account.Text = AccountMessage;
                    lb_password.Text = PasswordMessage;
                    lb_email.Text = EmailMessage;
                    lb_phone.Text = CellNumberMessage;
                    //打開錯誤訊息,顯示錯誤資訊
                }
                else
                {
                    if (AddUserData(m))//如果正確就丟進AddUserData方法裡加進資料庫
                    {
                        MessageBox.Show("註冊成功!為您跳轉登入頁面!");
                        //login f = new login();
                        //f.Show();
                        this.Close(); //跳轉頁面
                    }
                    else
                    {
                        MessageBox.Show("註冊失敗...");//其他狀況就顯示註冊失敗
                    }
                }
            }
            else
            {
                MessageBox.Show("請確認會員權益及說明");
            }
        }
        private bool AddUserData(RMember m)
        {
            string password = m.Password1;
            //跑100次雜湊
            for (int i = 0; i < 100; i++)
            {
                password = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "SHA256");
            }
            //產生手機驗證碼
            string CellConfirm = "";
            for (int i = 0; i < 6; i++)
            {
                CellConfirm += r.Next(0, 9).ToString();
            }
            //insert into資料庫
            try
            {
                var NewMember = new Member_Table
                {
                    AccountName = m.AccountName,
                    Nickname = m.AccountName,
                    MemberName = m.MemberName,
                    CellNumber = m.CellNumber,
                    CellConfirm = CellConfirm,
                    Email = m.Email,
                    EmailConfirm = Guid.NewGuid(),
                    Birthday = m.Birthday,
                    Gender = cb_gender.Text,
                    Info = "",
                    ConfirmedOrNot_email = false,
                    ConfirmedOrNot_phone = false,
                    Password = password,
                    RegisterTime = DateTime.Now,
                    PersonalRankScore = 0,
                    RankID = 1,
                    AuthorityID = 1,
                    Figure = ".\\..\\..\\Figure\\default.png"
                };
                dbcontext.Member_Table.Add(NewMember);
                dbcontext.SaveChanges();
                var NewCollectionFolder = new CollectionFolder_Table
                {
                    CollectionFolder = "我的最愛",
                    MemberID = (from member in dbcontext.Member_Table
                                where member.AccountName == m.AccountName
                                select member).ToList()[0].MemberID
                };
                dbcontext.CollectionFolder_Table.Add(NewCollectionFolder);
                dbcontext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void btn_BackLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
