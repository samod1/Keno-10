using System;
using System.Linq;

namespace Lucka_Keno
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] tipovane = new int[10];
            int[] losovane = new int[10];


            Console.WriteLine("\nKeno 10\n");
            Console.WriteLine("Vloz 10 cisel");

            //zapis do tipovanych cisiel do pola
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\nNapis cislo " + i);
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

            Console.WriteLine("Vase Tipy");
            VypisTipy(tipovane);

            for (int i = 0; i < 10; i++)
            {
                losovane[i] = GenerujLosovanie();
            }


            Console.WriteLine("Vylosovane cisla");
            VypisTipy(losovane);

            Console.WriteLine("Spravne si tipol: "+ VyhodnotenieLosovania(losovane,tipovane));

        }

        //funkcia na vypis pola
        public static void VypisTipy(int[] cisla)
        {
            

            Array.Sort(cisla);
            foreach (int prvok in cisla)
            {
                Console.WriteLine(prvok + " ");
            }
        }
    

        static int GenerujLosovanie()
        {
            Random rd = new Random();
            int rand = rd.Next(1,80);

            return rand;
        }

        static int VyhodnotenieLosovania(int[] losovane, int[]tipovane)
        {
            int pocet_spravnych_tipov = 0;

            for(int i=0; i < 10; i++)
            {
                int index = Array.IndexOf(losovane, tipovane[i]);
                    if(index == -1)
                    {
                        //nebolo najdene cislo nepotrebujeme ziaden vypis
                    }

                    else
                    {
                    pocet_spravnych_tipov += 1;
                    }
            }
            return pocet_spravnych_tipov;
        }
    }
}
    

