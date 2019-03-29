using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerPlateExample.Dto;
using BoilerPlateExample.Dto.Employee;
using BoilerPlateExample.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BoilerPlateExample.Web.Controllers
{
    public class EmployeeController : BoilerPlateExampleControllerBase
    {
        private readonly IEmployeeService _employeeService;

        private readonly IOfficeService _officeService;

        public EmployeeController(IEmployeeService employeeService, IOfficeService officeService)
        {
            _employeeService = employeeService;
            _officeService = officeService;
        }

        public IActionResult GetEmployees()
        {
            var result = _employeeService.GetAll();
            return View(result);
        }

        [HttpGet]
        public IActionResult GetEmployee(int? id)
        {
            EmployeeGet employee= null;
            if (id.HasValue)
            {
                employee = _employeeService.Get(id.Value);
            }

            return View(employee);
        }


        public SelectList SelectOffices()
        {
            var offices = _officeService.GetAll();

            SelectList list = new SelectList(offices, "id", "description");

            return list;
        }

        [HttpGet]
        public IActionResult CreateEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateEmployee(EmployeePost employeeDto)
        {
            _employeeService.Create(employeeDto);
            return RedirectToAction("GetEmployees");
        }

        [HttpGet]
        public IActionResult DeleteEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteEmployee(int id)
        {
            _employeeService.Delete(id);

            return RedirectToAction("GetEmployees");
        }

        [HttpGet]
        public IActionResult UpdateEmployee(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);
            EmployeePost newEmployeePost = new EmployeePost
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                OfficeId = employee.OfficeId
            };
            ViewData["DropDown"] = SelectOffices();
            return View(newEmployeePost);
        }

        [HttpPost]
        public IActionResult UpdateEmployee(int id, EmployeePost dto)
        {
            _employeeService.Update(id, dto);

            return RedirectToAction("GetEmployees");
        }
    }
}