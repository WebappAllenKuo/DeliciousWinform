using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using project.Model_秉鈞;

namespace project
{
    public static class Viewbag
    {
        public static CMember member { get; set; }
        public static CAdmin Admin { get; set; }
    }

    
}
