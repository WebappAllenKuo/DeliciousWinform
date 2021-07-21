using Delicious_Kashir;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.Model_秉鈞
{
    public partial class RecipeControl : UserControl
    {
        public RecipeControl(int id)
        {
            InitializeComponent();
            pb_recipePB.BackColor = Color.AliceBlue;
            this.pb_recipePB.Name = id.ToString();
            this.Name = id.ToString();
        }
        public RecipeControl(int id , Color c)
        {
            InitializeComponent();
            this.BackColor = c;
            this.pb_recipePB.Name = id.ToString();
            this.Name = id.ToString();
        }

        private void pb_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            RecipePage recipePage = new RecipePage(Convert.ToInt32(pb.Name));
            recipePage.ShowDialog();
        }

        public void setAll(byte[] bytes, string RecipeName, string NickName, int view, int like)
        {
            if (bytes != null)
            {
                MemoryStream ms = new MemoryStream(bytes);
                this.pb_recipePB.Image = Image.FromStream(ms);
            }
            else
            {
                this.pb_recipePB.Image = null;
            }
            lb_RecipeName.Text = RecipeName;
            lb_NickName.Text = NickName;
            lb_Views.Text = view.ToString();
            lb_Like.Text = like.ToString();
        }
        
    }
}
