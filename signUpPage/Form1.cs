using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace signUpPage
{
	public partial class signupPage : Form
	{
		public signupPage()
		{
			InitializeComponent();
		}

		private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
		{
			// Toggles password visibility cleanly
			passwordTextBox.PasswordChar = checkBoxShowPassword.Checked ? '\0' : '*';
		}

		private void registerbutton_Click(object sender, EventArgs e)
		{

			// 1. Check if GUI validations are blocking the save
			if (!ValidateChildren())
			{
				MessageBox.Show("Please fix the red error icons on the form first!", "Validation Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string name = nameTextBox.Text.Trim();
			string sex = comboBoxSex.Text;
			string email = emailTextBox.Text.Trim();
			string password = passwordTextBox.Text;

			// 2. Check if any fields are empty
			if (string.IsNullOrWhiteSpace(name) ||
				string.IsNullOrWhiteSpace(sex) ||
				string.IsNullOrWhiteSpace(email) ||
				string.IsNullOrWhiteSpace(password))
			{
				MessageBox.Show("Fill-up all fields before registering.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// 3. ALTERNATIVE PATH: Saves directly to your Windows Desktop so you can see it instantly!
			string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			string filepath = Path.Combine(desktopPath, "usersdata.txt");

			string data = $"{name}, {sex}, {email}, {password}";

			try
			{
				// 4. Write to the file
				File.AppendAllText(filepath, data + Environment.NewLine);

				// 5. Success Message showing exactly where it went
				MessageBox.Show($"Registered Successfully!\nFile saved to your Desktop:\n{filepath}", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

				// Redirect to Login
				LogInpage login = new LogInpage();
				login.Show();
				this.Hide();

				ClearForm();
			}
			catch (Exception ex)
			{
				// Tells you exactly if Windows is blocking the file write (e.g., permission issues)
				MessageBox.Show($"File error: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool IsValidEmail(string email)
		{
			if (string.IsNullOrWhiteSpace(email)) return false;
			try
			{
				var emailAddress = new MailAddress(email);
				return true;
			}
			catch
			{
				return false;
			}
		}

		private void emailTextBox_Validating(object sender, CancelEventArgs e)
		{
			// If the field is totally empty
			if (string.IsNullOrWhiteSpace(emailTextBox.Text))
			{
				errorProvider1.SetError(emailTextBox, "Email is required.");
				e.Cancel = true; // Blocks the form from submitting
			}
			// If they typed something, but it's missing an @ or .com
			else if (!IsValidEmail(emailTextBox.Text))
			{
				errorProvider1.SetError(emailTextBox, "Email is in a wrong format. Fix it.");
				e.Cancel = true; // Blocks the form from submitting
			}
			// If everything is completely fine
			else
			{
				errorProvider1.SetError(emailTextBox, ""); // Clears the error icon
			}
		}

		private void passwordTextBox_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
			{
				errorProvider1.SetError(passwordTextBox, "Password is required.");
				e.Cancel = true;
			}
			else if (passwordTextBox.Text.Length < 8)
			{
				errorProvider1.SetError(passwordTextBox, "Password must be at least 8 characters.");
				e.Cancel = true;
			}
			else
			{
				errorProvider1.SetError(passwordTextBox, ""); // Clears error
			}
		}

		private void ClearForm()
		{
			nameTextBox.Clear();
			emailTextBox.Clear();
			passwordTextBox.Clear();
			comboBoxSex.SelectedIndex = -1;
			checkBoxShowPassword.Checked = false;
		}

		private void loginlinkButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			LogInpage login = new LogInpage();
			login.Show();
			this.Hide();
		}

	}
}