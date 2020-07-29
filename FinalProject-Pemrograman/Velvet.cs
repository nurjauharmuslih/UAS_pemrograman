﻿using System;

namespace FinalProject
{
    class Velvet : Bioskop
    {
        public void spesifikasi()
        {
            Console.WriteLine(" Fasilitas              : - Minuman Red Velvet");
            Console.WriteLine("                          - Snack");
            Console.WriteLine("                          - Popcorn besar");
            Console.WriteLine("                          *Dilarang membawa makanan dan minuman selain dari Bioskop");
        }
        public double JumlahTiket { get; set; }
        public double HargaTiket { get; set; }
        public double UangBayar { get; set; }
        public override double Bayar()
        {
            return JumlahTiket * HargaTiket;
        }
        public override double Kembalian()
        {
            return UangBayar - Bayar();
        }
    }
}
