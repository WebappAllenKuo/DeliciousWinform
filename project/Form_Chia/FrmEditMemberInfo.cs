using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.Form_Chia
{
    public partial class FrmEditMemberInfo : Form
    {

        public FrmEditMemberInfo(int Mid)
        {
            InitializeComponent();
            FormContent(Mid);
        }
        DeliciousEntities dbcontext = new DeliciousEntities();
        public void FormContent(int Mid)
        {
            this.tb_Mid.Text = Mid.ToString();
            var q = this.dbcontext.Member_Table.Where(n => n.MemberID == Mid).Select(n => new { n.AccountName,n.MemberName,n.CellNumber,n.Email,n.Nickname,n.Gender,n.Birthday,n.MemberID});
            foreach (var item in q) {

                this.tb_Accountname.Text = item.AccountName;
                this.tb_MemberName.Text = item.MemberName;
                this.tb_cellnumber.Text = item.CellNumber;
                this.tb_email.Text = item.Email;
                this.tb_Nickname.Text = item.Nickname;
                this.cb_gender.Text = item.Gender;
                this.pb_birthday.Text = item.Birthday.ToString();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
           
            this.tb_MemberName.Enabled = true;
            this.tb_cellnumber.Enabled = true;
            this.tb_email.Enabled = true;
            this.tb_Nickname.Enabled = true;
            this.cb_gender.Enabled = true;
            //this.birthdayPicker.Enabled = true;
        }

        private void btn_checkedit_Click(object sender, EventArgs e)
        {
            UpdateMemb();
        }

        private void UpdateMemb()
        {
            if (checkcontent())
            {
                int Mid = Convert.ToInt32(this.tb_Mid.Text);
                var q = this.dbcontext.Member_Table.Where(n => n.MemberID == Mid).Select(n => n);
                foreach (var item in q)
                {

                    item.MemberName = this.tb_MemberName.Text;
                    item.CellNumber = this.tb_cellnumber.Text;
                    item.Email = this.tb_email.Text;
                    item.Nickname = this.tb_Nickname.Text;
                    item.Gender = this.cb_gender.Text;
                }
                this.dbcontext.SaveChanges();
                this.tb_Accountname.Enabled = false;
                this.tb_MemberName.Enabled = false;
                this.tb_cellnumber.Enabled = false;
                this.tb_email.Enabled = false;
                this.tb_Nickname.Enabled = false;
                this.cb_gender.Enabled = false;
            }
        }

        private bool checkcontent()
        {
            DeliciousEntities dbcontext = new DeliciousEntities();
            var countcell = dbcontext.Member_Table.AsEnumerable().Where(n => n.CellNumber == tb_cellnumber.Text && n.MemberID != Convert.ToInt32(this.tb_Mid.Text)).Select(n => n).Count();

            var iswords = new Regex(@"[\u4E00-\u9FA5]{2,4}$");
            var isnums = new Regex(@"09[0-9]{8}$");
            if (!iswords.IsMatch(tb_MemberName.Text)) { MessageBox.Show("會員姓名2-4個中文字"); return false; }
            if (!isnums.IsMatch(tb_cellnumber.Text)) { MessageBox.Show("請輸入正確的手機號碼"); return false; }
            if (countcell > 0) { MessageBox.Show("手機號碼已被註冊過"); return false; }
            var q = (from m in dbcontext.Member_Table
                     where m.Email == this.tb_email.Text
                     select m).ToList();
            if (q.Count >1)
            {
                MessageBox.Show("此信箱已被使用");
                return false;
            }
            var emailjdg = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            if (string.IsNullOrWhiteSpace(this.tb_email.Text))
            {
                MessageBox.Show("請輸入電子信箱");
                return false;
            }
            else if (!emailjdg.IsMatch(this.tb_email.Text))
            {
                MessageBox.Show("請輸入正確的電子信箱");
                return false;
            }
           


            return true;
        }

        private void btn_Finished_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
