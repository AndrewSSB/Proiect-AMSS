using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect1.Infrastructure.Entities;
using Proiect1.Services.DTOs.Meet;
using Proiect1.Services.Interfaces.Meet.Manager;
using Proiect1.Services.Interfaces.Meet.Repo;

namespace Proiect1.Services.Managers.Meet
{
    public class FeedbackManager : IFeedbackManager
    {
        private readonly IFeedbackRepository feedbackRepository;

        public FeedbackManager(IFeedbackRepository feedbackRepository)
        {
            this.feedbackRepository = feedbackRepository;
        }

        public FeedbackDTO AddFeedback(FeedbackDTO feedback)
        {
            var newFeedback = new Feedback()
            {
                FeedbackText = feedback.FeedbackText,
                Nickname = feedback.Nickname,
                Rating = feedback.Rating
            };
            feedbackRepository.AddFeedback(newFeedback);
            return feedback;
        }

        public void DeleteFeedback(int id)
        {
            feedbackRepository.DeleteFeedback(id);
        }

        public List<FeedbackDTO> GetAllFeedbacks()
        {
            return feedbackRepository.GetAllFeedbacks();
        }

        public FeedbackDTO GetFeedback(int id)
        {
            return feedbackRepository.GetFeedback(id);
        }

        public FeedbackDTO UpdateFeedback(FeedbackDTO feedbackDto, string text, int rate)
        {
            var feedback = new Feedback()
            {
                FeedbackText = feedbackDto.FeedbackText,
                Nickname = feedbackDto.Nickname,
                Rating = feedbackDto.Rating
            };
            var updatedFeedback = feedbackRepository.UpdateFeedback(feedback, text, rate);
            return updatedFeedback;
        }

        public FeedbackDTO UpdateFeedback(int feedbackId, string text, int rate)
        {
            return feedbackRepository.UpdateFeedback(feedbackId, text, rate);
        }
    }
}
