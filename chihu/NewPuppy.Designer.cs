﻿/*
 * Created by SharpDevelop.
 * User: Tuomo
 * Date: 23/08/2014
 * Time: 17:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace chihu
{
	partial class NewPuppy
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
			this.dogBox = new System.Windows.Forms.TextBox();
			this.doneButton = new System.Windows.Forms.Button();
			this.closeButton = new System.Windows.Forms.Button();
			this.updateButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// coatBox
			// 
			this.coatBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.coatBox.FormattingEnabled = true;
			this.coatBox.Items.AddRange(new object[] {
									"LK",
									"PK"});
			this.coatBox.Location = new System.Drawing.Point(35, 25);
			this.coatBox.Name = "coatBox";
			this.coatBox.Size = new System.Drawing.Size(121, 21);
			this.coatBox.TabIndex = 0;
			this.coatBox.SelectedIndexChanged += new System.EventHandler(this.CoatBoxSelectedIndexChanged);
			// 
			// breederBox
			// 
			this.breederBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.breederBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.breederBox.FormattingEnabled = true;
			this.breederBox.Location = new System.Drawing.Point(188, 25);
			this.breederBox.Name = "breederBox";
			this.breederBox.Size = new System.Drawing.Size(121, 21);
			this.breederBox.TabIndex = 1;
			this.breederBox.Text = "Breeder";
			this.breederBox.SelectedIndexChanged += new System.EventHandler(this.BreederBoxSelectedIndexChanged);
			this.breederBox.Leave += new System.EventHandler(this.BreederBoxSelectedIndexChanged);
			// 
			// dogBox
			// 
			this.dogBox.Location = new System.Drawing.Point(325, 25);
			this.dogBox.Name = "dogBox";
			this.dogBox.Size = new System.Drawing.Size(134, 20);
			this.dogBox.TabIndex = 2;
			this.dogBox.Text = "Name";
			this.dogBox.TextChanged += new System.EventHandler(this.DogBoxTextChanged);
			this.dogBox.Leave += new System.EventHandler(this.DogBoxTextChanged);
			// 
			// doneButton
			// 
			this.doneButton.Location = new System.Drawing.Point(487, 12);
			this.doneButton.Name = "doneButton";
			this.doneButton.Size = new System.Drawing.Size(75, 23);
			this.doneButton.TabIndex = 3;
			this.doneButton.Text = "Done";
			this.doneButton.UseVisualStyleBackColor = true;
			this.doneButton.Click += new System.EventHandler(this.DoneButtonClick);
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(487, 67);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 4;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(487, 25);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(75, 23);
			this.updateButton.TabIndex = 5;
			this.updateButton.Text = "Update";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Visible = false;
			this.updateButton.Click += new System.EventHandler(this.UpdateButtonClick);
			// 
			// NewPuppy
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 340);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.doneButton);
			this.Controls.Add(this.dogBox);
			this.Controls.Add(this.breederBox);
			this.Controls.Add(this.coatBox);
			this.Name = "NewPuppy";
			this.Text = "NewPuppy";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Button doneButton;
		private System.Windows.Forms.TextBox dogBox;
		private System.Windows.Forms.ComboBox breederBox;
		private System.Windows.Forms.ComboBox coatBox;
	}
}
