using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;
using System.Numerics;
using System.Diagnostics;
using DungeonLibrary;

namespace Dungeon
{
    internal class DungeonApp
    {

        static void Main(string[] args)
        {

            Console.Title = "Dragon Hunter";
            Console.WriteLine("Welcome, you brave and reckless soul!");
            Console.Clear();

            Console.WriteLine("You enter a large spooky house.\n" +
                GetRooms());

            #region
            //TODO - Create Rooms and randomize
            #endregion

            #region Variable to keep score
            int score = 0;

            #endregion

            #region Weapon Creation
            //TODO - Weapon
            #endregion



            bool exit = false;
            do
            {

                #region Monster
                //TODO Create Monster

                #endregion



                bool reload = false;
                do
                {
                    Console.WriteLine("Please choose an action: \n" +
                        "A) Attack\n" +
                        "R) Run Away\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "X) Exit\n"
                        );

                    ConsoleKey userChoice = Console.ReadKey(true).Key;//Executes upon input, without hitting enter

                    Console.Clear();

                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            Console.WriteLine("Attack!");
                            break;
                        case ConsoleKey.R:
                            Console.WriteLine("Run away!");
                            break;
                        case ConsoleKey.P:
                            Console.WriteLine("Player info");
                            break;
                        case ConsoleKey.M:
                            Console.WriteLine("Monster");
                            break;
                        case ConsoleKey.X:
                            Console.WriteLine("Leaving so soon?");
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Thanks for playing!");
                            exit = true;
                            break;
                    }
                    int user = 0;
                    if (user < 1)
                    {
                        Console.WriteLine("You have perished!");
                        exit = true;
                    }

                } while (!exit && !reload);





            } while (!exit);//While exit not true keep looping

            #region Output Final Score
            //TODO output final score and end the game
            #endregion


        }

        public static string GetRooms()
        {
            string[] rooms =
            {
                "It's a pitch black room you can't see anything but you can hear...something or someone is breathing right behind you",
                "The dim room start to illuminate and it's full of mirrors. You see movement but all of the reflections confuse you.",
                "Fog gently rolls across the floor and in front of you is a shadowy figure coming right toward you!",
                "You don't see but FEEL something brush past you then hear a low growl. It's hunting you.",
                "Your childhood room appears except it looks like it's been abandoned for a century with thick dust and cobwebs.",
                "It's the DMV.",
                "I thought Saw was just a movie, maybe this room is just a movie set..",
                "Bars on the windows, bars on the doors. I can't tell if this is a jail or a medievil torture chamber.",
                "An abandoned store.",
                "A sinister dark humid room with an odd mechanical creaking",
                "A backwoods doctor's office with rusty tools strew about.",
                "It's a pitch black room you can't see anything except glowing eyes",
                "It's a dark room you can make out a glooming monster taking a keen interest in you.",
                "A cellar of some type floor to ceiling full of plushies?",
                "Sir this is a Wendy's said a monster staring at me",
                "I didn't know Kmart still had buildings. What's that scratching noise?",
                "I miss Toys'R'Us but this one looks haunted and someone or SOMETHING is here already. ",
                "I've never seen an unhappy Hallmark so this has to be a dream. The clerk looks angry!",
                "This grocery store has nothing but grusome bloody body parts and a very mad...thing...whatever it is it wants to talk to the manager.",
                "Rainbow Road from Mario Kart but with a monster that's mad I cut him off...he wants me to get out of my toad kart",
                "This is the Dentist's office but the Dentist looks like he'd rather knock my teeth out.",
                "What a cute room! There's a papasan. I didn't notice right away but someone is sitting in the papasan...."

            };
            Random roomRand = new Random();
            int index = roomRand.Next(rooms.Length);
            string room = rooms[index];
            return room;
        }
    }
}
