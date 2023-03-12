using CodingChallenge.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CodingChallenge.Service.Interfaces
{
    public interface ISystemLookupService
    {
        IEnumerable<Shipper_Shipment_Details_Result> Shipper_Shipment_Details(Int32 shipper_id);
    }
}
