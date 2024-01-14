using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect1.DAL;
using Proiect1.Infrastructure.Entities;
using Proiect1.Services.Interfaces.Meet.Repo;
using Proiect1.Services.Models.MeetModels;

namespace Proiect1.Services.Repositories.Meet
{
    public class AgendaRepository : IAgendaRepository
    {

        private readonly AppDbContext db;

        public AgendaRepository(AppDbContext db)
        {
            this.db = db;
        }

        public Agenda AcceptAgenda(Agenda agenda)
        {
            agenda.acceptedUser1 = true;
            agenda.acceptedUser2 = true;
            db.Agendas.Update(agenda);
            db.SaveChanges();
            return agenda;
        }

        public void Add(Agenda agenda)
        {
            db.Agendas.Add(agenda);
            db.SaveChanges();
        }

        public Agenda CreateAgendaForMeeting(int meetingId, DateTime date)
        {
            var agenda = new Agenda
            {
                MeetingId = meetingId,
                Date = date,
                acceptedUser1 = true,
                acceptedUser2 = false
            };
            db.Agendas.Add(agenda);
            db.SaveChanges();
            return agenda;
        }

        public Agenda CreateAgendaForMeeting(MeetingModel meeting, DateTime date)
        {
            var agenda = new Agenda
            {
                MeetingId = meeting.MeetingId,
                Date = date,
                acceptedUser1 = true,
                acceptedUser2 = false
            };

            db.Agendas.Add(agenda);
            db.SaveChanges();
            return agenda;
        }

        public void Delete(int id)
        {
            db.Agendas.Remove(GetById(id));
            db.SaveChanges();
        }

        public void Delete(Agenda agenda)
        {
            db.Agendas.Remove(agenda);
            db.SaveChanges();
        }

        public List<Agenda> GetAll()
        {
            return db.Agendas.ToList();
        }

        public Agenda GetById(int id)
        {
            return db.Agendas.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Agenda agenda)
        {
            db.Agendas.Update(agenda);
            db.SaveChanges();
        }
    }
}
