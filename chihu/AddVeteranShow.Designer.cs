/*
 * Created by SharpDevelop.
 * User: Tuomo
 * Date: 23/08/2014
 * Time: 17:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace chihu
{
	partial class AddVeteranShow
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
			this.judgeBox = new System.Windows.Forms.TextBox();
			this.dogCountBox = new System.Windows.Forms.TextBox();
			this.ropVetButton = new System.Windows.Forms.Button();
			this.vspVetButton = new System.Windows.Forms.Button();
			this.ropVetBox = new System.Windows.Forms.TextBox();
			this.vspVetBox = new System.Windows.Forms.TextBox();
			this.addButton = new System.Windows.Forms.Button();
			this.closeButton = new System.Windows.Forms.Button();
			this.judgeComboBox = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.updateButton = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.textBoxGuessVeteran = new System.Windows.Forms.TextBox();
			this.buttonGuess = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// coatBox
			// 
			this.coatBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.coatBox.FormattingEnabled = true;
			this.coatBox.Items.AddRange(new object[] {
			"LK",
			"PK"});
			this.coatBox.Location = new System.Drawing.Point(40, 35);
			this.coatBox.Name = "coatBox";
			this.coatBox.Size = new System.Drawing.Size(121, 21);
			this.coatBox.TabIndex = 0;
			this.coatBox.SelectedIndexChanged += new System.EventHandler(this.CoatBoxSelectedIndexChanged);
			// 
			// showBox
			// 
			this.showBox.Location = new System.Drawing.Point(40, 86);
			this.showBox.Name = "showBox";
			this.showBox.Size = new System.Drawing.Size(100, 20);
			this.showBox.TabIndex = 1;
			this.showBox.Text = "Show location";
			this.showBox.Click += new System.EventHandler(this.ShowBoxClick);
			this.showBox.TextChanged += new System.EventHandler(this.ShowBoxTextChanged);
			this.showBox.Leave += new System.EventHandler(this.ShowBoxTextChanged);
			// 
			// judgeBox
			// 
			this.judgeBox.Location = new System.Drawing.Point(40, 130);
			this.judgeBox.Name = "judgeBox";
			this.judgeBox.ReadOnly = true;
			this.judgeBox.Size = new System.Drawing.Size(52, 20);
			this.judgeBox.TabIndex = 2;
			this.judgeBox.TabStop = false;
			this.judgeBox.Text = "Judge:";
			// 
			// dogCountBox
			// 
			this.dogCountBox.Location = new System.Drawing.Point(143, 180);
			this.dogCountBox.Name = "dogCountBox";
			this.dogCountBox.Size = new System.Drawing.Size(100, 20);
			this.dogCountBox.TabIndex = 4;
			this.dogCountBox.Text = "2";
			this.dogCountBox.Click += new System.EventHandler(this.AmountBoxClick);
			this.dogCountBox.Leave += new System.EventHandler(this.DogCountBoxTextChanged);
			// 
			// ropVetButton
			// 
			this.ropVetButton.Location = new System.Drawing.Point(40, 221);
			this.ropVetButton.Name = "ropVetButton";
			this.ropVetButton.Size = new System.Drawing.Size(75, 23);
			this.ropVetButton.TabIndex = 5;
			this.ropVetButton.Text = "ROP-VET";
			this.ropVetButton.UseVisualStyleBackColor = true;
			this.ropVetButton.Click += new System.EventHandler(this.RopVetButtonClick);
			// 
			// vspVetButton
			// 
			this.vspVetButton.Location = new System.Drawing.Point(40, 266);
			this.vspVetButton.Name = "vspVetButton";
			this.vspVetButton.Size = new System.Drawing.Size(75, 23);
			this.vspVetButton.TabIndex = 6;
			this.vspVetButton.Text = "VSP-VET";
			this.vspVetButton.UseVisualStyleBackColor = true;
			this.vspVetButton.Click += new System.EventHandler(this.VspVetButtonClick);
			// 
			// ropVetBox
			// 
			this.ropVetBox.Location = new System.Drawing.Point(151, 221);
			this.ropVetBox.Name = "ropVetBox";
			this.ropVetBox.ReadOnly = true;
			this.ropVetBox.Size = new System.Drawing.Size(170, 20);
			this.ropVetBox.TabIndex = 7;
			this.ropVetBox.TabStop = false;
			// 
			// vspVetBox
			// 
			this.vspVetBox.Location = new System.Drawing.Point(151, 266);
			this.vspVetBox.Name = "vspVetBox";
			this.vspVetBox.ReadOnly = true;
			this.vspVetBox.Size = new System.Drawing.Size(170, 20);
			this.vspVetBox.TabIndex = 8;
			this.vspVetBox.TabStop = false;
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(406, 203);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 9;
			this.addButton.Text = "Add";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.AddButtonClick);
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(406, 266);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 10;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
			// 
			// judgeComboBox
			// 
			this.judgeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.judgeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.judgeComboBox.FormattingEnabled = true;
			this.judgeComboBox.Location = new System.Drawing.Point(122, 129);
			this.judgeComboBox.Name = "judgeComboBox";
			this.judgeComboBox.Size = new System.Drawing.Size(121, 21);
			this.judgeComboBox.TabIndex = 3;
			this.judgeComboBox.SelectedIndexChanged += new System.EventHandler(this.JudgeComboBoxSelectedIndexChanged);
			this.judgeComboBox.Leave += new System.EventHandler(this.JudgeComboBoxSelectedIndexChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(40, 180);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(90, 20);
			this.textBox1.TabIndex = 11;
			this.textBox1.TabStop = false;
			this.textBox1.Text = "Veteran amount:";
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(406, 233);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(75, 23);
			this.updateButton.TabIndex = 12;
			this.updateButton.Text = "Update";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Visible = false;
			this.updateButton.Click += new System.EventHandler(this.UpdateButtonClick);
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(406, 31);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(104, 24);
			this.checkBox1.TabIndex = 13;
			this.checkBox1.Text = "Valid";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// textBoxGuessVeteran
			// 
			this.textBoxGuessVeteran.Location = new System.Drawing.Point(40, 319);
			this.textBoxGuessVeteran.Multiline = true;
			this.textBoxGuessVeteran.Name = "textBoxGuessVeteran";
			this.textBoxGuessVeteran.Size = new System.Drawing.Size(355, 88);
			this.textBoxGuessVeteran.TabIndex = 14;
			// 
			// buttonGuess
			// 
			this.buttonGuess.Location = new System.Drawing.Point(406, 319);
			this.buttonGuess.Name = "buttonGuess";
			this.buttonGuess.Size = new System.Drawing.Size(75, 23);
			this.buttonGuess.TabIndex = 15;
			this.buttonGuess.Text = "Guess";
			this.buttonGuess.UseVisualStyleBackColor = true;
			this.buttonGuess.Click += new System.EventHandler(this.ButtonGuessClick);
			// 
			// AddVeteranShow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(618, 437);
			this.Controls.Add(this.buttonGuess);
			this.Controls.Add(this.textBoxGuessVeteran);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.judgeComboBox);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.vspVetBox);
			this.Controls.Add(this.ropVetBox);
			this.Controls.Add(this.vspVetButton);
			this.Controls.Add(this.ropVetButton);
			this.Controls.Add(this.dogCountBox);
			this.Controls.Add(this.judgeBox);
			this.Controls.Add(this.showBox);
			this.Controls.Add(this.coatBox);
			this.Name = "AddVeteranShow";
			this.Text = "AddVeteranShow";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox judgeComboBox;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.TextBox vspVetBox;
		private System.Windows.Forms.TextBox ropVetBox;
		private System.Windows.Forms.Button vspVetButton;
		private System.Windows.Forms.Button ropVetButton;
		private System.Windows.Forms.TextBox dogCountBox;
		private System.Windows.Forms.TextBox judgeBox;
		private System.Windows.Forms.TextBox showBox;
		private System.Windows.Forms.ComboBox coatBox;
		private System.Windows.Forms.TextBox textBoxGuessVeteran;
		private System.Windows.Forms.Button buttonGuess;
	}
}
