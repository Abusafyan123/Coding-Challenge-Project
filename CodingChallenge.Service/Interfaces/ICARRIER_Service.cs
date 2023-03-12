using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingChallenge.Domain;

namespace CodingChallenge.Service.Interfaces
{
    public interface ICARRIER_Service
    {
        IEnumerable<CARRIER> GetAll();
        CARRIER GetById(long id);
        void Add(CARRIER cARRIER);
        void Update(CARRIER cARRIER);
        void Delete(long id);
        CARRIER GetCARRIER(Func<CARRIER, Boolean> where);
    }
}
