namespace signUpPage
{
	partial class LogInpage
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
			linkLabel1 = new LinkLabel();
			emaillabel = new Label();
			emailTextBox = new TextBox();
			passwordTextBox = new TextBox();
			checkBox1 = new CheckBox();
			passwordlabel = new Label();
			loginbutton = new Button();
			label1 = new Label();
			SuspendLayout();
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			linkLabel1.Location = new Point(285, 439);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(101, 21);
			linkLabel1.TabIndex = 1;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Register now";
			linkLabel1.LinkClicked += linkLabel1_LinkClicked;
			// 
			// emaillabel
			// 
			emaillabel.AutoSize = true;
			emaillabel.Font = new Font("Lucida Bright", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			emaillabel.Location = new Point(137, 135);
			emaillabel.Name = "emaillabel";
			emaillabel.Size = new Size(120, 20);
			emaillabel.TabIndex = 2;
			emaillabel.Text = "Email Address";
			// 
			// emailTextBox
			// 
			emailTextBox.Location = new Point(87, 158);
			emailTextBox.Name = "emailTextBox";
			emailTextBox.Size = new Size(225, 31);
			emailTextBox.TabIndex = 3;
			// 
			// passwordTextBox
			// 
			passwordTextBox.Location = new Point(87, 299);
			passwordTextBox.Name = "passwordTextBox";
			passwordTextBox.Size = new Size(225, 31);
			passwordTextBox.TabIndex = 5;
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Font = new Font("Segoe Fluent Icons", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			checkBox1.Location = new Point(189, 336);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(123, 21);
			checkBox1.TabIndex = 6;
			checkBox1.Text = "Show Password";
			checkBox1.UseVisualStyleBackColor = true;
			checkBox1.CheckedChanged += checkBox1_CheckedChanged;
			// 
			// passwordlabel
			// 
			passwordlabel.AutoSize = true;
			passwordlabel.Font = new Font("Lucida Bright", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			passwordlabel.Location = new Point(152, 276);
			passwordlabel.Name = "passwordlabel";
			passwordlabel.Size = new Size(83, 20);
			passwordlabel.TabIndex = 7;
			passwordlabel.Text = "Password";
			// 
			// loginbutton
			// 
			loginbutton.Location = new Point(137, 421);
			loginbutton.Name = "loginbutton";
			loginbutton.Size = new Size(142, 44);
			loginbutton.TabIndex = 8;
			loginbutton.Text = "Log-in";
			loginbutton.UseVisualStyleBackColor = true;
			loginbutton.Click += loginbutton_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(135, 58);
			label1.Name = "label1";
			label1.Size = new Size(144, 38);
			label1.TabIndex = 9;
			label1.Text = "Welcome!";
			// 
			// LogInpage
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(421, 521);
			Controls.Add(label1);
			Controls.Add(loginbutton);
			Controls.Add(passwordlabel);
			Controls.Add(checkBox1);
			Controls.Add(passwordTextBox);
			Controls.Add(emailTextBox);
			Controls.Add(emaillabel);
			Controls.Add(linkLabel1);
			Name = "LogInpage";
			Text = "LogInpage";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private LinkLabel linkLabel1;
		private Label emaillabel;
		private TextBox emailTextBox;
		private TextBox passwordTextBox;
		private CheckBox checkBox1;
		private Label passwordlabel;
		private Button loginbutton;
		private Label label1;
	}
}