using Microsoft.AspNetCore.Identity;
using BookHub.Infrastructure.Entities;
using System.Collections.Generic;

namespace BookHub.DAL.Entities;

public class User : IdentityUser<int>
{
    public string RefreshToken { get; set; }
    public virtual ICollection<UserRole> UserRoles { get; set; }
    public virtual ICollection<UserMeeting> UserMeetings { get; set; }
    public virtual ICollection<UserTrade> UserByTrades { get; set; }
    public virtual ICollection<UserTrade> UserForTrades { get; set; }
    public virtual ICollection<Post> Posts { get; set; }
    public virtual ICollection<Friendship> Friendships { get; set; }
}
