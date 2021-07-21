using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace project.Model
{
    class SendEmail
    {
        public string email { get; set; }
        public string conform { get; set; } 
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Result { get; set; }
        public SendEmail(string email,string conform,string Subject,string Body,string Result)
        {
            this.email = email;//收件人EMAIL
            this.conform = conform;//驗證碼
            this.Subject = Subject;//主旨
            this.Body = Body;//內文
            this.Result = Result;//回傳訊息
        }
        public SendEmail()
        {

        }
        public string send()
        {
            try
            {
                MailMessage mm = new MailMessage("jyun1091201@gmail.com", email);
                mm.Subject = Subject;
                mm.Body = Body + conform;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                NetworkCredential networkCredential = new NetworkCredential("jyun1091201@gmail.com", "j3465197");
                smtp.Credentials = networkCredential;
                smtp.EnableSsl = true;
                smtp.Send(mm);
                return Result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
