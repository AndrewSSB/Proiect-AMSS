using Microsoft.AspNetCore.Mvc;
using Proiect1.Services.Interfaces.Meet.Manager;
using Proiect1.Services.Models;
using Proiect1.Services.Models.MeetModels;
using System;
using System.Threading.Tasks;
using Proiect1.Services.DTOs.Meet;

namespace Proiect1.Api.Controllers.Meet
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
