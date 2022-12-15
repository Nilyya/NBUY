namespace ShoppingApp.Web.EmailServices.Concrete
{
    public interface EmailSender
    {
        Task SendEmailAsync(string email, string subject, string htmlMessage);
    }
}
