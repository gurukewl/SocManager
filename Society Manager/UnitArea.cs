/*
 * Created by SharpDevelop.
 * User: Arijit Bhattacharyya
 * Date: 11/2/2014
 * Time: 6:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Society_Manager
{
	/// <summary>
	/// Description of UnitArea.
	/// </summary>
	public partial class UnitArea : Form
	{
		public SQLiteConnection sqlite_conn;
        public SQLiteCommand sqlite_cmd;
        public SQLiteDataReader sqlite_datareader;
        public SQLiteDataAdapter sqllite_datadapter;
		public DataTable ds;
		public String tempValue;
		public String tempValue1;
		
		public UnitArea()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			List<string> unitDesc = FirstLoadElement.Retrieve_untdesc();
            for (int i = 0; i < unitDesc.Count; i++) // Loop through List with for
            {
                selUnitType.Items.Add(unitDesc[i]);
            }
			fillData();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void fillData()
		{
			
			updateButton.Enabled =  false;
			deleteButton.Enabled = false;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    		
             // create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=SocietyManagerDB.db;Version=3;New=False;Compress=True;");
            
            //open the connection:
            sqlite_conn.Open();
          
            //Define the DataAdapter
            sqllite_datadapter = new SQLiteDataAdapter("SELECT Unit_Area as 'Unit Area', Unit_Type_desc as 'Unit Description' from UnitArea",sqlite_conn);
			
            ds =  new DataTable();
            sqllite_datadapter.Fill(ds);
            dataGridView1.DataSource = ds;
            
            // We are ready, now lets cleanup and close our connection:
            sqlite_conn.Close();
            
            addButton.Enabled = true;
			deleteButton.Enabled = false;
			updateButton.Enabled = false;
			untAreatextBox1.Text = "";
			selUnitType.Text = "";

		}
		
		void CloseButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void AddButtonClick(object sender, EventArgs e)
		{
			string valueArea = untAreatextBox1.Text;
			string valueUnitDesc = selUnitType.Text;

			if (valueArea == "")
            {
                MessageBox.Show("Please add Unit Description","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
			            
            // create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=SocietyManagerDB.db;Version=3;New=False;Compress=True;");

            // open the connection:
            sqlite_conn.Open();

            // create a new SQL command:
            sqlite_cmd = sqlite_conn.CreateCommand();

            try
            {
                // First lets build a SQL-Query again:
                sqlite_cmd.CommandText = "INSERT Into UnitArea (Unit_Area,Unit_Type_Desc) values ('"+ valueArea +"','" + valueUnitDesc + "')";

                // And execute this again ;D
                sqlite_cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                // We are ready, now lets cleanup and close our connection:
                sqlite_conn.Close();
            }

            fillData();
		}
		
		void DataGridView1MouseClick(object sender, MouseEventArgs e)
		{
			addButton.Enabled = false;
			deleteButton.Enabled = true;
			updateButton.Enabled = true;
			untAreatextBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
			selUnitType.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
			tempValue =  untAreatextBox1.Text;
			tempValue1 = selUnitType.Text;
		}
		void UpdateButtonClick(object sender, EventArgs e)
		{
			string valueArea = untAreatextBox1.Text;
			string valueUnitDesc = selUnitType.Text;

			if (valueArea == "")
            {
                MessageBox.Show("Please add Unit Description","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
			            
            // create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=SocietyManagerDB.db;Version=3;New=False;Compress=True;");

            // open the connection:
            sqlite_conn.Open();

            // create a new SQL command:
            sqlite_cmd = sqlite_conn.CreateCommand();

            try
            {
                // First lets build a SQL-Query again:
                sqlite_cmd.CommandText = "UPDATE UnitArea SET Unit_Area = '" + valueArea + "',Unit_Type_Desc = '" + valueUnitDesc + "' WHERE Unit_Area = '"+ tempValue +"' and Unit_Type_Desc = '"+ tempValue1 +"'";

                // And execute this again ;D
                sqlite_cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                // We are ready, now lets cleanup and close our connection:
                sqlite_conn.Close();
            }

            fillData();
		}
		void DeleteButtonClick(object sender, EventArgs e)
		{
			string valueArea = untAreatextBox1.Text;
			string valueUnitDesc = selUnitType.Text;
  			
			DialogResult dialogResult = MessageBox.Show("Do you want to delete the current entry?","Warning",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
			if (dialogResult == DialogResult.Yes)
			{
	            // create a new database connection:
	            sqlite_conn = new SQLiteConnection("Data Source=SocietyManagerDB.db;Version=3;New=False;Compress=True;");
	
	            // open the connection:
	            sqlite_conn.Open();
	
	            // create a new SQL command:
	            sqlite_cmd = sqlite_conn.CreateCommand();
	
	            try
	            {
	                // First lets build a SQL-Query again:
	                sqlite_cmd.CommandText = "DELETE from UnitArea  WHERE Unit_Area = '" + valueArea + "' and Unit_Type_Desc = '"+ valueUnitDesc +"'";
	
	                // And execute this again ;D
	                sqlite_cmd.ExecuteNonQuery();
	
	            }
	            catch (Exception ex)
	            {
	                MessageBox.Show(ex.Message.ToString());
	            }
	            finally
	            {
	                // We are ready, now lets cleanup and close our connection:
	                sqlite_conn.Close();
	            }
	
	            fillData();
			}
			else if (dialogResult == DialogResult.No)
			{
                return;
            }
		}
	}
}
