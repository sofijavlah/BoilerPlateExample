using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.UI.Inputs;
using BoilerPlateExample.Dto;
using BoilerPlateExample.Models;
using BoilerPlateExample.Web.Views;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BoilerPlateExample.Web.Controllers
{
    public class OfficeController : BoilerPlateExampleControllerBase
    {
        private readonly IOfficeService _officeService;

        public OfficeController(IOfficeService officeService)
        {
            _officeService = officeService;
        }

        public IActionResult GetOffices()
        {
            //var result =  _officeService.GetAll();
            //var model = new List<OfficeDto> OfficeListDto(result);
            //return View(model);
            return Ok();
        }


        [HttpGet]
        public IActionResult GetOffice(int? id)
        {
            OfficeDto office = null;
            if (id.HasValue)
            {
                office = _officeService.Get(id.Value);
            }

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

        [HttpGet]
        public IActionResult DeleteOffice()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteOffice(int id)
        {
            _officeService.Delete(id);

            return RedirectToAction("GetOffices");
        }

        [HttpGet]
        public IActionResult UpdateOffice()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateOffice(int id, OfficeDto dto)
        {
            _officeService.Update(id, dto);

            return RedirectToAction("GetOffices");
        }
    }
}
