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
	/// Description of WingDesc.
	/// </summary>
	public partial class WingDesc : Form
	{
		public SQLiteConnection sqlite_conn;
        public SQLiteCommand sqlite_cmd;
        public SQLiteDataReader sqlite_datareader;
        public SQLiteDataAdapter sqllite_Datadapter;
		public DataTable ds;
		public String tempValue;
        
		public WingDesc()
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
            sqllite_Datadapter = new SQLiteDataAdapter("SELECT Wing_Type_Desc as 'Wing Description' from WingTypeDesc",sqlite_conn);
			
            ds =  new DataTable();
            sqllite_Datadapter.Fill(ds);
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
			string valueWingDesc = wngDesctextBox1.Text;

			if (valueWingDesc == "")
            {
                MessageBox.Show("Please add Wing Description","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                sqlite_cmd.CommandText = "INSERT Into WingTypeDesc (Wing_Type_Desc) values ('" + valueWingDesc + "')";

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
			string valueWingDesc = wngDesctextBox1.Text;

			if (valueWingDesc == "")
            {
                MessageBox.Show("Please add Wing Description","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                sqlite_cmd.CommandText = "UPDATE WingTypeDesc SET Wing_Type_Desc = '" + valueWingDesc + "' WHERE Wing_Type_Desc = '"+tempValue+"'";

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
			string valueWingDesc = wngDesctextBox1.Text;
  
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
	                sqlite_cmd.CommandText = "DELETE from WingTypeDesc  WHERE Wing_Type_Desc = '"+ valueWingDesc +"'";
	
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
