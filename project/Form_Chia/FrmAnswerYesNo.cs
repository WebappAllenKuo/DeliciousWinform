using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.Form_Chia
{
    public partial class FrmAnswerYesNo : Form
    {
        int IngIDfordelete;
        public FrmAnswerYesNo(int IngId)
        {
            DeliciousEntities dbcontext = new DeliciousEntities();
            InitializeComponent();
            IngIDfordelete = IngId;
            var q = dbcontext.Ingredient_Table.Single(n => n.IngredientID == IngId).Ingredient.ToString();

            this.lb_IngName.Text ="食材名稱 "+q ;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DeliciousEntities dbcontext = new DeliciousEntities();

            var q0 = dbcontext.Ingredient_Table.Single(n => n.IngredientID == IngIDfordelete);
            var q1 = dbcontext.Merchandise_Picture_Table.Where(n => n.IngredientID == IngIDfordelete).Select(n => n);
            foreach (var Q in q1)
            { dbcontext.Merchandise_Picture_Table.Remove(Q); }
            dbcontext.Ingredient_Table.Remove(q0);
            dbcontext.SaveChanges();
            this.Close();

        }
    
        private void btn_canceldel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
    }
}
