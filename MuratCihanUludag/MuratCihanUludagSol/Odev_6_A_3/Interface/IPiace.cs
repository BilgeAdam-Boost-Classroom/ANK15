using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_6_A_3
{
    public interface IPiace
    {
        public string Name { get; set; }
        public PieceColor Color { get; set; }
        public void Move();
    }
}
