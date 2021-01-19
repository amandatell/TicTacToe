// AMANDA TELL 2021-01-05
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    /// <summary>
    /// Winner class turns a player into a winner
    /// Is added to Stats class by MainForm
    /// </summary>
    public class Winner
    {
        /// <summary>
        /// Fields, date of win and Player object
        /// </summary>
        DateTime date;
        Player player;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="player">Winning Player object</param>
        public Winner(Player player)
        {
            this.player = new Player(player.Name, player.Symbol);
            date = DateTime.Now;
        }
        /// <summary>
        /// Formats the fields for display in MainForm
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{date, -22}" +
                    $"{player.Name, -15}" +
                    $"{player.Symbol}";
        }
    }
}
