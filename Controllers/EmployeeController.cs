using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using EmployeeCrudManager;
using EmployeeCrudManager.Models;
using EmployeeCrudManager.Storage;

namespace EmployeeWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private EmpMgtSys _eManager;
        public EmployeeController(EmpMgtSys eManager){
            
        _eManager =eManager;
    }
    // display of all employees
        [HttpGet]
        public List<EmployeeInformation> GetEmployee()
        {
            return _eManager.Print();
        }
    //  employee created
        [HttpPost]
        public string Create(EmployeeInformation employee){
            _eManager.Create(employee.FirstName, employee.LastName, employee.Age, employee.Designation, employee.Salary);
            return "employee created";
            
        }
        
    }
}
