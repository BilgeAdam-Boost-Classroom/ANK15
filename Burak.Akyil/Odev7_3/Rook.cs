using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Odev7_3.IPiece;

namespace Odev7_3
{
    public class Rook : IPiece
    {
        public string Name { get; set; } = "Kale";
        public PieceColor Color { get ; set ; }
        public void Move()
        {
            Console.WriteLine("Ranks and files only.");
        }
    }
}
