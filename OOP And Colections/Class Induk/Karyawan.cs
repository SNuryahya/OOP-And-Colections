﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_And_Colections
{
    public abstract class Karyawan
    {
        public string NIK { get; set; }
        public string NAMA { get; set; }
        public abstract double Pendapatan();
    }
}