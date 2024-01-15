using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.Infrastructure.Entities
{
    public class Feedback
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public int Rating { get; set; }
        public string FeedbackText { get; set; }
    }
}
