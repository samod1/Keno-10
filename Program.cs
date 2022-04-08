using System;
using System.Linq;

namespace Lucka_Keno
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tipovane = new int[10];
            

        Console.WriteLine("\nKeno 10\n");
        Console.WriteLine("Vloz 10 cisel");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\nNapis cislo "+ i);
                tipovane[i] = Convert.ToInt32(Console.ReadLine());

                if (Enumerable.Range(1, 80).Contains(tipovane[i]))
                {

                }    

                else
                {
                    //here is a Bug when u insert number out of range more then once
                    Console.WriteLine("Cislo je mimo rozsahu 1 - 80 \n Zadajte cislo este raz ");
                    tipovane[i] = Convert.ToInt32(Console.ReadLine());
                }
            };

            VypisTipy(tipovane);

        }

        //funkcia na vypis pola
        public static void VypisTipy(int[] losovanie)
        {
            Console.WriteLine("\n\nZoradene prvky pola");

            Array.Sort(losovanie);
            foreach (int prvok in losovanie)
            {
                Console.WriteLine(prvok + " ");
            }    
        }
    }
    
}
