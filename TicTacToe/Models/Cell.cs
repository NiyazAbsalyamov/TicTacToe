namespace TicTacToe.Models
{
    public class Cell
    {
        private bool _isPlayer;
        private bool _isX;
        private bool _isEmpty = true;

        public bool IsPlayer => _isPlayer;
        public bool IsX => _isX;
        public bool IsEmpty => _isEmpty;

        public Cell()
        {
            _isEmpty = true;
        }
        public Cell(bool isPlayer, bool isX)
        {
            Set(isPlayer, isX);
        }

        public void Reset()
        {
            _isPlayer = false;
            _isX = false;
            _isEmpty = false;
        }

        public void Set(bool isPlayer, bool isX)
        {
            _isPlayer = isPlayer;
            _isX = isX;
            _isEmpty = false;
        }
    }
}
