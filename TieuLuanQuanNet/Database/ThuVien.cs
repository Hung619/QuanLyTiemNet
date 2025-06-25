using EASendMail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TieuLuanQuanNet.Database
{
    class ThuVien
    {
        public static NhanVien LoggedUser = null;
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
        public static bool SendEmail(string mailto, string content)
        {
            try
            {
                SmtpMail oMail = new SmtpMail("TryIt");

                // Your gmail email address
                oMail.From = "n.d.h.hung2004@gmail.com";
                // Set recipient email address
                oMail.To = mailto;//"nguyenhoangphongcntt@gmail.com";

                // Set email subject
                oMail.Subject = "Mật khẩu NETMAN";
                // Set email body
                oMail.TextBody = content;

                // Gmail SMTP server address
                SmtpServer oServer = new SmtpServer("smtp.gmail.com");

                // Gmail user authentication
                // For example: your email is "gmailid@gmail.com", then the user should be the same
                oServer.User = "n.d.h.hung2004@gmail.com";

                //app password
                oServer.Password = "xjenkwfrqgjgfnpl";

                // Set 465 port
                oServer.Port = 465;

                // detect SSL/TLS automatically
                oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;

                Console.WriteLine("start to send email over SSL ...");

                SmtpClient oSmtp = new SmtpClient();
                oSmtp.SendMail(oServer, oMail);

                Console.WriteLine("email was sent successfully!");
                return true;
            }
            catch (Exception ep)
            {
                Console.WriteLine("Lỗi gửi email:");
                Console.WriteLine(ep.Message);
                return false;
            }
        }
    }
}
