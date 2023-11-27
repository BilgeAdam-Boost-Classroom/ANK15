using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev6Soru3
{
    public class Queen:IPiece
    {
        public string Name { get; set ; }
        public PieceColor Color { get ; set ; }

        void Move()
        {
            Console.WriteLine("Rook + BiShop");
        }
    }
}
