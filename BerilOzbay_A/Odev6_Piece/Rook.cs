﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev6_Piece
{
    public class Rook : IPiece
    {
        public string Name { get ; set ; }
        public PieceColor Color { get ; set ; }

        public void Move()
        {
            Console.WriteLine("Ranks and files only");
        }
    }
}