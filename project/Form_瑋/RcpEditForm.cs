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
    public partial class RcpEditForm : Form
    {
        public RcpEditForm()
        {
            InitializeComponent();
            RcpEditFormStart();
        }
        SearchByTagClass sbt = new SearchByTagClass();
        DeliciousEntities dbc = new DeliciousEntities();
        private void RcpEditFormStart()
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;
            dataGridView4.DataSource = null;
            dataGridView5.DataSource = null;
            var rcps = dbc.Recipe_Table.Select(t =>
            new
            {
                t.RecipeID,
                t.RecipeName
            }).ToList();
            bindingSource1.DataSource = rcps;
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;
            bindingSource1.Position = 0;
            textBox4.Text = rcps[0].RecipeID.ToString();
            textBox5.Text = rcps[0].RecipeName;

            var tags = dbc.Hashtag_Table.Select(t =>
            new
            {
                t.HashtagID,
                t.Hasgtag
            }).ToList();
            bindingSource2.DataSource = tags;
            bindingNavigator2.BindingSource = bindingSource2;
            dataGridView2.DataSource = bindingSource2;
            bindingSource2.Position = 0;
            textBox6.Text = tags[0].HashtagID.ToString();
            textBox7.Text = tags[0].Hasgtag;

            var ingds = dbc.Ingredient_Table.Select(t =>
            new
            {
                t.IngredientID,
                t.Ingredient,
            }).ToList();
            bindingSource3.DataSource = ingds;
            bindingNavigator3.BindingSource = bindingSource3;
            dataGridView3.DataSource = bindingSource3;
            bindingSource3.Position = 0;
            textBox8.Text = ingds[0].IngredientID.ToString();
            textBox9.Text = ingds[0].Ingredient;

            int rid = Int32.Parse(textBox4.Text);

            var rt = dbc.Hashtag_Record_Table.Where(rr => rr.RecipeID == rid).Select(r => new
            {
                r.RecipeID,
                r.HashTagID,
                r.HashTagFolderID,
            }).ToList();
            bindingSource4.DataSource = rt;
            bindingNavigator4.BindingSource = bindingSource4;
            dataGridView4.DataSource = bindingSource4;

            var ri = dbc.Ingredient_Record_Table.Where(i => i.RecipeID == rid).Select(r => new
            {
                r.RecipeID,
                r.IngredientID,
                RecordID = r.IngredientRecordID,
                Unit = r.Unt,
                Amt = r.IngredientAmountForUse,
            }).ToList();
            bindingSource5.DataSource = ri;
            bindingNavigator5.BindingSource = bindingSource5;
            dataGridView5.DataSource = bindingSource5;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            int[] tagids = sbt.RcpStringToRcpIds(dbc, textBox1.Text, checkBox1.Checked);
            if (tagids.Count() != 0)
            {
                var q = dbc.Recipe_Table.Where(t => tagids.Contains(t.RecipeID)).Select(t => new
                {
                    t.RecipeID,
                    t.RecipeName
                }).ToList();
                bindingSource1.DataSource = q;
            }
            else
            {
                var q = dbc.Recipe_Table.Select(t => new
                {
                    t.RecipeID,
                    t.RecipeName
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
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            int[] tagids = sbt.TagsStringToTagIds(dbc, textBox2.Text, checkBox2.Checked);
            if (tagids.Count() != 0)
            {
                var q = dbc.Hashtag_Table.Where(t => tagids.Contains(t.HashtagID)).Select(t => new
                {
                    t.HashtagID,
                    t.Hasgtag
                }).ToList();
                bindingSource2.DataSource = q;
            }
            else
            {
                var q = dbc.Hashtag_Table.Select(t => new
                {
                    t.HashtagID,
                    t.Hasgtag
                }).ToList();
                bindingSource2.DataSource = q;
            }
            dataGridView2.DataSource = bindingSource2;
            if (dataGridView2.CurrentRow != null)
            {
                bindingSource2.Position = 0;
                bindingSource2_PositionChanged(null, null);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = null;
            int[] tagids = sbt.IngdStringToIngdIds(dbc, textBox3.Text, checkBox3.Checked);
            if (tagids.Count() != 0)
            {
                var q = dbc.Ingredient_Table.Where(t => tagids.Contains(t.IngredientID)).Select(t => new
                {
                    t.IngredientID,
                    t.Ingredient
                }).ToList();
                bindingSource3.DataSource = q;
            }
            else
            {
                var q = dbc.Ingredient_Table.Select(t => new
                {
                    t.IngredientID,
                    t.Ingredient
                }).ToList();
                bindingSource3.DataSource = q;
            }
            dataGridView3.DataSource = bindingSource3;
            if (dataGridView3.CurrentRow != null)
            {
                bindingSource3.Position = 0;
                bindingSource3_PositionChanged(null, null);
            }
        }
        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            //if (dataGridView1.CurrentRow != null)
            //{
            //    dataGridView1.Rows[bindingSource1.Position].Selected = true;
            //    int id = (int)dataGridView1.Rows.SharedRow(bindingSource1.Position).Cells[0].Value;
            //    string name = dataGridView1.Rows.SharedRow(bindingSource1.Position).Cells[1].Value.ToString();
            //    textBox4.Text = id.ToString();
            //    textBox5.Text = name;
            //    var rt = dbc.Hashtag_Record_Table.Where(rr => rr.RecipeID == id).Select(r=>new
            //    {
            //        r.RecipeID,
            //        r.HashTagID,
            //        r.HashTagFolderID,
            //    }).ToList();
            //    bindingSource4.DataSource = rt;
            //    var ri = dbc.Ingredient_Record_Table.Where(rr => rr.RecipeID == id).Select(r=>new
            //    {
            //        r.RecipeID,
            //        r.IngredientID,
            //        RecordID = r.IngredientRecordID,
            //        Unit = r.Unt,
            //        Amt = r.IngredientAmountForUse,
            //    }).ToList();
            //    bindingSource5.DataSource = ri;
            //    //if (dataGridView5.CurrentRow != null)
            //    //{
            //    //    dataGridView5.Rows[bindingSource5.Position].Selected = true;
            //    //    int riid = (int)dataGridView5.Rows.SharedRow(bindingSource5.Position).Cells[2].Value;
            //    //    textBox11.Text = riid.ToString();
            //    //    string unit = dataGridView5.Rows.SharedRow(bindingSource5.Position).Cells[3].Value.ToString();
            //    //    textBox12.Text = unit;
            //    //    Double mt = (Double)dataGridView5.Rows.SharedRow(bindingSource5.Position).Cells[4].Value;
            //    //    textBox13.Text = mt.ToString();
            //    //}
            //}
        }
        private void bindingSource2_PositionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                dataGridView2.Rows[bindingSource2.Position].Selected = true;
                int id = (int)dataGridView2.Rows.SharedRow(bindingSource2.Position).Cells[0].Value;
                string name = dataGridView2.Rows.SharedRow(bindingSource2.Position).Cells[1].Value.ToString();
                textBox6.Text = id.ToString();
                textBox7.Text = name;
            }
        }
        private void bindingSource3_PositionChanged(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow != null)
            {
                dataGridView3.Rows[bindingSource3.Position].Selected = true;
                int id = (int)dataGridView3.Rows.SharedRow(bindingSource3.Position).Cells[0].Value;
                string name = dataGridView3.Rows.SharedRow(bindingSource3.Position).Cells[1].Value.ToString();
                textBox8.Text = id.ToString();
                textBox9.Text = name;
            }
        }
        private void bindingSource4_PositionChanged(object sender, EventArgs e)
        {
            //dataGridView4.DataSource = bindingSource4;
            //if (dataGridView4.Rows.Count != 0)
            //{
            //    dataGridView4.Rows[bindingSource4.Position].Selected = true;
            //    int id = (int)dataGridView4.Rows.SharedRow(bindingSource4.Position).Cells[2].Value;
            //    textBox10.Text = id.ToString();
            //}
        }
        private void bindingSource5_PositionChanged(object sender, EventArgs e)
        {
            //dataGridView5.DataSource = bindingSource5.DataSource;
            
            //if (dataGridView5.Rows.Count != 0)
            //{
            //    dataGridView5.Rows[bindingSource5.Position].Selected = true;
            //    int id = (int)dataGridView5.Rows.SharedRow(bindingSource5.Position).Cells[2].Value;
            //    textBox11.Text = id.ToString();
            //    string unit = dataGridView5.Rows.SharedRow(bindingSource5.Position).Cells[3].Value.ToString();
            //    textBox12.Text = unit;
            //    var mt = dataGridView5.Rows.SharedRow(bindingSource5.Position).Cells[4].Value;
            //    textBox13.Text = mt.ToString();
            //}
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int frid = Int32.Parse(textBox4.Text);
            int fiid = Int32.Parse(textBox8.Text);
            if (dbc.Ingredient_Record_Table.Count(r => ((r.RecipeID == frid) && (r.IngredientID == fiid))) != 0)
            {
                MessageBox.Show("已經有相同的食譜-食材關聯了");
            }
            else
            {
                DialogResult result = MessageBox.Show("確認新增" + Environment.NewLine + "食譜:" + textBox5.Text + Environment.NewLine + "食材:" + textBox9.Text + Environment.NewLine + "單位:" + textBox12.Text + Environment.NewLine + "用量:" + textBox13.Text + Environment.NewLine + "的關聯性嗎?", "通知", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    var ingdr = new Ingredient_Record_Table()
                    {
                        RecipeID = Int32.Parse(textBox4.Text),
                        IngredientID = Int32.Parse(textBox8.Text),
                        Unt = textBox12.Text,
                        IngredientAmountForUse = Int32.Parse(textBox13.Text),
                    };
                    dbc.Ingredient_Record_Table.Add(ingdr);
                    dbc.SaveChanges();
                    MessageBox.Show("新增成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    int rid = Int32.Parse(textBox4.Text);
                    var ri = dbc.Ingredient_Record_Table.Where(i => i.RecipeID == rid).Select(r => new
                    {
                        r.RecipeID,
                        r.IngredientID,
                        RecordID = r.IngredientRecordID,
                        Unit = r.Unt,
                        Amt = r.IngredientAmountForUse,
                    }).ToList();
                    bindingSource5.DataSource = ri;
                }
                else
                {
                    return;
                }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox11.Text !="")
            {
                int frid = Int32.Parse(textBox4.Text);
                int fiid = Int32.Parse(textBox8.Text);
                if (false)
                {
                    MessageBox.Show("已經有相同的食譜-食材關聯了");
                }
                else
                {
                    DialogResult result = MessageBox.Show("確認修改" + Environment.NewLine + "食譜:" + textBox5.Text + Environment.NewLine + "食材:" + textBox9.Text + Environment.NewLine + "單位:" + textBox12.Text + Environment.NewLine + "用量:" + textBox13.Text + Environment.NewLine + "的關聯性嗎?", "通知", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        int id = Int32.Parse(textBox11.Text);
                        var ingdr = dbc.Ingredient_Record_Table.Where(r => r.IngredientRecordID == id).ToList();
                        foreach (var t in ingdr)
                        {
                            t.RecipeID = Int32.Parse(textBox4.Text);
                            t.IngredientID = Int32.Parse(textBox8.Text);
                            t.Unt = textBox12.Text;
                            t.IngredientAmountForUse = Int32.Parse(textBox13.Text);
                        }
                        dbc.SaveChanges();
                        MessageBox.Show("修改成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        int rid = Int32.Parse(textBox4.Text);
                        var ri = dbc.Ingredient_Record_Table.Where(i => i.RecipeID == rid).Select(r => new
                        {
                            r.RecipeID,
                            r.IngredientID,
                            RecordID = r.IngredientRecordID,
                            Unit = r.Unt,
                            Amt = r.IngredientAmountForUse,
                        }).ToList();
                        bindingSource5.DataSource = ri;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("請選擇關聯編號");
                return;
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox11.Text != "")
            {
                DialogResult result = MessageBox.Show("確認刪除" + Environment.NewLine + "編號:" + textBox11.Text + Environment.NewLine + "食譜-食材的關聯性嗎?", "通知", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int id = Int32.Parse(textBox11.Text);
                    dbc.Ingredient_Record_Table.RemoveRange(dbc.Ingredient_Record_Table.Where(t => t.IngredientRecordID == id));
                    dbc.SaveChanges();
                    MessageBox.Show("刪除成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    int rid = Int32.Parse(textBox4.Text);
                    var ri = dbc.Ingredient_Record_Table.Where(i => i.RecipeID == rid).Select(r => new
                    {
                        r.RecipeID,
                        r.IngredientID,
                        RecordID = r.IngredientRecordID,
                        Unit = r.Unt,
                        Amt = r.IngredientAmountForUse,
                    }).ToList();
                    bindingSource5.DataSource = ri;
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("請選擇關聯編號");
                return;
            }

        }
        private void button10_Click(object sender, EventArgs e)
        {
            HashTagEditForm hef = new HashTagEditForm();
            hef.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            IngdEditForm ief = new IngdEditForm();
            ief.Show();
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows[bindingSource1.Position].Selected = true;
                int id = (int)dataGridView1.Rows.SharedRow(bindingSource1.Position).Cells[0].Value;
                string name = dataGridView1.Rows.SharedRow(bindingSource1.Position).Cells[1].Value.ToString();
                textBox4.Text = id.ToString();
                textBox5.Text = name;
                var rt = dbc.Hashtag_Record_Table.Where(rr => rr.RecipeID == id).Select(r => new
                {
                    r.RecipeID,
                    r.HashTagID,
                    r.HashTagFolderID,
                }).ToList();
                bindingSource4.DataSource = rt;
                var ri = dbc.Ingredient_Record_Table.Where(rr => rr.RecipeID == id).Select(r => new
                {
                    r.RecipeID,
                    r.IngredientID,
                    RecordID = r.IngredientRecordID,
                    Unit = r.Unt,
                    Amt = r.IngredientAmountForUse,
                }).ToList();
                bindingSource5.DataSource = ri;
            }
        }

        private void dataGridView4_Click(object sender, EventArgs e)
        {
            if (dataGridView4.Rows.Count != 0)
            {
                dataGridView4.Rows[bindingSource4.Position].Selected = true;
                int id = (int)dataGridView4.Rows.SharedRow(bindingSource4.Position).Cells[2].Value;
                textBox10.Text = id.ToString();
            }
        }
        private void dataGridView5_Click(object sender, EventArgs e)
        {
            if (dataGridView5.Rows.Count != 0)
            {
                dataGridView5.Rows[bindingSource5.Position].Selected = true;
                int id = (int)dataGridView5.Rows.SharedRow(bindingSource5.Position).Cells[2].Value;
                textBox11.Text = id.ToString();
                string unit = dataGridView5.Rows.SharedRow(bindingSource5.Position).Cells[3].Value.ToString();
                textBox12.Text = unit;
                var mt = dataGridView5.Rows.SharedRow(bindingSource5.Position).Cells[4].Value;
                textBox13.Text = mt.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int frid = Int32.Parse(textBox4.Text);
            int ftid = Int32.Parse(textBox6.Text);
            if (dbc.Hashtag_Record_Table.Count(r => ((r.RecipeID == frid) && (r.HashTagID == ftid))) != 0)
            {
                MessageBox.Show("已經有相同的食譜-標籤關聯了");
            }
            else
            {
                DialogResult result = MessageBox.Show("確認新增" + Environment.NewLine + "食譜:" + textBox5.Text + Environment.NewLine + "標籤:" + textBox7.Text + Environment.NewLine + "的關聯性嗎?", "通知", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    var tagr = new Hashtag_Record_Table()
                    {
                        RecipeID = Int32.Parse(textBox4.Text),
                        HashTagID = Int32.Parse(textBox6.Text),
                    };
                    dbc.Hashtag_Record_Table.Add(tagr);
                    dbc.SaveChanges();
                    MessageBox.Show("新增成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    int rid = Int32.Parse(textBox4.Text);
                    var rt = dbc.Hashtag_Record_Table.Where(rr => rr.RecipeID == rid).Select(r => new
                    {
                        r.RecipeID,
                        r.HashTagID,
                        r.HashTagFolderID,
                    }).ToList();
                    bindingSource4.DataSource = rt;
                }
                else
                {
                    return;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int frid = Int32.Parse(textBox4.Text);
            int ftid = Int32.Parse(textBox6.Text);
            if(textBox10.Text != "")
            {
                if (dbc.Hashtag_Record_Table.Count(r => ((r.RecipeID == frid) && (r.HashTagID == ftid))) != 0)
                {
                    MessageBox.Show("已經有相同的食譜-標籤關聯了");
                }
                else
                {
                    DialogResult result = MessageBox.Show("確認修改" + Environment.NewLine + "食譜:" + textBox5.Text + Environment.NewLine + "標籤:" + textBox7.Text + Environment.NewLine + "的關聯性嗎?", "通知", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        int id = Int32.Parse(textBox10.Text);
                        var tagr = dbc.Hashtag_Record_Table.Where(r => r.HashTagFolderID == id).ToList();
                        foreach (var t in tagr)
                        {
                            t.RecipeID = Int32.Parse(textBox4.Text);
                            t.HashTagID = Int32.Parse(textBox6.Text);
                        }
                        dbc.SaveChanges();
                        MessageBox.Show("修改成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        int rid = Int32.Parse(textBox4.Text);
                        var rt = dbc.Hashtag_Record_Table.Where(rr => rr.RecipeID == rid).Select(r => new
                        {
                            r.RecipeID,
                            r.HashTagID,
                            r.HashTagFolderID,
                        }).ToList();
                        bindingSource4.DataSource = rt;
                    }
                    else
                    {
                        return;
                    }
                }
              
            }
            else
            {
                MessageBox.Show("請選擇關聯編號");
                return;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                DialogResult result = MessageBox.Show("確認刪除" + Environment.NewLine + "編號:" + textBox10.Text + Environment.NewLine + "食譜-標籤的關聯性嗎?", "通知", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int id = Int32.Parse(textBox10.Text);
                    dbc.Hashtag_Record_Table.RemoveRange(dbc.Hashtag_Record_Table.Where(t => t.HashTagFolderID == id));
                    dbc.SaveChanges();
                    MessageBox.Show("刪除成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    int rid = Int32.Parse(textBox4.Text);
                    var rt = dbc.Hashtag_Record_Table.Where(rr => rr.RecipeID == rid).Select(r => new
                    {
                        r.RecipeID,
                        r.HashTagID,
                        r.HashTagFolderID,
                    }).ToList();
                    bindingSource4.DataSource = rt;
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("請選擇關聯編號");
                return;
            }
        }
    }
}
