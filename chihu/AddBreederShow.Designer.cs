/*
 * Created by SharpDevelop.
 * User: Tuomo
 * Date: 29/08/2014
 * Time: 20:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace chihu
{
	partial class AddBreederShow
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
			this.showBox = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.dogCountBox = new System.Windows.Forms.TextBox();
			this.ropBox = new System.Windows.Forms.ComboBox();
			this.kp2Box = new System.Windows.Forms.ComboBox();
			this.kp3Box = new System.Windows.Forms.ComboBox();
			this.kp4Box = new System.Windows.Forms.ComboBox();
			this.addButton = new System.Windows.Forms.Button();
			this.closeButton = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.updateButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// coatBox
			// 
			this.coatBox.FormattingEnabled = true;
			this.coatBox.Items.AddRange(new object[] {
									"LK",
									"PK"});
			this.coatBox.Location = new System.Drawing.Point(37, 28);
			this.coatBox.Name = "coatBox";
			this.coatBox.Size = new System.Drawing.Size(121, 21);
			this.coatBox.TabIndex = 0;
			this.coatBox.Text = "LK";
			this.coatBox.SelectedIndexChanged += new System.EventHandler(this.CoatBoxSelectedIndexChanged);
			// 
			// showBox
			// 
			this.showBox.Location = new System.Drawing.Point(37, 75);
			this.showBox.Name = "showBox";
			this.showBox.Size = new System.Drawing.Size(100, 20);
			this.showBox.TabIndex = 1;
			this.showBox.Text = "Show location";
			this.showBox.TextChanged += new System.EventHandler(this.ShowBoxTextChanged);
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Location = new System.Drawing.Point(37, 114);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(50, 13);
			this.textBox1.TabIndex = 2;
			this.textBox1.TabStop = false;
			this.textBox1.Text = "Amount";
			// 
			// dogCountBox
			// 
			this.dogCountBox.Location = new System.Drawing.Point(93, 111);
			this.dogCountBox.Name = "dogCountBox";
			this.dogCountBox.Size = new System.Drawing.Size(100, 20);
			this.dogCountBox.TabIndex = 3;
			this.dogCountBox.Text = "0";
			this.dogCountBox.TextChanged += new System.EventHandler(this.DogCountBoxTextChanged);
			this.dogCountBox.Leave += new System.EventHandler(this.DogCountBoxTextChanged);
			// 
			// ropBox
			// 
			this.ropBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.ropBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.ropBox.FormattingEnabled = true;
			this.ropBox.Location = new System.Drawing.Point(119, 158);
			this.ropBox.Name = "ropBox";
			this.ropBox.Size = new System.Drawing.Size(121, 21);
			this.ropBox.TabIndex = 4;
			this.ropBox.SelectedIndexChanged += new System.EventHandler(this.RopBoxSelectedIndexChanged);
			// 
			// kp2Box
			// 
			this.kp2Box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.kp2Box.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.kp2Box.FormattingEnabled = true;
			this.kp2Box.Location = new System.Drawing.Point(119, 194);
			this.kp2Box.Name = "kp2Box";
			this.kp2Box.Size = new System.Drawing.Size(121, 21);
			this.kp2Box.TabIndex = 5;
			this.kp2Box.SelectedIndexChanged += new System.EventHandler(this.Kp2BoxSelectedIndexChanged);
			// 
			// kp3Box
			// 
			this.kp3Box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.kp3Box.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.kp3Box.FormattingEnabled = true;
			this.kp3Box.Location = new System.Drawing.Point(119, 231);
			this.kp3Box.Name = "kp3Box";
			this.kp3Box.Size = new System.Drawing.Size(121, 21);
			this.kp3Box.TabIndex = 6;
			this.kp3Box.SelectedIndexChanged += new System.EventHandler(this.Kp3BoxSelectedIndexChanged);
			// 
			// kp4Box
			// 
			this.kp4Box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.kp4Box.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.kp4Box.FormattingEnabled = true;
			this.kp4Box.Location = new System.Drawing.Point(119, 270);
			this.kp4Box.Name = "kp4Box";
			this.kp4Box.Size = new System.Drawing.Size(121, 21);
			this.kp4Box.TabIndex = 7;
			this.kp4Box.SelectedIndexChanged += new System.EventHandler(this.Kp4BoxSelectedIndexChanged);
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(286, 221);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 8;
			this.addButton.Text = "Add";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.AddButtonClick);
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(286, 270);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 9;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Location = new System.Drawing.Point(37, 158);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(65, 13);
			this.textBox2.TabIndex = 10;
			this.textBox2.TabStop = false;
			this.textBox2.Text = "ROP";
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox3.Location = new System.Drawing.Point(37, 194);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(50, 13);
			this.textBox3.TabIndex = 11;
			this.textBox3.TabStop = false;
			this.textBox3.Text = "2, KP";
			// 
			// textBox4
			// 
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox4.Location = new System.Drawing.Point(37, 231);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(50, 13);
			this.textBox4.TabIndex = 12;
			this.textBox4.TabStop = false;
			this.textBox4.Text = "3, KP";
			// 
			// textBox5
			// 
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox5.Location = new System.Drawing.Point(37, 270);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new System.Drawing.Size(65, 13);
			this.textBox5.TabIndex = 13;
			this.textBox5.TabStop = false;
			this.textBox5.Text = "4, KP";
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(286, 241);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(75, 23);
			this.updateButton.TabIndex = 14;
			this.updateButton.Text = "Update";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Visible = false;
			this.updateButton.Click += new System.EventHandler(this.UpdateButtonClick);
			// 
			// AddBreederShow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(597, 539);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.kp4Box);
			this.Controls.Add(this.kp3Box);
			this.Controls.Add(this.kp2Box);
			this.Controls.Add(this.ropBox);
			this.Controls.Add(this.dogCountBox);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.showBox);
			this.Controls.Add(this.coatBox);
			this.Name = "AddBreederShow";
			this.Text = "AddBreederShow";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.ComboBox kp4Box;
		private System.Windows.Forms.ComboBox kp3Box;
		private System.Windows.Forms.ComboBox kp2Box;
		private System.Windows.Forms.ComboBox ropBox;
		private System.Windows.Forms.TextBox dogCountBox;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox showBox;
		private System.Windows.Forms.ComboBox coatBox;
	}
}
