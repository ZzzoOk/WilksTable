using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GemBox.Spreadsheet;

namespace WilksTable
{
    public partial class Form1 : Form
    {
        string fileName = "";
        bool changed;
        DataGridViewCellEventArgs ge;
        SortedList<string, int> prevCat;
        List<string> teams = new List<string>();

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < table.Columns.Count; ++i)
            {
                contextMenuStrip2.Items.Add(table.Columns[i].HeaderText);

                contextMenuStrip2.Items[i].Name = table.Columns[i].Name;

                ((ToolStripMenuItem)contextMenuStrip2.Items[i]).Checked = table.Columns[i].Visible;
            }

            prevCat = new SortedList<string, int>();

            prevCat.Add(mensCategories.DropDownItems[0].Text, 0);
            for (int i = 1; i < mensCategories.DropDownItems.Count; ++i)
                prevCat.Add(mensCategories.DropDownItems[i].Text, Convert.ToInt32(mensCategories.DropDownItems[i - 1].Text));

            prevCat.Add(womensCategories.DropDownItems[0].Text, 0);
            for (int i = 1; i < womensCategories.DropDownItems.Count; ++i)
                prevCat.Add(womensCategories.DropDownItems[i].Text, Convert.ToInt32(womensCategories.DropDownItems[i - 1].Text));

