using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace ArrayPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové pole a naplň ho pěti čísly.
            int[] myArray = {0, 1, 2, 3, 4, 5};

            //TODO 2: Vypiš do konzole všechny prvky pole, zkus klasický for, kde i využiješ jako index v poli, a foreach (vysvětlíme si).
            foreach(int element in myArray)
                Console.WriteLine(element);
            Console.WriteLine(Environment.NewLine);
            //TODO 3: Spočti sumu všech prvků v poli a vypiš ji uživateli.
            int sum = 0;
            foreach(int element in myArray)
                sum += element;
            Console.WriteLine(sum + Environment.NewLine);
            //TODO 4: Spočti průměr prvků v poli a vypiš ho do konzole.
            int average = 0;
            foreach(int element in myArray)
                average += element;
            average = average / myArray.Length;
            Console.WriteLine(average + Environment.NewLine);
            //TODO 5: Najdi maximum v poli a vypiš ho do konzole.
            int max = myArray[0];
            foreach(int element in myArray)
            {
                if(element > max)
                    max = element;
            }
            Console.WriteLine(max + Environment.NewLine);

            //TODO 6: Najdi minimum v poli a vypiš ho do konzole.
            int min = myArray.Min();


            //TODO 7: Vyhledej v poli číslo, které zadá uživatel, a vypiš index nalezeného prvku do konzole.
            int index;
            Console.WriteLine("Zadejte hledane cislo v indexu");
            int userInput = Convert.ToInt32(Console.ReadLine());
            index = Array.Find(myArray, element => element == userInput); //inspiration from https://learn.microsoft.com/en-us/dotnet/api/system.array.find?view=net-7.0
            Console.WriteLine(index); 
            //TODO 8: Změň tvorbu integerového pole tak, že bude obsahovat 100 náhodně vygenerovaných čísel od 0 do 9. Vytvoř si na to proměnnou typu Random.
            myArray = new int[100];
            Random rng = new Random();
            Console.WriteLine(Environment.NewLine + "8)100 random čísel");
            for(int i = 0; i < 100; i++)
            {
                myArray[i] = rng.Next(0, 10);
                Console.WriteLine(Environment.NewLine + myArray[i]);
            }
            //TODO 9: Spočítej kolikrát se každé číslo v poli vyskytuje a spočítané četnosti vypiš do konzole.
            int[] counts = new int[10];
            for(int i = 0; i < counts.Length; i++)
            {
               counts[myArray[i]]++;
            }
            foreach(int element in counts)
            {
                Console.WriteLine(element);
            }

            //TODO 10: Vytvoř druhé pole, do kterého zkopíruješ prvky z prvního pole v opačném pořadí.
            int[] reverseArray = new int[100];
            for(int i = reverseArray.Length -1; i >= 0; --i)
            {
                reverseArray[99 - i] = myArray[i];
            }
            Console.ReadKey();
        }
    }
}

