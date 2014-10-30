/*
 * Created by SharpDevelop.
 * User: Arijit Bhattacharyya
 * Date: 11/1/2014
 * Time: 9:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Society_Manager
{
	/// <summary>
	/// Description of UnitDesc.
	/// </summary>
	public partial class UnitDesc : Form
	{
		public SQLiteConnection sqlite_conn;
        public SQLiteCommand sqlite_cmd;
        public SQLiteDataReader sqlite_datareader;
        public SQLiteDataAdapter sqllite_datadapter;
		public DataTable ds;
		public String tempValue;
        
		public UnitDesc()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			fillData();
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
            sqllite_datadapter = new SQLiteDataAdapter("SELECT Unit_Type_Desc as 'Unit Description' from UnitTypeDesc",sqlite_conn);
			
            ds =  new DataTable();
            sqllite_datadapter.Fill(ds);
            dataGridView1.DataSource = ds;
            
            // We are ready, now lets cleanup and close our connection:
            sqlite_conn.Close();
            
            addButton.Enabled = true;
			deleteButton.Enabled = false;
			updateButton.Enabled = false;
			wngDesctextBox1.Text = "";

		}
		
		void CloseButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void AddButtonClick(object sender, EventArgs e)
		{
			string valueUnitDesc = wngDesctextBox1.Text;

			if (valueUnitDesc == "")
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
                sqlite_cmd.CommandText = "INSERT Into UnitTypeDesc (Unit_Type_Desc) values ('" + valueUnitDesc + "')";

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
			wngDesctextBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
			tempValue =  wngDesctextBox1.Text;
		}
		
		void UpdateButtonClick(object sender, EventArgs e)
		{
			string valueUnitDesc = wngDesctextBox1.Text;

			if (valueUnitDesc == "")
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
                sqlite_cmd.CommandText = "UPDATE UnitTypeDesc SET Unit_Type_Desc = '" + valueUnitDesc + "' WHERE Unit_Type_Desc = '"+tempValue+"'";

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
			string valueUnitDesc = wngDesctextBox1.Text;
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
	                sqlite_cmd.CommandText = "DELETE from UnitTypeDesc  WHERE Unit_Type_Desc = '"+ valueUnitDesc +"'";
	
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
