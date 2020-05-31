/* Charlie Wolfsandle
   MS539 
   5/22/2020
   This program is to demonstrate the use of exception handling through the use of If..Else and Try / Catch */

/* I think that this will take me approximately 30 minutes 5/22/2020 */

/* It took me an hour to write since I wanted to add extra functionality and comments 5/22/2020*/
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CW_Exception_Handling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result;
            string str = textBox1.Text;
            if (int.TryParse(str, out result)) /*tries to parse the contents of str as an integer*/
            {
                MessageBox.Show("This is a valid integer" + Environment.NewLine + "(in the IF statement)"); /*Environment.NewLine is what will add a newline to the message box*/
            }
            else
            {
                MessageBox.Show("This is NOT a valid integer" + Environment.NewLine + "(in the ELSE statement)");
                MessageBox.Show("Please Try Again" + Environment.NewLine + "(Integers are whole numbers)");
                textBox1.Clear(); /*clears the entry if it is not an integer to guide user to try again*/
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boolean status = true;
            string str2 = textBox2.Text;
            try /*tries to parse entry as an integer*/
            {
                int.Parse(str2);
            }
            catch /*if the try fails, this will run*/
            {
                MessageBox.Show("This is NOT a valid integer" + Environment.NewLine + "(in the CATCH statement)");
                MessageBox.Show("Please Try Again" + Environment.NewLine + "(Integers are whole numbers)");
                textBox2.Clear();
                status = false;
            }
            finally /*if the try succeeds, this will run*/
            {
                if (status == true)
                {
                    MessageBox.Show("This is a valid integer" + Environment.NewLine + "(in the FINALLY statement)" + Environment.NewLine + "needed to output a successful TRY");
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
