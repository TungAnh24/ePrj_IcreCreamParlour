using IcreCreamParlour.Model.DTO;
using IcreCreamParlour.Model.Entities;
using IcreCreamParlour.Model.Mapper;
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
        private readonly IGenericRepository<Flavor> _repository;

        public FlavorService(IGenericRepository<Flavor> repository)
        {
            _repository = repository;
        }

        public void DeleteFlavor(int id)
        {
            _repository.Delete(id);
        }

        public Flavor FindById(int id)
        {
            return _repository.FindById(id);
        }

        public IEnumerable<FlavorDTO> GetAll()
        {
            return _repository.GetAll().ToList().Select(flavor => flavor.Convert());
        }

        public void InsertFlavor(Flavor flavor)
        {
            _repository.Insert(flavor);
        }

        public void UpdateFlavor(Flavor flavor)
        {
            _repository.Update(flavor);
        }
        public static implicit operator FlavorService(GenericRepository<FlavorService> flavor)
        {
            throw new NotImplementedException();
        }
    }
}
