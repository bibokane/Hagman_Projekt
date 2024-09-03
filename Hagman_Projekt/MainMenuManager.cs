using System;


namespace Hagman_Projekt
{
    internal class MainMenuManager
    {
        public static void MainMenu()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("### HANGMAN ###");
                Console.WriteLine("###############");
                Console.WriteLine();
                Console.WriteLine("Wähle eine Aktion aus: ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[1] Spielen");
                Console.WriteLine("[2] Beenden");
                Console.ResetColor();
                Console.WriteLine();

                Console.Write("Aktion: ");
                int action = Convert.ToInt32(Console.ReadLine());
                bool end = false;

                switch (action)
                {
                    case 1:
                        GameEngin.StartGame();
                        break;
                    case 2:
                        end = true;
                        break;
                }

                if (end)
                {
                    break;
                }
                Console.Clear();


            }



        }
    }
}
