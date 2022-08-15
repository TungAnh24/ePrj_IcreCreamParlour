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
        private readonly IGenericRepository<FeedbackService> _repository;

        public FeedbackService(IGenericRepository<FeedbackService> repository)
        {
            _repository = repository;
        }

        public void DeleteFeedback(int id)
        {
            _repository.Delete(id);
        }

        public FeedbackService FindById(int id)
        {
            return _repository.FindById(id);
        }

        public IEnumerable<FeedbackService> GetAll()
        {
            return _repository.GetAll();
        }

        public void InsertFeedback(FeedbackService feedback)
        {
            _repository.Insert(feedback);
        }

        public void UpdateFeedback(FeedbackService feedback)
        {
            _repository.Update(feedback);
        }
        public static implicit operator FeedbackService(GenericRepository<FeedbackService> feedback)
        {
            throw new NotImplementedException(); 
        }
    }
}
