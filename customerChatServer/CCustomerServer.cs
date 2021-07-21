using customerChatServer.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customerChatServer
{
    class CCustomerServer
    {
        DeliciousEntities DE = new DeliciousEntities();
        public string mAI(string getstr)
        {
            string result_str = "";
            if (getstr.Contains("食譜")) 
            {
                if (getstr.Contains("總筆數"))
                {
                    result_str = "食譜的總筆數";
                    var q = from n in DE.Recipe_Table

                            select n;
                    result_str += q.Count() + "筆";
                }
                else if (getstr.Contains("清單"))
                {
                    int count = 1;
                    result_str = "食譜的清單";
                    var q = from n in DE.Recipe_Table

                            select n.RecipeName;
                    foreach (var item in q)
                    {
                        result_str += count + item.ToString();
                        count++;
                    }
                   
                }
                else
                {
                    result_str = "食譜可用關鍵字, 總筆數, 清單";
                }

            }
            else if(getstr.Contains("會員"))
            {

                if (getstr.Contains("總筆數"))
                {
                    result_str = "會員的總筆數";
                    var q = from n in DE.Member_Table

                            select n;
                    result_str += q.Count() + "筆";
                }
                else
                {
                    result_str = "會員可用關鍵字, 總筆數 ";
                }
            }
            return result_str;
        }
    }
}
