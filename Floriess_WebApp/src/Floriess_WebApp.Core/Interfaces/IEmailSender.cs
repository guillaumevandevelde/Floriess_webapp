using System.Threading.Tasks;

namespace Floriess_WebApp.Core.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string to, string from, string subject, string body);
    }
}