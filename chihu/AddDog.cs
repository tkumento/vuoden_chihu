/*
 * Created by SharpDevelop.
 * User: Tuomo
 * Date: 19/08/2014
 * Time: 13:57
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

		public enum dog_type
		{
			adult,
			puppy,
			veteran
		};
	
	/// Description of AddDog.
	/// </summary>
	public partial class AddDog : Form
	{
		public int return_id{get;set;}
		public string return_name{get;set;}
		public string return_value;
		public string dog_name = "none";
		public string breeder_name = "none";
		public string sire_name = "none";
		public string dam_name = "none";
		public string sire_coat = "none";
		public string dam_coat = "none";
		public int sire_coat_id = 1;
		public int dam_coat_id = 1;
		public int dog_coat_id = 1;
		
		public dog_type DogType = chihu.dog_type.adult;
		
		public AddDog(int coat, dog_type DogTypeP)
		{
			string sql;
			SQLiteCommand command;
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			if(coat == 0)
			{
			dogcoatBox.Text = "LK";
			}
			else
			{
			dogcoatBox.Text = "LK";
			}	
			dogcoatBox.SelectedIndex = coat;
			
			SQLiteConnection m_dbConnection;
			m_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
			m_dbConnection.Open();

			breederBox.Items.Clear();
			DogType = DogTypeP;
			if(DogType == chihu.dog_type.adult)
			{
				sql = "select distinct breeder from dogs where dogcoat = @dog_coat order by breeder";
			}
			else if(DogType == chihu.dog_type.puppy)
			{
				sql = "select distinct breeder from puppy where dogcoat = @dog_coat order by breeder";
			}
			else
			{
				sql = "select distinct breeder from veteran where dogcoat = @dog_coat order by breeder";
			}
			command = new SQLiteCommand(sql, m_dbConnection);
			command.Parameters.AddWithValue("@dog_coat", dog_coat_id);
			
			SQLiteDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				//MessageBox.Show("Breeder: " + reader["breeder"]);
				var temp_breeder = reader["breeder"];
				string breeder_str = temp_breeder.ToString();
				int result = breederBox.FindStringExact(breeder_str);
				if (result == -1)
				{
					breederBox.Items.Add(breeder_str);
				}
			}
			m_dbConnection.Close();
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			breeder_name = breederBox.Text;
			update_dog_list();
			dogBox.Text = breederBox.Text + " ";
			dogBox.SelectionLength = 0;
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
			
			if(DogType == chihu.dog_type.adult)
			{
				sql = "select id from dogs where name = @dog_name AND dogcoat = @dog_coat";
			}
			else if(DogType == chihu.dog_type.puppy)
			{
				sql = "select id from puppy where name = @dog_name AND dogcoat = @dog_coat";
			}
			else
			{
				sql = "select id from veteran where name = @dog_name AND dogcoat = @dog_coat";
			}
			
			//sql = "select id from dogs where name = @dog_name AND dogcoat = @dog_coat";
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
		
		
	
		void DogcoatBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			dog_coat_id = dogcoatBox.SelectedIndex;
			update_breeder_list();
		}
		
		void update_breeder_list()
		{
			string sql;
			SQLiteCommand command;
			
			SQLiteConnection m_dbConnection;
			m_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
			m_dbConnection.Open();
			breederBox.Items.Clear();
			
			if(DogType == chihu.dog_type.adult)
			{
				sql = "select distinct breeder from dogs where dogcoat = @dog_coat order by breeder";
			}
			else if(DogType == chihu.dog_type.puppy)
			{
				sql = "select distinct breeder from puppy where dogcoat = @dog_coat order by breeder";
			}
			else
			{
				sql = "select distinct breeder from veteran where dogcoat = @dog_coat order by breeder";
			}			
			
			//sql = "select distinct breeder from dogs where dogcoat = @dog_coat order by breeder";
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
		
		void update_dog_list()
		{
			string sql;
			SQLiteCommand command;
			
			SQLiteConnection m_dbConnection;
			m_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
			m_dbConnection.Open();
			dogBox.Items.Clear();
			if(breeder_name.Equals(""))
			{
				if(DogType == chihu.dog_type.adult)
				{
					sql = "select name from dogs where (breeder is NULL or breeder is @empty) AND dogcoat = @dog_coat order by name";
				}
				else if(DogType == chihu.dog_type.puppy)
				{
					sql = "select name from puppy where (breeder is NULL or breeder is @empty) AND dogcoat = @dog_coat order by name";
				}
				else
				{
					sql = "select name from veteran where (breeder is NULL or breeder is @empty) AND dogcoat = @dog_coat order by name";
				}
				
				//sql = "select name from dogs where breeder is NULL AND dogcoat = @dog_coat order by name";
				command = new SQLiteCommand(sql, m_dbConnection);
				command.Parameters.AddWithValue("@empty", breeder_name);
			}
			else
			{
				if(DogType == chihu.dog_type.adult)
				{
					sql = "select name from dogs where breeder = @breeder_name AND dogcoat = @dog_coat order by name";
				}
				else if(DogType == chihu.dog_type.puppy)
				{
					sql = "select name from puppy where breeder = @breeder_name AND dogcoat = @dog_coat order by name";
				}
				else
				{
					sql = "select name from veteran where breeder = @breeder_name AND dogcoat = @dog_coat order by name";
				}
				
			//sql = "select name from dogs where breeder = @breeder_name AND dogcoat = @dog_coat order by name";
			command = new SQLiteCommand(sql, m_dbConnection);
			command.Parameters.AddWithValue("@breeder_name", breeder_name);
			}
			command.Parameters.AddWithValue("@dog_coat", dog_coat_id);
			SQLiteDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				//MessageBox.Show("name: " + reader["name"]);
				dogBox.Items.Add(reader["name"]);
			}
			m_dbConnection.Close();			
		}
		
		void DoneButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void AddNewDogButtonClick(object sender, EventArgs e)
		{
			NewDog newDogDialog = new NewDog(false, "");
			newDogDialog.ShowDialog();			
			update_breeder_list();
			update_dog_list();
		}
		
		void AddNewPuppyButtonClick(object sender, EventArgs e)
		{
			NewPuppy newPuppyDialog = new NewPuppy(false, "");
			newPuppyDialog.ShowDialog();			
			update_breeder_list();
			update_dog_list();
		}
		
		void AddNewVeteranButtonClick(object sender, EventArgs e)
		{
			NewVeteran newVeteranDialog = new NewVeteran(false, "");
			newVeteranDialog.ShowDialog();			
			update_breeder_list();
			update_dog_list();
		}
		
		void NoDogButtonClick(object sender, EventArgs e)
		{
				this.return_id = 0;
				this.return_name = null;	
				this.Close();
		}
		
		void AddDogEnter(object sender, EventArgs e)
		{
			dogBox.SelectionLength = 0;
		}
	}
}
