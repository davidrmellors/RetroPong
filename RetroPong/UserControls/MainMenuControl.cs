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
        public event EventHandler PlaySinglePlayer;
        public event EventHandler PlayMultiplayer;
        public event EventHandler OpenSettings;
        public event EventHandler QuitGame;

        public MainMenuControl()
        {
            InitializeComponent();
            // Add your buttons here and wire up the events.
        }

        // Example button click event
        private void btnSinglePlayer_Click(object sender, EventArgs e)
        {
            PlaySinglePlayer?.Invoke(this, EventArgs.Empty);
        }

        // Implement other buttons similarly...
    }

}
