// Pemrograman Berorientasi Obyek Kelas C
// Ulfatun Ni'mah
// Tipe Soal A

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace SistemMBG
{
    
    
    public class Sekolah
    {
        private string idSekolah;
        private string namaSekolah;
        private int jumlahPaketDiterima;

        public string IdSekolah
        {
            get { return idSekolah; }
            set { idSekolah = value; }
        }

        public string NamaSekolah
        {
            get { return namaSekolah; }
            set { namaSekolah = value; }
        }

   
        public int JumlahPaketDiterima
        {
            get { return jumlahPaketDiterima; }
            private set { jumlahPaketDiterima = value; }
        }

        public Sekolah(string idSekolah, string namaSekolah, int jumlahPaketDiterima)
        {
            this.idSekolah = idSekolah;
            this.namaSekolah = namaSekolah;
            this.jumlahPaketDiterima = jumlahPaketDiterima;
        }

     
        public void TerimaPaket(int jumlah)
        {
            jumlahPaketDiterima += jumlah;
        }

        public void TampilInfo()
        {
            Console.WriteLine($"ID Sekolah           : {idSekolah}");
            Console.WriteLine($"Nama Sekolah         : {namaSekolah}");
            Console.WriteLine($"Jumlah Paket Diterima: {jumlahPaketDiterima} paket");
        }
    }

   
    
    public abstract class PaketMBG
    {
        private string idPaket;
        private string namaPaket;
        private int stokDapur;

        public string IdPaket
        {
            get { return idPaket; }
            set { idPaket = value; }
        }

        public string NamaPaket
        {
            get { return namaPaket; }
            set { namaPaket = value; }
        }

       
        public int StokDapur
        {
            get { return stokDapur; }
            private set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(StokDapur), "Stok dapur tidak boleh bernilai negatif.");
                stokDapur = value;
            }
        }

        protected PaketMBG(string idPaket, string namaPaket, int stokDapur)
        {
            this.idPaket = idPaket;
            this.namaPaket = namaPaket;
            StokDapur = stokDapur; 
        }

        public bool KurangiStok(int jumlah)
        {
            if (jumlah <= 0)
            {
                Console.WriteLine("  [KurangiStok] Gagal: jumlah pengurangan harus lebih dari 0.");
                return false;
            }
            if (jumlah > stokDapur)
            {
                Console.WriteLine($"  [KurangiStok] Gagal: jumlah ({jumlah}) melebihi stok tersedia ({stokDapur}).");
                return false;
            }
        }

 