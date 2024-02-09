using System;
using System.Drawing;
using System.Windows.Forms;

namespace Random_color_picker
{
    public partial class Form1 : Form
    {
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void nextColorButton_MouseClick(object sender, MouseEventArgs e)
        {
            ChangeBackgroundColor();
        }

        private void copyCurColorButton_MouseClick(object sender, MouseEventArgs e)
        {
            Color backgroundColor = this.BackColor;

            // Copy RGB to clipboard
            Clipboard.SetText($"{backgroundColor.R}:{backgroundColor.G}:{backgroundColor.B}");

            MessageBox.Show("The background color has been copied to the clipboard.", "Successfully copied");
        }

        private void ChangeBackgroundColor()
        {
            // Random numbers for color generation
            int red = random.Next(256);
            int green = random.Next(256);
            int blue = random.Next(256);

            this.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
