// AMANDA TELL 2021-01-05
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    /// <summary>
    /// Class Game is initialized everytime a new game is started
    /// </summary>
    class Game
    {
        /// <summary>
        /// Fields
        /// </summary>
        /// winner holds the winning symbol that is shown in GUI in MainForm
        string winner;
        // Players of the game
        private Player x;
        private Player o;
        // Whose turn it is, true == x, false == o
        private bool turn;

        /// <summary>
        /// Constructor with optional parameters
        /// If no arguments are passed then the player gets the name anonymous
        /// </summary>
        /// <param name="name1"></param>
        /// <param name="sym1"></param>
        /// <param name="name2"></param>
        /// <param name="sym2"></param>
        public Game(string name1 = "Anonymous", Symbol sym1 = Symbol.X, string name2 = "Anonymous", Symbol sym2 = Symbol.O)
        {
            X = new Player(name1, sym1);
            O = new Player(name2, sym2);
            turn = true;
        }

        /// <summary>
        /// Properties
        /// </summary>
        /// When turn is set, it changes whose turn it is
        public bool Turn { get => turn; set => turn = !value; }
        public string Winner { get => winner; set => winner = value; }
        public Player X { get => x; set => x = value; }
        public Player O { get => o; set => o = value; }

        /// <summary>
        /// Checks if there is a winner
        /// If true winner field gets the winning symbol
        /// </summary>
        /// <param name="sym_1"></param>
        /// <param name="sym_2"></param>
        /// <param name="sym_3"></param>
        /// <returns>True if there is a winner, else false</returns>
        public bool CheckWinner(string sym_1, string sym_2, string sym_3)
        {
            if (sym_1 == sym_2 && sym_2 == sym_3) 
            {
                if (sym_1 != String.Empty && sym_2 != String.Empty && sym_3 != String.Empty)
                {
                    winner = sym_1;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Gets the winner
        /// Creates a Winner object
        /// </summary>
        /// <param name="sym"></param>
        /// <returns>A winner object</returns>
        public Winner GetWinner(Symbol sym)
        {
            Player winner;
            if (x.Symbol == sym)
                winner = x;
            else
                winner = o;
            Winner newWin = new Winner(winner);
            return newWin;
        }
    }
}
