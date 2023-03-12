using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingChallenge.Domain;

namespace CodingChallenge.Service.Interfaces
{
    public interface ISHIPMENT_Service
    {
        IEnumerable<SHIPMENT> GetAll();
        SHIPMENT GetById(long id);
        void Add(SHIPMENT sHIPMENT);
        void Update(SHIPMENT sHIPPER);
        void Delete(long id);
        SHIPMENT GetSHIPMENT(Func<SHIPMENT, Boolean> where);
    }
}
