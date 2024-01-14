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
        public Meeting Meeting { get; set; }
        public int MeetingId { get; set; }
    }
}
