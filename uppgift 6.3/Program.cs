using System;
using System.Net.Http.Headers;

namespace Program
{
    class Program
    {

        static void Main(string[] args)
        {
            string användarensval = "";

            

            while (användarensval != "4")
            {
                val();
                
                användarensval=Console.ReadLine();

                switch (användarensval)
                {
                    case "1":
                        addera();
                            break;
                    case "2":
                        största();
                            break;
                    case "3":
                        stopp();
                            break;
                }

            }

        }


        static void val()
        {
            Console.WriteLine("Vad vill du göra?");
            Console.WriteLine();
            Console.WriteLine("1. Addera tre tal");
            Console.WriteLine("2. Största talet av två tal");
            Console.WriteLine("3. Avsluta programmet");
            Console.WriteLine();
        }

        static void addera()
        {
            Console.WriteLine("skriv in tal 1 ");
            string tal1 = Console.ReadLine();
            Console.WriteLine("Skriv in tal 2");
            string tal2 = Console.ReadLine();
            Console.WriteLine("Skriv in tal 3");
            string tal3 = Console.ReadLine();

            int tal4 = int.Parse(tal1);
            int tal5 = int.Parse(tal2);
            int tal6 = int.Parse(tal3);

            Console.WriteLine($"{tal4} + {tal5} + {tal6} = {tal4 + tal5 +tal6}");
        }

        static void största()
        {
            Console.WriteLine("Skriv in tal 1 ");
            string tal1 = Console.ReadLine();
            Console.WriteLine("Skriv in tal 2 ");
            string tal2 = Console.ReadLine();

            int tal3 = int.Parse(tal1);
            int tal4 = int.Parse(tal2);


            if (tal3>tal4)
            {
                Console.WriteLine($"{tal3} är det största talet");
            }

            else if (tal3 < tal4)
            {
                Console.WriteLine($"{tal4} är det största talet");
            }

            else
            {
                Console.WriteLine("båda talen är lika stora");
            }
        }

        static void stopp()
        {
            Environment.Exit(0);
        }

    }
}

