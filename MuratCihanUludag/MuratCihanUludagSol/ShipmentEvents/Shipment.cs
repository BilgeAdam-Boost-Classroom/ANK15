using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentEvents
{
    // Kargonun bilgileri ve  gonderilmesi ile ilgili sinif
    internal class Shipment
    {
        // Amac : Kargoya kargo numarasi verildigi zaman  Olayi gerceklessin...!!
        //Once bir event tanimlayin. Neden?
        // Kargoya kargo numarasi verildigi zaman bu event calissin.
        //Event tanimimiz:

        public event ShipmentHandler ShipmentEvent; //adini biz verdik
        //Kargo numarasi verildigi  ShipmentEvent calistiracagiz.


        public delegate void ShipmentHandler(string info); //adini biz verdik.

        private string _trackingNumber;
        public string TrackingNumber {
            //get olmasin disaridan gorulmesin ama deger atandigi zaman  olayini calistirsin.
            set 
            {
                if (value.Length == 5)
                {
                    _trackingNumber = value;
                    // Olayini meydana getir.
                    if (ShipmentEvent != null)
                        ShipmentEvent("Kargo gonderildi");
                }
            } 
        }    

    }
}
