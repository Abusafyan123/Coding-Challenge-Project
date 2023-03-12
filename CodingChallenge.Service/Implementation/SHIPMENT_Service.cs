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
    public class SHIPMENT_Service : ISHIPMENT_Service
    {
        private readonly IUnitOfWork _unitOfWork;
        public SHIPMENT_Service(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<SHIPMENT> GetAll()
        {
            var model = _unitOfWork.SHIPMENTRepository.Get();
            return model;
        }

        public SHIPMENT GetById(long id)
        {
            var model = _unitOfWork.SHIPMENTRepository.GetByID(id);
            return model;
        }
        public void Add(SHIPMENT SHIPMENT)
        {
            _unitOfWork.SHIPMENTRepository.Insert(SHIPMENT);
            _unitOfWork.Save();
        }
        public void Update(SHIPMENT SHIPMENT)
        {
            _unitOfWork.SHIPMENTRepository.Update(SHIPMENT);
            _unitOfWork.Save();
        }

        public void Delete(long id)
        {
            _unitOfWork.SHIPMENTRepository.Delete(id);
            _unitOfWork.Save();
        }

        public SHIPMENT GetSHIPMENT(Func<SHIPMENT, bool> where)
        {
            return _unitOfWork.SHIPMENTRepository.Get(where);
        }
    }
}
