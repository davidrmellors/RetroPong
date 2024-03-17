using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetroPong.UserControls
{
    public partial class MainMenuControl : UserControl
    {
        private Button btnSinglePlayer;
        private Button btnMultiplayer;
        private Button btnSettings;
        private Button btnQuit;

        public event EventHandler PlaySinglePlayer;
        public event EventHandler PlayMultiplayer;
        public event EventHandler OpenSettings;
        public event EventHandler QuitGame;

        public MainMenuControl()
        {
            InitializeComponent();
            CreateUI();
        }

        private void CreateUI()
        {
            btnSinglePlayer = new Button { Text = "Single Player", Size = new Size(200, 40), Location = new Point(150, 60) };
            btnMultiplayer = new Button { Text = "Multiplayer", Size = new Size(200, 40), Location = new Point(150, 120) };
            btnSettings = new Button { Text = "Settings", Size = new Size(200, 40), Location = new Point(150, 180) };
            btnQuit = new Button { Text = "Quit Game", Size = new Size(200, 40), Location = new Point(150, 240) };

            btnSinglePlayer.Click += (sender, e) => PlaySinglePlayer?.Invoke(this, EventArgs.Empty);
            btnMultiplayer.Click += (sender, e) => PlayMultiplayer?.Invoke(this, EventArgs.Empty);
            btnSettings.Click += (sender, e) => OpenSettings?.Invoke(this, EventArgs.Empty);
            btnQuit.Click += (sender, e) => QuitGame?.Invoke(this, EventArgs.Empty);

            this.Controls.Add(btnSinglePlayer);
            this.Controls.Add(btnMultiplayer);
            this.Controls.Add(btnSettings);
            this.Controls.Add(btnQuit);
        }
    }

}
