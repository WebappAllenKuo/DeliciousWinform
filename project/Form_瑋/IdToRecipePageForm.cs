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
    public partial class IdToRecipePageForm : Form
    {
        DeliciousEntities dbc = new DeliciousEntities();
        public int RecipeId { get; set; }
        public IdToRecipePageForm(int RecipeId)
        {
            InitializeComponent();
            this.RecipeId = RecipeId;
            MessageBox.Show("食譜編號" + RecipeId.ToString());
            var q = dbc.Recipe_Table.Where(r => r.RecipeID == this.RecipeId).Select(r => new {
                r.RecipeID,
                r.RecipeName,
                r.RecipeDescription,
                RecipeCategory = dbc.RecipeCategory_Table.Where(c => c.RecipeCategoryID == r.RecipeCategoryID).Select(c => c.RecipeCategory).FirstOrDefault(),
                RecipeStep = dbc.Steps_Table.Where(s => s.RecipeID == r.RecipeID).OrderBy(s => s.StepsNumber).Select(s => s.Steps.ToString()).ToList(),
                r.Picture,
                Tags = dbc.Hashtag_Record_Table.Where(t => t.RecipeID == r.RecipeID).Select(t => new
                {

                }),
            }).FirstOrDefault();
            textBox1.Text = q.RecipeID.ToString();
            textBox2.Text = q.RecipeName.ToString();
            textBox3.Text = q.RecipeCategory.ToString();
            textBox4.Text = q.RecipeDescription.ToString();
            listBox1.Items.Clear();
            int snum = 0;
            foreach (string s in q.RecipeStep)
            {
                snum++;
                listBox1.Items.Add(snum.ToString() + "." + s);
            }
        }
    }
}
