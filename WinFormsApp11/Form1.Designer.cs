namespace WinFormsApp11
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            groupBox1 = new GroupBox();
            button2 = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            groupBox2 = new GroupBox();
            button5 = new Button();
            button3 = new Button();
            textBox4 = new TextBox();
            label8 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            dateTimePicker4 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            button4 = new Button();
            categoryBindingSource = new BindingSource(components);
            categoryBindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dRDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dPDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 182);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(415, 259);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавление данных";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button2
            // 
            button2.Location = new Point(166, 208);
            button2.Name = "button2";
            button2.Size = new Size(90, 29);
            button2.TabIndex = 8;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(166, 159);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(242, 29);
            dateTimePicker2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(166, 119);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(242, 29);
            dateTimePicker1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 165);
            label4.Name = "label4";
            label4.Size = new Size(168, 22);
            label4.TabIndex = 5;
            label4.Text = "Дата поступления";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 125);
            label3.Name = "label3";
            label3.Size = new Size(141, 22);
            label3.TabIndex = 4;
            label3.Text = "Дата рождения";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(166, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(242, 29);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 29);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 83);
            label2.Name = "label2";
            label2.Size = new Size(100, 22);
            label2.TabIndex = 1;
            label2.Text = "Номер з.к.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 37);
            label1.Name = "label1";
            label1.Size = new Size(56, 22);
            label1.TabIndex = 0;
            label1.Text = "ФИО";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(452, 198);
            button1.Name = "button1";
            button1.Size = new Size(136, 29);
            button1.TabIndex = 1;
            button1.Text = "Удалить строку";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(dateTimePicker4);
            groupBox2.Controls.Add(dateTimePicker3);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(452, 244);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(468, 197);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Фильтрация данных";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button5
            // 
            button5.Location = new Point(174, 161);
            button5.Name = "button5";
            button5.Size = new Size(100, 30);
            button5.TabIndex = 9;
            button5.Text = "Выход";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.Location = new Point(286, 114);
            button3.Name = "button3";
            button3.Size = new Size(158, 26);
            button3.TabIndex = 8;
            button3.Text = "Фильтровать";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(193, 115);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(60, 29);
            textBox4.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(163, 118);
            label8.Name = "label8";
            label8.Size = new Size(30, 22);
            label8.TabIndex = 6;
            label8.Text = "до";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(97, 115);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(60, 29);
            textBox3.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 118);
            label7.Name = "label7";
            label7.Size = new Size(93, 22);
            label7.TabIndex = 4;
            label7.Text = "Возраст с";
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(202, 68);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(242, 29);
            dateTimePicker4.TabIndex = 3;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(202, 29);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(242, 29);
            dateTimePicker3.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 74);
            label6.Name = "label6";
            label6.Size = new Size(153, 22);
            label6.TabIndex = 1;
            label6.Text = "Поступившие до";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 35);
            label5.Name = "label5";
            label5.Size = new Size(183, 22);
            label5.TabIndex = 0;
            label5.Text = "Поступившие после";
            // 
            // button4
            // 
            button4.Location = new Point(775, 198);
            button4.Name = "button4";
            button4.Size = new Size(145, 29);
            button4.TabIndex = 3;
            button4.Text = "Сброс фильтров";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Category);
            // 
            // categoryBindingSource1
            // 
            categoryBindingSource1.DataSource = typeof(Category);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, numberDataGridViewTextBoxColumn, dRDataGridViewTextBoxColumn, dPDataGridViewTextBoxColumn });
            dataGridView1.DataSource = categoryBindingSource;
            dataGridView1.Location = new Point(15, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(905, 151);
            dataGridView1.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            numberDataGridViewTextBoxColumn.HeaderText = "Number";
            numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            numberDataGridViewTextBoxColumn.Width = 125;
            // 
            // dRDataGridViewTextBoxColumn
            // 
            dRDataGridViewTextBoxColumn.DataPropertyName = "DR";
            dRDataGridViewTextBoxColumn.HeaderText = "DR";
            dRDataGridViewTextBoxColumn.MinimumWidth = 6;
            dRDataGridViewTextBoxColumn.Name = "dRDataGridViewTextBoxColumn";
            dRDataGridViewTextBoxColumn.Width = 125;
            // 
            // dPDataGridViewTextBoxColumn
            // 
            dPDataGridViewTextBoxColumn.DataPropertyName = "DP";
            dPDataGridViewTextBoxColumn.HeaderText = "DP";
            dPDataGridViewTextBoxColumn.MinimumWidth = 6;
            dPDataGridViewTextBoxColumn.Name = "dPDataGridViewTextBoxColumn";
            dPDataGridViewTextBoxColumn.Width = 125;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 471);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Students";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private Button button1;
        private GroupBox groupBox2;
        private Button button2;
        private Button button3;
        private Label label8;
        private Label label7;
        private DateTimePicker dateTimePicker4;
        private DateTimePicker dateTimePicker3;
        private Label label6;
        private Label label5;
        private Button button4;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private BindingSource categoryBindingSource;
        private BindingSource categoryBindingSource1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dRDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dPDataGridViewTextBoxColumn;
        private Button button5;
        public TextBox textBox4;
        public TextBox textBox3;
    }
}
