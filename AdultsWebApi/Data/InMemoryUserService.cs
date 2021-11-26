using System;
using System.Threading.Tasks;
using AdultsWebApi.DataAccess;
using AdultsWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AdultsWebApi.Data
{
    public class InMemoryUserService : IUserService
    {
        
        public async Task<User> ValidateUser(string userName, string Password)
        {
            try
            {
                using AdultUserDbContext adultUserDbContext = new AdultUserDbContext();
                
                User first = await adultUserDbContext.Users.FirstAsync(user => user.UserName.Equals(userName));
                
            
                if (!first.Password.Equals(Password))
                {
                    throw new Exception("Incorrect password");
                }

                return first;
            }
            catch (InvalidOperationException e)
            {
                throw new Exception("User not found");
               
            }
           
        }
    }
}