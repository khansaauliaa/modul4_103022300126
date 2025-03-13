using modul4_103022300126;
using modul4_103022300126;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("1. Kode Produk");
        Console.WriteLine("2. Fan Laptop");
        Console.WriteLine("0. Exit");
        Console.WriteLine("Pilih Menu : ");


        string masuk = Console.ReadLine();

        while (masuk != "0")
        {
            if (masuk == "1")
            {
                KodeProduk Kode = new KodeProduk();
                Console.WriteLine("Masukkan Nama Produk : ");
                string namaproduk = Console.ReadLine();

                if (namaproduk != "Kembali")
                {
                    string kode = KodeProduk.getKodeProduk(namaproduk);
                    Console.WriteLine("Kode Produk : " + kode);
                }
                else
                {
                    Main();
                }
            }
            else if (masuk == "2")
            {
                FanLaptop fan = new FanLaptop();
                fan.TurnOn();
            }
            else if (masuk == "0")
            {
                break;
            }
        }
    }
}