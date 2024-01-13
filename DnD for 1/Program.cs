using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DnD_for_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //honestly kinda don't know why it works, but I made it work
            Utils Use = new Utils();
            Story UseStory = new Story();
            
            Use.DMSpeak("Hello there new player. I am your Dungeon Master. What is your name?");
            string name = Console.ReadLine();
            Use.DMSpeak($"Very well {name},which class do you wish to choose. \n Assasin is quick and stealthy, with a swift short blade \n Barbarian is big and strong with a large axe \n The Rangers bow rarely misses");
            string[] options = { "Assasin", "Barbarian", "Ranger" };
            int chosenClass = Use.ReadInput(options);
            Player Player1 = new Player(name, chosenClass);

            
            UseStory.FirstQuest();
            Use.Combat(Player1, 1, 10, "goblin");
            UseStory.SecondQuest();
            Console.ReadKey();
    }
}
}
