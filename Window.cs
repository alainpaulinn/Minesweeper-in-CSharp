using System;
using System.Drawing;
using System.Windows.Forms;

namespace minesweeper
{
    public partial class MinesweeperAlain : Form
    {
        private Bitmap _gameArea;
        private Graphics _GameGraphics;
        private const int UPPER_OFFSET = 60;// gives me a spave for the game upper controls
        private const int WIDTH_OFFSET = 16;
        private int FieldOffset;
        private readonly Gamedesign Game;
        
        private void FillLevels()
        {
            LevelCombobox.Items.Add(new Levelproperties(9, 9, 10, "Easy: 9*9, 10 minutes"));
            LevelCombobox.Items.Add(new Levelproperties(18, 18, 40, "Medium: 16*16, 40 minutes"));
            LevelCombobox.Items.Add(new Levelproperties(30, 30, 99, "Hard: 30*16, 99 minutes"));
            LevelCombobox.Items.Add(new Levelproperties(68, 33, 300, "Extreme: 68*33, 200 minutes"));
            LevelCombobox.SelectedIndex = 2;
        }
        public MinesweeperAlain()
        {
            InitializeComponent();
            FillLevels();
            Game = new Gamedesign();
            var level = (Levelproperties) LevelCombobox.SelectedItem;
            Size = new Size(level.Width * Gamedesign.CELL_SIZE + WIDTH_OFFSET, level.Height * Gamedesign.CELL_SIZE + UPPER_OFFSET);
        }
        private void OnMouseClick(object sender, MouseEventArgs e)
        {
            if (IsGameRunning())
            {
                var x = (e.X - FieldOffset) / Gamedesign.CELL_SIZE;
                var y = (e.Y - LevelCombobox.Height) / Gamedesign.CELL_SIZE;
              
                if (e.Button == MouseButtons.Right)
                {
                    Game.CheckMine(x, y);
                }
                else
                {
                    if (!Timer.Enabled)
                    {
                        Timer.Start();
                    }
                    Game.OpenCell(x, y);
                }
                Invalidate();
                if (Game.GameOver)
                {
                    finishGame("Boom! It's a fail...");
                }
            }
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            Game.UpdateTime();
            if (Game.GameOver)
            {
                Invalidate();
                finishGame("Failed Time is over!!! try again a bit quicker");
            }
            UpdateTimeLabels();
        }

        private void finishGame(string message)
        {
            Timer.Stop();
            MessageBox.Show(message);
            LevelCombobox.Enabled = m_StartBtn.Enabled = true;
            
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            if (IsGameRunning())
            {
                _GameGraphics.Clear(Color.White);
                Game.Draw(_GameGraphics);
                e.Graphics.DrawImage(_gameArea, FieldOffset, LevelCombobox.Height);
            }
        }

        private bool IsGameRunning()
        {
            return !m_StartBtn.Enabled;
        }

        private void UpdateTimeLabels()
        {
            m_MinutesLabel.Text = Game.Minutes.ToString();
            m_SecondsLabel.Text = Game.Seconds.ToString();
        }

        private void OnStartBtnClick(object sender, EventArgs e)
        {
            Game.Start((Levelproperties)LevelCombobox.SelectedItem);
            _gameArea = new Bitmap(Game.Width * Gamedesign.CELL_SIZE, Game.Height * Gamedesign.CELL_SIZE);
            _GameGraphics = Graphics.FromImage(_gameArea);
            Size = new Size(Size.Width, _gameArea.Height + UPPER_OFFSET);
            UpdateTimeLabels();
            m_StartBtn.Enabled = LevelCombobox.Enabled = false;
            FieldOffset = (ClientSize.Width - _gameArea.Width)/2;
            Invalidate();
        }
    }
    public class Levelproperties
    {
        public int Width { get; }
        public int Height { get; }
        public int TimeLimit { get; }
        public string Description { get; }

        public Levelproperties(int w, int h, int timelimit, string description)
        {
            Width = w;
            Height = h;
            TimeLimit = timelimit;
            Description = description;
        }
        public override string ToString()
        {
            return Description;
        }


    }

    public struct HighscoreEntry
    {
        public string Playername { get; set; }
        public int Timeused { get; set; }
        public string Gamesize { get; set; }
    }


}

