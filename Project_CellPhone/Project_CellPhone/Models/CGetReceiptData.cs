using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Project_CellPhone.Models
{
    public class CGetReceiptData
    {
        SQLiteAsyncConnection _conn;
        private SQLiteAsyncConnection GetSQLiteconn()
        {
            if (_conn == null)
            {
                string m_folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string m_path = Path.Combine(m_folder, "db_demo.db");
                _conn = new SQLiteAsyncConnection(m_path);
                _conn.CreateTableAsync<CReceipt>();
            }
            return _conn;
        }
        public List<CReceipt> queryAll()
        {
            List<CReceipt> mList = new List<CReceipt>();

            mList.Add(new CReceipt {  Receipt_name= "超神咖哩雞肉", Receipt_Descript = "咖哩雞，是一種南亞地區的菜式，不過東亞都很流行。咖哩雞煮法簡單，其它用料成份不同可變化出各地風味，如印度咖哩雞、馬來和港式快餐咖哩雞馬鈴薯飯等。", PostTime = Convert.ToDateTime("2021-01-03 00:00:00.000") });
            mList.Add(new CReceipt { Receipt_name = "佛蒙特牛肉咖哩", Receipt_Descript = "晚餐就決定牛肉咖哩了！小時候只要跟媽媽說「我要吃咖哩」晚上餐桌就有一鍋濃郁的牛肉咖哩可以多吃好幾碗飯", PostTime = Convert.ToDateTime("2021-02-04 00:00:00.000") });
            mList.Add(new CReceipt { Receipt_name = "日式馬鈴薯燉肉", Receipt_Descript = "據說，在日本就算再怎麼不會煮菜，一定要學會「馬鈴薯燉肉」，因為它是日本最具人氣的家庭料理代表，專屬於「家」的香氣在餐桌上瀰漫開來，是記憶裡最溫柔的滋味。", PostTime = Convert.ToDateTime("2021-04-04 00:00:00.000") });
            mList.Add(new CReceipt { Receipt_name = "馬鈴薯蛋沙拉", Receipt_Descript = "炎炎夏日即將來臨，大熱天熱食吃不下。真想吃點冰冰涼的馬鈴薯蛋沙拉。親子DIY動手做馬鈴薯蛋沙拉~做法簡單又好吃。", PostTime = Convert.ToDateTime("2021-05-04 12:00:00.000") });
            mList.Add(new CReceipt { Receipt_name = "醋溜高麗菜", Receipt_Descript = "高麗菜在我們日常飲食裡面是一種比較常見的蔬菜，高麗菜又叫做捲心菜，營養價值十分的豐富", PostTime = Convert.ToDateTime("2021-06-04 00:00:00.000") });
            //foreach (var item in mList)
            //{
            //    GetSQLiteconn().InsertAsync(item);
            //}

            //mList = GetSQLiteconn().Table<CReceipt>().ToListAsync().Result;

            return mList;
        }

    }
}
