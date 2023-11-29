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
                "",
                "",
                "",
            };
            Random roomRand = new Random();
            int index = roomRand.Next(rooms.Length);
            string room = rooms[index];
            return room;
        }
    }
}
