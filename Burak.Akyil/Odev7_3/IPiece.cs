using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Odev7_3
{
    public interface IPiece
    {
        public enum PieceColor
        {
            Black,
            White
        }
        public string Name { get; set; }
        public PieceColor Color { get; set; }
        public void Move()
        {

        }
    }
}
