using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetroPong.UserControls;

namespace RetroPong.Forms
{
    public partial class MainForm : Form
    {
        MainMenuControl mainMenu;
        GameControl gameControl;
        SettingsControl settingsControl;

        public MainForm()
        {
            InitializeComponent();
            mainMenu = new MainMenuControl();
            gameControl = new GameControl();
            settingsControl = new SettingsControl();

            mainMenu.PlaySinglePlayer += MainMenu_PlaySinglePlayer;
            mainMenu.PlayMultiplayer += MainMenu_PlayMultiplayer;
            mainMenu.OpenSettings += MainMenu_OpenSettings;
            mainMenu.QuitGame += MainMenu_QuitGame;

            LoadMainMenu();
        }

        private void LoadMainMenu()
        {
            this.Controls.Clear();
            this.Controls.Add(mainMenu);
        }

        private void MainMenu_PlaySinglePlayer(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(gameControl);
            gameControl.StartSinglePlayer();
        }

        private void MainMenu_PlayMultiplayer(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(gameControl);
            gameControl.StartMultiplayer();
        }

        private void MainMenu_OpenSettings(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(settingsControl);
        }

        private void MainMenu_QuitGame(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
