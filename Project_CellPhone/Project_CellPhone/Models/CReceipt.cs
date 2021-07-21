﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_CellPhone.Models
{
     public class CReceipt
    {
        [PrimaryKey, AutoIncrement]
        public string Receipt_name { get; set; }
        public string Receipt_Descript { get; set; }
        public DateTime PostTime { get; set; }
    }
}
