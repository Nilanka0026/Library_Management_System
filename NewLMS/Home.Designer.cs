namespace NewLMS
{
    partial class Home
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            datagrid = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nme = new DataGridViewTextBoxColumn();
            NatID = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            dataGridViewl = new DataGridView();
            issueId = new DataGridViewTextBoxColumn();
            memid = new DataGridViewTextBoxColumn();
            bookId = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            duedate = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)datagrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewl).BeginInit();
            SuspendLayout();
            // 
            // datagrid
            // 
            datagrid.AllowUserToAddRows = false;
            datagrid.AllowUserToDeleteRows = false;
            datagrid.AllowUserToOrderColumns = true;
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
            datagrid.ColumnHeadersHeight = 29;
            datagrid.Columns.AddRange(new DataGridViewColumn[] { ID, Title, Author });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(219, 219, 219);
            dataGridViewCellStyle2.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(219, 219, 219);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            datagrid.DefaultCellStyle = dataGridViewCellStyle2;
            datagrid.Location = new Point(12, 609);
            datagrid.Name = "datagrid";
            datagrid.ReadOnly = true;
            datagrid.RowHeadersVisible = false;
            datagrid.RowHeadersWidth = 51;
            datagrid.Size = new Size(575, 161);
            datagrid.TabIndex = 2;
            datagrid.CellContentClick += datagrid_CellContentClick;
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(219, 219, 219);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, nme, NatID, City, Age, Gender });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(219, 219, 219);
            dataGridViewCellStyle3.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(219, 219, 219);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Location = new Point(12, 379);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1040, 184);
            dataGridView1.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nme
            // 
            nme.HeaderText = "Name";
            nme.MinimumWidth = 6;
            nme.Name = "nme";
            nme.ReadOnly = true;
            // 
            // NatID
            // 
            NatID.HeaderText = "National ID";
            NatID.MinimumWidth = 6;
            NatID.Name = "NatID";
            NatID.ReadOnly = true;
            // 
            // City
            // 
            City.HeaderText = "City";
            City.MinimumWidth = 6;
            City.Name = "City";
            City.ReadOnly = true;
            // 
            // Age
            // 
            Age.HeaderText = "Age";
            Age.MinimumWidth = 6;
            Age.Name = "Age";
            Age.ReadOnly = true;
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            // 
            // dataGridViewl
            // 
            dataGridViewl.AllowUserToAddRows = false;
            dataGridViewl.AllowUserToDeleteRows = false;
            dataGridViewl.AllowUserToResizeColumns = false;
            dataGridViewl.AllowUserToResizeRows = false;
            dataGridViewl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewl.BackgroundColor = Color.FromArgb(219, 219, 219);
            dataGridViewl.BorderStyle = BorderStyle.None;
            dataGridViewl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewl.ColumnHeadersHeight = 29;
            dataGridViewl.Columns.AddRange(new DataGridViewColumn[] { issueId, memid, bookId, date, duedate });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(219, 219, 219);
            dataGridViewCellStyle4.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(219, 219, 219);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewl.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewl.Location = new Point(12, 138);
            dataGridViewl.Name = "dataGridViewl";
            dataGridViewl.RowHeadersVisible = false;
            dataGridViewl.RowHeadersWidth = 51;
            dataGridViewl.Size = new Size(1040, 194);
            dataGridViewl.TabIndex = 15;
            // 
            // issueId
            // 
            issueId.HeaderText = "Issue ID";
            issueId.MinimumWidth = 6;
            issueId.Name = "issueId";
            // 
            // memid
            // 
            memid.HeaderText = "Member ID";
            memid.MinimumWidth = 6;
            memid.Name = "memid";
            // 
            // bookId
            // 
            bookId.HeaderText = "Book ID";
            bookId.MinimumWidth = 6;
            bookId.Name = "bookId";
            // 
            // date
            // 
            date.HeaderText = "Date";
            date.MinimumWidth = 6;
            date.Name = "date";
            // 
            // duedate
            // 
            duedate.HeaderText = "Due Date";
            duedate.MinimumWidth = 6;
            duedate.Name = "duedate";
            // 
            // label1
            // 
            label1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 95);
            label1.Name = "label1";
            label1.Size = new Size(321, 39);
            label1.TabIndex = 16;
            label1.Text = "Book Issuing Table";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 336);
            label2.Name = "label2";
            label2.Size = new Size(321, 39);
            label2.TabIndex = 17;
            label2.Text = "Members";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 567);
            label3.Name = "label3";
            label3.Size = new Size(321, 39);
            label3.TabIndex = 18;
            label3.Text = "Books";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(1040, 70);
            label4.TabIndex = 19;
            label4.Text = "DASHBOARD";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(219, 219, 219);
            ClientSize = new Size(1064, 792);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewl);
            Controls.Add(dataGridView1);
            Controls.Add(datagrid);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)datagrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewl).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView datagrid;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nme;
        private DataGridViewTextBoxColumn NatID;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Gender;
        private DataGridView dataGridViewl;
        private DataGridViewTextBoxColumn issueId;
        private DataGridViewTextBoxColumn memid;
        private DataGridViewTextBoxColumn bookId;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn duedate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}