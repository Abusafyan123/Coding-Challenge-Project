//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodingChallenge.Domain
{
    using System;
    
    public partial class Shipper_Shipment_Details_Result
    {
        public int shipment_id { get; set; }
        public string shipment_description { get; set; }
        public decimal shipment_weight { get; set; }
        public string shipper_name { get; set; }
        public string carrier_name { get; set; }
        public string shipment_rate_description { get; set; }
    }
}