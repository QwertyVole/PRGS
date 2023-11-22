using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace Deathroll
{
    internal class Program
    {
        
        
        static int roll(betRemaining) {
            Random rng = new Random();
            return rng.New(1; betRemaining);
            
            }
        static void Main(string[] args)
        {
            int round = 1;
            int goldPlayer = 1000;
            int goldComputer = 1000;
            int rolledNumber = 0;
            int bet = 0;
            bool nextPlayer = 0;//0= next player is computer, 1 = next player is player

            while(goldComputer !=0 || goldPlayer != 0)
            {
                do { 
                Console.WriteLine("You have" + goldPlayer + "gold");
                Console.WriteLine("How much do you want to bet?");
                bet = Convert.ToInt32(Console.ReadLine());
                    if (bet > goldPlayer)
                    Console.WriteLine("You don't have enough gold or you didnt bet anything, try again");
                    bet = 0;
                }while(bet = 0)
                bet = rolledNumber;
                while (rolledNumber != 1)
                {
                    rolledNumber = roll(rolledNumber);
                    if (rolledNumber = 1 && nextPlayer = 0) {
                        Console.WriteLine("Player lost");
                        goldPlayer = goldPlayer - bet;
                        rolledNumber = 0;
                    }else if (rolledNumber = 1 && nextPlayer = 1){
                        Console.WriteLine("Computer lost");
                        goldComputer = goldComputer - bet;
                        rolledNumber = 0;
                    }else nextPlayer = !nextPlayer;
                }
            }
            
            /*
             * Jednoduchy program na procviceni podminek a cyklu (lze udelat i rekurzi).
             * 
             * Vytvor program, kde bude uzivatel hrat s pocitacem deathroll.
             * Pravidla deathrollu: Prvni hrac navrhne cislo (puvodne ve wowku pocet goldu, o ktere se hraci vsadi) a "rollne" navrhnute cislo, jinak receno je to stejne,
             * jako kdyby si hodil kostkou s tolika stenami, jako je navrhnute cislo. Prvnimu hraci "padne" nejake cislo a druhy hrac si "rollne" padnute cislo.
             * Prohrava ten hrac, kteremu padne 1 jako prvnimu.
             * Ukazka hry: Hraci se shodnou na cisle 1000. Prvni hrac rollne 0-1000, padne mu 920. Druhy hrac rolluje 0-920, padne mu 235 atd. atd. az jednomu z hracu padne 1
             * a ten prohrava.
             * 
             * Struktura:
             * 
             * - nadefinuj promenne, ktere budes potrebovat po celou dobu hry, tedy aktualne rollovane cislo a stav "goldu" uzivatele i pocitace (oba zacinaji treba s 1000 goldu)
             * 
             * - uzivatel zada prvotni sazku, ktera musi byt maximalne tolik, kolik ma goldu
             * 
             * Opakuj dokud nepadne jednomu z hracu 1:
             * {
             *      Pokud je sude kolo:
             *      {
             *          - uzivatel zada hodnotu, kterou rolluje
             *          - kontroluj, ze uzivatel zadal spravnou hodnotu
             *          - uloz rollnute cislo
             *          - vypis uzivateli, co rollnul
             *      }
             *      Pokud je liche kolo:
             *      {
             *          - pocitac rollne nahodne cislo mezi 0 a aktualne rollovanym cislem
             *          - vypis uzivateli, co rollnul pocitac
             *      }
             * }
             * 
             * 
             * - posledni hrajici hrac prohral, protoze mu padla 1 a sazku bere druhy hrac
             * - vypis uzivateli kdo vyhral a stav goldu uzivatele i pocitace
             * 
             * ROZSIRENI:
             * - umozni uzivateli opakovat deathroll dokud ma nejake goldy
             */
        }
    }
}
