﻿using System.Reflection.Metadata;

namespace tpmodul10_103022300101
{
    public class Mahasiswa
    {
        public string Nama { get; set; }
        public string NIM { get; set; }

        public Mahasiswa(string nama, string nim)
        {
            Nama = nama;
            NIM = nim;
        }
    }
}
