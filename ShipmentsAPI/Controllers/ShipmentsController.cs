using System.Collections.Generic;
using System.Web.Http;

namespace ShipmentsAPI.Controllers
{
    [Authorize]
    public class ShipmentsController : ApiController
    {
        [Authorize]        
        public IHttpActionResult Get()
        {
            return Ok(Shipment.CreateShipments());
        }
    }

    public class Shipment
    {
        public int ShipmentId { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }

        public static List<Shipment> CreateShipments()
        {
            List<Shipment> ShipmentList = new List<Shipment>
            {
                new Shipment {ShipmentId = 10248, Origin = "Amman", Destination = "Dubai" },
                new Shipment {ShipmentId = 10249, Origin = "Dubai", Destination = "Abu Dhabi"},
                new Shipment {ShipmentId = 10250,Origin = "Dubai", Destination = "New York"},
                new Shipment {ShipmentId = 10251,Origin = "Boston", Destination = "New Jersey"},
                new Shipment {ShipmentId = 10252,Origin = "Cairo", Destination = "Jeddah"}
            };

            return ShipmentList;
        }
    }


}
