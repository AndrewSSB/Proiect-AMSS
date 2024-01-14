using Proiect1.Services.Models.MeetModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.Services.Interfaces.Meet.Manager
{
    public interface ITradeManager
    {
        public TradeModel CreateTrade(int userId1, int userId2);
        public TradeModel AcceptTrade(int userId, TradeModel trade);
        public void CancelTrade(TradeModel trade);
        public TradeModel CompleteTrade(TradeModel trade);
    }
}
