using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_for_1
{
    class Utils
    {
        public void DwarfSpeak(string a)
        {
            //for when the NPC Dwarf speaks
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Dwarf:"+ a + Environment.NewLine);
        }
        public void DMSpeak(string a)
        {
            //for when the DM speaks
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(a + Environment.NewLine);
        }
        public int ReadInput(string[] options)
        {
            //Input verification and processing, takes in an array of strings with all acceptable options
            //TODO: make it not case sensitive


            bool repeat = true;
            while (repeat == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Type in one of the options");
                foreach (string element in options)
                {
                    Console.WriteLine($"{element}");
                }
                Console.WriteLine("-------------------------------------");

                string input = Console.ReadLine();
                int output = Array.IndexOf(options, input);
                if (output == -1)
                {
                    DMSpeak("This is not an option");
                }
                else
                {
                    repeat = false;
                    return output;
                }
            }
            return -1;

        }
        public void CombatPlayerTurn(Player player, Enemy enemy)
        {
            //Player input for combat
            DMSpeak("It is your turn what do you do?");
            DMSpeak($"Attack \n Go closer \n get further away");
            string[] options = { "Attack", "Closer", "Away" };
            int option = ReadInput(options);
            switch (option)
            {
                case 0:
                    {
                        if (enemy.distance <= player.range)
                        {
                            Random rnd = new Random();
                            Console.WriteLine("guess a number between one and six");
                            string[] optionsNum = { "1", "2", "3", "4", "5", "6" };
                            int playerInput = ReadInput(optionsNum);
                            int computerInput1 = rnd.Next(1, 6);
                            int computerInput2 = rnd.Next(1, 6);
                            int multiplier;
                            if (playerInput == computerInput1)
                                multiplier = 5;
                            else if (playerInput == computerInput2)
                                multiplier = 0;
                            else
                                multiplier = 1;


                            enemy.hp = enemy.hp - (player.dmg * multiplier);
                        }
                        else
                        {
                            DMSpeak($"You are {enemy.distance - player.range}m too far away, and your weapon does not have enough reach, better luck next time ");
                        }
                        break;
                    }
                case 1:
                    {
                        enemy.distance -= 10;
                        break;
                    }
                case 2:
                    {
                        enemy.distance += 10;
                        break;
                    }
                default:
                    break;
            }
        }
        public void CombatComputerTurn(Player player, Enemy enemy)
        {
            //So the enemies fight back at least a bit
            Random rnd = new Random();
            int option = rnd.Next(0, 4);
            switch (option)
            {
                case 0:
                    {
                        if (enemy.distance <= enemy.range)
                        {
                            enemy.hp = enemy.hp - player.dmg;
                        }
                        else
                        {
                            DMSpeak($"The {enemy.name} tried to attack you but was too far away");
                        }
                        break;
                    }
                case 1:
                    {
                        enemy.distance -= 10;
                        DMSpeak("Enemy moved 10 meters closer");
                        break;
                    }
                case 2:
                    {
                        enemy.distance += 10;
                        DMSpeak("Enemy moved 10 meters away");
                        break;
                    }
                default:
                    break;
            }
        }
        public void Combat(Player player, int strength, int distance, string name)
        {
            //Turn system and winner validation for combat

            Enemy enemy = new Enemy(strength, distance, name);
            bool repeat = true;
            while (repeat == true)
            {
                CombatPlayerTurn(player, enemy);
                if (enemy.hp <= 0)
                {
                    DMSpeak($"You have defeated the {enemy.name}");
                    repeat = false;
                }
                else
                {
                    CombatComputerTurn(player, enemy);
                }
                if (player.hp <= 0)
                {
                    DMSpeak($"You have been defeated by the {enemy.name}. Farewell and may the gods be merciful");
                    repeat = false;
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
        }
    }
}




