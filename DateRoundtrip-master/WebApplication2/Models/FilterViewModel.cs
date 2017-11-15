using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class FilterViewModel
    {

        /*Фильтрации разные*/
        public FilterViewModel(string SomeInput)
        {
             SelectedAny = SomeInput;
        }


        public FilterViewModel(DateTime DateStartInput, DateTime DateFinishInput, string SomeInput)
        {
            SelectedAny = SomeInput;
            SelectedDateStart = DateStartInput;
            SelectedDateFinish = DateFinishInput;

        }        

        public string SelectedAny { get; private set; }
        public DateTime SelectedDateStart { get; private set; }
        public DateTime SelectedDateFinish { get; private set; }        
    }
}
