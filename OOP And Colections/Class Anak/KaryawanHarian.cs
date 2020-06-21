using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_And_Colections
{
    class KaryawanHarian : Karyawan
    {
        public double PendapatanPerJam { get; set; }
        public double HitunganJamKerja { get; set; }
        public override double Pendapatan()
        {
            return PendapatanPerJam * HitunganJamKerja;
        }
    }
}