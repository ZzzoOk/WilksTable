namespace WilksTable
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gender = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.squat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.benchPress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.deadlift = new System.Windows.Forms.TextBox();
            this.team = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gender
            // 
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Мужчина",
            "Женщина"});
            this.gender.Location = new System.Drawing.Point(75, 12);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(164, 27);
            this.gender.TabIndex = 6;
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Location = new System.Drawing.Point(75, 78);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(164, 27);
            this.name.TabIndex = 0;
            this.name.TextChanged += new System.EventHandler(this.checkEmpty);
            // 
            // weight
            // 
            this.weight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weight.Location = new System.Drawing.Point(75, 111);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(164, 27);
            this.weight.TabIndex = 1;
            this.weight.TextChanged += new System.EventHandler(this.checkEmpty);
            this.weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkPressedKey);
            // 
            // squat
            // 
            this.squat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.squat.Location = new System.Drawing.Point(75, 144);
            this.squat.Name = "squat";
            this.squat.Size = new System.Drawing.Size(164, 27);
            this.squat.TabIndex = 2;
            this.squat.TextChanged += new System.EventHandler(this.checkEmpty);
            this.squat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkPressedKey);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(12, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Пол:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Вес:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Прис:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Жим:";
            // 
            // benchPress
            // 
            this.benchPress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.benchPress.Location = new System.Drawing.Point(75, 177);
            this.benchPress.Name = "benchPress";
            this.benchPress.Size = new System.Drawing.Size(164, 27);
            this.benchPress.TabIndex = 3;
            this.benchPress.TextChanged += new System.EventHandler(this.checkEmpty);
            this.benchPress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkPressedKey);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Тяга:";
            // 
            // deadlift
            // 
            this.deadlift.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deadlift.Location = new System.Drawing.Point(75, 210);
            this.deadlift.Name = "deadlift";
            this.deadlift.Size = new System.Drawing.Size(164, 27);
            this.deadlift.TabIndex = 4;
            this.deadlift.TextChanged += new System.EventHandler(this.checkEmpty);
            this.deadlift.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkPressedKey);
            // 
            // team
            // 
            this.team.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.team.FormattingEnabled = true;
            this.team.Location = new System.Drawing.Point(75, 45);
            this.team.Name = "team";
            this.team.Size = new System.Drawing.Size(164, 27);
            this.team.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "К-да:";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(0, 0);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(251, 286);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.team);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deadlift);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.benchPress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.squat);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.name);
            this.Controls.Add(this.gender);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новый участник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.TextBox squat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox benchPress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox deadlift;
        private System.Windows.Forms.ComboBox team;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}