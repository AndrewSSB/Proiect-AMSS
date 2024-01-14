using Proiect1.DAL.Entities;
using Proiect1.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.Services.DTOs.Meet
{
    public class TradeDTO
    {
        public int? UserById { get; set; }
        public int? UserForId { get; set; }
        public int? MeetingId { get; set; }

        public bool acceptedUser1 { get; set; }
        public bool acceptedUser2 { get; set; }
    }
}
