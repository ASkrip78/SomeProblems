using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class IndexViewModelSomeModel
    {
        
        public IEnumerable<SomeModel> SomeModels { get; set; }
        public FilterViewModel FilterViewModel { get; set; }
       
    }
}
