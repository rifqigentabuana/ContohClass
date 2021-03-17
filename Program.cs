using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest01
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek dari class Mahasiswa
            Mahasiswa aing = new Mahasiswa();
            Mahasiswa koe = new Mahasiswa();

            // setting nilai properties objek aing dan koe
            aing.Nim = "20.11.3334";
            aing.Nama = "Jono";
            aing.Ipk = 3.82f;

            koe.Nim = "20.11.3333";
            koe.Nama = "Genta";
            koe.Ipk = 3.85f;

            // memanggil method registrasi dan isi krs
            aing.Registrasi();
            aing.IsiKrs();

            koe.Registrasi();
            koe.IsiKrs();

            Console.ReadKey();
        }
    }
}
