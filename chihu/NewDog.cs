/*
 * Created by SharpDevelop.
 * User: Tuomo
 * Date: 23/08/2014
 * Time: 17:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace chihu
{
	/// <summary>
	/// Description of NewDog.
	/// </summary>
	public partial class NewDog : Form
	{
		string sire;
		string dam;
		string breeder_name;
		string name;
		int sire_coat_id;
		int dam_coat_id;
		int dog_coat_id;
		int dog_id;
		public bool modify_operation;
		public struct parent_list
		{
			public int coat;
			public string name;
		}
		
		public List<parent_list> Parents;
		
		public NewDog(bool modify, string current_name)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			Parents = new List<parent_list>();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			//dog_id = current_id;
			modify_operation = modify;
			dog_coat_id = 0;
			coatBox.SelectedIndex = 0;
			coatBox.Text = "LK";
			populate_parents(modify, current_name);
		}
		

		
		
		void populate_parents(bool modify, string current_name)
		{
			string sql;
			SQLiteCommand command;
			parent_list parent;
			SQLiteConnection m_dbConnection;
			m_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
			m_dbConnection.Open();

			sql = "select * from dogs group by sire";
			//sql = "select distinct sire from dogs order by sire";
			command = new SQLiteCommand(sql, m_dbConnection);
			SQLiteDataReader reader = command.ExecuteReader();
			while (reader.Read())
				{
				var temp_sire = reader["sire"];
				var temp_sire_coat = reader["sirecoat"];
				var temp_id = reader["id"];
				parent = new parent_list();
				parent.name = temp_sire.ToString();
				parent.coat = Convert.ToInt32(temp_sire_coat);
				Parents.Add(parent);
       			sireBox.Items.Add(temp_sire);
				}

			sql = "select * from dogs group by dam";
			command = new SQLiteCommand(sql, m_dbConnection);
			reader = command.ExecuteReader();
			while (reader.Read())
				{
				//damBox.Items.Add(reader["dam"]);
				var temp_dam = reader["dam"];
				var temp_dam_coat = reader["damcoat"];
				var temp_id = reader["id"];
				parent = new parent_list();
				parent.name = temp_dam.ToString();
				parent.coat = Convert.ToInt32(temp_dam_coat);
				Parents.Add(parent);
       			damBox.Items.Add(temp_dam);
				}
			
			sql = "select distinct breeder from dogs order by breeder";
			command = new SQLiteCommand(sql, m_dbConnection);
			reader = command.ExecuteReader();
			while (reader.Read())
				{
				breederBox.Items.Add(reader["breeder"]);
				}
			
			if(modify == true)
			{
				doneButton.Hide();
				updateButton.Show();
				sql = "select * from dogs where name = @name";
				command = new SQLiteCommand(sql, m_dbConnection);
				command.Parameters.AddWithValue("@name", current_name);
				reader = command.ExecuteReader();
				while (reader.Read())
				{
					var temp_id = reader["id"];
					var temp_dogcoat = reader["dogcoat"];
					var temp_breeder = reader["breeder"];
					var temp_name = reader["name"];
					var temp_reverse_order = reader["reverse_order"];
					var temp_sire = reader["sire"];
					var temp_dam = reader["dam"];
					var temp_sirecoat = reader["sirecoat"];
					var temp_damcoat = reader["damcoat"];
					
					if(temp_reverse_order.Equals(1))
					{
					    reverseOrderBox.Checked = true;
					}
					else
					{
						reverseOrderBox.Checked = false;
					}
					
					dog_id = Convert.ToInt32(temp_id);
					dog_coat_id = Convert.ToInt32(temp_dogcoat);
					breeder_name = temp_breeder.ToString();
					string trim_name = temp_name.ToString();
					if(breeder_name != "")
					{
						name = trim_name.Remove(0, breeder_name.Length + 1);
					}
					else
					{
						name = trim_name;
					}
					sire = temp_sire.ToString();
					dam = temp_dam.ToString();
					sire_coat_id = Convert.ToInt32(temp_sirecoat);
					dam_coat_id = Convert.ToInt32(temp_damcoat);
					sireBox.Text = sire;
					damBox.Text = dam;
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
					dogBox.Text = name;
					
				}
			}
			m_dbConnection.Close();
		
		}
		void CloseButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void SireBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			parent_list result;
			int index = Parents.FindIndex(parent_list=>parent_list.name == sireBox.Text);
			result = Parents.Find(parent_list=>parent_list.name == sireBox.Text);
			if(index != -1)
			{
				sireCoatBox.SelectedIndex = result.coat;
				sire_coat_id = result.coat;
				if(sire_coat_id == 0)
					{
					sireCoatBox.Text = "LK";
					}
				else if(sire_coat_id == 1)
					{
					sireCoatBox.Text = "PK";
					}
			}
			sire = sireBox.Text;

		}
		
		void DamBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			parent_list result;
			int index = Parents.FindIndex(parent_list=>parent_list.name == damBox.Text);
			result = Parents.Find(parent_list=>parent_list.name == damBox.Text);
			if(index != -1)
			{
				damCoatBox.SelectedIndex = result.coat;
				dam_coat_id = result.coat;
				if(dam_coat_id == 0)
					{
					damCoatBox.Text = "LK";
					}
				else if(dam_coat_id == 1)
					{
					damCoatBox.Text = "PK";
					}
			}
			dam = damBox.Text;

		}
		
		void DoneButtonClick(object sender, EventArgs e)
		{
			string sql;
			SQLiteCommand command;
			
			bool reverse;
			
			reverse = reverseOrderBox.Checked;
				
			SQLiteConnection mm_dbConnection;
			mm_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");

			mm_dbConnection.Open();

			sql = "select count(*) from dogs where dogcoat = @coat_id AND name = @dog_name";
			command = new SQLiteCommand(sql, mm_dbConnection);
			if(breeder_name.Equals(""))
			{
				command.Parameters.AddWithValue("@dog_name", name);
			}
			else
			{
				command.Parameters.AddWithValue("@dog_name", breeder_name + " " + name);
			}
			command.Parameters.AddWithValue("@coat_id", dog_coat_id);
			int count = Convert.ToInt32(command.ExecuteScalar());
			mm_dbConnection.Close();

			mm_dbConnection.Open();
			if(count == 0)
			{
				
				sql = "insert into dogs (dogcoat, breeder, name, reverse_order, sire, dam, sirecoat, damcoat) values ( @dog_coat, @breeder_name, @dog_name, @reverse, @sire_name, @dam_name, @sire_coat_id, @dam_coat_id)";
				//sql = "insert into dogs (dogcoat, breeder, name, sire, dam, sirecoat, damcoat) values ( 0, breeder, dog_name, sire_name, dam_name, 0, 0)";
				command = new SQLiteCommand(sql, mm_dbConnection);

				command.Parameters.AddWithValue("@dog_coat", dog_coat_id);

				if(breeder_name.Equals(""))
				{
					command.Parameters.AddWithValue("@breeder_name", null);
					command.Parameters.AddWithValue("@dog_name", name);
				}
				else
				
				{
					command.Parameters.AddWithValue("@breeder_name", breeder_name);
					command.Parameters.AddWithValue("@dog_name", breeder_name + " " + name);
				}

				command.Parameters.AddWithValue("@reverse", reverse);
				command.Parameters.AddWithValue("@sire_name", sire);
				command.Parameters.AddWithValue("@dam_name", dam);
				command.Parameters.AddWithValue("@sire_coat_id", sire_coat_id);
				command.Parameters.AddWithValue("@dam_coat_id", dam_coat_id);

				command.ExecuteNonQuery();
				
				
				MessageBox.Show("Added!");
			}
			else
			{
				MessageBox.Show("Exists already!");
			}

			mm_dbConnection.Close();
		}
		
		void BreederBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			breeder_name = breederBox.Text;
		}
		
		void DogBoxTextChanged(object sender, EventArgs e)
		{
			name = dogBox.Text;	
		}
		
		void SireCoatBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			sire_coat_id = sireCoatBox.SelectedIndex;
		}
		
		void DamCoatBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			dam_coat_id =damCoatBox.SelectedIndex;
		}
		
		void CoatBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			dog_coat_id = coatBox.SelectedIndex;
		}
		
		void UpdateButtonClick(object sender, EventArgs e)
		{
			SQLiteConnection m_dbConnection;
			m_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
			m_dbConnection.Open();
			bool reverse;

			string sql;
			SQLiteCommand command;

			reverse = reverseOrderBox.Checked;
			sql = "UPDATE dogs SET dogcoat = @dog_coat, breeder = @breeder_name, name = @dog_name, reverse_order = @reverse, sire = @sire_name, dam = @dam_name, sirecoat = @sire_coat_id, damcoat = @dam_coat_id where id = @dog_id";
			command = new SQLiteCommand(sql, m_dbConnection);

			command.Parameters.AddWithValue("@dog_coat", dog_coat_id);
			command.Parameters.AddWithValue("@dog_id", dog_id);
			if(breeder_name.Equals(""))
			{
				command.Parameters.AddWithValue("@breeder_name", null);
				command.Parameters.AddWithValue("@dog_name", name);
			}
			else
			{
				command.Parameters.AddWithValue("@breeder_name", breeder_name);
				command.Parameters.AddWithValue("@dog_name", breeder_name + " " + name);
			}

			command.Parameters.AddWithValue("@reverse", reverse);
			command.Parameters.AddWithValue("@sire_name", sire);
			command.Parameters.AddWithValue("@dam_name", dam);
			command.Parameters.AddWithValue("@sire_coat_id", sire_coat_id);
			command.Parameters.AddWithValue("@dam_coat_id", dam_coat_id);

			command.ExecuteNonQuery();

			m_dbConnection.Close();
			MessageBox.Show("Updated");
		}
		
	}
}
