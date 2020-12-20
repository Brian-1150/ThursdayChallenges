using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace DrofsnarChallenge {
    public class DrofsnarRepo {

        public int Bird = 10;
        public int CrestedIbi = 100;
        public int GreatKiskudee = 300;
        public int RedCrossbill = 500;
        public int ReNeckedPhalarope = 700;
        public int EveningGrosbeak = 1000;
        public int GreaterPrairiedChicken = 2000;
        public int IcelandGull = 3000;
        public int OrangeBelliedParrot = 5000;





        public List<int> FinalScore(List<string> list) {
            List<int> results = new List<int>();
            Stopwatch s = new Stopwatch();
            bool x = false;
            int total = 5000;
            int count = 0;
            int lives = 3;
            foreach (string input in list) {
                if (x == true) {
                    
                    switch (input) {
                        case "Bird":
                            total += 10;
                            break;
                        case "CrestedIbis":
                            total += 100;
                            break;
                        case "Greatkiskudee":
                            total += 300;
                            break;
                        case "RedCrossbill":
                            total += 500;
                            break;
                        case "Red-neckedPhalarope":
                            total += 700;
                            break;
                        case "EveningGrosbeak":
                            total += 1000;
                            break;
                        case "GreaterPrairieChicken":
                            total += 2000;
                            break;
                        case "IcelandGull":
                            total += 3000;
                            break;
                        case "Orange-belliedParrot":
                            total += 5000;
                            break;
                        case "stopper":
                            s.Stop();
                            s.Start();
                            break;
                        case "VulnerableBirdHunter":
                            if (count == 0) { total += 200; }
                            if (count == 1) { total += 400; }
                            if (count == 2) { total += 800; }
                            if (count >= 3) { total += 1600; }
                            count++;
                            break;
                        default: break;

                    }
                    if (s.Elapsed >= TimeSpan.FromMilliseconds(.49999999999999996)) {
                        s.Stop();
                        x = false;

                    }
                }

                else {
                    switch (input) {
                        case "Bird":
                            total += 10;
                            break;
                        case "CrestedIbis":
                            total += 100;
                            break;
                        case "Greatkiskudee":
                            total += 300;
                            break;
                        case "RedCrossbill":
                            total += 500;
                            break;
                        case "Red-neckedPhalarope":
                            total += 700;
                            break;
                        case "EveningGrosbeak":
                            total += 1000;
                            break;
                        case "GreaterPrairieChicken":
                            total += 2000;
                            break;
                        case "IcelandGull":
                            total += 3000;
                            break;
                        case "Orange-belliedParrot":
                            total += 5000;
                            break;
                        case "stopper":
                            s.Start();
                            x = true;
                            break;
                        case "VulnerableBirdHunter":
                            lives--;
                            break;
                        default: break;

                    }
                }
                
            }
            results.Add(total);
            results.Add(lives);
            return results;
        }
    }
}
