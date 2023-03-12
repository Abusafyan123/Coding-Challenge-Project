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
    public class SHIPPER_Service : ISHIPPER_Service
    {
        private readonly IUnitOfWork _unitOfWork;
        public SHIPPER_Service(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<SHIPPER> GetAll()
        {
            var model = _unitOfWork.SHIPPERRepository.Get();
            return model;
        }

        public SHIPPER GetById(long id)
        {
            var model = _unitOfWork.SHIPPERRepository.GetByID(id);
            return model;
        }
        public void Add(SHIPPER SHIPPER)
        {
            _unitOfWork.SHIPPERRepository.Insert(SHIPPER);
            _unitOfWork.Save();
        }
        public void Update(SHIPPER SHIPPER)
        {
            _unitOfWork.SHIPPERRepository.Update(SHIPPER);
            _unitOfWork.Save();
        }

        public void Delete(long id)
        {
            _unitOfWork.SHIPPERRepository.Delete(id);
            _unitOfWork.Save();
        }

        public SHIPPER GetSHIPPER(Func<SHIPPER, bool> where)
        {
            return _unitOfWork.SHIPPERRepository.Get(where);
        }
    }
}
