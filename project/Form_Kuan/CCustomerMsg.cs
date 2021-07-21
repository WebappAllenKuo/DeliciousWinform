using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.Form_Kuan
{
    class CCustomerMsg
    {
         
        DeliciousEntities DE = new DeliciousEntities();
        PictureBox _pic1 = null;
        public PictureBox setPicturebox(PictureBox getpic)
        {
            _pic1 = getpic;
            this._pic1.AllowDrop = true;
            this._pic1.DragDrop += Pb_RecipeIMG_DragDrop;
            this._pic1.DragEnter += Pb_RecipeIMG_DragEnter;
            this._pic1.Click += _pic1_Click;
            _pic1.DoubleClick += _pic1_DoubleClick;
            return _pic1;
        }

        private void _pic1_DoubleClick(object sender, EventArgs e)
        {
            PictureBox M_Picture = sender as PictureBox;
            OpenFileDialog openIMGDialog = new OpenFileDialog();
            MemoryStream memory = new MemoryStream();
            openIMGDialog.Filter = "*.jpg|*.jpg|*.png|*.png|*.jpeg|*.jpeg|*.bmp|*.bmp";
            if (openIMGDialog.ShowDialog() == DialogResult.OK)
            {
                M_Picture.Image = Image.FromFile(openIMGDialog.FileName);               
            }
        }

        private void _pic1_Click(object sender, EventArgs e)
        {
             PictureBox m_picture = (PictureBox)sender;
            if (m_picture.Image != null)
            {
                Form loading_form = new Form();
                loading_form.Size = new System.Drawing.Size(640, 480);
                loading_form.ControlBox = true;
                loading_form.StartPosition = FormStartPosition.CenterParent;
                PictureBox picbox1 = new PictureBox();
                picbox1.Size = new System.Drawing.Size(640, 480);
                picbox1.Image = m_picture.Image;
                picbox1.Location = new System.Drawing.Point(0, 0);
                picbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                loading_form.Controls.Add(picbox1);
                loading_form.Show();
            }
        }

        private void Pb_RecipeIMG_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy; //拖曳效果
        }

        private void Pb_RecipeIMG_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                FlowLayoutPanel controlflow = sender as FlowLayoutPanel;
                string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop);               

               
                if (_pic1.Image != null) //判斷PictureBox是否有圖片
                {
                    _pic1.Image = null; //清除PictureBox裡的圖片                   
                }
                _pic1.Image = Image.FromFile(filenames[0]); //顯示
            }
            catch (Exception)
            {
                MessageBox.Show("非圖片格式", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public IQueryable<string> get_Feedback_Category()
        {
            var q = from n in DE.Feedback_Category_Table
                    select n.FeedbackCategory;
            return q;
             
        }
        public IQueryable<string> get_Feedback_msg(int _member_id)
        {
            
            var q1 = from n in DE.Feedback_Table
                     where n.MemberID == _member_id
                     select n.Contents;
            return q1;
        }
         
        public IQueryable<Feedback_Table> get_Feedback_msg_byindex(int _current_index)
        {

            var q = (from n in DE.Feedback_Table
                     where n.FeedbackID == _current_index
                     select n); 
            return q;
        }
        public IQueryable< Feedback_Table >get_Feedback_process(int _ProcessNum)
        {

            var q2 = from n in DE.Feedback_Table
                     where n.ProgressID < _ProcessNum
                     select n;
            return q2;
        }
         
        
    }
}
