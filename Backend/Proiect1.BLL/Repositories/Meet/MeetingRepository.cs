using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect1.DAL;
using Proiect1.Infrastructure.Entities;
using Proiect1.Services.Interfaces.Meet.Repo;

namespace Proiect1.Services.Repositories.Meet
{
    public class MeetingRepository : IMeetingRepository
    {
        private readonly AppDbContext db;

        public MeetingRepository(AppDbContext db)
        {
            this.db = db;
        }

        public Meeting CreateMeeting(int tradeId)
        {
            var meeting = new Meeting(){};
            meeting.TradeId = tradeId;
            db.Meetings.Add(meeting);
            db.SaveChanges();
            return meeting;
        }
    }
}
