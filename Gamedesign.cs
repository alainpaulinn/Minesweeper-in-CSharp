using System;
using System.Collections.Generic;
using System.Drawing;
using minesweeper.Properties;

namespace minesweeper
{
    public class Gamedesign
    {
        public const int CELL_SIZE = 20;
        public string Playername;
        public List<string[]> Scores;
        public int Width => _Level.Width;
        public int Height => _Level.Height;
        public int Minutes { get; private set; }
        public int Seconds { get; private set; }
        public bool GameOver { get; private set; }

        private Levelproperties _Level;
        private Square[,] _Grid;
        private Bitmap _emptyTile;
        private Bitmap _mineTile;
        private Bitmap _flagTile;
        private readonly List<Bitmap> m_NumberBitmaps;

        public Gamedesign()
        {
            m_NumberBitmaps = new List<Bitmap>();
            InitializeImages();
        }

        public void Start(Levelproperties level)
        {
            _Level = level;
            GameOver = false;
            _Grid = new Square[Width, Height];
            Minutes = 0;
            Seconds = 0;
            InitializeField();
        }
        public void CheckMine(int x, int y)
        {
            _Grid[x, y].MarkedAsMine = !_Grid[x, y].MarkedAsMine;
        }

        public void OpenCell(int x, int y)
        {
            if (_Grid[x, y].IsMine)
            {
                GameOver = true;
            }
            else
            {
                Open(x, y);
            }
        }

        public void Draw(Graphics g)
        {
            for (var x = 0; x < Width; x++)
            {
                for (var y = 0; y < Height; y++)
                {
                    var cell = _Grid[x, y];
                    var image = GameOver && cell.IsMine ? _mineTile : cell.MarkedAsMine ? _flagTile : cell.Discovered ? m_NumberBitmaps[cell.Number] : _emptyTile;
                    g.DrawImage(image, new Point(x*CELL_SIZE, y*CELL_SIZE));
                }
            }
        }

        private void InitializeField()
        {
            var distributeCells = new Square[Width * Height];
            var i = 0;
            for (var k = 0; k < Width; k++)
            {
                for (var l = 0; l < Height; l++)
                {
                    distributeCells[i++] = _Grid[k, l] = new Square(k, l);
                }
            }
            var rnd = new Random();
            var mines = _Level.TimeLimit;
            for (i = 0; i < mines; ++i)
            {
                SwapCells(ref distributeCells[i], ref distributeCells[i + rnd.Next() % (Width * Height - i)]);
            }
            for (i = 0; i < mines; i++)
            {
                distributeCells[i].IsMine = true;
            }
            CountMineNumbers();
        }

        private void Open(int x, int y)
        {
            _Grid[x, y].Discovered = true;
            if (_Grid[x, y].Number == 0)
            {
                ForCellsAround(x, y, (i, j) => 
                {
                    var cell = _Grid[i, j];
                    if (!cell.Discovered && !cell.IsMine)
                    {
                        cell.Discovered = true;
                        if (cell.Number == 0)
                        {
                            Open(i, j);
                        }
                    }
                });
            }            
        }       

        private void CountMineNumbers()
        {
            foreach (var cell in _Grid)
            {
                var i = 0;
                if (!cell.IsMine)
                {
                    ForCellsAround(cell.X, cell.Y, (x,y) => { if(_Grid[x, y].IsMine) i++; });                    
                }
                cell.Number = i;
            }
        }

        private void ForCellsAround(int x, int y, Action<int, int> action)
        {
            for (var i = -1; i < 2; i++)
            {
                for (var j = -1; j < 2; j++)
                {
                    var posI = x + i;
                    var posJ = y + j;
                    if (posI >= 0 && posI < Width && posJ >= 0 && posJ < Height)
                    {
                        action(posI, posJ);
                    }
                }
            }
        }

        private static void SwapCells(ref Square a, ref Square b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        private void InitializeImages()
        {
            for (var i = 0; i < 9; i++)
            {
                var bitmap = (Bitmap)Resources.ResourceManager.GetObject($"_{i}");
                bitmap.SetResolution(96, 96);
                m_NumberBitmaps.Add(bitmap);
            }
            _emptyTile = (Bitmap)Resources.ResourceManager.GetObject("empty");
            _emptyTile.SetResolution(96, 96);
            _mineTile = (Bitmap)Resources.ResourceManager.GetObject("mine");
            _mineTile.SetResolution(96, 96);
            _flagTile = (Bitmap)Resources.ResourceManager.GetObject("flag");
            _flagTile.SetResolution(96, 96);
        }
        public void UpdateTime()
        {
            if (Seconds != 60)
            {
                Seconds++;
            }
            else
            {
                Minutes++;
                Seconds = 0;
            }
            if (Minutes == _Level.TimeLimit)
            {
                GameOver = true;
            }
        }
    }
}
