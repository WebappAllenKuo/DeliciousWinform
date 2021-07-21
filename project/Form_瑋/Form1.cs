using project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Dynamic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchByHashTag
{
   
    public partial class Form1 : Form
    {
        DeliciousEntities dbc = new DeliciousEntities();
        public Form1()
        {
            
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            string[] tags = textBox1.Text.Split();
            //MessageBox.Show("0354");
            var qt = dbc.Hashtag_Table.Where(t => tags.Contains(t.Hasgtag)).Select(t => new
            {
                t.HashtagID,
                t.Hasgtag,
                TagRecipes = dbc.Hashtag_Record_Table.Where(r => r.HashTagID == t.HashtagID).Select(r => new
                {
                    Recipes = dbc.Recipe_Table.Where(r1 => r1.RecipeID == r.RecipeID),
                }
                ).SelectMany(r => r.Recipes),
            }
            ).SelectMany(r => r.TagRecipes);
            //dataGridView1.DataSource = qt.ToList();

            var tagids = dbc.Hashtag_Table.Where(t => tags.Contains(t.Hasgtag)).Select(t => t.HashtagID).ToList();

            var taggrp = dbc.Hashtag_Record_Table.GroupBy(r => r.RecipeID).Where(g => tagids.All(t => g.Where(r => r.HashTagID == t).Count() != 0)).Select(g => dbc.Recipe_Table.Where(r => r.RecipeID == g.Key).FirstOrDefault()).ToList();


            dataGridView1.DataSource = taggrp.ToList();

            //var q = tagids.ForEach(id => id);

            //foreach(int tagid in tagids)
            //{

            //}

            //var tagrcp = taggrp.Where();

            //var tagids = dbc.Hashtag_Table.Where(t => tags.Contains(t.Hasgtag)).Select(t => t.HashtagID);
            //var qta = dbc.Hashtag_Record_Table;
            //foreach (int tagid in tagids)
            //{
            //    qta.All(r => r.HashTagID == tagids.).Select(r => r.RecipeID);
            //}

            //dataGridView1.DataSource = qta.ToList();
            //var qtr = dbc.Hashtag_Record_Table.Where()

            var qr = dbc.Recipe_Table;

            var qm = dbc.Member_Table.Where(m => true).Select(m => m);

            //


            //if (comboBox1.SelectedIndex == 0)
            //    dataGridView1.DataSource = qr.ToList();
            //else
            //    dataGridView1.DataSource = qm.ToList();


            //MessageBox.Show(tags[0]);
            //MessageBox.Show(tags[1]);
            //var q3 = dbc.Recipe_Table(r => r)



            //var q3 = dbc.Hashtag_Record_Table.Where(r => r.HashTagID == );

            //foreach(string tag in tags)
            //{

            //}
            //string tag1 = tags[0];
            //var q = dbc.Ingredient_Table.Where(i => (i.Ingredient == tag1) && (i.InStoreOrNot)).Select(i =>
            //    new
            //    {
            //        i.Ingredient,
            //        Cname = dbc.IngredientCategory_Table.Where(c => c.IngredientCategoryID == i.IngredientCategoryID).Select(c => c.IngredientCategory).FirstOrDefault(),
            //    }

            //    ).ToList();


            //dataGridView1.DataSource = q;



            //DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            //{
            //    button.Name = "button";
            //    button.HeaderText = "Button";
            //    button.Text = "Button";
            //    button.UseColumnTextForButtonValue = true; //dont forget this line
            //    this.dataGridView1.Columns.Add(button);
            //}

        }


    }
    public static class PredicateBuilder
    {
        public static Expression<Func<T, bool>> True<T>() { return f => true; }
        public static Expression<Func<T, bool>> False<T>() { return f => false; }

        public static Expression<Func<T, bool>> Or<T>(this Expression<Func<T, bool>> expr1,
                                                            Expression<Func<T, bool>> expr2)
        {
            var invokedExpr = Expression.Invoke(expr2, expr1.Parameters.Cast<Expression>());
            return Expression.Lambda<Func<T, bool>>
                  (Expression.OrElse(expr1.Body, invokedExpr), expr1.Parameters);
        }

        public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> expr1,
                                                             Expression<Func<T, bool>> expr2)
        {
            var invokedExpr = Expression.Invoke(expr2, expr1.Parameters.Cast<Expression>());
            return Expression.Lambda<Func<T, bool>>
                  (Expression.AndAlso(expr1.Body, invokedExpr), expr1.Parameters);
        }
    }
}
