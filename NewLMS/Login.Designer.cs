namespace NewLMS
{
    partial class Login
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
            panel2 = new Panel();
            password = new TextBox();
            username = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(password);
            panel2.Controls.Add(username);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(785, 794);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // password
            // 
            password.Location = new Point(373, 293);
            password.Name = "password";
            password.Size = new Size(250, 29);
            password.TabIndex = 4;
            password.UseSystemPasswordChar = true;
            // 
            // username
            // 
            username.Location = new Point(373, 215);
            username.Name = "username";
            username.Size = new Size(250, 29);
            username.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(161, 294);
            label2.Name = "label2";
            label2.Size = new Size(158, 33);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(161, 216);
            label1.Name = "label1";
            label1.Size = new Size(158, 33);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(310, 404);
            button1.Name = "button1";
            button1.Size = new Size(164, 60);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 794);
            Controls.Add(panel2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button button1;
        private Label label1;
        private TextBox password;
        private TextBox username;
        private Label label2;
    }
}