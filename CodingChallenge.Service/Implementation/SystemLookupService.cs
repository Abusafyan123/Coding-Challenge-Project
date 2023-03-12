using CodingChallenge.Domain;
using CodingChallenge.Repository;
using CodingChallenge.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Service.Implementation
{
    public class SystemLookupService : ISystemLookupService
    {
        private readonly IUnitOfWork _unitOfWork;
        public SystemLookupService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Shipper_Shipment_Details_Result> Shipper_Shipment_Details(int shipper_id)
        {
            return _unitOfWork.Shipper_Shipment_DetailsRepository.ExecWithStoreProcedure("Shipper_Shipment_Details " + shipper_id).ToList();
        }

    }
}
