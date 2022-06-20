using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.BaseRepositories;
using Data.Entities;
using Data.Access;

namespace Repository.EmployeeRepositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DataContext context) : base(context) { }

        public Employee GetByAddress(string Adress)
        {
            return _Context.Set<Employee>().SingleOrDefault(x => x.Address == Adress);
        }

        public Employee GetByEmailAdress(string EmailAdress)
        {
            return _Context.Set<Employee>().SingleOrDefault(x => x.EmailAdress == EmailAdress);
        }

        public Employee GetByFirstName(string Firstname)
        {
            return _Context.Set<Employee>().SingleOrDefault(x => x.Firstname == Firstname);
        }

        public Employee GetByLastName(string LastName)
        {
            return _Context.Set<Employee>().SingleOrDefault(x => x.Lastname == LastName);
        }

        public Employee GetByPersonalNumber(string PersonalNumber)
        {
            return _Context.Set<Employee>().SingleOrDefault(x => x.PersonalNumber == PersonalNumber);
        }

        public Employee GetByPhoneNumber(string PhoneNumber)
        {
            return _Context.Set<Employee>().SingleOrDefault(x => x.PhoneNumber == PhoneNumber);
        }
    }
}
