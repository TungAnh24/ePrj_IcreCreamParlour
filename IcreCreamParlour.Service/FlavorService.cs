using IcreCreamParlour.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Service
{
    public class FlavorService : IFlavorService
    {
        private readonly IGenericRepository<FlavorService> _repository;

        public FlavorService(IGenericRepository<FlavorService> repository)
        {
            _repository = repository;
        }

        public void DeleteFlavor(int id)
        {
            _repository.Delete(id);
        }

        public FlavorService FindById(int id)
        {
            return _repository.FindById(id);
        }

        public IEnumerable<FlavorService> GetAll()
        {
            return _repository.GetAll();
        }

        public void InsertFlavor(FlavorService flavor)
        {
            _repository.Insert(flavor);
        }

        public void UpdateFlavor(FlavorService flavor)
        {
            _repository.Update(flavor);
        }
        public static implicit operator FlavorService(GenericRepository<FlavorService> flavor)
        {
            throw new NotImplementedException();
        }
    }
}
