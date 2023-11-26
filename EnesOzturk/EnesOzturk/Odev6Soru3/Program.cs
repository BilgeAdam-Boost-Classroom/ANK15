using System.Drawing;

namespace Odev6Soru3
{
    public class Program
    {

        static void Main(string[] args)

        {    Random rnd = new Random();
            int sayi = rnd.Next(0, 5);
            List<IPiece> Pieces = new List<IPiece>();

            string deger = Console.ReadLine();
           
            do
            {
                Console.WriteLine("Çıkmak için H/h basınız ");
               
             
              

                    if (sayi == 0)
                    {
                        Pawn pawn = new Pawn();
                        pawn.Name = " piyon";
                        pawn.Color = PieceColor.White;
                        pawn.Promote();
                        Pieces.Add(pawn);

                    }
                    else if (sayi == 1)
                    {
                        Rook rook = new Rook();
                        rook.Name = "kale";
                        rook.Color = PieceColor.Black;
                        Pieces.Add(rook);
                    }
                    else if (sayi == 2)
                    {
                        Knight knight = new Knight();
                        knight.Name = "At";
                        knight.Color = PieceColor.White;
                        Pieces.Add(knight);
                    }
                    else if (sayi == 3)
                    {
                        Bishop bishop = new Bishop();
                        bishop.Name = "Fil";
                        bishop.Color = PieceColor.Black;
                        Pieces.Add(bishop);
                    }
                    else if (sayi == 4)
                    {
                        Queen queen = new Queen();
                        queen.Name = "Vezir";
                        queen.Color = PieceColor.White;
                        Pieces.Add(queen);
                    }
                    else if (sayi == 5)
                    {
                        King_ king_ = new King_();
                        king_.Name = "Şah";
                        king_.Color = PieceColor.White;
                        Pieces.Add(king_);
                    break;
                    }

                    foreach (var item in Pieces)
                    {
                        Console.WriteLine(item.Name);
                        Console.WriteLine(item.Color);
                        item.Move();
                    }
                

                
            }while (deger=="H".ToLower()) ;

        }
}   }

              
    
  