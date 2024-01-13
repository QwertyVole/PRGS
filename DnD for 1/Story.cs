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

            string[] optionsYN = { "Yes", "No" };
            int e = Use.ReadInput(optionsYN);
            if (e == 1)
            {
                Use.DwarfSpeak("Well go f$&k yourself then");
                Use.DMSpeak("The Dwarfs throws a pint your way, which hits you in the head and kills you instantly");
                Use.DMSpeak("Game over");
                Console.ReadKey();
                Environment.Exit(0);
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
            string[] optionsYN = { "Yes", "No" };

            if(Use.ReadInput(optionsYN) == 0)
            {
                Use.DMSpeak("As you search through the forest , you suddenly hear a crack behind you, you turn around and see a big goblin comming to rip your head off");
            }
            else{
                Use.DMSpeak("You went to sleep and in the middle of a night woke up to find out a big gobblin is ravaging your camp, you quickly put something on and confront him");

            }
        }
        public void Outro()
        {
            Use.DMSpeak("You finnish off the goblin and as you look around you see your dwarf friend laying on the ground in agony, with a puddle of blood forming underneath him");
            Use.DwarfSpeak($"What a shame, I thought I will die in battle alongside my bretheren and instead I was a midnight snack for an oversized cucumber. I hope you will have more luck. Farewell....");
            Use.DMSpeak("If you wish to continue this journey, send 50EUR to 3970249003/5500 . See ya!");
        }
    }
}
