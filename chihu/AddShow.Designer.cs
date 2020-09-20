/*
 * Created by SharpDevelop.
 * User: Tuomo
 * Date: 23/08/2014
 * Time: 13:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace chihu
{
	partial class AddShow
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
			this.showLocationBox = new System.Windows.Forms.TextBox();
			this.coatBox = new System.Windows.Forms.ComboBox();
			this.judgeBox = new System.Windows.Forms.TextBox();
			this.amountBox = new System.Windows.Forms.TextBox();
			this.showTypeBox = new System.Windows.Forms.ComboBox();
			this.ropButton = new System.Windows.Forms.Button();
			this.vspButton = new System.Windows.Forms.Button();
			this.pu2Button = new System.Windows.Forms.Button();
			this.pu3Button = new System.Windows.Forms.Button();
			this.pu4Button = new System.Windows.Forms.Button();
			this.pn2Button = new System.Windows.Forms.Button();
			this.pn3Button = new System.Windows.Forms.Button();
			this.pn4Button = new System.Windows.Forms.Button();
			this.addShowButton = new System.Windows.Forms.Button();
			this.ropNameBox = new System.Windows.Forms.TextBox();
			this.vspNameBox = new System.Windows.Forms.TextBox();
			this.pu2NameBox = new System.Windows.Forms.TextBox();
			this.pu3NameBox = new System.Windows.Forms.TextBox();
			this.pu4NameBox = new System.Windows.Forms.TextBox();
			this.pn2NameBox = new System.Windows.Forms.TextBox();
			this.pn3NameBox = new System.Windows.Forms.TextBox();
			this.pn4NameBox = new System.Windows.Forms.TextBox();
			this.closeButton = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.judgeComboBox = new System.Windows.Forms.ComboBox();
			this.updateButton = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// showLocationBox
			// 
			this.showLocationBox.Location = new System.Drawing.Point(39, 41);
			this.showLocationBox.Name = "showLocationBox";
			this.showLocationBox.Size = new System.Drawing.Size(159, 20);
			this.showLocationBox.TabIndex = 1;
			this.showLocationBox.Text = "Show location";
			this.showLocationBox.Click += new System.EventHandler(this.ShowBoxClick);
			this.showLocationBox.TextChanged += new System.EventHandler(this.ShowLocationBoxTextChanged);
			this.showLocationBox.Leave += new System.EventHandler(this.ShowLocationBoxTextChanged);
			// 
			// coatBox
			// 
			this.coatBox.FormattingEnabled = true;
			this.coatBox.Items.AddRange(new object[] {
									"LK",
									"PK"});
			this.coatBox.Location = new System.Drawing.Point(39, 12);
			this.coatBox.Name = "coatBox";
			this.coatBox.Size = new System.Drawing.Size(121, 21);
			this.coatBox.TabIndex = 0;
			this.coatBox.Text = "LK";
			this.coatBox.SelectedIndexChanged += new System.EventHandler(this.CoatBoxSelectedIndexChanged);
			// 
			// judgeBox
			// 
			this.judgeBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.judgeBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.judgeBox.Location = new System.Drawing.Point(39, 68);
			this.judgeBox.Name = "judgeBox";
			this.judgeBox.ReadOnly = true;
			this.judgeBox.Size = new System.Drawing.Size(53, 20);
			this.judgeBox.TabIndex = 24;
			this.judgeBox.TabStop = false;
			this.judgeBox.Text = "Judge:";
			this.judgeBox.Click += new System.EventHandler(this.JudgeBoxClick);
			// 
			// amountBox
			// 
			this.amountBox.Location = new System.Drawing.Point(98, 96);
			this.amountBox.Name = "amountBox";
			this.amountBox.Size = new System.Drawing.Size(159, 20);
			this.amountBox.TabIndex = 3;
			this.amountBox.TextChanged += new System.EventHandler(this.AmountBoxTextChanged);
			this.amountBox.Leave += new System.EventHandler(this.AmountBoxTextChanged);
			// 
			// showTypeBox
			// 
			this.showTypeBox.FormattingEnabled = true;
			this.showTypeBox.Items.AddRange(new object[] {
									"NAT",
									"INT"});
			this.showTypeBox.Location = new System.Drawing.Point(39, 122);
			this.showTypeBox.Name = "showTypeBox";
			this.showTypeBox.Size = new System.Drawing.Size(121, 21);
			this.showTypeBox.TabIndex = 4;
			this.showTypeBox.Text = "NAT";
			this.showTypeBox.SelectedIndexChanged += new System.EventHandler(this.ShowTypeBoxSelectedIndexChanged);
			// 
			// ropButton
			// 
			this.ropButton.Location = new System.Drawing.Point(39, 163);
			this.ropButton.Name = "ropButton";
			this.ropButton.Size = new System.Drawing.Size(75, 23);
			this.ropButton.TabIndex = 5;
			this.ropButton.Text = "ROP";
			this.ropButton.UseVisualStyleBackColor = true;
			this.ropButton.Click += new System.EventHandler(this.RopButtonClick);
			// 
			// vspButton
			// 
			this.vspButton.Location = new System.Drawing.Point(39, 193);
			this.vspButton.Name = "vspButton";
			this.vspButton.Size = new System.Drawing.Size(75, 23);
			this.vspButton.TabIndex = 6;
			this.vspButton.Text = "VSP";
			this.vspButton.UseVisualStyleBackColor = true;
			this.vspButton.Click += new System.EventHandler(this.VspButtonClick);
			// 
			// pu2Button
			// 
			this.pu2Button.Location = new System.Drawing.Point(39, 223);
			this.pu2Button.Name = "pu2Button";
			this.pu2Button.Size = new System.Drawing.Size(75, 23);
			this.pu2Button.TabIndex = 7;
			this.pu2Button.Text = "PU-2";
			this.pu2Button.UseVisualStyleBackColor = true;
			this.pu2Button.Click += new System.EventHandler(this.Pu2ButtonClick);
			// 
			// pu3Button
			// 
			this.pu3Button.Location = new System.Drawing.Point(39, 253);
			this.pu3Button.Name = "pu3Button";
			this.pu3Button.Size = new System.Drawing.Size(75, 23);
			this.pu3Button.TabIndex = 8;
			this.pu3Button.Text = "PU-3";
			this.pu3Button.UseVisualStyleBackColor = true;
			this.pu3Button.Click += new System.EventHandler(this.Pu3ButtonClick);
			// 
			// pu4Button
			// 
			this.pu4Button.Location = new System.Drawing.Point(39, 283);
			this.pu4Button.Name = "pu4Button";
			this.pu4Button.Size = new System.Drawing.Size(75, 23);
			this.pu4Button.TabIndex = 9;
			this.pu4Button.Text = "PU-4";
			this.pu4Button.UseVisualStyleBackColor = true;
			this.pu4Button.Click += new System.EventHandler(this.Pu4ButtonClick);
			// 
			// pn2Button
			// 
			this.pn2Button.Location = new System.Drawing.Point(39, 313);
			this.pn2Button.Name = "pn2Button";
			this.pn2Button.Size = new System.Drawing.Size(75, 23);
			this.pn2Button.TabIndex = 10;
			this.pn2Button.Text = "PN-2";
			this.pn2Button.UseVisualStyleBackColor = true;
			this.pn2Button.Click += new System.EventHandler(this.Pn2ButtonClick);
			// 
			// pn3Button
			// 
			this.pn3Button.Location = new System.Drawing.Point(39, 343);
			this.pn3Button.Name = "pn3Button";
			this.pn3Button.Size = new System.Drawing.Size(75, 23);
			this.pn3Button.TabIndex = 11;
			this.pn3Button.Text = "PN-3";
			this.pn3Button.UseVisualStyleBackColor = true;
			this.pn3Button.Click += new System.EventHandler(this.Pn3ButtonClick);
			// 
			// pn4Button
			// 
			this.pn4Button.Location = new System.Drawing.Point(39, 373);
			this.pn4Button.Name = "pn4Button";
			this.pn4Button.Size = new System.Drawing.Size(75, 23);
			this.pn4Button.TabIndex = 12;
			this.pn4Button.Text = "PN-4";
			this.pn4Button.UseVisualStyleBackColor = true;
			this.pn4Button.Click += new System.EventHandler(this.Pn4ButtonClick);
			// 
			// addShowButton
			// 
			this.addShowButton.Location = new System.Drawing.Point(438, 300);
			this.addShowButton.Name = "addShowButton";
			this.addShowButton.Size = new System.Drawing.Size(75, 23);
			this.addShowButton.TabIndex = 13;
			this.addShowButton.Text = "Add";
			this.addShowButton.UseVisualStyleBackColor = true;
			this.addShowButton.Click += new System.EventHandler(this.AddShowButtonClick);
			// 
			// ropNameBox
			// 
			this.ropNameBox.Location = new System.Drawing.Point(165, 163);
			this.ropNameBox.Name = "ropNameBox";
			this.ropNameBox.ReadOnly = true;
			this.ropNameBox.Size = new System.Drawing.Size(164, 20);
			this.ropNameBox.TabIndex = 15;
			this.ropNameBox.TabStop = false;
			// 
			// vspNameBox
			// 
			this.vspNameBox.Location = new System.Drawing.Point(165, 195);
			this.vspNameBox.Name = "vspNameBox";
			this.vspNameBox.ReadOnly = true;
			this.vspNameBox.Size = new System.Drawing.Size(164, 20);
			this.vspNameBox.TabIndex = 15;
			this.vspNameBox.TabStop = false;
			// 
			// pu2NameBox
			// 
			this.pu2NameBox.Location = new System.Drawing.Point(165, 225);
			this.pu2NameBox.Name = "pu2NameBox";
			this.pu2NameBox.ReadOnly = true;
			this.pu2NameBox.Size = new System.Drawing.Size(164, 20);
			this.pu2NameBox.TabIndex = 16;
			this.pu2NameBox.TabStop = false;
			// 
			// pu3NameBox
			// 
			this.pu3NameBox.Location = new System.Drawing.Point(165, 253);
			this.pu3NameBox.Name = "pu3NameBox";
			this.pu3NameBox.ReadOnly = true;
			this.pu3NameBox.Size = new System.Drawing.Size(164, 20);
			this.pu3NameBox.TabIndex = 17;
			this.pu3NameBox.TabStop = false;
			// 
			// pu4NameBox
			// 
			this.pu4NameBox.Location = new System.Drawing.Point(165, 283);
			this.pu4NameBox.Name = "pu4NameBox";
			this.pu4NameBox.ReadOnly = true;
			this.pu4NameBox.Size = new System.Drawing.Size(164, 20);
			this.pu4NameBox.TabIndex = 18;
			this.pu4NameBox.TabStop = false;
			// 
			// pn2NameBox
			// 
			this.pn2NameBox.Location = new System.Drawing.Point(165, 315);
			this.pn2NameBox.Name = "pn2NameBox";
			this.pn2NameBox.ReadOnly = true;
			this.pn2NameBox.Size = new System.Drawing.Size(164, 20);
			this.pn2NameBox.TabIndex = 19;
			this.pn2NameBox.TabStop = false;
			// 
			// pn3NameBox
			// 
			this.pn3NameBox.Location = new System.Drawing.Point(165, 343);
			this.pn3NameBox.Name = "pn3NameBox";
			this.pn3NameBox.ReadOnly = true;
			this.pn3NameBox.Size = new System.Drawing.Size(164, 20);
			this.pn3NameBox.TabIndex = 20;
			this.pn3NameBox.TabStop = false;
			// 
			// pn4NameBox
			// 
			this.pn4NameBox.Location = new System.Drawing.Point(165, 373);
			this.pn4NameBox.Name = "pn4NameBox";
			this.pn4NameBox.ReadOnly = true;
			this.pn4NameBox.Size = new System.Drawing.Size(164, 20);
			this.pn4NameBox.TabIndex = 21;
			this.pn4NameBox.TabStop = false;
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(438, 373);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 14;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Location = new System.Drawing.Point(39, 96);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(53, 13);
			this.textBox1.TabIndex = 23;
			this.textBox1.Text = "Amount:";
			// 
			// judgeComboBox
			// 
			this.judgeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.judgeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.judgeComboBox.FormattingEnabled = true;
			this.judgeComboBox.Location = new System.Drawing.Point(109, 67);
			this.judgeComboBox.Name = "judgeComboBox";
			this.judgeComboBox.Size = new System.Drawing.Size(165, 21);
			this.judgeComboBox.TabIndex = 2;
			this.judgeComboBox.SelectedIndexChanged += new System.EventHandler(this.JudgeComboBoxSelectedIndexChanged);
			this.judgeComboBox.Leave += new System.EventHandler(this.JudgeComboBoxSelectedIndexChanged);
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(438, 329);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(75, 23);
			this.updateButton.TabIndex = 25;
			this.updateButton.Text = "Update";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Visible = false;
			this.updateButton.Click += new System.EventHandler(this.UpdateButtonClick);
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(438, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(104, 24);
			this.checkBox1.TabIndex = 26;
			this.checkBox1.Text = "Valid";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// AddShow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(619, 492);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.judgeComboBox);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.pn4NameBox);
			this.Controls.Add(this.pn3NameBox);
			this.Controls.Add(this.pn2NameBox);
			this.Controls.Add(this.pu4NameBox);
			this.Controls.Add(this.pu3NameBox);
			this.Controls.Add(this.pu2NameBox);
			this.Controls.Add(this.vspNameBox);
			this.Controls.Add(this.ropNameBox);
			this.Controls.Add(this.addShowButton);
			this.Controls.Add(this.pn4Button);
			this.Controls.Add(this.pn3Button);
			this.Controls.Add(this.pn2Button);
			this.Controls.Add(this.pu4Button);
			this.Controls.Add(this.pu3Button);
			this.Controls.Add(this.pu2Button);
			this.Controls.Add(this.vspButton);
			this.Controls.Add(this.ropButton);
			this.Controls.Add(this.showTypeBox);
			this.Controls.Add(this.amountBox);
			this.Controls.Add(this.judgeBox);
			this.Controls.Add(this.coatBox);
			this.Controls.Add(this.showLocationBox);
			this.Name = "AddShow";
			this.Text = "AddShow";
			this.Click += new System.EventHandler(this.AmountBoxClick);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.ComboBox judgeComboBox;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.TextBox pn4NameBox;
		private System.Windows.Forms.TextBox pn3NameBox;
		private System.Windows.Forms.TextBox pn2NameBox;
		private System.Windows.Forms.TextBox pu4NameBox;
		private System.Windows.Forms.TextBox pu3NameBox;
		private System.Windows.Forms.TextBox pu2NameBox;
		private System.Windows.Forms.TextBox vspNameBox;
		private System.Windows.Forms.TextBox ropNameBox;
		private System.Windows.Forms.Button addShowButton;
		private System.Windows.Forms.Button pn4Button;
		private System.Windows.Forms.Button pn3Button;
		private System.Windows.Forms.Button pn2Button;
		private System.Windows.Forms.Button pu4Button;
		private System.Windows.Forms.Button pu3Button;
		private System.Windows.Forms.Button pu2Button;
		private System.Windows.Forms.Button vspButton;
		private System.Windows.Forms.Button ropButton;
		private System.Windows.Forms.ComboBox showTypeBox;
		private System.Windows.Forms.TextBox amountBox;
		private System.Windows.Forms.TextBox judgeBox;
		private System.Windows.Forms.ComboBox coatBox;
		private System.Windows.Forms.TextBox showLocationBox;
	}
}
