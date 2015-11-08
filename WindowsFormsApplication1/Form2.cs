using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace WilksTable
{
    public partial class Form2 : Form
    {
        public string Name1, Gender, Team;
        public double Weight, Squat, Bench, Lift, Coefficient;

        public Form2(List<string> teams)
        {
            InitializeComponent();
            gender.SelectedIndex = 0;

            team.Items.Clear();
            team.Items.AddRange(teams.ToArray());
        }

        public void button1_Click(object sender, EventArgs ee)
        {
            try
            {
                Weight = double.Parse(weight.Text); Squat = double.Parse(squat.Text);
                Bench = double.Parse(benchPress.Text); Lift = double.Parse(deadlift.Text);
                Gender = gender.SelectedIndex == 0 ? "м" : "ж";
                Name1 = name.Text; Team = team.Text;

                double a = -216.0475144, b = 16.2606339, c = -0.002388645, d = -0.00113732, e = 7.01863E-06, f = -1.291E-08, x = Weight;

                if (gender.SelectedIndex == 1)
                {
                    a = 594.31747775582; b = -27.23842536447; c = 0.82112226871; d = -0.00930733913; e = 0.00004731582; f = -0.00000009054;
                }

                Coefficient = 500 / (a + b * x + c * (x * x) + d * (x * x * x) + e * (x * x * x * x) + f * (x * x * x * x * x));
                Coefficient = Math.Round(Coefficient, 4);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");

                DialogResult = DialogResult.None;
            }
        }

        private void checkEmpty(object sender, EventArgs e)
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

        private void checkPressedKey(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != NumberFormatInfo.CurrentInfo.NumberDecimalSeparator[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
