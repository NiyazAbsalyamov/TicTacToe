using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TicTacToe.Models;

namespace TicTacToe
{
    public class AI
    {
        public int AiStep(Model model, bool isPlayerX)
        {
            var fieldX = new bool[3, 3];
            var fieldO = new bool[3, 3];
            var fieldEmpty = new bool[3, 3];

            for (var i = 1; i < 10; i++)
            {
                fieldX[(i - 1) / 3, i % 3 - 1] = model.Get(i).IsX && !model.Get(i).IsEmpty;
            }

            for (var i = 1; i < 10; i++)
            {
                fieldO[(i - 1) / 3, i % 3 - 1] = !model.Get(i).IsX && !model.Get(i).IsEmpty;
            }

            for (var i = 1; i < 10; i++)
            {
                fieldEmpty[(i - 1) / 3, i % 3 - 1] = model.Get(i).IsEmpty;
            }

            for (var i = 1; i < 9; i++)
            {
                var list = Map(fieldX, fieldO, fieldEmpty, i);
                var answer = IsEnd(list);
                if (answer != 0)
                {
                    if (i < 4)
                    {
                        return (i - 1) * 3 + answer;
                    }
                    if (i < 7)
                    {
                        return (answer - 1) * 3 + i - 3;
                    }
                    if (answer == 2) return 5;
                    if (i == 7)
                    {
                        if (answer == 1) return 1;
                        if (answer == 3) return 9;
                    }
                    if (i == 8)
                    {
                        if (answer == 1) return 3;
                        if (answer == 3) return 7;
                    }
                }
            }

            if (fieldEmpty[1, 1])
            {
                return 5;
            }
            if (fieldEmpty[0, 0])
            {
                return 1;
            }
            if (fieldEmpty[0, 2])
            {
                return 3;
            }
            if (fieldEmpty[2, 0])
            {
                return 7;
            }
            if (fieldEmpty[2, 2])
            {
                return 9;
            }
            if (fieldEmpty[0, 1])
            {
                return 2;
            }
            if (fieldEmpty[1, 0])
            {
                return 4;
            }
            if (fieldEmpty[1, 2])
            {
                return 6;
            }
            if (fieldEmpty[2, 1])
            {
                return 8;
            }

            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isXs">0 - empty, 1 - true, 2 - false</param>
        /// <returns></returns>
        private int IsEnd(IList<int> isXs)
        {
            var emptyCount = isXs.Count(x => x == 0);
            var xCount = isXs.Count(x => x == 1);
            var oCount = isXs.Count(x => x == 2);

            if (emptyCount != 1) return 0;

            if (xCount == 2 || oCount == 2)
                return isXs.IndexOf(0) + 1;
            return 0;
        }

        private IList<int> Map(bool[,] x, bool[,] o, bool[,] empty, int i)
        {
            if (i > 8 || i < 1)
            {
                throw new ArgumentException("Ошибка в аргументе");
            }

            var list = new List<int>();
            switch (i)
            {
                case 1:
                    {
                        var k = empty[0, 0] ? 0 : x[0, 0] ? 1 : o[0, 0] ? 2 : 0;
                        list.Add(k);
                        k = empty[0, 1] ? 0 : x[0, 1] ? 1 : o[0, 1] ? 2 : 0;
                        list.Add(k);
                        k = empty[0, 2] ? 0 : x[0, 2] ? 1 : o[0, 2] ? 2 : 0;
                        list.Add(k);
                        break;
                    }
                case 2:
                    {
                        var k = empty[1, 0] ? 0 : x[1, 0] ? 1 : o[1, 0] ? 2 : 0;
                        list.Add(k);
                        k = empty[1, 1] ? 0 : x[1, 1] ? 1 : o[1, 1] ? 2 : 0;
                        list.Add(k);
                        k = empty[1, 2] ? 0 : x[1, 2] ? 1 : o[1, 2] ? 2 : 0;
                        list.Add(k);
                        break;
                    }
                case 3:
                    {
                        var k = empty[2, 0] ? 0 : x[2, 0] ? 1 : o[2, 0] ? 2 : 0;
                        list.Add(k);
                        k = empty[2, 1] ? 0 : x[2, 1] ? 1 : o[2, 1] ? 2 : 0;
                        list.Add(k);
                        k = empty[2, 2] ? 0 : x[2, 2] ? 1 : o[2, 2] ? 2 : 0;
                        list.Add(k);
                        break;
                    }
                case 4:
                    {
                        var k = empty[0, 0] ? 0 : x[0, 0] ? 1 : o[0, 0] ? 2 : 0;
                        list.Add(k);
                        k = empty[1, 0] ? 0 : x[1, 0] ? 1 : o[1, 0] ? 2 : 0;
                        list.Add(k);
                        k = empty[2, 0] ? 0 : x[2, 0] ? 1 : o[2, 0] ? 2 : 0;
                        list.Add(k);
                        break;
                    }
                case 5:
                    {
                        var k = empty[0, 1] ? 0 : x[0, 1] ? 1 : o[0, 1] ? 2 : 0;
                        list.Add(k);
                        k = empty[1, 1] ? 0 : x[1, 1] ? 1 : o[1, 1] ? 2 : 0;
                        list.Add(k);
                        k = empty[2, 1] ? 0 : x[2, 1] ? 1 : o[2, 1] ? 2 : 0;
                        list.Add(k);
                        break;
                    }
                case 6:
                    {
                        var k = empty[0, 2] ? 0 : x[0, 2] ? 1 : o[0, 2] ? 2 : 0;
                        list.Add(k);
                        k = empty[1, 2] ? 0 : x[1, 2] ? 1 : o[1, 2] ? 2 : 0;
                        list.Add(k);
                        k = empty[2, 2] ? 0 : x[2, 2] ? 1 : o[2, 2] ? 2 : 0;
                        list.Add(k);
                        break;
                    }
                case 7:
                    {
                        var k = empty[0, 0] ? 0 : x[0, 0] ? 1 : o[0, 0] ? 2 : 0;
                        list.Add(k);
                        k = empty[1, 1] ? 0 : x[1, 1] ? 1 : o[1, 1] ? 2 : 0;
                        list.Add(k);
                        k = empty[2, 2] ? 0 : x[2, 2] ? 1 : o[2, 2] ? 2 : 0;
                        list.Add(k);
                        break;
                    }
                case 8:
                    {
                        var k = empty[0, 2] ? 0 : x[0, 2] ? 1 : o[0, 2] ? 2 : 0;
                        list.Add(k);
                        k = empty[1, 1] ? 0 : x[1, 1] ? 1 : o[1, 1] ? 2 : 0;
                        list.Add(k);
                        k = empty[2, 0] ? 0 : x[2, 0] ? 1 : o[2, 0] ? 2 : 0;
                        list.Add(k);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            return list;
        }
    }
}
