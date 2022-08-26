using IcreCreamParlour.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IcreCreamParlour.Model.DTO;

namespace IcreCreamParlour.Service
{
    public interface IFlavorService
    {
        IEnumerable<FlavorDTO> GetAll();
        Flavor FindById(int id);
        void InsertFlavor(Flavor flavor);
        void UpdateFlavor(Flavor flavor);
        void DeleteFlavor(int id);
    }
}
