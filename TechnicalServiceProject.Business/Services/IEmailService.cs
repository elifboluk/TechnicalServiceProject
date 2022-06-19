

using TechnicalServiceProject.Core.Emails;

namespace TecnicalServiceProject.Business.Services
{
    public interface IEmailService
    {
        Task SendMailAsync(MailModel model);
    }
}
