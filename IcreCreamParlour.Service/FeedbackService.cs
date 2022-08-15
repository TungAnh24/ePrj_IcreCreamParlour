using IcreCreamParlour.Model.Entities;
using IcreCreamParlour.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Service
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IGenericRepository<Feedback> _repository;

        public FeedbackService(IGenericRepository<Feedback> repository)
        {
            _repository = repository;
        }

        public void DeleteFeedback(int id)
        {
            _repository.Delete(id);
        }

        public Feedback FindById(int id)
        {
            return _repository.FindById(id);
        }

        public IEnumerable<Feedback> GetAll()
        {
            return _repository.GetAll();
        }

        public void InsertFeedback(Feedback feedback)
        {
            _repository.Insert(feedback);
        }

        public void UpdateFeedback(Feedback feedback)
        {
            _repository.Update(feedback);
        }
        public static implicit operator FeedbackService(GenericRepository<FeedbackService> feedback)
        {
            throw new NotImplementedException(); 
        }
    }
}
