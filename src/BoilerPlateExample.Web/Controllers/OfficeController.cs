using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerPlateExample.Web.Views;
using Microsoft.AspNetCore.Mvc;

namespace BoilerPlateExample.Web.Controllers
{
    public class OfficeController : BoilerPlateExampleControllerBase
    {
        private readonly IFirstService _firstService;

        public OfficeController(IFirstService firstService)
        {
            _firstService = firstService;
        }

        public async Task<ActionResult> Index()
        {
            var result = await _firstService.GetAll();
            var model = new IndexViewModel(result);
            return View(model);
        }
    }
}
