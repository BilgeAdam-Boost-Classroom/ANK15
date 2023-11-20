namespace Odev4
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Kopek kopek = new Kopek();
          
            Console.WriteLine(kopek.SesCikar());
            Kedi kedi= new Kedi();
           
            Console.WriteLine(kedi.SesCikar());

          
            Canli canli = new Canli();
             Console.WriteLine(canli.SesCikar());
       

        }
    }
}