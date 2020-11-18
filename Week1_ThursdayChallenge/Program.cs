using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_ThursdayChallenge {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Challenge 1");  //challenge 1
            string super = "Supercalifragilisticexpialidocious";
            
            foreach (char letter in super) {  // challenge 1 Bonus
                if (letter == 'i')
                    Console.WriteLine("You are the letter " + letter);
                else if (letter == 'L')
                    Console.WriteLine('L'); // challenge 1 Bonus part 2
                else if (letter == 'l')
                    Console.WriteLine("But you are a lowercase " + letter);
                else  
                    Console.WriteLine("you are not at i or L");
              
            }
            int count = super.Length;
            Console.WriteLine(count); //challenge 1 Bonus

            string f = "Brian";   //challenge 2
            string l = "Campassi";
            int age = 40;

            //challenge 3
            string[] favMov = { "Interstellar", "Tombstone", "A Few Good Men", "Inception" };
            List<DateTime> days = new List<DateTime>();  //challenge 4
            days.Add(DateTime.Now);
            days.Add(new DateTime(1980, 10, 08));
            days.Add(new DateTime(2020, 6, 29));
            days.Add(new DateTime(2222, 1, 1));
            foreach (DateTime DateTime in days)
                Console.WriteLine(DateTime.ToString("MM/dd/yyyy"));  //remove time stamp


            Console.Write(7 + age);  // challenge 5
            Console.Write("in seven years I will be " + (age + 7));
            Console.Write("\nin seven years I will be " + (age + 7));

            Console.Write($"\nToday I am {age}");
            Console.Write("\n" + (age + 7) + "\n" + (age - 7 ));
            Console.Write("\n");   // just trying some things
            Console.WriteLine(age * 7);
            Console.WriteLine(age / 7);

            Console.Write("How many hours of sleep do you average per night? ");
            int hours = Convert.ToInt32(Console.ReadLine());
            if (hours > 9)                                          //challenge 6
                Console.WriteLine("Wow! That is a lot of sleep.");
            else if (hours > 8 && hours < 10)
                Console.WriteLine("You should be well rested.");
            else if (hours > 4 && hours < 8)
                Console.WriteLine("Bummer");
            else
                Console.WriteLine("OH NO!  Get some sleep");

            Console.Write("On a scale of 1 to 10, How is your day today?");
            int feeling = Convert.ToInt32(Console.ReadLine());
            string response;
            switch (feeling) {                                 //challenge 7
                case 1: response = ":( So Sorry"; break;
                case 2: response = "Uh Oh"; break;
                case 3: response = "Bad"; break;
                case 4: response = "Ok"; break;
                case 5: response = "Could be better"; break;
                case 6: response = "So-So"; break;
                case 7: response = "Good"; break;
                case 8: response = "Doesn't get much better than that"; break;
                case 9: response = "Great!"; break;
                case 10: response = "!!!AMAZING!!!BEST!!DAY!!EVER!!!"; break;
                default: response = "Sadly, you did not enter a valid feeling"; break;
            }
            Console.WriteLine( response);

            }





        }


    }

