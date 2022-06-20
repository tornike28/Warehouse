using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.BaseRepositories;
using Data.Entities;
using Data.Access;

namespace Repository.OrganizationRepositories
{
    public class OrganizationRepository : BaseRepository<Organization>, IOrganizationRepository
    {
        public OrganizationRepository(DataContext context) : base(context) { }

        public Organization GetByAddress(string Address)
        {
            return _Context.Set<Organization>().SingleOrDefault(x => x.Address == Address);
        }

        public Organization GetByCity(string City)
        {
            return _Context.Set<Organization>().SingleOrDefault(x => x.City == City);

        }

        public Organization GetByEmailAdress(string EmailAdress)
        {
            return _Context.Set<Organization>().SingleOrDefault(x => x.EmailAddress == EmailAdress);
        }

        public Organization GetByEnglishName(string EnglishName)
        {
            return _Context.Set<Organization>().SingleOrDefault(x => x.EnglishName == x.EnglishName);
        }

        public Organization GetByGPSAddress(string GPSAddress)
        {
            return _Context.Set<Organization>().SingleOrDefault(x => x.GPSAddress == x.GPSAddress);
        }

        public Organization GetByName(string Name)
        {
            return _Context.Set<Organization>().SingleOrDefault(x => x.Name == x.Name);
        }

        public Organization GetByPhoneNumber(string PhoneNumber)
        {
            return _Context.Set<Organization>().SingleOrDefault(x => x.PhoneNumber == x.PhoneNumber);
        }

        public Organization GetByPostalCode(string PostalCode)
        {
            return _Context.Set<Organization>().SingleOrDefault(x => x.PostalCode == x.PostalCode);
        }

        public Organization GetByRegion(string Region)
        {
            return _Context.Set<Organization>().SingleOrDefault(x => x.Region == x.Region);
        }

        public Organization GetByWebSite(string WebSite)
        {
            return _Context.Set<Organization>().SingleOrDefault(x => x.WebSite == x.WebSite);
        }
    }
}
