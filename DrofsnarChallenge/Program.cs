using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrofsnarChallenge;

namespace DrofsnarChallenge {
    
   public class Program {
        static void Main(string[] args) {
        DrofsnarRepo _repo = new DrofsnarRepo();

            Console.WriteLine("Enter the sequence");
            
            List<string> listOfActions = Console.ReadLine().Split(',').ToList();
            
            List<int> returnedList = _repo.FinalScore(listOfActions);
            Console.WriteLine($"The final score is {returnedList.ElementAt(0)}\n" +
                              $"Number of lives remaining: {returnedList.ElementAt(1)}");

        }
    }
}
