// AMANDA TELL 2021-01-05
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    /// <summary>
    /// Stats holds a List of Winner
    /// </summary>
    class Stats
    {
        List<Winner> winners;

        /// <summary>
        /// Default constructor
        /// Initlialize a new List
        /// </summary>
        public Stats()
        {
            winners = new List<Winner>();
        }

        /// <summary>
        /// Adds a new Winner object to List
        /// </summary>
        /// <param name="player"></param>
        public void AddStat(Winner player)
        {
            winners.Add(player);
        }

        /// <summary>
        /// Formats the List to an array for ListBox in MainForm
        /// </summary>
        /// <returns></returns>
        public string[] ArrayToString()
        {
            return winners.ConvertAll(x => x.ToString()).ToArray();
        }
    }
}
