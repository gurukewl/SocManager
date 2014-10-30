/*
 * Created by SharpDevelop.
 * User: Arijit Bhattacharyya
 * Date: 11/1/2014
 * Time: 5:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Society_Manager
{
	partial class DB
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button Button2;
		
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
			this.Button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(14, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(147, 38);
			this.button1.TabIndex = 0;
			this.button1.Text = "Create New Database";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Button2
			// 
			this.Button2.Location = new System.Drawing.Point(50, 71);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(75, 23);
			this.Button2.TabIndex = 1;
			this.Button2.Text = "Close";
			this.Button2.UseVisualStyleBackColor = true;
			this.Button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// DB
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(174, 101);
			this.ControlBox = false;
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.button1);
			this.Name = "DB";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Database";
			this.TopMost = true;
			this.ResumeLayout(false);

		}
	}
}
