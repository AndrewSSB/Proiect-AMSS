using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.BLL.DTOs;

public class FriendshipGetDTO
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string UserName { get; set; }
    public int FriendId { get; set; }
    public string FriendName { get; set; }
}
