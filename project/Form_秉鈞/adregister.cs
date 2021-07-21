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
    public partial class adregister : Form
    {
        public adregister()
        {
            InitializeComponent();
        }
        DeliciousEntities dbcontext = new DeliciousEntities();
        private void btn_Registered_Click(object sender, EventArgs e)
        {
            Judgment jdg = new Judgment(); //建立判斷物件
            CAdmin c = new CAdmin();
            c.AdminName = tb_AdminName.Text;
            c.AccountName = tb_account.Text;
            c.Password1 = tb_password1.Text;
            c.Password2 = tb_password2.Text;
            if (!jdg.AllJdg_admin(c, out string AdminNameMessage, out string AccountMessage, out string PasswordMessage))
            //使用者資訊丟進jdg判斷,無錯誤回傳true,有錯則回傳false,並傳回錯誤訊息
            {
                lb_ErrorAdminName.Visible = true;
                lb_account.Visible = true;
                lb_password.Visible = true;
                lb_ErrorAdminName.Text = AdminNameMessage;
                lb_account.Text = AccountMessage;
                lb_password.Text = PasswordMessage;
                //打開錯誤訊息,顯示錯誤資訊
            }
            else
            {
                if (AddAdmin(c))//如果正確就丟進AddUserData方法裡加進資料庫
                {
                    MessageBox.Show("新增管理員成功");
                    this.Close(); //跳轉頁面
                }
                else
                {
                    MessageBox.Show("註冊失敗...");//其他狀況就顯示註冊失敗
                }
            }
        }

        private bool AddAdmin(CAdmin c)
        {
            string password = c.Password1;
            //跑100次雜湊
            for (int i = 0; i < 100; i++)
            {
                password = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "SHA256");
            }
            //insert into資料庫
            var admin = new Admin_Table
            {
                AdminName = c.AdminName,
                AccountName = c.AccountName,
                Password = password,
                AdminAuthority = true
            };
            dbcontext.Admin_Table.Add(admin);
            try
            {
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
