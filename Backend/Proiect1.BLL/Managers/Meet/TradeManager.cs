using Proiect1.DAL.Entities;
using Proiect1.Infrastructure.Entities;
using Proiect1.Services.Interfaces.Meet.Manager;
using Proiect1.Services.Interfaces.Meet.Repo;
using Proiect1.Services.Models.MeetModels;
using System;
using System.Collections.Generic;
using System.Linq;
using Proiect1.Services.DTOs.Meet;

namespace Proiect1.Services.Managers.Meet
{
    public class TradeManager : ITradeManager
    {
        private readonly ITradeRepository tradeRepository;
        private readonly IMeetingRepository meetingRepository;

        public TradeManager(ITradeRepository tradeRepository, IMeetingRepository meetingRepository)
        {
            this.tradeRepository = tradeRepository;
            this.meetingRepository = meetingRepository;
        }

        public TradeDTO AcceptTrade(int userId, int tradeId)
        {
            var trade = tradeRepository.GetTradeById(tradeId);
            if (trade.UserForId != userId)
                return null;
            
            trade.acceptedUser2 = true;
            var tradeGenerated = tradeRepository.AcceptTrade(tradeId);

            // meetingRepository.CreateMeeting(tradeId);

            return new TradeDTO()
            {
                UserForId = trade.UserForId,
                UserById = trade.UserById,
                acceptedUser1 = trade.acceptedUser1,
                acceptedUser2 = trade.acceptedUser2
            };
        }

        public void CancelTrade(int tradeId)
        {
            var trade = tradeRepository.GetTradeById(tradeId);
            tradeRepository.DeleteTrade(trade);
        }
        

        public TradeDTO CreateTrade(int userId1, int userId2)
        {
            var trade = tradeRepository.CreateTradeByUser(userId1, userId2);
            return new TradeDTO()
            {
                MeetingId = null,
                UserById = trade.UserById,
                UserForId = trade.UserForId,
                acceptedUser1 = true,
                acceptedUser2 = trade.acceptedUser2
            };

        }

        public TradeDTO DeleteTrade(int tradeId)
        {
            var trade = tradeRepository.GetTradeById(tradeId);
            var delete = tradeRepository.DeleteTrade(trade);
            return new TradeDTO()
            {
                UserById = delete.UserById,
                UserForId = delete.UserForId,
                acceptedUser1 = delete.acceptedUser1,
                acceptedUser2 = delete.acceptedUser2
            };
        }

        public List<TradeDTO> GetAll()
        {
            var trades = tradeRepository.GetAll();
            var tradesDTO = trades.Select(t => new TradeDTO()
            {
                MeetingId = t.MeetingId,
                UserById = t.UserById,
                UserForId = t.UserForId,
                acceptedUser1 = t.acceptedUser1,
                acceptedUser2 = t.acceptedUser2
            }).ToList();
            return tradesDTO;
        }

        public List<TradeDTO> GetAllAcceptedTrades(int userId)
        {
            var trades = tradeRepository.GetTradesByUser(userId);
            var acceptedTrades = trades.FindAll(trade => trade.acceptedUser1 == true && trade.acceptedUser2 == true);
            var acceptedTradesDTO = acceptedTrades.Select(t => new TradeDTO()
            {
                MeetingId = t.MeetingId,
                UserById = t.UserById,
                UserForId = t.UserForId,
                acceptedUser1 = t.acceptedUser1,
                acceptedUser2 = t.acceptedUser2
            }).ToList();
            return acceptedTradesDTO;
        }

        public List<TradeDTO> GetAllUnacceptedTrades(int userId)
        {
            var trades = tradeRepository.GetTradesByUser(userId);
            var acceptedTrades = trades.FindAll(trade => trade.acceptedUser1 == false || trade.acceptedUser2 == false);
            var acceptedTradesDTO = acceptedTrades.Select(t => new TradeDTO()
            {
                MeetingId = t.MeetingId,
                UserById = t.UserById,
                UserForId = t.UserForId,
                acceptedUser1 = t.acceptedUser1,
                acceptedUser2 = t.acceptedUser2
            }).ToList();
            return acceptedTradesDTO;
        }

        public List<TradeDTO> GetTradesByUser(int userId)
        {
            var trades = tradeRepository.GetTradesByUser(userId);
            var tradesDTO = trades.Select(t => new TradeDTO()
            {
                MeetingId = t.MeetingId,
                UserById = t.UserById,
                UserForId = t.UserForId,
                acceptedUser1 = t.acceptedUser1,
                acceptedUser2 = t.acceptedUser2
            }).ToList();
            return tradesDTO;
        }

        public List<TradeDTO> GetTradesForUser(int userId)
        {
            var trades = tradeRepository.GetTradesForUser(userId);
            var tradesDTO = trades.Select(t => new TradeDTO()
            {
                MeetingId = t.MeetingId,
                UserById = t.UserById,
                UserForId = t.UserForId,
                acceptedUser1 = t.acceptedUser1,
                acceptedUser2 = t.acceptedUser2
            }).ToList();
            return tradesDTO;
        }
    }
}
