using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.Services.DTOs.Meet
{
    public class FeedbackDTO
    {
        public string Nickname { get; set; }
        public int Rating { get; set; }
        public string FeedbackText { get; set; }
    }
}
