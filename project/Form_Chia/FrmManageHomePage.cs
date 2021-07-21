using project.Form_Kuan;
using project.Form_瑋;
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
    public partial class FrmManageHomePage : Form
    {
        public FrmManageHomePage()
        {
          
            InitializeComponent();
            lb_adminname.Text = "管理員 "+Viewbag.Admin.AdminName+" 您好 ";
        }

        private void btnAddIng_Click(object sender, EventArgs e)
        {
            FrmAddIngr ingredientAdd = new FrmAddIngr();
            this.Visible = false;
            ingredientAdd.ShowDialog();
            this.Visible = true;
        }

        private void btn_UpdIng_Click(object sender, EventArgs e)
        {
            FrmUpdateIng updateIng = new FrmUpdateIng();
            this.Visible = false;
            updateIng.ShowDialog();
            this.Visible = true;
        }

        private void btn_UpdMem_Click(object sender, EventArgs e)
        {
            FrmGetMember GetMemberForm = new FrmGetMember();
            this.Visible = false;
            GetMemberForm.ShowDialog();
            this.Visible = true;
        }

        private void btn_HideRecipe_Click(object sender, EventArgs e)
        {
            FAccusation maccusation = new FAccusation();
            this.Visible = false;
            maccusation.ShowDialog();
            this.Visible = true;
        }

      
       

        private void btn_SendMail_Click(object sender, EventArgs e)
        {
            FrmSendEmail sendEmail = new FrmSendEmail();
            this.Visible = false;
            sendEmail.ShowDialog();
            this.Visible = true;

        }

        private void btn_SearchOrder_Click(object sender, EventArgs e)
        {
            FrmOrderSearch ordersearchform = new FrmOrderSearch();
            this.Visible = false;
            ordersearchform.ShowDialog();
            this.Visible = true;
        }

        private void btn_HideComment_Click(object sender, EventArgs e)
        {
            FCommentSection_Accusation fcommentSection_Accusation = new FCommentSection_Accusation();
            fcommentSection_Accusation.Show();
           
        }

        private void btn_HashTagManage_Click(object sender, EventArgs e)
        {
            HashTagEditForm HashTagEditFrm = new HashTagEditForm();
            HashTagEditFrm.Show();
        }

        private void btn_OrderManage_Click(object sender, EventArgs e)
        {
            FrmSetOrderStatus orderStatusFRM = new FrmSetOrderStatus();
            this.Visible = false;
            orderStatusFRM.ShowDialog();
            this.Visible = true;
        }

        private void btn_ManageIngRecipe_Click(object sender, EventArgs e)
        {
            RcpEditForm rcpEditForm = new RcpEditForm();
            rcpEditForm.Show();

        }

        private void btn_QA_Click(object sender, EventArgs e)
        {
            FCustomerMsg fCustomer = new FCustomerMsg();
            fCustomer.Show();
        }
    }
}
