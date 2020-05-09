using System.Collections.Generic;
using System.Threading.Tasks;
using CompanyApp.API.Models;

namespace CompanyApp.API.Data
{
    public interface IEmployeeRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int id);
    }
}