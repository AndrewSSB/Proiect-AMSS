using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHub.Infrastructure.Entities;
using BookHub.Services.DTOs.Meet;

namespace BookHub.Services.Interfaces.Meet.Repo
{
    public interface IFeedbackRepository
    {
        public FeedbackDTO AddFeedback(Feedback feedback);
        public FeedbackDTO GetFeedback(int id);
        public FeedbackDTO UpdateFeedback(Feedback feedback, string text, int rate);
        public FeedbackDTO UpdateFeedback(int feedbackId, string text, int rate);
        public void DeleteFeedback(int id);
        public List<FeedbackDTO> GetAllFeedbacks();
    }
}
