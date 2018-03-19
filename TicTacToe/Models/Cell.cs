namespace TicTacToe.Models
{
    public class Cell
    {
        private bool _isPlayer;
        private bool _isX;
        public bool isEmpty = true;
        
        public Cell()
        {
            isEmpty = false;
        }
        public Cell(bool isPlayer, bool isX)
        {
            Set(isPlayer, isX);
        }

        public void Reset()
        {
            _isPlayer = false;
            _isX = false;
            isEmpty = false;
        }

        public void Set(bool isPlayer, bool isX)
        {
            _isPlayer = isPlayer;
            _isX = isX;
            isEmpty = false;
        }
    }
}
