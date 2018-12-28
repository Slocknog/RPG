using System;

namespace Main
{
    public class Location
    {
        public string GoToLocation(bool MenuDecision, string Location)
        {
            
            switch (Location)
            {
                case "town":
                    Console.Write("\r\nArriving at: Town\r\n");
                    Console.ReadLine();
                    return "Town";

                default:
                    Console.Write("\nInvalid location\n\n");
                    return "Invalid";
            }
        }

        /*public Town()
        {
            Console.WriteLine("\r\nPress any key to continue.\r\n");
            Console.ReadKey();
            string TownSelection = "";
            Console.WriteLine("\r\nYou are in Town.\r\n\r\nYou can 'explore' for encounters\r\nYou can use 'stats' to check your character\r\nOr you can 'sleep' to return to the main menu\r\n");
            TownSelection = Console.ReadLine();
            if (TownSelection == "sleep")
            {
                Player.CharacterLevel += 5;
                Console.WriteLine("");
                Player.CharacterStats();
                return;
            }
            else if (TownSelection == "stats")
            {
                Player.CharacterStats();
                return (Player);
            }
        }*/
    }
}
