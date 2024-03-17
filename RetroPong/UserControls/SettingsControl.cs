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
    public partial class SettingsControl : UserControl
    {
        private Button btnSaveSettings;
        private CheckBox chkMusic;
        // Add other settings components like resolution changer, background changer

        public event EventHandler SaveSettings;
        public event EventHandler<bool> MusicChanged;

        public SettingsControl()
        {
            InitializeComponent();
            CreateUI();
        }

        private void CreateUI()
        {
            chkMusic = new CheckBox { Text = "Music", Checked = true, Location = new Point(20, 20) };
            chkMusic.CheckedChanged += (sender, e) => MusicChanged?.Invoke(this, chkMusic.Checked);

            btnSaveSettings = new Button { Text = "Save Settings", Location = new Point(20, 100) };
            btnSaveSettings.Click += (sender, e) => SaveSettings?.Invoke(this, EventArgs.Empty);

            this.Controls.Add(chkMusic);
            this.Controls.Add(btnSaveSettings);
        }
    }
}
