using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300126
{
     class KodeProduk
    {
        public static string getKodeProduk(string namaproduk)
        {
            string[,] dataKodeProduk = {
                { "Laptop" , "E100"},
                { "Smartphone" , "E101"},
                { "Tablet" , "E102"},
                { "Headset" , "E103"},
                { "Keyboard" , "E104"},
                { "Mouse", "E105"},
                { "Printer" , "E106"},
                { "Monitor" , "E107"},
                { "Smartwatch" , "E108"},
                { "Kamera" , "E100"},
            };

            for (int i = 0; i < dataKodeProduk.GetLength(0); i++)

                if (dataKodeProduk[i, 0].Equals(namaproduk, StringComparison.OrdinalIgnoreCase))
               
                    return dataKodeProduk[i, 1];
                    return "Produk tidak ditemukan";

               
        }
    }
  }

