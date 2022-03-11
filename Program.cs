using System;

namespace for_loop
{
    class Program
    {
        static   void Main(string[] args)
        {
            int sayi = int.Parse(Console.ReadLine());

            for (int i = 0; i < sayi; i++)
            {
                if( i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

        

        int tekToplam = 0;
        int ciftToplam = 0;

         for (int i = 0; i < 1000; i++)
            {
                if( i % 2 == 1)
                {
                    tekToplam += i;
                    
                }else{
                    ciftToplam += i;
                }
            }
            Console.WriteLine("tek Toplam" + tekToplam);
            Console.WriteLine("Cift Toplam" + ciftToplam);

            for(int i = 0 ; i <= 10; i++ ){
                
                if( i == 4){
                    break;
                }
                Console.WriteLine(i);
                
            }

             for(int i = 0 ; i <= 10; i++ ){
                
                if( i == 4){
                    continue;
                }
                 Console.WriteLine(i);

                
            }
        }
    }
} 