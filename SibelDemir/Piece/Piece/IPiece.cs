using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piece
{
    public interface IPiece
    {
        public string Name { get; set; }
        public PieceColor Color { get; set; }
        public void Move();


    }
}
