using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingChallenge.Domain;

namespace CodingChallenge.Service.Interfaces
{
    public interface ISHIPMENT_RATE_Service
    {
        IEnumerable<SHIPMENT_RATE> GetAll();
        SHIPMENT_RATE GetById(long id);
        void Add(SHIPMENT_RATE sHIPMENT_RATE);
        void Update(SHIPMENT_RATE sHIPMENT_RATE);
        void Delete(long id);
        SHIPMENT_RATE GetSHIPMENT_RATE(Func<SHIPMENT_RATE, Boolean> where);
    }
}
