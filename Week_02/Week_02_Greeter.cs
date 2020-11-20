using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_02 {
    public class Week_02_Greeter {

        public string Name { get; set; }


        /* Build a class called Greeter. This class will hold our next few methods.
      Inside our new class, build a method that takes in a name and then says hello to that person.
      Ex: If the method is given the name Joshua, the output should be "Hello Joshua"
      Build another method that outputs some sort of farewell to the name it is given as a parameter.
      Build a method that says Good Morning/Afternoon/Evening/Night depending on the time of day.
      New up an instance of your Greeter class inside your Main method. From this instance call all of the methods you've built out. */

            public void NameInputAndHello(string name) {
                Name = name;
                
               Console.WriteLine("Hello " + Name);

            }
        public void Farewell(string name) {
            Console.WriteLine($"Farewell {name}");

        }
        public void TimeDependentGreeting(string name) {
            int hour  = DateTime.Now.Hour;
            

            string greeting;
            if (hour >= 0 && hour < 12)
                greeting = "Morning";
            else if (hour > 11 && hour < 17)
                greeting = "Afternoon";
            else if (hour > 16 && hour < 21)
                greeting = "Evening";
            else
                greeting = "Night";
            Console.WriteLine($"Good {greeting} {name}!");

            
        }

        }
    }

