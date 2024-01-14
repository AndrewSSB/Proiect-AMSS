using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.Services.DTOs.Meet
{
    public class AgendaDTO
    {
        public int? MeetingId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool acceptedUser1 { get; set; }
        public bool acceptedUser2 { get; set; }
    }
}
