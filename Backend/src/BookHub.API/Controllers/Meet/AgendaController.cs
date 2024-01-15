using Microsoft.AspNetCore.Mvc;
using BookHub.Services.Interfaces.Meet.Manager;
using BookHub.Services.Models;
using BookHub.Services.Models.MeetModels;
using System;
using System.Threading.Tasks;
using BookHub.Services.DTOs.Meet;

namespace BookHub.Api.Controllers.Meet
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendaController : ControllerBase
    {
        private readonly IAgendaManager manager;

        public AgendaController(IAgendaManager agendaManager)
        {
            this.manager = agendaManager;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateAgenda([FromBody] AgendaDTO agendaModel)
        {
            var createdAgenda = manager.CreateAgenda(agendaModel);
            return Ok(createdAgenda);
        }

        [HttpPost("create/{meetingId}")]
        public async Task<IActionResult> CreateAgendaForMeeting([FromRoute] int meetingId, [FromBody] string date)
        {
            var createdAgenda = manager.CreateAgendaForMeeting(meetingId, DateTime.Parse(date));
            return Ok(createdAgenda);
        }

        [HttpPost("accept/{agendaId}")]
        public async Task<IActionResult> AcceptAgenda([FromRoute] int agendaId)
        {
            var acceptedAgenda = manager.AcceptAgenda(agendaId);
            return Ok(acceptedAgenda);
        }
    }
}
