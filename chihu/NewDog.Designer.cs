/*
 * Created by SharpDevelop.
 * User: Tuomo
 * Date: 23/08/2014
 * Time: 17:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace chihu
{
	partial class NewDog
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
			this.sireBox = new System.Windows.Forms.ComboBox();
			this.sireCoatBox = new System.Windows.Forms.ComboBox();
			this.damBox = new System.Windows.Forms.ComboBox();
			this.damCoatBox = new System.Windows.Forms.ComboBox();
			this.doneButton = new System.Windows.Forms.Button();
			this.dogBox = new System.Windows.Forms.TextBox();
			this.closeButton = new System.Windows.Forms.Button();
			this.updateButton = new System.Windows.Forms.Button();
			this.reverseOrderBox = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// coatBox
			// 
			this.coatBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.coatBox.FormattingEnabled = true;
			this.coatBox.Items.AddRange(new object[] {
									"LK",
									"PK"});
			this.coatBox.Location = new System.Drawing.Point(42, 25);
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
			this.breederBox.Location = new System.Drawing.Point(198, 25);
			this.breederBox.Name = "breederBox";
			this.breederBox.Size = new System.Drawing.Size(121, 21);
			this.breederBox.TabIndex = 1;
			this.breederBox.Text = "Breeder";
			this.breederBox.SelectedIndexChanged += new System.EventHandler(this.BreederBoxSelectedIndexChanged);
			this.breederBox.Leave += new System.EventHandler(this.BreederBoxSelectedIndexChanged);
			// 
			// sireBox
			// 
			this.sireBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.sireBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.sireBox.FormattingEnabled = true;
			this.sireBox.Location = new System.Drawing.Point(42, 66);
			this.sireBox.Name = "sireBox";
			this.sireBox.Size = new System.Drawing.Size(205, 21);
			this.sireBox.TabIndex = 3;
			this.sireBox.Text = "Sire";
			this.sireBox.SelectedIndexChanged += new System.EventHandler(this.SireBoxSelectedIndexChanged);
			this.sireBox.Leave += new System.EventHandler(this.SireBoxSelectedIndexChanged);
			// 
			// sireCoatBox
			// 
			this.sireCoatBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.sireCoatBox.FormattingEnabled = true;
			this.sireCoatBox.Items.AddRange(new object[] {
									"LK",
									"PK"});
			this.sireCoatBox.Location = new System.Drawing.Point(270, 66);
			this.sireCoatBox.Name = "sireCoatBox";
			this.sireCoatBox.Size = new System.Drawing.Size(107, 21);
			this.sireCoatBox.TabIndex = 4;
			this.sireCoatBox.SelectedIndexChanged += new System.EventHandler(this.SireCoatBoxSelectedIndexChanged);
			// 
			// damBox
			// 
			this.damBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.damBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.damBox.FormattingEnabled = true;
			this.damBox.Location = new System.Drawing.Point(42, 105);
			this.damBox.Name = "damBox";
			this.damBox.Size = new System.Drawing.Size(205, 21);
			this.damBox.TabIndex = 5;
			this.damBox.Text = "Dam";
			this.damBox.SelectedIndexChanged += new System.EventHandler(this.DamBoxSelectedIndexChanged);
			this.damBox.Leave += new System.EventHandler(this.DamBoxSelectedIndexChanged);
			// 
			// damCoatBox
			// 
			this.damCoatBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.damCoatBox.FormattingEnabled = true;
			this.damCoatBox.Items.AddRange(new object[] {
									"LK",
									"PK"});
			this.damCoatBox.Location = new System.Drawing.Point(270, 105);
			this.damCoatBox.Name = "damCoatBox";
			this.damCoatBox.Size = new System.Drawing.Size(107, 21);
			this.damCoatBox.TabIndex = 6;
			this.damCoatBox.SelectedIndexChanged += new System.EventHandler(this.DamCoatBoxSelectedIndexChanged);
			// 
			// doneButton
			// 
			this.doneButton.Location = new System.Drawing.Point(606, 22);
			this.doneButton.Name = "doneButton";
			this.doneButton.Size = new System.Drawing.Size(75, 23);
			this.doneButton.TabIndex = 7;
			this.doneButton.Text = "Done";
			this.doneButton.UseVisualStyleBackColor = true;
			this.doneButton.Click += new System.EventHandler(this.DoneButtonClick);
			// 
			// dogBox
			// 
			this.dogBox.Location = new System.Drawing.Point(348, 25);
			this.dogBox.Name = "dogBox";
			this.dogBox.Size = new System.Drawing.Size(131, 20);
			this.dogBox.TabIndex = 2;
			this.dogBox.Text = "Name";
			this.dogBox.TextChanged += new System.EventHandler(this.DogBoxTextChanged);
			this.dogBox.Leave += new System.EventHandler(this.DogBoxTextChanged);
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(606, 79);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 9;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(606, 43);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(75, 23);
			this.updateButton.TabIndex = 10;
			this.updateButton.Text = "Update";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Visible = false;
			this.updateButton.Click += new System.EventHandler(this.UpdateButtonClick);
			// 
			// reverseOrderBox
			// 
			this.reverseOrderBox.Location = new System.Drawing.Point(485, 23);
			this.reverseOrderBox.Name = "reverseOrderBox";
			this.reverseOrderBox.Size = new System.Drawing.Size(104, 24);
			this.reverseOrderBox.TabIndex = 11;
			this.reverseOrderBox.Text = "Reverse";
			this.reverseOrderBox.UseVisualStyleBackColor = true;
			// 
			// NewDog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(841, 602);
			this.Controls.Add(this.reverseOrderBox);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.dogBox);
			this.Controls.Add(this.doneButton);
			this.Controls.Add(this.damCoatBox);
			this.Controls.Add(this.damBox);
			this.Controls.Add(this.sireCoatBox);
			this.Controls.Add(this.sireBox);
			this.Controls.Add(this.breederBox);
			this.Controls.Add(this.coatBox);
			this.Name = "NewDog";
			this.Text = "NewDog";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.CheckBox reverseOrderBox;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Button doneButton;
		private System.Windows.Forms.ComboBox damCoatBox;
		private System.Windows.Forms.ComboBox damBox;
		private System.Windows.Forms.ComboBox sireCoatBox;
		private System.Windows.Forms.ComboBox sireBox;
		private System.Windows.Forms.TextBox dogBox;
		private System.Windows.Forms.ComboBox breederBox;
		private System.Windows.Forms.ComboBox coatBox;
	}
}
