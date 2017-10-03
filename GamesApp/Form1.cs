using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesApp
{
    public partial class Form1 : Form
    {
        GameApp gameApp;

        BindingList<string> gameNames;

        public Form1()
        {
            InitializeComponent();

            gameApp = new GameApp();
            gameApp.AddDummies();

            gameNames = new BindingList<string>();

            UpdateGameList();
        }

        private void BtAddGame_Click(object sender, EventArgs e)
        {
            string title = tbTitle.Text;
            if(string.IsNullOrEmpty(title))
            {
                MessageBox.Show("A game must have a title");
                return;
            }
            string genre = tbGenre.Text;
            if (string.IsNullOrEmpty(genre))
            {
                MessageBox.Show("A game must have a genre");
                return;
            }
            string platform = tbPlatform.Text;
            if (string.IsNullOrEmpty(platform))
            {
                MessageBox.Show("A game must have a platform");
                return;
            }
            decimal price = nudPrice.Value;
            if(price <0)
            {
                MessageBox.Show("A game must cost at least €0,00");
                return;
            }

            Game game = new Game(title, genre, platform, price);

            if (gameApp.AddGame(game))
            {
                MessageBox.Show("Added " + game.Title);
                UpdateGameList();
            }
            else
            {
                MessageBox.Show("You already own this game!");
            }
        }

        private void UpdateGameList()
        {
            gameNames.Clear();
            foreach (Game game in gameApp.GetGames())
            {
                gameNames.Add(game.ToString());
            }
            libGames.DataSource = gameNames;
        }
    }
}
