namespace HesapMakinesi;
class Program
{
    static void Main(string[] args)
    {
     
        Toplama toplama = new Toplama(20,20);
       
        Console.WriteLine(toplama.Topla());
        
    }
}
