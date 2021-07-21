using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project.Form_Kuan;

namespace project.Form_Kuan
{
    public partial class FCustomerMsg : Form
    {
        int member_id = 2;
        int m_AuthorityID = 2;
         
        public FCustomerMsg()
        {
            InitializeComponent();
            pictureBox1 = new CCustomerMsg().setPicturebox(pictureBox1);
            pictureBox2 = new CCustomerMsg().setPicturebox(pictureBox2);
            member_id = Viewbag.member.MemberID;
            m_AuthorityID = Viewbag.member.AuthorityID;


        }
        DeliciousEntities DE = new DeliciousEntities();
        
       
        private void FCustomerMsg_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.pictureBox1, "請拖放圖片至此");
            //var get_AuthorityID = (from n in DE.Member_Table
            //                      where n.MemberID == member_id
            //                      select n.AuthorityID).FirstOrDefault();

            //m_AuthorityID = (int)get_AuthorityID;

            if (m_AuthorityID < 3)
            {
                 
                textBox2.Visible = false;
                label2.Visible = false;
                pictureBox2.Visible = false;
                button2.Visible = false;
                label4.Visible = false;
                var q2 = from n in DE.Feedback_Table
                         where n.MemberID == member_id
                         select new { n.Feedback_Category_Table.FeedbackCategory,
                             n.Contents,
                             n.FeedbackContent,
                             n.Feedback_Progress_Table.ProgressContent,
                             n.FeedbackDate,
                             n.Picture
                         };
                dataGridView1.DataSource = q2.ToList();
                label3.Text = Viewbag.member.MemberName;

                
            }
            else
            {
                label1.Visible = false;
                pictureBox1.Visible = false;
                textBox1.Visible = false;
                listBox1.Visible = false;
                button1.Visible = false;
                label3.Visible = false;
                var q2 = new CCustomerMsg().get_Feedback_process(4);
                dataGridView1.DataSource = q2.ToList();
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].Visible = false;
                label4.Text = Viewbag.member.MemberName;


            }

            comboBox1.DataSource = new CCustomerMsg().get_Feedback_Category().ToList();
            var q1 = new CCustomerMsg().get_Feedback_msg(member_id);
            foreach (var item in q1)
            {
                listBox1.Items.Add(item);
            }

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            Feedback_Table ft = new Feedback_Table();            
            ft.FeedbackCategoryID = comboBox1.SelectedIndex+1;
            ft.MemberID = member_id;
            ft.Contents = textBox1.Text;
            ft.ProgressID = 1;
            ft.FeedbackDate = DateTime.Today;
            if (pictureBox1.Image != null)
            {
                byte[] bytes;
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                bytes = ms.GetBuffer();
                ft.Picture = bytes;
            }
            DE.Feedback_Table.Add(ft);
            DE.SaveChanges();
            listBox1.Items.Clear();
            var q1 = new CCustomerMsg().get_Feedback_msg(member_id);
            foreach (var item in q1)
            {
                listBox1.Items.Add(item);
            }
            textBox1.Text = "";
            pictureBox1.Image = null;
            var q2 = from n in DE.Feedback_Table
                     where n.MemberID == member_id
                     select new
                     {
                         n.Feedback_Category_Table.FeedbackCategory,
                         n.Contents,
                         n.FeedbackContent,
                         n.Feedback_Progress_Table.ProgressContent,
                         n.FeedbackDate,
                         n.Picture
                     };
            dataGridView1.DataSource = q2.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int current_index = (int)(dataGridView1.CurrentRow.Cells[0].Value);

            var q = (from n in DE.Feedback_Table
                     where n.FeedbackID == current_index
                     select n).FirstOrDefault();
            
            q.FeedbackContent = textBox2.Text;
            q.ProgressID = 3;
            q.FeedbackDate = DateTime.Now ;
            DE.SaveChanges();

            var q2 = new CCustomerMsg().get_Feedback_process(4);
            dataGridView1.DataSource = q2.ToList();
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            textBox2.Text = "";
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            byte[] bytes;
             
            bytes = (byte[])dataGridView1.CurrentRow.Cells["Picture"].Value;
            
            if (bytes != null)
            {
                if (m_AuthorityID > 2)
                {
                    comboBox1.SelectedIndex = (int)dataGridView1.CurrentRow.Cells[1].Value;
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                    pictureBox2.Image = Image.FromStream(ms);
                }
                else
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                    pictureBox1.Image = Image.FromStream(ms);
                }
               
            }
            else
            {
                pictureBox1.Image = null;
                pictureBox2.Image = null;
            }
            

               
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
