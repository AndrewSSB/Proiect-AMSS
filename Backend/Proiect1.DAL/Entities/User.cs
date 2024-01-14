using Microsoft.AspNetCore.Identity;
using Proiect1.Infrastructure.Entities;
using System.Collections.Generic;

namespace Proiect1.DAL.Entities;

public class User : IdentityUser<int>
{
    public string RefreshToken { get; set; }
    public virtual ICollection<UserRole> UserRoles { get; set; }
    public virtual ICollection<UserMeeting> UserMeetings { get; set; }
    public virtual ICollection<UserTrade> UserTrades { get; set; }
}