            changed = false;
        }

        private void newFile_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();

            fileName = ""; Text = "Таблица";
            saveFile.Enabled = false; changed = false;
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName != "")
            {
                try
                {
                    ExcelFile ef = new ExcelFile();
                    ef.LoadXls(openFileDialog1.FileName);
                    ExcelWorksheet ws = ef.Worksheets.ActiveWorksheet;

                    table.Rows.Clear(); teams.Clear();
                    for (int r = 1; r < ws.Rows.Count; r++)
                    {
                        table.Rows.Add(ws.Cells[r, 0].Value, Convert.ToDouble(ws.Cells[r, 1].Value), ws.Cells[r, 2].Value, Convert.ToDouble(ws.Cells[r, 3].Value),
                            Convert.ToDouble(ws.Cells[r, 4].Value), Convert.ToDouble(ws.Cells[r, 5].Value), Convert.ToDouble(ws.Cells[r, 6].Value), Convert.ToDouble(ws.Cells[r, 7].Value),
                            Convert.ToDouble(ws.Cells[r, 8].Value), Convert.ToDouble(ws.Cells[r, 9].Value), Convert.ToDouble(ws.Cells[r, 10].Value), Convert.ToDouble(ws.Cells[r, 11].Value),
                            Convert.ToDouble(ws.Cells[r, 12].Value), Convert.ToDouble(ws.Cells[r, 13].Value), Convert.ToDouble(ws.Cells[r, 14].Value), ws.Cells[r, 15].Value);

                        if (table.Rows[r - 1].Cells[2].Value.ToString() != string.Empty && !teams.Contains(table.Rows[r - 1].Cells[2].Value.ToString()))
                            teams.Add(table.Rows[r - 1].Cells[2].Value.ToString());

                        for (int c = 3; c <= 11; c++)
                        {
                            if (ws.Cells[r, c].Style.FillPattern.PatternForegroundColor.Name == "ff90ee90")
                                table.Rows[r - 1].Cells[c].Style.BackColor = Color.LightGreen;
                            if (ws.Cells[r, c].Style.FillPattern.PatternForegroundColor.Name == "ffdb7093")
                                table.Rows[r - 1].Cells[c].Style.BackColor = Color.PaleVioletRed;
                        }
                    }

                    Text = openFileDialog1.FileName + " - Таблица";
                    fileName = openFileDialog1.FileName;
                    saveFile.Enabled = true;
                    changed = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelFile ef = new ExcelFile();

                ExcelWorksheet ws = ef.Worksheets.Add("Соревнования (" + DateTime.Now.Date + ")");

                ws.Cells[0, 0].Value = "Имя"; ws.Cells[0, 1].Value = "Вес"; ws.Cells[0, 2].Value = "Команда";
                ws.Cells[0, 3].Value = "Приседания"; ws.Cells[0, 4].Value = "2"; ws.Cells[0, 5].Value = "3"; ws.Cells[0, 6].Value = "Жим"; ws.Cells[0, 6].Value = "2";
                ws.Cells[0, 8].Value = "3"; ws.Cells[0, 9].Value = "Тяга"; ws.Cells[0, 10].Value = "2"; ws.Cells[0, 11].Value = "3";
                ws.Cells[0, 12].Value = "Сумма"; ws.Cells[0, 13].Value = "Результат"; ws.Cells[0, 14].Value = "Коэффициент";

                for (int r = 0; r < table.Rows.Count; r++)
                {
                    for (int c = 0; c < table.ColumnCount; c++)
                    {
                        ws.Cells[r + 1, c].Value = table.Rows[r].Cells[c].Value;

                        if (table.Rows[r].Cells[c].Style.BackColor != Color.Empty)
                            ws.Cells[r + 1, c].Style.FillPattern.SetPattern(FillPatternStyle.Solid, table.Rows[r].Cells[c].Style.BackColor, Color.Empty);
                    }
                }

                ef.SaveXls(fileName);
                changed = false;
                Text = fileName + " - Таблица";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveFileAsTSMI_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != "")
            {
                fileName = saveFileDialog1.FileName;
                saveFile_Click(null, null);
                this.Text = fileName + " - Таблица";
                saveFile.Enabled = true;
                changed = false;
            }
        }

        private void addRow_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(teams);
            var res = f2.ShowDialog();

            if (res == DialogResult.OK)
            {
                table.Rows.Add(f2.Name1, f2.Weight, f2.Team, f2.Squat, 0.0, 0.0, f2.Bench, 0.0, 0.0, f2.Lift, 0.0, 0.0, 0.0, null, f2.Coefficient, f2.Gender);

                if (f2.Team != string.Empty && !teams.Contains(f2.Team))
                    teams.Add(f2.Team);
            }
        }

        private void deleteRow_Click(object sender, EventArgs e)
        {
            if (table.CurrentRow != null)
                table.Rows.Remove(table.CurrentRow);
        }

        private void getResults_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < table.Rows.Count; i++)
                table.Rows[i].Cells[13].Value = (double)table.Rows[i].Cells[12].Value * (double)table.Rows[i].Cells[14].Value;
        }

        private void newGroup_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(table);

            var res = f3.ShowDialog();

            if (res == DialogResult.OK)
            {
                groups.DropDownItems[0].Visible = false;
                groups.DropDownItems[1].Visible = true;

                for (int i = 0; i < f3.GroupCount; ++i)
                {
                    groups.DropDownItems.Add((i + 1).ToString());

                    groups.DropDownItems[2 + i].Click += new EventHandler(changeGroup);
                }
            }
        }

        private void mergeGroups_Click(object sender, EventArgs e)
        {
            groups.DropDownItems[0].Visible = true;
            groups.DropDownItems[1].Visible = false;

            while (groups.DropDownItems.Count > 2)
                groups.DropDownItems.RemoveAt(2);

            for (int i = 0; i < table.RowCount; ++i)
            {
                table.Rows[i].Cells["Group"].Value = 1;
                table.Rows[i].Visible = true;
            }
        }

        private void changeGroup(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;

            foreach (ToolStripMenuItem mi in groups.DropDownItems)
                mi.Checked = false;

            menuItem.Checked = true;

            for (int i = 0; i < table.RowCount; ++i)
                if (table.Rows[i].Cells["Group"].Value.ToString() == menuItem.Text)
                    table.Rows[i].Visible = true;
                else
                    table.Rows[i].Visible = false;
        }

        private void mensCategories_Click(object sender, EventArgs e)
        {
            if (mensCategories.Checked)
            {
                for (int i = 0; i < table.Rows.Count; ++i)
                    table.Rows[i].Visible = true;

                foreach (ToolStripMenuItem t in mensCategories.DropDownItems)
                    t.Checked = false;

                mensCategories.Checked = false;
            }
            else
            {
                for (int i = 0; i < (table.Rows.Count); ++i)
                {
                    table.Rows[i].Visible = true;

                    if (table.Rows[i].Cells[15].Value.ToString() == "ж")
                        table.Rows[i].Visible = false;
                }

                foreach (ToolStripMenuItem t in womensCategories.DropDownItems)
                    t.Checked = false;
                foreach (ToolStripMenuItem t in mensCategories.DropDownItems)
                    t.Checked = true;

                womensCategories.Checked = false;
                mensCategories.Checked = true;
            }
        }

        private void womensCategories_Click(object sender, EventArgs e)
        {
            if (womensCategories.Checked)
            {
                for (int i = 0; i < table.Rows.Count; ++i)
                    table.Rows[i].Visible = true;

                foreach (ToolStripMenuItem t in womensCategories.DropDownItems)
                    t.Checked = false;

                womensCategories.Checked = false;
            }
            else
            {
                for (int i = 0; i < (table.Rows.Count); ++i)
                {
                    table.Rows[i].Visible = true;

                    if (table.Rows[i].Cells[15].Value.ToString() == "м")
                        table.Rows[i].Visible = false;
                }

                foreach (ToolStripMenuItem t in mensCategories.DropDownItems)
                    t.Checked = false;
                foreach (ToolStripMenuItem t in womensCategories.DropDownItems)
                    t.Checked = true;

                mensCategories.Checked = false;
                womensCategories.Checked = true;
            }
        }

        private void mensCat_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            if (menuItem.Checked && !mensCategories.Checked)
            {
                for (int i = 0; i < table.Rows.Count; ++i)
                    table.Rows[i].Visible = true;

                menuItem.Checked = false;
            }
            else
            {
                foreach (ToolStripMenuItem t in mensCategories.DropDownItems)
                    t.Checked = false;
                foreach (ToolStripMenuItem t in womensCategories.DropDownItems)
                    t.Checked = false;

                for (int i = 0; i < (table.Rows.Count); ++i)
                {
                    table.Rows[i].Visible = true;

                    if (table.Rows[i].Cells[15].Value.ToString() == "ж" || (menuItem.Text.Contains("+") ? (Convert.ToDouble(table.Rows[i].Cells[1].Value) <= prevCat[menuItem.Text]) :
                        (Convert.ToDouble(table.Rows[i].Cells[1].Value) > Convert.ToDouble(menuItem.Text) || Convert.ToDouble(table.Rows[i].Cells[1].Value) <= prevCat[menuItem.Text])))
                        table.Rows[i].Visible = false;
                }

                mensCategories.Checked = false;
                womensCategories.Checked = false;
                menuItem.Checked = true;
            }
        }

        private void womensCat_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            if (menuItem.Checked && !womensCategories.Checked)
            {
                for (int i = 0; i < table.Rows.Count; ++i)
                {
                    table.Rows[i].Visible = true;
                }

                menuItem.Checked = false;
            }
            else
            {
                foreach (ToolStripMenuItem t in mensCategories.DropDownItems)
                    t.Checked = false;
                foreach (ToolStripMenuItem t in womensCategories.DropDownItems)
                    t.Checked = false;

                for (int i = 0; i < (table.Rows.Count); ++i)
                {
                    table.Rows[i].Visible = true;

                    if (table.Rows[i].Cells[15].Value.ToString() == "м" || (menuItem.Text.Contains("+") ? (Convert.ToDouble(table.Rows[i].Cells[1].Value) <= prevCat[menuItem.Text]) :
                        (Convert.ToDouble(table.Rows[i].Cells[1].Value) > Convert.ToDouble(menuItem.Text) || Convert.ToDouble(table.Rows[i].Cells[1].Value) <= prevCat[menuItem.Text])))
                        table.Rows[i].Visible = false;
                }

                mensCategories.Checked = false;
                womensCategories.Checked = false;
                menuItem.Checked = true;
            }
        }

        private void teamResult_Click(object sender, EventArgs e)
        {
            if (table.Rows.Count > 0)
            {
                string info = string.Format("{0,-30}\t{1}\t{2}\t\n\n", "Команда", "Состав", "Результат");

                int n; double d;
                foreach (string s in teams)
                {
                    n = 0; d = 0;

                    for (int i = 0; i < table.Rows.Count; ++i)
                        if (table.Rows[i].Cells[2].Value.ToString().Equals(s))
                        {
                            d += Convert.ToDouble(table.Rows[i].Cells[12].Value);

                            ++n;
                        }

                    if (n > 0)
                        info += string.Format("{0,-30}\t{1,30}\t{2,12:N2}\t\n", s, n, d);
                }

                MessageBox.Show(info);
            }
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Коэффициент Уилкса или Формула Уилкса — это коэффициент для оценки силы тяжелоатлета относительно других спортсменов независимо от их веса. Автором формулы является Роберт Уилкс (Robert Wilks).

Горячие клавиши:

Ctrl+N — добавить спортсмена
Delete — удалить выделенного спортсмена


Программа написана специально для секции пауэрлифтинга МГТУ им. Н.Э. Баумана

Репозиторий на GitHub: github.com/ZzzoOk/WilksTable", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void setSuccAttempt_Click(object sender, EventArgs e)
        {
            table.Rows[ge.RowIndex].Cells[ge.ColumnIndex].Style.BackColor = Color.LightGreen;
            table_CellEndEdit(sender, ge);
        }

        private void setFailAttempt_Click(object sender, EventArgs e)
        {
            table.Rows[ge.RowIndex].Cells[ge.ColumnIndex].Style.BackColor = Color.PaleVioletRed;
            table_CellEndEdit(sender, ge);
        }

        private void table_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 2 && e.ColumnIndex < 12)
            {
                try
                {
                    table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = double.Parse(table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                }
                catch
                {
                    table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                }

                double squat = 0, bench = 0, dead = 0;

                for (int i = 3; i < 6; i++)
                {
                    if (table.Rows[e.RowIndex].Cells[i].Value != null && table.Rows[e.RowIndex].Cells[i].Style.BackColor == Color.LightGreen && (double)table.Rows[e.RowIndex].Cells[i].Value != 0)
                        squat = double.Parse(table.Rows[e.RowIndex].Cells[i].Value.ToString());

                    if (table.Rows[e.RowIndex].Cells[i + 3].Value != null && table.Rows[e.RowIndex].Cells[i + 3].Style.BackColor == Color.LightGreen && (double)table.Rows[e.RowIndex].Cells[i + 3].Value != 0)
                        bench = double.Parse(table.Rows[e.RowIndex].Cells[i + 3].Value.ToString());

                    if (table.Rows[e.RowIndex].Cells[i + 6].Value != null && table.Rows[e.RowIndex].Cells[i + 6].Style.BackColor == Color.LightGreen && (double)table.Rows[e.RowIndex].Cells[i + 6].Value != 0)
                        dead = double.Parse(table.Rows[e.RowIndex].Cells[i + 6].Value.ToString());
                }

                table.Rows[e.RowIndex].Cells[12].Value = squat + bench + dead;
            }
        }

        private void tableChanged()
        {
            changed = true;

            if (fileName != "")
                Text = fileName + "*" + " - Таблица";
        }

        private void table_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            tableChanged();
        }

        private void table_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            tableChanged();
        }

        private void table_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            tableChanged();
        }

        private void table_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            ge = e;
        }

        private void table_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip2.Show(MousePosition);
        }

        private void contextMenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ((ToolStripMenuItem)e.ClickedItem).Checked = !((ToolStripMenuItem)e.ClickedItem).Checked;

            table.Columns[e.ClickedItem.Name].Visible = ((ToolStripMenuItem)e.ClickedItem).Checked;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changed)
            {
                DialogResult result = MessageBox.Show(this, "Сохранить таблицу?", "Таблица", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                    if (fileName != "")
                        saveFile_Click(null, null);
                    else
                        saveFileAsTSMI_Click(sender, e);

                if (result == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }
    }
}