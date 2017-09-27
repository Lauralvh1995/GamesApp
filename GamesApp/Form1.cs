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
        Game skyrim;
        Game finalFantasy12;
        Game darksiders;

        BindingList<string> gameNames;

        public Form1()
        {
            InitializeComponent();

            gameApp = new GameApp();

            skyrim = new Game("The Elder Scrolls V: Skyrim", "WRPG", "PC", 30.00);
            finalFantasy12 = new Game("Final Fantasy XII", "JRPG", "PS2", 21.50);
            darksiders = new Game("Darksiders", "Action", "PC", 7.50);

            gameApp.AddGame(skyrim);
            gameApp.AddGame(finalFantasy12);
            gameApp.AddGame(darksiders);

            gameNames = new BindingList<string>();

            UpdateGameList();
        }

        private void BtAddGame_Click(object sender, EventArgs e)
        {
            gameApp.AddGame(new Game(tbTitle.Text, tbGenre.Text, tbPlatform.Text, (double)nudPrice.Value));
            UpdateGameList();
        }

        private void UpdateGameList()
        {
            gameNames.Clear();
            foreach (Game game in gameApp.Games)
            {
                gameNames.Add(game.ToString());
            }
            libGames.DataSource = gameNames;
        }
    }
}
