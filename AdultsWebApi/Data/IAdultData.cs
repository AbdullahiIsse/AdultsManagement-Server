using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace DNP_Assignment.Data
{
    public interface IAdultData
    {
        IList<Adult> GetAdults();

        Adult AddAdults(Adult adult);

        void RemoveAdults(int adultId);

        Adult Update(Adult adult);

        Adult Get(int id);








    }
}