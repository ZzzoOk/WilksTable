using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GemBox.Spreadsheet;

namespace WilksTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            prevCat = new SortedList<string, double>();
            prevCat.Add(mensCategories.DropDownItems[0].Text, 0);
            for (int i = 1; i < mensCategories.DropDownItems.Count; ++i)
                prevCat.Add(mensCategories.DropDownItems[i].Text, Convert.ToDouble(mensCategories.DropDownItems[i - 1].Text));

            prevCat.Add(womensCategories.DropDownItems[0].Text, 0);
            for (int i = 1; i < womensCategories.DropDownItems.Count; ++i)
                prevCat.Add(womensCategories.DropDownItems[i].Text, Convert.ToDouble(womensCategories.DropDownItems[i - 1].Text));
        }

        string fileName = "";
        bool changed = false;
        DataGridViewCellEventArgs ge;
        SortedList<string, double> prevCat;
        ToolStripMenuItem menuItem;

        private void newFile_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
            fileName = "";
            Text = "Таблица";
            saveFile.Enabled = false;
            changed = false;
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialog1.FileName != "")
            {
                try
                {
                    ExcelFile xls = new ExcelFile();
                    xls.LoadXls(openFileDialog1.FileName);
                    table.Rows.Clear();
                    ExcelWorksheet ws = xls.Worksheets.ActiveWorksheet;
                    for (int r = 1; r < ws.Rows.Count; r++)
                    {
                        table.Rows.Add(ws.Cells[r, 0].Value, ws.Cells[r, 1].Value, ws.Cells[r, 2].Value, ws.Cells[r, 3].Value, ws.Cells[r, 4].Value, ws.Cells[r, 5].Value, ws.Cells[r, 6].Value, ws.Cells[r, 7].Value, ws.Cells[r, 8].Value, ws.Cells[r, 9].Value, ws.Cells[r, 10].Value, ws.Cells[r, 11].Value, ws.Cells[r, 12].Value, ws.Cells[r, 13].Value, ws.Cells[r, 14].Value);
                        for (int c = 2; c <= 10; c++)
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
                ExcelWorksheet ws = ef.Worksheets.Add("Таблица");
                ws.Cells[0, 0].Value = "Имя"; ws.Cells[0, 1].Value = "Вес"; ws.Cells[0, 2].Value = "Приседания"; ws.Cells[0, 3].Value = "2";
                ws.Cells[0, 4].Value = "3"; ws.Cells[0, 5].Value = "Жим"; ws.Cells[0, 6].Value = "2"; ws.Cells[0, 7].Value = "3";
                ws.Cells[0, 8].Value = "Тяга"; ws.Cells[0, 9].Value = "2"; ws.Cells[0, 10].Value = "3";
                ws.Cells[0, 11].Value = "Сумма"; ws.Cells[0, 12].Value = "Результат"; ws.Cells[0, 13].Value = "Коэффициент";
                for (int r = 0; r < table.RowCount; r++)
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
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog1.FileName != "")
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
            Form2 f2 = new Form2();
            f2.ShowDialog();

            if (f2.isCalculated)
                table.Rows.Add(f2.getName, f2.getWeight, f2.getSquat, 0.0, 0.0, f2.getBench, 0.0, 0.0, f2.getDead, 0.0, 0.0, 0.0, null, f2.coefficient, f2.getGender);
        }

        private void deleteRow_Click(object sender, EventArgs e)
        {
            if (table.CurrentRow.Index < table.RowCount - 1)
                table.Rows.Remove(table.CurrentRow);
        }

        private void getResults_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < table.RowCount - 1; i++)
                table.Rows[i].Cells[12].Value = (double)table.Rows[i].Cells[11].Value * (double)table.Rows[i].Cells[13].Value;
        }

        private void mensCat_Click(object sender, System.EventArgs e)
        {
            menuItem = (ToolStripMenuItem)sender;
            if (menuItem.Checked)
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

                for (int i = 0; i < (table.Rows.Count - 1); ++i)
                {
                    table.Rows[i].Visible = true;

                    if (table.Rows[i].Cells[14].Value.ToString() == "ж" || (menuItem.Text.Contains("+") ? (Convert.ToDouble(table.Rows[i].Cells[1].Value) <= prevCat[menuItem.Text]) :
                        (Convert.ToDouble(table.Rows[i].Cells[1].Value) > Convert.ToDouble(menuItem.Text) || Convert.ToDouble(table.Rows[i].Cells[1].Value) <= prevCat[menuItem.Text])))
                        table.Rows[i].Visible = false;
                }

                menuItem.Checked = true;
            }
        }

        private void womensCat_Click(object sender, System.EventArgs e)
        {
            menuItem = (ToolStripMenuItem)sender;
            if (menuItem.Checked)
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

                for (int i = 0; i < (table.Rows.Count - 1); ++i)
                {
                    table.Rows[i].Visible = true;

                    if (table.Rows[i].Cells[14].Value.ToString() == "м" || (menuItem.Text.Contains("+") ? (Convert.ToDouble(table.Rows[i].Cells[1].Value) <= prevCat[menuItem.Text]) :
                        (Convert.ToDouble(table.Rows[i].Cells[1].Value) > Convert.ToDouble(menuItem.Text) || Convert.ToDouble(table.Rows[i].Cells[1].Value) <= prevCat[menuItem.Text])))
                        table.Rows[i].Visible = false;
                }

                menuItem.Checked = true;
            }
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Коэффициент Уилкса или Формула Уилкса — это коэффициент для оценки силы тяжелоатлета относительно других спортсменов независимо от их веса. Автором формулы является Роберт Уилкс (Robert Wilks).\r\n\r\n Программа написана специально для СК «ОЛИМП».\r\n\r\n Репозиторий на GitHub: github.com/ZzzoOk/WilksTable", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (e.RowIndex == table.Rows.Count - 1)
                return;

            if (e.ColumnIndex != 0)
                try
                {
                    table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = double.Parse(table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                }
                catch
                {
                    table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                }

            if (e.ColumnIndex > 1 && e.ColumnIndex < 11)
            {
                double squat = 0, bench = 0, dead = 0;
                for (int i = 2; i < 5; i++)
                {
                    if (table.Rows[e.RowIndex].Cells[i].Value != null && table.Rows[e.RowIndex].Cells[i].Style.BackColor == Color.LightGreen && (double)table.Rows[e.RowIndex].Cells[i].Value != 0)
                        squat = double.Parse(table.Rows[e.RowIndex].Cells[i].Value.ToString());

                    if (table.Rows[e.RowIndex].Cells[i + 3].Value != null && table.Rows[e.RowIndex].Cells[i + 3].Style.BackColor == Color.LightGreen && (double)table.Rows[e.RowIndex].Cells[i + 3].Value != 0)
                        bench = double.Parse(table.Rows[e.RowIndex].Cells[i + 3].Value.ToString());

                    if (table.Rows[e.RowIndex].Cells[i + 6].Value != null && table.Rows[e.RowIndex].Cells[i + 6].Style.BackColor == Color.LightGreen && (double)table.Rows[e.RowIndex].Cells[i + 6].Value != 0)
                        dead = double.Parse(table.Rows[e.RowIndex].Cells[i + 6].Value.ToString());
                }

                table.Rows[e.RowIndex].Cells[11].Value = squat + bench + dead;
            }
        }

        private void table_Changed(object sender, EventArgs e)
        {
            changed = true;

            if (fileName != "")
                Text = fileName + "*" + " - Таблица";
        }

        private void table_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            ge = e;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changed)
            {
                DialogResult result = MessageBox.Show(this, "Сохранить таблицу результатов?", "Таблица", MessageBoxButtons.YesNoCancel);
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
