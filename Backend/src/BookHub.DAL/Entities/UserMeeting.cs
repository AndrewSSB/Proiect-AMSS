using BookHub.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.Infrastructure.Entities
{
    public class UserMeeting
    {
        public int? UserId { get; set; }
        public int? MeetingId { get; set; }
        public User? User { get; set; }
        public Meeting? Meeting { get; set; }
    }
}
