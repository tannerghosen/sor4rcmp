using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sor4
{
    public partial class sor4form : Form
    {
        public sor4form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // randomly pick character
        {
            string message = functions.pick("random");
            string title = "Randomly Pick a Character";
            MessageBox.Show(message, title);

        }

        private void button2_Click(object sender, EventArgs e) // choose character
        {
            // for this I think we need 2 popups, one with text input and one for the result
            inputform input = new inputform();
            input.Text = "Choose a Character";
            input.ShowDialog();
            string result = input.returntext;
           // string message = result;
            string message = functions.pick(result); //placeholder
            string title = "Choose a Character";
            MessageBox.Show(message, title);
        }

        private void button3_Click(object sender, EventArgs e) // random stage
        {
            string message = functions.randomstage();
            string title = "Randomly Pick a Stage";
            MessageBox.Show(message, title);
        }

        private void button4_Click(object sender, EventArgs e) // these 3 below handle the 3 displays (normal/alt, move names, both)
        {
            functions.changemoves(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            functions.changemoves(1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            functions.changemoves(2);
        }

        private void button7_Click(object sender, EventArgs e) // Help Button
        {
            string message = "Street of Rage 4 Random Character & Moveset Picker"+ "\n\n" + "List of Characters: " + functions.characterlist();
            string title = "Help";
            MessageBox.Show(message, title);
        }
    }
}
