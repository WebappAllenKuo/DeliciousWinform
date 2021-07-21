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
    public partial class FrmGetMember : Form
    {
        public FrmGetMember()
        {
            InitializeComponent();
            lb_adminname.Text = "管理員 " + Viewbag.Admin.AdminName + " 您好 ";
        }
        
        private void btn_Srh_Click(object sender, EventArgs e)
        {
            DeliciousEntities dbcontext = new DeliciousEntities();
            var q = dbcontext.Member_Table.Where(n => n.CellNumber.Contains(this.tb_SrhCondition.Text) || n.MemberName.Contains(this.tb_SrhCondition.Text) || n.Email.Contains(this.tb_SrhCondition.Text)).Select(n=>new { n.MemberID,n.MemberName,n.Nickname,n.CellNumber,n.Email });
            this.dgv_MemInfo.DataSource = q.ToList();
        }
        private void GetthisMember(int Mid) { 
            FrmEditMemberInfo editMemberForm = new FrmEditMemberInfo(Mid);
            editMemberForm.ShowDialog();
            this.dgv_MemInfo.DataSource = null;
            btn_Srh_Click(null, null);
        }

        private void dgv_Member_DoubleClick(object sender, EventArgs e)
        {
            int MID=Convert.ToInt32(this.dgv_MemInfo.Rows[this.dgv_MemInfo.CurrentCell.RowIndex].Cells["MemberID"].Value);
            GetthisMember(MID);
        }
    }
}
