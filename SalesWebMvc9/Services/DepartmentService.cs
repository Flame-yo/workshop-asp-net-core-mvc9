using SalesWebMvc9.Data;
using SalesWebMvc9.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc9.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvc9Context _context;

        public DepartmentService(SalesWebMvc9Context context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
