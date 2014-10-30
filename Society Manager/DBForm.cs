/*
 * Created by SharpDevelop.
 * User: Arijit Bhattacharyya
 * Date: 11/1/2014
 * Time: 5:17 PM
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
	/// Description of DB.
	/// </summary>
	public partial class DB : Form
	{
		public DB()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
		//Define the Variables
            SQLiteConnection sqlite_conn;
            SQLiteCommand sqlite_cmd;
            string currentYear = DateTime.Now.Year.ToString();
            Cursor.Current = Cursors.WaitCursor;
            sqlite_conn = new SQLiteConnection("Data Source=SocietyManagerDB.db;Version=3;New=True;Compress=True;");
            
            // open the connection:
            sqlite_conn.Open();

            // create a new SQL command:
            sqlite_cmd = sqlite_conn.CreateCommand();
            try
            {
                // Creating the Unit Type Description table first
                sqlite_cmd.CommandText = "CREATE TABLE UnitTypeDesc (Unit_Type_Desc varchar(50) NOT NULL, PRIMARY KEY(Unit_Type_Desc));";

                // Now lets execute the SQL
                sqlite_cmd.ExecuteNonQuery();
                
                // Creating the Wing type Description table first
                sqlite_cmd.CommandText = "CREATE TABLE WingTypeDesc (Wing_Type_Desc varchar(50) NOT NULL, PRIMARY KEY(Wing_Type_Desc));";

                // Now lets execute the SQL
                sqlite_cmd.ExecuteNonQuery();
                
                // Creating the Unit Area table first
                sqlite_cmd.CommandText = "CREATE TABLE UnitArea (Unit_Area double(10) NOT NULL,Unit_Type_Desc Varchar(50) NOT NULL, PRIMARY KEY(Unit_Area, Unit_Type_Desc) FOREIGN KEY(Unit_Type_Desc) REFERENCES UnitTypeDesc(Unit_Type_Desc));";

                // Now lets execute the SQL
                sqlite_cmd.ExecuteNonQuery();

                Cursor.Current = Cursors.Default;
                MessageBox.Show("All Databases created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
