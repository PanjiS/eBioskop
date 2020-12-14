using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBioskop
{
    class tiket:Bioskop
    {
        public int daftar, kelas ;
        public string nama, pilih;
        public bool ulangi = true;
        public double harga_tiket, total_bayar, dis, h_dis;

        public void kategori_tiket()
        {
            do
            {
                Console.Write("Jumlah Tiket yang di beli : ");
                daftar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (daftar < 1)
                {

                    Console.WriteLine("Tidak boleh kosong");
                    ulangi = true;
                }
                else
                {
                    for (int a = 0; a < daftar; a++)
                    {
                        Console.Write("Masukkan FILM yang ditonton : ");
                        nama = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("-----------------------");
                        Console.WriteLine("   Kelas Tiket Bioskop ");
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("1. Tiket Reguler");
                        Console.WriteLine("2. Tiket VIP");
                        Console.WriteLine("-----------------------");
                        Console.WriteLine();

                        Console.Write("pilih Kelas Tiket : ");
                        kelas = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        switch (kelas)
                        {
                            case 1:
                                harga_tiket = 25000;
                                Console.WriteLine("Total yang Dibayar Rp. " + harga_tiket);
                                break;

                            case 2:
                                harga_tiket = 50000;
                                Console.WriteLine("Total yang Dibayar Rp. " + harga_tiket);
                                break;

                            default:
                                Console.WriteLine("inputan salah");
                                break;
                        }
                        Console.WriteLine();
                        total_bayar += harga_tiket;
                        Console.WriteLine("");
                        ulangi = false;


                    }
                }
            } while (ulangi);

        }

        public void jenis_pembayaran()
        {

            do
            {
                Console.Write("mempunyai member card? YA/TIDAK : ");
                pilih = Console.ReadLine();
                Console.WriteLine();
                switch (pilih)
                {
                    case "YA":
                        dis = total_bayar * 10 / 100;
                        h_dis = total_bayar - dis;

                        Console.WriteLine("Discount 10%  : Rp." + dis);
                        Console.WriteLine("Total bayar  : Rp." + h_dis);
                        ulangi = false;
                        break;

                    case "TIDAK":
                        Console.WriteLine("Total bayar  : Rp." + total_bayar);
                        ulangi = false;
                        break;

                    default:
                        Console.WriteLine("pilihan anda salah");
                        break;
                }
            } while (ulangi);
            Console.WriteLine();
        }
    }
}
