using Proiect1.DAL.Entities;
using Proiect1.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.Services.Models.MeetModels
{
    public class TradeModel
    {
        public int TradeId { get; set; }
        public int UserId { get; set; }
        public int MeetingId { get; set; }
    }
}
