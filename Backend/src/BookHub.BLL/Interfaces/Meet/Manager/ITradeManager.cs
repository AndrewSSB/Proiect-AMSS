using BookHub.Infrastructure.Entities;
using BookHub.Services.Models.MeetModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHub.Services.DTOs.Meet;

namespace BookHub.Services.Interfaces.Meet.Manager
{
    public interface ITradeManager
    {
        public TradeDTO CreateTrade(int userId1, int userId2);
        public TradeDTO AcceptTrade(int userId, int tradeId);
        public List<TradeDTO> GetTradesByUser(int userId);
        public List<TradeDTO> GetTradesForUser(int userId);
        public List<TradeDTO> GetAll();
        public TradeDTO DeleteTrade(int tradeId);
        public List<TradeDTO> GetAllAcceptedTrades(int userId);
        public List<TradeDTO> GetAllUnacceptedTrades(int userId);
    }
}
