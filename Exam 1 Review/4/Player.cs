using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Player
    {
        private string _name;
        private Board _board;
        private char _mark;
        public Player(string name, char mark, Board board)
        {
            _name = name;
            _board = board;
            _mark = mark;
        }
        public bool Play()
        {
            int row, col;
            Console.WriteLine($"{_mark} is playing...");
            Console.Write("Row:");
            row = int.Parse(Console.ReadLine());
            Console.Write("Col:");
            col = int.Parse(Console.ReadLine());
            return _board.SetBoard(row, col, _mark);
        }
        public string Name 
        {
            get { return _name; }
        }
    }
}
