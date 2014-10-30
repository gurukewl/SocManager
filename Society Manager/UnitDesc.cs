/*
 * Created by SharpDevelop.
 * User: Arijit Bhattacharyya
 * Date: 11/1/2014
 * Time: 9:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
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
        
		public UnitDesc()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			editButton.Enabled =  false;
			deleteButton.Enabled = false;
			
			listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            
             // create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=SocietyManagerDB.db;Version=3;New=False;Compress=True;");

            // open the connection:
            sqlite_conn.Open();

            // create a new SQL command:
            sqlite_cmd = sqlite_conn.CreateCommand();
            
            try
            {
	            // First lets build a SQL-Query again:
	             sqlite_cmd.CommandText = "Select * from UnitTypeDesc";
	
	            // Now the SQLiteCommand object can give us a DataReader-Object:
	            sqlite_datareader = sqlite_cmd.ExecuteReader();
		             
	            while (sqlite_datareader.Read()) 
	            {
	           
	            	ListViewItem item = new ListViewItem (sqlite_datareader[0].ToString());
	            	listView1.Items.Add(item);
	            }
            }
            catch (Exception ex)
            {
            	MessageBox.Show(ex.Message);
            }
            finally
            {
                // We are ready, now lets cleanup and close our connection:
                sqlite_conn.Close();

            }
		}
		void CloseButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void AddButtonClick(object sender, EventArgs e)
		{
			string valueUnitDesc = untDesctextBox1.Text;

			if (valueUnitDesc == "")
            {
                MessageBox.Show("Please add Unit Description","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
			
            SQLiteConnection sqlite_conn;
            SQLiteCommand sqlite_cmd;
            
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
		}
	}
}
