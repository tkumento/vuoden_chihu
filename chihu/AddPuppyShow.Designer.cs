/*
 * Created by SharpDevelop.
 * User: Tuomo
 * Date: 23/08/2014
 * Time: 17:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace chihu
{
	partial class AddPuppyShow
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
			this.addButton = new System.Windows.Forms.Button();
			this.ropPuppyButton = new System.Windows.Forms.Button();
			this.vspPuppyButton = new System.Windows.Forms.Button();
			this.ropPentuBox = new System.Windows.Forms.TextBox();
			this.vspPuppyBox = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.closeButton = new System.Windows.Forms.Button();
			this.judgeComboBox = new System.Windows.Forms.ComboBox();
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
			this.coatBox.Location = new System.Drawing.Point(39, 30);
			this.coatBox.Name = "coatBox";
			this.coatBox.Size = new System.Drawing.Size(121, 21);
			this.coatBox.TabIndex = 0;
			this.coatBox.SelectedIndexChanged += new System.EventHandler(this.CoatBoxSelectedIndexChanged);
			// 
			// showBox
			// 
			this.showBox.Location = new System.Drawing.Point(39, 70);
			this.showBox.Name = "showBox";
			this.showBox.Size = new System.Drawing.Size(144, 20);
			this.showBox.TabIndex = 1;
			this.showBox.Text = "Show location";
			this.showBox.Click += new System.EventHandler(this.ShowBoxClick);
			this.showBox.TextChanged += new System.EventHandler(this.ShowBoxTextChanged);
			this.showBox.Leave += new System.EventHandler(this.ShowBoxTextChanged);
			// 
			// judgeBox
			// 
			this.judgeBox.Location = new System.Drawing.Point(39, 111);
			this.judgeBox.Name = "judgeBox";
			this.judgeBox.ReadOnly = true;
			this.judgeBox.Size = new System.Drawing.Size(50, 20);
			this.judgeBox.TabIndex = 8;
			this.judgeBox.TabStop = false;
			this.judgeBox.Text = "Judge:";
			this.judgeBox.Click += new System.EventHandler(this.JudgeBoxClick);
			this.judgeBox.TextChanged += new System.EventHandler(this.JudgeBoxTextChanged);
			this.judgeBox.Leave += new System.EventHandler(this.JudgeBoxTextChanged);
			// 
			// dogCountBox
			// 
			this.dogCountBox.Location = new System.Drawing.Point(95, 150);
			this.dogCountBox.Name = "dogCountBox";
			this.dogCountBox.Size = new System.Drawing.Size(86, 20);
			this.dogCountBox.TabIndex = 3;
			this.dogCountBox.Text = "0";
			this.dogCountBox.Click += new System.EventHandler(this.DogCountBoxClick);
			this.dogCountBox.TextChanged += new System.EventHandler(this.DogCountBoxTextChanged);
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(347, 171);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 6;
			this.addButton.Text = "Add";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.AddButtonClick);
			// 
			// ropPuppyButton
			// 
			this.ropPuppyButton.Location = new System.Drawing.Point(39, 191);
			this.ropPuppyButton.Name = "ropPuppyButton";
			this.ropPuppyButton.Size = new System.Drawing.Size(75, 23);
			this.ropPuppyButton.TabIndex = 4;
			this.ropPuppyButton.Text = "ROP-Pentu";
			this.ropPuppyButton.UseVisualStyleBackColor = true;
			this.ropPuppyButton.Click += new System.EventHandler(this.RopPuppyButtonClick);
			// 
			// vspPuppyButton
			// 
			this.vspPuppyButton.Location = new System.Drawing.Point(39, 238);
			this.vspPuppyButton.Name = "vspPuppyButton";
			this.vspPuppyButton.Size = new System.Drawing.Size(75, 23);
			this.vspPuppyButton.TabIndex = 5;
			this.vspPuppyButton.Text = "VSP-Pentu";
			this.vspPuppyButton.UseVisualStyleBackColor = true;
			this.vspPuppyButton.Click += new System.EventHandler(this.VspPuppyButtonClick);
			// 
			// ropPentuBox
			// 
			this.ropPentuBox.Location = new System.Drawing.Point(166, 191);
			this.ropPentuBox.Name = "ropPentuBox";
			this.ropPentuBox.ReadOnly = true;
			this.ropPentuBox.Size = new System.Drawing.Size(152, 20);
			this.ropPentuBox.TabIndex = 10;
			this.ropPentuBox.TabStop = false;
			// 
			// vspPuppyBox
			// 
			this.vspPuppyBox.Location = new System.Drawing.Point(166, 241);
			this.vspPuppyBox.Name = "vspPuppyBox";
			this.vspPuppyBox.ReadOnly = true;
			this.vspPuppyBox.Size = new System.Drawing.Size(152, 20);
			this.vspPuppyBox.TabIndex = 11;
			this.vspPuppyBox.TabStop = false;
			this.vspPuppyBox.TextChanged += new System.EventHandler(this.VspPuppyBoxTextChanged);
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Location = new System.Drawing.Point(39, 153);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(50, 13);
			this.textBox1.TabIndex = 9;
			this.textBox1.TabStop = false;
			this.textBox1.Text = "amount";
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(347, 238);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 7;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
			// 
			// judgeComboBox
			// 
			this.judgeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.judgeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.judgeComboBox.FormattingEnabled = true;
			this.judgeComboBox.Location = new System.Drawing.Point(113, 110);
			this.judgeComboBox.Name = "judgeComboBox";
			this.judgeComboBox.Size = new System.Drawing.Size(121, 21);
			this.judgeComboBox.TabIndex = 2;
			this.judgeComboBox.SelectedIndexChanged += new System.EventHandler(this.JudgeComboBoxSelectedIndexChanged);
			this.judgeComboBox.Leave += new System.EventHandler(this.JudgeComboBoxSelectedIndexChanged);
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(347, 200);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(75, 23);
			this.updateButton.TabIndex = 12;
			this.updateButton.Text = "Update";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Visible = false;
			this.updateButton.Click += new System.EventHandler(this.UpdateButtonClick);
			// 
			// AddPuppyShow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(597, 538);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.judgeComboBox);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.vspPuppyBox);
			this.Controls.Add(this.ropPentuBox);
			this.Controls.Add(this.vspPuppyButton);
			this.Controls.Add(this.ropPuppyButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.dogCountBox);
			this.Controls.Add(this.judgeBox);
			this.Controls.Add(this.showBox);
			this.Controls.Add(this.coatBox);
			this.Name = "AddPuppyShow";
			this.Text = "AddPuppyShow";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.ComboBox judgeComboBox;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox vspPuppyBox;
		private System.Windows.Forms.TextBox ropPentuBox;
		private System.Windows.Forms.Button vspPuppyButton;
		private System.Windows.Forms.Button ropPuppyButton;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.TextBox dogCountBox;
		private System.Windows.Forms.TextBox judgeBox;
		private System.Windows.Forms.TextBox showBox;
		private System.Windows.Forms.ComboBox coatBox;
	}
}
