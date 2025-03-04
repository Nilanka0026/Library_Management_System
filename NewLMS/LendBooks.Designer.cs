namespace NewLMS
{
    partial class LendBooks
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
            comboBoxb = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBoxm = new ComboBox();
            button1 = new Button();
            dataGridViewl = new DataGridView();
            issueId = new DataGridViewTextBoxColumn();
            memid = new DataGridViewTextBoxColumn();
            bookId = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            duedate = new DataGridViewTextBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewl).BeginInit();
            SuspendLayout();
            // 
            // comboBoxb
            // 
            comboBoxb.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxb.FormattingEnabled = true;
            comboBoxb.Location = new Point(12, 202);
            comboBoxb.Name = "comboBoxb";
            comboBoxb.Size = new Size(274, 28);
            comboBoxb.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(219, 219, 219);
            label1.Font = new Font("Arial Rounded MT Bold", 12F);
            label1.Location = new Point(12, 160);
            label1.Name = "label1";
            label1.Size = new Size(274, 39);
            label1.TabIndex = 1;
            label1.Text = "Book ID";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(219, 219, 219);
            label2.Font = new Font("Arial Rounded MT Bold", 12F);
            label2.Location = new Point(345, 160);
            label2.Name = "label2";
            label2.Size = new Size(274, 39);
            label2.TabIndex = 2;
            label2.Text = "Member ID";
            // 
            // comboBoxm
            // 
            comboBoxm.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxm.FormattingEnabled = true;
            comboBoxm.Location = new Point(345, 202);
            comboBoxm.Name = "comboBoxm";
            comboBoxm.Size = new Size(274, 28);
            comboBoxm.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(56, 56, 56);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Black;
            button1.FlatAppearance.MouseOverBackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(663, 202);
            button1.Name = "button1";
            button1.Size = new Size(182, 44);
            button1.TabIndex = 4;
            button1.Text = "Lend";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridViewl
            // 
            dataGridViewl.AllowUserToAddRows = false;
            dataGridViewl.AllowUserToDeleteRows = false;
            dataGridViewl.AllowUserToResizeRows = false;
            dataGridViewl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewl.BackgroundColor = Color.FromArgb(219, 219, 219);
            dataGridViewl.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(231, 236, 239);
            dataGridViewCellStyle1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewl.Columns.AddRange(new DataGridViewColumn[] { issueId, memid, bookId, date, duedate });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(219, 219, 219);
            dataGridViewCellStyle2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(219, 219, 219);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewl.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewl.Location = new Point(12, 397);
            dataGridViewl.Name = "dataGridViewl";
            dataGridViewl.RowHeadersVisible = false;
            dataGridViewl.RowHeadersWidth = 51;
            dataGridViewl.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewl.Size = new Size(1040, 328);
            dataGridViewl.TabIndex = 5;
            // 
            // issueId
            // 
            issueId.HeaderText = "Issue ID";
            issueId.MinimumWidth = 6;
            issueId.Name = "issueId";
            issueId.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // memid
            // 
            memid.HeaderText = "Member ID";
            memid.MinimumWidth = 6;
            memid.Name = "memid";
            memid.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // bookId
            // 
            bookId.HeaderText = "Book ID";
            bookId.MinimumWidth = 6;
            bookId.Name = "bookId";
            bookId.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // date
            // 
            date.HeaderText = "Date";
            date.MinimumWidth = 6;
            date.Name = "date";
            date.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // duedate
            // 
            duedate.HeaderText = "Due Date";
            duedate.MinimumWidth = 6;
            duedate.Name = "duedate";
            duedate.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.DropDownAlign = LeftRightAlignment.Right;
            dateTimePicker1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(12, 270);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(337, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(219, 219, 219);
            label4.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(1040, 70);
            label4.TabIndex = 21;
            label4.Text = "LEND BOOKS";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LendBooks
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(219, 219, 219);
            ClientSize = new Size(1064, 792);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridViewl);
            Controls.Add(button1);
            Controls.Add(comboBoxm);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxb);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LendBooks";
            Text = "LendBooks";
            ((System.ComponentModel.ISupportInitialize)dataGridViewl).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxb;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxm;
        private Button button1;
        private DataGridView dataGridViewl;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private DataGridViewTextBoxColumn issueId;
        private DataGridViewTextBoxColumn memid;
        private DataGridViewTextBoxColumn bookId;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn duedate;
    }
}