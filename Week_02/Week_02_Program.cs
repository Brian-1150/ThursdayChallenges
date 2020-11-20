using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_02 {
    class Week_02_Program {
        static void Main(string[] args) {


            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();

            Week_02_Greeter userInput = new Week_02_Greeter();
            userInput.NameInputAndHello(name);
            userInput.Farewell(name);
            userInput.TimeDependentGreeting(name);
            


        }
    }
}
