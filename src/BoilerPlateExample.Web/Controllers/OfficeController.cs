using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.UI.Inputs;
using BoilerPlateExample.Dto;
using BoilerPlateExample.Dto.Office;
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


        //-------------- GET OFFICES/OFFICE -----------------//
        public IActionResult GetOffices()
        {
            var result = _officeService.GetAll();
            var model = new OfficeListDto(result);
            return View(model);
        }


        [HttpGet]
        public IActionResult GetOffice(int? id)
        {
            OfficeEmployeeListDto office = null;
            if (id.HasValue)
            {
                office = _officeService.Get(id.Value);
            }

            return View(office);
        }


        //-------------- CREATE OFFICE -----------------//
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


        //-------------- DELETE OFFICE -----------------//
        [HttpPost]
        public IActionResult DeleteOffice(int id)
        {
            _officeService.Delete(id);

            return RedirectToAction("GetOffices");
        }


        //-------------- UPDATE OFFICE -----------------//
        [HttpGet]
        public IActionResult UpdateOffice(int id)
        {
            var office = _officeService.GetOfficeById(id);

            OfficeDto newOfficeDto = new OfficeDto
            {
                Description = office.Description
            };

            return View(newOfficeDto);
        }

        [HttpPost]
        public IActionResult UpdateOffice(int id, OfficeDto dto)
        {
            _officeService.Update(id, dto);

            return RedirectToAction("GetOffices");
        }
    }
}
