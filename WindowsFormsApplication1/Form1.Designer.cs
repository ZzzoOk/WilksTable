namespace WilksTable
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.table = new System.Windows.Forms.DataGridView();
            this.tname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tweight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.squat1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.squat2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.squat3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.benchpress1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.benchpress2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.benchpress3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadlift1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadlift2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadlift3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tresult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coefficient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.newTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.open = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.addRow = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.getResults = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tname,
            this.tweight,
            this.squat1,
            this.squat2,
            this.squat3,
            this.benchpress1,
            this.benchpress2,
            this.benchpress3,
            this.deadlift1,
            this.deadlift2,
            this.deadlift3,
            this.ttotal,
            this.tresult,
            this.Coefficient});
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 24);
            this.table.Margin = new System.Windows.Forms.Padding(4);
            this.table.MultiSelect = false;
            this.table.Name = "table";
            this.table.RowHeadersVisible = false;
            this.table.RowTemplate.DefaultCellStyle.Format = "#,##0.##";
            this.table.RowTemplate.DefaultCellStyle.NullValue = null;
            this.table.Size = new System.Drawing.Size(884, 338);
            this.table.TabIndex = 0;
            this.table.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellEndEdit);
            this.table.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellMouseEnter);
            // 
            // tname
            // 
            this.tname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tname.HeaderText = "Имя";
            this.tname.Name = "tname";
            // 
            // tweight
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.tweight.DefaultCellStyle = dataGridViewCellStyle1;
            this.tweight.HeaderText = "Вес";
            this.tweight.Name = "tweight";
            this.tweight.ReadOnly = true;
            this.tweight.Width = 58;
            // 
            // squat1
            // 
            this.squat1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.squat1.DefaultCellStyle = dataGridViewCellStyle2;
            this.squat1.HeaderText = "Приседания";
            this.squat1.Name = "squat1";
            this.squat1.Width = 121;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.toolStripMenuItem1.Text = "Засчитан";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(141, 22);
            this.toolStripMenuItem2.Text = "Не засчитан";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // squat2
            // 
            this.squat2.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Format = "N2";
            this.squat2.DefaultCellStyle = dataGridViewCellStyle3;
            this.squat2.HeaderText = "2";
            this.squat2.Name = "squat2";
            this.squat2.Width = 43;
            // 
            // squat3
            // 
            this.squat3.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle4.Format = "N2";
            this.squat3.DefaultCellStyle = dataGridViewCellStyle4;
            this.squat3.HeaderText = "3";
            this.squat3.Name = "squat3";
            this.squat3.Width = 43;
            // 
            // benchpress1
            // 
            this.benchpress1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle5.Format = "N2";
            this.benchpress1.DefaultCellStyle = dataGridViewCellStyle5;
            this.benchpress1.HeaderText = "Жим";
            this.benchpress1.Name = "benchpress1";
            this.benchpress1.Width = 67;
            // 
            // benchpress2
            // 
            this.benchpress2.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle6.Format = "N2";
            this.benchpress2.DefaultCellStyle = dataGridViewCellStyle6;
            this.benchpress2.HeaderText = "2";
            this.benchpress2.Name = "benchpress2";
            this.benchpress2.Width = 43;
            // 
            // benchpress3
            // 
            this.benchpress3.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle7.Format = "N2";
            this.benchpress3.DefaultCellStyle = dataGridViewCellStyle7;
            this.benchpress3.HeaderText = "3";
            this.benchpress3.Name = "benchpress3";
            this.benchpress3.Width = 43;
            // 
            // deadlift1
            // 
            this.deadlift1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle8.Format = "N2";
            this.deadlift1.DefaultCellStyle = dataGridViewCellStyle8;
            this.deadlift1.HeaderText = "Тяга";
            this.deadlift1.Name = "deadlift1";
            this.deadlift1.Width = 67;
            // 
            // deadlift2
            // 
            this.deadlift2.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle9.Format = "N2";
            this.deadlift2.DefaultCellStyle = dataGridViewCellStyle9;
            this.deadlift2.HeaderText = "2";
            this.deadlift2.Name = "deadlift2";
            this.deadlift2.Width = 43;
            // 
            // deadlift3
            // 
            this.deadlift3.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle10.Format = "N2";
            this.deadlift3.DefaultCellStyle = dataGridViewCellStyle10;
            this.deadlift3.HeaderText = "3";
            this.deadlift3.Name = "deadlift3";
            this.deadlift3.Width = 43;
            // 
            // ttotal
            // 
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.ttotal.DefaultCellStyle = dataGridViewCellStyle11;
            this.ttotal.HeaderText = "Сумма";
            this.ttotal.Name = "ttotal";
            this.ttotal.ReadOnly = true;
            this.ttotal.Width = 80;
            // 
            // tresult
            // 
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            this.tresult.DefaultCellStyle = dataGridViewCellStyle12;
            this.tresult.HeaderText = "Результат";
            this.tresult.Name = "tresult";
            this.tresult.ReadOnly = true;
            this.tresult.Width = 107;
            // 
            // Coefficient
            // 
            dataGridViewCellStyle13.Format = "N4";
            dataGridViewCellStyle13.NullValue = null;
            this.Coefficient.DefaultCellStyle = dataGridViewCellStyle13;
            this.Coefficient.HeaderText = "Coefficient";
            this.Coefficient.Name = "Coefficient";
            this.Coefficient.ReadOnly = true;
            this.Coefficient.Visible = false;
            this.Coefficient.Width = 108;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.addRow,
            this.deleteRow,
            this.getResults,
            this.about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTSMI,
            this.open,
            this.save,
            this.saveAs,
            this.exit});
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(48, 20);
            this.file.Text = "Файл";
            // 
            // newTSMI
            // 
            this.newTSMI.Name = "newTSMI";
            this.newTSMI.Size = new System.Drawing.Size(162, 22);
            this.newTSMI.Text = "Новый";
            this.newTSMI.Click += new System.EventHandler(this.newTSMI_Click);
            // 
            // open
            // 
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(162, 22);
            this.open.Text = "Открыть";
            this.open.Click += new System.EventHandler(this.OpenTSMI_Click);
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(162, 22);
            this.save.Text = "Сохранить";
            this.save.Click += new System.EventHandler(this.SaveTSMI_Click);
            // 
            // saveAs
            // 
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(162, 22);
            this.saveAs.Text = "Сохранить как...";
            this.saveAs.Click += new System.EventHandler(this.SaveAsTSMI_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(162, 22);
            this.exit.Text = "Выход";
            this.exit.Click += new System.EventHandler(this.ExitTSMI_Click);
            // 
            // addRow
            // 
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(71, 20);
            this.addRow.Text = "Добавить";
            this.addRow.Click += new System.EventHandler(this.AddTSMI_Click);
            // 
            // deleteRow
            // 
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.Size = new System.Drawing.Size(63, 20);
            this.deleteRow.Text = "Удалить";
            this.deleteRow.Click += new System.EventHandler(this.DeleteTSMI_Click);
            // 
            // getResults
            // 
            this.getResults.Name = "getResults";
            this.getResults.Size = new System.Drawing.Size(130, 20);
            this.getResults.Text = "Расчитать результат";
            this.getResults.Click += new System.EventHandler(this.getResults_Click);
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(94, 20);
            this.about.Text = "О программе";
            this.about.Click += new System.EventHandler(this.AboutTSMI_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel (*.xls)|*.xls";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Excel (*.xls)|*.xls";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(884, 362);
            this.Controls.Add(this.table);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Таблица";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem open;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripMenuItem saveAs;
        private System.Windows.Forms.ToolStripMenuItem addRow;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.ToolStripMenuItem deleteRow;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem newTSMI;
        private System.Windows.Forms.ToolStripMenuItem getResults;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tname;
        private System.Windows.Forms.DataGridViewTextBoxColumn tweight;
        private System.Windows.Forms.DataGridViewTextBoxColumn squat1;
        private System.Windows.Forms.DataGridViewTextBoxColumn squat2;
        private System.Windows.Forms.DataGridViewTextBoxColumn squat3;
        private System.Windows.Forms.DataGridViewTextBoxColumn benchpress1;
        private System.Windows.Forms.DataGridViewTextBoxColumn benchpress2;
        private System.Windows.Forms.DataGridViewTextBoxColumn benchpress3;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadlift1;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadlift2;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadlift3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn tresult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coefficient;

    }
}

