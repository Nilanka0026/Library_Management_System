namespace NewLMS
{
    partial class ManageMembers
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtname = new TextBox();
            txtage = new TextBox();
            txtid = new TextBox();
            txtcity = new TextBox();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nme = new DataGridViewTextBoxColumn();
            NatID = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            cmbmemlist = new ComboBox();
            button3 = new Button();
            label6 = new Label();
            label7 = new Label();
            button4 = new Button();
            sortbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(219, 219, 219);
            label1.Font = new Font("Arial Rounded MT Bold", 12F);
            label1.Location = new Point(12, 115);
            label1.Name = "label1";
            label1.Size = new Size(228, 39);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(219, 219, 219);
            label2.Font = new Font("Arial Rounded MT Bold", 12F);
            label2.Location = new Point(12, 173);
            label2.Name = "label2";
            label2.Size = new Size(228, 39);
            label2.TabIndex = 1;
            label2.Text = "City";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(219, 219, 219);
            label3.Font = new Font("Arial Rounded MT Bold", 12F);
            label3.Location = new Point(12, 233);
            label3.Name = "label3";
            label3.Size = new Size(228, 39);
            label3.TabIndex = 2;
            label3.Text = "National ID";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(219, 219, 219);
            label4.Font = new Font("Arial Rounded MT Bold", 12F);
            label4.Location = new Point(12, 295);
            label4.Name = "label4";
            label4.Size = new Size(228, 39);
            label4.TabIndex = 3;
            label4.Text = "Age";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(219, 219, 219);
            label5.Font = new Font("Arial Rounded MT Bold", 12F);
            label5.Location = new Point(12, 354);
            label5.Name = "label5";
            label5.Size = new Size(228, 39);
            label5.TabIndex = 4;
            label5.Text = "Gender";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtname
            // 
            txtname.Font = new Font("Arial", 10.8F);
            txtname.Location = new Point(309, 115);
            txtname.Multiline = true;
            txtname.Name = "txtname";
            txtname.Size = new Size(301, 39);
            txtname.TabIndex = 5;
            // 
            // txtage
            // 
            txtage.Font = new Font("Arial", 10.8F);
            txtage.Location = new Point(309, 295);
            txtage.Multiline = true;
            txtage.Name = "txtage";
            txtage.Size = new Size(301, 39);
            txtage.TabIndex = 6;
            // 
            // txtid
            // 
            txtid.Font = new Font("Arial", 10.8F);
            txtid.Location = new Point(309, 233);
            txtid.Multiline = true;
            txtid.Name = "txtid";
            txtid.Size = new Size(301, 39);
            txtid.TabIndex = 7;
            txtid.Text = "ID";
            // 
            // txtcity
            // 
            txtcity.Font = new Font("Arial", 10.8F);
            txtcity.Location = new Point(309, 173);
            txtcity.Multiline = true;
            txtcity.Name = "txtcity";
            txtcity.Size = new Size(301, 39);
            txtcity.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(56, 56, 56);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Black;
            button1.FlatAppearance.MouseOverBackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 10.2F);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(637, 115);
            button1.Name = "button1";
            button1.Size = new Size(145, 44);
            button1.TabIndex = 10;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(56, 56, 56);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Black;
            button2.FlatAppearance.MouseOverBackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 10.2F);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(637, 194);
            button2.Name = "button2";
            button2.Size = new Size(145, 44);
            button2.TabIndex = 11;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(309, 360);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(112, 29);
            comboBox1.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(219, 219, 219);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(231, 236, 239);
            dataGridViewCellStyle1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, nme, NatID, City, Age, Gender });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(219, 219, 219);
            dataGridViewCellStyle2.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(219, 219, 219);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(12, 423);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(1040, 308);
            dataGridView1.TabIndex = 13;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
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
            // cmbmemlist
            // 
            cmbmemlist.FormattingEnabled = true;
            cmbmemlist.Location = new Point(858, 194);
            cmbmemlist.Name = "cmbmemlist";
            cmbmemlist.Size = new Size(145, 29);
            cmbmemlist.TabIndex = 14;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(56, 56, 56);
            button3.FlatAppearance.BorderColor = Color.Red;
            button3.FlatAppearance.MouseDownBackColor = Color.Black;
            button3.FlatAppearance.MouseOverBackColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(858, 255);
            button3.Name = "button3";
            button3.Size = new Size(145, 40);
            button3.TabIndex = 15;
            button3.Text = "Remove";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(858, 115);
            label6.Name = "label6";
            label6.Size = new Size(194, 75);
            label6.TabIndex = 22;
            label6.Text = "Select a Member to Remove";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(1040, 70);
            label7.TabIndex = 23;
            label7.Text = "MANAGE MEMBERS";
            label7.TextAlign = ContentAlignment.MiddleCenter;
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
            button4.Location = new Point(637, 317);
            button4.Name = "button4";
            button4.Size = new Size(178, 47);
            button4.TabIndex = 25;
            button4.Text = "Sort (descending)";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
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
            sortbtn.Location = new Point(637, 255);
            sortbtn.Name = "sortbtn";
            sortbtn.Size = new Size(178, 47);
            sortbtn.TabIndex = 24;
            sortbtn.Text = "Sort (Ascending)";
            sortbtn.UseVisualStyleBackColor = false;
            sortbtn.Click += sortbtn_Click;
            // 
            // ManageMembers
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(219, 219, 219);
            ClientSize = new Size(1064, 792);
            Controls.Add(button4);
            Controls.Add(sortbtn);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(cmbmemlist);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtcity);
            Controls.Add(txtid);
            Controls.Add(txtage);
            Controls.Add(txtname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageMembers";
            Text = "ManageMembers";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtname;
        private TextBox txtage;
        private TextBox txtid;
        private TextBox txtcity;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nme;
        private DataGridViewTextBoxColumn NatID;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Gender;
        private ComboBox cmbmemlist;
        private Button button3;
        private Label label6;
        private Label label7;
        private Button button4;
        private Button sortbtn;
    }
}