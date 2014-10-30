/*
 * Created by SharpDevelop.
 * User: Arijit Bhattacharyya
 * Date: 11/2/2014
 * Time: 6:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Society_Manager
{
	partial class UnitArea
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.TextBox untAreatextBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox selUnitType;
		private System.Windows.Forms.Label label2;
		
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
			this.closeButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.updateButton = new System.Windows.Forms.Button();
			this.addButton = new System.Windows.Forms.Button();
			this.untAreatextBox1 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.selUnitType = new System.Windows.Forms.ComboBox();
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
			this.dataGridView1.TabIndex = 6;
			this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView1MouseClick);
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(251, 71);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 11;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(174, 71);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(75, 23);
			this.deleteButton.TabIndex = 10;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(93, 71);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(75, 23);
			this.updateButton.TabIndex = 9;
			this.updateButton.Text = "Update";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.UpdateButtonClick);
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(12, 71);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 8;
			this.addButton.Text = "Add";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.AddButtonClick);
			// 
			// untAreatextBox1
			// 
			this.untAreatextBox1.Location = new System.Drawing.Point(12, 40);
			this.untAreatextBox1.Name = "untAreatextBox1";
			this.untAreatextBox1.Size = new System.Drawing.Size(156, 20);
			this.untAreatextBox1.TabIndex = 7;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.selUnitType);
			this.groupBox1.Controls.Add(this.untAreatextBox1);
			this.groupBox1.Controls.Add(this.addButton);
			this.groupBox1.Controls.Add(this.closeButton);
			this.groupBox1.Controls.Add(this.updateButton);
			this.groupBox1.Controls.Add(this.deleteButton);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 242);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(332, 100);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Unit Area in Sq. Ft";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(174, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(151, 21);
			this.label2.TabIndex = 14;
			this.label2.Text = "Unit Type";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(151, 21);
			this.label1.TabIndex = 13;
			this.label1.Text = "Unit Area in Sq. Ft.";
			// 
			// selUnitType
			// 
			this.selUnitType.FormattingEnabled = true;
			this.selUnitType.Location = new System.Drawing.Point(174, 39);
			this.selUnitType.Name = "selUnitType";
			this.selUnitType.Size = new System.Drawing.Size(152, 21);
			this.selUnitType.TabIndex = 12;
			// 
			// UnitArea
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(354, 349);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "UnitArea";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Unit Area for Unit Type";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
