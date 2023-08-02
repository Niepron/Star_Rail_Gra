using System;
using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;

namespace Star_Rail_Gra
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Witaj UŻYTKOWNIKU");
            Console.WriteLine("");
            Console.WriteLine("tutaj możesz spełnić swe marzenia w dostawaniu postaci:)");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Żeby poznać zasady działania programu wpisz 'zasady' i naciśnij Enter.");
            Console.WriteLine("Jeśli chcesz prześć odrazu do Whisowania na baner z postaciami napisz 'gra' i wciśnij Enter.");
            Console.WriteLine("Jeśli chcesz prześć odrazu do Whisowania na baner z bornią napisz 'bron' i wciśnij Enter.");
            Console.WriteLine("Jeśli chcesz wyjść wpisz 'exit'.");
            Console.WriteLine("");
            Console.Write(">");
            string wybór = (Console.ReadLine());
            switch (wybór)
            {
                case "zasady":
                    Menu();
                    break;
                case "gra":
                    Gra();
                    break;
                case "bron":
                    Bron();
                    break;
                case "exit":
                    System.Environment.Exit(0);
                    break;
                default:
                    Main();
                    break;
            }
            Console.ReadKey();
        }

        static void Gra()//...................................................POSTACIE
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Witaj w Banerze z postaciami");
            Console.WriteLine("");
            Console.WriteLine("Żeby wyjść wpisz 'menu' ");
            Console.WriteLine("");
            Console.WriteLine("Wpisz jeden lub dycha żeby losować");
            double ilosc_wishy = 0;
            double ilosc_wishy10 = 0;
            while (1 == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.Write(">");
                Console.ForegroundColor = ConsoleColor.White;
                string wish = Console.ReadLine();
                switch (wish)
                {
                    case "jeden":
                        ilosc_wishy = ilosc_wishy + 1;
                        ilosc_wishy10 = ilosc_wishy10 + 1;
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("yay zrobiłeś wisha");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("");
                        Silnik(ref ilosc_wishy, ref ilosc_wishy10);
                        Console.WriteLine("");
                        Console.WriteLine("Twoje pity to: " + ilosc_wishy);
                        Console.WriteLine("Twoje pity na 4 star to: " + ilosc_wishy10);

                        break;
                    case "dycha":
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("yay zrobiłeś 10 wishy");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("");
                        for (int DY = 0; DY < 10; DY++)
                        {
                            ilosc_wishy = ilosc_wishy + 1;
                            ilosc_wishy10 = ilosc_wishy10 + 1;
                            Silnik(ref ilosc_wishy, ref ilosc_wishy10);
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Twoje pity to: " + ilosc_wishy);
                        Console.WriteLine("Twoje pity na 4 star to: " + ilosc_wishy10);
                        break;
                    case "menu":
                        ilosc_wishy = 0;
                        ilosc_wishy10 = 0;
                        Main();
                        break;
                    default:
                        Gra();
                        break;
                }
            }
        }

        static double Silnik(ref double ilosc_wishy, ref double ilosc_wishy10)//.......................SILNIK POSTACI
        {
            string[] postacie4 = { "Arlan", "Asta", "Dan Heng", "Herta", "Hook", "March 7th", "Natasha", "Pela", "Qingque", "Sampo", "Serval", "Sushang", "Tingyun", "Yukong" };
            string[] postacie5 = { "Bailu", "Blade", "Bronya", "Clara", "Gepart", "Himeko", "Jing Yuan", "Loucha", "Seele", "Silver Wolf", "Welt", "Yanqing" };
            string[] bron3 = { "Adversarial", "Amber", "Arrows", "Chorus", "Collapsing Sky", "Cornucopia", "Darting Arrow", "Data Bank", "Defense", "Fine Fruit", "Hidden Shadow", "Loop", "Mediation", "Meshing Cogs", "Multiplication", "Mutual Demise", "Passkey", "Pioneering", "Sagacity", "Shattered Home", "Void" };
            string[] bron4 = { "A Secret Vow", "Dance! Dance! Dance!", "Day One of My New Life", "Eyes of the Prey", "Geniuses' Repose", "Good Night and Sleep Well", "Landau's Choice", "Make the World Clamor", "Memories of the Past", "Only Silence Remains", "Perfect Timing", "Planetary Rendezvous", "Post-Op Conversation", "Resolution Shines As Pearls of Sweat", "Shared Feeling", "Subscribe for More!", "Swordplay", "The Birth of the Self", "The Moles Welcome You", "Trend of the Universal Market", "Under the Blue Sky" };
            string[] bron5 = { "Before Dawn", "But the Battle Isn't Over", "Echoes of the Coffin", "In the Name of the World", "In the Night", "Incessant Rain", "Moment of Victory", "Night on the Milky Way", "Sleep Like the Dead", "Something Irreplaceable", "The Unreachable Side", "Time Waits for No One" };
            Random random = new Random();
            int i = random.Next(0, 100001);
            if (ilosc_wishy >= 0 && ilosc_wishy < 75 && ilosc_wishy10 % 10 != 0)
            {
                if (i >= 0 && i <= 94299) // 3 star
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    int bron3r = random.Next(0, 21);
                    Console.WriteLine(bron3[bron3r]);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (i >= 94300 && i <= 99399) //4 star
                {
                    int los2 = random.Next(0, 5101);
                    if (los2 <= 2549) // postacie
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        int postac4r = random.Next(0, 13);
                        Console.WriteLine(postacie4[postac4r]);
                        Console.ForegroundColor = ConsoleColor.White;
                        ilosc_wishy10 = 0;
                    }
                    else if (los2 >= 2550) // bronie 
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        int bron4r = random.Next(0, 21);
                        Console.WriteLine(bron4[bron4r]);
                        Console.ForegroundColor = ConsoleColor.White;
                        ilosc_wishy10 = 0;
                    }

                }
                else if (i >= 99400 && i < 100000) //5 star
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("............................");
                    Console.ForegroundColor = ConsoleColor.Red;
                    int postacie5r = random.Next(0, 11);
                    Console.WriteLine(postacie5[postacie5r]);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("............................");
                    Console.ForegroundColor = ConsoleColor.White;
                    ilosc_wishy = 0;

                }

            }
            else if (ilosc_wishy10 == 10)
            {
                if (i >= 99400 && i < 100000) // 5 star
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("............................");
                    Console.ForegroundColor = ConsoleColor.Red;
                    int postacie5r = random.Next(0, 11);
                    Console.WriteLine(postacie5[postacie5r]);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("............................");
                    Console.ForegroundColor = ConsoleColor.White;
                    ilosc_wishy = 0;
                    ilosc_wishy10 = 0;
                }
                else if (i >= 0 && i <= 99399) //4 star
                {
                    int los2 = random.Next(0, 5101);
                    if (los2 <= 2549) // postacie
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        int postac4r = random.Next(0, 13);
                        Console.WriteLine(postacie4[postac4r]);
                        Console.ForegroundColor = ConsoleColor.White;
                        ilosc_wishy10 = 0;
                    }
                    else if (los2 >= 2550) // bronie 
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        int bron4r = random.Next(0, 21);
                        Console.WriteLine(bron4[bron4r]);
                        Console.ForegroundColor = ConsoleColor.White;
                        ilosc_wishy10 = 0;
                    }

                }
            }
            else if (ilosc_wishy >= 75 && ilosc_wishy < 90 && ilosc_wishy10 % 10 != 0)
            {
                if (i >= 0 && i <= 44999) // 5 star
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("............................");
                    Console.ForegroundColor = ConsoleColor.Red;
                    int postacie5r = random.Next(0, 11);
                    Console.WriteLine(postacie5[postacie5r]);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("............................");
                    Console.ForegroundColor = ConsoleColor.White;
                    ilosc_wishy = 0;
                }
                else if (i >= 45000 && i <= 50099) //4 star
                {
                    int los2 = random.Next(0, 5101);
                    if (los2 <= 2549) // postacie
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        int postac4r = random.Next(0, 13);
                        Console.WriteLine(postacie4[postac4r]);
                        Console.ForegroundColor = ConsoleColor.White;
                        ilosc_wishy10 = 0;
                    }
                    else if (los2 >= 2550) // bronie 
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        int bron4r = random.Next(0, 21);
                        Console.WriteLine(bron4[bron4r]);
                        Console.ForegroundColor = ConsoleColor.White;
                        ilosc_wishy10 = 0;
                    }

                }
                else if (i >= 50100 && i < 100000) //3 STAR
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    int bron3r = random.Next(0, 21);
                    Console.WriteLine(bron3[bron3r]);
                    Console.ForegroundColor = ConsoleColor.White;

                }
            }
            else if (ilosc_wishy == 90) //5 star
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("............................");
                Console.ForegroundColor = ConsoleColor.Red;
                int postacie5r = random.Next(0, 11);
                Console.WriteLine(postacie5[postacie5r]);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("............................");
                Console.ForegroundColor = ConsoleColor.White;
                ilosc_wishy = 0;
            }
            return ilosc_wishy;
        }


        static void Bron()// BANER Z BRONIAMI ...................................................
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Witaj w Banerze z Bronią");
            Console.WriteLine("");
            Console.WriteLine("Żeby wyjść wpisz 'menu' ");
            Console.WriteLine("");
            Console.WriteLine("Wpisz jeden lub dycha żeby losować");
            double ilosc_wishyb = 0;
            double ilosc_wishy10b = 0;
            while (1 == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.Write(">");
                Console.ForegroundColor = ConsoleColor.White;
                string wish = Console.ReadLine();
                switch (wish)
                {
                    case "jeden":
                        ilosc_wishyb = ilosc_wishyb + 1;
                        ilosc_wishy10b = ilosc_wishy10b + 1;
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("yay zrobiłeś wisha");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("");
                        BronSilnik(ref ilosc_wishyb, ref ilosc_wishy10b);
                        Console.WriteLine("");
                        Console.WriteLine("Twoje pity to: " + ilosc_wishyb);
                        Console.WriteLine("Twoje pity na 4 star to: " + ilosc_wishy10b);

                        break;
                    case "dycha":
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("yay zrobiłeś 10 wishy");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("");
                        for (int DY = 0; DY < 10; DY++)
                        {
                            ilosc_wishyb = ilosc_wishyb + 1;
                            ilosc_wishy10b = ilosc_wishy10b + 1;
                            BronSilnik(ref ilosc_wishyb, ref ilosc_wishy10b);
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Twoje pity to: " + ilosc_wishyb);
                        Console.WriteLine("Twoje pity na 4 star to: " + ilosc_wishy10b);
                        break;
                    case "menu":
                        ilosc_wishyb = 0;
                        ilosc_wishy10b = 0;
                        Main();
                        break;
                    default:
                        Bron();
                        break;
                }
            }
        }




        static double BronSilnik(ref double ilosc_wishyb, ref double ilosc_wishy10b)//.......................SILNIK BRONI
        {
            string[] postacie4 = { "Arlan", "Asta", "Dan Heng", "Herta", "Hook", "March 7th", "Natasha", "Pela", "Qingque", "Sampo", "Serval", "Sushang", "Tingyun", "Yukong" };
            string[] bron3 = { "Adversarial", "Amber", "Arrows", "Chorus", "Collapsing Sky", "Cornucopia", "Darting Arrow", "Data Bank", "Defense", "Fine Fruit", "Hidden Shadow", "Loop", "Mediation", "Meshing Cogs", "Multiplication", "Mutual Demise", "Passkey", "Pioneering", "Sagacity", "Shattered Home", "Void" };
            string[] bron4 = { "A Secret Vow", "Dance! Dance! Dance!", "Day One of My New Life", "Eyes of the Prey", "Geniuses' Repose", "Good Night and Sleep Well", "Landau's Choice", "Make the World Clamor", "Memories of the Past", "Only Silence Remains", "Perfect Timing", "Planetary Rendezvous", "Post-Op Conversation", "Resolution Shines As Pearls of Sweat", "Shared Feeling", "Subscribe for More!", "Swordplay", "The Birth of the Self", "The Moles Welcome You", "Trend of the Universal Market", "Under the Blue Sky" };
            string[] bron5 = { "Before Dawn", "But the Battle Isn't Over", "Echoes of the Coffin", "In the Name of the World", "In the Night", "Incessant Rain", "Moment of Victory", "Night on the Milky Way", "Sleep Like the Dead", "Something Irreplaceable", "The Unreachable Side", "Time Waits for No One" };
            Random random = new Random();
            int i = random.Next(0, 100001);
            if (ilosc_wishyb >= 0 && ilosc_wishyb < 65 && ilosc_wishy10b % 10 != 0)
            {
                if (i >= 0 && i <= 92599) // 3 star
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    int bron3r = random.Next(0, 21);
                    Console.WriteLine(bron3[bron3r]);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (i >= 92600 && i <= 99199) //4 star
                {
                    int los2 = random.Next(0, 6600);
                    if (los2 <= 3299) // postacie
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        int postac4r = random.Next(0, 13);
                        Console.WriteLine(postacie4[postac4r]);
                        Console.ForegroundColor = ConsoleColor.White;
                        ilosc_wishy10b = 0;
                    }
                    else if (los2 >= 3300) // bronie 
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        int bron4r = random.Next(0, 21);
                        Console.WriteLine(bron4[bron4r]);
                        Console.ForegroundColor = ConsoleColor.White;
                        ilosc_wishy10b = 0;
                    }

                }
                else if (i >= 99200 && i < 100000) //5 star
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("............................");
                    Console.ForegroundColor = ConsoleColor.Red;
                    int bron5r = random.Next(0, 11);
                    Console.WriteLine(bron5[bron5r]);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("............................");
                    Console.ForegroundColor = ConsoleColor.White;
                    ilosc_wishyb = 0;

                }

            }
            else if (ilosc_wishy10b == 10)
            {
                if (i >= 99200 && i < 100000) // 5 star
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("............................");
                    Console.ForegroundColor = ConsoleColor.Red;
                    int bron5r = random.Next(0, 11);
                    Console.WriteLine(bron5[bron5r]);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("............................");
                    Console.ForegroundColor = ConsoleColor.White;
                    ilosc_wishyb = 0;
                    ilosc_wishy10b = 0;
                }
                else if (i >= 0 && i <= 99199) //4 star
                {
                    int los2 = random.Next(0, 6600);
                    if (los2 <= 3299) // postacie
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        int postac4r = random.Next(0, 13);
                        Console.WriteLine(postacie4[postac4r]);
                        Console.ForegroundColor = ConsoleColor.White;
                        ilosc_wishy10b = 0;
                    }
                    else if (los2 >= 3300) // bronie 
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        int bron4r = random.Next(0, 21);
                        Console.WriteLine(bron4[bron4r]);
                        Console.ForegroundColor = ConsoleColor.White;
                        ilosc_wishy10b = 0;
                    }

                }
            }
            else if (ilosc_wishyb >= 65 && ilosc_wishyb < 80 && ilosc_wishy10b % 10 != 0)
            {
                if (i >= 0 && i <= 44999) // 5 star
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("............................");
                    Console.ForegroundColor = ConsoleColor.Red;
                    int bron5r = random.Next(0, 11);
                    Console.WriteLine(bron5[bron5r]);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("............................");
                    Console.ForegroundColor = ConsoleColor.White;
                    ilosc_wishyb = 0;
                }
                else if (i >= 45000 && i <= 50099) //4 star
                {
                    int los2 = random.Next(0, 5101);
                    if (los2 <= 2549) // postacie
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        int postac4r = random.Next(0, 13);
                        Console.WriteLine(postacie4[postac4r]);
                        Console.ForegroundColor = ConsoleColor.White;
                        ilosc_wishy10b = 0;
                    }
                    else if (los2 >= 2550) // bronie 
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        int bron4r = random.Next(0, 21);
                        Console.WriteLine(bron4[bron4r]);
                        Console.ForegroundColor = ConsoleColor.White;
                        ilosc_wishy10b = 0;
                    }

                }
                else if (i >= 50100 && i < 100000) //3 STAR
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    int bron3r = random.Next(0, 21);
                    Console.WriteLine(bron3[bron3r]);
                    Console.ForegroundColor = ConsoleColor.White;

                }
            }
            else if (ilosc_wishyb == 80) //5 star
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("............................");
                Console.ForegroundColor = ConsoleColor.Red;
                int bron5r = random.Next(0, 11);
                Console.WriteLine(bron5[bron5r]);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("............................");
                Console.ForegroundColor = ConsoleColor.White;
                ilosc_wishyb = 0;
            }
            return ilosc_wishyb;
        }





        static void Menu()//Menu 
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("WITAJ W MENU");
            Console.WriteLine("");
            Console.WriteLine("Jest to najzwyczajniejszy w świecie symulator wishowania w Star Rail");
            Console.WriteLine("Zasady są proste jeśli chcesz zwishować za 1 wpisujesz 'Jeden' a jeśli za dychę wpisujesz 'dycha' ");
            Console.WriteLine("Pity jest liczone");
            Console.WriteLine("W grze jest uwzględnione soft pity!!!");
            Console.WriteLine("Nie ma gwaranta na postać czy broń!!");
            Console.WriteLine("Można cały czas zdobywać postacie z limitowanych banerów oraz ich Light Cone'y");
            Console.WriteLine("Miłej zabawy");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Żeby wrócić z powrotem wpisz 'menu' ");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(">");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string wybór2 = (Console.ReadLine());
            if (wybór2 == "menu")
            {
                Console.Clear();
                Main();
            }
            else
            {
                while (wybór2 != "menu")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Coś poszło nie tak, wpisz menu");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("");
                    Console.Write(">");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    wybór2 = (Console.ReadLine());
                    Console.WriteLine("");
                    if (wybór2 == "menu")
                    {
                        Console.Clear();
                        Main();
                    }
                }
            }
        }
    }
}// Stworzył Michał (Niepron)