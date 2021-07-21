using project.Model_秉鈞;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace project
{
    class Judgment
    {
        DeliciousEntities dbcontext = new DeliciousEntities();
        public bool AllJdg(RMember c, out string MemberNameMessage, out string AccountMessage, out string PasswordMessage, out string EmailMessage, out string CellNumberMessage)//全部判斷
        {
            MemberNameMessage = NameJdg(c.MemberName);
            AccountMessage = AccountJdg(c.AccountName.ToLower());
            PasswordMessage = PasswordJdg(c.Password1.ToLower(), c.Password2.ToLower());
            EmailMessage = EmailJdg(c.Email);
            CellNumberMessage = CellNumberJdg(c.CellNumber);
            if (MemberNameMessage == null & AccountMessage == null && PasswordMessage == null && EmailMessage == null && CellNumberMessage == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AllJdg_admin(CAdmin c, out string AdminNameMessage, out string AccountMessage, out string PasswordMessage)//全部判斷
        {
            AdminNameMessage = NameJdg(c.AdminName);
            AccountMessage = AdminAccountJdg(c.AccountName.ToLower());
            PasswordMessage = PasswordJdg(c.Password1.ToLower(), c.Password2.ToLower());
            if (AdminNameMessage == null & AccountMessage == null && PasswordMessage == null )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string AccountJdg(string accountName)
        {
            var q = (from m in dbcontext.Member_Table
                    where m.AccountName == accountName
                     select m).ToList();
            if (q.Count != 0)
            {
                return "此帳號已被註冊";
            }
            else 
            {
                var hasNumber = new Regex(@"[0-9]+");
                var hasMiniMaxChars = new Regex(@".{5,15}");
                var hasLowerChar = new Regex(@"[a-z]+");
                var hasSymbolChar = new Regex(@"[!@#$%^&*().,=';_\x2f\x2d\x5b\x5d\x22\x20\x5c]+");
                if (string.IsNullOrWhiteSpace(accountName))
                {
                    return "請輸入帳號";
                }
                else if (!hasLowerChar.IsMatch(accountName))
                {
                    return "帳號至少應包含一個小寫字母。";
                }
                else if (!hasMiniMaxChars.IsMatch(accountName))
                {
                    return "帳號不得少於5個或大於15個字符。";
                }
                else if (!hasNumber.IsMatch(accountName))
                {
                    return "帳號應至少包含一個數字值。";
                }
                else if (hasSymbolChar.IsMatch(accountName))
                {
                    return "不可輸入特殊字元";
                }
                else
                {
                    return null;
                }
            }
        }
        public string AdminAccountJdg(string accountName)
        {
            var q = (from m in dbcontext.Admin_Table
                     where m.AccountName == accountName
                     select m).ToList();
            if (q.Count != 0)
            {
                return "此帳號已被註冊";
            }
            else
            {
                var hasNumber = new Regex(@"[0-9]+");
                var hasMiniMaxChars = new Regex(@".{5,15}");
                var hasLowerChar = new Regex(@"[a-z]+");
                var hasSymbolChar = new Regex(@"[!@#$%^&*().,=';_\x2f\x2d\x5b\x5d\x22\x20\x5c]+");
                if (string.IsNullOrWhiteSpace(accountName))
                {
                    return "請輸入帳號";
                }
                else if (!hasLowerChar.IsMatch(accountName))
                {
                    return "帳號至少應包含一個小寫字母。";
                }
                else if (!hasMiniMaxChars.IsMatch(accountName))
                {
                    return "帳號不得少於5個或大於15個字符。";
                }
                else if (!hasNumber.IsMatch(accountName))
                {
                    return "帳號應至少包含一個數字值。";
                }
                else if (hasSymbolChar.IsMatch(accountName))
                {
                    return "不可輸入特殊字元";
                }
                else
                {
                    return null;
                }
            }
        }
        public string PasswordJdg(string password1, string password2)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasMiniMaxChars = new Regex(@".{5,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbolChar = new Regex(@"[!@#$%^&*().,=';_\x2f\x2d\x5b\x5d\x22\x20\x5c]+");
            if (string.IsNullOrWhiteSpace(password1) || password1 != password2)
            {
                return "兩次輸入密碼不同";
            }
            else if (!hasLowerChar.IsMatch(password1))
            {
                return "密碼至少應包含一個英文字母。";
            }
            else if (!hasMiniMaxChars.IsMatch(password1))
            {
                return "密碼不得少於5個或大於15個字符。";
            }
            else if (!hasNumber.IsMatch(password1))
            {
                return "密碼應至少包含一個數字值。";
            }
            else if (hasSymbolChar.IsMatch(password1))
            {
                return "不可輸入特殊字元";
            }
            else
            {
                return null;
            }
        }
        public string EmailJdg(string email)
        {
            var q = (from m in dbcontext.Member_Table
                     where m.Email == email
                     select m).ToList();
            if (q.Count != 0)
            {
                return "此信箱已被使用";
            }
            var emailjdg = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            if (string.IsNullOrWhiteSpace(email))
            {
                return "請輸入電子信箱";
            }
            else if (!emailjdg.IsMatch(email))
            {
                return "請輸入正確的電子信箱";
            }
            else
            {
                return null;
            }
        }
        public string CellNumberJdg(string CellNumber)
        {
            var q = (from m in dbcontext.Member_Table
                     where m.CellNumber == CellNumber
                     select m).ToList();
            if (q.Count != 0)
            {
                return "此手機已被使用";
            }
            else 
            {
                var PhonenumberJdg = new Regex(@"^09[0-9]{8}$");

                if (!PhonenumberJdg.IsMatch(CellNumber))
                {
                    return "請輸入正確手機號碼";
                }
                else
                {
                    return null;
                }
            }
        }
        public string NameJdg(string name)
        {
            var MemberNameJdg = new Regex(@"[\u4E00-\u9FFF]{2,4}");
            var hasSymbolChar = new Regex(@"[!@#$%^&*().,=';_\x2f\x2d\x5b\x5d\x22\x20\x5c]+");
            if (!MemberNameJdg.IsMatch(name))
            {
                return "請輸入正確姓名";
            }
            else if (hasSymbolChar.IsMatch(name))
            {
                return "不可輸入特殊字元";
            }
            else
            {
                return null;
            }
        }
        public string Nickname(string name)
        {
            var hasSymbolChar = new Regex(@"[!@#$%^&*().,=';_\x2f\x2d\x5b\x5d\x22\x20\x5c]+");
            if (hasSymbolChar.IsMatch(name))
            {
                return "不可輸入特殊字元";
            }
            else
            {
                return null;
            }
        }
    }
}
