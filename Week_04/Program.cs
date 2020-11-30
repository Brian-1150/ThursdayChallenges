using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week_04 {
    class Program {
       // private AbstractGamesClass _test = new AbstractGamesClass();
        //private BoardGames _test2 = new BoardGames();
        static void Main(string[] args) {

            var checkers = new BoardGames(true, "Checkers", "Iraq", new DateTime(3000, 1, 1));
            Console.Write(checkers.DateOfInception.ToString("yyyy"));
            checkers.BC('y');  //based on assignment, is this virtual or abstract method???
            Console.WriteLine("\n\n");

            var chess = new BoardGames();
            chess.Name = "Chess";
            chess.Origin = "India";
            chess.Outdoor = false;
            chess.TwoPlayerOnly = true;
            chess.DateOfInception = new DateTime(600, 1, 1);

            var monopoly = new BoardGames(false, "Monopoly", "United States", new DateTime(1903, 1, 1));

            var euchre = new Cardgames(false, false, "Euchre", "Pennsylvania", new DateTime(1820, 1, 1));

            var darts = new BarGames("Darts", "United Kingdom", new DateTime(1860, 1, 1));
            var pool = new BarGames("Pool", "France", new DateTime(1400, 1, 1));
            var shuffleboard = new BarGames("Shuffleboard", "England", new DateTime(1500, 1, 1));

            var football = new TeamSportsGames(true, "Football", "Unitied States", new DateTime(1882, 1, 1));

            List<AbstractGamesClass> games = new List<AbstractGamesClass>();
            games.Add(chess);
            games.InsertRange(games.Count, new AbstractGamesClass[] { checkers, monopoly, euchre, darts, pool, shuffleboard, football });  //method to add multiple items at once to existing list

            List<AbstractGamesClass> anotherGamesList = new List<AbstractGamesClass> { checkers, chess, monopoly }; //a better way to do it initially

            foreach (AbstractGamesClass var in games) {
                Console.Write($"         { var.Name}    \n" +
                                  $"Country of origin:  {var.Origin}\n" +
                                  $"Year established:" + var.DateOfInception.ToString("yyy"));
                    
                if (var.Name == "Checkers") {
                    var.BC('y');
                }else {
                    var.BC('n');
                }
                Console.WriteLine($"Outdoor game:  {var.Outdoor}\n\n");
                    
                                                                                                                  //$"Outdoor Game:  {var.Outdoor}");
            }
        }
    }


        }

    
