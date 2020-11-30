using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_04 {
    abstract class AbstractGamesClass {
        public string Name { get; set; }
        public string Origin { get; set; }
        public DateTime DateOfInception { get; set; }
        public bool Outdoor { get; set; }  // I did not use this constructor in my base abstractGamesClass object

        public void BC(char yesOrNo) {
            if (yesOrNo == 'y') {
                Console.WriteLine("BC");
            }
            else {
                Console.WriteLine("");
            }

        }
       
        public AbstractGamesClass() { }
        public AbstractGamesClass(string name, string origin, DateTime dateOfInception) {
            Name = name;
            Origin = origin;
            DateOfInception = dateOfInception;  // no bool Outdoor
        }
    }

    class BoardGames : AbstractGamesClass {
        public bool TwoPlayerOnly { get; set; }

        public BoardGames() { }
        public BoardGames(bool twoPlayerOnly, string name, string origin, DateTime dateOfInception)
            : base(name, origin, dateOfInception) {
            TwoPlayerOnly = twoPlayerOnly;
        }

       
    }

    class Cardgames : BoardGames {
        public bool StandardDeck { get; set; }

        public Cardgames() { }
        public Cardgames(bool standardDeck, bool twoPlayerOnly, string name, string origin, DateTime dateOfInception)
            : base(twoPlayerOnly, name, origin, dateOfInception) {
            StandardDeck = standardDeck;
        }
    }

    class BarGames : AbstractGamesClass {

        public BarGames() { }
        public BarGames(string name, string origin, DateTime dateOfInception) : base(name, origin, dateOfInception) { }
           

        }
    

    class TeamSportsGames : AbstractGamesClass {
        public int PlayersPerTeam { get; set; }

        public TeamSportsGames() { }
        public TeamSportsGames(bool outdoor, string name, string origin, DateTime dateOfInception) : base(name, origin, dateOfInception) {
            Outdoor = outdoor; //but I can still use bool Outdoor here without a new Outdoor constructor
        }
    }
}



