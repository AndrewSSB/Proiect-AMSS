using BookHub.BLL.Interfaces;
using BookHub.DAL.Entities;
using BookHub.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHub.Infrastructure.Entities;
using BookHub.Services.Interfaces.Meet.Repo;

namespace BookHub.Services.Repositories.Meet
{
    public class TradeRepository : ITradeRepository
    {
        private readonly AppDbContext db;

        public TradeRepository(AppDbContext db)
        {
            this.db = db;
        }

        public Trade AcceptTrade(int tradeId)
        {
            var trade = db.Trades.Find(tradeId);
            trade.acceptedUser1 = true;
            trade.acceptedUser2 = true;
            db.Trades.Update(trade);
            db.SaveChanges();
            return trade;
        }

        public Trade CreateTrade(Trade trade)
        {
            db.Trades.Add(trade);
            db.SaveChanges();
            return trade;
        }
        

        public Trade CreateTradeByUser(Trade trade, int userId, int userId2)
        {
            trade.UserById = userId;
            trade.UserForId = userId2;
            db.Trades.Add(trade);
            db.SaveChanges();
            return trade;
        }
        

        public Trade CreateTradeByUser(int userId, int userId2)
        {
            var trade = new Trade();
            trade.UserById = userId;
            trade.UserForId = userId2;

            var userTrade = new UserTrade();
            userTrade.UserById = userId;
            userTrade.UserForId = userId2;
            userTrade.Trade = trade;
            db.UserTrades.Add(userTrade);
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

        public List<Trade> GetTradesByUser(int userId)
        {
            var userTrades = db.UserTrades.Where(t => t.UserById == userId).ToList();
            var tradesIds = userTrades.Select(ut => ut.TradeId).ToList();
            var trades = db.Trades.Where(t => tradesIds.Contains(t.TradeId)).ToList();
            return trades;
        }

        public List<Trade> GetTradesForUser(int userId)
        {
            var userTrades = db.UserTrades.Where(t => t.UserForId == userId).ToList();
            var tradesIds = userTrades.Select(ut => ut.TradeId).ToList();
            var trades = db.Trades.Where(t => tradesIds.Contains(t.TradeId)).ToList();
            return trades;
        }

        public Trade ResetTrade(Trade trade)
        {
            trade.acceptedUser1 = true;
            trade.acceptedUser2 = false;
            db.Trades.Update(trade);
            db.SaveChanges();
            return trade;
        }

        public Trade GetTradeById(int id)
        {
            return db.Trades.Find(id);
        }
    }
}
