using CodingChallenge.Domain;
namespace CodingChallenge.Repository
{
    public interface IUnitOfWork
    {

        #region CodingChallenge Tables
        GenericRepository<CARRIER> CARRIERRepository { get; }
        GenericRepository<SHIPMENT> SHIPMENTRepository { get; }
        GenericRepository<SHIPMENT_RATE> SHIPMENT_RATERepository { get; }
        GenericRepository<SHIPPER> SHIPPERRepository { get; }

        #endregion

        #region Store Procedure
        GenericRepository<Shipper_Shipment_Details_Result> Shipper_Shipment_DetailsRepository { get; }

        #endregion

        void Save();
        void Dispose();
    }
}