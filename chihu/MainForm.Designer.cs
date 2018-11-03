/*
 * Created by SharpDevelop.
 * User: Tuomo
 * Date: 19/08/2014
 * Time: 13:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace chihu
{
	partial class MainForm
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
			this.addButton = new System.Windows.Forms.Button();
			this.importButton = new System.Windows.Forms.Button();
			this.addShowButton = new System.Windows.Forms.Button();
			this.newPuppyButton = new System.Windows.Forms.Button();
			this.newVeteranButton = new System.Windows.Forms.Button();
			this.addPuppyShowButton = new System.Windows.Forms.Button();
			this.addVeteranShowButton = new System.Windows.Forms.Button();
			this.confirmBox = new System.Windows.Forms.CheckBox();
			this.dropShowsButton = new System.Windows.Forms.Button();
			this.dropPuppyShowsButton = new System.Windows.Forms.Button();
			this.dropVeteranShowsButton = new System.Windows.Forms.Button();
			this.dropBreederShowsButton = new System.Windows.Forms.Button();
			this.calculateButton = new System.Windows.Forms.Button();
			this.addBreederShowButton = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.calculateAllButton = new System.Windows.Forms.Button();
			this.aboutButton = new System.Windows.Forms.Button();
			this.modifyButton = new System.Windows.Forms.Button();
			this.dumpButton = new System.Windows.Forms.Button();
			this.htmlResultsButton = new System.Windows.Forms.Button();
			this.dropPuppyButton = new System.Windows.Forms.Button();
			this.yearTextBox = new System.Windows.Forms.TextBox();
			this.debugResultsButton = new System.Windows.Forms.Button();
			this.missingParentButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(91, 104);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(91, 23);
			this.addButton.TabIndex = 0;
			this.addButton.Text = "Add new dog";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.AddButtonClick);
			// 
			// importButton
			// 
			this.importButton.Location = new System.Drawing.Point(614, 371);
			this.importButton.Name = "importButton";
			this.importButton.Size = new System.Drawing.Size(75, 23);
			this.importButton.TabIndex = 1;
			this.importButton.Text = "Import";
			this.importButton.UseVisualStyleBackColor = true;
			this.importButton.Visible = false;
			this.importButton.Click += new System.EventHandler(this.ImportButtonClick);
			// 
			// addShowButton
			// 
			this.addShowButton.Location = new System.Drawing.Point(91, 35);
			this.addShowButton.Name = "addShowButton";
			this.addShowButton.Size = new System.Drawing.Size(91, 23);
			this.addShowButton.TabIndex = 2;
			this.addShowButton.Text = "Add show";
			this.addShowButton.UseVisualStyleBackColor = true;
			this.addShowButton.Click += new System.EventHandler(this.AddShowButtonClick);
			// 
			// newPuppyButton
			// 
			this.newPuppyButton.Location = new System.Drawing.Point(213, 104);
			this.newPuppyButton.Name = "newPuppyButton";
			this.newPuppyButton.Size = new System.Drawing.Size(102, 23);
			this.newPuppyButton.TabIndex = 3;
			this.newPuppyButton.Text = "Add new puppy";
			this.newPuppyButton.UseVisualStyleBackColor = true;
			this.newPuppyButton.Click += new System.EventHandler(this.NewPuppyButtonClick);
			// 
			// newVeteranButton
			// 
			this.newVeteranButton.Location = new System.Drawing.Point(361, 104);
			this.newVeteranButton.Name = "newVeteranButton";
			this.newVeteranButton.Size = new System.Drawing.Size(104, 23);
			this.newVeteranButton.TabIndex = 4;
			this.newVeteranButton.Text = "Add new veteran";
			this.newVeteranButton.UseVisualStyleBackColor = true;
			this.newVeteranButton.Click += new System.EventHandler(this.NewVeteranButtonClick);
			// 
			// addPuppyShowButton
			// 
			this.addPuppyShowButton.Location = new System.Drawing.Point(213, 35);
			this.addPuppyShowButton.Name = "addPuppyShowButton";
			this.addPuppyShowButton.Size = new System.Drawing.Size(102, 23);
			this.addPuppyShowButton.TabIndex = 5;
			this.addPuppyShowButton.Text = "Add puppy show";
			this.addPuppyShowButton.UseVisualStyleBackColor = true;
			this.addPuppyShowButton.Click += new System.EventHandler(this.AddPuppyShowButtonClick);
			// 
			// addVeteranShowButton
			// 
			this.addVeteranShowButton.Location = new System.Drawing.Point(361, 35);
			this.addVeteranShowButton.Name = "addVeteranShowButton";
			this.addVeteranShowButton.Size = new System.Drawing.Size(104, 23);
			this.addVeteranShowButton.TabIndex = 6;
			this.addVeteranShowButton.Text = "Add veteran show";
			this.addVeteranShowButton.UseVisualStyleBackColor = true;
			this.addVeteranShowButton.Click += new System.EventHandler(this.AddVeteranShowButtonClick);
			// 
			// confirmBox
			// 
			this.confirmBox.Location = new System.Drawing.Point(704, 370);
			this.confirmBox.Name = "confirmBox";
			this.confirmBox.Size = new System.Drawing.Size(134, 24);
			this.confirmBox.TabIndex = 7;
			this.confirmBox.Text = "I know what I\'m doing";
			this.confirmBox.UseVisualStyleBackColor = true;
			this.confirmBox.CheckedChanged += new System.EventHandler(this.ConfirmBoxCheckedChanged);
			// 
			// dropShowsButton
			// 
			this.dropShowsButton.Location = new System.Drawing.Point(91, 370);
			this.dropShowsButton.Name = "dropShowsButton";
			this.dropShowsButton.Size = new System.Drawing.Size(91, 23);
			this.dropShowsButton.TabIndex = 8;
			this.dropShowsButton.Text = "Drop shows";
			this.dropShowsButton.UseVisualStyleBackColor = true;
			this.dropShowsButton.Visible = false;
			this.dropShowsButton.Click += new System.EventHandler(this.DropShowsButtonClick);
			// 
			// dropPuppyShowsButton
			// 
			this.dropPuppyShowsButton.Location = new System.Drawing.Point(201, 371);
			this.dropPuppyShowsButton.Name = "dropPuppyShowsButton";
			this.dropPuppyShowsButton.Size = new System.Drawing.Size(114, 23);
			this.dropPuppyShowsButton.TabIndex = 9;
			this.dropPuppyShowsButton.Text = "Drop puppy shows";
			this.dropPuppyShowsButton.UseVisualStyleBackColor = true;
			this.dropPuppyShowsButton.Visible = false;
			this.dropPuppyShowsButton.Click += new System.EventHandler(this.DropPuppyShowsButtonClick);
			// 
			// dropVeteranShowsButton
			// 
			this.dropVeteranShowsButton.Location = new System.Drawing.Point(321, 370);
			this.dropVeteranShowsButton.Name = "dropVeteranShowsButton";
			this.dropVeteranShowsButton.Size = new System.Drawing.Size(114, 23);
			this.dropVeteranShowsButton.TabIndex = 10;
			this.dropVeteranShowsButton.Text = "Drop veteran shows";
			this.dropVeteranShowsButton.UseVisualStyleBackColor = true;
			this.dropVeteranShowsButton.Visible = false;
			this.dropVeteranShowsButton.Click += new System.EventHandler(this.DropVeteranShowsButtonClick);
			// 
			// dropBreederShowsButton
			// 
			this.dropBreederShowsButton.Location = new System.Drawing.Point(459, 371);
			this.dropBreederShowsButton.Name = "dropBreederShowsButton";
			this.dropBreederShowsButton.Size = new System.Drawing.Size(123, 23);
			this.dropBreederShowsButton.TabIndex = 11;
			this.dropBreederShowsButton.Text = "Drop breeder shows";
			this.dropBreederShowsButton.UseVisualStyleBackColor = true;
			this.dropBreederShowsButton.Visible = false;
			this.dropBreederShowsButton.Click += new System.EventHandler(this.DropBreederShowsButtonClick);
			// 
			// calculateButton
			// 
			this.calculateButton.Location = new System.Drawing.Point(91, 154);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.Size = new System.Drawing.Size(75, 23);
			this.calculateButton.TabIndex = 12;
			this.calculateButton.Text = "Calculate";
			this.calculateButton.UseVisualStyleBackColor = true;
			this.calculateButton.Click += new System.EventHandler(this.CalculateButtonClick);
			// 
			// addBreederShowButton
			// 
			this.addBreederShowButton.Location = new System.Drawing.Point(518, 35);
			this.addBreederShowButton.Name = "addBreederShowButton";
			this.addBreederShowButton.Size = new System.Drawing.Size(75, 23);
			this.addBreederShowButton.TabIndex = 13;
			this.addBreederShowButton.Text = "Add Breeder Show";
			this.addBreederShowButton.UseVisualStyleBackColor = true;
			this.addBreederShowButton.Click += new System.EventHandler(this.AddBreederShowButtonClick);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(91, 222);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(100, 23);
			this.progressBar1.TabIndex = 14;
			this.progressBar1.Visible = false;
			// 
			// calculateAllButton
			// 
			this.calculateAllButton.Location = new System.Drawing.Point(213, 154);
			this.calculateAllButton.Name = "calculateAllButton";
			this.calculateAllButton.Size = new System.Drawing.Size(75, 23);
			this.calculateAllButton.TabIndex = 15;
			this.calculateAllButton.Text = "Calculate all";
			this.calculateAllButton.UseVisualStyleBackColor = true;
			this.calculateAllButton.Click += new System.EventHandler(this.CalculateAllButtonClick);
			// 
			// aboutButton
			// 
			this.aboutButton.Location = new System.Drawing.Point(730, 403);
			this.aboutButton.Name = "aboutButton";
			this.aboutButton.Size = new System.Drawing.Size(75, 23);
			this.aboutButton.TabIndex = 16;
			this.aboutButton.Text = "About";
			this.aboutButton.UseVisualStyleBackColor = true;
			this.aboutButton.Click += new System.EventHandler(this.AboutButtonClick);
			// 
			// modifyButton
			// 
			this.modifyButton.Location = new System.Drawing.Point(91, 295);
			this.modifyButton.Name = "modifyButton";
			this.modifyButton.Size = new System.Drawing.Size(91, 23);
			this.modifyButton.TabIndex = 17;
			this.modifyButton.Text = "Modify data";
			this.modifyButton.UseVisualStyleBackColor = true;
			this.modifyButton.Click += new System.EventHandler(this.ModifyButtonClick);
			// 
			// dumpButton
			// 
			this.dumpButton.Location = new System.Drawing.Point(614, 403);
			this.dumpButton.Name = "dumpButton";
			this.dumpButton.Size = new System.Drawing.Size(75, 23);
			this.dumpButton.TabIndex = 18;
			this.dumpButton.Text = "Dump";
			this.dumpButton.UseVisualStyleBackColor = true;
			this.dumpButton.Visible = false;
			this.dumpButton.Click += new System.EventHandler(this.DumpButtonClick);
			// 
			// htmlResultsButton
			// 
			this.htmlResultsButton.Location = new System.Drawing.Point(346, 154);
			this.htmlResultsButton.Name = "htmlResultsButton";
			this.htmlResultsButton.Size = new System.Drawing.Size(75, 23);
			this.htmlResultsButton.TabIndex = 19;
			this.htmlResultsButton.Text = "html results";
			this.htmlResultsButton.UseVisualStyleBackColor = true;
			this.htmlResultsButton.Click += new System.EventHandler(this.HtmlResultsButtonClick);
			// 
			// dropPuppyButton
			// 
			this.dropPuppyButton.Location = new System.Drawing.Point(91, 401);
			this.dropPuppyButton.Name = "dropPuppyButton";
			this.dropPuppyButton.Size = new System.Drawing.Size(91, 23);
			this.dropPuppyButton.TabIndex = 20;
			this.dropPuppyButton.Text = "drop puppies";
			this.dropPuppyButton.UseVisualStyleBackColor = true;
			this.dropPuppyButton.Visible = false;
			this.dropPuppyButton.Click += new System.EventHandler(this.DropPuppyButtonClick);
			// 
			// yearTextBox
			// 
			this.yearTextBox.Location = new System.Drawing.Point(459, 156);
			this.yearTextBox.Name = "yearTextBox";
			this.yearTextBox.Size = new System.Drawing.Size(100, 20);
			this.yearTextBox.TabIndex = 21;
			// 
			// debugResultsButton
			// 
			this.debugResultsButton.Location = new System.Drawing.Point(201, 403);
			this.debugResultsButton.Name = "debugResultsButton";
			this.debugResultsButton.Size = new System.Drawing.Size(114, 23);
			this.debugResultsButton.TabIndex = 22;
			this.debugResultsButton.Text = "debug results";
			this.debugResultsButton.UseVisualStyleBackColor = true;
			this.debugResultsButton.Visible = false;
			this.debugResultsButton.Click += new System.EventHandler(this.DebugResultsButtonClick);
			// 
			// missingParentButton
			// 
			this.missingParentButton.Location = new System.Drawing.Point(321, 403);
			this.missingParentButton.Name = "missingParentButton";
			this.missingParentButton.Size = new System.Drawing.Size(114, 23);
			this.missingParentButton.TabIndex = 23;
			this.missingParentButton.Text = "Missing parent";
			this.missingParentButton.UseVisualStyleBackColor = true;
			this.missingParentButton.Visible = false;
			this.missingParentButton.Click += new System.EventHandler(this.MissingParentButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(865, 438);
			this.Controls.Add(this.missingParentButton);
			this.Controls.Add(this.debugResultsButton);
			this.Controls.Add(this.yearTextBox);
			this.Controls.Add(this.dropPuppyButton);
			this.Controls.Add(this.htmlResultsButton);
			this.Controls.Add(this.dumpButton);
			this.Controls.Add(this.modifyButton);
			this.Controls.Add(this.aboutButton);
			this.Controls.Add(this.calculateAllButton);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.addBreederShowButton);
			this.Controls.Add(this.calculateButton);
			this.Controls.Add(this.dropBreederShowsButton);
			this.Controls.Add(this.dropVeteranShowsButton);
			this.Controls.Add(this.dropPuppyShowsButton);
			this.Controls.Add(this.dropShowsButton);
			this.Controls.Add(this.confirmBox);
			this.Controls.Add(this.addVeteranShowButton);
			this.Controls.Add(this.addPuppyShowButton);
			this.Controls.Add(this.newVeteranButton);
			this.Controls.Add(this.newPuppyButton);
			this.Controls.Add(this.addShowButton);
			this.Controls.Add(this.importButton);
			this.Controls.Add(this.addButton);
			this.Name = "MainForm";
			this.Text = "Chihu pistelasku";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button missingParentButton;
		private System.Windows.Forms.Button debugResultsButton;
		private System.Windows.Forms.TextBox yearTextBox;
		private System.Windows.Forms.Button dropPuppyButton;
		private System.Windows.Forms.Button htmlResultsButton;
		private System.Windows.Forms.Button dumpButton;
		private System.Windows.Forms.Button modifyButton;
		private System.Windows.Forms.Button aboutButton;
		private System.Windows.Forms.Button calculateAllButton;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button addBreederShowButton;
		private System.Windows.Forms.Button calculateButton;
		private System.Windows.Forms.Button dropBreederShowsButton;
		private System.Windows.Forms.Button dropVeteranShowsButton;
		private System.Windows.Forms.Button dropPuppyShowsButton;
		private System.Windows.Forms.Button dropShowsButton;
		private System.Windows.Forms.CheckBox confirmBox;
		private System.Windows.Forms.Button addVeteranShowButton;
		private System.Windows.Forms.Button addPuppyShowButton;
		private System.Windows.Forms.Button newVeteranButton;
		private System.Windows.Forms.Button newPuppyButton;
		private System.Windows.Forms.Button addShowButton;
		private System.Windows.Forms.Button importButton;
		private System.Windows.Forms.Button addButton;
	}
}
