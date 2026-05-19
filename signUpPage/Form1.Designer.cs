namespace signUpPage
{
	partial class signupPage
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
			nameTextBox = new TextBox();
			registerbutton = new Button();
			comboBoxSex = new ComboBox();
			namelabel = new Label();
			label5 = new Label();
			label6 = new Label();
			emailTextBox = new TextBox();
			label8 = new Label();
			label10 = new Label();
			passwordTextBox = new TextBox();
			errorProvider1 = new ErrorProvider(components);
			label2 = new Label();
			checkBoxShowPassword = new CheckBox();
			dateTimePicker1 = new DateTimePicker();
			loginlinkButton = new LinkLabel();
			birthdateTextBox = new TextBox();
			label3 = new Label();
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			SuspendLayout();
			// 
			// nameTextBox
			// 
			nameTextBox.BackColor = SystemColors.Menu;
			nameTextBox.Location = new Point(46, 143);
			nameTextBox.Name = "nameTextBox";
			nameTextBox.Size = new Size(281, 31);
			nameTextBox.TabIndex = 0;
			// 
			// registerbutton
			// 
			registerbutton.BackColor = Color.RosyBrown;
			registerbutton.Font = new Font("Berlin Sans FB Demi", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			registerbutton.Location = new Point(373, 351);
			registerbutton.Margin = new Padding(2);
			registerbutton.Name = "registerbutton";
			registerbutton.Size = new Size(139, 43);
			registerbutton.TabIndex = 4;
			registerbutton.Text = "Register";
			registerbutton.UseVisualStyleBackColor = false;
			registerbutton.Click += registerbutton_Click;
			// 
			// comboBoxSex
			// 
			comboBoxSex.DisplayMember = "Male ";
			comboBoxSex.FormattingEnabled = true;
			comboBoxSex.Items.AddRange(new object[] { "Male", "Female" });
			comboBoxSex.Location = new Point(389, 232);
			comboBoxSex.Name = "comboBoxSex";
			comboBoxSex.Size = new Size(146, 33);
			comboBoxSex.TabIndex = 8;
			comboBoxSex.Text = "Please Select";
			comboBoxSex.ValueMember = "Male ";
			// 
			// namelabel
			// 
			namelabel.AutoSize = true;
			namelabel.Location = new Point(46, 115);
			namelabel.Name = "namelabel";
			namelabel.Size = new Size(91, 25);
			namelabel.TabIndex = 10;
			namelabel.Text = "Full Name";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Showcard Gothic", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
			label5.Location = new Point(46, 10);
			label5.Name = "label5";
			label5.Size = new Size(503, 60);
			label5.TabIndex = 14;
			label5.Text = "PRO-TRACK SIGN-UP";
			label5.Click += label5_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(46, 204);
			label6.Name = "label6";
			label6.Size = new Size(124, 25);
			label6.TabIndex = 15;
			label6.Text = "Email Address";
			// 
			// emailTextBox
			// 
			emailTextBox.BackColor = SystemColors.Menu;
			emailTextBox.Location = new Point(46, 232);
			emailTextBox.Name = "emailTextBox";
			emailTextBox.PlaceholderText = "keneth@gmail.com";
			emailTextBox.Size = new Size(239, 31);
			emailTextBox.TabIndex = 16;
			emailTextBox.Validating += emailTextBox_Validating;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(389, 204);
			label8.Name = "label8";
			label8.Size = new Size(39, 25);
			label8.TabIndex = 19;
			label8.Text = "Sex";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(46, 286);
			label10.Name = "label10";
			label10.Size = new Size(132, 25);
			label10.TabIndex = 21;
			label10.Text = "Enter Password";
			// 
			// passwordTextBox
			// 
			passwordTextBox.BackColor = SystemColors.Menu;
			passwordTextBox.Location = new Point(46, 314);
			passwordTextBox.Name = "passwordTextBox";
			passwordTextBox.PasswordChar = '*';
			passwordTextBox.Size = new Size(239, 31);
			passwordTextBox.TabIndex = 24;
			passwordTextBox.Validating += passwordTextBox_Validating;
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(389, 115);
			label2.Name = "label2";
			label2.Size = new Size(112, 25);
			label2.TabIndex = 27;
			label2.Text = "Date of Birth";
			// 
			// checkBoxShowPassword
			// 
			checkBoxShowPassword.AutoSize = true;
			checkBoxShowPassword.Location = new Point(164, 351);
			checkBoxShowPassword.Name = "checkBoxShowPassword";
			checkBoxShowPassword.Size = new Size(146, 31);
			checkBoxShowPassword.TabIndex = 29;
			checkBoxShowPassword.Text = "Show Passord";
			checkBoxShowPassword.UseCompatibleTextRendering = true;
			checkBoxShowPassword.UseVisualStyleBackColor = true;
			checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
			checkBoxShowPassword.TextChanged += checkBoxShowPassword_CheckedChanged;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(518, 143);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(31, 31);
			dateTimePicker1.TabIndex = 30;
			dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
			// 
			// loginlinkButton
			// 
			loginlinkButton.AutoSize = true;
			loginlinkButton.Location = new Point(518, 369);
			loginlinkButton.Name = "loginlinkButton";
			loginlinkButton.Size = new Size(63, 25);
			loginlinkButton.TabIndex = 31;
			loginlinkButton.TabStop = true;
			loginlinkButton.Text = "Log-in";
			loginlinkButton.LinkClicked += loginlinkButton_LinkClicked;
			// 
			// birthdateTextBox
			// 
			birthdateTextBox.Location = new Point(387, 143);
			birthdateTextBox.Name = "birthdateTextBox";
			birthdateTextBox.PlaceholderText = "dd/mm/yy";
			birthdateTextBox.Size = new Size(125, 31);
			birthdateTextBox.TabIndex = 32;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(389, 286);
			label3.Name = "label3";
			label3.Size = new Size(0, 25);
			label3.TabIndex = 33;
			// 
			// signupPage
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Info;
			ClientSize = new Size(614, 453);
			Controls.Add(label3);
			Controls.Add(birthdateTextBox);
			Controls.Add(loginlinkButton);
			Controls.Add(dateTimePicker1);
			Controls.Add(checkBoxShowPassword);
			Controls.Add(label2);
			Controls.Add(passwordTextBox);
			Controls.Add(label10);
			Controls.Add(label8);
			Controls.Add(emailTextBox);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(namelabel);
			Controls.Add(comboBoxSex);
			Controls.Add(registerbutton);
			Controls.Add(nameTextBox);
			MaximizeBox = false;
			Name = "signupPage";
			Padding = new Padding(10);
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox nameTextBox;
		private Button registerbutton;
		private ComboBox comboBoxSex;
		private Label namelabel;
		private Label label5;
		private Label label6;
		private TextBox emailTextBox;
		private Label label8;
		private Label label10;
		private TextBox passwordTextBox;
		private ErrorProvider errorProvider1;
		private Label label2;
		private CheckBox checkBoxShowPassword;
		private DateTimePicker dateTimePicker1;
		private TextBox birthdateTextBox;
		private LinkLabel loginlinkButton;
		private Label label3;
	}
}
