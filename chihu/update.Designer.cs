/*
 * Created by SharpDevelop.
 * User: Tuomo
 * Date: 07/09/2014
 * Time: 07:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace chihu
{
	partial class update
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
			this.selectShowBox = new System.Windows.Forms.ComboBox();
			this.updateShowButton = new System.Windows.Forms.Button();
			this.selectPuppyShowBox = new System.Windows.Forms.ComboBox();
			this.updatePuppyShowButton = new System.Windows.Forms.Button();
			this.selectVeteranShowBox = new System.Windows.Forms.ComboBox();
			this.updateVeteranShowButton = new System.Windows.Forms.Button();
			this.selectBreederShowBox = new System.Windows.Forms.ComboBox();
			this.updateBreederShowButton = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.selectDogBox = new System.Windows.Forms.ComboBox();
			this.updateDogButton = new System.Windows.Forms.Button();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.closeButton = new System.Windows.Forms.Button();
			this.selectPuppyBox = new System.Windows.Forms.ComboBox();
			this.updatePuppyButton = new System.Windows.Forms.Button();
			this.selectVeteranBox = new System.Windows.Forms.ComboBox();
			this.updateVeteranButton = new System.Windows.Forms.Button();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// selectShowBox
			// 
			this.selectShowBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectShowBox.FormattingEnabled = true;
			this.selectShowBox.Location = new System.Drawing.Point(39, 26);
			this.selectShowBox.Name = "selectShowBox";
			this.selectShowBox.Size = new System.Drawing.Size(170, 21);
			this.selectShowBox.TabIndex = 0;
			this.selectShowBox.SelectedIndexChanged += new System.EventHandler(this.SelectShowBoxSelectedIndexChanged);
			// 
			// updateShowButton
			// 
			this.updateShowButton.Location = new System.Drawing.Point(227, 24);
			this.updateShowButton.Name = "updateShowButton";
			this.updateShowButton.Size = new System.Drawing.Size(75, 23);
			this.updateShowButton.TabIndex = 1;
			this.updateShowButton.Text = "Update";
			this.updateShowButton.UseVisualStyleBackColor = true;
			this.updateShowButton.Click += new System.EventHandler(this.UpdateShowButtonClick);
			// 
			// selectPuppyShowBox
			// 
			this.selectPuppyShowBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectPuppyShowBox.FormattingEnabled = true;
			this.selectPuppyShowBox.Location = new System.Drawing.Point(39, 96);
			this.selectPuppyShowBox.Name = "selectPuppyShowBox";
			this.selectPuppyShowBox.Size = new System.Drawing.Size(170, 21);
			this.selectPuppyShowBox.TabIndex = 2;
			this.selectPuppyShowBox.SelectedIndexChanged += new System.EventHandler(this.SelectPuppyShowBoxSelectedIndexChanged);
			// 
			// updatePuppyShowButton
			// 
			this.updatePuppyShowButton.Location = new System.Drawing.Point(227, 96);
			this.updatePuppyShowButton.Name = "updatePuppyShowButton";
			this.updatePuppyShowButton.Size = new System.Drawing.Size(75, 23);
			this.updatePuppyShowButton.TabIndex = 3;
			this.updatePuppyShowButton.Text = "Update";
			this.updatePuppyShowButton.UseVisualStyleBackColor = true;
			this.updatePuppyShowButton.Click += new System.EventHandler(this.UpdatePuppyShowButtonClick);
			// 
			// selectVeteranShowBox
			// 
			this.selectVeteranShowBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectVeteranShowBox.FormattingEnabled = true;
			this.selectVeteranShowBox.Location = new System.Drawing.Point(39, 170);
			this.selectVeteranShowBox.Name = "selectVeteranShowBox";
			this.selectVeteranShowBox.Size = new System.Drawing.Size(170, 21);
			this.selectVeteranShowBox.TabIndex = 4;
			this.selectVeteranShowBox.SelectedIndexChanged += new System.EventHandler(this.SelectVeteranShowBoxSelectedIndexChanged);
			// 
			// updateVeteranShowButton
			// 
			this.updateVeteranShowButton.Location = new System.Drawing.Point(227, 168);
			this.updateVeteranShowButton.Name = "updateVeteranShowButton";
			this.updateVeteranShowButton.Size = new System.Drawing.Size(75, 23);
			this.updateVeteranShowButton.TabIndex = 5;
			this.updateVeteranShowButton.Text = "Update";
			this.updateVeteranShowButton.UseVisualStyleBackColor = true;
			this.updateVeteranShowButton.Click += new System.EventHandler(this.UpdateVeteranShowButtonClick);
			// 
			// selectBreederShowBox
			// 
			this.selectBreederShowBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectBreederShowBox.FormattingEnabled = true;
			this.selectBreederShowBox.Location = new System.Drawing.Point(39, 243);
			this.selectBreederShowBox.Name = "selectBreederShowBox";
			this.selectBreederShowBox.Size = new System.Drawing.Size(170, 21);
			this.selectBreederShowBox.TabIndex = 6;
			this.selectBreederShowBox.SelectedIndexChanged += new System.EventHandler(this.SelectBreederShowBoxSelectedIndexChanged);
			// 
			// updateBreederShowButton
			// 
			this.updateBreederShowButton.Location = new System.Drawing.Point(227, 243);
			this.updateBreederShowButton.Name = "updateBreederShowButton";
			this.updateBreederShowButton.Size = new System.Drawing.Size(75, 23);
			this.updateBreederShowButton.TabIndex = 7;
			this.updateBreederShowButton.Text = "Update";
			this.updateBreederShowButton.UseVisualStyleBackColor = true;
			this.updateBreederShowButton.Click += new System.EventHandler(this.UpdateBreederShowButtonClick);
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Location = new System.Drawing.Point(39, 7);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(100, 13);
			this.textBox1.TabIndex = 8;
			this.textBox1.TabStop = false;
			this.textBox1.Text = "Show";
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Location = new System.Drawing.Point(39, 77);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(100, 13);
			this.textBox2.TabIndex = 9;
			this.textBox2.TabStop = false;
			this.textBox2.Text = "Puppy show";
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox3.Location = new System.Drawing.Point(39, 153);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(100, 13);
			this.textBox3.TabIndex = 10;
			this.textBox3.TabStop = false;
			this.textBox3.Text = "Veteran show";
			// 
			// textBox4
			// 
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox4.Location = new System.Drawing.Point(39, 227);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(100, 13);
			this.textBox4.TabIndex = 11;
			this.textBox4.TabStop = false;
			this.textBox4.Text = "Breeder show";
			// 
			// selectDogBox
			// 
			this.selectDogBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.selectDogBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.selectDogBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectDogBox.FormattingEnabled = true;
			this.selectDogBox.Location = new System.Drawing.Point(39, 317);
			this.selectDogBox.Name = "selectDogBox";
			this.selectDogBox.Size = new System.Drawing.Size(170, 21);
			this.selectDogBox.TabIndex = 12;
			this.selectDogBox.SelectedIndexChanged += new System.EventHandler(this.SelectDogBoxSelectedIndexChanged);
			// 
			// updateDogButton
			// 
			this.updateDogButton.Location = new System.Drawing.Point(227, 317);
			this.updateDogButton.Name = "updateDogButton";
			this.updateDogButton.Size = new System.Drawing.Size(75, 23);
			this.updateDogButton.TabIndex = 13;
			this.updateDogButton.Text = "Update";
			this.updateDogButton.UseVisualStyleBackColor = true;
			this.updateDogButton.Click += new System.EventHandler(this.UpdateDogButtonClick);
			// 
			// textBox5
			// 
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox5.Location = new System.Drawing.Point(39, 298);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new System.Drawing.Size(100, 13);
			this.textBox5.TabIndex = 14;
			this.textBox5.TabStop = false;
			this.textBox5.Text = "Dog";
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(345, 441);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 15;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
			// 
			// selectPuppyBox
			// 
			this.selectPuppyBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.selectPuppyBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.selectPuppyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectPuppyBox.FormattingEnabled = true;
			this.selectPuppyBox.Location = new System.Drawing.Point(39, 379);
			this.selectPuppyBox.Name = "selectPuppyBox";
			this.selectPuppyBox.Size = new System.Drawing.Size(170, 21);
			this.selectPuppyBox.TabIndex = 16;
			this.selectPuppyBox.SelectedIndexChanged += new System.EventHandler(this.SelectPuppyBoxSelectedIndexChanged);
			// 
			// updatePuppyButton
			// 
			this.updatePuppyButton.Location = new System.Drawing.Point(227, 379);
			this.updatePuppyButton.Name = "updatePuppyButton";
			this.updatePuppyButton.Size = new System.Drawing.Size(75, 23);
			this.updatePuppyButton.TabIndex = 17;
			this.updatePuppyButton.Text = "Update";
			this.updatePuppyButton.UseVisualStyleBackColor = true;
			this.updatePuppyButton.Click += new System.EventHandler(this.UpdatePuppyButtonClick);
			// 
			// selectVeteranBox
			// 
			this.selectVeteranBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.selectVeteranBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.selectVeteranBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectVeteranBox.FormattingEnabled = true;
			this.selectVeteranBox.Location = new System.Drawing.Point(39, 441);
			this.selectVeteranBox.Name = "selectVeteranBox";
			this.selectVeteranBox.Size = new System.Drawing.Size(170, 21);
			this.selectVeteranBox.TabIndex = 18;
			this.selectVeteranBox.SelectedIndexChanged += new System.EventHandler(this.SelectVeteranBoxSelectedIndexChanged);
			// 
			// updateVeteranButton
			// 
			this.updateVeteranButton.Location = new System.Drawing.Point(227, 441);
			this.updateVeteranButton.Name = "updateVeteranButton";
			this.updateVeteranButton.Size = new System.Drawing.Size(75, 23);
			this.updateVeteranButton.TabIndex = 20;
			this.updateVeteranButton.Text = "Update";
			this.updateVeteranButton.UseVisualStyleBackColor = true;
			this.updateVeteranButton.Click += new System.EventHandler(this.UpdateVeteranButtonClick);
			// 
			// textBox6
			// 
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox6.Location = new System.Drawing.Point(39, 360);
			this.textBox6.Name = "textBox6";
			this.textBox6.ReadOnly = true;
			this.textBox6.Size = new System.Drawing.Size(100, 13);
			this.textBox6.TabIndex = 23;
			this.textBox6.TabStop = false;
			this.textBox6.Text = "Puppy";
			// 
			// textBox7
			// 
			this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox7.Location = new System.Drawing.Point(39, 422);
			this.textBox7.Name = "textBox7";
			this.textBox7.ReadOnly = true;
			this.textBox7.Size = new System.Drawing.Size(100, 13);
			this.textBox7.TabIndex = 24;
			this.textBox7.TabStop = false;
			this.textBox7.Text = "Veteran";
			// 
			// update
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(573, 586);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.updateVeteranButton);
			this.Controls.Add(this.selectVeteranBox);
			this.Controls.Add(this.updatePuppyButton);
			this.Controls.Add(this.selectPuppyBox);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.updateDogButton);
			this.Controls.Add(this.selectDogBox);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.updateBreederShowButton);
			this.Controls.Add(this.selectBreederShowBox);
			this.Controls.Add(this.updateVeteranShowButton);
			this.Controls.Add(this.selectVeteranShowBox);
			this.Controls.Add(this.updatePuppyShowButton);
			this.Controls.Add(this.selectPuppyShowBox);
			this.Controls.Add(this.updateShowButton);
			this.Controls.Add(this.selectShowBox);
			this.Name = "update";
			this.Text = "update";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Button updateVeteranButton;
		private System.Windows.Forms.ComboBox selectVeteranBox;
		private System.Windows.Forms.Button updatePuppyButton;
		private System.Windows.Forms.ComboBox selectPuppyBox;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Button updateDogButton;
		private System.Windows.Forms.ComboBox selectDogBox;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button updateBreederShowButton;
		private System.Windows.Forms.ComboBox selectBreederShowBox;
		private System.Windows.Forms.Button updateVeteranShowButton;
		private System.Windows.Forms.ComboBox selectVeteranShowBox;
		private System.Windows.Forms.Button updatePuppyShowButton;
		private System.Windows.Forms.ComboBox selectPuppyShowBox;
		private System.Windows.Forms.Button updateShowButton;
		private System.Windows.Forms.ComboBox selectShowBox;
	}
}
