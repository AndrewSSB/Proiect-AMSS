using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect1.Infrastructure.Entities;
using Proiect1.Services.DTOs.Meet;

namespace Proiect1.Services.Interfaces.Meet.Manager
{
    public interface IFeedbackManager
    {
        public FeedbackDTO AddFeedback(FeedbackDTO feedback);
        public FeedbackDTO GetFeedback(int id);
        public FeedbackDTO UpdateFeedback(FeedbackDTO feedback, string text, int rate);
        public FeedbackDTO UpdateFeedback(int feedbackId, string text, int rate);
        public void DeleteFeedback(int id);
        public List<FeedbackDTO> GetAllFeedbacks();
    }
}
