using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesApp
{
    public class Game
    {
        public string Title { get; }
        public string Genre { get;  }
        public string Platform { get;  }
        public decimal Price { get;  }

        public Game(string title, string genre, string platform, decimal price)
        {
            Title = title;
            Genre = genre;
            Platform = platform;
            Price = price;
        }

        public override string ToString()
        {
            string gameString = "Title: " + Title + " - Genre: " + Genre + " - Platform: " + Platform + " - Price: " + Price;
            return gameString;
        }
    }
}
