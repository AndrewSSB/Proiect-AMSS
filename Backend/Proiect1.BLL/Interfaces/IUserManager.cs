using Proiect1.BLL.DTOs;
using System.Threading.Tasks;

namespace Proiect1.BLL.Interfaces;

public interface IUserManager
{
    Task SendEmailTemplate(EmailReceiverDTO emailDto);
}
