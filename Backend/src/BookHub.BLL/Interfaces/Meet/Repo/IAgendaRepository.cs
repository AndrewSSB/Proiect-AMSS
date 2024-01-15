using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHub.Infrastructure.Entities;
using BookHub.Services.Models.MeetModels;

namespace BookHub.Services.Interfaces.Meet.Repo
{
    public interface IAgendaRepository
    {
        void Add(Agenda agenda);
        void Update(Agenda agenda);
        void Delete(int id);
        void Delete(Agenda agenda);
        Agenda GetById(int id);
        List<Agenda> GetAll();

        Agenda CreateAgendaForMeeting(int meetingId, DateTime date);
        Agenda CreateAgendaForMeeting(MeetingModel meeting, DateTime date);
        Agenda AcceptAgenda(Agenda agenda);
    }
}
