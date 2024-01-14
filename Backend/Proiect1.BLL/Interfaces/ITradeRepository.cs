using Proiect1.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.Services.Interfaces
{
    public interface ITradeRepository
    {
        public Trade CreateTrade(Trade trade);
        public Trade UpdateTrade(Trade trade, Trade newTrad);
        public List<Trade> GetAll();
        public Trade DeleteTrade(Trade trade);
    }
}
