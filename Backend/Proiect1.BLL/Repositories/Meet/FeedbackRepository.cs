using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect1.DAL;
using Proiect1.Infrastructure.Entities;
using Proiect1.Services.DTOs.Meet;
using Proiect1.Services.Interfaces.Meet.Repo;

namespace Proiect1.Services.Repositories.Meet
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly AppDbContext db;

        public FeedbackRepository(AppDbContext db)
        {
            this.db = db;
        }

        public FeedbackDTO AddFeedback(Feedback feedback)
        {
            db.Feedbacks.Add(feedback);
            db.SaveChanges();
            return new FeedbackDTO()
            {
                Nickname = feedback.Nickname,
                FeedbackText = feedback.FeedbackText,
                Rating = feedback.Rating
            };
        }

        public void DeleteFeedback(int id)
        {
            db.Feedbacks.Remove(db.Feedbacks.Find(id));
            db.SaveChanges();
        }

        public List<FeedbackDTO> GetAllFeedbacks()
        {
            return db.Feedbacks.ToList().Select(f => new FeedbackDTO()
            {
                FeedbackText = f.FeedbackText,
                Nickname = f.Nickname,
                Rating = f.Rating
            }).ToList();
        }

        public FeedbackDTO GetFeedback(int id)
        {
            var feedback = db.Feedbacks.Find(id);
            return new FeedbackDTO()
            {
                Nickname = feedback.Nickname,
                FeedbackText = feedback.FeedbackText,
                Rating = feedback.Rating
            };
        }

        public FeedbackDTO UpdateFeedback(Feedback feedback, string newText, int newRate)
        {
            feedback.FeedbackText = newText;
            feedback.Rating = newRate;
            db.Feedbacks.Update(feedback);
            db.SaveChanges();
            return new FeedbackDTO()
            {
                Nickname = feedback.Nickname,
                FeedbackText = feedback.FeedbackText,
                Rating = feedback.Rating
            };
        }

        public FeedbackDTO UpdateFeedback(int feedbackId, string newText, int newRate)
        {
            var feedback = db.Feedbacks.Find(feedbackId);
            feedback.FeedbackText = newText;
            feedback.Rating = newRate;
            db.Feedbacks.Update(feedback);
            db.SaveChanges();
            return new FeedbackDTO()
            {
                Nickname = feedback.Nickname,
                FeedbackText = feedback.FeedbackText,
                Rating = feedback.Rating
            };
        }
    }
}
