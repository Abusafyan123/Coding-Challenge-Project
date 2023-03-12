using CodingChallenge.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingChallenge.Domain;
using CodingChallenge.Service.Interfaces;
using System.Web;

namespace CodingChallenge.Service.Implementation
{
    public class SHIPMENT_RATE_Service : ISHIPMENT_RATE_Service
    {
        private readonly IUnitOfWork _unitOfWork;
        public SHIPMENT_RATE_Service(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<SHIPMENT_RATE> GetAll()
        {
            var model = _unitOfWork.SHIPMENT_RATERepository.Get();
            return model;
        }

        public SHIPMENT_RATE GetById(long id)
        {
            var model = _unitOfWork.SHIPMENT_RATERepository.GetByID(id);
            return model;
        }
        public void Add(SHIPMENT_RATE SHIPMENT_RATE)
        {
            _unitOfWork.SHIPMENT_RATERepository.Insert(SHIPMENT_RATE);
            _unitOfWork.Save();
        }
        public void Update(SHIPMENT_RATE SHIPMENT_RATE)
        {
            _unitOfWork.SHIPMENT_RATERepository.Update(SHIPMENT_RATE);
            _unitOfWork.Save();
        }

        public void Delete(long id)
        {
            _unitOfWork.SHIPMENT_RATERepository.Delete(id);
            _unitOfWork.Save();
        }

        public SHIPMENT_RATE GetSHIPMENT_RATE(Func<SHIPMENT_RATE, bool> where)
        {
            return _unitOfWork.SHIPMENT_RATERepository.Get(where);
        }
    }
}
