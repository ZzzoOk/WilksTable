using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace WilksTable
{
    public partial class Form3 : Form
    {
        DataGridView table;

        public int GroupCount;

        public Form3(DataGridView data)
        {
            InitializeComponent();

            table = data;

            numericUpDown1.Maximum = table.Rows.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                GroupCount = (int)numericUpDown1.Value;
                int[] members = textBox1.Text.Split(',').Select(Int32.Parse).ToArray();

                int count = 0;
                foreach (int n in members)
                    count += n;

                if (count == table.Rows.Count && GroupCount == members.Length)
                {
                    int c = 3;  // squat column
                    if (radioButton2.Checked)
                        c = 6;  // bench column
                    if (radioButton3.Checked)
                        c = 9;  // lift column

                    table.Sort(table.Columns[c], ListSortDirection.Ascending);

                    int n = 0;
                    for (int i = 0; i < members.Length; ++i)
                        for (int j = 0; j < members[i]; ++j)
                            table.Rows[n++].Cells["Group"].Value = i + 1;
                }
                else
                {
                    MessageBox.Show("Суммарное количество людей всех потоков должно совпадать с количеством людей в таблице", "Ошибка распределения по потокам");

                    DialogResult = DialogResult.None;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");

                DialogResult = DialogResult.None;
            }
        }

        private void Form3_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Задайте количество потоков, затем, во втором поле введите количество человек в каждом потоке через запятую. Например:\n\n" +
                "Всего человек: 25\nКол-во потоков: 3\nКол-во людей в потоке: 10, 10, 5\n\n"+
                "Разделение происходит по выбранному полю, которое будет отсортировано по возрастанию");
        }

        private void checkEmpty(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
