namespace DOANCSHARP
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            panel1 = new Panel();
            label2 = new Label();
            textBox3 = new TextBox();
            linkLabel2 = new LinkLabel();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            button2 = new Button();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel3 = new Panel();
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(412, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(437, 616);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(159, 415);
            label2.Name = "label2";
            label2.Size = new Size(138, 21);
            label2.TabIndex = 4;
            label2.Text = "OR SIGNUP WITH ";
            label2.Click += label2_Click;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(60, 188);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(330, 31);
            textBox3.TabIndex = 13;
            textBox3.Text = "Your Email";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.ForeColor = Color.Black;
            linkLabel2.Location = new Point(293, 504);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(61, 25);
            linkLabel2.TabIndex = 12;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Log in";
            linkLabel2.VisitedLinkColor = Color.Navy;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(96, 507);
            label3.Name = "label3";
            label3.Size = new Size(191, 30);
            label3.TabIndex = 11;
            label3.Text = "Already have an account ? ";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = Color.Black;
            linkLabel1.LinkColor = Color.Blue;
            linkLabel1.Location = new Point(179, 290);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(117, 25);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "service policy";
            linkLabel1.UseMnemonic = false;
            linkLabel1.VisitedLinkColor = Color.Blue;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 0, 192);
            button2.ForeColor = Color.White;
            button2.Location = new Point(51, 339);
            button2.Name = "button2";
            button2.Size = new Size(348, 50);
            button2.TabIndex = 9;
            button2.Text = "Sign up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.Gray;
            checkBox1.Location = new Point(60, 292);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(131, 25);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "I agree to the ";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(60, 236);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(330, 31);
            textBox2.TabIndex = 5;
            textBox2.Text = "Your Password";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(60, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 31);
            textBox1.TabIndex = 0;
            textBox1.Text = "Your Full Name";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.ForeColor = Color.Silver;
            panel3.Location = new Point(76, 424);
            panel3.Name = "panel3";
            panel3.Size = new Size(295, 3);
            panel3.TabIndex = 3;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.google;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(209, 451);
            button1.Name = "button1";
            button1.Size = new Size(30, 34);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(107, 76);
            label1.Name = "label1";
            label1.Size = new Size(259, 38);
            label1.TabIndex = 0;
            label1.Text = "Create Account";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(412, 616);
            panel2.TabIndex = 2;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 616);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Signup";
            Text = "Signup";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private LinkLabel linkLabel2;
        private Label label3;
        private LinkLabel linkLabel1;
        private Button button2;
        private CheckBox checkBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Panel panel3;
        private Button button1;
        private Label label1;
        private Panel panel2;
        private TextBox textBox3;
    }
}