namespace NewLMS
{
    partial class Managebooks
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            txttitle = new TextBox();
            txtauthor = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            datagrid = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            sortbtn = new Button();
            button4 = new Button();
            time1 = new Label();
            time2 = new Label();
            ((System.ComponentModel.ISupportInitialize)datagrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(219, 219, 219);
            label1.Font = new Font("Arial Rounded MT Bold", 12F);
            label1.Location = new Point(12, 468);
            label1.Name = "label1";
            label1.Size = new Size(103, 36);
            label1.TabIndex = 0;
            label1.Text = "Title";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(219, 219, 219);
            label2.Font = new Font("Arial Rounded MT Bold", 12F);
            label2.Location = new Point(12, 525);
            label2.Name = "label2";
            label2.Size = new Size(103, 36);
            label2.TabIndex = 1;
            label2.Text = "Author";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txttitle
            // 
            txttitle.Location = new Point(133, 468);
            txttitle.Multiline = true;
            txttitle.Name = "txttitle";
            txttitle.Size = new Size(333, 36);
            txttitle.TabIndex = 2;
            // 
            // txtauthor
            // 
            txtauthor.Location = new Point(133, 525);
            txtauthor.Multiline = true;
            txtauthor.Name = "txtauthor";
            txtauthor.Size = new Size(333, 36);
            txtauthor.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(56, 56, 56);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Black;
            button1.FlatAppearance.MouseOverBackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(485, 468);
            button1.Name = "button1";
            button1.Size = new Size(140, 36);
            button1.TabIndex = 4;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(56, 56, 56);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Black;
            button2.FlatAppearance.MouseOverBackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(485, 525);
            button2.Name = "button2";
            button2.Size = new Size(140, 36);
            button2.TabIndex = 5;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(56, 56, 56);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.Red;
            button3.FlatAppearance.MouseDownBackColor = Color.Black;
            button3.FlatAppearance.MouseOverBackColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(813, 527);
            button3.Name = "button3";
            button3.Size = new Size(130, 36);
            button3.TabIndex = 7;
            button3.Text = "Remove";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // datagrid
            // 
            datagrid.AllowUserToAddRows = false;
            datagrid.AllowUserToDeleteRows = false;
            datagrid.AllowUserToResizeColumns = false;
            datagrid.AllowUserToResizeRows = false;
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid.BackgroundColor = Color.FromArgb(219, 219, 219);
            datagrid.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(231, 236, 239);
            dataGridViewCellStyle1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrid.Columns.AddRange(new DataGridViewColumn[] { ID, Title, Author });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(219, 219, 219);
            dataGridViewCellStyle2.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(219, 219, 219);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            datagrid.DefaultCellStyle = dataGridViewCellStyle2;
            datagrid.Location = new Point(12, 156);
            datagrid.Name = "datagrid";
            datagrid.ReadOnly = true;
            datagrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(231, 236, 239);
            dataGridViewCellStyle3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            datagrid.RowHeadersVisible = false;
            datagrid.RowHeadersWidth = 51;
            datagrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            datagrid.Size = new Size(1040, 248);
            datagrid.TabIndex = 8;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // Author
            // 
            Author.HeaderText = "Author";
            Author.MinimumWidth = 6;
            Author.Name = "Author";
            Author.ReadOnly = true;
            // 
            // comboBox1
            // 
            comboBox1.Location = new Point(680, 532);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(118, 29);
            comboBox1.TabIndex = 9;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(219, 219, 219);
            label4.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(1040, 70);
            label4.TabIndex = 20;
            label4.Text = "MANAGE BOOKS";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(680, 468);
            label3.Name = "label3";
            label3.Size = new Size(282, 36);
            label3.TabIndex = 21;
            label3.Text = "Select Book ID to Remove book";
            // 
            // sortbtn
            // 
            sortbtn.BackColor = Color.FromArgb(56, 56, 56);
            sortbtn.Cursor = Cursors.Hand;
            sortbtn.FlatAppearance.BorderSize = 0;
            sortbtn.FlatAppearance.MouseDownBackColor = Color.Black;
            sortbtn.FlatAppearance.MouseOverBackColor = Color.Black;
            sortbtn.FlatStyle = FlatStyle.Flat;
            sortbtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sortbtn.ForeColor = SystemColors.Control;
            sortbtn.Location = new Point(680, 590);
            sortbtn.Name = "sortbtn";
            sortbtn.Size = new Size(209, 47);
            sortbtn.TabIndex = 22;
            sortbtn.Text = "Sort (Ascending)";
            sortbtn.UseVisualStyleBackColor = false;
            sortbtn.Click += sortbtn_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(56, 56, 56);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Black;
            button4.FlatAppearance.MouseOverBackColor = Color.Black;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(680, 643);
            button4.Name = "button4";
            button4.Size = new Size(209, 47);
            button4.TabIndex = 23;
            button4.Text = "Sort (descending)";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // time1
            // 
            time1.BackColor = Color.FromArgb(219, 219, 219);
            time1.Location = new Point(448, 602);
            time1.Name = "time1";
            time1.Size = new Size(188, 35);
            time1.TabIndex = 24;
            time1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // time2
            // 
            time2.BackColor = Color.FromArgb(219, 219, 219);
            time2.Location = new Point(448, 655);
            time2.Name = "time2";
            time2.Size = new Size(188, 35);
            time2.TabIndex = 25;
            time2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Managebooks
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(219, 219, 219);
            ClientSize = new Size(1064, 792);
            Controls.Add(time2);
            Controls.Add(time1);
            Controls.Add(button4);
            Controls.Add(sortbtn);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(datagrid);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtauthor);
            Controls.Add(txttitle);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Managebooks";
            Text = "Managebooks";
            ((System.ComponentModel.ISupportInitialize)datagrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txttitle;
        private TextBox txtauthor;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView datagrid;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private ComboBox comboBox1;
        private Label label4;
        private Label label3;
        private Button sortbtn;
        private Button button4;
        private Label time1;
        private Label time2;
    }
}