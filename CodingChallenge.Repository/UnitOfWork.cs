using CodingChallenge.Domain;
using System;
namespace CodingChallenge.Repository
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private CodingChallengeDBEntities context = new CodingChallengeDBEntities();

        #region CodingChallenge Tables

        private GenericRepository<CARRIER> _CARRIERRepository;
        public GenericRepository<CARRIER> CARRIERRepository
        {
            get
            {
                if (this._CARRIERRepository == null)
                {
                    this._CARRIERRepository = new GenericRepository<CARRIER>(context);
                }
                return _CARRIERRepository;
            }
        }

        private GenericRepository<SHIPMENT> _SHIPMENTRepository;
        public GenericRepository<SHIPMENT> SHIPMENTRepository
        {
            get
            {
                if (this._SHIPMENTRepository == null)
                {
                    this._SHIPMENTRepository = new GenericRepository<SHIPMENT>(context);
                }
                return _SHIPMENTRepository;
            }
        }

        private GenericRepository<SHIPMENT_RATE> _SHIPMENT_RATERepository;
        public GenericRepository<SHIPMENT_RATE> SHIPMENT_RATERepository
        {
            get
            {
                if (this._SHIPMENT_RATERepository == null)
                {
                    this._SHIPMENT_RATERepository = new GenericRepository<SHIPMENT_RATE>(context);
                }
                return _SHIPMENT_RATERepository;
            }
        }

        private GenericRepository<SHIPPER> _SHIPPERRepository;
        public GenericRepository<SHIPPER> SHIPPERRepository
        {
            get
            {
                if (this._SHIPPERRepository == null)
                {
                    this._SHIPPERRepository = new GenericRepository<SHIPPER>(context);
                }
                return _SHIPPERRepository;
            }
        }




        #endregion

        #region Store Procedure

        private GenericRepository<Shipper_Shipment_Details_Result> _Shipper_Shipment_DetailsRepository;
        public GenericRepository<Shipper_Shipment_Details_Result> Shipper_Shipment_DetailsRepository
        {
            get
            {
                if (this._Shipper_Shipment_DetailsRepository == null)
                {
                    this._Shipper_Shipment_DetailsRepository = new GenericRepository<Shipper_Shipment_Details_Result>(context);
                }
                return _Shipper_Shipment_DetailsRepository;
            }
        }


        #endregion

        ////////////////////////////refreral tables services///////////////////

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
