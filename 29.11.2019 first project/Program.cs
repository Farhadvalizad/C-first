using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._11._2019_first_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Adinizi daxil edin");
            //string ad = Console.ReadLine();
            //Console.WriteLine("Soyadinizi daxil edin");
            //string soyad = Console.ReadLine();

            //Console.WriteLine("Yasinizi daxil edin");
            //int yas=Convert.ToInt32(Console.ReadLine());

            //if (yas < 18) 
            //{
            //    Console.WriteLine("Siz yetkinlik yasina catmamisiniz");
            //}
            //else if (yas >= 18 && yas<24)
            //{
            //    Console.WriteLine("Xos gelmisiz.Siz bizim sayta uygunsunuz");
            //}
            //else
            //{
            //    Console.WriteLine("Siz bizim sayta daxil olmaq ucun cox boyuksunuz");
            //}

            while (1 == 1)
            {
                Console.WriteLine("Balinizi daxil edin");
                int bal = Convert.ToInt32(Console.ReadLine()); 
                if(bal<51)
                {
                    Console.WriteLine("Kesilmisiz");
                }
                if (bal>=51 && bal<61) 
                {
                    Console.WriteLine("Kafi");
                }
                if (bal >= 61 && bal < 71)
                {
                    Console.WriteLine("Qenaetbexs");
                }
                if (bal >= 71 && bal < 81)
                {
                    Console.WriteLine("Ela");
                }
                if (bal >= 81 && bal < 91)
                {
                    Console.WriteLine("Elaci");
                }
                else if(bal>100){
                    Console.WriteLine("Balinizi duzgun daxil etmemisiniz");
                }
                
            }
            
            
        }
    }
}
