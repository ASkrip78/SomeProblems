using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
  
    public class HomeController : Controller
    {
        

        public IActionResult Index(DateTime DateStartInput, DateTime DateFinishInput, string SomeInput)
        {
            string DateStartFormatted = DateStartInput.ToString();
            string DateFinishFormatted = DateFinishInput.ToString();

            IndexViewModelSomeModel viewmodel = new IndexViewModelSomeModel
            {
                FilterViewModel = new FilterViewModel(DateStartInput, DateFinishInput, SomeInput)
                // SomeModels = new ModelEnum();
            };
            return View(viewmodel);
        }

        public IActionResult SomeAction(SomeModel model)
        {
            return View("Index", model);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
