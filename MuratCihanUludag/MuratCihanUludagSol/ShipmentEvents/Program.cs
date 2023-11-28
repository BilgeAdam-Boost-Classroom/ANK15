namespace ShipmentEvents
{
    internal class Program
    {
        public static void ArabaDagit(string message)
        {
            Console.WriteLine($"Araba ile {message}");
        }
        public static void KamyonetDagit(string message)
        {
            Console.WriteLine($"Kamyonet ile {message}");
        }
        static void Main(string[] args)
        {
            Shipment shipment = new Shipment();
            //Kargocu bu olai 5 karakterli kargo numarasi verilmezse firlatmaz
            //dolayisila dagit methodu da calismaz!!!

            //shipment.ShipmentEvent += (string message) =>
            //{
            //    Console.WriteLine();
            //};

            shipment.ShipmentEvent += ArabaDagit;
            shipment.ShipmentEvent += KamyonetDagit;

            shipment.ShipmentEvent -= ArabaDagit;

            shipment.TrackingNumber = "A1234";
        }
    }
}