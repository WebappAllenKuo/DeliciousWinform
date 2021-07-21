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

namespace project.From_伯均
{
    public partial class GoodsToR : Form
    {
        DeliciousEntities dbContext = new DeliciousEntities();
        public GoodsToR(int[]R)
        {
            InitializeComponent();
            Re = R;
            var GTRresult = dbContext.Recipe_Table.Where(RER => Re.Contains(RER.RecipeID)).Select(RER2 =>
                new {
                    編號 = RER2.RecipeID,
                    食譜名稱 = RER2.RecipeName,
                    食譜類型 = dbContext.RecipeCategory_Table.Where(RC => RC.RecipeCategoryID == RER2.RecipeCategoryID).Select(RC => RC.RecipeCategory),
                    食譜描述 = RER2.RecipeDescription,
                    圖片 = RER2.Picture
                }).ToList();

            dgv_GoodsToR.DataSource = GTRresult;
        }

       int[] Re;

        private void btn_ToR_Click(object sender, EventArgs e)
        {
            if(dgv_GoodsToR.Rows.Count == 0)
            {
                return;
            }
            try
            {
                int RIndex = (int)dgv_GoodsToR.CurrentRow.Cells[0].Value;
                RecipePage NewR = new RecipePage(RIndex);
                NewR.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("請選擇您要的食譜。", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
