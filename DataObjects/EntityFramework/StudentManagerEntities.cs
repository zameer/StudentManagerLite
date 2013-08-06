using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.EntityFramework
{
    /// <summary>
    /// POCO: StudentManagerEntities
    /// </summary>
    /// <remarks>
    /// When running DataObjects library to generate or update database
    /// this will use App.config connectionStrings 'StudentManagerLite'
    /// </remarks>
    public class StudentManagerEntities : DbContext
    {
        /// <summary>
        /// This constructor will help to init with default connectionstring
        /// </summary>
        public StudentManagerEntities() : base("name=StudentManagerLite") { }

        public DbSet<EntityStudent> Students { get; set; }
    }
}
