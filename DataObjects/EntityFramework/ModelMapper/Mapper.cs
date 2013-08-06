using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.EntityFramework.ModelMapper
{
    /// <summary>
    /// Maps Entity Framework entities to business objects and vice versa.
    /// </summary>
    public class Mapper
    {
        /// <summary>
        /// Maps student entity to student business object.
        /// </summary>
        /// <param name="entity">A student entity to be transformed.</param>
        /// <returns>A student business object.</returns>
        internal static Student Map(EntityStudent entity)
        {
            return new Student
            {
                StudentId = entity.StudentId,
                StudentName = entity.StudentName
            };
        }
    }
}
