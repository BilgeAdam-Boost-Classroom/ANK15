// See https://aka.ms/new-console-template for more information
using Abstraction;

Kebap kebap = new Kebap();
kebap.SosMiktari = 0.4;
kebap.DiyetMi = false;
kebap.YemekHazirlan();
kebap.Sunul();

Console.WriteLine("------------------------");

Insan insan = new Insan();
insan.Familya = "Homo Sapiens";
insan.CanliTuru = "Memeli";
insan.Aile = "Aile1";
insan.FamilyaGoster();
insan.TurGoster();
insan.AileGoster();
