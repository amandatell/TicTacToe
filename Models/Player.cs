// AMANDA TELL 2021-01-05
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    /// <summary>
    /// A Player object consists of a name and a symbol
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Fields
        /// </summary>
        string name;
        Symbol symbol;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="sym"></param>
        public Player(string name, Symbol sym)
        {
            this.Name = name;
            this.Symbol = sym;
        }

        /// <summary>
        /// Properties
        /// </summary>
        public string Name { get => name; set => name = value; }
        public Symbol Symbol { get => symbol; set => symbol = value; }
    }
}
