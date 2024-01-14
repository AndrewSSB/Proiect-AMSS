using Proiect1.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.Services.Models.MeetModels
{
    public class AgendaModel
    {

        public int Id { get; set; }
        public int MeetingId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool acceptedUser1 { get; set; }
        public bool acceptedUser2 { get; set; }
    }
}
