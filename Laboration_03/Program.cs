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
  
        static StringBuilder sb = new StringBuilder();

        static public int checkListPick;
        static bool loopTheProgram = true;
        
        // // // // // // // // // // // // // // // // // // // // // // //
        //Program start
        static void Main(string[] args)
        {

            Adjektiv();
            Adverb();
            Interjektioner();
            Konjuktioner();
            

            while (loopTheProgram) //Loopar programet
            {
               
                LoopsLists(ChooseWordClass());
                Console.WriteLine("\n^^^^^^^^^^^^^");
                ItemPickerFromWc();
                UserWord();

                Console.Write("Print: print || Lägg till ord: add || Svar: ");
                string user = Console.ReadLine();
                if (user == "print" || user == "p")
                {
                    loopTheProgram = false;
                    Console.WriteLine(sb);
                }
                else if (user == "add" || user == "a" )
                {
                    loopTheProgram = true;
                }

            }

            Console.ReadLine();
        }
        //Program End
        // // // // // // // // // // // // // // // // // 

        static void UserWord() //Användarens egna ord
        {
            Console.Write("\nVill du lägga till egna ord?\n" +
                "ja eller nej: ");   
            
            string userInputPersonalWord = Console.ReadLine();
           
            if(userInputPersonalWord == "ja" || userInputPersonalWord == "j")
            {
                Console.WriteLine(" ");
                string b = Console.ReadLine();
                sb.Append(b + " ");
            }
            else if(userInputPersonalWord == "nej" || userInputPersonalWord == "n" )
            {
                loopTheProgram = true;
            }                      
        }

        static void ItemPickerFromWc() //väljer specifik ord från en ordklass
        {

            Console.Write("Välj ett ord: ");
            try
            {
                
            int userWordFromWc = int.Parse(Console.ReadLine());

            if (checkListPick == 1)
            {
                switch (userWordFromWc)
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
            }

            else if (checkListPick == 2)
            {
                switch (userWordFromWc)
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
            }

            else if (checkListPick == 3)
            {
                switch (userWordFromWc)
                {
                    case 1:
                        sb.Append(interjektionerList[0]);
                        break;
                    case 2:
                        sb.Append(interjektionerList[1]);
                        break;
                    case 3:
                        sb.Append(interjektionerList[2]);
                        break;
                    case 4:
                        sb.Append(interjektionerList[3]);
                        break;
                    case 5:
                        sb.Append(interjektionerList[4]);
                        break;
                    case 6:
                        sb.Append(interjektionerList[5]);
                        break;
                    case 7:
                        sb.Append(interjektionerList[6]);
                        break;
                    case 8:
                        sb.Append(interjektionerList[7]);
                        break;
                    case 9:
                        sb.Append(interjektionerList[8]);
                        break;
                    case 10:
                        sb.Append(interjektionerList[9]);
                        break;
                }
            }
            else if (checkListPick == 4)
            {
                switch (userWordFromWc)
                {
                    case 1:
                        sb.Append(konjuktionerList[0]);
                        break;
                    case 2:
                        sb.Append(konjuktionerList[1]);
                        break;
                    case 3:
                        sb.Append(konjuktionerList[2]);
                        break;
                    case 4:
                        sb.Append(konjuktionerList[3]);
                        break;
                    case 5:
                        sb.Append(konjuktionerList[4]);
                        break;
                    case 6:
                        sb.Append(konjuktionerList[5]);
                        break;
                    case 7:
                        sb.Append(konjuktionerList[6]);
                        break;
                    case 8:
                        sb.Append(konjuktionerList[7]);
                        break;
                    case 9:
                        sb.Append(konjuktionerList[8]);
                        break;
                    case 10:
                        sb.Append(konjuktionerList[9]);
                        break;
                }
            }
            }
            catch (Exception e)
            {
               Console.WriteLine(e.Message);              
            }
        }

        static void LoopsLists(int k) //Går igenom alla listor
        {
            switch (k) // väljer vilken lista 
            {
                case 1:
                    foreach (var item in adjektivList)
                    {

                        Console.Write("\n{0}",adjektivList.IndexOf(item) + 1);

                        Console.WriteLine(": {0}", item);

                    }
                    break;
                case 2:
                    foreach (var item in adverbList)
                    {

                        Console.Write("\n{0}", adverbList.IndexOf(item) + 1);

                        Console.WriteLine(": {0}", item);
                    }
                    break;
                case 3:
                    foreach (var item in interjektionerList)
                    {

                        Console.Write("\n{0}", interjektionerList.IndexOf(item) + 1);

                        Console.WriteLine(": {0}", item);
                    }
                    break;
                case 4:
                    foreach (var item in konjuktionerList)
                    {

                        Console.Write("\n{0}", konjuktionerList.IndexOf(item) + 1);

                        Console.WriteLine(": {0}", item);
                    }
                    break;
            }
        }

        static int ChooseWordClass() //printar ut vilken ordklass användaren vill ha
                                   //Bestämmer också.
        {
            bool loopInput = true;
            while (loopInput)
            {
                Console.Write("Välj en ordklass:\n" +
                "\nTryck: 1 - Adjektiv\n" +
                "Tryck: 2 - Adverb\n" +
                "Tryck: 3 - Interjektioner\n" +
                "Tryck: 4 - Konjuktioner\n");
               Console.Write("\nSvar: ");
        
                try //testar att det är en gilltig input
                {
                    checkListPick = int.Parse(Console.ReadLine());

                }
                catch (Exception e) 
                {
                    Console.WriteLine(e.Message); //fel meddelande
                }
                if (checkListPick == 1 || checkListPick == 2 || checkListPick == 3 || checkListPick == 4)
                {
                    loopInput = false;
                }
            }
            return checkListPick;
        }

        static void Adjektiv()  //lägger in ord till listan kadjektivList
        {
            
            adjektivList.Add("Röd ");
            adjektivList.Add("Gul ");
            adjektivList.Add("Svart ");
            adjektivList.Add("Stark ");
            adjektivList.Add("Svag ");
            adjektivList.Add("Stor ");
            adjektivList.Add("Ung ");
            adjektivList.Add("Glad ");
            adjektivList.Add("Arg ");
            adjektivList.Add("Lesden ");
        }

        static void Adverb()  //lägger in ord till listan adverbList
        {
            adverbList.Add("Fort ");
            adverbList.Add("Ovanligt ");
            adverbList.Add("Mycket ");
            adverbList.Add("När ");
            adverbList.Add("Där ");
            adverbList.Add("Dit ");
            adverbList.Add("Inte ");
            adverbList.Add("Ner ");
            adverbList.Add("Upp ");
            adverbList.Add("Efter ");
        }

        static void Interjektioner()  //lägger in ord till listan interjektionerList
        {
            interjektionerList.Add("Hej ");
            interjektionerList.Add("Usch ");
            interjektionerList.Add("Tick-Tack ");
            interjektionerList.Add("Boom ");
            interjektionerList.Add("God natt ");
            interjektionerList.Add("Skål ");
            interjektionerList.Add("Bravo ");
            interjektionerList.Add("Ja ");
            interjektionerList.Add("Pang ");
            interjektionerList.Add("Fy ");
        }
        
        static void Konjuktioner() //lägger in ord till listan konjuktionerList
        {
            konjuktionerList.Add("Och ");
            konjuktionerList.Add("Eller ");
            konjuktionerList.Add("Utan ");
            konjuktionerList.Add("Men ");
            konjuktionerList.Add("För ");
            konjuktionerList.Add("Fast ");
            konjuktionerList.Add("Varken ");
            konjuktionerList.Add("Att ");
            konjuktionerList.Add("När ");
            konjuktionerList.Add("Som ");
        }

    }
}
