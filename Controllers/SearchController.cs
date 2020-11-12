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
    public class SearchController : ControllerBase
    {
        
        private EmpMgtSys _eManager;

        public SearchController(EmpMgtSys eManager){
            _eManager =eManager;
        }
        //  employee finder
        [HttpGet]
        public EmployeeInformation Search(string name){
            var result = GenericFunc.regexChecker(name);
            
            if(result!=null){
                return _eManager.Search(result);
            }
            else{
                throw new Exception("please enter valid name");
            }
          
        }

    }
}
