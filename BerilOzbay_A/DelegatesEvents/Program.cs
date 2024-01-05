
namespace DelegatesEvents
{
    public class Program
    {
        static void Dagit(string mesaj)
        {
            Console.WriteLine(mesaj);
        }
        static void Main(string[] args)
        {
            Shipment shipment = new Shipment();
            shipment.ShipmentEvent += Dagit;
            shipment.TrackingNumber = "ABC12";
 
        }
    }
}