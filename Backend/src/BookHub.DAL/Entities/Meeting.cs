using BookHub.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.Infrastructure.Entities
{
    public class Meeting
    {
        public int MeetingId { get; set; }
        public virtual ICollection<UserMeeting> UserMeetings { get; set; }
        public int? AgendaId { get; set; }
        public Agenda? Agenda { get; set; }
        public int? TradeId { get; set; }
        public Trade? Trade { get; set; }
    }
}
