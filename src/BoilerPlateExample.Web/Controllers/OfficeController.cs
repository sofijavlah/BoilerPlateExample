using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerPlateExample.Dto;
using BoilerPlateExample.Models;
using BoilerPlateExample.Web.Views;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoilerPlateExample.Web.Controllers
{
    public class OfficeController : BoilerPlateExampleControllerBase
    {
        private readonly IOfficeService _officeService;

        public OfficeController(IOfficeService firstService)
        {
            _officeService = firstService;
        }

        

        public IActionResult GetOffices()
        {
            var result =  _officeService.GetAll();
            var model = new OfficeListDto(result);
            return View(model);
        }

        [HttpGet]
        public IActionResult GetOffice()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetOffice(int id)
        {
            var office = _officeService.Get(id);

            return View(office);
        }

        [HttpGet]
        public IActionResult CreateOffice()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CreateOffice(OfficeDto officeDto)
        {
            _officeService.Create(officeDto);
            return RedirectToAction("GetOffices");
        }


    }
}
