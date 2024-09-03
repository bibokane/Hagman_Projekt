using System;


namespace Hagman_Projekt
{
    class GameEngin
    {
        public static void StartGame()
        {
            string[] words = new string[]
            {
                "Apfelkuchen",
                "Schnitzel",
                "Gemüsesuppe",
                "Kraftfahrzeug",
                "Lastwagen",
                "Videospiel",
                "Alarmanlage",
                "Vollkornbrott"
            };

            Random rand = new Random();
            int index = rand.Next(0, words.Length);
            string word = words[index].ToLower();
            GameLoopManager.GameLoop(word);
        }
    }
}
