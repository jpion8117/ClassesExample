using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStuffs
{
    class SoccerPlayer
    {
        public enum Genders
        {
            MALE,
            FEMALE,
            MONKEY
        }

        /// <summary>
        /// this is a special type of method called a constructor. Notice it doesn't have a return type.
        /// </summary>
        /// <param name="name">Name of the player</param>
        /// <param name="jerseyNum">the player's jersey num</param>
        /// <param name="gender">the player's gender (this will default to MONKEY [not my idea] if no gender is chosen)</param>
        public SoccerPlayer(string name, int jerseyNum, Genders gender = Genders.MONKEY)
        {
            //sets the variable feilds of this instance of the class
            Name = name;
            JerseyNum = jerseyNum;
            Gender = gender;
        }

        /// <summary>
        /// Display player's info to the console
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name} Jersey#: {JerseyNum}");
        }

        //declares a variable that can used from anywhere in the program but only set from within the class
        public string Name
        {
            get; // tells the program you can access this variable from anywhere
            private set; // tells the program you can ONLY set the variable from within this class
        }
        //declares a variable that can used from anywhere in the program but only set from within the class
        public int JerseyNum
        {
            get; // tells the program you can access this variable from anywhere
            private set; // tells the program you can ONLY set the variable from within this class
        }
        //declares a variable that can used from anywhere in the program but only set from within the class
        public Genders Gender
        {
            get; // tells the program you can access this variable from anywhere
            private set; // tells the program you can ONLY set the variable from within this class
        }
    }
}
