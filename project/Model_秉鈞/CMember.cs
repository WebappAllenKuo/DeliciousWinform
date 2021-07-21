using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class CMember
    {
        
        public int MemberID { get { return _MemberID; }  }
        int _MemberID;
        public string AccountName { get { return _AccountName; } }
        string _AccountName;
        public string Nickname { get { return _Nickname; } }
        string _Nickname;
        public string MemberName { get { return _MemberName; } }
        string _MemberName;
        public string CellNumber { get { return _CellNumber; } }
        string _CellNumber;
        public string Email { get { return _Email; } }
        string _Email;
        public DateTime Birthday { get { return _Birthday; } }
        DateTime _Birthday;
        public string Gender { get { return _Gender; } }
        string _Gender;
        public string info { get { return _info; } }
        string _info;
        public bool ConfirmedOrNot_email { get { return _ConfirmedOrNot_email; } }
        bool _ConfirmedOrNot_email;
        public bool ConfirmedOrNot_phone { get { return _ConfirmedOrNot_phone; } }
        bool _ConfirmedOrNot_phone;
        public string Password1 { get; set; }
        public string Password2 { get; set; }
        public DateTime RigisterTime { get { return _RigisterTime; } }
        DateTime _RigisterTime;
        public int PersonalRankScore { get { return _PersonalRankScore; } }
        int _PersonalRankScore;
        public int RankID { get { return _RankID; } }
        int _RankID;
        public int AuthorityID { get { return _AuthorityID; } }
        int _AuthorityID;
        public string Figure { get { return _Figure; } }
        string _Figure;
        public void getdata(Member_Table _Member_Table)
        {
            _MemberID = _Member_Table.MemberID;
            _AccountName = _Member_Table.AccountName;
            _Nickname = _Member_Table.Nickname;
            _MemberName = _Member_Table.MemberName;
            _CellNumber = _Member_Table.CellNumber;
            _Email = _Member_Table.Email;
            _Birthday = _Member_Table.Birthday;
            _Gender = _Member_Table.Gender;
            _info = _Member_Table.Info;
            _ConfirmedOrNot_email = _Member_Table.ConfirmedOrNot_email;
            _ConfirmedOrNot_phone = _Member_Table.ConfirmedOrNot_phone;
            _RigisterTime = _Member_Table.RegisterTime;
            _PersonalRankScore = _Member_Table.PersonalRankScore;
            _RankID = _Member_Table.RankID;
            _AuthorityID = _Member_Table.AuthorityID;
            _Figure = _Member_Table.Figure;

        }
    }
}
