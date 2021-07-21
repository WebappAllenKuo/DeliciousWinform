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
    public partial class IngdEditForm : Form
    {
        public IngdEditForm()
        {
            InitializeComponent();
            HashTagEditFormStart();
        }
        SearchByTagClass sbt = new SearchByTagClass();
        DeliciousEntities dbc = new DeliciousEntities();
        private void HashTagEditFormStart()
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            var tags = dbc.Ingredient_Table.Select(t =>
            new
            {
                t.IngredientID,
                t.Ingredient,
            }).ToList();
            bindingSource1.DataSource = tags;
            bindingNavigator1.BindingSource = bindingSource1;
            bindingNavigator2.BindingSource = bindingSource2;
            dataGridView1.DataSource = bindingSource1;
            dataGridView2.DataSource = bindingSource2;
            bindingSource1.Position = 0;
            textBox2.Text = tags[0].IngredientID.ToString();
            textBox3.Text = tags[0].Ingredient;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            int[] tagids = sbt.IngdStringToIngdIds(dbc, textBox1.Text, checkBox1.Checked);
            if (tagids.Count() != 0)
            {
                var q = dbc.Ingredient_Table.Where(t => tagids.Contains(t.IngredientID)).Select(t => new
                {
                    t.IngredientID,
                    t.Ingredient
                }).ToList();
                bindingSource1.DataSource = q;
            }
            else
            {
                var q = dbc.Ingredient_Table.Select(t => new
                {
                    t.IngredientID,
                    t.Ingredient
                }).ToList();
                bindingSource1.DataSource = q;
            }
            dataGridView1.DataSource = bindingSource1;
            if (dataGridView1.CurrentRow != null)
            {
                bindingSource1.Position = 0;
                bindingSource1_PositionChanged(null, null);
            }
        }

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows[bindingSource1.Position].Selected = true;
                int id = (int)dataGridView1.Rows.SharedRow(bindingSource1.Position).Cells[0].Value;
                string name = dataGridView1.Rows.SharedRow(bindingSource1.Position).Cells[1].Value.ToString();
                textBox2.Text = id.ToString();
                textBox3.Text = name;
                int[] ida = new int[] { id };
                int[] recipeids = sbt.IngdIdsToRecipeIds(dbc, ida);
                var recipes = dbc.Recipe_Table.Where(r => recipeids.Contains(r.RecipeID)).Select(r => new
                {
                    r.RecipeID,
                    r.RecipeName,
                }).ToList();
                bindingSource2.DataSource = recipes;
                dataGridView2.DataSource = bindingSource2;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sbt.IngdTips(dbc, textBox1, toolTip1);
        }
    }
}
