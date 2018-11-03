/*
 * Created by SharpDevelop.
 * User: Tuomo
 * Date: 23/08/2014
 * Time: 15:17
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
	/// Description of AddPuppy.
	/// </summary>
	public partial class AddPuppy : Form
	{
		public int return_id{get;set;}
		public string return_name{get;set;}
		public string return_value;
		public int dog_coat_id;
		public string breeder_name;
		public string dog_name;
		
		
		public AddPuppy()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void CoatBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			string sql;
			SQLiteCommand command;
			dog_coat_id = coatBox.SelectedIndex;

			SQLiteConnection m_dbConnection;
			m_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
			m_dbConnection.Open();
			breederBox.Items.Clear();
			sql = "select distinct breeder from puppy where dogcoat = @dog_coat order by breeder";
			command = new SQLiteCommand(sql, m_dbConnection);
			command.Parameters.AddWithValue("@dog_coat", dog_coat_id);
			SQLiteDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				//MessageBox.Show("Breeder: " + reader["breeder"]);
				breederBox.Items.Add(reader["breeder"]);
			}
			m_dbConnection.Close();
		}
		
		void BreederBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			string sql;
			SQLiteCommand command;
			breeder_name = breederBox.Text;
			
			SQLiteConnection m_dbConnection;
			m_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
			m_dbConnection.Open();
			dogBox.Items.Clear();
			sql = "select name from puppy where breeder = @breeder_name AND dogcoat = @dog_coat order by name";
			command = new SQLiteCommand(sql, m_dbConnection);
			command.Parameters.AddWithValue("@breeder_name", breeder_name);
			command.Parameters.AddWithValue("@dog_coat", dog_coat_id);
			SQLiteDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				//MessageBox.Show("name: " + reader["name"]);
				dogBox.Items.Add(reader["name"]);
			}
			m_dbConnection.Close();
			dogBox.Text = breederBox.Text + " ";
		}
		
		void DogBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			string sql;
			SQLiteCommand command;
			dog_name = dogBox.Text;

			SQLiteConnection m_dbConnection;
			m_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
			m_dbConnection.Open();
			sql = "select id from puppy where name = @dog_name AND dogcoat = @dog_coat";
			command = new SQLiteCommand(sql, m_dbConnection);
			command.Parameters.AddWithValue("@dog_name", dog_name);
			command.Parameters.AddWithValue("@dog_coat", dog_coat_id);
			SQLiteDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				this.return_id = Convert.ToInt32(reader["id"]);
				this.return_name = dog_name;
			}
			m_dbConnection.Close();
		}
		
		void DoneButtonClick(object sender, EventArgs e)
		{
			this.Close();			
		}
	}
}
