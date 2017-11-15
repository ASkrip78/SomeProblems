using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public partial class SomeModel
    {
        public string AnyStringModel { get; set; }
        public string SomeStringModel { get; set; }
        public DateTime? DateOfSomeModel { get; set; }
    }
}
