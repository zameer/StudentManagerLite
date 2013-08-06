using BusinessObjects;
using DataObjects.EntityFramework.ModelMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.EntityFramework.Implementation
{
    /// <summary>
    /// Entity Framework implementation of the IStudentDao interface.
    /// </summary>
    public class EntityStudentDao : IStudentDao
    {
        /// <summary>
        /// Gets List of Students
        /// </summary>
        /// <returns>List of Students</returns>
        public IList<Student> GetStudents()
        {
            using (var context = DataObjectFactory.CreateContext())
            {
                var _list = new List<Student>();
                var students = context.Students.ToList();

                foreach(var entity in students)
                    _list.Add(Mapper.Map(entity));

                return _list;
            }
        }

        /// <summary>
        /// Remove specific student
        /// </summary>
        /// <param name="id">Unique student identifier</param>
        /// <returns>No of students Deleted</returns>
        public int DeleteStudent(int id = 0)
        {
            using (var context = DataObjectFactory.CreateContext())
            {
                var entity = context.Students.Where(s => s.StudentId == id).FirstOrDefault();
                context.Students.Remove(entity);
                return context.SaveChanges();
            }
        }

        /// <summary>
        /// Update existing student
        /// </summary>
        /// <param name="id">Unique student identifier</param>
        /// <param name="student">Unique student object</param>
        public void PatchStudent(int id, Student student)
        {
            using (var context = DataObjectFactory.CreateContext())
            {
                var entity = context.Students.Where(s => s.StudentId == id).FirstOrDefault();
                entity.StudentName = student.StudentName;
                context.SaveChanges();
            }
        }
    }
}
