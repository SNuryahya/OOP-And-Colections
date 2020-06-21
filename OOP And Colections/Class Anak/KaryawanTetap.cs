using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_And_Colections
{
    class KaryawanTetap : Karyawan
    {
        public double GajiBulanan { get; set; }
        public override double Pendapatan()
        {
            return GajiBulanan;
        }
    }
}