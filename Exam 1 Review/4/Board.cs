using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Board
    {
        private char[,] _board;
        public Board()
        {
            _board = new char[3, 3];
        }
        public void Show()
        {
            for (int i = 0; i < _board.GetLength(0); i++)
            {
                for (int j = 0; j < _board.GetLength(1); j++)
                    if (_board[i,j]!='\0')
                        Console.Write($"{_board[i, j]}\t");
                    else
                        Console.Write($"*\t");
                Console.WriteLine("\n");
            }
        }
        public bool SetBoard(int row, int col, char mark)
        {
            if (_board[row, col] == '\0')
            {
                _board[row, col] = mark;
                return true;
            }
            else
                return false;
        }
        public bool CheckRows()
        {
            for (int i = 0; i < _board.GetLength(0); i++)
                if (_board[i, 0] == _board[i, 1] && _board[i, 1] == _board[i, 2] && _board[i, 0] != '\0')
                    return true;
            return false;
        }
        public bool CheckCols()
        {
            for (int i = 0; i < _board.GetLength(1); i++)
                if (_board[0, i] == _board[1, i] && _board[1, i] == _board[2, i] && _board[0, i] != '\0')
                    return true;
            return false;
        }
        public bool CheckDiag()
        {
            return (_board[0, 0] == _board[1, 1] && _board[1, 1] == _board[2, 2] && _board[0, 0]!='\0') || (_board[0, 2] == _board[1, 1] && _board[1, 1] == _board[2, 0] && _board[2, 0] != '\0');
        }
    }
}
