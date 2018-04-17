using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moradi_Anti_Virus
{
    public partial class Caculator : MetroFramework.Forms.MetroForm
    {
        public Caculator()
        {
            InitializeComponent();
        }

        private void caculator_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = metroTextBox1.Text + "1";
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = metroTextBox1.Text + "2";
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = metroTextBox1.Text + "3";
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = metroTextBox1.Text + "4";
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = metroTextBox1.Text + "5";
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = metroTextBox1.Text + "6";
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = metroTextBox1.Text + "7";
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = metroTextBox1.Text + "8";
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = metroTextBox1.Text + "9";
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = metroTextBox1.Text + "0";
        }

        private void metroButton12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Under Development","Cannot Use", MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
