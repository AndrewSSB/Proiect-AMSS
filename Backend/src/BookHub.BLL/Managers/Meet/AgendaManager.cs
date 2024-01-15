using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHub.Infrastructure.Entities;
using BookHub.Services.DTOs.Meet;
using BookHub.Services.Interfaces.Meet.Manager;
using BookHub.Services.Interfaces.Meet.Repo;
using BookHub.Services.Models.MeetModels;

namespace BookHub.Services.Managers.Meet
{
    public class AgendaManager : IAgendaManager
    {
        private readonly IAgendaRepository agendaRepository;

        public AgendaManager(IAgendaRepository agendaRepository)
        {
            this.agendaRepository = agendaRepository;
        }

        public AgendaDTO CreateAgenda(AgendaDTO agenda)
        {
            var newAgenda = new Agenda
            {
                MeetingId = agenda.MeetingId,
                Date = agenda.Date,
                Description = agenda.Description,
                acceptedUser1 = true,
                acceptedUser2 = false,
            };
            agendaRepository.Add(newAgenda);

            var agendaDTO = new AgendaDTO
            {
                MeetingId = newAgenda.MeetingId,
                Date = newAgenda.Date,
                Description = newAgenda.Description,
                acceptedUser1 = newAgenda.acceptedUser1,
                acceptedUser2 = newAgenda.acceptedUser2,
            };
            return agendaDTO;
        }

        public AgendaDTO CreateAgendaForMeeting(int meetingId, DateTime date)
        {
            var newAgenda = new Agenda
            {
                MeetingId = meetingId,
                Date = date,
                Description = "",
                acceptedUser1 = true,
                acceptedUser2 = false,
            };
            agendaRepository.Add(newAgenda);

            var agendaDTO = new AgendaDTO
            {
                MeetingId = newAgenda.MeetingId ?? 0,
                Date = newAgenda.Date,
                Description = newAgenda.Description,
                acceptedUser1 = newAgenda.acceptedUser1,
                acceptedUser2 = newAgenda.acceptedUser2,
            };
            return agendaDTO;
        }

        public AgendaDTO CreateAgendaForMeeting(MeetingModel meeting, DateTime date)
        {
            var newAgenda = new Agenda
            {
                MeetingId = meeting.MeetingId,
                Date = date,
                Description = "",
                acceptedUser1 = true,
                acceptedUser2 = false,
            };
            agendaRepository.Add(newAgenda);

            var agendaDTO = new AgendaDTO
            {
                MeetingId = newAgenda.MeetingId ?? 0,
                Date = newAgenda.Date,
                Description = newAgenda.Description,
                acceptedUser1 = newAgenda.acceptedUser1,
                acceptedUser2 = newAgenda.acceptedUser2,
            };
            return agendaDTO;
        }

        public AgendaDTO AcceptAgenda(AgendaModel agenda)
        {
            var newAgenda = new Agenda
            {
                Id = agenda.Id,
                MeetingId = agenda.MeetingId,
                Date = agenda.Date,
                Description = agenda.Description,
                acceptedUser1 = true,
                acceptedUser2 = true,
            };
            agendaRepository.Update(newAgenda);

            var agendaDTO = new AgendaDTO
            {
                MeetingId = newAgenda.MeetingId ?? 0,
                Date = newAgenda.Date,
                Description = newAgenda.Description,
                acceptedUser1 = newAgenda.acceptedUser1,
                acceptedUser2 = newAgenda.acceptedUser2,
            };
            return agendaDTO;
        }

        public AgendaDTO AcceptAgenda(int agendaId)
        {
            var agenda = agendaRepository.GetById(agendaId);
            agenda.acceptedUser2 = true;
            agendaRepository.Update(agenda);

            var agendaDTO = new AgendaDTO
            {
                MeetingId = agenda.MeetingId ?? 0,
                Date = agenda.Date,
                Description = agenda.Description,
                acceptedUser1 = agenda.acceptedUser1,
                acceptedUser2 = agenda.acceptedUser2,
            };
            return agendaDTO;
        }
    }
}
