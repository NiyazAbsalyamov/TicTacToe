using System.Collections.Generic;

namespace TicTacToe.Models
{
    public class Model
    {
        private Dictionary<int, Cell> _field;

        public Model()
        {
            _field = new Dictionary<int, Cell>();

            for (int i = 1; i < 10; i++)
            {
                _field.Add(i, new Cell());
            }
        }

        public void Set(int cell, bool isPlayer, bool isX, bool isEmpty)
        {
            if (isEmpty)
            {
                _field[cell].Reset();
                return;
            }

            _field[cell].Set(isPlayer, isX);
        }

        public void Reset()
        {
            foreach (var cell in _field)
            {
                cell.Value.Reset();
            }
        }
    }
}
