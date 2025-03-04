namespace NewLMS
{
    partial class ReturnBooks
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
            comboBox1 = new ComboBox();
            dataGridViewr = new DataGridView();
            issueId = new DataGridViewTextBoxColumn();
            memid = new DataGridViewTextBoxColumn();
            bookId = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            duedate = new DataGridViewTextBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewr).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(244, 165);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(195, 29);
            comboBox1.TabIndex = 0;
            // 
            // dataGridViewr
            // 
            dataGridViewr.AllowUserToAddRows = false;
            dataGridViewr.AllowUserToDeleteRows = false;
            dataGridViewr.AllowUserToResizeRows = false;
            dataGridViewr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewr.BackgroundColor = Color.FromArgb(219, 219, 219);
            dataGridViewr.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(231, 236, 239);
            dataGridViewCellStyle1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewr.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewr.Columns.AddRange(new DataGridViewColumn[] { issueId, memid, bookId, date, duedate });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(219, 219, 219);
            dataGridViewCellStyle2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(219, 219, 219);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewr.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewr.Location = new Point(12, 292);
            dataGridViewr.Name = "dataGridViewr";
            dataGridViewr.RowHeadersVisible = false;
            dataGridViewr.RowHeadersWidth = 51;
            dataGridViewr.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewr.Size = new Size(1040, 328);
            dataGridViewr.TabIndex = 6;
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
            // button1
            // 
            button1.BackColor = Color.FromArgb(56, 56, 56);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Black;
            button1.FlatAppearance.MouseOverBackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(458, 150);
            button1.Name = "button1";
            button1.Size = new Size(174, 44);
            button1.TabIndex = 7;
            button1.Text = "Returned";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(1040, 70);
            label7.TabIndex = 24;
            label7.Text = "RETURN BOOKS";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReturnBooks
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(219, 219, 219);
            ClientSize = new Size(1064, 792);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(dataGridViewr);
            Controls.Add(comboBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReturnBooks";
            Text = "ReturnBooks";
            ((System.ComponentModel.ISupportInitialize)dataGridViewr).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private DataGridView dataGridViewr;
        private DataGridViewTextBoxColumn issueId;
        private DataGridViewTextBoxColumn memid;
        private DataGridViewTextBoxColumn bookId;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn duedate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private Label label7;
    }
}