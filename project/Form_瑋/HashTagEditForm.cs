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
    public partial class HashTagEditForm : Form
    {
        public HashTagEditForm()
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
            var tags = dbc.Hashtag_Table.Select(t =>
            new
            {
                t.HashtagID,
                t.Hasgtag
            }).ToList();
            bindingSource1.DataSource = tags;
            bindingNavigator1.BindingSource = bindingSource1;
            bindingNavigator2.BindingSource = bindingSource2;
            dataGridView1.DataSource = bindingSource1;
            dataGridView2.DataSource = bindingSource2;
            bindingSource1.Position = 0;
            textBox2.Text = tags[0].HashtagID.ToString();
            textBox3.Text = tags[0].Hasgtag;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            int[] tagids = sbt.TagsStringToTagIds(dbc, textBox1.Text, checkBox1.Checked);
            if (tagids.Count() != 0)
            {
                var q = dbc.Hashtag_Table.Where(t => tagids.Contains(t.HashtagID)).Select(t => new
                {
                    t.HashtagID,
                    t.Hasgtag
                }).ToList();
                bindingSource1.DataSource = q;
            }
            else
            {
                var q = dbc.Hashtag_Table.Select(t => new
                {
                    t.HashtagID,
                    t.Hasgtag
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sbt.TagTips(dbc, textBox1, toolTip1);
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
                int[] ida = new int[] {id};
                int[] recipeids = sbt.TagIdsToRecipeIds(dbc, ida);
                var recipes = dbc.Recipe_Table.Where(r => recipeids.Contains(r.RecipeID)).Select(r => new
                {
                    r.RecipeID,
                    r.RecipeName,
                }).ToList();
                bindingSource2.DataSource = recipes;
                dataGridView2.DataSource = bindingSource2;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
            if (dbc.Hashtag_Table.Count(t => t.Hasgtag == textBox3.Text) != 0)
            {
                MessageBox.Show("已經有相同的HashTag名稱了");
            }
            else
            {
                int id = (int)dataGridView1.Rows.SharedRow(bindingSource1.Position).Cells[0].Value;
                DialogResult result = MessageBox.Show("確認修改" + Environment.NewLine + "HashTag編號:" + textBox2.Text + Environment.NewLine + "HashTag名稱:" + textBox3.Text + "?", "通知", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    var hashtag = dbc.Hashtag_Table.Where(t => t.HashtagID == id).ToList();
                    foreach (var t in hashtag)
                    {
                        t.Hasgtag = textBox3.Text;
                    }
                    dbc.SaveChanges();
                    MessageBox.Show("HashTag編號:" + textBox2.Text + Environment.NewLine + "HashTag名稱:" + textBox3.Text + Environment.NewLine + "修改成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var q = dbc.Hashtag_Table.Select(t => new { t.HashtagID, t.Hasgtag }).ToList();
                    bindingSource1.DataSource = q;
                }
                else
                {
                    return;
                }
            }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("修改失敗", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //try
            //{
            if (dbc.Hashtag_Table.Count(t => t.Hasgtag == textBox3.Text) != 0)
            {
                MessageBox.Show("已經有相同的HashTag名稱了");
            }
            else
            {
                DialogResult result = MessageBox.Show("確認新增" + Environment.NewLine + "HashTag:" + textBox3.Text + "?", "通知", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    var hashtag = new Hashtag_Table()
                    {
                        Hasgtag = textBox3.Text
                    };
                    dbc.Hashtag_Table.Add(hashtag);
                    dbc.SaveChanges();
                    MessageBox.Show("HashTag:" + textBox3.Text + Environment.NewLine + "新增成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var q = dbc.Hashtag_Table.Select(t => new { t.HashtagID, t.Hasgtag }).ToList();
                    bindingSource1.DataSource = q;
                    bindingSource1.Position = (q.Count - 1);
                }
                else
                {
                    return;
                }
            }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("新增失敗", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確認刪除" + Environment.NewLine + "HashTag編號:" + textBox2.Text + Environment.NewLine + "HashTag名稱:" + textBox3.Text + Environment.NewLine+ "以及從所有使用此HashTag的食譜中刪除此HashTag的紀錄?", "通知", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int id = (int)dataGridView1.Rows.SharedRow(bindingSource1.Position).Cells[0].Value;
                dbc.Hashtag_Record_Table.RemoveRange(dbc.Hashtag_Record_Table.Where(r => r.HashTagID == id));
                dbc.Hashtag_Table.RemoveRange(dbc.Hashtag_Table.Where(t => t.HashtagID == id));
                dbc.SaveChanges();
                MessageBox.Show("HashTag:" + textBox3.Text + Environment.NewLine + "刪除成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HashTagEditFormStart();
            }
            else
            {
                return;
            }
        }
    }
}
