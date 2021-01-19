// AMANDA TELL 2021-01-05
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace TicTacToe
{
    /// <summary>
    /// Partial class MainForm
    /// Desls with logic of the buttons
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Fields
        /// </summary>
        private Game game;
        private Stats stats;
        /// <summary>
        /// If win is true when buttons are disabled
        /// </summary>
        private bool win;

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
            // Creates a new instance of stats when program starts
            stats = new Stats();
        }

        /// <summary>
        /// Initializes GUI
        /// hides labels and diables buttons
        /// </summary>
        public void InitializeGUI()
        {
            lblPlaying.Visible = false;
            lblPlayerNames.Visible = false;
            btnStart.Enabled = false;
            lblTurn.Visible = false;
            lblSymbol.Visible = false;
            grpBoard.Enabled = false;
            btnEdit.Enabled = false;
            btnSwap.Enabled = false;
        }

        /// <summary>
        /// If users presses Quick Starts at start of program
        /// game instance with default constructor is created
        /// players gets name Anonymous
        /// else game restarts with same players
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuickStart_Click(object sender, EventArgs e)
        {
            if (btnQuickStart.Text == "Quick Start")
                game = new Game();
            else
                game.Turn = false;
            StartGame();
        }

        /// <summary>
        /// Starts the game
        /// Updates GUI with player names
        /// Enables buttons and sets turn label to X
        /// </summary>
        public void StartGame()
        {
            btnSwap.Enabled = false;
            win = false;
            string x = game.X.Name;
            string o = game.O.Name;
            lblPlayerNames.Text = x + " (X) vs " + o + " (O)";
            btnEdit.Enabled = true;
            lblPlaying.Visible = true;
            lblPlayerNames.Visible = true;
            grpBoard.Enabled = true;
            foreach (Button button in grpBoard.Controls)
            {
                button.Text = String.Empty;
                button.Enabled = true;
                button.ForeColor = Color.Black;
            }

            lblTurn.Visible = true;
            lblSymbol.Visible = true;
            lblTurn.Text = "Turn:";
            lblSymbol.Text = Symbol.X.ToString();
            btnQuickStart.Text = "Quick Restart";
        }

        /// <summary>
        /// Buttons is enabled when one or both textboxes with player names is filled
        /// If players in current game then GameInterrupted gets called
        /// Checks which textboxes of player names are filled and creates a game accordingly
        /// If only one of the players name are filled then the other players gets the name 
        /// Anonymous
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            string x = txtXPlayer.Text;
            string o = txtOPlayer.Text;
            if (btnStart.Text == "Start")
            {
                if (CheckCurrentGame() && !win)
                    if (!GameInterrupted())
                        return;
                if (o == String.Empty)
                    game = new Game(name1: txtXPlayer.Text);
                else if (x == String.Empty)
                    game = new Game(name2: txtOPlayer.Text);
                else if (x == String.Empty && x == String.Empty)
                    game = new Game();
                else
                    game = new Game(name1: txtXPlayer.Text, name2: txtOPlayer.Text);
                btnStart.Enabled = false;
                StartGame();
                txtXPlayer.Text = String.Empty;
                txtOPlayer.Text = String.Empty;
            }

            // If buttons label == Save
            // Changes the name and continues the game
            else
            {
                game.X.Name = x;
                game.O.Name = o;
                txtXPlayer.Text = String.Empty;
                txtOPlayer.Text = String.Empty;
                lblPlayerNames.Text = game.X.Name + " (X) vs " + game.O.Name + " (O)";
                btnStart.Text = "Start";
            }
        }
            
        /// <summary>
        /// Checks if there is a current game, ie. someone has put down a symbol
        /// </summary>
        /// <returns></returns>
        private bool CheckCurrentGame()
        {
            foreach (Button button in grpBoard.Controls)
            {
                if (button.Text != String.Empty)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Alerts the user that they are interrupting a game
        /// If users presses Yes, a new game is started in StartGame()
        /// else nothing happens
        /// </summary>
        /// <returns>True or False depending on user choice on MessageBox</returns>
        private bool GameInterrupted()
        {
            {
                DialogResult dialog = MessageBox.Show("You are interrupting a current game.\nAre you sure you would like to start a new game?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    foreach (Button button in grpBoard.Controls)
                        button.Enabled = true;
                    return true;
                }
                else
                    return false;
            }
        }

        /// <summary>
        /// Marks the current button depending on whose turn it is
        /// Changes turn if win is false
        /// If all users has put down their symbols, ie. 3
        /// Then UnlockCurrentSymbols is called
        /// </summary>
        /// <param name="currButton"></param>
        private void MarkAndChange(Button currButton)
        {
            string buttonCheck = currButton.Text;

            if (game.Turn)
            {
                currButton.Text = Symbol.X.ToString();
                lblSymbol.Text = Symbol.O.ToString();
            }
            else
            {
                currButton.Text = Symbol.O.ToString();
                lblSymbol.Text = Symbol.X.ToString();
            }
            if (!win)
                game.Turn = game.Turn;
            if (UnlockCurrentSymbol() && buttonCheck != String.Empty)
                EnableBlanks(currButton);
        }

        /// <summary>
        /// Unlocks the current players symbols if player has put down all its symbols
        /// This makes the gae not finish after player has put down its symbols
        /// </summary>
        /// <returns></returns>
        private bool UnlockCurrentSymbol()
        {
            bool turn = game.Turn;
            if (CheckAllSymbolsActive())
            {
                foreach (Button button in grpBoard.Controls)
                {
                    if (turn && button.Text == Symbol.X.ToString())
                    {
                        Button[] buttons = SwitchButton(button.Name);
                        bool notEmpty = buttons.All(x => x.Text != String.Empty);
                        if (!notEmpty)
                            button.Enabled = true;
                    }
                    //button.Enabled = true;
                    else if (!turn && button.Text == Symbol.O.ToString())
                    {
                        Button[] buttons = SwitchButton(button.Name);
                        bool notEmpty = buttons.All(x => x.Text != String.Empty);
                        if (!notEmpty)
                            button.Enabled = true;
                    }
                    else if (button.Text == string.Empty)
                        button.Enabled = false;
                } return true;
               
            } return false;
        }

        /// <summary>
        /// To make the not endless (hopefully), I added the functionality
        /// that a player can only move a symbol to an empty space that touches the current symbol
        /// when all symbols are layed out
        /// Creates an array of buttons for each button of which moves are playable
        /// </summary>
        /// <param name="currSymbol"></param>
        /// <returns></returns>
        private Button[] SwitchButton(string currSymbol)
        {
            Button[] buttons;
            switch (currSymbol)
            {
                case "a1":
                    buttons = new Button[] { a2, b1, b2 };
                    return buttons;
                case "a2":
                    buttons = new Button[] { a1, a3, b1, b2, b3 };
                    return buttons;
                case "a3":
                    buttons = new Button[] { a2, b2, b3 };
                    return buttons;
                case "b1":
                    buttons = new Button[] { a1, a2, b2, c1, c2 };
                    return buttons;
                case "b2":
                    buttons = new Button[] { a1, a2, a3, b1, b3, c1, c2, c3 };
                    return buttons;
                case "b3":
                    buttons = new Button[] { a2, a3, b2, c2, c3 };
                    return buttons;
                case "c1":
                    buttons = new Button[] { b1, b2, c2 };
                    return buttons;
                case "c2":
                    buttons = new Button[] { b1, b2, b3, c1, c3 };
                    return buttons;
                case "c3":
                    buttons = new Button[] { b2, b3, c2 };
                    return buttons;
                default:
                    buttons = null;
                    return buttons;
            }
        }

        /// <summary>
        /// Checks if all players symbols are active, ie. they have put down 3 symbols
        /// Checks all buttons and if there are 3 X's and 3 O's
        /// </summary>
        /// <returns>Boolean, true if all symbols put down, false if not</returns>
        private bool CheckAllSymbolsActive()
        {
            int countX = 0;
            int countO = 0;
            foreach (Button button in grpBoard.Controls)
            {
                if (button.Text != String.Empty)
                {
                    if (button.Text == Symbol.X.ToString())
                        countX++;
                    else 
                        countO++;
                }
            } if (countX == 3 && countO == 3)
                return true;
            return false;
        }

        /// <summary>
        /// When the current players symbols is active, ie. its played all symbols
        /// and pressed a symbols to move, the blanks are enabled so user can move symbol
        /// Changes turn again so the user can press another button
        /// </summary>
        /// <param name="currButton"></param>
        private void EnableBlanks(Button currButton)
        {
            Button[] buttons = SwitchButton(currButton.Name);
            currButton.Text = String.Empty;
            
            FindBlanks(buttons);

            game.Turn = game.Turn;
            lblSymbol.Text = "X";
            currButton.Enabled = false;
        }

        /// <summary>
        /// Finds the blank button where user can put down symbol by using
        /// SwitchButton() and enables them
        /// </summary>
        /// <param name="buttons"></param>
        private void FindBlanks(Button[] buttons)
        {
            foreach (Button button in grpBoard.Controls)
            {
                if (buttons.Contains(button))
                {
                    if (button.Text == String.Empty)
                        button.Enabled = true;
                    else
                        button.Enabled = false;
                }
                else
                    button.Enabled = false;
            }
        }

        /// <summary>
        /// Marks the win of a symbol with green colour
        /// Sets win = true and updates GUI
        /// </summary>
        /// <param name="sym1"></param>
        /// <param name="sym2"></param>
        /// <param name="sym3"></param>
        private void MarkWin(Button sym1, Button sym2, Button sym3) 
        {
            sym1.ForeColor = Color.Green;
            sym2.ForeColor = Color.Green;
            sym3.ForeColor = Color.Green;
            sym1.Enabled = true;
            sym2.Enabled = true;
            sym3.Enabled = true;
            win = true;
            lblSymbol.Text = game.Winner;
            lblTurn.Text = "Winner:";

            AddWinAndUpdate(sym1);
        }

        /// <summary>
        /// Turns the player intoto a winner object
        /// Adds the winner to stats
        /// Updates the listbox with the winning player
        /// </summary>
        /// <param name="winningSymbol">Button with the winning symbol</param>
        private void AddWinAndUpdate(Button winningSymbol)
        {
            Winner winner = game.GetWinner((Symbol)Enum.Parse(typeof(Symbol), winningSymbol.Text));
            stats.AddStat(winner);
            lstStats.Items.Clear();
            lstStats.Items.AddRange(stats.ArrayToString());
            btnSwap.Enabled = true;
        }

        private void txtXPlayer_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void txtOPlayer_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        // If either of player names if changed, then the Start button is enabled
        private void EnableButton()
        {
            if (txtOPlayer.Text != String.Empty || txtXPlayer.Text != String.Empty)
                btnStart.Enabled = true;
            else
                btnStart.Enabled = false;
        }

        /// <summary>
        /// When there are players active they can change the names, which does not interrupt game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtXPlayer.Text = game.X.Name;
            txtOPlayer.Text = game.O.Name;
            btnStart.Text = "Save";
        }

        /// <summary>
        /// Event handler for Quit button
        /// If yes then program stops
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you would like to quit?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Event-handler for AboutBox in MenuStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolAbout_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
        }

        /// <summary>
        /// Event-hanler for Swap button
        /// Swaps the players and their symbols
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSwap_Click(object sender, EventArgs e)
        {
            Player temp = game.X; 
            game.X.Symbol = Symbol.O;
            game.X = game.O;
            game.O.Symbol = Symbol.X;
            game.O = temp;
            lblPlayerNames.Text = game.X.Name + " (X) vs " + game.O.Name + " (O)";
        }
    }
}
