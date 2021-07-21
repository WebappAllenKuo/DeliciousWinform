using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Form_Kuan
{
    class CAccusation
    {
         
        public IQueryable<Accusation_Table> get_Accusation_Table_Froze(DeliciousEntities Get_DE, int get_mode)
        {
            var q = from n in Get_DE.Accusation_Table
                    where n.AccusedAvatar == get_mode.ToString() && n.ProgressID == 0
                    select n;
            return q;

        }
        public IQueryable<Accusation_Table> get_Accusation_Table_All(DeliciousEntities Get_DE,  int get_mode)
        {
            var q = from n in Get_DE.Accusation_Table
                    where n.AccusedAvatar == get_mode.ToString()
                    select n;
            return q;

        }

        //public IQueryable<Recipe_Table> Reflash_gv2(DeliciousEntities Get_DE, int get_select)
        //{
        //    //Recipe_Table result = (from n in Get_DE.Recipe_Table
        //    //              where n.RecipeID == get_select
        //    //              select new Recipe_Table { RecipeID= n.RecipeID, RecipeName= n.RecipeName, DisVisible = n.DisVisible });
        //    //result.ToList();
        //    //return result;
        //    var q = Get_DE.Recipe_Table.Where(n => n.RecipeID == get_select).Select(a => new Recipe_Table()
        //    {
        //        RecipeID = a.RecipeID,
        //        RecipeName = a.RecipeName,
        //        DisVisible = a.DisVisible,
        //    });
        //    return q;
        //}

        //public void Update_DisVisible(ref DeliciousEntities Get_DE,int get_mode, int get_select, bool get )
        //{
        //    Recipe_Table q = (from n in Get_DE.Recipe_Table
        //                      where n.RecipeID == get_select
        //                      select n).FirstOrDefault();
        //    q.DisVisible = false;
        //    Get_DE.SaveChanges();
        //}
        //public void Update_progess(ref DeliciousEntities Get_DE, int get_mode, int get_select_Accusation)
        //{
        //    var q2 = (from n in Get_DE.Accusation_Table
        //              where n.AccusationRightID == get_select_Accusation
        //              select n).FirstOrDefault();
        //    q2.ProgressID = 1;
        //    Get_DE.SaveChanges();
        //}
    }
}
