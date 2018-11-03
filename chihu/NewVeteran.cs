/*
 * Created by SharpDevelop.
 * User: Tuomo
 * Date: 23/08/2014
 * Time: 17:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace chihu
{
	/// <summary>
	/// Description of NewVeteran.
	/// </summary>
	public partial class NewVeteran : Form
	{
		string breeder_name;
		string dog_name;
		int dog_coat_id = 0;
		public bool modify_operation;
		int dog_id;
		
		public NewVeteran(bool modify, string current_name)
		{
		
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			modify_operation = modify;
			populate(modify, current_name);

		}
		
		void populate(bool modify, string current_name)
		{
			string sql;
			SQLiteCommand command;
			coatBox.Text = "LK";
			coatBox.SelectedIndex = 0;
			dog_coat_id = coatBox.SelectedIndex;		

			SQLiteConnection m_dbConnection;
			m_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
			m_dbConnection.Open();
			breederBox.Items.Clear();
			sql = "select distinct breeder from veteran order by breeder";
			command = new SQLiteCommand(sql, m_dbConnection);
			SQLiteDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				//MessageBox.Show("Breeder: " + reader["breeder"]);
				breederBox.Items.Add(reader["breeder"]);
			}
			if(modify == true)
			{
				doneButton.Hide();
				updateButton.Show();
				this.Text = "Update mode";
				sql = "select * from veteran where name = @name";
				command = new SQLiteCommand(sql, m_dbConnection);
				command.Parameters.AddWithValue("@name", current_name);
				reader = command.ExecuteReader();
				while (reader.Read())
				{
					var temp_id = reader["id"];
					var temp_dogcoat = reader["dogcoat"];
					var temp_breeder = reader["breeder"];
					var temp_name = reader["name"];
					
					dog_id = Convert.ToInt32(temp_id);
					dog_coat_id = Convert.ToInt32(temp_dogcoat);
					
					breeder_name = temp_breeder.ToString();
					string trim_name = temp_name.ToString();
					if(breeder_name != "")
					{
						dog_name = trim_name.Remove(0, breeder_name.Length + 1);
					}
					else
					{
						dog_name = trim_name;
					}
					coatBox.SelectedIndex = dog_coat_id;
					if(dog_coat_id == 0)
					{
						coatBox.Text = "LK";
					}
					else
					{
						coatBox.Text = "PK";
					}
					breederBox.Text = breeder_name;
					dogBox.Text = dog_name;
				}
			}
			m_dbConnection.Close();
		}
		void CoatBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			dog_coat_id = coatBox.SelectedIndex;
		}
		
		void BreederBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			breeder_name = breederBox.Text;	
		}
		
		void DogBoxTextChanged(object sender, EventArgs e)
		{
			dog_name = dogBox.Text;
		}
		

		void CloseButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void DoneButtonClick(object sender, EventArgs e)
		{
			string sql;
			SQLiteCommand command;
			SQLiteConnection m_dbConnection;
			m_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");

			m_dbConnection.Open();

			sql = "select count(*) from veteran where dogcoat = @coat_id AND name = @dog_name";
			command = new SQLiteCommand(sql, m_dbConnection);
			if(breeder_name.Equals(""))
			{
				command.Parameters.AddWithValue("@dog_name", dog_name);
			}
			else
			{
				command.Parameters.AddWithValue("@dog_name", breeder_name + " " + dog_name);
			}
			command.Parameters.AddWithValue("@coat_id", dog_coat_id);
			int count = Convert.ToInt32(command.ExecuteScalar());

			if(count == 0)
			{
				sql = "insert into veteran (dogcoat, breeder, name) values ( @coat_id, @breeder_name, @dog_name)";
				command = new SQLiteCommand(sql, m_dbConnection);
				command.Parameters.AddWithValue("@breeder_name", breeder_name);
				if(breeder_name.Equals(""))
				{
					command.Parameters.AddWithValue("@dog_name", dog_name);
				}
				else
				{
					command.Parameters.AddWithValue("@dog_name", breeder_name + " " + dog_name);
				}
				command.Parameters.AddWithValue("@coat_id", dog_coat_id);
				command.ExecuteNonQuery();
				MessageBox.Show("Added!");
			}
			else
			{
				MessageBox.Show("Exists already!");
			}

			m_dbConnection.Close();
		}
		
		void UpdateButtonClick(object sender, EventArgs e)
		{
			SQLiteConnection m_dbConnection;
			m_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
			m_dbConnection.Open();

			string sql;
			SQLiteCommand command;

			sql = "UPDATE veteran SET dogcoat = @dog_coat, breeder = @breeder_name, name = @dog_name where id = @dog_id";
			command = new SQLiteCommand(sql, m_dbConnection);

			command.Parameters.AddWithValue("@dog_coat", dog_coat_id);
			command.Parameters.AddWithValue("@dog_id", dog_id);
			if(breeder_name.Equals(""))
			{
				command.Parameters.AddWithValue("@breeder_name", null);
				command.Parameters.AddWithValue("@dog_name", dog_name);
			}
			else
			{
				command.Parameters.AddWithValue("@breeder_name", breeder_name);
				command.Parameters.AddWithValue("@dog_name", breeder_name + " " + dog_name);
			}

			command.ExecuteNonQuery();

			m_dbConnection.Close();
			MessageBox.Show("Updated");
		}
	}
}
