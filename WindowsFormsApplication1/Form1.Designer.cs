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
            this.succAttempt = new System.Windows.Forms.ToolStripMenuItem();
            this.failAttempt = new System.Windows.Forms.ToolStripMenuItem();
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
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.newFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileAs = new System.Windows.Forms.ToolStripMenuItem();
            this.addRow = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.getResults = new System.Windows.Forms.ToolStripMenuItem();
            this.categories = new System.Windows.Forms.ToolStripMenuItem();
            this.mensCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.m53 = new System.Windows.Forms.ToolStripMenuItem();
            this.m59 = new System.Windows.Forms.ToolStripMenuItem();
            this.m66 = new System.Windows.Forms.ToolStripMenuItem();
            this.m74 = new System.Windows.Forms.ToolStripMenuItem();
            this.m83 = new System.Windows.Forms.ToolStripMenuItem();
            this.m93 = new System.Windows.Forms.ToolStripMenuItem();
            this.m105 = new System.Windows.Forms.ToolStripMenuItem();
            this.m120 = new System.Windows.Forms.ToolStripMenuItem();
            this.m120p = new System.Windows.Forms.ToolStripMenuItem();
            this.womensCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.w43 = new System.Windows.Forms.ToolStripMenuItem();
            this.w47 = new System.Windows.Forms.ToolStripMenuItem();
            this.w52 = new System.Windows.Forms.ToolStripMenuItem();
            this.w57 = new System.Windows.Forms.ToolStripMenuItem();
            this.w63 = new System.Windows.Forms.ToolStripMenuItem();
            this.w72 = new System.Windows.Forms.ToolStripMenuItem();
            this.w84 = new System.Windows.Forms.ToolStripMenuItem();
            this.w84p = new System.Windows.Forms.ToolStripMenuItem();
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
            this.Coefficient,
            this.gender});
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
            this.table.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_Changed);
            this.table.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.table_Changed);
            this.table.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.table_Changed);
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
            this.succAttempt,
            this.failAttempt});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 48);
            // 
            // succAttempt
            // 
            this.succAttempt.Name = "succAttempt";
            this.succAttempt.Size = new System.Drawing.Size(141, 22);
            this.succAttempt.Text = "Засчитан";
            this.succAttempt.Click += new System.EventHandler(this.setSuccAttempt_Click);
            // 
            // failAttempt
            // 
            this.failAttempt.Name = "failAttempt";
            this.failAttempt.Size = new System.Drawing.Size(141, 22);
            this.failAttempt.Text = "Не засчитан";
            this.failAttempt.Click += new System.EventHandler(this.setFailAttempt_Click);
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
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.Visible = false;
            this.gender.Width = 85;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.addRow,
            this.deleteRow,
            this.getResults,
            this.categories,
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
            this.newFile,
            this.openFile,
            this.saveFile,
            this.saveFileAs});
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(48, 20);
            this.file.Text = "Файл";
            // 
            // newFile
            // 
            this.newFile.Name = "newFile";
            this.newFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newFile.Size = new System.Drawing.Size(234, 22);
            this.newFile.Text = "Новый";
            this.newFile.Click += new System.EventHandler(this.newFile_Click);
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            this.openFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFile.Size = new System.Drawing.Size(234, 22);
            this.openFile.Text = "Открыть";
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // saveFile
            // 
            this.saveFile.Enabled = false;
            this.saveFile.Name = "saveFile";
            this.saveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFile.Size = new System.Drawing.Size(234, 22);
            this.saveFile.Text = "Сохранить";
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // saveFileAs
            // 
            this.saveFileAs.Name = "saveFileAs";
            this.saveFileAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveFileAs.Size = new System.Drawing.Size(234, 22);
            this.saveFileAs.Text = "Сохранить как...";
            this.saveFileAs.Click += new System.EventHandler(this.saveFileAsTSMI_Click);
            // 
            // addRow
            // 
            this.addRow.Name = "addRow";
            this.addRow.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addRow.Size = new System.Drawing.Size(71, 20);
            this.addRow.Text = "Добавить";
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
            // 
            // deleteRow
            // 
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteRow.Size = new System.Drawing.Size(63, 20);
            this.deleteRow.Text = "Удалить";
            this.deleteRow.Click += new System.EventHandler(this.deleteRow_Click);
            // 
            // getResults
            // 
            this.getResults.Name = "getResults";
            this.getResults.Size = new System.Drawing.Size(130, 20);
            this.getResults.Text = "Расчитать результат";
            this.getResults.Click += new System.EventHandler(this.getResults_Click);
            // 
            // categories
            // 
            this.categories.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mensCategories,
            this.womensCategories});
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(76, 20);
            this.categories.Text = "Категории";
            // 
            // mensCategories
            // 
            this.mensCategories.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m53,
            this.m59,
            this.m66,
            this.m74,
            this.m83,
            this.m93,
            this.m105,
            this.m120,
            this.m120p});
            this.mensCategories.Name = "mensCategories";
            this.mensCategories.Size = new System.Drawing.Size(132, 22);
            this.mensCategories.Text = "Мужчины";
            // 
            // m53
            // 
            this.m53.Name = "m53";
            this.m53.Size = new System.Drawing.Size(100, 22);
            this.m53.Text = "53";
            this.m53.Click += new System.EventHandler(this.mensCat_Click);
            // 
            // m59
            // 
            this.m59.Name = "m59";
            this.m59.Size = new System.Drawing.Size(100, 22);
            this.m59.Text = "59";
            this.m59.Click += new System.EventHandler(this.mensCat_Click);
            // 
            // m66
            // 
            this.m66.Name = "m66";
            this.m66.Size = new System.Drawing.Size(100, 22);
            this.m66.Text = "66";
            this.m66.Click += new System.EventHandler(this.mensCat_Click);
            // 
            // m74
            // 
            this.m74.Name = "m74";
            this.m74.Size = new System.Drawing.Size(100, 22);
            this.m74.Text = "74";
            this.m74.Click += new System.EventHandler(this.mensCat_Click);
            // 
            // m83
            // 
            this.m83.Name = "m83";
            this.m83.Size = new System.Drawing.Size(100, 22);
            this.m83.Text = "83";
            this.m83.Click += new System.EventHandler(this.mensCat_Click);
            // 
            // m93
            // 
            this.m93.Name = "m93";
            this.m93.Size = new System.Drawing.Size(100, 22);
            this.m93.Text = "93";
            this.m93.Click += new System.EventHandler(this.mensCat_Click);
            // 
            // m105
            // 
            this.m105.Name = "m105";
            this.m105.Size = new System.Drawing.Size(100, 22);
            this.m105.Text = "105";
            this.m105.Click += new System.EventHandler(this.mensCat_Click);
            // 
            // m120
            // 
            this.m120.Name = "m120";
            this.m120.Size = new System.Drawing.Size(100, 22);
            this.m120.Text = "120";
            this.m120.Click += new System.EventHandler(this.mensCat_Click);
            // 
            // m120p
            // 
            this.m120p.Name = "m120p";
            this.m120p.Size = new System.Drawing.Size(100, 22);
            this.m120p.Text = "120+";
            this.m120p.Click += new System.EventHandler(this.mensCat_Click);
            // 
            // womensCategories
            // 
            this.womensCategories.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.w43,
            this.w47,
            this.w52,
            this.w57,
            this.w63,
            this.w72,
            this.w84,
            this.w84p});
            this.womensCategories.Name = "womensCategories";
            this.womensCategories.Size = new System.Drawing.Size(132, 22);
            this.womensCategories.Text = "Женщины";
            // 
            // w43
            // 
            this.w43.Name = "w43";
            this.w43.Size = new System.Drawing.Size(94, 22);
            this.w43.Text = "43";
            this.w43.Click += new System.EventHandler(this.womensCat_Click);
            // 
            // w47
            // 
            this.w47.Name = "w47";
            this.w47.Size = new System.Drawing.Size(94, 22);
            this.w47.Text = "47";
            this.w47.Click += new System.EventHandler(this.womensCat_Click);
            // 
            // w52
            // 
            this.w52.Name = "w52";
            this.w52.Size = new System.Drawing.Size(94, 22);
            this.w52.Text = "52";
            this.w52.Click += new System.EventHandler(this.womensCat_Click);
            // 
            // w57
            // 
            this.w57.Name = "w57";
            this.w57.Size = new System.Drawing.Size(94, 22);
            this.w57.Text = "57";
            this.w57.Click += new System.EventHandler(this.womensCat_Click);
            // 
            // w63
            // 
            this.w63.Name = "w63";
            this.w63.Size = new System.Drawing.Size(94, 22);
            this.w63.Text = "63";
            this.w63.Click += new System.EventHandler(this.womensCat_Click);
            // 
            // w72
            // 
            this.w72.Name = "w72";
            this.w72.Size = new System.Drawing.Size(94, 22);
            this.w72.Text = "72";
            this.w72.Click += new System.EventHandler(this.womensCat_Click);
            // 
            // w84
            // 
            this.w84.Name = "w84";
            this.w84.Size = new System.Drawing.Size(94, 22);
            this.w84.Text = "84";
            this.w84.Click += new System.EventHandler(this.womensCat_Click);
            // 
            // w84p
            // 
            this.w84p.Name = "w84p";
            this.w84p.Size = new System.Drawing.Size(94, 22);
            this.w84p.Text = "84+";
            this.w84p.Click += new System.EventHandler(this.womensCat_Click);
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(94, 20);
            this.about.Text = "О программе";
            this.about.Click += new System.EventHandler(this.about_Click);
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
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripMenuItem saveFile;
        private System.Windows.Forms.ToolStripMenuItem saveFileAs;
        private System.Windows.Forms.ToolStripMenuItem addRow;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.ToolStripMenuItem deleteRow;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem newFile;
        private System.Windows.Forms.ToolStripMenuItem getResults;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem succAttempt;
        private System.Windows.Forms.ToolStripMenuItem failAttempt;
        private System.Windows.Forms.ToolStripMenuItem categories;
        private System.Windows.Forms.ToolStripMenuItem mensCategories;
        private System.Windows.Forms.ToolStripMenuItem m53;
        private System.Windows.Forms.ToolStripMenuItem m59;
        private System.Windows.Forms.ToolStripMenuItem m66;
        private System.Windows.Forms.ToolStripMenuItem m74;
        private System.Windows.Forms.ToolStripMenuItem m83;
        private System.Windows.Forms.ToolStripMenuItem m93;
        private System.Windows.Forms.ToolStripMenuItem m105;
        private System.Windows.Forms.ToolStripMenuItem m120;
        private System.Windows.Forms.ToolStripMenuItem m120p;
        private System.Windows.Forms.ToolStripMenuItem womensCategories;
        private System.Windows.Forms.ToolStripMenuItem w43;
        private System.Windows.Forms.ToolStripMenuItem w47;
        private System.Windows.Forms.ToolStripMenuItem w52;
        private System.Windows.Forms.ToolStripMenuItem w57;
        private System.Windows.Forms.ToolStripMenuItem w63;
        private System.Windows.Forms.ToolStripMenuItem w72;
        private System.Windows.Forms.ToolStripMenuItem w84;
        private System.Windows.Forms.ToolStripMenuItem w84p;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;

    }
}

