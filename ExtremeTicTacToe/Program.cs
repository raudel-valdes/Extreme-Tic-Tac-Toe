using System;

namespace ExtremeTicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            int gameChoiceInt = -1;
            int terminateGame = 1;

            while(gameChoiceInt != terminateGame) {

                Console.WriteLine("\n\tWelcome to Extreme TIC-TAC-TOE! \n");
                Console.WriteLine("Please Choose An Option - Enter the Corresponding #: \n");
                Console.WriteLine("\t0) Multiplayer - Person VS. Person");
                Console.WriteLine($"\t{terminateGame}) Terminate the Game \n");

                Console.Write("Choice: ");
                string gameChoiceString = Console.ReadLine();

                if(string.IsNullOrEmpty(gameChoiceString)) 
                {
                    Console.WriteLine("Please Enter a correct game option: ");
                    enterToContinue();
                    continue;
                }

                try 
                {
                    gameChoiceInt = Int32.Parse(gameChoiceString);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    enterToContinue();
                    continue;
                }


                if (gameChoiceInt == terminateGame) 
                {
                    Console.WriteLine("\nGoodbye!");
                    return;
                } 

                if (gameChoiceInt > 0 || gameChoiceInt < 0) {
                    Console.WriteLine("\n\tPlease enter a correct game option. Available options: 0 - 1\n");
                    enterToContinue();
                    continue;
                } 

                switch(gameChoiceInt) {
                    case (0): 
                        
                        return;
                    case (1):
                        return;
                    case (2):
                        return;
                    case (3):
                        return;
                }
            }
        }

        public static void enterToContinue() {
            Console.WriteLine("\nClick Enter to Continue...\n");
            Console.ReadLine();
        }
    }
}
