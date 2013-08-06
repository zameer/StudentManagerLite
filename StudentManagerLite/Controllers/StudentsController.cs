using BusinessObjects;
using StudentManagerLite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentManagerLite.Controllers
{
    public class StudentsController : ApiController
    {
        readonly StudentRepository _studentsRepository = new StudentRepository();

        // GET api/students
        public IEnumerable<Student> Get()
        {
            return _studentsRepository.GetAll();
        }

        // PUT api/students/5
        public void Put(int id, Student student)
        {
            _studentsRepository.PatchStudent(id, student); ;
        }

        // DELETE api/students/5
        public void Delete(int id)
        {
            _studentsRepository.Delete(id); ;
        }
    }
}
