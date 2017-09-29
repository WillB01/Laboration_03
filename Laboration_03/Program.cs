using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Laboration_03
{
    class Test
    {
        int _a;
        string _b;

        public Test(int a, string b)
        {
            _a = a;
            _b = b;
        }

    }


    class Program
    {
        static List<string> adjektivList = new List<string>();
        static List<string> adverbList = new List<string>();
        static List<string> interjektionerList = new List<string>();
        static List<string> konjuktionerList = new List<string>();
        static List<int> my = new List<int>();

        static StringBuilder sb = new StringBuilder();

        static public int b;
        
      
        

        static void Main(string[] args)
        {




            bool loopTheProgram = true;
          
                Adjektiv();
                Adverb();
                Interjektioner();
                Konjuktioner();

                
            while (loopTheProgram)
            {
                LoopsLists(ChooseWordClass());
                ItemPickerFromWc();

                Console.WriteLine("Print: y Add Words: n");
                string user = Console.ReadLine();
                if(user == "y")
                {
                    loopTheProgram = false;
                    Console.WriteLine(sb);
                }
                else if(user == "n")
                {
                    loopTheProgram = true;
                }
                
            }
           
            
            
            
            







            Console.ReadLine();
        }


        static void ItemPickerFromWc()
        {
            Console.WriteLine("Välj ett ord");
            int hm = int.Parse(Console.ReadLine());

            switch (hm)
            {
                case 1:
                    sb.Append(adjektivList[0]);                  
                    break;
                case 2:
                    sb.Append(adjektivList[1]);
                    break;
                case 3:
                    sb.Append(adjektivList[2]);
                    break;
                case 4:
                    sb.Append(adjektivList[3]);
                    break;
                case 5:
                    sb.Append(adjektivList[4]);
                    break;
                case 6:
                    sb.Append(adjektivList[5]);
                    break;
                case 7:
                    sb.Append(adjektivList[6]);
                    break;
                case 8:
                    sb.Append(adjektivList[7]);
                    break;
                case 9:
                    sb.Append(adjektivList[8]);
                    break;
                case 10:
                    sb.Append(adjektivList[9]);
                    break;
            }

            /*switch (hm)
            {
                case 1:
                    sb.Append(adverbList[0]);
                    break;
                case 2:
                    sb.Append(adverbList[1]);
                    break;
                case 3:
                    sb.Append(adverbList[2]);
                    break;
                case 4:
                    sb.Append(adverbList[3]);
                    break;
                case 5:
                    sb.Append(adverbList[4]);
                    break;
                case 6:
                    sb.Append(adverbList[5]);
                    break;
                case 7:
                    sb.Append(adverbList[6]);
                    break;
                case 8:
                    sb.Append(adverbList[7]);
                    break;
                case 9:
                    sb.Append(adverbList[8]);
                    break;
                case 10:
                    sb.Append(adverbList[9]);
                    break;
            }


    */




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
            adjektivList.Add("röd");
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
