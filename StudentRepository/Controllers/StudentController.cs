using Microsoft.AspNetCore.Mvc;
using StudentRepository.Repository;
using StudentRepository.Model;

namespace StudentRepository.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class StudentController : ControllerBase
    {
        IStudentsRepository _isr;
        public StudentController(IStudentsRepository iSR)                           //Constructor of StudentController Class 
        {
            _isr=iSR;
        }
        [HttpGet("Creation")]
        public IActionResult CreateStudent(StudentsInfo studentsInfo)
        {
            _isr.Add(studentsInfo);
            return Ok("! Record Added");
        }
        [HttpPost("GetAllRecords")]
        public IActionResult FetchAllResult()
        {
            var t=_isr.getall();
            if(t==null)
            {
                return Ok("No Record Inserted");
            }
            else
            {
                return Ok(t);
            }
        }
        [HttpPut("Updation")]
        public IActionResult UpdateRecord(StudentsInfo studentsInfo)
        {
            _isr.update(studentsInfo);
            return Ok("Record Updated");
        }
    }
}