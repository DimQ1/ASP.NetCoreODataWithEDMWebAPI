using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using ODataWithEDM.Model;
using ODataWithEDM.Services;

namespace ODataWithEDM.Controllers
{
    
    public class StudentsController : ODataController
    {

        [HttpGet]
        [EnableQuery(PageSize =12 )]
        public ActionResult<IEnumerable<Student>> Get()
        {
            var studentsService = new StudentsService();
            return studentsService.GetStudents();
        }
    }
}