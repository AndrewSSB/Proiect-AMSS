using Proiect1.BLL.Interfaces;
using Proiect1.Infrastructure.Entities;
using Proiect1.Services.Interfaces.Meet.Manager;
using Proiect1.Services.Interfaces.Meet.Repo;
using Proiect1.Services.Models.MeetModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.Services.Managers.Meet
{
    public class TradeManager : ITradeManager
    {
        private readonly ITradeRepository tradeRepository;

        public TradeManager(ITradeRepository tradeRepository)
        {
            this.tradeRepository = tradeRepository;
        }

        public TradeModel AcceptTrade(int userId, TradeModel trade)
        {
            throw new NotImplementedException();
        }

        public void CancelTrade(TradeModel trade)
        {
            var tradeItem = new Trade
            {
                acceptedUser1 = trade.acceptedUser1,
                acceptedUser2 = trade.acceptedUser2,
                UserId = trade.UserId,
                TradeId = trade.TradeId
            };

            tradeRepository.DeleteTrade(tradeItem);
        }

        public TradeModel CompleteTrade(TradeModel trade)
        {
            throw new NotImplementedException();
        }

        public TradeModel CreateTrade(int userId1, int userId2)
        {
            throw new NotImplementedException();
        }
    }
}
