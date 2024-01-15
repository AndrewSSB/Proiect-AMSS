using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHub.DAL;
using BookHub.Infrastructure.Entities;
using BookHub.Services.Interfaces.Meet.Repo;

namespace BookHub.Services.Repositories.Meet
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
