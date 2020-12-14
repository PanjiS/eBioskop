using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBioskop
{
    class Bioskop
    {
        static void Main(string[] args)
        {
            tiket tkt = new tiket();
            tkt.kategori_tiket();
            tkt.jenis_pembayaran();

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
