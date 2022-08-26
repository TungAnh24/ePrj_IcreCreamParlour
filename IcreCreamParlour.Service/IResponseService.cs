using IcreCreamParlour.Model.ObjResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Service
{
    public interface IResponseService
    {
        IEnumerable<HomeResponse> GetAll();
    }
}
