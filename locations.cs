using System;
using PlayerCharacter;

namespace LocationSpace
{
    public class LocationEngine
    {
        Character Player = new Character();
        public string Location;
        public void GoToLocation(bool MenuDecision)
        {
            
            switch (Location)
            {
                case "town":
                    Console.Write("\r\nArriving at: Town\r\n");
                    Console.ReadLine();
                    //Town();
                    break;

                default:
                    Console.Write("\nInvalid location\n\n");
                    break;
            }
        }
        public LocationEngine(ref Character CurrentPlayer)
        {
            Location = CurrentPlayer.CharacterLocation;
            Player = CurrentPlayer;
            Location = Player.CharacterLocation;
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
        }
    }
}
