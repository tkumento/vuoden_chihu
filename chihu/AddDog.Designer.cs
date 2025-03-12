/*
 * Created by SharpDevelop.
 * User: Tuomo
 * Date: 19/08/2014
 * Time: 13:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace chihu
{
	partial class AddDog
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.breederBox = new System.Windows.Forms.ComboBox();
			this.dogBox = new System.Windows.Forms.ComboBox();
			this.dogcoatBox = new System.Windows.Forms.ComboBox();
			this.doneButton = new System.Windows.Forms.Button();
			this.addNewDogButton = new System.Windows.Forms.Button();
			this.addNewPuppyButton = new System.Windows.Forms.Button();
			this.addNewVeteranButton = new System.Windows.Forms.Button();
			this.noDogButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// breederBox
			// 
			this.breederBox.AllowDrop = true;
			this.breederBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.breederBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.breederBox.FormattingEnabled = true;
			this.breederBox.Location = new System.Drawing.Point(192, 25);
			this.breederBox.Name = "breederBox";
			this.breederBox.Size = new System.Drawing.Size(143, 21);
			this.breederBox.TabIndex = 0;
			this.breederBox.Text = "Breeder";
			this.breederBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			this.breederBox.SelectedValueChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			this.breederBox.Leave += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// dogBox
			// 
			this.dogBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.dogBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.dogBox.FormattingEnabled = true;
			this.dogBox.Items.AddRange(new object[] {
									"dog1",
									"dog2"});
			this.dogBox.Location = new System.Drawing.Point(370, 24);
			this.dogBox.Name = "dogBox";
			this.dogBox.Size = new System.Drawing.Size(200, 21);
			this.dogBox.TabIndex = 1;
			this.dogBox.Text = "dog1";
			this.dogBox.SelectedIndexChanged += new System.EventHandler(this.DogBoxSelectedIndexChanged);
			this.dogBox.SelectedValueChanged += new System.EventHandler(this.DogBoxSelectedIndexChanged);
			this.dogBox.Enter += new System.EventHandler(this.AddDogEnter);
			this.dogBox.Leave += new System.EventHandler(this.DogBoxSelectedIndexChanged);
			// 
			// dogcoatBox
			// 
			this.dogcoatBox.FormattingEnabled = true;
			this.dogcoatBox.Items.AddRange(new object[] {
									"LK",
									"PK"});
			this.dogcoatBox.Location = new System.Drawing.Point(43, 25);
			this.dogcoatBox.Name = "dogcoatBox";
			this.dogcoatBox.Size = new System.Drawing.Size(121, 21);
			this.dogcoatBox.TabIndex = 7;
			this.dogcoatBox.Visible = false;
			this.dogcoatBox.SelectedIndexChanged += new System.EventHandler(this.DogcoatBoxSelectedIndexChanged);
			this.dogcoatBox.SelectedValueChanged += new System.EventHandler(this.DogcoatBoxSelectedIndexChanged);
			this.dogcoatBox.Leave += new System.EventHandler(this.DogcoatBoxSelectedIndexChanged);
			// 
			// doneButton
			// 
			this.doneButton.Location = new System.Drawing.Point(587, 22);
			this.doneButton.Name = "doneButton";
			this.doneButton.Size = new System.Drawing.Size(75, 23);
			this.doneButton.TabIndex = 8;
			this.doneButton.Text = "Add";
			this.doneButton.UseVisualStyleBackColor = true;
			this.doneButton.Click += new System.EventHandler(this.DoneButtonClick);
			// 
			// addNewDogButton
			// 
			this.addNewDogButton.Location = new System.Drawing.Point(43, 93);
			this.addNewDogButton.Name = "addNewDogButton";
			this.addNewDogButton.Size = new System.Drawing.Size(121, 23);
			this.addNewDogButton.TabIndex = 9;
			this.addNewDogButton.Text = "Add new dog";
			this.addNewDogButton.UseVisualStyleBackColor = true;
			this.addNewDogButton.Click += new System.EventHandler(this.AddNewDogButtonClick);
			// 
			// addNewPuppyButton
			// 
			this.addNewPuppyButton.Location = new System.Drawing.Point(192, 93);
			this.addNewPuppyButton.Name = "addNewPuppyButton";
			this.addNewPuppyButton.Size = new System.Drawing.Size(111, 23);
			this.addNewPuppyButton.TabIndex = 10;
			this.addNewPuppyButton.Text = "Add new puppy";
			this.addNewPuppyButton.UseVisualStyleBackColor = true;
			this.addNewPuppyButton.Click += new System.EventHandler(this.AddNewPuppyButtonClick);
			// 
			// addNewVeteranButton
			// 
			this.addNewVeteranButton.Location = new System.Drawing.Point(336, 93);
			this.addNewVeteranButton.Name = "addNewVeteranButton";
			this.addNewVeteranButton.Size = new System.Drawing.Size(114, 23);
			this.addNewVeteranButton.TabIndex = 11;
			this.addNewVeteranButton.Text = "Add new veteran";
			this.addNewVeteranButton.UseVisualStyleBackColor = true;
			this.addNewVeteranButton.Click += new System.EventHandler(this.AddNewVeteranButtonClick);
			// 
			// noDogButton
			// 
			this.noDogButton.Location = new System.Drawing.Point(587, 63);
			this.noDogButton.Name = "noDogButton";
			this.noDogButton.Size = new System.Drawing.Size(75, 23);
			this.noDogButton.TabIndex = 12;
			this.noDogButton.Text = "No dog";
			this.noDogButton.UseVisualStyleBackColor = true;
			this.noDogButton.Click += new System.EventHandler(this.NoDogButtonClick);
			// 
			// AddDog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(735, 409);
			this.Controls.Add(this.noDogButton);
			this.Controls.Add(this.addNewVeteranButton);
			this.Controls.Add(this.addNewPuppyButton);
			this.Controls.Add(this.addNewDogButton);
			this.Controls.Add(this.doneButton);
			this.Controls.Add(this.dogcoatBox);
			this.Controls.Add(this.dogBox);
			this.Controls.Add(this.breederBox);
			this.Name = "AddDog";
			this.Text = "AddDog";
			this.CursorChanged += new System.EventHandler(this.AddDogEnter);
			this.Click += new System.EventHandler(this.AddDogEnter);
			this.Enter += new System.EventHandler(this.AddDogEnter);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button noDogButton;
		private System.Windows.Forms.Button addNewVeteranButton;
		private System.Windows.Forms.Button addNewPuppyButton;
		private System.Windows.Forms.Button addNewDogButton;
		private System.Windows.Forms.Button doneButton;
		private System.Windows.Forms.ComboBox dogcoatBox;
		private System.Windows.Forms.ComboBox dogBox;
		private System.Windows.Forms.ComboBox breederBox;
	}
}
