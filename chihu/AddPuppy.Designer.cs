﻿/*
 * Created by SharpDevelop.
 * User: Tuomo
 * Date: 23/08/2014
 * Time: 15:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace chihu
{
	partial class AddPuppy
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
			this.coatBox = new System.Windows.Forms.ComboBox();
			this.breederBox = new System.Windows.Forms.ComboBox();
			this.dogBox = new System.Windows.Forms.ComboBox();
			this.doneButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// coatBox
			// 
			this.coatBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.coatBox.FormattingEnabled = true;
			this.coatBox.Items.AddRange(new object[] {
									"LK",
									"PK"});
			this.coatBox.Location = new System.Drawing.Point(34, 24);
			this.coatBox.Name = "coatBox";
			this.coatBox.Size = new System.Drawing.Size(121, 21);
			this.coatBox.TabIndex = 0;
			this.coatBox.SelectedIndexChanged += new System.EventHandler(this.CoatBoxSelectedIndexChanged);
			// 
			// breederBox
			// 
			this.breederBox.FormattingEnabled = true;
			this.breederBox.Location = new System.Drawing.Point(191, 23);
			this.breederBox.Name = "breederBox";
			this.breederBox.Size = new System.Drawing.Size(121, 21);
			this.breederBox.TabIndex = 1;
			this.breederBox.Text = "Breeder";
			this.breederBox.SelectedIndexChanged += new System.EventHandler(this.BreederBoxSelectedIndexChanged);
			// 
			// dogBox
			// 
			this.dogBox.FormattingEnabled = true;
			this.dogBox.Location = new System.Drawing.Point(342, 24);
			this.dogBox.Name = "dogBox";
			this.dogBox.Size = new System.Drawing.Size(162, 21);
			this.dogBox.TabIndex = 2;
			this.dogBox.Text = "Dog";
			this.dogBox.SelectedIndexChanged += new System.EventHandler(this.DogBoxSelectedIndexChanged);
			// 
			// doneButton
			// 
			this.doneButton.Location = new System.Drawing.Point(510, 24);
			this.doneButton.Name = "doneButton";
			this.doneButton.Size = new System.Drawing.Size(75, 23);
			this.doneButton.TabIndex = 3;
			this.doneButton.Text = "Done";
			this.doneButton.UseVisualStyleBackColor = true;
			this.doneButton.Click += new System.EventHandler(this.DoneButtonClick);
			// 
			// AddPuppy
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(615, 375);
			this.Controls.Add(this.doneButton);
			this.Controls.Add(this.dogBox);
			this.Controls.Add(this.breederBox);
			this.Controls.Add(this.coatBox);
			this.Name = "AddPuppy";
			this.Text = "AddPuppy";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button doneButton;
		private System.Windows.Forms.ComboBox dogBox;
		private System.Windows.Forms.ComboBox breederBox;
		private System.Windows.Forms.ComboBox coatBox;
	}
}
