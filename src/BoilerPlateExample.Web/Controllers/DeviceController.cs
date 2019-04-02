using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerPlateExample.Dto;
using BoilerPlateExample.Dto.Device;
using BoilerPlateExample.Dto.Office;
using BoilerPlateExample.Interfaces;
using BoilerPlateExample.Web.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BoilerPlateExample.Web.Controllers
{
    public class DeviceController : BoilerPlateExampleControllerBase
    {
        private readonly IDeviceService _deviceService;

        protected readonly IEmployeeService _employeeService;

        public DeviceController(IDeviceService deviceService, IEmployeeService employeeService)
        {
            _deviceService = deviceService;
            _employeeService = employeeService;
        }

        //-------------- GET DEVICES/DEVICE -----------------//
        public IActionResult GetDevices()
        {
            var result = _deviceService.GetAll();
            return View(result);
        }

        [HttpGet]
        public IActionResult GetDevice(int? id)
        {
            DeviceGet device = null;
            if (id.HasValue)
            {
                device = _deviceService.Get(id.Value);
            }

            return View(device);
        }

        [HttpGet]
        public IActionResult GetDeviceHistory(int id)
        {
            var result = _deviceService.GetDeviceHistory(id);
            return View(result);
        }


        //------------ DROP DOWN EMPLOYEES --------------//
        public SelectList SelectEmployees()
        {
            var employeesForSelect = new EmployeeListDtoForSelect(_employeeService);

            var employees = employeesForSelect.Employees.Employees.ToList();

            var selectEmployees = employees.Select(x => new
            {
                Id = x.Id,
                FullName = x.FirstName + " " + x.LastName
            });

            SelectList selectList = new SelectList(selectEmployees, "Id", "FullName");

            return selectList;
        }


        //--------------- CREATE DEVICE -------------------//
        [HttpGet]
        public IActionResult CreateDevice()
        {
            var employees = SelectEmployees();
            ViewData["DropDown"] = employees;

            return View(new DevicePost());
        }

        [HttpPost]
        public IActionResult CreateDevice(DevicePost deviceDto)
        {

            _deviceService.Create(deviceDto);
            return RedirectToAction("GetDevices");

        }


        //---------------- DELETE DEVICE ----------------//
        [HttpPost]
        public IActionResult DeleteDevice(int id)
        {
            _deviceService.Delete(id);

            return RedirectToAction("GetDevices");
        }


        //-------------- UPDATE DEVICE -----------------//
        [HttpGet]
        public IActionResult UpdateDevice(int id)
        {
            var device = _deviceService.GetDeviceById(id);

            DevicePost newDevicePost = new DevicePost
            {
                Name = device.Name,
                EmployeeId = device.EmployeeId
            };

            var employees = SelectEmployees();
            ViewData["DropDown"] = employees;
            // ViewBag.DropDown = new SelectList(SelectOffices());

            return View(newDevicePost);
        }

        [HttpPost]
        public IActionResult UpdateDevice(int id, DevicePost dto)
        {
            _deviceService.Update(id, dto);

            return RedirectToAction("GetDevices");
        }


    }
}