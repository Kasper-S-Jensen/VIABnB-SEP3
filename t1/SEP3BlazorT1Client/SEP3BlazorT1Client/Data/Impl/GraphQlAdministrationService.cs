using System.Collections.Generic;
using System.Threading.Tasks;
using SEP3BlazorT1Client.Models;

namespace SEP3BlazorT1Client.Data.Impl
{
    public class GraphQlAdministrationService : IAdministrationService
    {
        public Task<Administrator> GetAdminByEmail(string email)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Administrator>> GetAllAdmins()
        {
            throw new System.NotImplementedException();
        }
    }
}