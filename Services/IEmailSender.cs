namespace CarsAPI.Services
{
    public interface IEmailSender
    {
        bool SendEmail(string email, string subject, string body);
    }
}
