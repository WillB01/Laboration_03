using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Laboration_03
{
    class Program
    {
        static List<string> adjektivList = new List<string>();
        static List<string> adverbList = new List<string>();
        static List<string> interjektionerList = new List<string>();
        static List<string> konjuktionerList = new List<string>();

        static public int b;
        static public Exception e;


        static void Main(string[] args)
        {





           
            Adjektiv();
            Adverb();
            Interjektioner();
            Konjuktioner();

            LoopsLists(ChooseWordClass());
            







            Console.ReadLine();
        }


        static void LoopsLists(int k)
        {

            switch (k)
            {
                case 1:
                    foreach (var item in adjektivList)
                    {

                        Console.Write(adjektivList.IndexOf(item) + 1);

                        Console.WriteLine(": {0}", item);
                    }
                    break;
                case 2:
                    foreach (var item in adverbList)
                    {

                        Console.Write(adverbList.IndexOf(item) + 1);

                        Console.WriteLine(": {0}", item);
                    }
                    break;
                case 3:
                    foreach (var item in interjektionerList)
                    {

                        Console.Write(interjektionerList.IndexOf(item) + 1);

                        Console.WriteLine(": {0}", item);
                    }
                    break;
                case 4:
                    foreach (var item in konjuktionerList)
                    {

                        Console.Write(konjuktionerList.IndexOf(item) + 1);

                        Console.WriteLine(": {0}", item);
                    }
                    break;

            }   
        }



        static int ChooseWordClass()
        {
            bool loopInput = true;
            while (loopInput)
            {
                Console.Write("Välj en ordklass:\n" +
                "Tryck: 1 - Adjektiv\n" +
                "Tryck: 2 - Adverb\n" +
                "Tryck: 3 - Interjektioner\n" +
                "Tryck: 4 - Konjuktioner\n" +
                "Svar: ");
           
                try
                {
                    b = int.Parse(Console.ReadLine());

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
               if (b == 1 || b == 2 || b == 3 || b == 4 )
                {
                    loopInput = false;
                }
            
            }
            return b;




        }

       
        static void Adjektiv()
        {
            adjektivList.Add("Röd");
            adjektivList.Add("Gul");
            adjektivList.Add("Svart");
            adjektivList.Add("Stark");
            adjektivList.Add("Svag");
            adjektivList.Add("Stor");
            adjektivList.Add("Ung");
            adjektivList.Add("Glad");
            adjektivList.Add("Arg");
            adjektivList.Add("Lesden");

        }

        static void Adverb()
        {
            adverbList.Add("Fort");
            adverbList.Add("Ovanligt");
            adverbList.Add("Mycket");
            adverbList.Add("När");
            adverbList.Add("Där");
            adverbList.Add("Dit");
            adverbList.Add("Inte");
            adverbList.Add("Ner");
            adverbList.Add("Upp");
            adverbList.Add("Efter");



        }

        static void Interjektioner()
        {
            interjektionerList.Add("Hej");
            interjektionerList.Add("Usch");
            interjektionerList.Add("Tick-Tack");
            interjektionerList.Add("Boom");
            interjektionerList.Add("God natt");
            interjektionerList.Add("Skål");
            interjektionerList.Add("Bravo");
            interjektionerList.Add("Ja");
            interjektionerList.Add("Pang");
            interjektionerList.Add("Fy");



        }

        static void Konjuktioner()
        {
            konjuktionerList.Add("Och");
            konjuktionerList.Add("Eller");
            konjuktionerList.Add("Utan");
            konjuktionerList.Add("Men");
            konjuktionerList.Add("För");
            konjuktionerList.Add("Fast");
            konjuktionerList.Add("Varken");
            konjuktionerList.Add("Att");
            konjuktionerList.Add("När");
            konjuktionerList.Add("Som");



        }





    }
}
