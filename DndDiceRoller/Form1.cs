using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DndDiceRoller {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        // initialise the input from the user
        private void diceSides_TextChanged(object sender, EventArgs e) {

        }
        // initialise input from the user
        private void amountOfRolls_TextChanged(object sender, EventArgs e) {

        }
        // displays the output from the dice rolls
        private void outPutBox_TextChanged(object sender, EventArgs e) {

        }
        // tells the program to start calculations
        private void calcButton_Click(object sender, EventArgs e) {
            // Initial values for use later
            int diceRolled;
            int diceHasSides;

            // Reset the output for the next amount of code
            outPutBox.Text = "";

            // Checking to see if both the inputs
            // are actual integers, and not random
            // characters.
            if(!int.TryParse(diceSides.Text, out diceHasSides)) {
                MessageBox.Show("Are you sure that's a number?");
                diceSides.Text = "";
                diceSides.Focus();
                return;
            }

            if (!int.TryParse(amountOfRolls.Text, out diceRolled)) {
                MessageBox.Show("Are you sure that's a number?");
                amountOfRolls.Text = "";
                amountOfRolls.Focus();
                return;
            }

            int total = 0;
            Random rnd = new Random();

            for (int i = 1; i <= diceRolled; i++) {
                int numberofRolls = rnd.Next(1, diceHasSides + 1);
                Output(numberofRolls);
                total = total + numberofRolls;
            }

            Output(total);
        }

        void Output(int value) {
            outPutBox.Text += value.ToString("F2") + Environment.NewLine;
        }

        private void quitButton_Click(object sender, EventArgs e) {
            MessageBox.Show("Thanks for using");
            Application.Exit();
        }
    }
}
