using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinksGo.Data.Interfaces;
using DrinksGo.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DrinksGo.Controllers
{
    public class DrinkController : Controller
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IDrinkRepository drinkRepository;

        public DrinkController(ICategoryRepository _categoryRepository, IDrinkRepository _drinkRepository)
        {
            categoryRepository = _categoryRepository;
            drinkRepository = _drinkRepository;
        }
        public ViewResult List()
        {
            //ViewBag.Name = "Dot Net How?";
            var vm = new DrinkListViewModel();
            // var drinks = drinkRepository.Drinks;
            vm.Drinks = drinkRepository.Drinks;
            vm.CurrentCategory = "DrinkCategory";
            return View(vm);
        }
    }
}