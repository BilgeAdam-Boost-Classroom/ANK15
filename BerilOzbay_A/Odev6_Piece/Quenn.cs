using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev6_Piece
{
    public class Quenn : IPiece
    {
        public string Name { get ; set ; }
        public PieceColor Color { get ; set ; }

        public void Move()
        {
            Console.WriteLine("Rook + Bishop");
        }
    }
}
