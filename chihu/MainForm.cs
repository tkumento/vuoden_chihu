/*
 * Created by SharpDevelop.
 * User: Tuomo
 * Date: 19/08/2014
 * Time: 13:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Text;

namespace chihu
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			yearTextBox.Text = DateTime.Now.Year.ToString();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			SQLiteConnection m_dbConnection;
			string sql;
			SQLiteCommand command;
			m_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;foreign keys=true;");
			m_dbConnection.Open();

			//TODO: remove


#if false
			sql = "drop table if exists dogs";
			command = new SQLiteCommand(sql, m_dbConnection);
			command.ExecuteNonQuery();

			sql = "drop table if exists puppy";
			command = new SQLiteCommand(sql, m_dbConnection);
			command.ExecuteNonQuery();

			sql = "drop table if exists veteran";
			command = new SQLiteCommand(sql, m_dbConnection);
			command.ExecuteNonQuery();

			sql = "drop table if exists shows";
			command = new SQLiteCommand(sql, m_dbConnection);
			command.ExecuteNonQuery();

			sql = "drop table if exists puppy_shows";
			command = new SQLiteCommand(sql, m_dbConnection);
			command.ExecuteNonQuery();

			sql = "drop table if exists veteran_shows";
			command = new SQLiteCommand(sql, m_dbConnection);
			command.ExecuteNonQuery();

			sql = "drop table if exists breeder";
			command = new SQLiteCommand(sql, m_dbConnection);
			command.ExecuteNonQuery();
#endif
			
			sql = "create table if not exists dogs (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, dogcoat INT, breeder VARCHAR(30), name VARCHAR(30), reverse_order INT, sire VARCHAR(30), dam VARCHAR(30), sirecoat INT, damcoat INT)";
			command = new SQLiteCommand(sql, m_dbConnection);
			command.ExecuteNonQuery();

			sql = "create table if not exists puppy (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, dogcoat INT, breeder VARCHAR(30), name VARCHAR(30))";
			command = new SQLiteCommand(sql, m_dbConnection);
			command.ExecuteNonQuery();

			sql = "create table if not exists veteran (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, dogcoat INT, breeder VARCHAR(30), name VARCHAR(30))";
			command = new SQLiteCommand(sql, m_dbConnection);
			command.ExecuteNonQuery();

			sql = "create table if not exists shows (coat INT, int_show INT, show VARCHAR(30), judge VARCHAR(50), dog_count INT, rop INTEGER, vsp INTEGER, pu2 INTEGER, pu3 INTEGER, pu4 INTEGER, pn2 INTEGER, pn3 INTEGER, pn4 INTEGER, FOREIGN KEY(rop) REFERENCES dogs(id), FOREIGN KEY(vsp) REFERENCES dogs(id), FOREIGN KEY(pu2) REFERENCES dogs(id), FOREIGN KEY(pu3) REFERENCES dogs(id), FOREIGN KEY(pu4) REFERENCES dogs(id), FOREIGN KEY(pn2) REFERENCES dogs(id), FOREIGN KEY(pn3) REFERENCES dogs(id), FOREIGN KEY(pn4) REFERENCES dogs(id))";
			command = new SQLiteCommand(sql, m_dbConnection);
			command.ExecuteNonQuery();

			sql = "create table if not exists puppy_shows (coat INT, show VARCHAR(30), judge VARCHAR(50), puppy_count INT, rop_puppy INTEGER, vsp_puppy INTEGER, FOREIGN KEY(rop_puppy) REFERENCES puppy(id), FOREIGN KEY(vsp_puppy) REFERENCES puppy(id))";
			command = new SQLiteCommand(sql, m_dbConnection);
			command.ExecuteNonQuery();

			sql = "create table if not exists veteran_shows (coat INT, show VARCHAR(30), judge VARCHAR(50), veteran_count INT, rop_vet INTEGER, vsp_vet INTEGER, FOREIGN KEY(rop_vet) REFERENCES veteran(id), FOREIGN KEY(vsp_vet) REFERENCES veteran(id))";
			command = new SQLiteCommand(sql, m_dbConnection);
			command.ExecuteNonQuery();

			sql = "create table if not exists breeder (coat INT, show VARCHAR(30), rop_breeder VARCHAR(30), breeder2 VARCHAR(30), breeder3 VARCHAR(30), breeder4 VARCHAR(30), count )";
			command = new SQLiteCommand(sql, m_dbConnection);
			command.ExecuteNonQuery();

			m_dbConnection.Close();
		}
		
		void AddButtonClick(object sender, EventArgs e)
		{
			NewDog newDogDialog = new NewDog(false, "");
			newDogDialog.ShowDialog();
			
		}
		
		void ImportButtonClick(object sender, EventArgs e)
		{
			ImportCSV importDialog = new ImportCSV();
			importDialog.Show();
		}
		
		void AddShowButtonClick(object sender, EventArgs e)
		{
			AddShow addShowDialog = new AddShow(false, 0, "");
			addShowDialog.ShowDialog();
		}
		
		void NewPuppyButtonClick(object sender, EventArgs e)
		{
			NewPuppy newPuppyDialog = new NewPuppy(false, "");
			newPuppyDialog.ShowDialog();
		}
		
		void NewVeteranButtonClick(object sender, EventArgs e)
		{
			NewVeteran newVeteranDialog = new NewVeteran(false, "");
			newVeteranDialog.ShowDialog();
		}
		
		void ConfirmBoxCheckedChanged(object sender, EventArgs e)
		{
			if(confirmBox.Checked)
			{
				importButton.Show();
				dropShowsButton.Show();
				dropPuppyShowsButton.Show();
				dropVeteranShowsButton.Show();
				dropBreederShowsButton.Show();
				dumpButton.Show();
				dropPuppyButton.Show();
				debugResultsButton.Show();
				missingParentButton.Show();
				this.Text = "Expert mode";
			}
			else
			{
				importButton.Hide();
				dropShowsButton.Hide();
				dropPuppyShowsButton.Hide();
				dropVeteranShowsButton.Hide();
				dropBreederShowsButton.Hide();
				dumpButton.Hide();
				dropPuppyButton.Hide();
				debugResultsButton.Hide();
				missingParentButton.Hide();
				this.Text = "Chihu pistelasku";
			}
		}
		public struct parent_result
		{
			public int dog_id;
			public int count;
			public int points;
			public string name;
		}
			
		public struct breeder_result
		{
			public int count;
			public int points;
			public string name;
		}
		
		public struct dog_result
		{
			public int dog_id;
			public int points;
			public int p1;
			public int p2;
			public int p3;
			public int p4;
			public int p5;
			public int p6;
			public int count;
			public int disc_count;
			public string j1;
			public string j2;
			public string j3;
			public string j4;
			public string j5;
			public string j6;
			public string show1;
			public string show2;
			public string show3;
			public string show4;
			public string show5;
			public string show6;
			}
		
		void CalculateButtonClick(object sender, EventArgs e)
		{
			calculate(15, false, false);
		}

		void calculate(int limit, bool html_format, bool debug)
		{
			string name = "";
			int points;
			string debug_string = "";
			if(limit == 0)
			{
				limit = Int32.MaxValue;
			}
			progressBar1.Value = 0;
			progressBar1.Maximum = 14;
			progressBar1.Step = 1;
			progressBar1.Show();
			List<dog_result> LKDogResults = new List<dog_result>();
			List<dog_result> PKDogResults = new List<dog_result>();
			List<parent_result> LKParentResults = new List<parent_result>();
			List<parent_result> PKParentResults = new List<parent_result>();
			List<breeder_result> LKBreederResults = new List<breeder_result>();
			List<breeder_result> PKBreederResults = new List<breeder_result>();
			List<dog_result> LKVeteranResults = new List<dog_result>();
			List<dog_result> PKVeteranResults = new List<dog_result>();
			List<dog_result> LKPuppyResults = new List<dog_result>();
			List<dog_result> PKPuppyResults = new List<dog_result>();
			calculate_results(ref LKDogResults, 0);
			progressBar1.PerformStep();
			calculate_results(ref PKDogResults, 1);
			progressBar1.PerformStep();
			calculate_parents(ref LKDogResults, ref LKParentResults, ref PKParentResults, debug);
			progressBar1.PerformStep();
			calculate_parents(ref PKDogResults, ref LKParentResults, ref PKParentResults, debug);
			progressBar1.PerformStep();
			calculate_breeders(ref LKDogResults, ref LKBreederResults);
			progressBar1.PerformStep();
			calculate_breeders(ref PKDogResults, ref PKBreederResults);
			progressBar1.PerformStep();
			File.Delete("result.csv");
			using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"result.csv", true, Encoding.UTF8))
			{
				add_breeder_class(ref LKBreederResults, 0, debug, file);
				progressBar1.PerformStep();
				add_breeder_class(ref PKBreederResults, 1, debug, file);
				progressBar1.PerformStep();
				calculate_veteran(ref LKVeteranResults, 0);
				progressBar1.PerformStep();
				calculate_veteran(ref PKVeteranResults, 1);
				progressBar1.PerformStep();
				calculate_puppy(ref LKPuppyResults, 0);
				progressBar1.PerformStep();
				calculate_puppy(ref PKPuppyResults, 1);
				progressBar1.PerformStep();
				
				
			
				int position = 0;
				int true_position = 0;
				int prev_points = 0;
				SQLiteConnection m_dbConnection;
				SQLiteCommand command;
				string sql;
				m_dbConnection =
					new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;foreign keys=true;");
				m_dbConnection.Open();
				if(html_format == false)
				{
					if(debug == true)
					{
						file.WriteLine("Title LK tulokset");
					}
					else
					{
						file.WriteLine("LK tulokset");
					}
					file.WriteLine("Sijoitus,Nimi,Pisteet");
				}
				else
				{
					file.WriteLine("<h1>Vuoden lyhytkarvainen chihuahua " + yearTextBox.Text + "</h1>");
					file.WriteLine("<table border=\"0\" frame=\"VOID\" rules=\"NONE\" cellspacing=\"0\">");
					file.WriteLine("<thead>");
					file.WriteLine("<tr>");
					file.WriteLine("<td align=\"LEFT\" width=\"58\" height=\"18\">Sijoitus</td>");
					file.WriteLine("<td align=\"LEFT\" width=\"348\">Nimi</td>");
					file.WriteLine("<td align=\"LEFT\" width=\"61\">Pisteet</td>");
					file.WriteLine("</tr>");
					file.WriteLine("</thead>");
					file.WriteLine("<colgroup> <col width=\"58\" /> <col width=\"348\" /> <col width=\"61\" /></colgroup>");
					file.WriteLine("<tbody>");
				}
				LKDogResults.Sort((result, result2) => result2.points.CompareTo(result.points));
				PKDogResults.Sort((result, result2) => result2.points.CompareTo(result.points));
				progressBar1.PerformStep();
				LKPuppyResults.Sort((result, result2) => result2.points.CompareTo(result.points));
				PKPuppyResults.Sort((result, result2) => result2.points.CompareTo(result.points));
				LKVeteranResults.Sort((result, result2) => result2.points.CompareTo(result.points));
				PKVeteranResults.Sort((result, result2) => result2.points.CompareTo(result.points));
				LKParentResults.Sort((parent_result, parent_result2) => parent_result2.points.CompareTo(parent_result.points));
				PKParentResults.Sort((parent_result, parent_result2) => parent_result2.points.CompareTo(parent_result.points));
				LKBreederResults.Sort((result, result2) => result2.points.CompareTo(result.points));
				PKBreederResults.Sort((result, result2) => result2.points.CompareTo(result.points));
				progressBar1.PerformStep();
				
				foreach(dog_result dog in LKDogResults)
				{
					int smallest = 0;
					sql = "select * from dogs where id = @dog_id";
					command = new SQLiteCommand(sql, m_dbConnection);
					command.Parameters.AddWithValue("@dog_id", dog.dog_id);
					SQLiteDataReader reader = command.ExecuteReader();
					while(reader.Read() )
					{
						var test = reader["name"];
						name = test.ToString();
						
						var temp_breeder = reader["breeder"];
						
						var reverse = reader["reverse_order"];
						
						string breeder_name = temp_breeder.ToString();
						string trim_name = name;
						string new_name;
						if(reverse.Equals(1))
						{
							if(breeder_name != "")
							{
								new_name = trim_name.Remove(0, breeder_name.Length + 1);
								name = new_name + " " + breeder_name;
							}

						}
					}
					smallest = find_smallest(dog);
					points = dog.points;
					true_position++;
					if(prev_points != points)
					{
						position = true_position;
					}
					if(position > limit)
					{
						break;
					}
					prev_points = points;
					if(debug == true)
					{
						debug_string = ",debug: " + dog.show1 + ":" + dog.p1 + "   " + dog.show2  + ":" + dog.p2  + "   " + dog.show3 + ":" + dog.p3 + "   " + dog.show4 + ":" + dog.p4 + "   " + dog.show5 + ":" + dog.p5 + "   " + dog.show6 + ":" + dog.p6 + " "; 
					}
					else
					{
						debug_string = "";
					}
					if(html_format == false)
					{
						file.WriteLine(position + "," + name + "," + points.ToString() + " (" + dog.count + ") [" + smallest + "]" + debug_string);
					}
					else
					{
						file.WriteLine("<tr>");
						file.WriteLine("<td align=\"LEFT\" height=\"18\">" + position + "</td>");
						file.WriteLine("<td align=\"LEFT\">" + name + "</td>");
						file.WriteLine("<td align=\"LEFT\">" + points.ToString() + " (" + dog.count+ ")" + debug_string +"</td>");
						file.WriteLine("</tr>");
					}
				}
				if(html_format == false)
				{
					file.WriteLine("");
				}
				else
				{
					file.WriteLine("</tbody>");
					file.WriteLine("</table>");
				}
				// puppy
				position = 0;
				true_position = 0;
				prev_points = 0;
				if(html_format == false)
				{
					if(debug == true)
					{
						file.WriteLine("Title LK pentu tulokset");
					}
					else
					{
						file.WriteLine("LK pentu tulokset");
					}
					file.WriteLine("Sijoitus,Nimi,Pisteet");
				}
				else
				{
					file.WriteLine("<h1>Vuoden lyhytkarvainen pentu " + yearTextBox.Text + "</h1>");
					file.WriteLine("<table border=\"0\" frame=\"VOID\" rules=\"NONE\" cellspacing=\"0\">");
					file.WriteLine("<thead>");
					file.WriteLine("<tr>");
					file.WriteLine("<td align=\"LEFT\" width=\"58\" height=\"18\">Sijoitus</td>");
					file.WriteLine("<td align=\"LEFT\" width=\"348\">Nimi</td>");
					file.WriteLine("<td align=\"LEFT\" width=\"61\">Pisteet</td>");
					file.WriteLine("</tr>");
					file.WriteLine("</thead>");
					file.WriteLine("<colgroup> <col width=\"58\" /> <col width=\"348\" /> <col width=\"61\" /></colgroup>");
					file.WriteLine("<tbody>");
				}
				foreach (dog_result dog in LKPuppyResults)
				{
					
					sql = "select * from puppy where id = @dog_id";
					command = new SQLiteCommand(sql, m_dbConnection);
					command.Parameters.AddWithValue("@dog_id", dog.dog_id);
					SQLiteDataReader reader = command.ExecuteReader();
					while(reader.Read() )
					{
						var test = reader["name"];
						name = test.ToString();
					}
					
					points = dog.points;
					true_position++;
					if(prev_points != points)
					{
						position = true_position;
					}
					if(position > limit)
					{
						break;
					}
					prev_points = points;
					if(debug == true)
					{
						debug_string = ",debug: " + dog.show1 + ":" + dog.p1 + "   " + dog.show2  + ":" + dog.p2  + "   " + dog.show3 + ":" + dog.p3 + "   " + dog.show4 + ":" + dog.p4 + "   " + dog.show5 + ":" + dog.p5 + "   " + dog.show6 + ":" + dog.p6 + " "; 
					}
					else
					{
						debug_string = "";
					}
					if(html_format == false)
					{
						file.WriteLine(position + "," + name + "," + points.ToString() + " (" + dog.count + ")" + debug_string);
					}					
					else
					{
						file.WriteLine("<tr>");
						file.WriteLine("<td align=\"LEFT\" height=\"18\">" + position + "</td>");
						file.WriteLine("<td align=\"LEFT\">" + name + "</td>");
						file.WriteLine("<td align=\"LEFT\">" + points.ToString() + " (" + dog.count+ ")</td>");
						file.WriteLine("</tr>");
					}
				}
				if(html_format == false)
				{
					file.WriteLine("");
				}
				else
				{
					file.WriteLine("</tbody>");
					file.WriteLine("</table>");
				}
				// veteran
				position = 0;
				true_position = 0;
				prev_points = 0;
				if(html_format == false)
				{
					if(debug == true)
					{
						file.WriteLine("Title LK veteraani tulokset");
					}
					else
					{
						file.WriteLine("LK veteraani tulokset");
					}
					file.WriteLine("Sijoitus,Nimi,Pisteet");
				}
				else
				{
					file.WriteLine("<h1>Vuoden lyhytkarvainen veteraani " + yearTextBox.Text + "</h1>");
					file.WriteLine("<table border=\"0\" frame=\"VOID\" rules=\"NONE\" cellspacing=\"0\">");
					file.WriteLine("<thead>");
					file.WriteLine("<tr>");
					file.WriteLine("<td align=\"LEFT\" width=\"58\" height=\"18\">Sijoitus</td>");
					file.WriteLine("<td align=\"LEFT\" width=\"348\">Nimi</td>");
					file.WriteLine("<td align=\"LEFT\" width=\"61\">Pisteet</td>");
					file.WriteLine("</tr>");
					file.WriteLine("</thead>");
					file.WriteLine("<colgroup> <col width=\"58\" /> <col width=\"348\" /> <col width=\"61\" /></colgroup>");
					file.WriteLine("<tbody>");
				}
				foreach (dog_result dog in LKVeteranResults)
				{
					
					sql = "select * from veteran where id = @dog_id";
					command = new SQLiteCommand(sql, m_dbConnection);
					command.Parameters.AddWithValue("@dog_id", dog.dog_id);
					SQLiteDataReader reader = command.ExecuteReader();
					while(reader.Read() )
					{
						var test = reader["name"];
						name = test.ToString();
					}
					
					points = dog.points;
					true_position++;
					if(prev_points != points)
					{
						position = true_position;
					}
					if(position > limit)
					{
						break;
					}
					prev_points = points;
					if(debug == true)
					{
						debug_string = ",debug: " + dog.show1 + ":" + dog.p1 + "   " + dog.show2  + ":" + dog.p2  + "   " + dog.show3 + ":" + dog.p3 + "   " + dog.show4 + ":" + dog.p4 + "   " + dog.show5 + ":" + dog.p5 + "   " + dog.show6 + ":" + dog.p6 + " "; 
					}
					else
					{
						debug_string = "";
					}
					if(html_format == false)
					{
						file.WriteLine(position + "," + name + "," + points.ToString() + " (" + dog.count + ")" + debug_string);
					}
					else
					{
						file.WriteLine("<tr>");
						file.WriteLine("<td align=\"LEFT\" height=\"18\">" + position + "</td>");
						file.WriteLine("<td align=\"LEFT\">" + name + "</td>");
						file.WriteLine("<td align=\"LEFT\">" + points.ToString() + " (" + dog.count+ ")</td>");
						file.WriteLine("</tr>");
					}
				}
				if(html_format == false)
				{
					file.WriteLine("");
				}
				else
				{
					file.WriteLine("</tbody>");
					file.WriteLine("</table>");
				}
				//breeder
				position = 0;
				true_position = 0;
				prev_points = 0;
				if(html_format == false)
				{
					if(debug == true)
					{
						file.WriteLine("Title LK kasvattaja tulokset");	
					}
					else
					{
						file.WriteLine("LK kasvattaja tulokset");
					}
					file.WriteLine("Sijoitus,Nimi,Pisteet");
				}
				else
				{
					file.WriteLine("<h1>Vuoden lyhytkarvaisten kasvattaja " + yearTextBox.Text + "</h1>");
					file.WriteLine("<table border=\"0\" frame=\"VOID\" rules=\"NONE\" cellspacing=\"0\">");
					file.WriteLine("<thead>");
					file.WriteLine("<tr>");
					file.WriteLine("<td align=\"LEFT\" width=\"58\" height=\"18\">Sijoitus</td>");
					file.WriteLine("<td align=\"LEFT\" width=\"348\">Nimi</td>");
					file.WriteLine("<td align=\"LEFT\" width=\"61\">Pisteet</td>");
					file.WriteLine("</tr>");
					file.WriteLine("</thead>");
					file.WriteLine("<colgroup> <col width=\"58\" /> <col width=\"348\" /> <col width=\"61\" /></colgroup>");
					file.WriteLine("<tbody>");
				}
				foreach (breeder_result dog in LKBreederResults)
				{
					
					points = dog.points;
					if(dog.count > 2)
					{
						true_position++;
						if(prev_points != points)
						{
							position = true_position;
						}
						if(position > limit)
						{
							break;
						}
						prev_points = points;
						if(html_format == false)
						{
							file.WriteLine(position + "," + dog.name + "," + points.ToString() + " (" + dog.count + ")");
						}
						else
						{
							file.WriteLine("<tr>");
							file.WriteLine("<td align=\"LEFT\" height=\"18\">" + position + "</td>");
							file.WriteLine("<td align=\"LEFT\">" + dog.name + "</td>");
							file.WriteLine("<td align=\"LEFT\">" + points.ToString() + " (" + dog.count+ ")</td>");
							file.WriteLine("</tr>");
						}
					}
				}
				if(html_format == false)
				{
					file.WriteLine("");
				}
				else
				{
					file.WriteLine("</tbody>");
					file.WriteLine("</table>");
				}
				//parent
				position = 0;
				true_position = 0;
				prev_points = 0;
				if(html_format == false)
				{
					if(debug == true)
					{
						file.WriteLine("Title LK jalostuskoira tulokset");	
					}
					else
					{
						file.WriteLine("LK jalostuskoira tulokset");
					}
					file.WriteLine("Sijoitus,Nimi,Pisteet");
				}
				else
				{
					file.WriteLine("<h1>Vuoden lyhytkarvainen jalostuskoira " + yearTextBox.Text + "</h1>");
					file.WriteLine("<table border=\"0\" frame=\"VOID\" rules=\"NONE\" cellspacing=\"0\">");
					file.WriteLine("<thead>");
					file.WriteLine("<tr>");
					file.WriteLine("<td align=\"LEFT\" width=\"58\" height=\"18\">Sijoitus</td>");
					file.WriteLine("<td align=\"LEFT\" width=\"348\">Nimi</td>");
					file.WriteLine("<td align=\"LEFT\" width=\"61\">Pisteet</td>");
					file.WriteLine("</tr>");
					file.WriteLine("</thead>");
					file.WriteLine("<colgroup> <col width=\"58\" /> <col width=\"348\" /> <col width=\"61\" /></colgroup>");
					file.WriteLine("<tbody>");
				}
				foreach (parent_result dog in LKParentResults)
				{
					
					name = dog.name;
					points = dog.points;
					if(dog.count > 2)
					{
						true_position++;
						if(prev_points != points)
						{
							position = true_position;
						}
						if(position > limit)
						{
							break;
						}
						prev_points = points;
						if(html_format == false)
						{
							file.WriteLine(position + "," + name + "," + points.ToString() + " (" + dog.count + ")");
						}
						else
						{
							file.WriteLine("<tr>");
							file.WriteLine("<td align=\"LEFT\" height=\"18\">" + position + "</td>");
							file.WriteLine("<td align=\"LEFT\">" + name + "</td>");
							file.WriteLine("<td align=\"LEFT\">" + points.ToString() + " (" + dog.count+ ")</td>");
							file.WriteLine("</tr>");
						}
					}
				}
				if(html_format == false)
				{
					file.WriteLine("");
				}
				else
				{
					file.WriteLine("</tbody>");
					file.WriteLine("</table>");
				}
				
				if(debug == true)
				{
					string dog_named = "";
					string breeder = "";

					file.WriteLine("Title LK Breeder debug");
					foreach (dog_result dog in LKDogResults)
					{
						int id = dog.dog_id;
						int count = Math.Min(2, dog.count + dog.disc_count);

						sql = "select * from dogs where id = @dog_id";
						command = new SQLiteCommand(sql, m_dbConnection);
						command.Parameters.AddWithValue("@dog_id", id);
						SQLiteDataReader reader = command.ExecuteReader();
						while (reader.Read())
						{
							var test = reader["breeder"];
							var test2 = reader["name"];
							//breeder = (string)reader["breeder"];
							if(test == null)
							{
								breeder = "";
							}
							else
							{
								breeder = test.ToString();
							}
							dog_named = test2.ToString();
						}
						if(breeder != null && breeder != "")
						{
							//support only text format debug
							if(html_format == false)
							{
								file.WriteLine(dog_named + ":" + count );
							}
							
						}
					}

					file.WriteLine("");
					
				}
				// PK BEGINS HERE
				position = 0;
				true_position = 0;
				prev_points = 0;
				if(html_format == false)
				{
					if(debug == true)
					{
						file.WriteLine("Title PK tulokset");
					}
					else
					{
						file.WriteLine("PK tulokset");
					}
					file.WriteLine("Sijoitus,Nimi,Pisteet");
				}
				else
				{
					file.WriteLine("<h1>Vuoden pitkäkarvainen chihuahua " + yearTextBox.Text + "</h1>");
					file.WriteLine("<table border=\"0\" frame=\"VOID\" rules=\"NONE\" cellspacing=\"0\">");
					file.WriteLine("<thead>");
					file.WriteLine("<tr>");
					file.WriteLine("<td align=\"LEFT\" width=\"58\" height=\"18\">Sijoitus</td>");
					file.WriteLine("<td align=\"LEFT\" width=\"348\">Nimi</td>");
					file.WriteLine("<td align=\"LEFT\" width=\"61\">Pisteet</td>");
					file.WriteLine("</tr>");
					file.WriteLine("</thead>");
					file.WriteLine("<colgroup> <col width=\"58\" /> <col width=\"348\" /> <col width=\"61\" /></colgroup>");
					file.WriteLine("<tbody>");
				}

				foreach(dog_result dog in PKDogResults)
				{
					int smallest = 0;
					sql = "select * from dogs where id = @dog_id";
					command = new SQLiteCommand(sql, m_dbConnection);
					command.Parameters.AddWithValue("@dog_id", dog.dog_id);
					SQLiteDataReader reader = command.ExecuteReader();
					while(reader.Read() )
					{
						var test = reader["name"];
						name = test.ToString();
						var temp_breeder = reader["breeder"];
						
						var reverse = reader["reverse_order"];
						
						string breeder_name = temp_breeder.ToString();
						string trim_name = name;
						string new_name;
						if(reverse.Equals(1))
						{
							if(breeder_name != "")
							{
								new_name = trim_name.Remove(0, breeder_name.Length + 1);
								name = new_name + " " + breeder_name;
							}

						}
						
					}
					smallest = find_smallest(dog);
					points = dog.points;
					true_position++;
					if(prev_points != points)
					{
						position = true_position;
					}
					if(position > limit)
					{
						break;
					}
					prev_points = points;
					if(debug == true)
					{
						debug_string = ",debug: " + dog.show1 + ":" + dog.p1 + "   " + dog.show2  + ":" + dog.p2  + "   " + dog.show3 + ":" + dog.p3 + "   " + dog.show4 + ":" + dog.p4 + "   " + dog.show5 + ":" + dog.p5 + "   " + dog.show6 + ":" + dog.p6 + " "; 
					}
					else
					{
						debug_string = "";
					}
					if(html_format == false)
					{
						file.WriteLine(position + "," + name + "," + points.ToString() + " (" + dog.count + ") [" + smallest + "]" + debug_string);
					}
					else
					{
						file.WriteLine("<tr>");
						file.WriteLine("<td align=\"LEFT\" height=\"18\">" + position + "</td>");
						file.WriteLine("<td align=\"LEFT\">" + name + "</td>");
						file.WriteLine("<td align=\"LEFT\">" + points.ToString() + " (" + dog.count+ ")" + debug_string + "</td>");
						file.WriteLine("</tr>");
					}
					
				}
				if(html_format == false)
				{
					file.WriteLine("");
				}
				else
				{
					file.WriteLine("</tbody>");
					file.WriteLine("</table>");
				}
				// puppy

				position = 0;
				true_position = 0;
				prev_points = 0;
				if(html_format == false)
				{
					if(debug == true)
					{
						file.WriteLine("Title PK pentu tulokset");
					}					
					else
					{
						file.WriteLine("PK pentu tulokset");
					}
					file.WriteLine("Sijoitus,Nimi,Pisteet");
				}
				else
				{
					file.WriteLine("<h1>Vuoden pitkäkarvainen pentu " + yearTextBox.Text + "</h1>");
					file.WriteLine("<table border=\"0\" frame=\"VOID\" rules=\"NONE\" cellspacing=\"0\">");
					file.WriteLine("<thead>");
					file.WriteLine("<tr>");
					file.WriteLine("<td align=\"LEFT\" width=\"58\" height=\"18\">Sijoitus</td>");
					file.WriteLine("<td align=\"LEFT\" width=\"348\">Nimi</td>");
					file.WriteLine("<td align=\"LEFT\" width=\"61\">Pisteet</td>");
					file.WriteLine("</tr>");
					file.WriteLine("</thead>");
					file.WriteLine("<colgroup> <col width=\"58\" /> <col width=\"348\" /> <col width=\"61\" /></colgroup>");
					file.WriteLine("<tbody>");
				}
				foreach (dog_result dog in PKPuppyResults)
				{
					
					sql = "select * from puppy where id = @dog_id";
					command = new SQLiteCommand(sql, m_dbConnection);
					command.Parameters.AddWithValue("@dog_id", dog.dog_id);
					SQLiteDataReader reader = command.ExecuteReader();
					while(reader.Read() )
					{
						var test = reader["name"];
						name = test.ToString();
					}
					
					points = dog.points;
					true_position++;
					if(prev_points != points)
					{
						position = true_position;
					}
					if(position > limit)
					{
						break;
					}
					prev_points = points;
					if(debug == true)
					{
						debug_string = ",debug: " + dog.show1 + ":" + dog.p1 + "   " + dog.show2  + ":" + dog.p2  + "   " + dog.show3 + ":" + dog.p3 + "   " + dog.show4 + ":" + dog.p4 + "   " + dog.show5 + ":" + dog.p5 + "   " + dog.show6 + ":" + dog.p6 + " "; 
					}
					else
					{
						debug_string = "";
					}
					if(html_format == false)
					{
						file.WriteLine(position + "," + name + "," + points.ToString() + " (" + dog.count + ")" + debug_string);
					}						
					else
					{
						file.WriteLine("<tr>");
						file.WriteLine("<td align=\"LEFT\" height=\"18\">" + position + "</td>");
						file.WriteLine("<td align=\"LEFT\">" + name + "</td>");
						file.WriteLine("<td align=\"LEFT\">" + points.ToString() + " (" + dog.count+ ")</td>");
						file.WriteLine("</tr>");
					}
					
				}
				if(html_format == false)
				{
					file.WriteLine("");
				}
				else
				{
					file.WriteLine("</tbody>");
					file.WriteLine("</table>");
				}
				// veteran
				
				
				position = 0;
				true_position = 0;
				prev_points = 0;

				if(html_format == false)
				{
				if(debug == true)
					{
						file.WriteLine("Title PK veteraani tulokset");
					}
				else
				{
					file.WriteLine("PK veteraani tulokset");
				}
					file.WriteLine("Sijoitus,Nimi,Pisteet");
				}
				else
				{
					file.WriteLine("<h1>Vuoden pitkäkarvainen veteraani " + yearTextBox.Text + "</h1>");
					file.WriteLine("<table border=\"0\" frame=\"VOID\" rules=\"NONE\" cellspacing=\"0\">");
					file.WriteLine("<thead>");
					file.WriteLine("<tr>");
					file.WriteLine("<td align=\"LEFT\" width=\"58\" height=\"18\">Sijoitus</td>");
					file.WriteLine("<td align=\"LEFT\" width=\"348\">Nimi</td>");
					file.WriteLine("<td align=\"LEFT\" width=\"61\">Pisteet</td>");
					file.WriteLine("</tr>");
					file.WriteLine("</thead>");
					file.WriteLine("<colgroup> <col width=\"58\" /> <col width=\"348\" /> <col width=\"61\" /></colgroup>");
					file.WriteLine("<tbody>");
				}
				foreach (dog_result dog in PKVeteranResults)
				{
					
					sql = "select * from veteran where id = @dog_id";
					command = new SQLiteCommand(sql, m_dbConnection);
					command.Parameters.AddWithValue("@dog_id", dog.dog_id);
					SQLiteDataReader reader = command.ExecuteReader();
					while(reader.Read() )
					{
						var test = reader["name"];
						name = test.ToString();
					}
					
					points = dog.points;
					true_position++;
					if(prev_points != points)
					{
						position = true_position;
					}
					if(position > limit)
					{
						break;
					}
					prev_points = points;
					if(debug == true)
					{
						debug_string = ",debug: " + dog.show1 + ":" + dog.p1 + "   " + dog.show2  + ":" + dog.p2  + "   " + dog.show3 + ":" + dog.p3 + "   " + dog.show4 + ":" + dog.p4 + "   " + dog.show5 + ":" + dog.p5 + "   " + dog.show6 + ":" + dog.p6 + " "; 
					}
					else
					{
						debug_string = "";
					}
					if(html_format == false)
					{
						file.WriteLine(position + "," + name + "," + points.ToString() + " (" + dog.count + ")" + debug_string);
					}
					else
					{
						file.WriteLine("<tr>");
						file.WriteLine("<td align=\"LEFT\" height=\"18\">" + position + "</td>");
						file.WriteLine("<td align=\"LEFT\">" + name + "</td>");
						file.WriteLine("<td align=\"LEFT\">" + points.ToString() + " (" + dog.count+ ")</td>");
						file.WriteLine("</tr>");
					}
				}
				if(html_format == false)
				{
					file.WriteLine("");
				}
				else
				{
					file.WriteLine("</tbody>");
					file.WriteLine("</table>");
				}
				// breeder
				

				position = 0;
				true_position = 0;
				prev_points = 0;
				
				if(html_format == false)
				{
					if(debug == true)
					{
						file.WriteLine("Title PK kasvattaja tulokset");	
					}
					else
					{
						file.WriteLine("PK kasvattaja tulokset");
					}
					file.WriteLine("Sijoitus,Nimi,Pisteet");
				}
				else
				{
					file.WriteLine("<h1>Vuoden pitkäkarvaisten kasvattaja " + yearTextBox.Text + "</h1>");
					file.WriteLine("<table border=\"0\" frame=\"VOID\" rules=\"NONE\" cellspacing=\"0\">");
					file.WriteLine("<thead>");
					file.WriteLine("<tr>");
					file.WriteLine("<td align=\"LEFT\" width=\"58\" height=\"18\">Sijoitus</td>");
					file.WriteLine("<td align=\"LEFT\" width=\"348\">Nimi</td>");
					file.WriteLine("<td align=\"LEFT\" width=\"61\">Pisteet</td>");
					file.WriteLine("</tr>");
					file.WriteLine("</thead>");
					file.WriteLine("<colgroup> <col width=\"58\" /> <col width=\"348\" /> <col width=\"61\" /></colgroup>");
					file.WriteLine("<tbody>");
				}
				foreach (breeder_result dog in PKBreederResults)
				{
					
					points = dog.points;
					if(dog.count > 2)
					{
						true_position++;
						if(prev_points != points)
						{
							position = true_position;
						}
						if(position > limit)
						{
							break;
						}
						prev_points = points;
						if(html_format == false)
						{
							file.WriteLine(position + "," + dog.name + "," + points.ToString() + " (" + dog.count + ")");
						}
						else
						{
							file.WriteLine("<tr>");
							file.WriteLine("<td align=\"LEFT\" height=\"18\">" + position + "</td>");
							file.WriteLine("<td align=\"LEFT\">" + dog.name + "</td>");
							file.WriteLine("<td align=\"LEFT\">" + points.ToString() + " (" + dog.count+ ")</td>");
							file.WriteLine("</tr>");
						}
					}
				}
				if(html_format == false)
				{
					file.WriteLine("");
				}
				else
				{
					file.WriteLine("</tbody>");
					file.WriteLine("</table>");
				}
				
				// parents
				
				position = 0;
				true_position = 0;
				prev_points = 0;
				
				if(html_format == false)
				{
					if(debug == true)
					{
						file.WriteLine("Title PK jalostuskoira tulokset");	
					}
					else
					{
						file.WriteLine("PK jalostuskoira tulokset");
					}
					file.WriteLine("Sijoitus,Nimi,Pisteet");
				}
				else
				{
					file.WriteLine("<h1>Vuoden pitkäkarvainen jalostuskoira " + yearTextBox.Text + "</h1>");
					file.WriteLine("<table border=\"0\" frame=\"VOID\" rules=\"NONE\" cellspacing=\"0\">");
					file.WriteLine("<thead>");
					file.WriteLine("<tr>");
					file.WriteLine("<td align=\"LEFT\" width=\"58\" height=\"18\">Sijoitus</td>");
					file.WriteLine("<td align=\"LEFT\" width=\"348\">Nimi</td>");
					file.WriteLine("<td align=\"LEFT\" width=\"61\">Pisteet</td>");
					file.WriteLine("</tr>");
					file.WriteLine("</thead>");
					file.WriteLine("<colgroup> <col width=\"58\" /> <col width=\"348\" /> <col width=\"61\" /></colgroup>");
					file.WriteLine("<tbody>");
				}
				foreach (parent_result dog in PKParentResults)
				{
					
					name = dog.name;
					points = dog.points;
					if(dog.count > 2)
					{
						true_position++;
						if(prev_points != points)
						{
							position = true_position;
						}
						if(position > limit)
						{
							break;
						}
						prev_points = points;
						if(html_format == false)
						{
							file.WriteLine(position + "," + name + "," + points.ToString() + " (" + dog.count + ")");
						}
						else
						{
							file.WriteLine("<tr>");
							file.WriteLine("<td align=\"LEFT\" height=\"18\">" + position + "</td>");
							file.WriteLine("<td align=\"LEFT\">" + name + "</td>");
							file.WriteLine("<td align=\"LEFT\">" + points.ToString() + " (" + dog.count+ ")</td>");
							file.WriteLine("</tr>");
						}
					}
				}
				if(html_format == false)
				{
					file.WriteLine("");
				}
				else
				{
					file.WriteLine("</tbody>");
					file.WriteLine("</table>");
				}
				
				if(debug == true)
				{
					string dog_named = "";
					string breeder = "";

					file.WriteLine("Title PK Breeder debug");
					foreach (dog_result dog in PKDogResults)
					{
						int id = dog.dog_id;
						int count = Math.Min(2, dog.count + dog.disc_count);

						sql = "select * from dogs where id = @dog_id";
						command = new SQLiteCommand(sql, m_dbConnection);
						command.Parameters.AddWithValue("@dog_id", id);
						SQLiteDataReader reader = command.ExecuteReader();
						while (reader.Read())
						{
							var test = reader["breeder"];
							var test2 = reader["name"];
							//breeder = (string)reader["breeder"];
							if(test == null)
							{
								breeder = "";
							}
							else
							{
								breeder = test.ToString();
							}
							dog_named = test2.ToString();
						}
						if(breeder != null && breeder != "")
						{
							//support only text format debug
							if(html_format == false)
							{
								file.WriteLine(dog_named + ":" + count );
							}
							
						}
					}

					file.WriteLine("");
					
				}
				
				m_dbConnection.Close();
			}
			MessageBox.Show("done");
			progressBar1.Hide();
			
		}
		
		int find_smallest(dog_result dog)
		{
			int smallest = dog.p1;
			if(smallest > dog.p2)
			{
				smallest = dog.p2;
			}
			if(smallest > dog.p3)
			{
				smallest = dog.p3;
			}
			if(smallest > dog.p4)
			{
				smallest = dog.p4;
			}
			if(smallest > dog.p5)
			{
				smallest = dog.p5;
			}
			if(smallest > dog.p6)
			{
				smallest = dog.p6;
			}
		return smallest;	
		}
		
		void calculate_veteran(ref List<dog_result> Veteran, int coat_id)
		{
			SQLiteConnection m_dbConnection;
			SQLiteCommand command;
			string sql;
			int rop_id;
			int vsp_id;
			string judge;
			string show;
			int dog_count;
			
		
			m_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;foreign keys=true;");
			m_dbConnection.Open();
			sql = "select * from veteran_shows where coat = @dog_coat";
			command = new SQLiteCommand(sql, m_dbConnection);
			command.Parameters.AddWithValue("@dog_coat", coat_id);
			SQLiteDataReader reader = command.ExecuteReader();
			while(reader.Read() )
			{
				var test = reader["rop_vet"];
				var test2 = reader["vsp_vet"];
				var test3 = reader["judge"];
				var test_count = reader["veteran_count"];
				show = (string)reader["show"];
				dog_count = Convert.ToInt32(test_count);
				rop_id = Convert.ToInt32(test);
				vsp_id = Convert.ToInt32(test2);
				judge = test3.ToString();

				add_veteran_result(ref Veteran, rop_id, judge, dog_count, 3, show);
				add_veteran_result(ref Veteran, vsp_id, judge, dog_count, 2, show);

			}
			foreach (dog_result element in Veteran) 
			{
			int points = element.points;	
			}
			m_dbConnection.Close();
		}
		
		
		void add_veteran_result(ref List<dog_result> Veteran, int dog_id, string judge, int dog_count, int points, string show)
		{
			dog_result result;
			dog_result updated_result;
			if(dog_id != 0)
			{
				int index = Veteran.FindIndex(dog_result=>dog_result.dog_id == dog_id);
				result = Veteran.Find(dog_result=>dog_result.dog_id == dog_id);
				// extra points
				if(dog_count > 3)
				{
					points = points + dog_count - 3;
				}

				if(index == -1)
				{
					result = new dog_result();
					result.dog_id = dog_id;
					result.j1 = judge;
					result.p1 = points;
					result.show1 = show;
					result.p2 = 0;
					result.p3 = 0;
					result.p4 = 0;
					result.p5 = 0;
					result.p6 = 0;
					result.count = 1;
					result.points = points;
					Veteran.Add(result);
					
				}
				else
				{
					// dog exists
					// find same judge
					if(result.j1.Equals(judge))
					{
						// j1 match
						if(points > result.p1)
						{
							result.p1 = points;
							result.show1 = show;
						}
						result.points = result_sum(result.p1, result.p2, result.p3, result.p4, result.p5, result.p6);
						Veteran[index] = result;
						
					}
					else if(result.j2 != null && result.j2.Equals(judge))
					{
						// j2 match
						if(points > result.p2)
						{
							result.p2 = points;
							result.show2 = show;
						}
						result.points = result_sum(result.p1, result.p2, result.p3, result.p4, result.p5, result.p6);
						Veteran[index] = result;
					}
					else if(result.j3 != null && result.j3.Equals(judge))
					{
						// j3 match
						if(points > result.p3)
						{
							result.p3 = points;
							result.show3 = show;
						}
						result.points = result_sum(result.p1, result.p2, result.p3, result.p4, result.p5, result.p6);
						Veteran[index] = result;
					}
					else if(result.j4 != null && result.j4.Equals(judge))
					{
						// j4 match
						if(points > result.p4)
						{
							result.p4 = points;
							result.show4 = show;
						}
						result.points = result_sum(result.p1, result.p2, result.p3, result.p4, result.p5, result.p6);
						Veteran[index] = result;
					}
					else if(result.j5 != null && result.j5.Equals(judge))
					{
						// j5 match
						if(points > result.p5)
						{
							result.p5 = points;
							result.show5 = show;
						}
						result.points = result_sum(result.p1, result.p2, result.p3, result.p4, result.p5, result.p6);
						Veteran[index] = result;
					}
					// TODO: change here if 6 results counted
					else if(result.j6 != null && result.j6.Equals(judge))
					{
						// j6 match
						if(points > result.p6)
						{
							result.p6 = points;
							result.show6 = show;
						}
						result.points = result_sum(result.p1, result.p2, result.p3, result.p4, result.p5, result.p6);
						Veteran[index] = result;
					}
					else
					{
						// no judge match
						updated_result = replace_smallest_vet(ref result, points, judge, show);
						updated_result.points = result_sum(result.p1, result.p2, result.p3, result.p4, result.p5, result.p6);
						Veteran[index] = updated_result;
						
					}
				}
			}
		}
				
		dog_result replace_smallest_vet(ref dog_result result, int points, string judge, string show)
		{
			int smallest = result.p1;
			int index = 1;
			if(result.count < 6)
			   {
			   	result.count++;
			   }
			if(result.p2 < smallest)
			{
				index = 2;
				smallest = result.p2;
			}
			if(result.p3 < smallest)
			{
				index = 3;
				smallest = result.p3;
			}
			if(result.p4 < smallest)
			{
				index = 4;
				smallest = result.p4;
			}
			if(result.p5 < smallest)
			{
				index = 5;
				smallest = result.p5;
			}
			// TODO: change here if 6 counted
			if(result.p6 < smallest)
			{
				index = 6;
				smallest = result.p6;
			}
			if(smallest < points)
			{
				switch(index)
				{
					case 1:
						result.p1 = points;
						result.j1 = judge;
						result.show1 = show;
						break;
						
					case 2:
						result.p2 = points;
						result.j2 = judge;
						result.show2 = show;
						break;
						
					case 3:
						result.p3 = points;
						result.j3 = judge;
						result.show3 = show;
						break;
						
					case 4:
						result.p4 = points;
						result.j4 = judge;
						result.show4 = show;
						break;
						
					case 5:
						result.p5 = points;
						result.j5 = judge;
						result.show5 = show;
						break;
					case 6:
						result.p6 = points;
						result.j6 = judge;
						result.show6 = show;
						break;
				}
			}
		return result;
		}


		void calculate_puppy(ref List<dog_result> Puppy, int coat_id)
		{
			SQLiteConnection m_dbConnection;
			SQLiteCommand command;
			string sql;
			int rop_id;
			int vsp_id;
			string judge;
			string show;
			int dog_count;

			m_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;foreign keys=true;");
			m_dbConnection.Open();
			sql = "select * from puppy_shows where coat = @dog_coat";
			command = new SQLiteCommand(sql, m_dbConnection);
			command.Parameters.AddWithValue("@dog_coat", coat_id);
			SQLiteDataReader reader = command.ExecuteReader();
			while(reader.Read() )
			{
				var test = reader["rop_puppy"];
				var test2 = reader["vsp_puppy"];
				var test3 = reader["judge"];
				var test_count = reader["puppy_count"];
				show = (string)reader["show"];
				dog_count = Convert.ToInt32(test_count);
				rop_id = Convert.ToInt32(test);
				vsp_id = Convert.ToInt32(test2);
				judge = test3.ToString();

				add_puppy_result(ref Puppy, rop_id, judge, dog_count, 3, show);
				add_puppy_result(ref Puppy, vsp_id, judge, dog_count, 2, show);

			}
			foreach (dog_result element in Puppy) 
			{
			int points = element.points;
			}
			m_dbConnection.Close();
		}
		
		
		void add_puppy_result(ref List<dog_result> Puppy, int dog_id, string judge, int dog_count, int points, string show)
		{
			dog_result result;
			dog_result updated_result;
			if(dog_id != 0)
			{
				int index = Puppy.FindIndex(dog_result=>dog_result.dog_id == dog_id);
				result = Puppy.Find(dog_result=>dog_result.dog_id == dog_id);
				// extra points
				if((points == 3) && (dog_count > 5))
				{
					points = 5;
				}
				if((points == 2) && (dog_count > 5))
				{
					points = 3;
				}
				if(index == -1)
				{
					result = new dog_result();
					result.dog_id = dog_id;
					result.j1 = judge;
					result.p1 = points;
					result.show1 = show;
					result.p2 = 0;
					result.p3 = 0;
					result.p4 = 0;
					result.p5 = 0;
					result.p6 = 0;
					result.count = 1;
					result.points = points;
					Puppy.Add(result);
					
				}
				else
				{
					// dog exists
					// find same judge
					if(result.j1.Equals(judge))
					{
						// j1 match
						if(points > result.p1)
						{
							result.p1 = points;
							result.show1 = show;
						}
						result.points = result_sum(result.p1, result.p2, result.p3, result.p4, result.p5, result.p6);
						Puppy[index] = result;
						
					}
					else if(result.j2 != null && result.j2.Equals(judge))
					{
						// j2 match
						if(points > result.p2)
						{
							result.p2 = points;
							result.show2 = show;
						}
						result.points = result_sum(result.p1, result.p2, result.p3, result.p4, result.p5, result.p6);
						Puppy[index] = result;
					}
					else if(result.j3 != null && result.j3.Equals(judge))
					{
						// j3 match
						if(points > result.p3)
						{
							result.p3 = points;
							result.show3 = show;
						}
						result.points = result_sum(result.p1, result.p2, result.p3, result.p4, result.p5, result.p6);
						Puppy[index] = result;
					}
					else if(result.j4 != null && result.j4.Equals(judge))
					{
						// j4 match
						if(points > result.p4)
						{
							result.p4 = points;
							result.show4 = show;
						}
						result.points = result_sum(result.p1, result.p2, result.p3, result.p4, result.p5, result.p6);
						Puppy[index] = result;
					}
					else if(result.j5 != null && result.j5.Equals(judge))
					{
						// j5 match
						if(points > result.p5)
						{
							result.p5 = points;
							result.show5 = show;
						}
						result.points = result_sum(result.p1, result.p2, result.p3, result.p4, result.p5, result.p6);
						Puppy[index] = result;
					}
					else if(result.j6 != null && result.j6.Equals(judge))
					{
						// j6 match
						if(points > result.p6)
						{
							result.p6 = points;
							result.show6 = show;
						}
						result.points = result_sum(result.p1, result.p2, result.p3, result.p4, result.p5, result.p6);
						Puppy[index] = result;
					}
					else
					{
						// no judge match
						updated_result = replace_smallest_puppy(ref result, points, judge, show);
						updated_result.points = result_sum(result.p1, result.p2, result.p3, result.p4, result.p5, result.p6);
						Puppy[index] = updated_result;
						
					}
				}
			}
		}
				
		dog_result replace_smallest_puppy(ref dog_result result, int points, string judge, string show)
		{
			int smallest = result.p1;
			int index = 1;
			if(result.count < 6)
			   {
			   	result.count++;
			   }
			if(result.p2 < smallest)
			{
				index = 2;
				smallest = result.p2;
			}
			if(result.p3 < smallest)
			{
				index = 3;
				smallest = result.p3;
			}
			if(result.p4 < smallest)
			{
				index = 4;
				smallest = result.p4;
			}
			if(result.p5 < smallest)
			{
				index = 5;
				smallest = result.p5;
			}
			if(result.p6 < smallest)
			{
				index = 6;
				smallest = result.p6;
			}

			if(smallest < points)
			{
				switch(index)
				{
					case 1:
						result.p1 = points;
						result.j1 = judge;
						result.show1 = show;
						break;
						
					case 2:
						result.p2 = points;
						result.j2 = judge;
						result.show2 = show;
						break;
						
					case 3:
						result.p3 = points;
						result.j3 = judge;
						result.show3 = show;
						break;
						
					case 4:
						result.p4 = points;
						result.j4 = judge;
						result.show4 = show;
						break;
					case 5:
						result.p5 = points;
						result.j5 = judge;
						result.show5 = show;
						break;
						
					case 6:
						result.p6 = points;
						result.j6 = judge;
						result.show6 = show;
						break;	
				}
			}
		return result;
		}

		
		void add_breeder_class(ref List<breeder_result> Breeder, int coat_id, bool debug, System.IO.StreamWriter file)
		{
			SQLiteConnection m_dbConnection;
			string sql;
			string breeder_name;
			string breeder2_name;
			string breeder3_name;
			string breeder4_name;
			string show;
			int breeder_count;
			int extra_points = 0;
			int index;
			breeder_result ResultElement;
			SQLiteCommand command;
			
		
			{
				if(debug == true)
				{
					if(coat_id == 0)
					{
						file.WriteLine("Title Breederclass debug LK");
					}
					else
					{
						file.WriteLine("Title Breederclass debug PK");
					}	
				}
				m_dbConnection =
					new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;foreign keys=true;");
				m_dbConnection.Open();
				sql = "select * from breeder where coat = @dog_coat";
				command = new SQLiteCommand(sql, m_dbConnection);
				command.Parameters.AddWithValue("@dog_coat", coat_id);
				SQLiteDataReader reader = command.ExecuteReader();
				while(reader.Read() )
				{
					var test = reader["rop_breeder"];
					var test2 = reader["breeder2"];
					var test3 = reader["breeder3"];
					var test4 = reader["breeder4"];
					var test_count = reader["count"];
					var test_show = reader["show"];
					breeder_count = Convert.ToInt32(test_count);
					breeder_name = test.ToString();
					breeder2_name = test2.ToString();
					breeder3_name = test3.ToString();
					breeder4_name = test4.ToString();
					show = test_show.ToString();
					
					if(breeder_count > 2)
					{
						extra_points = breeder_count;
					}
					else
					{
						extra_points = 0;
					}
					if(debug == true)
					{
						file.WriteLine("title " + show + " extra points:" + extra_points);
					}
					index = Breeder.FindIndex(result=>result.name == breeder_name);
					if(index != -1)
					{
						// update existing index
						ResultElement = Breeder[index];
						ResultElement.points += (2 + extra_points);
						Breeder[index] = ResultElement;
						if(debug == true)
						{
							file.WriteLine(breeder_name + " :" + (2 + extra_points));
						}
					}
					else if(debug == true)
					{
						file.WriteLine("discarding " + breeder_name);
					}
					if((breeder2_name != "") && (breeder_count > 1))
					{
						index = Breeder.FindIndex(result=>result.name == breeder2_name);
						if(index != -1)
						{
							// update existing index
							ResultElement = Breeder[index];
							if(extra_points > 0)
							{
								ResultElement.points += (1 + extra_points - 1);
								if(debug == true)
								{
									file.WriteLine(breeder2_name + " :" + (1 + extra_points - 1));
								}
							}
							else
							{
								ResultElement.points += 1;
								if(debug == true)
								{
									file.WriteLine(breeder2_name + " :" + (1));
								}
							}
							Breeder[index] = ResultElement;
						}
						else if(debug == true)
						{
							file.WriteLine("discarding " + breeder2_name);
						}
					}
					if((breeder3_name != "") && (breeder_count > 2))
					{
						index = Breeder.FindIndex(result=>result.name == breeder3_name);
						if(index != -1)
						{
							// update existing index
							ResultElement = Breeder[index];
							ResultElement.points += (extra_points - 2);
							Breeder[index] = ResultElement;
							if(debug == true)
								{
									file.WriteLine(breeder3_name + " :" + (extra_points - 2));
								}
						}
						else if(debug == true)
						{
							file.WriteLine("discarding " + breeder3_name);
						}
					}
					if((breeder4_name != "") && (breeder_count > 3))
					{
						index = Breeder.FindIndex(result=>result.name == breeder4_name);
						if(index != -1)
						{
							// update existing index
							ResultElement = Breeder[index];
							ResultElement.points += (extra_points - 3);
							Breeder[index] = ResultElement;
							if(debug == true)
								{
									file.WriteLine(breeder4_name + " :" + (extra_points - 3));
								}
						}
						else if(debug == true)
						{
							file.WriteLine("discarding " + breeder4_name);
						}
					}
				}
			}
			if(debug == true)
			{
				file.WriteLine("");
			}
			m_dbConnection.Close();
		}
		
		void calculate_breeders(ref List<dog_result> Results, ref List<breeder_result> Breeder)
		{
			int id;
			int count;
			string breeder = "";
			int index;
			breeder_result ResultElement;
			
			SQLiteConnection m_dbConnection;
			string sql;
			SQLiteCommand command;
			m_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;foreign keys=true;");
			m_dbConnection.Open();
			
			foreach (dog_result dog in Results)
			{
				id = dog.dog_id;
				count = Math.Min(2, dog.count + dog.disc_count);

				sql = "select * from dogs where id = @dog_id";
				command = new SQLiteCommand(sql, m_dbConnection);
				command.Parameters.AddWithValue("@dog_id", id);
				SQLiteDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					var test = reader["breeder"];
					//breeder = (string)reader["breeder"];
					if(test == null)
					{
						breeder = "";
					}
					else
					{
						breeder = test.ToString();
					}
				}
				if(breeder != null && breeder != "")
				{
					index = Breeder.FindIndex(result=>result.name == breeder);
					if(index == -1)
					{
						// not found
						ResultElement = new breeder_result();
						ResultElement.name = breeder;
						ResultElement.count = 1;
						ResultElement.points = count;
						Breeder.Add(ResultElement);
					}
					else
					{
						// update existing index
						ResultElement = Breeder[index];
						ResultElement.count++;
						ResultElement.points += count;
						Breeder[index] = ResultElement;
					}
					
				}
			}

			m_dbConnection.Close();
		}
		
	
		void calculate_parents(ref List<dog_result> Results, ref List<parent_result> LKParent, ref List<parent_result> PKParent, bool debug)
		{
			int id;
			int count;
			string sire = "";
			string dam = "";
			int sire_coat = 0;
			int dam_coat = 0;
			int index;
			parent_result ParentResultElement;
			
			SQLiteConnection m_dbConnection;
			string sql;
			SQLiteCommand command;
			m_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;foreign keys=true;");
			m_dbConnection.Open();
			File.Delete("parent_debug.txt");
			using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"parent_debug.txt", true, Encoding.UTF8))
			{
			//TODO: debug parents here
			foreach (dog_result dog in Results)
			{
				id = dog.dog_id;
				count = Math.Min(2, dog.count + dog.disc_count);

				sql = "select * from dogs where id = @dog_id";
				command = new SQLiteCommand(sql, m_dbConnection);
				command.Parameters.AddWithValue("@dog_id", id);
				SQLiteDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					sire = (string)reader["sire"];
					dam = (string)reader["dam"];
					sire_coat = Convert.ToInt32(reader["sirecoat"]);
					dam_coat = Convert.ToInt32(reader["damcoat"]);
				}
				if(sire != "n/a" && dam != "n/a")
				{
					if(debug == true)
					{
						file.WriteLine(sire + " :" + GetDogNameById(dog.dog_id) + "(" + count + ")\n");
						file.WriteLine(dam + " :" + GetDogNameById(dog.dog_id) + "(" + count + ")\n");
					}
					if(sire_coat == 0)
					{
						// sire to LKParent
						index = LKParent.FindIndex(parent_result=>parent_result.name == sire);
						if(index == -1)
						{
							// not found
							ParentResultElement = new parent_result();
							ParentResultElement.name = sire;
							ParentResultElement.count = 1;
							ParentResultElement.points = count;
							LKParent.Add(ParentResultElement);
						}
						else
						{
							// update existing index
							ParentResultElement = LKParent[index];
							ParentResultElement.count++;
							ParentResultElement.points += count;
							LKParent[index] = ParentResultElement;
						}
					}
					else
					{
						// sire to PKParent
						index = PKParent.FindIndex(parent_result=>parent_result.name == sire);
						if(index == -1)
						{
							// not found
							ParentResultElement = new parent_result();
							ParentResultElement.name = sire;
							ParentResultElement.count = 1;
							ParentResultElement.points = count;
							PKParent.Add(ParentResultElement);
						}
						else
						{
							// update existing index
							ParentResultElement = PKParent[index];
							ParentResultElement.count++;
							ParentResultElement.points += count;
							PKParent[index] = ParentResultElement;
						}
					}
					
					if(dam_coat == 0)
					{
						// dam to LKParent
						index = LKParent.FindIndex(parent_result=>parent_result.name == dam);
						if(index == -1)
						{
							// not found
							ParentResultElement = new parent_result();
							ParentResultElement.name = dam;
							ParentResultElement.count = 1;
							ParentResultElement.points = count;
							LKParent.Add(ParentResultElement);
						}
						else
						{
							// update existing index
							ParentResultElement = LKParent[index];
							ParentResultElement.count++;
							ParentResultElement.points += count;
							LKParent[index] = ParentResultElement;
						}
					}
					else
					{
						// dam to PKParent
						index = PKParent.FindIndex(parent_result=>parent_result.name == dam);
						if(index == -1)
						{
							// not found
							ParentResultElement = new parent_result();
							ParentResultElement.name = dam;
							ParentResultElement.count = 1;
							ParentResultElement.points = count;
							PKParent.Add(ParentResultElement);
						}
						else
						{
							// update existing index
							ParentResultElement = PKParent[index];
							ParentResultElement.count++;
							ParentResultElement.points += count;
							PKParent[index] = ParentResultElement;
						}
					}
					
				}
			}
			}
			m_dbConnection.Close();
		}
		
		void calculate_results(ref List<dog_result> DogResults, int coat_id)
		{
			int rop;
			int vsp;
			int pu2;
			int pu3;
			int pu4;
			int pn2;
			int pn3;
			int pn4;
			string judge;
			int int_show;
			int dog_amount;
			string show;
						
			SQLiteConnection m_dbConnection;
			string sql;
			SQLiteCommand command;
			m_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;foreign keys=true;");
			m_dbConnection.Open();

			sql = "select * from shows where coat = @coat";
			command = new SQLiteCommand(sql, m_dbConnection);
			command.Parameters.AddWithValue("@coat", coat_id);
			SQLiteDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				rop = Convert.ToInt32(reader["rop"]);
				vsp = Convert.ToInt32(reader["vsp"]);
				pu2 = Convert.ToInt32(reader["pu2"]);
				pu3 = Convert.ToInt32(reader["pu3"]);
				pu4 = Convert.ToInt32(reader["pu4"]);
				pn2 = Convert.ToInt32(reader["pn2"]);
				pn3 = Convert.ToInt32(reader["pn3"]);
				pn4 = Convert.ToInt32(reader["pn4"]);
				show = (string)reader["show"];
				judge = (string)reader["judge"];
				int_show = Convert.ToInt32(reader["int_show"]);
				dog_amount = Convert.ToInt32(reader["dog_count"]);
				add_result(ref DogResults, rop, int_show, dog_amount, 8, judge, show);
				add_result(ref DogResults, vsp, int_show, dog_amount, 7, judge, show);
				add_result(ref DogResults, pu2, int_show, dog_amount, 6, judge, show);
				add_result(ref DogResults, pu3, int_show, dog_amount, 4, judge, show);
				add_result(ref DogResults, pu4, int_show, dog_amount, 2, judge, show);
				add_result(ref DogResults, pn2, int_show, dog_amount, 6, judge, show);
				add_result(ref DogResults, pn3, int_show, dog_amount, 4, judge, show);
				add_result(ref DogResults, pn4, int_show, dog_amount, 2, judge, show);
			}
			
			m_dbConnection.Close();	
		}
	
		

		void add_result(ref List<dog_result> DogResults, int dog_id, int int_show, int dog_amount, int base_points, string judge, string show)
		{
			dog_result result;
			dog_result updated_result;
			int points;
			if(dog_amount > 60)
			{
				dog_amount = 60;
			}
			if(dog_id != 0)
			{
				points = base_points + 2 * int_show + (int)(dog_amount/10);
				int index = DogResults.FindIndex(dog_result=>dog_result.dog_id == dog_id);
				result = DogResults.Find(dog_result=>dog_result.dog_id == dog_id);
				if(index == -1)
				{
					result = new dog_result();
					result.dog_id = dog_id;
					result.j1 = judge;
					result.p1 = points;
					result.show1 = show;
					result.p2 = 0;
					result.p3 = 0;
					result.p4 = 0;
					result.p5 = 0;
					result.p6 = 0;
					result.count = 1;
					result.disc_count = 0;
					result.points = points;
					DogResults.Add(result);
										
				}
				else
				{
					// dog exists
					// find same judge
					if(result.j1.Equals(judge))
					{
						// j1 match
						if(points > result.p1)
						{
							result.p1 = points;
							result.show1 = show;
						}
						
						result.disc_count++;
						result.points = result_sum(result.p1, result.p2, result.p3, result.p4, result.p5, result.p6);
						DogResults[index] = result;
					}
					else if(result.j2 != null && result.j2.Equals(judge))
					{
						// j2 match
						if(points > result.p2)
						{
							result.p2 = points;
							result.show2 = show;
						}
						
						result.disc_count++;
						result.points = result_sum(result.p1, result.p2, result.p3, result.p4, result.p5, result.p6);
						DogResults[index] = result;
					}
					else if(result.j3 != null && result.j3.Equals(judge))
					{
						// j3 match
						if(points > result.p3)
						{
							result.p3 = points;
							result.show3 = show;
						}
						
						result.disc_count++;
						result.points = result_sum(result.p1, result.p2, result.p3, result.p4, result.p5, result.p6);
						DogResults[index] = result;
					}
					else if(result.j4 != null && result.j4.Equals(judge))
					{
						// j4 match
						if(points > result.p4)
						{
							result.p4 = points;
							result.show4 = show;
						}
						
						result.disc_count++;
						result.points = result_sum(result.p1, result.p2, result.p3, result.p4, result.p5, result.p6);
						DogResults[index] = result;
					}
					else if(result.j5 != null && result.j5.Equals(judge))
					{
						// j5 match
						if(points > result.p5)
						{
							result.p5 = points;
							result.show5 = show;
						}
						
						result.disc_count++;
						result.points = result_sum(result.p1, result.p2, result.p3, result.p4, result.p5, result.p6);
						DogResults[index] = result;
					}
					else if(result.j6 != null && result.j6.Equals(judge))
					{
						// j6 match
						if(points > result.p6)
						{
							result.p6 = points;
							result.show6 = show;
						}
						
						result.disc_count++;
						result.points = result_sum(result.p1, result.p2, result.p3, result.p4, result.p5, result.p6);
						DogResults[index] = result;
					}
					else
					{
						// no judge match
						updated_result = replace_smallest(ref result, points, judge, show);
						updated_result.points = result_sum(result.p1, result.p2, result.p3, result.p4, result.p5, result.p6);
						DogResults[index] = updated_result;
						
					}

					
				}

			}
		}
		
		int result_sum(int p1, int p2, int p3, int p4, int p5, int p6)
		{
			return (p1 + p2 + p3 + p4 + p5 + p6);
		}

		dog_result replace_smallest(ref dog_result result, int points, string judge, string show)
		{
			int smallest = result.p1;
			int index = 1;
			if(result.count < 6)
			   {
			   	result.count++;
			   }
			if(result.p2 < smallest)
			{
				index = 2;
				smallest = result.p2;
			}
			if(result.p3 < smallest)
			{
				index = 3;
				smallest = result.p3;
			}
			if(result.p4 < smallest)
			{
				index = 4;
				smallest = result.p4;
			}
			if(result.p5 < smallest)
			{
				index = 5;
				smallest = result.p5;
			}
			if(result.p6 < smallest)
			{
				index = 6;
				smallest = result.p6;
			}
			if(smallest < points)
			{
				switch(index)
				{
					case 1:
						result.p1 = points;
						result.j1 = judge;
						result.show1 = show;
						break;
						
					case 2:
						result.p2 = points;
						result.j2 = judge;
						result.show2 = show;
						break;
						
					case 3:
						result.p3 = points;
						result.j3 = judge;
						result.show3 = show;
						break;
						
					case 4:
						result.p4 = points;
						result.j4 = judge;
						result.show4 = show;
						break;
						
					case 5:
						result.p5 = points;
						result.j5 = judge;
						result.show5 = show;
						break;
						
					case 6:
						result.p6 = points;
						result.j6 = judge;
						result.show6 = show;
						break;
				}
			}
		return result;
		}
		
		void AddPuppyShowButtonClick(object sender, EventArgs e)
		{
			AddPuppyShow addShowDialog = new AddPuppyShow(false, 0, "");
			addShowDialog.ShowDialog();			
		}
		
		void AddVeteranShowButtonClick(object sender, EventArgs e)
		{
			AddVeteranShow addShowDialog = new AddVeteranShow(false, 0, "");
			addShowDialog.ShowDialog();			
		}
		
		void AddBreederShowButtonClick(object sender, EventArgs e)
		{
			AddBreederShow addShowDialog = new AddBreederShow(false, 0, "");
			addShowDialog.ShowDialog();
		}
		
		void CalculateAllButtonClick(object sender, EventArgs e)
		{
			calculate(0, false, false);
		}
		
		void AboutButtonClick(object sender, EventArgs e)
		{
			MessageBox.Show("Vuoden Chihu pistelasku \nv0.11.15.05.2017 \n2015 säännöt \n© tkumento@gmail.com", "Vuoden Chihu - About");
		}
		
		void ModifyButtonClick(object sender, EventArgs e)
		{
			update updateDialog = new update();
			updateDialog.ShowDialog();
		}
		
		void dump_results()
		{
			File.Delete("data.txt");
			using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"data.txt", true, Encoding.UTF8))
			{
				int rop;
				int vsp;
				int pu2;
				int pu3;
				int pu4;
				int pn2;
				int pn3;
				int pn4;
				string judge;
				int int_show;
				int dog_amount;
				int coat;
				string coat_string;
				string show;
				List<string> dog_names = new List<string>();
				
				SQLiteConnection m_dbConnection;
				string sql;
				SQLiteCommand command;
				file.WriteLine("Results");
				
				m_dbConnection =
					new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;foreign keys=true;");
				m_dbConnection.Open();

			
				sql = "select * from shows";
				command = new SQLiteCommand(sql, m_dbConnection);
				
				SQLiteDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					rop = Convert.ToInt32(reader["rop"]);
					vsp = Convert.ToInt32(reader["vsp"]);
					pu2 = Convert.ToInt32(reader["pu2"]);
					pu3 = Convert.ToInt32(reader["pu3"]);
					pu4 = Convert.ToInt32(reader["pu4"]);
					pn2 = Convert.ToInt32(reader["pn2"]);
					pn3 = Convert.ToInt32(reader["pn3"]);
					pn4 = Convert.ToInt32(reader["pn4"]);
					judge = (string)reader["judge"];
					int_show = Convert.ToInt32(reader["int_show"]);
					dog_amount = Convert.ToInt32(reader["dog_count"]);
					coat = Convert.ToInt32(reader["coat"]);
					if(coat == 0)
					{
						coat_string = "LK";
					}
					else
					{
						coat_string = "PK";
					}
					show =  (string)reader["show"];
					file.WriteLine(show);
					if(int_show == 1)
					{
						file.WriteLine("INT show");
					}
					file.WriteLine(coat_string);
					file.WriteLine(judge);
					file.WriteLine("Dog amount: " + dog_amount);
					file.WriteLine("ROP: " + convert_id_to_name(rop));
					file.WriteLine("VSP: " + convert_id_to_name(vsp));
					file.WriteLine("PU2: " + convert_id_to_name(pu2));
					file.WriteLine("PU3: " + convert_id_to_name(pu3));
					file.WriteLine("PU4: " + convert_id_to_name(pu4));
					file.WriteLine("PN2: " + convert_id_to_name(pn2));
					file.WriteLine("PN3: " + convert_id_to_name(pn3));
					file.WriteLine("PN4: " + convert_id_to_name(pn4));
					file.WriteLine("\n");
				}
				file.WriteLine("\n");
				file.WriteLine("Pennut");
				sql = "select * from puppy_shows";
				command = new SQLiteCommand(sql, m_dbConnection);
				
				reader = command.ExecuteReader();
				while (reader.Read())
				{
					rop = Convert.ToInt32(reader["rop_puppy"]);
					vsp = Convert.ToInt32(reader["vsp_puppy"]);

					judge = (string)reader["judge"];

					dog_amount = Convert.ToInt32(reader["puppy_count"]);
					coat = Convert.ToInt32(reader["coat"]);
					if(coat == 0)
					{
						coat_string = "LK";
					}
					else
					{
						coat_string = "PK";
					}
					show =  (string)reader["show"];
					file.WriteLine(show);
					file.WriteLine(coat_string);
					file.WriteLine(judge);
					file.WriteLine("Dog amount: " + dog_amount);
					file.WriteLine("ROP-Pentu: " + convert_id_to_puppy_name(rop));
					file.WriteLine("VSP-Pentu: " + convert_id_to_puppy_name(vsp));
					file.WriteLine("\n");
				}
				file.WriteLine("\n");
				file.WriteLine("Veteraanit");
				sql = "select * from veteran_shows";
				command = new SQLiteCommand(sql, m_dbConnection);
				
				reader = command.ExecuteReader();
				while (reader.Read())
				{
					rop = Convert.ToInt32(reader["rop_vet"]);
					vsp = Convert.ToInt32(reader["vsp_vet"]);

					judge = (string)reader["judge"];

					dog_amount = Convert.ToInt32(reader["veteran_count"]);
					coat = Convert.ToInt32(reader["coat"]);
					if(coat == 0)
					{
						coat_string = "LK";
					}
					else
					{
						coat_string = "PK";
					}
					show =  (string)reader["show"];
					file.WriteLine(show);
					file.WriteLine(coat_string);
					file.WriteLine(judge);
					file.WriteLine("Dog amount: " + dog_amount);
					file.WriteLine("ROP-VET: " + convert_id_to_veteran_name(rop));
					file.WriteLine("VSP-VET: " + convert_id_to_veteran_name(vsp));
					file.WriteLine("\n");
				}
				file.WriteLine("\n");
				file.WriteLine("Kasvattajaluokat");
				sql = "select * from breeder";
				command = new SQLiteCommand(sql, m_dbConnection);
				string rop_breeder = "";
				string breeder2 = "";
				string breeder3 = "";
				string breeder4 = "";
				
				
				reader = command.ExecuteReader();
				while (reader.Read())
				{
					rop_breeder = (string)reader["rop_breeder"];
					var temp_breeder2 = reader["breeder2"];
					var temp_breeder3 = reader["breeder3"];
					var temp_breeder4 = reader["breeder4"];
					breeder2 = temp_breeder2.ToString();
					breeder3 = temp_breeder3.ToString();
					breeder4 = temp_breeder4.ToString();
					
					dog_amount = Convert.ToInt32(reader["count"]);
					coat = Convert.ToInt32(reader["coat"]);
					if(coat == 0)
					{
						coat_string = "LK";
					}
					else
					{
						coat_string = "PK";
					}
					// TODO: NULL check needed
					show =  (string)reader["show"];
					file.WriteLine(show);
					file.WriteLine(coat_string);
					file.WriteLine("Esitetyt kasvattajaluokat: " + dog_amount);
					file.WriteLine("ROP-Kasvattaja: " + rop_breeder);
					file.WriteLine("2, KP: " + breeder2);
					file.WriteLine("3, KP: " + breeder3);
					file.WriteLine("4, KP: " + breeder4);
					file.WriteLine("\n");
				}
				
				m_dbConnection.Close();
				MessageBox.Show("Done, data.txt generated");
			}
		}
		
		void FindMissingParent()
		{
			File.Delete("missing_parent.txt");
			using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"missing_parent.txt", true, Encoding.UTF8))
			{
				string name;
				
				
				SQLiteConnection m_dbConnection;
				string sql;
				SQLiteCommand command;
				file.WriteLine("Parent missing");
				
				m_dbConnection =
					new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;foreign keys=true;");
				m_dbConnection.Open();

			
				sql = "select * from dogs where sire = @na_string or dam = @na_string";
				command = new SQLiteCommand(sql, m_dbConnection);
				
   			    command.Parameters.AddWithValue("@na_string", "n/a");
				
				SQLiteDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					name = (string)reader["name"];
					file.WriteLine(name);
				}

				m_dbConnection.Close();
				MessageBox.Show("Done, missing_parent.txt generated");
			}
		}
		
		void DumpButtonClick(object sender, EventArgs e)
		{
			dump_results();
		}
		
		string convert_id_to_name(int id)
		{
			SQLiteConnection m_dbConnection;
			string sql;
			string name = "";
			SQLiteCommand command;
			if(id != 0)
			{
				m_dbConnection =
					new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;foreign keys=true;");
				m_dbConnection.Open();

				sql = "select name from dogs where id = @id";
				command = new SQLiteCommand(sql, m_dbConnection);
				command.Parameters.AddWithValue("@id", id);
				
				SQLiteDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					name = (string)reader["name"];
				}
				m_dbConnection.Close();
			}
			return name;
		}
		
		
		void HtmlResultsButtonClick(object sender, EventArgs e)
		{
			calculate(15, true, false);
		}
		
		void DropShowsButtonClick(object sender, EventArgs e)
		{
			DialogResult confirmation = MessageBox.Show("Drop show results.\nAre you sure?", "Confirm table drop", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(confirmation == DialogResult.Yes)
			{
				SQLiteConnection m_dbConnection;
				string sql;
				SQLiteCommand command;
				m_dbConnection =
					new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;foreign keys=true;");
				m_dbConnection.Open();
				
				sql = "drop table if exists shows";
				command = new SQLiteCommand(sql, m_dbConnection);
				command.ExecuteNonQuery();
				
				sql = "create table if not exists shows (coat INT, int_show INT, show VARCHAR(30), judge VARCHAR(50), dog_count INT, rop INTEGER, vsp INTEGER, pu2 INTEGER, pu3 INTEGER, pu4 INTEGER, pn2 INTEGER, pn3 INTEGER, pn4 INTEGER, FOREIGN KEY(rop) REFERENCES dogs(id), FOREIGN KEY(vsp) REFERENCES dogs(id), FOREIGN KEY(pu2) REFERENCES dogs(id), FOREIGN KEY(pu3) REFERENCES dogs(id), FOREIGN KEY(pu4) REFERENCES dogs(id), FOREIGN KEY(pn2) REFERENCES dogs(id), FOREIGN KEY(pn3) REFERENCES dogs(id), FOREIGN KEY(pn4) REFERENCES dogs(id))";
				command = new SQLiteCommand(sql, m_dbConnection);
				command.ExecuteNonQuery();
				
				m_dbConnection.Close();
			}
		}
		
		void DropPuppyShowsButtonClick(object sender, EventArgs e)
		{
			DialogResult confirmation = MessageBox.Show("Drop puppy show results.\nAre you sure?", "Confirm table drop", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(confirmation == DialogResult.Yes)
			{
				SQLiteConnection m_dbConnection;
				string sql;
				SQLiteCommand command;
				m_dbConnection =
					new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;foreign keys=true;");
				m_dbConnection.Open();
				
				sql = "drop table if exists puppy_shows";
				command = new SQLiteCommand(sql, m_dbConnection);
				command.ExecuteNonQuery();
				
				sql = "create table if not exists puppy_shows (coat INT, show VARCHAR(30), judge VARCHAR(50), puppy_count INT, rop_puppy INTEGER, vsp_puppy INTEGER, FOREIGN KEY(rop_puppy) REFERENCES puppy(id), FOREIGN KEY(vsp_puppy) REFERENCES puppy(id))";
				command = new SQLiteCommand(sql, m_dbConnection);
				command.ExecuteNonQuery();
				
				m_dbConnection.Close();
			}
		}
		
		void DropVeteranShowsButtonClick(object sender, EventArgs e)
		{
			DialogResult confirmation = MessageBox.Show("Drop veteran show results.\nAre you sure?", "Confirm table drop", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(confirmation == DialogResult.Yes)
			{
				SQLiteConnection m_dbConnection;
				string sql;
				SQLiteCommand command;
				m_dbConnection =
					new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;foreign keys=true;");
				m_dbConnection.Open();
				
				sql = "drop table if exists veteran_shows";
				command = new SQLiteCommand(sql, m_dbConnection);
				command.ExecuteNonQuery();
				
				sql = "create table if not exists veteran_shows (coat INT, show VARCHAR(30), judge VARCHAR(50), veteran_count INT, rop_vet INTEGER, vsp_vet INTEGER, FOREIGN KEY(rop_vet) REFERENCES veteran(id), FOREIGN KEY(vsp_vet) REFERENCES veteran(id))";
				command = new SQLiteCommand(sql, m_dbConnection);
				command.ExecuteNonQuery();
				
				m_dbConnection.Close();
			}
		}
		
		void DropBreederShowsButtonClick(object sender, EventArgs e)
		{
			DialogResult confirmation = MessageBox.Show("Drop breeder results.\nAre you sure?", "Confirm table drop", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(confirmation == DialogResult.Yes)
			{
				SQLiteConnection m_dbConnection;
				string sql;
				SQLiteCommand command;
				m_dbConnection =
					new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;foreign keys=true;");
				m_dbConnection.Open();
				
				sql = "drop table if exists breeder";
				command = new SQLiteCommand(sql, m_dbConnection);
				command.ExecuteNonQuery();
				
				sql = "create table if not exists breeder (coat INT, show VARCHAR(30), rop_breeder VARCHAR(30), breeder2 VARCHAR(30), breeder3 VARCHAR(30), breeder4 VARCHAR(30), count )";
				command = new SQLiteCommand(sql, m_dbConnection);
				command.ExecuteNonQuery();
				
				m_dbConnection.Close();
			}
		}
		

		
		void DropPuppyButtonClick(object sender, EventArgs e)
		{
			DialogResult confirmation = MessageBox.Show("Drop puppies and puppy results.\nAre you sure?", "Confirm table drop", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(confirmation == DialogResult.Yes)
			{
				
				SQLiteConnection m_dbConnection;
				string sql;
				SQLiteCommand command;
				m_dbConnection =
					new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;foreign keys=true;");
				m_dbConnection.Open();
				
				sql = "drop table if exists puppy_shows";
				command = new SQLiteCommand(sql, m_dbConnection);
				command.ExecuteNonQuery();
				
				sql = "drop table if exists puppy";
				command = new SQLiteCommand(sql, m_dbConnection);
				command.ExecuteNonQuery();
				
				sql = "create table if not exists puppy (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, dogcoat INT, breeder VARCHAR(30), name VARCHAR(30))";
				command = new SQLiteCommand(sql, m_dbConnection);
				command.ExecuteNonQuery();
				
				sql = "create table if not exists puppy_shows (coat INT, show VARCHAR(30), judge VARCHAR(50), puppy_count INT, rop_puppy INTEGER, vsp_puppy INTEGER, FOREIGN KEY(rop_puppy) REFERENCES puppy(id), FOREIGN KEY(vsp_puppy) REFERENCES puppy(id))";
				command = new SQLiteCommand(sql, m_dbConnection);
				command.ExecuteNonQuery();
				
				m_dbConnection.Close();
			}
		}
		
		string convert_id_to_puppy_name(int id)
		{
			SQLiteConnection m_dbConnection;
			string sql;
			string name = "";
			SQLiteCommand command;
			if(id != 0)
			{
				m_dbConnection =
					new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;foreign keys=true;");
				m_dbConnection.Open();

				sql = "select name from puppy where id = @id";
				command = new SQLiteCommand(sql, m_dbConnection);
				command.Parameters.AddWithValue("@id", id);
				
				SQLiteDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					name = (string)reader["name"];
				}
				m_dbConnection.Close();
			}
			return name;
		}
		
		string convert_id_to_veteran_name(int id)
		{
			SQLiteConnection m_dbConnection;
			string sql;
			string name = "";
			SQLiteCommand command;
			if(id != 0)
			{
				m_dbConnection =
					new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;foreign keys=true;");
				m_dbConnection.Open();

				sql = "select name from veteran where id = @id";
				command = new SQLiteCommand(sql, m_dbConnection);
				command.Parameters.AddWithValue("@id", id);
				
				SQLiteDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					name = (string)reader["name"];
				}
				m_dbConnection.Close();
			}
			return name;
		}
		
		
		void DebugResultsButtonClick(object sender, EventArgs e)
		{
			calculate(0, false, true);
		}
		
		void MissingParentButtonClick(object sender, EventArgs e)
		{
			FindMissingParent();
		}
		
		string GetDogNameById(int id)
		{
			string name = "";
			SQLiteConnection m_dbConnection;
			string sql;
			SQLiteCommand command;
			m_dbConnection =
				new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;foreign keys=true;");
			m_dbConnection.Open();
			sql = "select * from dogs where id = @dog_id";
			command = new SQLiteCommand(sql, m_dbConnection);
			command.Parameters.AddWithValue("@dog_id", id);
			SQLiteDataReader reader = command.ExecuteReader();
			while(reader.Read() )
			{
				var test = reader["name"];
				name = test.ToString();
				
				var temp_breeder = reader["breeder"];
				
				var reverse = reader["reverse_order"];
				
				string breeder_name = temp_breeder.ToString();
				string trim_name = name;
				string new_name;
				if(reverse.Equals(1))
				{
					if(breeder_name != "")
					{
						new_name = trim_name.Remove(0, breeder_name.Length + 1);
						name = new_name + " " + breeder_name;
					}

				}
			}
			m_dbConnection.Close();
			return name;
		}
		
	}
}
