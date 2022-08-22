using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Model.DTO
{
    public class FeedbackDTO
    {
        public int FeedbackId { get; set; }
        public string FeedbackDetail { get; set; }
        public int? UserId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Responder { get; set; }

        public FeedbackDTO(int feedbackId, string feedbackDetail, int? userId, string name, DateTime date, string contact, string email, string responder)
        {
            FeedbackId = feedbackId;
            FeedbackDetail = feedbackDetail;
            UserId = userId;
            Name = name;
            Date = date;
            Contact = contact;
            Email = email;
            Responder = responder;
        }

        public FeedbackDTO()
        {
        }
    }
}
