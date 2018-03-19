using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class Model
    {
        public Dictionary<int, Cell> Field;

        public Model()
        {
            Field = new Dictionary<int, Cell>();
        }
    }
}
