using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerPlateExample.Dto;
using BoilerPlateExample.Dto.Employee;
using BoilerPlateExample.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Query.Internal;

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


        //-------------- GET EMPLOYEES/EMPLOYEE -----------------//
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

        [HttpGet]
        public IActionResult GetEmployeeHistory(int id)
        {
            throw new NotImplementedException();
        }

        //-------------- DROP DOWN OFFICES ----------------//
        public SelectList SelectOffices()
        {
            var officeForSelect = new OfficeListDtoForSelect(_officeService);

            var offices = officeForSelect.Offices.ToList();
            SelectList selectList = new SelectList(offices, "Id", "Description");

            return selectList;
        }



        //--------------- CREATE EMPLOYEE -------------------//
        [HttpGet]
        public IActionResult CreateEmployee()
        {
            var offices = SelectOffices();
            ViewData["DropDown"] = offices;

            return View(new EmployeePost());
        }

        [HttpPost]
        public IActionResult CreateEmployee(EmployeePost employeeDto)
        {
            
            _employeeService.Create(employeeDto);
            return RedirectToAction("GetEmployees");

        }


        //-------------- DELETE EMPLOYEE -----------------//
        [HttpPost]
        public IActionResult DeleteEmployee(int id)
        {
            _employeeService.Delete(id);

            return RedirectToAction("GetEmployees");
        }


        //-------------- UPDATE EMPLOYEE -----------------//
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

            var offices = SelectOffices();
            ViewData["DropDown"] = offices;
            // ViewBag.DropDown = new SelectList(SelectOffices());

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