using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Odev6Soru3
{
    public class King_:IPiece
    {
        public string Name { get ; set; }
        public PieceColor Color { get ; set ; }

        void Move()
        {
            Console.WriteLine("Rook + BiShop + One");
        }

    }
}
