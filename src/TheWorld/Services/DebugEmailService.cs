using System.Diagnostics;

namespace TheWorld.Services
{
    public class DebugEmailService : IMailService
    {
        public bool SendEmail(string to, string from, string subject, string body)
        {
            Debug.WriteLine($"Sending email: To: {to}, Subject: {subject}");
            return true;
        }
    }
}
