using BookHub.DAL.Entities;
using BookHub.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.Services.Models.MeetModels
{
    public class TradeModel
    {
        public int TradeId { get; set; }
        public int? UserById { get; set; }
        public int? UserForId { get; set; }
        public int? MeetingId { get; set; }
        public virtual ICollection<UserTrade> UserTrades { get; set; }

        public bool acceptedUser1 { get; set; }
        public bool acceptedUser2 { get; set; }
    }
}
