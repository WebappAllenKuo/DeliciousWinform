using Delicious_Kashir;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.Form_瑋
{
    public partial class TagForm : Form
    {
        public TagForm()
        {
            InitializeComponent();
            var q = dbc.Hashtag_Record_Table.GroupBy(hr => hr.HashTagID).Select(g => new
            {
                HashTag = dbc.Hashtag_Table.Where(t => t.HashtagID == g.Key).Select(t => t.Hasgtag).FirstOrDefault(),
                總觀看數 = g.Sum(ro => dbc.Recipe_Table.Where(r => r.RecipeID == ro.RecipeID).Sum(r => r.Views)),
                g.Key,
            }).OrderByDescending(v => v.總觀看數).ToList();
            bindingSource1.DataSource = q;
            dataGridView1.DataSource = bindingSource1;
           
                dataGridView1.Rows[bindingSource1.Position].Selected = true;
                int id = (int)dataGridView1.Rows.SharedRow(bindingSource1.Position).Cells[2].Value;
                var q1 = dbc.Hashtag_Record_Table.Where(hr => hr.HashTagID == id).Select(r => new
                {
                    食譜 = dbc.Recipe_Table.Where(rt => rt.RecipeID == r.RecipeID).Select(n => n.RecipeName).FirstOrDefault(),
                    觀看數 = dbc.Recipe_Table.Where(rt => rt.RecipeID == r.RecipeID).Select(n => n.Views).FirstOrDefault(),
                    r.RecipeID,
                }).OrderByDescending(v => v.觀看數).ToList();
                dataGridView2.DataSource = q1;
            
        }
        DeliciousEntities dbc = new DeliciousEntities();
        SearchByTagClass sbt = new SearchByTagClass();

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows[bindingSource1.Position].Selected = true;
                int id = (int)dataGridView1.Rows.SharedRow(bindingSource1.Position).Cells[2].Value;
                var q = dbc.Hashtag_Record_Table.Where(hr => hr.HashTagID == id).Select(r => new
                {
                    食譜 = dbc.Recipe_Table.Where(rt => rt.RecipeID == r.RecipeID).Select(n => n.RecipeName).FirstOrDefault(),
                    觀看數 = dbc.Recipe_Table.Where(rt => rt.RecipeID == r.RecipeID).Select(n => n.Views).FirstOrDefault(),
                    r.RecipeID,
                }).OrderByDescending(v => v.觀看數).ToList();
                dataGridView2.DataSource = q;
            }
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                RecipePage recipePage = new RecipePage((int)dataGridView2.CurrentRow.Cells[2].Value);
                recipePage.ShowDialog();
            }
            else
            {
                return;
            }
        }
    }
}
