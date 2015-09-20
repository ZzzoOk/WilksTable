using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WilksTable
{
    public partial class Form2 : Form
    {
        public string getName { get { return name.Text; } }

        public double getWeight { get { return double.Parse(weight.Text); } }

        public double getSquat { get { return double.Parse(squat.Text); } }

        public double getBench { get { return double.Parse(benchPress.Text); } }

        public double getDead { get { return double.Parse(deadlift.Text); } }

        public string getGender { get { return gender.SelectedIndex == 0 ? "м" : "ж"; } }

        public string getTeam { get { return team.Text; } }

        public double coefficient; public bool isCalculated = false;

        public Form2(List<string> teams)
        {
            InitializeComponent();
            gender.SelectedIndex = 0;

            team.Items.Clear();
            foreach (string t in teams)
                team.Items.Add(t);
        }

        public void button1_Click(object sender, EventArgs ee)
        {
            double a = -216.0475144, b = 16.2606339, c = -0.002388645, d = -0.00113732, e = 7.01863E-06, f = -1.291E-08, x = double.Parse(weight.Text);

            if (gender.SelectedIndex == 1)
            {
                a = 594.31747775582; b = -27.23842536447; c = 0.82112226871; d = -0.00930733913; e = 0.00004731582; f = -0.00000009054;
            }

            coefficient = 500 / (a + b * x + c * (x * x) + d * (x * x * x) + e * (x * x * x * x) + f * (x * x * x * x * x));
            coefficient = Math.Round(coefficient, 4);
            isCalculated = true;
            this.Close();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            if ((name.Text.Length > 0) && (weight.Text.Length > 0) && (squat.Text.Length > 0) && (benchPress.Text.Length > 0) && (deadlift.Text.Length > 0))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void weight_TextChanged(object sender, EventArgs e)
        {
            if ((name.Text.Length > 0) && (weight.Text.Length > 0) && (squat.Text.Length > 0) && (benchPress.Text.Length > 0) && (deadlift.Text.Length > 0))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void squat_TextChanged(object sender, EventArgs e)
        {
            if ((name.Text.Length > 0) && (weight.Text.Length > 0) && (squat.Text.Length > 0) && (benchPress.Text.Length > 0) && (deadlift.Text.Length > 0))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void benchPress_TextChanged(object sender, EventArgs e)
        {
            if ((name.Text.Length > 0) && (weight.Text.Length > 0) && (squat.Text.Length > 0) && (benchPress.Text.Length > 0) && (deadlift.Text.Length > 0))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void deadlift_TextChanged(object sender, EventArgs e)
        {
            if ((name.Text.Length > 0) && (weight.Text.Length > 0) && (squat.Text.Length > 0) && (benchPress.Text.Length > 0) && (deadlift.Text.Length > 0))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != ',') && (e.KeyChar != '.') && (e.KeyChar != (char)13))
            {
                e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void squat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != ',') && (e.KeyChar != '.') && (e.KeyChar != (char)13))
            {
                e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void benchPress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != ',') && (e.KeyChar != '.') && (e.KeyChar != (char)13))
            {
                e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void deadlift_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != ',') && (e.KeyChar != '.') && (e.KeyChar != (char)13))
            {
                e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
