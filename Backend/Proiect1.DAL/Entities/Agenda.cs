using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.Infrastructure.Entities
{
    public class Agenda
    {
        public int Id { get; set; }
        public Meeting? Meeting { get; set; }
        public int? MeetingId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool acceptedUser1 { get; set; }
        public bool acceptedUser2 { get; set; }
    }
}
