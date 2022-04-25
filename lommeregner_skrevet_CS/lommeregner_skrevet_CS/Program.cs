
using System;



namespace Metoder

{

    class Program

    {

        static void Main(string[] args)

        {

            //vælger plus eller minus gange eller dividre //

            Console.WriteLine("skriv hvad du ville bruge  + - * /");

            string vaelg = Console.ReadLine();





            // tager det første tal til int //

            Console.WriteLine("Skriv det første tal ");

            string tal1 = Console.ReadLine();

            int tal1SomInt = Convert.ToInt32(tal1);



            //tager det andet tal til int//

            Console.WriteLine("Skriv det andet tal");

            string tal2 = Console.ReadLine();

            int tal2SomInt = Convert.ToInt32(tal2);



            //finder ud af om brugern vægler plus og plusser det//

            if (vaelg == "+")

            {

                int print = Plus(tal1SomInt, tal2SomInt);

                Console.WriteLine("Dit Resultat er:" + print);

                Console.ReadLine();

            }

            //finder ud af om brugern vægler minus og minuser det//

            else if (vaelg == "-")

            {

                int print = Minus(tal1SomInt, tal2SomInt);

                Console.WriteLine("Dit Resultat er:" + print);

                Console.ReadLine();

            }

            //finder ud af om brugern vælger gange og gane det//

            else if (vaelg == "*")

            {

                int print = Gange(tal1SomInt, tal2SomInt);

                Console.Write("Dit Resultat er:" + print);

                Console.ReadLine();



            }

            //finder uf af om Brugern vælger dividre og dividre det//

            else if (vaelg == "/ ")

            {

                int print = Dividre(tal1SomInt, tal2SomInt);

                Console.WriteLine("Dit Resultat er:" + print);

                Console.ReadLine();

            }











        }

        //plus funtion //

        public static int Plus(int tal1SomInt, int tal2SomInt)

        {

            return tal1SomInt + tal2SomInt;

        }

        //minus funtion//

        public static int Minus(int tal1SomInt, int tal2SomInt)

        {

            return tal1SomInt - tal2SomInt;

        }

        //gange funtion//

        public static int Gange(int tal1SomInt, int tal2SomInt)

        {

            return tal1SomInt * tal2SomInt;

        }

        //dividre funtion//

        public static int Dividre(int tal1SomInt, int tal2SomInt)

        {

            return tal1SomInt % tal2SomInt;

        }

    }

}

