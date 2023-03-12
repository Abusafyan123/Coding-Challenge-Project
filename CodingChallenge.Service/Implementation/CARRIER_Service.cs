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
    public class CARRIER_Service : ICARRIER_Service
    {
        private readonly IUnitOfWork _unitOfWork;
        public CARRIER_Service(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<CARRIER> GetAll()
        {
            var model = _unitOfWork.CARRIERRepository.Get();
            return model;
        }

        public CARRIER GetById(long id)
        {
            var model = _unitOfWork.CARRIERRepository.GetByID(id);
            return model;
        }
        public void Add(CARRIER CARRIER)
        {
            _unitOfWork.CARRIERRepository.Insert(CARRIER);
            _unitOfWork.Save();
        }
        public void Update(CARRIER CARRIER)
        {
            _unitOfWork.CARRIERRepository.Update(CARRIER);
            _unitOfWork.Save();
        }

        public void Delete(long id)
        {
            _unitOfWork.CARRIERRepository.Delete(id);
            _unitOfWork.Save();
        }

        public CARRIER GetCARRIER(Func<CARRIER, bool> where)
        {
            return _unitOfWork.CARRIERRepository.Get(where);
        }
    }
}
