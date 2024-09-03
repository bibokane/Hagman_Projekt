using System;


namespace Hagman_Projekt
{
    class GameLoopManager
    {
        public static void GameLoop(string word)
        {
            int lives = 10;
            string hiddenword = "";
            for (int i = 0; i < word.Length; i++)
            {
                hiddenword += "_";
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Gesuchtes Wort: " + hiddenword);
                Console.Write("Noch übrige Versuche: ");
                for (int i = 0; i < lives; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("*");
                    Console.ResetColor();
                }
                Console.WriteLine();
                Console.Write("Buchstabe: ");
                char character = Convert.ToChar(Console.ReadLine().ToLower());

                bool foundCharakterInWord = false;

                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == character)
                    {
                        foundCharakterInWord = true;
                        break;
                    }
                }

                string tempHiddenWord = hiddenword;
                hiddenword = "";

                if (foundCharakterInWord)
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == character) { hiddenword += character; }
                        else if (tempHiddenWord[i] != '_') { hiddenword += tempHiddenWord[i]; }
                        else { hiddenword += '_'; }
                    }
                    if (hiddenword == word)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("GEWONNEN!");
                        Console.WriteLine("Das Wort war: " + word);
                        Console.ReadKey();
                        Console.ResetColor();
                        break;
                    }
                }

                else
                {
                    hiddenword = tempHiddenWord;
                    if (lives > 0)
                    {
                        lives -= 1;
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("GAME OVER!");
                        Console.ReadKey();
                        Console.ResetColor();
                        break;
                    }
                }

            }
        }
    }
}
