using DiariesFood.Web.MailServices.Abstract;

namespace DiariesFood.Web.MailServices.Concrete
{
    public class Pop3EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            throw new NotImplementedException();
        }
    }
}