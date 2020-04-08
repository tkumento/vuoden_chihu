/*
 * Created by SharpDevelop.
 * User: Tuomo
 * Date: 29/08/2014
 * Time: 20:08
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
	/// Description of AddBreederShow.
	/// </summary>
	public partial class AddBreederShow : Form
	{
		
		public string rop;
		public string kp2;
		public string kp3;
		public string kp4;
		public int coat = 0;
		public int dog_count = 0;
		public string show_name;
		public bool modify_operation;
				
		public AddBreederShow(bool modify, int current_coat, string current_show)
		{

			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			coatBox.Text = "0";
			coatBox.SelectedIndex = 0;		
			modify_operation = modify;
			
			populate(modify, current_coat, current_show);
		}
		
		void populate(bool modify, int current_coat, string current_show)
		{
			string sql;
			SQLiteCommand command;
			SQLiteConnection m_dbConnection;
			m_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
			m_dbConnection.Open();

			ropBox.Items.Clear();
			kp2Box.Items.Clear();
			kp3Box.Items.Clear();
			kp4Box.Items.Clear();
			
			sql = "select distinct breeder from dogs where dogcoat = @dog_coat order by breeder";

			command = new SQLiteCommand(sql, m_dbConnection);
			command.Parameters.AddWithValue("@dog_coat", coat);
			
			SQLiteDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				//MessageBox.Show("Breeder: " + reader["breeder"]);
				ropBox.Items.Add(reader["breeder"]);
				kp2Box.Items.Add(reader["breeder"]);
				kp3Box.Items.Add(reader["breeder"]);
				kp4Box.Items.Add(reader["breeder"]);
			}
			if(modify == true)
			{
				//TODO: prefill
				this.Text = "Update mode";
				addButton.Hide();
				updateButton.Show();
				sql = "select * from breeder where coat = @coat AND show = @show";
				command = new SQLiteCommand(sql, m_dbConnection);
				command.Parameters.AddWithValue("@coat", current_coat);
				command.Parameters.AddWithValue("@show", current_show);
				reader = command.ExecuteReader();
				while (reader.Read())
				{
					coatBox.SelectedIndex = current_coat;
					coat = current_coat;
					if(current_coat == 0)
					{
						coatBox.Text = "LK";
					}
					else
					{
						coatBox.Text = "PK";
					}
					showBox.Text = current_show;
					show_name = current_show;
					
					var temp_dog_count = reader["count"];
					var temp_rop = reader["rop_breeder"];
					var temp_breeder2 = reader["breeder2"];
					var temp_breeder3 = reader["breeder3"];
					var temp_breeder4 = reader["breeder4"];
					
					rop = temp_rop.ToString();
					kp2 = temp_breeder2.ToString();
					kp3 = temp_breeder3.ToString();
					kp4 = temp_breeder4.ToString();
		
					dogCountBox.Text = temp_dog_count.ToString();
					dog_count = Convert.ToInt32(temp_dog_count);
					ropBox.Text = rop;
					kp2Box.Text = kp2;
					kp3Box.Text = kp3;
					kp4Box.Text = kp4;

				}
			}
			m_dbConnection.Close();
		}
		
		void CoatBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			string sql;
			SQLiteCommand command;
		
		SQLiteConnection m_dbConnection;
		coat = coatBox.SelectedIndex;	
			m_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
			m_dbConnection.Open();

			ropBox.Items.Clear();
			kp2Box.Items.Clear();
			kp3Box.Items.Clear();
			kp4Box.Items.Clear();
			
			sql = "select distinct breeder from dogs where dogcoat = @dog_coat order by breeder";

			command = new SQLiteCommand(sql, m_dbConnection);
			command.Parameters.AddWithValue("@dog_coat", coat);
			
			SQLiteDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				//MessageBox.Show("Breeder: " + reader["breeder"]);
				ropBox.Items.Add(reader["breeder"]);
				kp2Box.Items.Add(reader["breeder"]);
				kp3Box.Items.Add(reader["breeder"]);
				kp4Box.Items.Add(reader["breeder"]);
			}
			m_dbConnection.Close();				
		}
		
		void ShowBoxTextChanged(object sender, EventArgs e)
		{
			show_name = showBox.Text;
		}
		
		void DogCountBoxTextChanged(object sender, EventArgs e)
		{
			try
			{
			dog_count = Convert.ToInt32(dogCountBox.Text);
			}
			catch (Exception crap)
			{
			dog_count = 0;
			var _ = crap;
			}				
		}
		
		void RopBoxSelectedIndexChanged(object sender, EventArgs e)
		{
		rop = ropBox.Text;			
		}
		
		void Kp2BoxSelectedIndexChanged(object sender, EventArgs e)
		{
		kp2 = kp2Box.Text;			
		}
		
		void Kp3BoxSelectedIndexChanged(object sender, EventArgs e)
		{
			kp3 = kp3Box.Text;
		}
		
		void Kp4BoxSelectedIndexChanged(object sender, EventArgs e)
		{
			kp4 = kp4Box.Text;
		}
		
		void CloseButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void AddButtonClick(object sender, EventArgs e)
		{
			//sql = "create table if not exists breeder (coat INT, show VARCHAR(30), rop_breeder VARCHAR(30), breeder2 VARCHAR(30), breeder3 VARCHAR(30), breeder4 VARCHAR(30), count )";
			SQLiteConnection m_dbConnection;
			m_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
			m_dbConnection.Open();

            string sql;
            SQLiteCommand command;
		sql = "insert into breeder (coat, show, rop_breeder, breeder2, breeder3, breeder4, count)" +
			"values ( @dog_coat, @show, @rop, @kp2, @kp3, @kp4, @count)";
		command = new SQLiteCommand(sql, m_dbConnection);
		command.Parameters.AddWithValue("@dog_coat", coat);
		command.Parameters.AddWithValue("@show", show_name);
		command.Parameters.AddWithValue("@count", dog_count);
		command.Parameters.AddWithValue("@rop", rop);
		command.Parameters.AddWithValue("@kp2", kp2);
		command.Parameters.AddWithValue("@kp3", kp3);
		command.Parameters.AddWithValue("@kp4", kp4);
		command.ExecuteNonQuery();

		m_dbConnection.Close();   
		MessageBox.Show("Added");						
		}
		
		void UpdateButtonClick(object sender, EventArgs e)
		{
			SQLiteConnection m_dbConnection;
			m_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
			m_dbConnection.Open();

			string sql;
			SQLiteCommand command;

			if(kp2 == "")
			{
				kp2 = null;
			}
			if(kp3 == "")
			{
				kp3 = null;
			}
			if(kp4 == "")
			{
				kp4 = null;
			}
								
			sql = "UPDATE breeder SET rop_breeder = @rop, breeder2 = @kp2, breeder3 = @kp3, breeder4 = @kp4, count = @dog_count where coat = @coat and show = @show";
			command = new SQLiteCommand(sql, m_dbConnection);
			command.Parameters.AddWithValue("@coat", coat);
			command.Parameters.AddWithValue("@show", show_name);
			command.Parameters.AddWithValue("@dog_count", dog_count);
			command.Parameters.AddWithValue("@rop", rop);
			command.Parameters.AddWithValue("@kp2", kp2);
			command.Parameters.AddWithValue("@kp3", kp3);
			command.Parameters.AddWithValue("@kp4", kp4);
			command.ExecuteNonQuery();

			m_dbConnection.Close();
			MessageBox.Show("Updated");
		}
		
	}
}
