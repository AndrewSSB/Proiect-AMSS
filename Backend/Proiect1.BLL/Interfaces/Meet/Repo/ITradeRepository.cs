using Proiect1.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.Services.Interfaces.Meet.Repo
{
    public interface ITradeRepository
    {
        public Trade CreateTrade(Trade trade);
        public Trade CreateTradeByUser(Trade trade, int userIdFrom, int userIdTo);
        public Trade CreateTradeByUser( int userIdFrom, int userIdTo);
        public List<Trade> GetTradesByUser(int userId);
        public List<Trade> GetTradesForUser(int userId);
        public List<Trade> GetAll();
        public Trade AcceptTrade(int tradeId);
        public Trade DeleteTrade(Trade trade);
        public Trade GetTradeById(int id);
        public Trade ResetTrade(Trade trade);
    }
}
