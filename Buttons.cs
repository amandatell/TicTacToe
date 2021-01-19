// AMANDA TELL 2021-01-05
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    /// <summary>
    /// Partial class MainForm that deals with the events for the buttons
    /// Divided to its own file as code it quite long
    /// </summary>
    public partial class MainForm
    {
        /// <summary>
        /// Event handlers for buttons a1-c3
        /// Calls CheckButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void a1_Click(object sender, EventArgs e)
        {
            if (!win)
            {
                a1.Enabled = false;
                CheckButton(a1, a2, a3, b2, c3, b1, c1);
            }
        }

        private void a2_Click(object sender, EventArgs e)
        {
            if (!win)
            {
                a2.Enabled = false;
                CheckButton(a2, a1, a3, b2, c2);
            }
        }

        private void a3_Click(object sender, EventArgs e)
        {
            if (!win)
            {
                a3.Enabled = false;
                CheckButton(a3, a2, a1, b2, c1, b3, c3);
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (!win)
            {
                b1.Enabled = false;
                CheckButton(b1, b2, b3, a1, c1);
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (!win)
            {
                b2.Enabled = false;
                CheckButton(b2, b1, b3, a1, c3, a3, c1, a2, c2);
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (!win)
            {
                b3.Enabled = false;
                CheckButton(b3, b1, b2, a3, c3);
            }
        }

        private void c1_Click(object sender, EventArgs e)
        {
            if (!win)
            {
                c1.Enabled = false;
                CheckButton(c1, c2, c3, b2, a3, a1, b1);
            }
        }

        private void c2_Click(object sender, EventArgs e)
        {
            if (!win)
            {
                c2.Enabled = false;
                CheckButton(c2, c1, c3, a2, b2);
            }
        }

        private void c3_Click(object sender, EventArgs e)
        {
            if (!win)
            {
                c3.Enabled = false;
                CheckButton(c3, c1, c2, b2, a1, a3, b3);
            }
        }

        /// <summary>
        /// Overloaded Checkbutton
        /// Calls MarkAndChange in other partical MainForm class
        /// Checks if row and column are filled with symbols
        /// Calls CheckWinner in game if true
        /// If CheckWinner is true MarkWin is called
        /// </summary>
        /// <param name="currButton"></param>
        /// <param name="row1"></param>
        /// <param name="row2"></param>
        /// <param name="col1"></param>
        /// <param name="col2"></param>
        private void CheckButton(Button currButton, Button row1, Button row2, Button col1, Button col2)
        {
            MarkAndChange(currButton);
            if (!(row1.Text == String.Empty && row2.Text == String.Empty))
            {
                if (game.CheckWinner(currButton.Text, row1.Text, row2.Text))
                    MarkWin(currButton, row1, row2);
            }
            if (!(col1.Text == String.Empty && col2.Text == String.Empty))
            {
                if (game.CheckWinner(currButton.Text, col1.Text, col2.Text))
                    MarkWin(currButton, col1, col2);
            }
        }

        /// <summary>
        /// Overlodaded chaincalling Checkbutton
        /// Checks diagonally one way
        /// </summary>
        /// <param name="currButton"></param>
        /// <param name="row1"></param>
        /// <param name="row2"></param>
        /// <param name="diag1"></param>
        /// <param name="diag2"></param>
        /// <param name="col1"></param>
        /// <param name="col2"></param>
        private void CheckButton(Button currButton, Button row1, Button row2, Button diag1, Button diag2, Button col1, Button col2)
        {
            CheckButton(currButton, row1, row2, col1, col2);
            if (!(diag1.Text == String.Empty && diag2.Text == String.Empty))
            {
                if (game.CheckWinner(currButton.Text, diag1.Text, diag2.Text))
                    MarkWin(currButton, diag1, diag2);
            }
            
        }
        /// <summary>
        /// Overlodaded chaincalling Checkbutton
        /// Checks diagonally the other way, only called if middle button enabled
        /// </summary>
        /// <param name="currButton"></param>
        /// <param name="row1"></param>
        /// <param name="row2"></param>
        /// <param name="diag1_1"></param>
        /// <param name="diag1_2"></param>
        /// <param name="diag2_1"></param>
        /// <param name="diag2_2"></param>
        /// <param name="col1"></param>
        /// <param name="col2"></param>
        private void CheckButton(Button currButton, Button row1, Button row2, Button diag1_1, Button diag1_2, Button diag2_1, Button diag2_2, Button col1, Button col2)
        {
            CheckButton(currButton, row1, row2, col1, col2, diag1_1, diag1_2);

            if (!(diag2_1.Text == String.Empty && diag2_2.Text == String.Empty))
            {
                if (game.CheckWinner(currButton.Text, diag2_1.Text, diag2_2.Text))
                    MarkWin(currButton, diag2_1, diag2_2);
            }
        }
    }
}
