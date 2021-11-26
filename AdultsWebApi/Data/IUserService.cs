using System.Threading.Tasks;
using AdultsWebApi.Models;

namespace AdultsWebApi.Data
{
    public interface IUserService
    {
        Task<User> ValidateUser(string userName, string Password);
       
    }
}