using System;

namespace RandomnumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Random randomnumber = new Random();
            int answer = randomnumber.Next(100) + 1;
            string Titel = @"

████████╗██╗  ██╗███████╗    ██████╗  █████╗ ███╗   ██╗██████╗  ██████╗ ███╗   ███╗    ███╗   ██╗██╗   ██╗███╗   ███╗██████╗ ███████╗██████╗      ██████╗  █████╗ ███╗   ███╗███████╗
╚══██╔══╝██║  ██║██╔════╝    ██╔══██╗██╔══██╗████╗  ██║██╔══██╗██╔═══██╗████╗ ████║    ████╗  ██║██║   ██║████╗ ████║██╔══██╗██╔════╝██╔══██╗    ██╔════╝ ██╔══██╗████╗ ████║██╔════╝
   ██║   ███████║█████╗      ██████╔╝███████║██╔██╗ ██║██║  ██║██║   ██║██╔████╔██║    ██╔██╗ ██║██║   ██║██╔████╔██║██████╔╝█████╗  ██████╔╝    ██║  ███╗███████║██╔████╔██║█████╗  
   ██║   ██╔══██║██╔══╝      ██╔══██╗██╔══██║██║╚██╗██║██║  ██║██║   ██║██║╚██╔╝██║    ██║╚██╗██║██║   ██║██║╚██╔╝██║██╔══██╗██╔══╝  ██╔══██╗    ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝  
   ██║   ██║  ██║███████╗    ██║  ██║██║  ██║██║ ╚████║██████╔╝╚██████╔╝██║ ╚═╝ ██║    ██║ ╚████║╚██████╔╝██║ ╚═╝ ██║██████╔╝███████╗██║  ██║    ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗
   ╚═╝   ╚═╝  ╚═╝╚══════╝    ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═════╝  ╚═════╝ ╚═╝     ╚═╝    ╚═╝  ╚═══╝ ╚═════╝ ╚═╝     ╚═╝╚═════╝ ╚══════╝╚═╝  ╚═╝     ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝
                                                                                                                                                                                     
";
            Console.WriteLine(Titel);
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Hallo ich habe mir ein Zahl zwischen 1 und 100 ausgedacht errate sie!");
            Console.WriteLine("------------------------------------------------------------------------");
            int userGuess;
            int versuche = 1;
            int continuesupport = 187;
            while (continuesupport == 187)
            try
            {


                userGuess = System.Convert.ToInt32(Console.ReadLine());

                while (userGuess != answer)
                {
                                  
                    while (userGuess < 1 || userGuess > 100)
                    {
                        Console.WriteLine("Bitte gib eine gültige Zahl ein");
                        Console.WriteLine("-------------------------------------------------");
                        userGuess = System.Convert.ToInt32(Console.ReadLine());
                        versuche++;
                    }
                    if (userGuess < answer)
                    {
                        Console.WriteLine("Deine Zahl ist kleiner als die Zahl die du erraten musst");
                        Console.WriteLine("--------------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("Deine Zahl ist grösser als die Zahl die du erraten musst");
                        Console.WriteLine("--------------------------------------------------------");
                    }
                    userGuess = System.Convert.ToInt32(Console.ReadLine());
                    versuche++;
                }


                

                
                if (userGuess == answer)
                {
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("Korrekt!");
                    Console.WriteLine("Du hast " + versuche + " gültige versuche gebraucht");
                }


            }
            catch
            {
                versuche++;
                Console.WriteLine("Unglültige Eingabe");
                continue;  
            }   
           
              
            
        }
    }
}
