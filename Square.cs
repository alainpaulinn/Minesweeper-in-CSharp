namespace minesweeper
{
    public class Square
    {       
        public bool MarkedAsMine { get; set; }
        public bool IsMine { get; set; }
        public int Number { get; set; }
        public bool Discovered { get; set; }
        public int X { get; }
        public int Y { get; }
    
        public Square(int a, int b)
        {
            X = a;
            Y = b;
        }
    }
}
