namespace CarsAPI.Services
{
    public class FakeEmailSender : IEmailSender
    {
        public bool SendEmail(string email, string subject, string body) 
        {
            return true;
        }
    }
}
