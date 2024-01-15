using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.DAL.Entities;

public class Friendship
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int FriendId { get; set; }
}