using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHub.Infrastructure.Entities;

namespace BookHub.Services.Interfaces.Meet.Repo
{
    public interface IMeetingRepository
    {
        public Meeting CreateMeeting(int tradeId);
    }
}
