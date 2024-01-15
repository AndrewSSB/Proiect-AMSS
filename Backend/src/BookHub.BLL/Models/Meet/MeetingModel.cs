using BookHub.DAL.Entities;
using BookHub.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.Services.Models.MeetModels
{
    public class MeetingModel
    {
        public int MeetingId { get; set; }
        public int AgendaId { get; set; }
    }
}
