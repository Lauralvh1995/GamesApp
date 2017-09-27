using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesApp
{
    class GameApp
    {
        public List<Game> Games { get; }

        public GameApp()
        {
            Games = new List<Game>();
        }

        public bool AddGame(Game game)
        {
            foreach(Game checkGame in Games)
            {
                if(checkGame.Title == game.Title)
                {
                    MessageBox.Show("You already own this game!");
                    return false;
                }
            }
            Games.Add(game);
            MessageBox.Show("Added " + game.Title);
            return true;
        }
    }
}
