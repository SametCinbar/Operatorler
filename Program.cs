using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama ve işlemli atama 

            int x = 6;
            int y = 6;
            y = y + 2;
            Console.WriteLine(y); //8 yazacak

            y += 4;
            Console.WriteLine(y); //12 yazacak

            y *= 6;
            Console.WriteLine(y); //36 yazacak 



            x = x / 2;
            Console.WriteLine(x);


            //Mantıksal op.


            bool isSuccess = true;
            bool isCompleted = false;
            if (isSuccess && isCompleted)
                Console.WriteLine("Perfectly");
            if (isSuccess || isCompleted)
                Console.WriteLine("Great");

            if (isSuccess && !isCompleted)
                Console.WriteLine("Fine");

            //Console.ReadKey();

            //Implicit Conversion ( Bilinçsiz Dönüşüm)


            byte a = 10;
            sbyte b = 20;
            short c = 30;

            int d = a + b + c;
            Console.WriteLine("D" + d);

            long h = d;
            Console.WriteLine("h:" + d);

            float i = h;
            Console.WriteLine("i" + h);

            string s = "samet";
            char f = 's';
            object g = s + c + f;
            Console.WriteLine("g:" + g);



            //expilicy conversiyon ( Bilinçli Donusum )



            Console.WriteLine("********Explicit Conversion Donusum********");

            int z = 9;
            byte k = (byte)z;
            Console.WriteLine("k:" + k);

            int u = 100;
            byte t = (byte)u;
            Console.WriteLine("t" + t);


            double w = 10.09f;
            byte v = (byte)w;
            Console.WriteLine("v:" + w);


            //******ToString Methodu*******

            Console.WriteLine("********ToString Methodu********");

            int xx = 44;
            string yy = xx.ToString();
            Console.WriteLine("yy:" + yy);
            Console.WriteLine("System.Convert sınıfı******* ");

            string s1 = "20", s2 = "40";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + toplam);

            string metin1 = "10";
            string metin2 = "20,50";
            int rakam1;
            double double1;


            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            Console.WriteLine("Rakam: " + rakam1);
            Console.WriteLine("Rakam: " + double1);

            Console.ReadKey();



            Console.ReadKey();

        }









    }
    }
