using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.EntityFramework
{
    /// <summary>
    /// POCO: student entity class
    /// </summary>
    public class EntityStudent
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
    }
}
