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

namespace project.Form_Chia
{
    public partial class FrmSendEmail : Form
    {
        public FrmSendEmail()
        {
            InitializeComponent();
            lb_adminname.Text = "管理員 " + Viewbag.Admin.AdminName + " 您好 ";
            
            this.tb_AccountName.Enabled = false;
            
            this.tb_Email.Enabled = false;
            this.tb_MemberName.Enabled = false;
            this.tb_MID.Enabled = false;
            
        }
        
        private void btn_Srh_Click(object sender, EventArgs e)
        {
            DeliciousEntities dbcontext = new DeliciousEntities();
            var q = dbcontext.Member_Table.Where(n => n.CellNumber.Contains(this.tb_SrhCondition.Text) || n.MemberName.Contains(this.tb_SrhCondition.Text) || n.Email.Contains(this.tb_SrhCondition.Text)).Select(n => new {n.MemberID, n.AccountName, n.MemberName, n.CellConfirm, n.Email });
            this.bindingSource1.DataSource = q.ToList();
            this.dgv_MemberInfo.DataSource = this.bindingSource1;
            this.tb_MID.DataBindings.Add("Text", bindingSource1, "MemberID");
            this.tb_AccountName.DataBindings.Add("Text", bindingSource1, "AccountName");
            this.tb_MemberName.DataBindings.Add("Text", bindingSource1, "MemberName");
            this.tb_Email.DataBindings.Add("Text", bindingSource1, "Email");

        }



        private void btn_Send_Click(object sender, EventArgs e)
        {
            DeliciousEntities dbcontext = new DeliciousEntities();
            string confornnums = dbcontext.Member_Table.AsEnumerable().Single(n => n.MemberID == Convert.ToInt32(this.tb_MID.Text)).EmailConfirm.ToString();
            SendEmail sendtomember = new SendEmail()
            {
                email = this.tb_Email.Text,
                conform = confornnums,//驗證碼
                Subject = "瘋廚網認證信寄發",//主旨
                Body = "您好  " + this.tb_MemberName.Text +"\n\n 管理員 "+ Viewbag.Admin.AdminName + " 很高興能為您服務"+"\n\n以下為認證碼\n",//內文
                Result = "感謝",//回傳訊息 
            };
            sendtomember.send();
            MessageBox.Show("寄送成功");

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
