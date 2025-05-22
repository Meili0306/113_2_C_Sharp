using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Spectrum
{
    enum Spectrum 
    { 
        Red, Orange, Yellow, Green,
        Blue, Indigo, Violet 
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 將所有顏色相關的 label 的 Text 屬性設為 null
            redLabel.Text = null;
            orangeLabel.Text = null;
            yellowLabel.Text = null;
            greenLabel.Text = null;
            blueLabel.Text = null;
            indigoLabel.Text = null;
            violetLabel.Text = null;
        }

        // The DisplayColor method displays the
        // name of a color.
        private void DisplayColor(Spectrum color)
        {
            colorLabel.Text = color.ToString();
        }

        private void redLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Red);
        }

        private void orangeLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Orange);
        }

        private void yellowLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Yellow);
        }

        private void greenLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Green);
        }

        private void blueLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Blue);
        }

        private void indigoLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Indigo);
        }

        private void violetLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Violet);
        }
    }
}
