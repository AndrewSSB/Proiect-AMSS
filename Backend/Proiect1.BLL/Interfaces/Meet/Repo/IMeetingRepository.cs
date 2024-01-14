using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect1.Infrastructure.Entities;

namespace Proiect1.Services.Interfaces.Meet.Repo
{
    public interface IMeetingRepository
    {
        public Meeting CreateMeeting(int tradeId);
    }
}
