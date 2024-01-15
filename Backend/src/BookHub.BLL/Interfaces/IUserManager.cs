using BookHub.BLL.DTOs;
using System.Threading.Tasks;

namespace BookHub.BLL.Interfaces;

public interface IUserManager
{
    Task SendEmailTemplate(EmailReceiverDTO emailDto);
}
