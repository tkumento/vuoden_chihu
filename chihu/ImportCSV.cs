/*
 * Created by SharpDevelop.
 * User: Tuomo
 * Date: 19/08/2014
 * Time: 19:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Text;

namespace chihu
{
	/// <summary>
	/// Description of ImportCSV.
	/// </summary>
	public partial class ImportCSV : Form
	{
		public ImportCSV()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//


		}
		
		void ImportDogsButtonClick(object sender, EventArgs e)
		{
			SQLiteConnection m_dbConnection;
			m_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
			m_dbConnection.Open();
			
			using (StreamReader sr = new StreamReader("dogs.csv", Encoding.UTF7, true))
			{
				string currentLine;
				string[] line;
				string[] line2;
				string sql;
				SQLiteCommand command;

				int sire_coat_id = 1;
				int dam_coat_id = 1;
				int dog_coat_id = 1;
				
				// currentLine will be null when the StreamReader reaches the end of file
				while((currentLine = sr.ReadLine()) != null)
				{
					line = currentLine.Split(',');
					line2 = currentLine.Split(',');
					if(line[0].Equals("LK"))
					{
						//LK
						dog_coat_id = 0;
					}
					else
					{
						// PK
						dog_coat_id = 1;
					}
					
					if(line[3].Equals("LK"))
					{
						//LK
						sire_coat_id = 0;
					}
					else
					{
						// PK
						sire_coat_id = 1;
					}
					
					if(line[5].Equals("LK"))
					{
						//LK
						dam_coat_id = 0;
					}
					else
					{
						// PK
						dam_coat_id = 1;
					}
					
					sql = "insert into dogs (dogcoat, breeder, name, sire, dam, sirecoat, damcoat) values ( @dog_coat, @breeder_name, @dog_name, @sire_name, @dam_name, @sire_coat_id, @dam_coat_id)";
					command = new SQLiteCommand(sql, m_dbConnection);
					command.Parameters.AddWithValue("@dog_coat", dog_coat_id);

					if(line[1].Equals(""))
					{
						command.Parameters.AddWithValue("@breeder_name", null);
						command.Parameters.AddWithValue("@dog_name", line[2]);
					}
					else
					{
						command.Parameters.AddWithValue("@breeder_name", line[1]);
						command.Parameters.AddWithValue("@dog_name", line[1] + " " + line[2]);
					}

					command.Parameters.AddWithValue("@sire_name", line[4]);
					command.Parameters.AddWithValue("@dam_name", line[6]);
					command.Parameters.AddWithValue("@sire_coat_id", sire_coat_id);
					command.Parameters.AddWithValue("@dam_coat_id", dam_coat_id);
					command.ExecuteNonQuery();
					
				}
			}
			m_dbConnection.Close();
			MessageBox.Show("Done");
			
		}
		
		void ImportPuppiesButtonClick(object sender, EventArgs e)
		{
			SQLiteConnection m_dbConnection;
			m_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
			m_dbConnection.Open();
			
			using (StreamReader sr = new StreamReader("puppy.csv", Encoding.UTF7, true))
			{
				string currentLine;
				string[] line;
				string[] line2;
				string sql;
				SQLiteCommand command;

				int dog_coat_id = 1;
				
				// currentLine will be null when the StreamReader reaches the end of file
				while((currentLine = sr.ReadLine()) != null)
				{
					line = currentLine.Split(',');
					line2 = currentLine.Split(',');
					if(line[0].Equals("LK"))
					{
						//LK
						dog_coat_id = 0;
					}
					else
					{
						// PK
						dog_coat_id = 1;
					}
					

					
					sql = "insert into puppy (dogcoat, breeder, name) values ( @dog_coat, @breeder_name, @dog_name)";
					command = new SQLiteCommand(sql, m_dbConnection);
					command.Parameters.AddWithValue("@dog_coat", dog_coat_id);

					if(line[1].Equals(""))
					{
						command.Parameters.AddWithValue("@breeder_name", null);
						command.Parameters.AddWithValue("@dog_name", line[2]);
					}
					else
					{
						command.Parameters.AddWithValue("@breeder_name", line[1]);
						command.Parameters.AddWithValue("@dog_name", line[1] + " " + line[2]);
					}
					command.ExecuteNonQuery();
					
				}
			}
			m_dbConnection.Close();
			MessageBox.Show("Done");
		}
		
		void ImportVeteransButtonClick(object sender, EventArgs e)
		{
			SQLiteConnection m_dbConnection;
			m_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
			m_dbConnection.Open();
			
			using (StreamReader sr = new StreamReader("veteran.csv", Encoding.UTF7, true))
			{
				string currentLine;
				string[] line;
				string[] line2;
				string sql;
				SQLiteCommand command;

				int dog_coat_id = 1;
				
				// currentLine will be null when the StreamReader reaches the end of file
				while((currentLine = sr.ReadLine()) != null)
				{
					line = currentLine.Split(',');
					line2 = currentLine.Split(',');
					if(line[0].Equals("LK"))
					{
						//LK
						dog_coat_id = 0;
					}
					else
					{
						// PK
						dog_coat_id = 1;
					}
					

					
					sql = "insert into veteran (dogcoat, breeder, name) values ( @dog_coat, @breeder_name, @dog_name)";
					command = new SQLiteCommand(sql, m_dbConnection);
					command.Parameters.AddWithValue("@dog_coat", dog_coat_id);

					if(line[1].Equals(""))
					{
						command.Parameters.AddWithValue("@breeder_name", null);
						command.Parameters.AddWithValue("@dog_name", line[2]);
					}
					else
					{
						command.Parameters.AddWithValue("@breeder_name", line[1]);
						command.Parameters.AddWithValue("@dog_name", line[1] + " " + line[2]);
					}
					command.ExecuteNonQuery();
					
				}
			}
			
			m_dbConnection.Close();
			MessageBox.Show("Done");
		}
	}
}
