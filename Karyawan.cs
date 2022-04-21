using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4433
{
    internal class Karyawan
    {
        public string NIK { get; set; }
        public string Nama { get; set; }
        public float GajiBulanan { get; set; }
        public Karyawan(string nik, string nama, float gajiBulanan)
        {
            this.NIK = nik;
            this.Nama = nama;
            if (gajiBulanan < 0)
            {
                gajiBulanan = 0;
            }
            this.GajiBulanan = gajiBulanan;
        }

        public void NaikkanGaji(float persentase)
        {
            this.GajiBulanan = persentase / 100 * this.GajiBulanan + this.GajiBulanan;
        }

    }
}