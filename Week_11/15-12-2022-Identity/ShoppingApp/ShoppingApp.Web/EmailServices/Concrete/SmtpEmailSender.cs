using System.Net;
using System.Net.Mail;
using ShoppingApp.Web.EmailServices.Abstract;

namespace ShoppingApp.Web.EmailServices.Concrete
{
    public class SmtpEmailSender:IEmailSender
    {
        private string _host;
        private string _port;
        private bool _enableSSL;
        private string _userName;
        private string _password;

        public SmtpEmailSender(string host, string port, bool enableSSL, string userName, string password)
        {
            _host = host;
            _port = port;
            _enableSSL = enableSSL;
            _userName = userName;
            _password = password;
        }

        public Task SendEmailAsync(string email,string subject,string htmlMessage) {
            var client = new SmtpClient(_host, _port)
            {
                Credentials=new NetworkCredential (_userName, _password),
                EnableSSL = _enableSSL
            };
            return client.SendMailAsync(
                new MailMessage(_userName, email, subject, htmlMessage)
                {
                    IsBodyHtml= true
                });
        }
    }
}
