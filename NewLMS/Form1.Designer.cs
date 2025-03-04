namespace NewLMS
{
    partial class main
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
            leftpanel = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            mainpanel = new Panel();
            leftpanel.SuspendLayout();
            SuspendLayout();
            // 
            // leftpanel
            // 
            leftpanel.BackColor = Color.FromArgb(56, 56, 56);
            leftpanel.Controls.Add(button6);
            leftpanel.Controls.Add(button5);
            leftpanel.Controls.Add(button4);
            leftpanel.Controls.Add(button3);
            leftpanel.Controls.Add(button2);
            leftpanel.Controls.Add(button1);
            leftpanel.Dock = DockStyle.Left;
            leftpanel.Location = new Point(0, 0);
            leftpanel.Name = "leftpanel";
            leftpanel.Size = new Size(292, 843);
            leftpanel.TabIndex = 0;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.Black;
            button6.FlatAppearance.MouseOverBackColor = Color.Black;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(19, 185);
            button6.Name = "button6";
            button6.Size = new Size(253, 63);
            button6.TabIndex = 5;
            button6.Text = "Dashboard";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.MouseDownBackColor = Color.Black;
            button5.FlatAppearance.MouseOverBackColor = Color.Black;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(19, 724);
            button5.Name = "button5";
            button5.Size = new Size(253, 63);
            button5.TabIndex = 4;
            button5.Text = "LogOut";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Black;
            button4.FlatAppearance.MouseOverBackColor = Color.Black;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Rounded MT Bold", 12F);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(19, 545);
            button4.Name = "button4";
            button4.Size = new Size(253, 63);
            button4.TabIndex = 3;
            button4.Text = "Return Books";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Black;
            button3.FlatAppearance.MouseOverBackColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Rounded MT Bold", 12F);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(19, 455);
            button3.Name = "button3";
            button3.Size = new Size(253, 63);
            button3.TabIndex = 2;
            button3.Text = "Lend Books";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Black;
            button2.FlatAppearance.MouseOverBackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 12F);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(19, 365);
            button2.Name = "button2";
            button2.Size = new Size(253, 63);
            button2.TabIndex = 1;
            button2.Text = "Manage Members";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Black;
            button1.FlatAppearance.MouseOverBackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 12F);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(19, 275);
            button1.Name = "button1";
            button1.Size = new Size(253, 63);
            button1.TabIndex = 0;
            button1.Text = "Manage Books";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // mainpanel
            // 
            mainpanel.BackColor = Color.FromArgb(219, 219, 219);
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(292, 0);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1086, 843);
            mainpanel.TabIndex = 1;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 843);
            Controls.Add(mainpanel);
            Controls.Add(leftpanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LMS";
            leftpanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel leftpanel;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel mainpanel;
        private Button button6;
    }
}
