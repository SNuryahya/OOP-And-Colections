using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_And_Colections
{
    class Sales : Karyawan
    {
        public double JumlahPenjualan { get; set; }
        public double Komisi { get; set; }
        public override double Pendapatan()
        {
            return JumlahPenjualan * Komisi;
        }
    }
}