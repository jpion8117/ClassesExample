using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStuffs
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciate the variable declared at the bottom
            players = new List<SoccerPlayer>();
                
            //call the add players method to add the players to the list
            AddPlayers();

            //loop through the players list "List<SoccerPlayer> players"
            foreach (SoccerPlayer player in players)
            {
                //display every player who's JerseyNum is greater than 100
                if (player.JerseyNum >= 100)
                {
                    //calls this player's DisplayInfo method and gets the data that corrisponds to them and only them.
                    player.DisplayInfo();
                }
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        static void AddPlayers()
        {
            //dispite not passing the variable "players" to this method or declaring it locally, it can still be accessed
            //and modified here
            players.Add(new SoccerPlayer("Jim", 42, SoccerPlayer.Genders.FEMALE));
            players.Add(new SoccerPlayer("Paul", 39, SoccerPlayer.Genders.MONKEY));
            players.Add(new SoccerPlayer("IDFK", 420, SoccerPlayer.Genders.FEMALE));
            players.Add(new SoccerPlayer("bubba", 41, SoccerPlayer.Genders.MONKEY));
            players.Add(new SoccerPlayer("heinz", 57, SoccerPlayer.Genders.MALE));
            players.Add(new SoccerPlayer("s'tan", 666, SoccerPlayer.Genders.MALE));
            players.Add(new SoccerPlayer("Pete", 2, SoccerPlayer.Genders.MALE));
        }

        //this variable is now accessible by any method in the "Program" class
        static List<SoccerPlayer> players;
    }
}
