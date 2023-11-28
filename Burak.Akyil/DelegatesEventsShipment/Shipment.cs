using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEventsShipment
{
    public class Shipment
    {
        public delegate void ShipmentHandler(string info);
        public event ShipmentHandler ShipmentEvent;

        private string _trackingNumber;

        public string TrackingNumber
        {

            set
            {
                _trackingNumber = value;
                if(value.Length == 5)
                {
                    _trackingNumber = value;
                    ShipmentEvent("Paketiniz yola çıkmıştır.");
                }

            }
        }

    }
}
