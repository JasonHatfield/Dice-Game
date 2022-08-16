// Jason Hatfield
// This is my original work

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Dice_Game
{
    public partial class Dice : Form
    {
        public Dice()
        {
            InitializeComponent();
        }

        Random random = new Random();
        
        private int numberOfSides = 6; // establishes the number of sides for each die
        
        private void button1_Click(object sender, EventArgs e)
        {
            rollDie();  // calls the rollDie() method.
        }
        /// <summary>
        /// Method to roll two dice continuously until snake eyes is shown. Returns the count of rolls to get snake eyes.
        /// </summary>
        private void rollDie()
        {
            // clears the list box when the button is clicked.
            int dieOne, dieTwo, count = 0;

            do
            {
                dieOne = random.Next(1, numberOfSides + 1); // takes the number of sides and adds one to roll between 1 and that number.

                dieTwo = random.Next(1, numberOfSides + 1); // takes the number of sides and adds one to roll between 1 and that number.
                count++;

            }
            // while either the first or second die are not equal to one, the do loop repeats.
            while (dieOne != 1 || dieTwo != 1);

            // if statement to ensure the proper grammer is output if only one roll is needed to get to snake eyes.
            if (count == 1)
            {
                outputLabel.Text = ("It took " + count + " roll to get snake eyes!");
            }
            else
            {
                outputLabel.Text = ("It took " + count + " rolls to get snake eyes!");
            }
        }
    }
}
