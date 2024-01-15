using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHub.Infrastructure.Entities;
using BookHub.Services.DTOs.Meet;
using BookHub.Services.Models.MeetModels;

namespace BookHub.Services.Interfaces.Meet.Manager
{
    public interface IAgendaManager
    {
        public AgendaDTO CreateAgenda(AgendaDTO agenda);
        public AgendaDTO CreateAgendaForMeeting(int meetingId, DateTime date);
        public AgendaDTO AcceptAgenda(int agendaId);

    }
}
