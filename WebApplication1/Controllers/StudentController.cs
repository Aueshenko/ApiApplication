using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController
    {
        //private readonly ILogger<StudentController> _logger;

        //public StudentController(ILogger<StudentController> logger)
        //{
        //    _logger = logger;
        //}

        [HttpGet(Name = "GetStudent")]
        public IEnumerable<Student> Get()
        {
            return Enumerable.Range(1, 1).Select(index => new Student
            {
                Name = "Boris",
                Age = 20,
                StudentNumber = 123456,
                Direction = "Math"
            })
            .ToArray();
        }
    }
}
