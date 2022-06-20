using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.BaseRepositories;
using Data.Entities;

namespace Repository.OrganizationRepositories
{
    public interface IOrganizationRepository : IBaseRepository<Organization>
    {
        Organization GetByName(string Name);
        Organization GetByEnglishName(string EnglishName);
        Organization GetByCity(string City);
        Organization GetByRegion(string Region);
        Organization GetByPostalCode(string PostalCode);
        Organization GetByAddress(string Address);
        Organization GetByGPSAddress(string GPSAddress);
        Organization GetByPhoneNumber(string PhoneNumber);
        Organization GetByEmailAdress(string EmailAdress);
        Organization GetByWebSite(string WebSite);    }
}
