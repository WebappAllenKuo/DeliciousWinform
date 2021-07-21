using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.Form_明萱
{
    public class Caddcolnfolder
    {       
        public bool addCaddcolnfolder(string foldername,int memberID)
        {
            DeliciousEntities dbcontext = new DeliciousEntities();

            //判斷新增的收藏夾名稱是否重複
            var countsame = dbcontext.CollectionFolder_Table.Where(m => m.MemberID == memberID && m.CollectionFolder == foldername).Select(m => m.CollectionFolder).Count();
            if(countsame>0)
            {//如果收藏夾名稱重複 回傳false
                MessageBox.Show("已有相同名稱收藏夾");
                return false;
            }
            else if(foldername==""||foldername.Contains(" "))
            {//收藏夾名稱若為空白 回傳false
                MessageBox.Show("新增收藏夾的名稱不可含空白");
                return false;
            }
            else
            {//如果收藏夾名稱沒有重複 並回傳true
                CollectionFolder_Table _collectionFolder = new CollectionFolder_Table()
                {
                    CollectionFolder = foldername,
                    MemberID = memberID
                };

                dbcontext.CollectionFolder_Table.Add(_collectionFolder);
                dbcontext.SaveChanges();
                return true;
            }                       
        }
    }
}
