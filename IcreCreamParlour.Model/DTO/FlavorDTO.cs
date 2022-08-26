using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Model.DTO
{
    public class FlavorDTO
    {
        public int FlavorId { get; set; }
        public string FlavorName { get; set; }
        public string Ingredients { get; set; }
        public string MakingProcess { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
