﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev6Soru3
{
    public class Pawn : IPiece
    {
        public string Name { get ; set ; }
        public PieceColor Color { get; set ; }

       public void Move()
        {
            Console.WriteLine("Two forward at the beginning or one forward");
        }
       public void Promote()
        {
            Console.WriteLine("Can promote to rook ,knight ,bishop or queen");
        }


    }
}