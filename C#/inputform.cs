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
    public partial class inputform : Form
    {
        public string returntext;
        public inputform()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
           returntext = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "List of Characters: "+functions.characterlist();
            string title = "Help";
            MessageBox.Show(message, title);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
