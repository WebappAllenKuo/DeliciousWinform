using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Form_Kuan
{

    class CFSelectAccuseID
    {
        DeliciousEntities DE = new DeliciousEntities();
        public bool setAccusation(int _AccuselID, string _AccusedAvatar, int _AccusedID )
        {
            Accusation_Table At = new Accusation_Table();
            At.MemberID = Viewbag.member.MemberID;
           // At.MemberID = 3;
            At.AccuseID = _AccuselID+1;
            At.AccusedAvatar = _AccusedAvatar;
            At.AccusedID = _AccusedID.ToString();
            DE.Accusation_Table.Add(At);
            DE.SaveChanges();
            if (_AccusedAvatar == "0")
            {
                 
                Recipe_Table q = (from n in DE.Recipe_Table
                                  where n.RecipeID == _AccusedID
                                  select n).FirstOrDefault();
                q.DisVisible = true;
            }
            else if(_AccusedAvatar=="1")
            {
                CommentSection_Table q = (from n in DE.CommentSection_Table
                                          where n.CommentID == _AccusedID
                                          select n).FirstOrDefault();
                q.DisVisible = true;
            }
            DE.SaveChanges();
            return true;
        }
    }
}
