using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project.Form_育政;
using Delicious_Kashir;

namespace project.Form_瑋
{
    public partial class SearchByTagForm : Form
    {
        public SearchByTagForm()
        {
            InitializeComponent();

            string[] rt5 = dbc.Recipe_Table.OrderByDescending(r => r.Views).Take(5).Select(r => r.RecipeName).ToArray();
            linklabel1.Text = rt5[0];
            linklabel2.Text = rt5[1];
            linklabel3.Text = rt5[2];
            linklabel4.Text = rt5[3];
            linklabel5.Text = rt5[4];
        }
        DeliciousEntities dbc = new DeliciousEntities();
        SearchByTagClass sbt = new SearchByTagClass();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            int[] tagids = sbt.TagsStringToTagIds(dbc, textBox1.Text, checkBox1.Checked);
            int[] recipeids = sbt.TagIdsToRecipeIds(dbc, tagids, checkBox1.Checked);
            var recipes = dbc.Recipe_Table.Where(r => recipeids.Contains(r.RecipeID)).Select(r => r);
            dataGridView1.DataSource = recipes.Select(r => new
            {
                r.RecipeID,
                r.RecipeName,
            }).ToList();
            string stchar = "TagIds:";
            foreach (int id in tagids)
            {
                stchar += id.ToString()+",";
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            IdToRecipePageForm recipePage = new IdToRecipePageForm(a);
            recipePage.Show();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sbt.TagTips(dbc, textBox1, toolTip1);
            sbt.IngdTips(dbc, textBox1, toolTip1);
        }
    }
}
