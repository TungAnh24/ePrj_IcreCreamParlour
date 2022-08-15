using IcreCreamParlour.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Service
{
    public interface IFlavorService
    {
        IEnumerable<FlavorService> GetAll();
        FlavorService FindById(int id);
        void InsertFlavor(FlavorService flavor);
        void UpdateFlavor(FlavorService flavor);
        void DeleteFlavor(int id);
    }
}
