using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesApp
{
    class GameApp
    {
        private List<Game> games;

        public GameApp()
        {
            games = new List<Game>();
        }

        public bool AddGame(Game game)
        {
            //Check of de game al bestaat, zo ja, return false
            foreach(Game checkGame in games)
            {
                if(checkGame.Title == game.Title)
                {
                    return false;
                }
            }
            games.Add(game);
            return true;
        }

        public void AddDummies()
        {
            //Eerst werd de dummy data toegevoegd in de Form. Nu wordt die hier neergezet. 
            //Dit zodat je in de Form niet met de List hoeft te rommelen.
            Game skyrim = new Game("The Elder Scrolls V: Skyrim", "WRPG", "PC", 30.00m);
            Game finalFantasy12 = new Game("Final Fantasy XII", "JRPG", "PS2", 21.50m);
            Game darksiders = new Game("Darksiders", "Action", "PC", 7.50m);

            games.Add(skyrim);
            games.Add(finalFantasy12);
            games.Add(darksiders);
        }

        public IReadOnlyList<Game> GetGames()
        {
            //Deze methode maakt een kopie van de lijst, die alleen maar mag worden gelezen.
            //Hiermee is de lijst ook weggeëncapsuleerd.
            //Anders kan men vanuit de form bij de List, en deze aanpassen. Wat niet de bedoeling is.            
            return games.AsReadOnly();
        }
    }
}
