using Delicious_Kashir;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using project;
using project.Form_明萱;
using project.Form_Kuan;
using project.Form_Chia;
using project.Form_育政;
using project.Form_瑋;
using MarketPages;
using project.Form_秉鈞;
using project.From_伯均;

namespace project
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            
        Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new HomePage());
            //Application.Run(new FCustomerMsg());
            //Application.Run(new MemberRankForm());
            Application.Run(new FormMainLogin()) ;
            //Application.Run(new OrdersForMembers());
            //Application.Run(new Market());
            //Application.Run(new OrderSearch());
            //Application.Run(new HashTagEditForm());
            //Application.Run(new AddRecipePage());
            //Application.Run(new RecipePage());
            //Application.Run(new adlogin());
            //Application.Run(new UpdataRecipePage(50));
            

        }
    }
}
