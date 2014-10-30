/*
 * Created by SharpDevelop.
 * User: Arijit Bhattacharyya
 * Date: 11/2/2014
 * Time: 6:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Society_Manager
{
	partial class About
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(62, 110);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Close";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(7, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(184, 86);
			this.label1.TabIndex = 1;
			this.label1.Text = "Housing Society Manager V1.00\r\nCopyright @ Arijit Bhattacharyya\r\n\r\nSupport:\r\nEmai" +
	"l : arijitb@gmail.com\r\nPhone:  8698665199";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// About
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(199, 145);
			this.ControlBox = false;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "About";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Housing Society Manager";
			this.ResumeLayout(false);

		}
	}
}
