using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    /// <summary>
    /// Defines methods to access students
    /// </summary>
    /// <remarks>
    /// This is a database independent interface, implementations are database specific
    /// </remarks>
    public interface IStudentDao
    {
        /// <summary>
        /// Gets List of Students
        /// </summary>
        /// <returns>List of Students</returns>
        IList<Student> GetStudents();

        /// <summary>
        /// Remove specific student
        /// </summary>
        /// <param name="id">Unique student identifier</param>
        /// <returns>No of students Deleted</returns>
        int DeleteStudent(int id = 0); 

        /// <summary>
        /// Update existing student
        /// </summary>
        /// <param name="id">Unique student identifier</param>
        /// <param name="student">Unique student object</param>
        void PatchStudent(int id, Student student);
    }
}
