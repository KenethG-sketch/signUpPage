using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace signUpPage
{
	public partial class LogInpage : Form
	{
		public LogInpage()
		{
			InitializeComponent();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				passwordTextBox.PasswordChar = '\0';
			}
			else
			{
				passwordTextBox.PasswordChar = '*';
			}
		}

		private void loginbutton_Click(object sender, EventArgs e)
		{
			string email = emailTextBox.Text;
			string password = passwordTextBox.Text;

			string filepath = Application.StartupPath + "\\usersdata.txt";

			if (!File.Exists(filepath))
			{
				MessageBox.Show("User not found.");
				return;
			}
			string[] user = File.ReadAllLines(filepath);
			bool isLoginSuccess = false;

			foreach (string users in user)
			{
				string[] data = users.Split(',');

				if (data.Length >= 5)
				{
					string storedEmail = data[3].Trim();
					string storedPassword = data[4].Trim();

					if (email == storedEmail && password == storedPassword)
					{
						isLoginSuccess = true;
						break;
					}
				}
			}

			if (isLoginSuccess)
			{
				MessageBox.Show("Login Successful!");

				//mainForm main = new mainForm();
				//main.Show();

				//this.Hide();
			}
			else
			{
				MessageBox.Show("Invalid Email or Password!");
			}

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			signupPage signup = new signupPage();
			signup.Show();
			this.Hide();
		}
	}
}

