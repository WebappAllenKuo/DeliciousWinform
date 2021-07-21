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
    public partial class FSelectAccuseID : Form
    {
        string AccusedAvatar; int AccusedID;
        public FSelectAccuseID(string _AccusedAvatar, int _AccusedID)
        {
            InitializeComponent();
            AccusedAvatar = _AccusedAvatar;
            AccusedID = _AccusedID;
        }
        DeliciousEntities DE = new DeliciousEntities();
        private void FSelectAccuseID_Load(object sender, EventArgs e)
        {
            var q = from n in DE.AccuseContent_Table
                    select n.Accusation;
            comboBox1.DataSource = q.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selected = comboBox1.SelectedIndex;
            CFSelectAccuseID cAccusation = new CFSelectAccuseID();
            cAccusation.setAccusation(selected, AccusedAvatar, AccusedID);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
