using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Proiect1.Services.DTOs.Meet;
using Proiect1.Services.Interfaces.Meet.Manager;

namespace Proiect1.Api.Controllers.Meet
{

    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private readonly IFeedbackManager manager;

        public FeedbackController(IFeedbackManager feedbackManager)
        {
            this.manager = feedbackManager;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateFeedback([FromBody] FeedbackDTO feedbackModel)
        {
            var createdFeedback = manager.AddFeedback(feedbackModel);
            return Ok(createdFeedback);
        }

        [HttpGet("get/{feedbackId}")]
        public async Task<IActionResult> GetFeedback([FromRoute] int feedbackId)
        {
            var feedback = manager.GetFeedback(feedbackId);
            return Ok(feedback);
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAllFeedbacks()
        {
            var feedbacks = manager.GetAllFeedbacks();
            return Ok(feedbacks);
        }

        [HttpPut("update/{feedbackId}")]
        public async Task<IActionResult> UpdateFeedback([FromRoute] int feedbackId, [FromBody] FeedbackDTO newData)
        {
            var updatedFeedback = manager.UpdateFeedback(feedbackId, newData.FeedbackText, newData.Rating);
            return Ok(updatedFeedback);
        }

        [HttpDelete("delete/{feedbackId}")]
        public async Task<IActionResult> DeleteFeedback([FromRoute] int feedbackId)
        {
            manager.DeleteFeedback(feedbackId);
            return Ok();
        }
    }
}
