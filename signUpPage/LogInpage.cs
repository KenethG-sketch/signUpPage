using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
//using SportsTrack_FINAL;

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
			// Toggles password visibility between characters and dots
			passwordTextBox.PasswordChar = checkBox1.Checked ? '\0' : '*';
		}

		private void loginbutton_Click(object sender, EventArgs e)
		{
			// 1. Grab values from your input boxes and trim email to prevent trailing spaces
			string email = emailTextBox.Text.Trim();
			string password = passwordTextBox.Text;

			// Standard way to look for the file inside the bin/Debug folder
			string filepath = Path.Combine(Application.StartupPath, "usersdata.txt");

			// NOTE: If you are using the Desktop path version from the signup step, uncomment the line below:
			// string filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "usersdata.txt");

			if (!File.Exists(filepath))
			{
				MessageBox.Show("User data file not found. Please sign up first!", "Account Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string[] allUsers = File.ReadAllLines(filepath);
			bool isLoginSuccess = false;

			// 2. Loop through and check credentials against the text file
			foreach (string userLine in allUsers)
			{
				if (string.IsNullOrWhiteSpace(userLine)) continue; // Skips empty lines safely

				string[] data = userLine.Split(',');

				// FIXED: Check for length 4 since your data is: Name(0), Sex(1), Email(2), Password(3)
				if (data.Length >= 4)
				{
					// FIXED: Corrected index alignment to target exact positions
					string storedEmail = data[2].Trim();
					string storedPassword = data[3].Trim();

					// Uses case-insensitive comparison for emails so 'User@Test.com' matches 'user@test.com'
					if (email.Equals(storedEmail, StringComparison.OrdinalIgnoreCase) && password == storedPassword)
					{
						isLoginSuccess = true;
						break;
					}
				}
			}

			// 3. Handle the login status and transition to the Roster Management Form
			if (isLoginSuccess)
			{
				MessageBox.Show("Login Successful! Opening Roster Management...", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

				// Hide this login form from view
				this.Hide();

				// Instantiate and load your main Roster Management dashboard form
				//SportsTrack mainDashboard = new SportsTrack();

				//// ShowDialog opens the roster and stalls background threads right here
				//mainDashboard.ShowDialog();

				//// Cleanly kills the hidden login window and shuts down the app process once the dashboard is closed
				//this.Close();
			}
			else
			{
				MessageBox.Show("Invalid Email or Password! Please try again.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			// Redirects user back to the sign-up form
			signupPage signup = new signupPage();
			signup.Show();
			this.Hide();
		}
	}
}