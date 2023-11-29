namespace Piece
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPiece> Pieces = new List<IPiece>();
            PieceColor[] color=new PieceColor[2] {PieceColor.White,PieceColor.Black};


            Random random = new Random();
            while (true)
            {
                Console.WriteLine("çıkmak için H/h.Devam etmek için bir tuşa basınız.");
                if (Console.ReadKey().Key == ConsoleKey.H)
                    break;

                int sayi=random.Next(0, 6);
                int Color = random.Next(0, 2);
                switch (sayi)
                {
                    case 0:
                        Pawn piyon=new Pawn();
                        piyon.Name = "piyon";
                        piyon.Color = color[Color];
                        Pieces.Add(piyon);
                        break;
                    case 1:
                        Rook kale = new Rook();
                        kale.Name = "kale";
                        kale.Color = color[Color];
                        Pieces.Add(kale);
                        break;
                    case 2:
                        Knight at  = new Knight();
                        at.Name = "at";
                        at.Color = color[Color];
                        Pieces.Add(at);
                        break;
                    case 3:
                        Bishop fil = new Bishop();
                        fil.Name = "fil";
                        fil.Color = color[Color];
                        Pieces.Add(fil);
                        break;
                    case 4:
                        Queen vezir = new Queen();
                        vezir.Name = "vezir";
                        vezir.Color = color[Color];
                        Pieces.Add(vezir);
                        break;
                    case 5:
                        King sah = new King();
                        sah.Name = "şah";
                        sah.Color = color[Color];
                        Pieces.Add(sah);
                        break;
                    default:
                        break;
                }
            }
            foreach (var item in Pieces)
            {
                Console.WriteLine(" ");
                Console.WriteLine("---------------------");
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Color);
                item.Move();
                Console.WriteLine("---------------------");
            }

        }
    }
}