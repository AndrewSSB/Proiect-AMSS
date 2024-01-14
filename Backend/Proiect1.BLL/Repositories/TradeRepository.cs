using Proiect1.BLL.Interfaces;
using Proiect1.DAL.Entities;
using Proiect1.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect1.Services.Interfaces;
using Proiect1.Infrastructure.Entities;

namespace Proiect1.Services.Repositories
{
    public class TradeRepository : ITradeRepository
    {
        private readonly AppDbContext db;

        public TradeRepository(AppDbContext db)
        {
            this.db = db;
        }

        public Trade CreateTrade(Trade trade)
        {
            db.Trades.Add(trade);
            db.SaveChanges();
            return trade;
        }

        public Trade DeleteTrade(Trade trade)
        {
            db.Trades.Remove(trade);
            db.SaveChanges();
            return trade;
        }

        public List<Trade> GetAll()
        {
            return db.Trades.AsQueryable().ToList();
        }

        public Trade UpdateTrade(Trade trade, Trade newTrade)
        {
            trade.acceptedUser1 = newTrade.acceptedUser1;
            trade.acceptedUser2 = newTrade.acceptedUser2;
            db.Trades.Update(trade);
            db.SaveChanges();
            return trade;
        }
    }
}
