/*
 * Created by SharpDevelop.
 * User: Tuomo
 * Date: 23/08/2014
 * Time: 17:36
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
	/// Description of AddVeteranShow.
	/// </summary>
	public partial class AddVeteranShow : Form
	{
		public int rop_id;
		public int vsp_id;
		public int coat = 0;
		public int int_show;
		public int dog_count = 0;
		public string show_name;
		public string judge;
		public bool modify_operation;
		public AddVeteranShow(bool modify, int current_coat, string current_show)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			coatBox.Text = "0";
			coatBox.SelectedIndex = 0;
			modify_operation = modify;
			show_name = current_show;
			coat = current_coat;
			populate(modify, current_coat, current_show);        			
		}
		
		void populate( bool modify, int current_coat, string current_show)
		{
		    SQLiteConnection m_dbConnection;
			m_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
			m_dbConnection.Open();

            string sql;
            SQLiteCommand command;
			judgeComboBox.Items.Clear();
			
			sql = "select distinct judge from shows order by judge";
			
			command = new SQLiteCommand(sql, m_dbConnection);
			SQLiteDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				judgeComboBox.Items.Add(reader["judge"]);
			}
			if(modify == true)
			{
				this.Text = "Update mode";
				addButton.Hide();
				updateButton.Show();
				sql = "select * from veteran_shows where coat = @coat AND show = @show";
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
					
					var temp_judge = reader["judge"];
					var temp_dog_count = reader["veteran_count"];
					var temp_rop_id = reader["rop_vet"];
					var temp_vsp_id = reader["vsp_vet"];
					
					rop_id = Convert.ToInt32(temp_rop_id);
					vsp_id = Convert.ToInt32(temp_vsp_id);
					
		
					judgeComboBox.Text = temp_judge.ToString();
					judge =  temp_judge.ToString();
					dogCountBox.Text = temp_dog_count.ToString();
					dog_count = Convert.ToInt32(temp_dog_count);
					ropVetBox.Text = id_to_name(ref m_dbConnection, rop_id);
					vspVetBox.Text = id_to_name(ref m_dbConnection, vsp_id);

				}
				
			}
			m_dbConnection.Close();          
		}
		
		string id_to_name(ref SQLiteConnection m_dbConnection, int id)
		{
			string name = "";
			string sql;
            SQLiteCommand command;
			
			sql = "select name from veteran where id = @dog_id";
			
			command = new SQLiteCommand(sql, m_dbConnection);
			command.Parameters.AddWithValue("@dog_id", id);
			SQLiteDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				var temp_name = reader["name"];
				name = temp_name.ToString();
			}
			return name;
		}		
		
		void CloseButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void CoatBoxSelectedIndexChanged(object sender, EventArgs e)
		{
		coat = coatBox.SelectedIndex;
		}
		
		void ShowBoxTextChanged(object sender, EventArgs e)
		{
			show_name = showBox.Text;
		}
		
		
		void JudgeBoxTextChanged(object sender, EventArgs e)
		{
			judge = judgeBox.Text;
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
			}			
		}
		
		void RopVetButtonClick(object sender, EventArgs e)
		{
			string name;
			AddDog addDialog = new AddDog(coat, chihu.dog_type.veteran);
			addDialog.ShowDialog();
			rop_id = addDialog.return_id;
			name = addDialog.return_name;
			ropVetBox.Text = name;
		}
		
		void VspVetButtonClick(object sender, EventArgs e)
		{
			string name;
			AddDog addDialog = new AddDog(coat, chihu.dog_type.veteran);
			addDialog.ShowDialog();
			vsp_id = addDialog.return_id;
			name = addDialog.return_name;
			vspVetBox.Text = name;			
		}
		
		void JudgeBoxClick(object sender, EventArgs e)
		{
			judgeBox.SelectAll();
		}
		
		void ShowBoxClick(object sender, EventArgs e)
		{
			showBox.SelectAll();
		}
		
		void AmountBoxClick(object sender, EventArgs e)
		{
			dogCountBox.SelectAll();
		}
		
		void AddButtonClick(object sender, EventArgs e)
		{
			SQLiteConnection m_dbConnection;
			m_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
			m_dbConnection.Open();

            string sql;
            SQLiteCommand command;
		sql = "insert into veteran_shows (coat, show, judge, veteran_count, rop_vet, vsp_vet)" +
			"values ( @dog_coat, @show, @judge, @veteran_count, @rop_vet, @vsp_vet)";
		command = new SQLiteCommand(sql, m_dbConnection);
		command.Parameters.AddWithValue("@dog_coat", coat);
		command.Parameters.AddWithValue("@show", show_name);
		command.Parameters.AddWithValue("@judge", judge);
		command.Parameters.AddWithValue("@veteran_count", dog_count);
		command.Parameters.AddWithValue("@rop_vet", rop_id);
		command.Parameters.AddWithValue("@vsp_vet", vsp_id);
		command.ExecuteNonQuery();

		m_dbConnection.Close();   
		MessageBox.Show("Added");				
		}
		
		void JudgeComboBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			judge = judgeComboBox.Text;
		}
		
		void UpdateButtonClick(object sender, EventArgs e)
		{
			SQLiteConnection m_dbConnection;
			m_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
			m_dbConnection.Open();

			string sql;
			SQLiteCommand command;

			sql = "UPDATE veteran_shows SET rop_vet = @rop, vsp_vet = @vsp, judge = @judge, veteran_count = @dog_count where coat = @coat and show = @show";
			command = new SQLiteCommand(sql, m_dbConnection);
			command.Parameters.AddWithValue("@rop", rop_id);
			command.Parameters.AddWithValue("@vsp", vsp_id);
			command.Parameters.AddWithValue("@judge", judge);
			command.Parameters.AddWithValue("@dog_count", dog_count);
			command.Parameters.AddWithValue("@coat", coat);
			command.Parameters.AddWithValue("@show", show_name);
			command.ExecuteNonQuery();

			m_dbConnection.Close();
			MessageBox.Show("Updated");			
		}
	}
}
