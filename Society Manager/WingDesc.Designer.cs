/*
 * Created by SharpDevelop.
 * User: Arijit Bhattacharyya
 * Date: 11/2/2014
 * Time: 4:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Society_Manager
{
	partial class WingDesc
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.TextBox wngDesctextBox1;
		
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.closeButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.updateButton = new System.Windows.Forms.Button();
			this.addButton = new System.Windows.Forms.Button();
			this.wngDesctextBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(332, 224);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView1MouseClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.closeButton);
			this.groupBox1.Controls.Add(this.deleteButton);
			this.groupBox1.Controls.Add(this.updateButton);
			this.groupBox1.Controls.Add(this.addButton);
			this.groupBox1.Controls.Add(this.wngDesctextBox1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 242);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(332, 78);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Wing Description";
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(251, 45);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 5;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(170, 45);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(75, 23);
			this.deleteButton.TabIndex = 4;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(89, 45);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(75, 23);
			this.updateButton.TabIndex = 3;
			this.updateButton.Text = "Update";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.UpdateButtonClick);
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(6, 45);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 2;
			this.addButton.Text = "Add";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.AddButtonClick);
			// 
			// wngDesctextBox1
			// 
			this.wngDesctextBox1.Location = new System.Drawing.Point(6, 19);
			this.wngDesctextBox1.Name = "wngDesctextBox1";
			this.wngDesctextBox1.Size = new System.Drawing.Size(320, 20);
			this.wngDesctextBox1.TabIndex = 1;
			// 
			// WingDesc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(354, 331);
			this.ControlBox = false;
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox1);
			this.Name = "WingDesc";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Wing Description";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
