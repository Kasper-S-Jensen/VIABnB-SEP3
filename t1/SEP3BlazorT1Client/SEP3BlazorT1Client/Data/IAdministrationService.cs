using System.Collections.Generic;
using System.Threading.Tasks;
using SEP3BlazorT1Client.Models;

namespace SEP3BlazorT1Client.Data
{
    public interface IAdministrationService
    {
        Task<Administrator> GetAdminByEmail(string email);
        Task<IEnumerable<Administrator>> GetAllAdmins();
        Task<Administrator> ValidateAdmin(string email, string password);
    }
}