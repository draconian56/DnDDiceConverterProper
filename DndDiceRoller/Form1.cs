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

        private void calcButton_Click(object sender, EventArgs e) {
            int diceRolled;
            int diceHasSides;

            outPutBox.Text = "";

            if(!int.TryParse(DinceNumber.Text, out diceHasSides)) {
                MessageBox.Show("Are you sure that's a number?");
                DinceNumber.Text = "";
                DinceNumber.Focus();
                return;
            }

            if (!int.TryParse(amountOfRolls.Text, out diceRolled)) {
                MessageBox.Show("Are you sure that's a number?");
                amountOfRolls.Text = "";
                amountOfRolls.Focus();
                return;
            }

            int rollCheck = 0;
            int total = 0;
            Random rnd = new Random();

            for (int i = 1; i <= diceRolled; i++) {
                int numberofRolls = rnd.Next(1, diceHasSides + 1);
                total = total + numberofRolls;

                if (oneAsTwo.Checked) {
                    if (numberofRolls == 1) {
                        numberofRolls = 2;
                    }
                }

                if (RerollOnes.Checked) {
                    if (rollCheck != 1) {
                        if (numberofRolls == 1) {
                            numberofRolls = rnd.Next(1, diceHasSides + 1);
                            rollCheck = 1;
                        }
                    }
                }

                Output(numberofRolls);
            }

            Output(total);
        }

        void Output(int value) {
            outPutBox.Text += value.ToString("") + Environment.NewLine;
        }

        private void quitButton_Click(object sender, EventArgs e) {
            MessageBox.Show("Thank you for using this program\nGoobye!", "Exit");
            Application.Exit();
        }

        private void ClearAll_Click(object sender, EventArgs e) {
            DinceNumber.Text = "";
            amountOfRolls.Text = "";
            outPutBox.Text = "";
            oneAsTwo.Checked = false;
            RerollOnes.Checked = false;
        }

        private void diceSides_TextChanged(object sender, EventArgs e) {

        }

        private void amountOfRolls_TextChanged(object sender, EventArgs e) {

        }

        private void outPutBox_TextChanged(object sender, EventArgs e) {
            outPutBox.ScrollBars = ScrollBars.Vertical;
        }

        private void oneAsTwo_CheckedChanged(object sender, EventArgs e) {

        }

        private void RerollOnes_CheckedChanged(object sender, EventArgs e) {

        }

        private void DinceNumber_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
