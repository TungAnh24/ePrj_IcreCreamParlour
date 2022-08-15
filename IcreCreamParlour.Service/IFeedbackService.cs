using IcreCreamParlour.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Service
{
    public interface IFeedbackService
    {
        IEnumerable<FeedbackService> GetAll();
        FeedbackService FindById(int id);
        void InsertFeedback(FeedbackService feedback);
        void UpdateFeedback(FeedbackService feedback);
        void DeleteFeedback(int id);
    }
}
