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
    public partial class FrmAddMerchadisePic : Form
    {
       
        int getIngId=0,count=0;
        public FrmAddMerchadisePic(string IngName)
        {
            
            FindIDforIng(IngName);
            InitializeComponent();
            this.lb_IngName.Text = IngName;
            this.flp_PicsForMerch.DragDrop += FlowLayoutPanel1_DragDrop;
            this.flp_PicsForMerch.DragEnter += FlowLayoutPanel1_DragEnter;
            this.flp_PicsForMerch.AllowDrop = true;
        }
        DeliciousEntities dbcontext = new DeliciousEntities();
       

        private void FindIDforIng(string ingName)
        {
            var findidIng = dbcontext.Ingredient_Table.Where(n => n.Ingredient == ingName).Select(n=>n.IngredientID);
            getIngId = findidIng.First();


        }

        private void FlowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        List<System.IO.MemoryStream> ms = new List<System.IO.MemoryStream>();
        private void FlowLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {
            if (count <= 4)
            {
                string[] filenames = (string[])(e.Data.GetData(DataFormats.FileDrop));
                for (int i = 0; i <= filenames.Length - 1; i++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Image = Image.FromFile(filenames[i]);
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.flp_PicsForMerch.Controls.Add(pic);
                    System.IO.MemoryStream x = new System.IO.MemoryStream();
                    ms.Add(x);
                    pic.Image.Save(ms[count], System.Drawing.Imaging.ImageFormat.Jpeg);
                    count++;

                }
            }
            else { MessageBox.Show("圖片張數不大於5張"); return; }
        }

        
        private void bt_uppic_Click(object sender, EventArgs e)
        {
            if (count <= 5)
            {
                if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    int ImagesCount = this.openFileDialog1.FileNames.Length;
                    for (int i = 0; i <= ImagesCount - 1; i++)
                    {
                        PictureBox pic = new PictureBox();
                        pic.Image = Image.FromFile(this.openFileDialog1.FileNames[i]);
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        this.flp_PicsForMerch.Controls.Add(pic);
                        System.IO.MemoryStream x = new System.IO.MemoryStream();
                        ms.Add(x);
                        pic.Image.Save(ms[count], System.Drawing.Imaging.ImageFormat.Jpeg);
                        count++;

                    }

                }
            }
            else { MessageBox.Show("圖片張數不大於5張"); return; }

        }

        private void btncancelupd_Click(object sender, EventArgs e)
        {

            count = 0;
            ms.Clear();
            this.flp_PicsForMerch.Controls.Clear();
            this.Close();
        }

        private void bt_udpics_Click(object sender, EventArgs e)
        {
           
            
            for (int i = 0; i <= ms.Count - 1; i++)
            {
                Byte[] bytes;
                bytes = ms[i].GetBuffer();
                var newMerchidisePic = new Merchandise_Picture_Table() {
                IngredientID = getIngId,
                MerchandisePicture = bytes};
                dbcontext.Merchandise_Picture_Table.Add(newMerchidisePic);
                try
                {
                    dbcontext.SaveChanges();
                    MessageBox.Show("新增圖片成功");
                    this.Close();
                }
                catch (Exception) { MessageBox.Show("新增圖片失敗"); }

            }
        }

       
    }
}
