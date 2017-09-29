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
        static List<string> AdverbList = new List<string>();
        static List<string> InterjektionerList = new List<string>();
        static List<string> KonjunktionerList = new List<string>();


        static void Main(string[] args)
        {


            Adjektiv();
            LoopsLists();
            
            Kewl(ChooseWordClass());
            
            Console.ReadLine();
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

        static void Addverb()
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

        static void Interjektioner()
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

        static void Konjuktioner()
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

        static void LoopsLists()
        {
            foreach (var item in adjektivList)
            {

                Console.Write(adjektivList.IndexOf(item) + 1);

                Console.WriteLine(": {0}", item);
            }

        }

        static int ChooseWordClass()
        {
            Console.WriteLine("Välj list 1 eller 2");
            int b = int.Parse(Console.ReadLine());
            return b;
        }

        static void Kewl(int chooseWordClass)
        {
            if(chooseWordClass == 1)
            {
                LoopsLists();
            }
        }







    }
}
