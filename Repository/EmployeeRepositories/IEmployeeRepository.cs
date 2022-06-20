using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Repository.BaseRepositories;

namespace Repository.EmployeeRepositories
{
    public interface IEmployeeRepository : IBaseRepository<Employee>
    {
        Employee GetByFirstName(string FirstName);
        Employee GetByLastName(string LastName);
        Employee GetByPersonalNumber(string PersonalNumber);
        Employee GetByAddress(string Adress);
        Employee GetByPhoneNumber(string PhoneNumber);
        Employee GetByEmailAdress(string EmailAdress);
    }
}