﻿namespace OkulExerciseWF.Entity
{
    public class OgrenciDers
    {
        public int Id { get; set; }
        public int OgrenciId { get; set; }
        public int DersId { get; set; }
        public Ders Ders { get; set; }
        public Ogrenci Ogrenci { get; set; }
        public int Not { get; set; }
    }
}
