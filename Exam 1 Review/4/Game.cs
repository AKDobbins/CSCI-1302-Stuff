using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Game
    {
        private Board _board;
        public Game()
        {
            _board = new Board();
        }
        public void Start()
        {
            Player[] players = new Player[2];
            players[0] = new Player("Player 1", 'X', _board);
            players[1] = new Player("Player 1", 'O', _board);
            int turn = 0;
            bool pass;
            while (!IsOver())
            {
                _board.Show();
                pass = players[turn].Play();
                turn = (turn + Convert.ToInt32(pass)) % players.Length; // Make sure you understand this line
            }
            _board.Show();
            Console.WriteLine($"Winner: {players[(turn -1 + players.Length)%players.Length].Name}"); // Make sure you understand this line
            
        }
        public bool IsOver()
        {
            return Win();
        }
        public bool Win()
        {
            return _board.CheckRows() || _board.CheckCols() || _board.CheckDiag();
        }
    }
}
