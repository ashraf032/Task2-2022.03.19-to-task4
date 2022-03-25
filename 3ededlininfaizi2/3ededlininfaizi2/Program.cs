using System;

namespace _3ededlininfaizi2
{
    class Program
    {
        static void Main(string[] args)
        {

            string sevenpersentage = "7";

            Console.WriteLine("-------------------------");
            
            Console.WriteLine("Zehmet olmasa 3 reqemli eded daxil edin");
            
            string num = Console.ReadLine();
            
            string couplestr = num + sevenpersentage;
            
            Console.WriteLine(couplestr);
            
            int resultparam = int.Parse(couplestr);
            
            if (resultparam>=100 && resultparam<10000)
            {
                Console.WriteLine(resultparam*0.07);
            }
            
            else
            {
                Console.WriteLine("Nezere alinmayib");
            }


        }

    }
}
