/*
 * Created by SharpDevelop.
 * User: Tuomo
 * Date: 19/08/2014
 * Time: 19:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace chihu
{
	partial class ImportCSV
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
			this.importDogsButton = new System.Windows.Forms.Button();
			this.importPuppiesButton = new System.Windows.Forms.Button();
			this.importVeteransButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// importDogsButton
			// 
			this.importDogsButton.Location = new System.Drawing.Point(41, 210);
			this.importDogsButton.Name = "importDogsButton";
			this.importDogsButton.Size = new System.Drawing.Size(75, 23);
			this.importDogsButton.TabIndex = 0;
			this.importDogsButton.Text = "Dogs";
			this.importDogsButton.UseVisualStyleBackColor = true;
			this.importDogsButton.Click += new System.EventHandler(this.ImportDogsButtonClick);
			// 
			// importPuppiesButton
			// 
			this.importPuppiesButton.Location = new System.Drawing.Point(160, 210);
			this.importPuppiesButton.Name = "importPuppiesButton";
			this.importPuppiesButton.Size = new System.Drawing.Size(75, 23);
			this.importPuppiesButton.TabIndex = 1;
			this.importPuppiesButton.Text = "Puppies";
			this.importPuppiesButton.UseVisualStyleBackColor = true;
			this.importPuppiesButton.Click += new System.EventHandler(this.ImportPuppiesButtonClick);
			// 
			// importVeteransButton
			// 
			this.importVeteransButton.Location = new System.Drawing.Point(294, 210);
			this.importVeteransButton.Name = "importVeteransButton";
			this.importVeteransButton.Size = new System.Drawing.Size(75, 23);
			this.importVeteransButton.TabIndex = 2;
			this.importVeteransButton.Text = "Veterans";
			this.importVeteransButton.UseVisualStyleBackColor = true;
			this.importVeteransButton.Click += new System.EventHandler(this.ImportVeteransButtonClick);
			// 
			// ImportCSV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(468, 303);
			this.Controls.Add(this.importVeteransButton);
			this.Controls.Add(this.importPuppiesButton);
			this.Controls.Add(this.importDogsButton);
			this.Name = "ImportCSV";
			this.Text = "Import dogs";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button importVeteransButton;
		private System.Windows.Forms.Button importPuppiesButton;
		private System.Windows.Forms.Button importDogsButton;
	}
}
