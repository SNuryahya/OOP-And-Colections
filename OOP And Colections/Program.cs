using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_And_Colections;

namespace OOP_And_Colections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 (Pertemuan 11) - Polymorphsim, Inheritance, Abstraction & Collection";

            KaryawanTetap karyawantetap = new KaryawanTetap();
            karyawantetap.NIK = "009-005-200";
            karyawantetap.NAMA = "Nanda Reni Saputri";
            karyawantetap.GajiBulanan = 20000000;

            KaryawanHarian karyawanharian = new KaryawanHarian();
            karyawanharian.NIK = "014-002-200";
            karyawanharian.NAMA = "Sulistiya Nuryahya";
            karyawanharian.HitunganJamKerja = 10;
            karyawanharian.PendapatanPerJam = 25000;

            Sales sales = new Sales();
            sales.NIK = "017-008-200";
            sales.NAMA = "Fardhani";
            sales.JumlahPenjualan = 30;
            sales.Komisi = 50000;

            List<Karyawan> listkaryawan = new List<Karyawan>();

            listkaryawan.Add(karyawantetap);
            listkaryawan.Add(karyawanharian);
            listkaryawan.Add(sales);

            int noUrut = 1;
            foreach (Karyawan karyawan in listkaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}", noUrut, karyawan.NIK, karyawan.NAMA, karyawan.Pendapatan());
                noUrut++;
            }
            Console.ReadKey();
        }
    }
}
