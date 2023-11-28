using System.Security.Cryptography.X509Certificates;
using static Odev7_3.IPiece;

namespace Odev7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            List<IPiece> pieces = new List<IPiece>();
            char devam;
            int rastgeleTas, rastgeleRenk;
            Random rastgele = new Random();
            PieceColor[] renkler = new PieceColor[2] {PieceColor.White,PieceColor.Black};
            List<int> tekrarlar = new List<int>() { 0, 0, 0, 0, 0, 0 };
            IPiece[] taslar = new IPiece[]
            {
                new Pawn(), new Rook(), new Knight(), new Bishop(), new King(), new Queen()
            };
            IPiece olusturulanTas;
            List<IPiece> olusturulanTaslar = new List<IPiece>();
            do
            {
                rastgeleTas = rastgele.Next(0, 6);
                rastgeleRenk = rastgele.Next(0, 2);
                tekrarlar[rastgeleTas]++;
                switch (rastgeleTas)
                {
                    case 0:
                        Pawn pawn = new Pawn();
                        pawn.Color = renkler[rastgeleRenk];
                        olusturulanTaslar.Add(pawn);
                        break;
                    case 1:
                        Rook rook = new Rook();
                        rook.Color = renkler[rastgeleRenk];
                        olusturulanTaslar.Add(rook);
                        break;
                    case 2:
                        Knight knight = new Knight();
                        knight.Color = renkler[rastgeleRenk];
                        olusturulanTaslar.Add(knight);
                        break;
                    case 3:
                        Bishop bishop = new Bishop();
                        bishop.Color = renkler[rastgeleRenk];
                        olusturulanTaslar.Add(bishop);
                        break;
                    case 4:
                        King king = new King();
                        king.Color = renkler[rastgeleRenk];
                        olusturulanTaslar.Add(king);
                        break;
                    case 5:
                        Queen queen = new Queen();
                        queen.Color = renkler[rastgeleRenk];
                        olusturulanTaslar.Add(queen);
                        break;
                }
                        






                Console.WriteLine("Çıkış için H/h, taş eklemek için herhangi bir tuşa basınız.");
                devam = Convert.ToChar(Console.ReadLine());

            } 
            while (Char.ToLower(devam) != 'h');
            int ilkTekrarEdenTasİndisi = tekrarlar.IndexOf(tekrarlar.Max());
            foreach (var tas in olusturulanTaslar)
            {
                Console.WriteLine(tas.Name);
                Console.WriteLine(tas.Color);
                if(tas is Pawn)
                {
                    ((Pawn)(tas)).Promote();
                }
                Console.WriteLine("-----------------");
            }
            Console.WriteLine("En çok tekrar eden ilk taş: " + taslar[ilkTekrarEdenTasİndisi].Name);

        }
    }
}