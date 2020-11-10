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
       public EmployeeController(){
           var employeeStorage =new EmpStorageLists();
            
            Console.WriteLine("Welcome to the Employee Manager!!\n");

            // creating an instance of employee mgt storage which is the main class
             _eManager = new EmpMgtSys(employeeStorage);

            // user input class's input method called
            // EmpUserInput.Input(eManager);
        
       }
        [HttpGet]
        public List<EmployeeInformation> Get()
        {
           return _eManager.Print();
        }
        // [HttpGet]
        // public EmployeeInformation Search(string input){
        //     return _eManager.Search(input);
        // }
    }
}
