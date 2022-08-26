using IcreCreamParlour.Model.DTO;
using IcreCreamParlour.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Model.ObjResponse
{
    public class HomeResponse
    {
        public IEnumerable<Book> BookResponse { get; set; }
        public IEnumerable<Recipe> RecipeResponse { get; set; }
        public IEnumerable<Admin> AdminResponse { get; set; }
    }
}
