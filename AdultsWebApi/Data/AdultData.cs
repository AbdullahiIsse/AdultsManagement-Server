using System.Collections.Generic;
using System.Threading.Tasks;
using AdultsWebApi.DataAccess;
using Microsoft.EntityFrameworkCore;
using Models;

namespace AdultsWebApi.Data
{
    public class AdultData : IAdultData
    {

      
        private AdultUserDbContext adultUserDbContext;

        public AdultData()
        {

            adultUserDbContext = new AdultUserDbContext();

        }

       

        public async Task<List<Adult>> GetAdults()
        {
            var list = await adultUserDbContext.Adults.Include(j=>j.JobTitle).ToListAsync();
            return list;

        }

        public async Task<Adult> AddAdults(Adult adult)
        {
          await  adultUserDbContext.Adults.AddAsync(adult);
          await adultUserDbContext.Jobs.AddAsync(adult.JobTitle);
          await  adultUserDbContext.SaveChangesAsync();

            return adult;
        }

        public async void RemoveAdults(int adultId)
        {
            Adult firstAsync = await adultUserDbContext.Adults.Include(j => j.JobTitle)
                .FirstAsync(adult => adult.Id == adultId);
            adultUserDbContext.Remove(firstAsync);
            await adultUserDbContext.SaveChangesAsync();

        }

        public async Task<Adult> Update(Adult adult)
        {
            adultUserDbContext.Update(adult);

            return adult;
        }

        public async Task<Adult> Get(int id)
        {
            Adult firstAsync = await adultUserDbContext.Adults.Include(j => j.JobTitle)
                .FirstAsync(adult => adult.Id == id);
            
            return firstAsync;
        }
    }
}