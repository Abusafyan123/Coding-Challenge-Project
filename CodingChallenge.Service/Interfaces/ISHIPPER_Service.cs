using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingChallenge.Domain;

namespace CodingChallenge.Service.Interfaces
{
    public interface ISHIPPER_Service
    {
        IEnumerable<SHIPPER> GetAll();
        SHIPPER GetById(long id);
        void Add(SHIPPER sHIPPER);
        void Update(SHIPPER sHIPPER);
        void Delete(long id);
        SHIPPER GetSHIPPER(Func<SHIPPER, Boolean> where);
    }
}
