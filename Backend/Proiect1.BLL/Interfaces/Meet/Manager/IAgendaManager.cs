using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect1.Infrastructure.Entities;
using Proiect1.Services.DTOs.Meet;
using Proiect1.Services.Models.MeetModels;

namespace Proiect1.Services.Interfaces.Meet.Manager
{
    public interface IAgendaManager
    {
        public AgendaDTO CreateAgenda(AgendaDTO agenda);
        public AgendaDTO CreateAgendaForMeeting(int meetingId, DateTime date);
        public AgendaDTO AcceptAgenda(int agendaId);

    }
}
