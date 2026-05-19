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

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxShowPassword.Checked)
			{
				passwordTextBox.PasswordChar = '\0';
			}
			else
			{
				passwordTextBox.PasswordChar = '*';
			}
		}


		private void registerbutton_Click(object sender, EventArgs e)
		{
			if (!ValidateChildren())
			{
				MessageBox.Show("Please fix validation errors first!");
				return;
			}

			string name = nameTextBox.Text;
			string sex = comboBoxSex.Text;
			string birthdate = dateTimePicker1.Value.ToShortDateString();
			string email = emailTextBox.Text;
			string password = passwordTextBox.Text;

			if (string.IsNullOrWhiteSpace(name) ||
				string.IsNullOrWhiteSpace(sex) ||
				string.IsNullOrWhiteSpace(email) ||
				string.IsNullOrWhiteSpace(password))
			{
				MessageBox.Show("Fill-up all fields");
				return;
			}

			string filepath = Application.StartupPath + "\\usersdata.txt";

			string data = name + ", " + sex + ", " + birthdate + ", " + email + ", " + password;

			File.AppendAllText(filepath, data + Environment.NewLine);

			MessageBox.Show("Registered Successfully!");
			ClearForm();
		}


		private bool isValiEmail(string email)
		{
			if (string.IsNullOrWhiteSpace(email))
			{
				return false;
			}
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
			if (!isValiEmail(emailTextBox.Text))
			{
				errorProvider1.SetError(emailTextBox, "Email is required.");
				e.Cancel = true;
			}
			else if (!isValiEmail(emailTextBox.Text))
			{
				errorProvider1.SetError(emailTextBox, "Email is in worng format. Fix it.");
				e.Cancel = true;
			}
			else
			{
				errorProvider1.SetError(emailTextBox, "");
			}
		}

		//private bool isValidPassword(string password)
		//{
		//	if (string.IsNullOrWhiteSpace(password))
		//		return false;

		//	if (password.Length < 8)
		//		return false;

		//	return true;
		//}

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
				errorProvider1.SetError(passwordTextBox, "");
			}
		}
		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			birthdateTextBox.Text = dateTimePicker1.Value.ToShortDateString();
		}

		private void ClearForm()
		{
			nameTextBox.Clear();
			emailTextBox.Clear();
			passwordTextBox.Clear();
			birthdateTextBox.Clear();
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