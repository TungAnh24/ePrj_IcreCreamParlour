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
        IEnumerable<Flavor> GetAll();
        Flavor FindById(int id);
        void InsertFlavor(Flavor flavor);
        void UpdateFlavor(Flavor flavor);
        void DeleteFlavor(int id);
    }
}
