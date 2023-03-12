using CodingChallenge.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodingChallenge.WebUI.Controllers
{
    public class HomeController : Controller
    {

        private readonly ISHIPPER_Service _SHIPPER_Service;
        private readonly ISystemLookupService _SystemLookupService;
        public HomeController(ISHIPPER_Service SHIPPER_Service,
            ISystemLookupService SystemLookupService)
        {
            _SHIPPER_Service = SHIPPER_Service;
            _SystemLookupService = SystemLookupService;
        }
        public ActionResult Index()
        {
            return View();
        }

        #region Shipper List

        public ActionResult GetShipper()
        {
            return View(_SHIPPER_Service.GetAll().OrderBy(x => x.shipper_name));
        }


        #endregion

        #region Sipper Shioment Detail

        public ActionResult GetShipperShipmentDetail(int Id)
        {
            return View(_SystemLookupService.Shipper_Shipment_Details(Id).ToList());
        }


        #endregion

    }
}