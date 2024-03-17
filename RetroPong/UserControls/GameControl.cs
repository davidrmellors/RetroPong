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
    public partial class GameControl : UserControl
    {
        private Timer gameTimer;
        private bool isPaused;

        // Game elements like paddles and ball
        private Rectangle playerPaddle;
        private Rectangle aiPaddle;
        private Rectangle ball;
        private int playerScore;
        private int aiScore;

        public GameControl()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            // Initialize game elements
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);

            gameTimer = new Timer { Interval = 20 };
            gameTimer.Tick += GameTimer_Tick;
            this.KeyDown += GameControl_KeyDown;

            // Set initial positions of paddles and ball
            ResetGame();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (!isPaused)
            {
                // Update game logic, move paddles and ball
            }
            Invalidate(); // Causes the form to be redrawn
        }

        private void GameControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                isPaused = !isPaused;
                if (isPaused)
                    gameTimer.Stop();
                else
                    gameTimer.Start();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw paddles, ball, and score
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.Blue, playerPaddle);
            g.FillRectangle(Brushes.Red, aiPaddle);
            g.FillEllipse(Brushes.Green, ball);

            // Draw scores
            g.DrawString(playerScore.ToString(), new Font("Arial", 20), Brushes.White, new Point(30, 20));
            g.DrawString(aiScore.ToString(), new Font("Arial", 20), Brushes.White, new Point(this.Width - 60, 20));

            if (isPaused)
            {
                // If the game is paused, draw the paused text
                g.DrawString("PAUSED", new Font("Arial", 24), Brushes.White, new PointF(this.Width / 2 - 60, this.Height / 2 - 30));
            }
        }

        public void StartSinglePlayer()
        {
            // Initialize single player game specifics
            gameTimer.Start();
        }

        public void StartMultiplayer()
        {
            // Initialize multiplayer game specifics
            gameTimer.Start();
        }

        private void ResetGame()
        {
            // Reset game elements to initial positions
        }
    }


}
