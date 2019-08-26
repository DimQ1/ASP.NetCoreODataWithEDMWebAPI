using ODataWithEDM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataWithEDM.Services
{
    public class StudentsService
    {
        public List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student()
                {
                     Id = Guid.NewGuid(),
                     Name = "David Pullara",
                     Score = 100
                },
                new Student()
                {
                    Id = Guid.NewGuid(),
                    Name = "Tod Ostermeir",
                    Score = 120
                },
                new Student()
                {
                    Id = Guid.NewGuid(),
                    Name = "Trevor Richardson",
                    Score = 110
                }
            };
        }
    }
}
