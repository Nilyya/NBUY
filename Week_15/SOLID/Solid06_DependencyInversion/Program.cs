using Solid06_DependencyInversion.After;
using Solid06_DependencyInversion.Before;

namespace Solid06_DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MailService mailService = new MailService();
            // mailService.SendMail(new GMailServer);
            #region After
            MailService mailService = new MailService();
            mailService.SendMail(new GmailServer(), "engin@gmail.com","Selam");
            mailService.SendMail(new HotmailServer(), "enginniyazi@hotmail.com", "Selaaaaam");
            #endregion
        }
    }
}