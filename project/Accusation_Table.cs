//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace project
{
    using System;
    using System.Collections.Generic;
    
    public partial class Accusation_Table
    {
        public int AccusationRightID { get; set; }
        public int MemberID { get; set; }
        public int AccuseID { get; set; }
        public string AccusedAvatar { get; set; }
        public string AccusedID { get; set; }
        public int ProgressID { get; set; }
    
        public virtual AccuseContent_Table AccuseContent_Table { get; set; }
        public virtual Member_Table Member_Table { get; set; }
    }
}