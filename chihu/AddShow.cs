﻿/*
 * Created by SharpDevelop.
 * User: Tuomo
 * Date: 23/08/2014
 * Time: 13:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

//coat INT, int_show INT, show VARCHAR(30), judge VARCHAR(50), dog_count INT,
//rop INTEGER, vsp INTEGER, pu2 INTEGER, pu3 INTEGER, pu4 INTEGER, pn2 INTEGER, pn3 INTEGER, pn4 INTEGER,
//FOREIGN KEY(rop) REFERENCES dogs(id), FOREIGN KEY(vsp) REFERENCES dogs(id), FOREIGN KEY(pu2) REFERENCES dogs(id), FOREIGN KEY(pu3) REFERENCES dogs(id), FOREIGN KEY(pu4) REFERENCES dogs(id), FOREIGN KEY(pn2) REFERENCES dogs(id), FOREIGN KEY(pn3) REFERENCES dogs(id), FOREIGN KEY(pn4) REFERENCES dogs(id))";
namespace chihu
{
	/// <summary>
	/// Description of AddShow.
	/// </summary>
	public partial class AddShow : Form
	{
		public int rop_id;
		public int vsp_id;
		public int pu2_id;
		public int pu3_id;
		public int pu4_id;
		public int pn2_id;
		public int pn3_id;
		public int pn4_id;
		public int coat;
		public int int_show;
		public int dog_count;
		public string show_name;
		public string judge;
		public bool modify_operation = false;
		public int valid = 1;
		public int spare1 = 0;
		public string spare2 = "";
		
		public AddShow(bool modify, int current_coat, string current_show)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			modify_operation = modify;
			amountBox.Text = "0";
			coat = current_coat;
			show_name = current_show;
			if(modify == true)
			{
				this.Text = "Update mode";
				addShowButton.Hide();
				updateButton.Show();
				
			}
			populate(modify, current_coat, current_show);

		}


		void populate(bool modify, int current_coat, string current_show)
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
				addShowButton.Hide();
				updateButton.Show();

				sql = "select * from shows where coat = @coat AND show = @show";
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
					showLocationBox.Text = current_show;
					show_name = current_show;
					
					var temp_int_show = reader["int_show"];
					var temp_judge = reader["judge"];
					var temp_dog_count = reader["dog_count"];
					var temp_rop_id = reader["rop"];
					var temp_vsp_id = reader["vsp"];
					var temp_pu2_id = reader["pu2"];
					var temp_pu3_id = reader["pu3"];
					var temp_pu4_id = reader["pu4"];
					var temp_pn2_id = reader["pn2"];
					var temp_pn3_id = reader["pn3"];
					var temp_pn4_id = reader["pn4"];
					var temp_valid = reader["valid"];
					
					rop_id = Convert.ToInt32(temp_rop_id);
					vsp_id = Convert.ToInt32(temp_vsp_id);
					pu2_id = Convert.ToInt32(temp_pu2_id);
					pu3_id = Convert.ToInt32(temp_pu3_id);
					pu4_id = Convert.ToInt32(temp_pu4_id);
					pn2_id = Convert.ToInt32(temp_pn2_id);
					pn3_id = Convert.ToInt32(temp_pn3_id);
					pn4_id = Convert.ToInt32(temp_pn4_id);
					
					int_show = Convert.ToInt32(temp_int_show);
					if(int_show == 0)
					{
						showTypeBox.Text = "NAT";
					}
					else
					{
						showTypeBox.Text = "INT";
					}
					showTypeBox.SelectedIndex = int_show;
					
					judgeComboBox.Text = temp_judge.ToString();
					judge =  temp_judge.ToString();
					amountBox.Text = temp_dog_count.ToString();
					dog_count = Convert.ToInt32(temp_dog_count);
					ropNameBox.Text = id_to_name(ref m_dbConnection, rop_id);
					vspNameBox.Text = id_to_name(ref m_dbConnection, vsp_id);
					pu2NameBox.Text = id_to_name(ref m_dbConnection, pu2_id);
					pu3NameBox.Text = id_to_name(ref m_dbConnection, pu3_id);
					pu4NameBox.Text = id_to_name(ref m_dbConnection, pu4_id);
					pn2NameBox.Text = id_to_name(ref m_dbConnection, pn2_id);
					pn3NameBox.Text = id_to_name(ref m_dbConnection, pn3_id);
					pn4NameBox.Text = id_to_name(ref m_dbConnection, pn4_id);
					
					if((int)temp_valid == 1)
					{
						checkBox1.Checked = true;
						valid = 1;
					}
					else
					{
						checkBox1.Checked = false;
						valid = 0;
					}
					//break;
				}
			}
			
			m_dbConnection.Close();
			m_dbConnection.Dispose();
		}
		
		string id_to_name(ref SQLiteConnection m_dbConnection, int id)
		{
			string name = "";
			string sql;
			SQLiteCommand command;
			
			sql = "select name from dogs where id = @dog_id";
			
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
		
		void RopButtonClick(object sender, EventArgs e)
		{
			string name;
			AddDog addDialog = new AddDog(coat, chihu.dog_type.adult);
			addDialog.ShowDialog();
			rop_id = addDialog.return_id;
			name = addDialog.return_name;
			ropNameBox.Text = name;

		}
		
		void VspButtonClick(object sender, EventArgs e)
		{
			string name;
			AddDog addDialog = new AddDog(coat, chihu.dog_type.adult);
			addDialog.ShowDialog();
			vsp_id = addDialog.return_id;
			name = addDialog.return_name;
			vspNameBox.Text = name;
		}
		
		void Pu2ButtonClick(object sender, EventArgs e)
		{
			string name;
			AddDog addDialog = new AddDog(coat, chihu.dog_type.adult);
			addDialog.ShowDialog();
			pu2_id = addDialog.return_id;
			name = addDialog.return_name;
			pu2NameBox.Text = name;
		}
		
		void Pu3ButtonClick(object sender, EventArgs e)
		{
			string name;
			AddDog addDialog = new AddDog(coat, chihu.dog_type.adult);
			addDialog.ShowDialog();
			pu3_id = addDialog.return_id;
			name = addDialog.return_name;
			pu3NameBox.Text = name;
		}
		
		void Pu4ButtonClick(object sender, EventArgs e)
		{
			string name;
			AddDog addDialog = new AddDog(coat, chihu.dog_type.adult);
			addDialog.ShowDialog();
			pu4_id = addDialog.return_id;
			name = addDialog.return_name;
			pu4NameBox.Text = name;
		}
		
		void Pn2ButtonClick(object sender, EventArgs e)
		{
			string name;
			AddDog addDialog = new AddDog(coat, chihu.dog_type.adult);
			addDialog.ShowDialog();
			pn2_id = addDialog.return_id;
			name = addDialog.return_name;
			pn2NameBox.Text = name;
		}
		
		void Pn3ButtonClick(object sender, EventArgs e)
		{
			string name;
			AddDog addDialog = new AddDog(coat, chihu.dog_type.adult);
			addDialog.ShowDialog();
			pn3_id = addDialog.return_id;
			name = addDialog.return_name;
			pn3NameBox.Text = name;
		}
		
		void Pn4ButtonClick(object sender, EventArgs e)
		{
			string name;
			AddDog addDialog = new AddDog(coat, chihu.dog_type.adult);
			addDialog.ShowDialog();
			pn4_id = addDialog.return_id;
			name = addDialog.return_name;
			pn4NameBox.Text = name;
		}
		
		void AddShowButtonClick(object sender, EventArgs e)
		{

			SQLiteConnection m_dbConnection;
			m_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
			m_dbConnection.Open();

			string sql;
			SQLiteCommand command;
			//coat INT, int_show INT, show VARCHAR(30), judge VARCHAR(50), dog_count INT, rop INTEGER, vsp INTEGER, pu2 INTEGER, pu3 INTEGER, pu4 INTEGER, pn2 INTEGER, pn3 INTEGER, pn4 INTEGER
			sql = "insert into shows (valid, coat, int_show, show, judge, dog_count, rop, vsp, pu2, pu3, pu4, pn2, pn3, pn4, spare1, spare2) " +
				"values ( @valid, @dog_coat, @int_show, @show, @judge, @dog_count, @rop, @vsp, @pu2, @pu3, @pu4, @pn2, @pn3, @pn4, @spare1, @spare2)";
			command = new SQLiteCommand(sql, m_dbConnection);
			command.Parameters.AddWithValue("@valid", valid);
			command.Parameters.AddWithValue("@dog_coat", coat);
			command.Parameters.AddWithValue("@int_show", int_show);
			command.Parameters.AddWithValue("@show", show_name);
			command.Parameters.AddWithValue("@judge", judge);
			command.Parameters.AddWithValue("@dog_count", dog_count);
			command.Parameters.AddWithValue("@rop", rop_id);
			command.Parameters.AddWithValue("@vsp", vsp_id);
			command.Parameters.AddWithValue("@pu2", pu2_id);
			command.Parameters.AddWithValue("@pu3", pu3_id);
			command.Parameters.AddWithValue("@pu4", pu4_id);
			command.Parameters.AddWithValue("@pn2", pn2_id);
			command.Parameters.AddWithValue("@pn3", pn3_id);
			command.Parameters.AddWithValue("@pn4", pn4_id);
			command.Parameters.AddWithValue("@spare1", spare1);
			command.Parameters.AddWithValue("@spare2", spare2);
			command.ExecuteNonQuery();

			m_dbConnection.Close();
			MessageBox.Show("Added");
		}
		
		void CoatBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			coat = coatBox.SelectedIndex;
		}
		
		void ShowTypeBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			int_show = showTypeBox.SelectedIndex;
		}
		
		void AmountBoxTextChanged(object sender, EventArgs e)
		{
			try
			{
				dog_count = Convert.ToInt32(amountBox.Text);
			}
			catch (Exception crap)
			{
				dog_count = 0;
				var _ = crap;
			}
		}
		
		void ShowLocationBoxTextChanged(object sender, EventArgs e)
		{
			show_name = showLocationBox.Text;
		}
		
		void JudgeBoxTextChanged(object sender, EventArgs e)
		{
			judge = judgeBox.Text;
		}
		
		void CloseButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void JudgeBoxClick(object sender, EventArgs e)
		{
			judgeBox.SelectAll();
		}
		
		void ShowBoxClick(object sender, EventArgs e)
		{
			showLocationBox.SelectAll();
		}
		
		void AmountBoxClick(object sender, EventArgs e)
		{
			amountBox.SelectAll();
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

			sql = "UPDATE shows SET valid = @valid, rop = @rop, vsp = @vsp, pu2 = @pu2, pu3 = @pu3, pu4 = @pu4, pn2 = @pn2, pn3 = @pn3, pn4 = @pn4, int_show = @int_show, judge = @judge, dog_count = @dog_count where coat = @coat and show = @show";
			//sql = "UPDATE shows SET dog_count = @dog_count where show = @show";
			command = new SQLiteCommand(sql, m_dbConnection);
			command.Parameters.AddWithValue("@valid", valid);
			command.Parameters.AddWithValue("@rop", rop_id);
			command.Parameters.AddWithValue("@vsp", vsp_id);
			command.Parameters.AddWithValue("@pu2", pu2_id);
			command.Parameters.AddWithValue("@pu3", pu3_id);
			command.Parameters.AddWithValue("@pu4", pu4_id);
			command.Parameters.AddWithValue("@pn2", pn2_id);
			command.Parameters.AddWithValue("@pn3", pn3_id);
			command.Parameters.AddWithValue("@pn4", pn4_id);
			command.Parameters.AddWithValue("@int_show", int_show);
			command.Parameters.AddWithValue("@judge", judge);
			command.Parameters.AddWithValue("@dog_count", dog_count);
			command.Parameters.AddWithValue("@coat", coat);
			command.Parameters.AddWithValue("@show", show_name);
			command.ExecuteNonQuery();

			m_dbConnection.Close();
			MessageBox.Show("Updated");
		}
		

		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			if(checkBox1.Checked == true)
			{
				valid = 1;
			}
			else
			{
				valid = 0;
			}
		}
		
		public class dogIdentity
		{
			public Int32 id;
			public string dog_name;
		};
		
		public dogIdentity GuessDog(string dog_name, int dog_coat_id)
		{
			string sql;
			SQLiteCommand command;
			dogIdentity dog_from_db = new dogIdentity
			{
				id = 0,
				dog_name = ""
			};

			dog_from_db.id = 0;
			if(dog_name.Length > 0)
			{
				SQLiteConnection m_dbConnection;
				m_dbConnection =
					new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
				m_dbConnection.Open();
				
				sql = "select id from dogs where name = @dog_name AND dogcoat = @dog_coat";
				
				//sql = "select id from dogs where name = @dog_name AND dogcoat = @dog_coat";
				command = new SQLiteCommand(sql, m_dbConnection);
				command.Parameters.AddWithValue("@dog_name", dog_name);
				command.Parameters.AddWithValue("@dog_coat", dog_coat_id);
				SQLiteDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					dog_from_db.id = Convert.ToInt32(reader["id"]);
					dog_from_db.dog_name = dog_name;
				}
				m_dbConnection.Close();
			}
			return dog_from_db;
		}
		
		
		string string_to_upper(string input_s)
		{
			char[] output_s = input_s.ToCharArray();
			int index;
			
						
			index = input_s.IndexOf('-');
			if(index != -1)
			{
				output_s[index + 1] = Char.ToUpper(output_s[index + 1]);
			}
			
			for(int i = 0 ; i < output_s.Length; i++)
			{
				if(output_s[i] == 'é')
				{
					output_s[i] = 'e';
				}
			}
			
			string return_string = new string(output_s);
			return return_string;
		}
		
		string GetDogFromStrings(string result)
		{
			string dog_name_from_string = "";
			string[] lines = textBoxGuess.Text.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
			foreach (string s in lines)
			{
				if(s.StartsWith(result))
				{
					int index = 1;
					string line = s;
					string[] result_words = s.Split(',');
					string last_word = result_words[result_words.Length - 1].Trim();
					string[] words = last_word.Split(' ');
					if(words[index] == "SERT")
					{
						index++;
					}
					if(words[index] == "MVA")
					{
						index++;
					}
					dog_name_from_string = string_to_upper(words[index]);
					index++;
					//dog_name_from_string = words[1];
					for(int i = index ; i < words.Length ; i++)
					{
						dog_name_from_string += " " + string_to_upper(words[i]);
						//dog_name_from_string += " " + words[i];
					}
					
					break;
				}
			}
			return dog_name_from_string;
		}
		void ButtonGuessClick(object sender, EventArgs e)
		{
			string name;
			string result_name;
			dogIdentity dog_from_db;
			
			result_name = GetDogFromStrings("ROP,");
			dog_from_db = GuessDog(result_name, coat);
			if(dog_from_db.id == 0)
			{
				result_name = GetDogFromStrings("ROP ");
				dog_from_db = GuessDog(result_name, coat);
			}
			rop_id = dog_from_db.id;
			name = dog_from_db.dog_name;
			ropNameBox.Text = name;
			
			result_name = GetDogFromStrings("VSP,");
			dog_from_db = GuessDog(result_name, coat);
			if(dog_from_db.id == 0)
			{
				result_name = GetDogFromStrings("VSP ");
				dog_from_db = GuessDog(result_name, coat);
			}
			vsp_id = dog_from_db.id;
			name = dog_from_db.dog_name;
			vspNameBox.Text = name;
			
			result_name = GetDogFromStrings("PU-2");
			dog_from_db = GuessDog(result_name, coat);
			pu2_id = dog_from_db.id;
			name = dog_from_db.dog_name;
			pu2NameBox.Text = name;
			
			result_name = GetDogFromStrings("PU-3");
			dog_from_db = GuessDog(result_name, coat);
			pu3_id = dog_from_db.id;
			name = dog_from_db.dog_name;
			pu3NameBox.Text = name;
			
			result_name = GetDogFromStrings("PU-4");
			dog_from_db = GuessDog(result_name, coat);
			pu4_id = dog_from_db.id;
			name = dog_from_db.dog_name;
			pu4NameBox.Text = name;
			
			result_name = GetDogFromStrings("PN-2");
			dog_from_db = GuessDog(result_name, coat);
			pn2_id = dog_from_db.id;
			name = dog_from_db.dog_name;
			pn2NameBox.Text = name;
			
			result_name = GetDogFromStrings("PN-3");
			dog_from_db = GuessDog(result_name, coat);
			pn3_id = dog_from_db.id;
			name = dog_from_db.dog_name;
			pn3NameBox.Text = name;
			
			result_name = GetDogFromStrings("PN-4");
			dog_from_db = GuessDog(result_name, coat);
			pn4_id = dog_from_db.id;
			name = dog_from_db.dog_name;
			pn4NameBox.Text = name;

		}
		
	}
}
