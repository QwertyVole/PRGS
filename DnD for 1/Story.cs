using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_for_1
{
    public class Story
    {
        Utils Use = new Utils();

        public void FirstQuest()
        {
            //first quest, where the Player meets a dwarfs who offers him a job, abbility to accept and deny the quest
            Use.DMSpeak($"A Dwarf comes by to you and says:");
            Use.DwarfSpeak($"Are you the adventurer, about whom the whole town is yapping about? I have a job for you. You interested");

            string[] options2 = { "Yes", "No" };
            int e = Use.ReadInput(options2);
            if (e == 1)
            {
                Use.DwarfSpeak("Well go f$&k yourself then");
                Use.DMSpeak("The Dwarfs throws a pint your way, which hits you in the head and kills you instantly");
                Use.DMSpeak("Game over");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
            Use.DwarfSpeak("Great, come with me on a journey to the mountains. The goods I carry Are very valuable, and so I want a bodyguard to acompany me  ");
            Use.DMSpeak("And so you set of on a journey to the mountains");
            Use.DMSpeak("Week and a half later, you are going through a mountain pass when all of a sudden two gobblins attack you");

        }
        public void SecondQuest()
        {
            //TODO make it interesting
            Use.DwarfSpeak("Wow, that was really inpresive, I'm shure glad I brought you along");
            Use.DMSpeak("As you stroll along to find a place to camp for the night, you hear a strange noise, Do you go to Investigate?");
        }
    }
}
