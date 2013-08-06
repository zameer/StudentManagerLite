using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataObjects;
using BusinessObjects;

namespace StudentManagerLite.Models
{
    public class StudentRepository
    {
        // Create static data access objects
        private IStudentDao _studentDao = DataAccess.StudentDao;

        /// <summary>
        /// Get List of Students
        /// </summary>
        /// <returns>IList of Students</returns>
        public IList<Student> GetAll()
        {
            return _studentDao.GetStudents();
        }

        /// <summary>
        /// Removes specific student
        /// </summary>
        /// <param name="id">Identifier</param>
        /// <returns>No of students Deleted</returns>
        public int Delete(int id = 0)
        {
            return _studentDao.DeleteStudent(id);
        }

        /// <summary>
        /// Update specific student
        /// </summary>
        /// <param name="id">Identifier</param>
        /// <param name="student">Changed student object</param>
        public void PatchStudent(int id, Student student)
        {
            _studentDao.PatchStudent(id, student);
        }
    }
}