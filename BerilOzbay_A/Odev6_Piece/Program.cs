namespace Odev6_Piece
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            // Tas ve tasa ait sayac tek bir düzende tutmak için dictionary kullanılmıştır.
            Dictionary<string, int> pieceList = new Dictionary<string, int>()
            {
                { "At", 0 },
                { "Fil", 0 },
                { "Sah", 0 },
                { "Piyon", 0 },
                { "Kale", 0 },
                { "Vezir", 0 }
            };

            List<IPiece> pieces = new List<IPiece>();

            Console.WriteLine("Cikmak icin H/h basiniz. Devam etmek icin herhangi bir tusa basiniz.");
            char karakter = Convert.ToChar(Console.ReadLine());

            while (!(karakter == 'H' || karakter == 'h'))
            {
                Random rand = new Random();
                Random randForColor = new Random();

                int randomIndex = rand.Next(0, pieceList.Count);
                string rastgeleTas = pieceList.ElementAt(randomIndex).Key;

                switch (rastgeleTas)
                {
                    case "At":
                        Knight knight = new Knight()
                        {
                            Name = "At",
                            Color = Enum.GetValues<PieceColor>()[randForColor.Next(0, 2)]
                        };
                        pieces.Add(knight);
                        break;
                    case "Fil":
                        Bishop bishop = new Bishop()
                        {
                            Name = "Fil",
                            Color = Enum.GetValues<PieceColor>()[randForColor.Next(0, 2)]
                        };
                        pieces.Add(bishop);
                        break;
                    case "Sah":
                        King king = new King()
                        {
                            Name = "Sah",
                            Color = Enum.GetValues<PieceColor>()[randForColor.Next(0, 2)]
                        };
                        pieces.Add(king);
                        break;
                    case "Piyon":
                        Pawn pawn = new Pawn()
                        {
                            Name = "Piyon",
                            Color = Enum.GetValues<PieceColor>()[randForColor.Next(0, 2)]

                        };
                        pieces.Add(pawn);
                        break;
                    case "Kale":
                        Rook rook = new Rook()
                        {
                            Name = "Kale",
                            Color = Enum.GetValues<PieceColor>()[randForColor.Next(0, 2)]

                        };
                        pieces.Add(rook);
                        break;
                    case "Vezir":
                        Quenn quenn = new Quenn()
                        {
                            Name = "Vezir",
                            Color = Enum.GetValues<PieceColor>()[randForColor.Next(0, 2)]
                        };
                        pieces.Add(quenn);
                        break;
                }

                // Key'i rastgeleTas olanın Value değeri bir artar 
                pieceList[rastgeleTas]++;

                Console.WriteLine("Satranc Tasi listeye eklendi. Cikmak icin H/h basiniz. Devam etmek icin herhangi bir tusa basiniz.");
                karakter = Convert.ToChar(Console.ReadLine());
            }

            foreach (var piece in pieces)
            {
                Console.WriteLine($"{piece.Name}\n{piece.Color}");
                piece.Move();
                if (piece.Name == "Piyon") {
                    Pawn pawn = new Pawn();
                    pawn.Promote();
                }
                Console.WriteLine("---------------------------------------------------------------");
            }

            // En büyük Value değerine sahip Key'i getirir.
            var enCokTekrarEdenTas = pieceList.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;

            Console.WriteLine($"En çok tekrar eden tas : {enCokTekrarEdenTas}");
        }
    }
}