/*
 * Created by SharpDevelop.
 * User: Tuomo
 * Date: 07/09/2014
 * Time: 07:30
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
	/// Description of update.
	/// </summary>
	public partial class update : Form
	{
		
		public struct show_list
		{
			public int coat;
			public string show;
		}
		
		public struct dog_list
		{
			public int coat;
			public string name;
		}
		
		public List<show_list> Shows;
		public List<show_list> PuppyShows;
		public List<show_list> VeteranShows;
		public List<show_list> BreederShows;
		public List<dog_list> Dogs;
		public List<dog_list> Puppies;
		public List<dog_list> Veterans;
		
		public int show_index;
		public int puppy_show_index;
		public int veteran_show_index;
		public int breeder_show_index;
		public int dog_index = -1;
		public int puppy_index = -1;
		public int veteran_index = -1;
		
		public update()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Shows = new List<show_list>();
			PuppyShows = new List<show_list>();
			VeteranShows = new List<show_list>();
			BreederShows = new List<show_list>();
			Dogs = new List<dog_list>();
			Puppies = new List<dog_list>();
			Veterans = new List<dog_list>();
			
			populate_combox();
		}
		
		void populate_combox()
		{
			string sql;
			SQLiteCommand command;
			string show;
			int coat;
			string coat_string;
			
			show_list show_list_item;
			dog_list dog_list_item;
			SQLiteConnection m_dbConnection;
			m_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
			m_dbConnection.Open();

			sql = "select * from shows";
			command = new SQLiteCommand(sql, m_dbConnection);
			SQLiteDataReader reader = command.ExecuteReader();
			while (reader.Read())
				{
				show_list_item = new show_list();
				var temp_show = reader["show"];
				var temp_coat = reader["coat"];
				show = temp_show.ToString();
				coat = Convert.ToInt32(temp_coat);
				if(coat == 0)
				{
					coat_string = "LK";
				}
				else if (coat == 1)
				{
					coat_string = "PK";
				}
				else
				{
					coat_string = "Error";
				}
				show_list_item.show = show;
				show_list_item.coat = coat;
				Shows.Add(show_list_item);
       			selectShowBox.Items.Add(coat_string + " " + show);
       			
				}
			
			sql = "select * from puppy_shows";
			command = new SQLiteCommand(sql, m_dbConnection);
			reader = command.ExecuteReader();
			while (reader.Read())
				{
				show_list_item = new show_list();
				var temp_show = reader["show"];
				var temp_coat = reader["coat"];
				show = temp_show.ToString();
				coat = Convert.ToInt32(temp_coat);
				if(coat == 0)
				{
					coat_string = "LK";
				}
				else if (coat == 1)
				{
					coat_string = "PK";
				}
				else
				{
					coat_string = "Error";
				}
				show_list_item.show = show;
				show_list_item.coat = coat;
				PuppyShows.Add(show_list_item);
       			selectPuppyShowBox.Items.Add(coat_string + " " + show);
				}
			
			sql = "select * from veteran_shows";
			command = new SQLiteCommand(sql, m_dbConnection);
			reader = command.ExecuteReader();
			while (reader.Read())
				{
				show_list_item = new show_list();
				var temp_show = reader["show"];
				var temp_coat = reader["coat"];
				show = temp_show.ToString();
				coat = Convert.ToInt32(temp_coat);
				if(coat == 0)
				{
					coat_string = "LK";
				}
				else if (coat == 1)
				{
					coat_string = "PK";
				}
				else
				{
					coat_string = "Error";
				}
				show_list_item.show = show;
				show_list_item.coat = coat;
				VeteranShows.Add(show_list_item);
       			selectVeteranShowBox.Items.Add(coat_string + " " + show);
				}
			
			sql = "select * from breeder";
			command = new SQLiteCommand(sql, m_dbConnection);
			reader = command.ExecuteReader();
			while (reader.Read())
				{
				show_list_item = new show_list();
				var temp_show = reader["show"];
				var temp_coat = reader["coat"];
				show = temp_show.ToString();
				coat = Convert.ToInt32(temp_coat);
				if(coat == 0)
				{
					coat_string = "LK";
				}
				else if (coat == 1)
				{
					coat_string = "PK";
				}
				else
				{
					coat_string = "Error";
				}
				show_list_item.show = show;
				show_list_item.coat = coat;
				BreederShows.Add(show_list_item);
       			selectBreederShowBox.Items.Add(coat_string + " " + show);
				}
			
			sql = "select name, dogcoat from dogs order by name";
			command = new SQLiteCommand(sql, m_dbConnection);
			reader = command.ExecuteReader();

			while (reader.Read())
			{
				dog_list_item = new dog_list();
				var temp_name = reader["name"];
				var temp_coat = reader["dogcoat"];
				
				dog_list_item.name = temp_name.ToString();
				dog_list_item.coat = Convert.ToInt32(temp_coat);
				Dogs.Add(dog_list_item);
       			selectDogBox.Items.Add(dog_list_item.name);

			}
			
			sql = "select name, dogcoat from puppy order by name";
			command = new SQLiteCommand(sql, m_dbConnection);
			reader = command.ExecuteReader();

			while (reader.Read())
			{
				dog_list_item = new dog_list();
				var temp_name = reader["name"];
				var temp_coat = reader["dogcoat"];
				
				dog_list_item.name = temp_name.ToString();
				dog_list_item.coat = Convert.ToInt32(temp_coat);
				Puppies.Add(dog_list_item);
       			selectPuppyBox.Items.Add(dog_list_item.name);

			}
			
			sql = "select name, dogcoat from veteran order by name";
			command = new SQLiteCommand(sql, m_dbConnection);
			reader = command.ExecuteReader();

			while (reader.Read())
			{
				dog_list_item = new dog_list();
				var temp_name = reader["name"];
				var temp_coat = reader["dogcoat"];
				
				dog_list_item.name = temp_name.ToString();
				dog_list_item.coat = Convert.ToInt32(temp_coat);
				Veterans.Add(dog_list_item);
       			selectVeteranBox.Items.Add(dog_list_item.name);

			}
			
			m_dbConnection.Close();

		}
		
		void SelectShowBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			show_index = selectShowBox.SelectedIndex;
		}
		
		void SelectPuppyShowBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			puppy_show_index = selectPuppyShowBox.SelectedIndex;
		}
		
		void SelectVeteranShowBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			veteran_show_index = selectVeteranShowBox.SelectedIndex;
		}
		
		void SelectBreederShowBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			breeder_show_index = selectBreederShowBox.SelectedIndex;
		}
		
		void UpdateShowButtonClick(object sender, EventArgs e)
		{
			AddShow addShowDialog = new AddShow(true, Shows[show_index].coat, Shows[show_index].show);
			addShowDialog.ShowDialog();
		}
		
		void SelectDogBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			dog_index = selectDogBox.SelectedIndex;
		}
		
		void UpdateDogButtonClick(object sender, EventArgs e)
		{
			if(dog_index != -1)
			{
				var modify_name = selectDogBox.Items[dog_index].ToString();
				NewDog newDogDialog = new NewDog(true, modify_name);
				newDogDialog.ShowDialog();
			}
			else
			{
				MessageBox.Show("Dog does not exist");
			}
		}
		
		void UpdatePuppyShowButtonClick(object sender, EventArgs e)
		{
			AddPuppyShow addPuppyShowDialog = new AddPuppyShow(true, PuppyShows[puppy_show_index].coat, PuppyShows[puppy_show_index].show);
			addPuppyShowDialog.ShowDialog();
		}
		
		void UpdateVeteranShowButtonClick(object sender, EventArgs e)
		{
			AddVeteranShow addVeteranShowDialog = new AddVeteranShow(true, VeteranShows[veteran_show_index].coat, VeteranShows[veteran_show_index].show);
			addVeteranShowDialog.ShowDialog();
		}
		

		
		void CloseButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void UpdateBreederShowButtonClick(object sender, EventArgs e)
		{
			AddBreederShow addBreederShowDialog = new AddBreederShow(true, BreederShows[breeder_show_index].coat, BreederShows[breeder_show_index].show);
			addBreederShowDialog.ShowDialog();
		}
		
		void UpdatePuppyButtonClick(object sender, EventArgs e)
		{
			if(puppy_index != -1)
			{
				var modify_name = selectPuppyBox.Items[puppy_index].ToString();
				NewPuppy newPuppyDialog = new NewPuppy(true, modify_name);
				newPuppyDialog.ShowDialog();
			}
			else
			{
				MessageBox.Show("Puppy does not exist");
			}
		}
		
		void UpdateVeteranButtonClick(object sender, EventArgs e)
		{
			if(veteran_index != -1)
			{
				var modify_name = selectVeteranBox.Items[veteran_index].ToString();
				NewVeteran newVeteranDialog = new NewVeteran(true, modify_name);
				newVeteranDialog.ShowDialog();
			}
			else
			{
				MessageBox.Show("Veteran does not exist");
			}
		}
		
		void SelectPuppyBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			puppy_index = selectPuppyBox.SelectedIndex;
		}
		
		void SelectVeteranBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			veteran_index = selectVeteranBox.SelectedIndex;
		}
	}
}
