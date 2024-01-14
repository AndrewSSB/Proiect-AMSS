using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Proiect1.Services.DTOs.Meet;
using Proiect1.Services.Interfaces.Meet.Manager;

namespace Proiect1.Api.Controllers.Meet
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradeController : ControllerBase
    {
        private readonly ITradeManager manager;

        public TradeController(ITradeManager tradeManager)
        {
            this.manager = tradeManager;
        }

        [HttpPost("create/{userId1}/{userId2}")]
        public async Task<IActionResult> CreateTrade([FromRoute] int userId1, [FromRoute] int userId2)
        {
            var createdTrade = manager.CreateTrade(userId1, userId2);
            return Ok(createdTrade);
        }

        [HttpPost("accept/{userId}/{tradeId}")]
        public async Task<IActionResult> AcceptTrade([FromRoute] int userId, [FromRoute] int tradeId)
        {
            var acceptedTrade = manager.AcceptTrade(userId, tradeId);
            return Ok(acceptedTrade);
        }

        [HttpGet("getTradesByUser/{userId}")]
        public async Task<IActionResult> GetTradesByUser([FromRoute] int userId)
        {
            var trades = manager.GetTradesByUser(userId);
            return Ok(trades);
        }

        [HttpGet("getTradesForUser/{userId}")]
        public async Task<IActionResult> GetTradesForUser([FromRoute] int userId)
        {
            var trades = manager.GetTradesForUser(userId);
            return Ok(trades);
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var trades = manager.GetAll();
            return Ok(trades);
        }

        //[HttpDelete("delete/{tradeId}")]
        public async Task<IActionResult> DeleteTrade([FromRoute] int tradeId)
        {
            var trade = manager.DeleteTrade(tradeId);
            return Ok(trade);
        }

        [HttpGet("getAllAcceptedTrades/{userId}")]
        public async Task<IActionResult> GetAllAcceptedTrades([FromRoute] int userId)
        {
            var trades = manager.GetAllAcceptedTrades(userId);
            return Ok(trades);
        }

        [HttpGet("getAllUnacceptedTrades/{userId}")]
        public async Task<IActionResult> GetAllUnacceptedTrades([FromRoute] int userId)
        {
            var trades = manager.GetAllUnacceptedTrades(userId);
            return Ok(trades);
        }
        

    }
}
