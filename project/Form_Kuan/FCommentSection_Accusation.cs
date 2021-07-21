using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.Form_Kuan
{
    public partial class FCommentSection_Accusation : Form
    {
        public FCommentSection_Accusation()
        {
            InitializeComponent();
        }
        DeliciousEntities DE = new DeliciousEntities();
        CAccusation CACC = new CAccusation();
        private void FCommentSection_Accusation_Load(object sender, EventArgs e)
        {
            //var q = from n in DE.Accusation_Table
            //        where n.AccusedAvatar == "1" && n.ProgressID == 0
            //        select n;
            var q = CACC.get_Accusation_Table_Froze(DE, 1);
            dataGridView1.DataSource = q.ToList();
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int get_select = Convert.ToInt32(dataGridView1.CurrentRow.Cells["AccusedID"].Value);
            int get_select_Accusation = Convert.ToInt32(dataGridView1.CurrentRow.Cells["AccusationRightID"].Value);
            CommentSection_Table q = (from n in DE.CommentSection_Table
                              where n.CommentID == get_select
                              select n).FirstOrDefault();
            q.DisVisible = true;
            DE.SaveChanges();
            var q2 = (from n in DE.Accusation_Table
                      where n.AccusationRightID == get_select_Accusation
                      select n).FirstOrDefault();
            q2.ProgressID = 0;
            DE.SaveChanges();
            var result = (from n in DE.CommentSection_Table
                          where n.CommentID == get_select
                          select new { n.RecipeID, n.CommentID, n.MemberID, n.Comment, n.DisVisible });
            dataGridView2.DataSource = result.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int get_select = Convert.ToInt32(dataGridView1.CurrentRow.Cells["AccusedID"].Value);
            int get_select_Accusation = Convert.ToInt32(dataGridView1.CurrentRow.Cells["AccusationRightID"].Value);
            CommentSection_Table q = (from n in DE.CommentSection_Table
                                      where n.CommentID == get_select
                                      select n).FirstOrDefault();
            q.DisVisible = false;
            DE.SaveChanges();
            var q2 = (from n in DE.Accusation_Table
                      where n.AccusationRightID == get_select_Accusation
                      select n).FirstOrDefault();
            q2.ProgressID = 1;
            DE.SaveChanges();
            var result = (from n in DE.CommentSection_Table
                          where n.CommentID == get_select
                          select new { n.RecipeID, n.CommentID, n.MemberID, n.Comment, n.DisVisible });
            dataGridView2.DataSource = result.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //var q = from n in DE.Accusation_Table
            //        where n.AccusedAvatar == "1"  
            //        select n;
            var q = CACC.get_Accusation_Table_All(DE, 1);
            dataGridView1.DataSource = q.ToList();
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
