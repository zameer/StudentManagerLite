using DataObjects.EntityFramework.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    /// <summary>
    /// This class shields the client from the details of database specific 
    /// data-access objects. It returns the appropriate data-access objects 
    /// according to the configuration in web.config.
    /// </summary>
    /// <remarks>
    /// GoF Design Patterns: Factory, Singleton, Proxy.
    /// 
    /// This class makes extensive use of the Factory pattern in determining which 
    /// database specific DAOs (Data Access Objects) to return.
    /// 
    /// This class is like a Singleton -- it is a static class and 
    /// therefore only one 'instance' will ever exist.
    /// 
    /// This class is a Proxy as it 'stands in' for the actual Data Access Object Factory.
    /// </remarks>
    public static class DataAccess
    {
        // The static field initializers below are thread safe.
        private static readonly IDaoFactory _factory = new EntityDaoFactory();

        /// <summary>
        /// Gets a provider-specific student data access object.
        /// </summary>
        public static IStudentDao StudentDao
        {
            get { return _factory.StudentDao; }
        }
    }
}
