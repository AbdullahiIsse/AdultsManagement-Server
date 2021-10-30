using System.Collections.Generic;
using System.Linq;
using FileData;
using Models;

namespace DNP_Assignment.Data
{
    public class AdultData : IAdultData
    {

      
        private FileContext adultFileContext;

        public AdultData()
        {

            adultFileContext = new FileContext();

        }

       

        public IList<Adult> GetAdults()
        {
           
            return adultFileContext.Adults;
            
        }

        public Adult AddAdults(Adult adult)
        {
            int max = adultFileContext.Adults.Max(adult => adult.Id);
            adult.Id =(++max);
            adultFileContext.Adults.Add(adult);
            adultFileContext.SaveChanges();

            return adult;
        }

        public void RemoveAdults(int adultId)
        {
            
            Adult toRemove = adultFileContext.Adults.First(a => a.Id == adultId);
            adultFileContext.Adults.Remove(toRemove);
            adultFileContext.SaveChanges();
        }

        public Adult Update(Adult adult)
        {
            adultFileContext.Update(adult);

            return adult;
        }

        public Adult Get(int id)
        {
            return adultFileContext.Adults.FirstOrDefault(a => a.Id == id);
        }
    }
}