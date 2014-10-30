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
                // Creating the subsidy table first
                sqlite_cmd.CommandText = "CREATE TABLE UnitTypeDesc (Unit_Type_Desc Varchar(50) NOT NULL, PRIMARY KEY(Unit_Type_Desc));";

                // Now lets execute the SQL ;D
                sqlite_cmd.ExecuteNonQuery();

//                //Creating the Resident information table
//                sqlite_cmd.CommandText = "CREATE TABLE Resident_Detail (Flat_No varchar(10) PRIMARY KEY NOT NULL, Name varchar(200), Subsidy_Status varchar(10),Total_Units double);";
//                //Execute the sql
//                sqlite_cmd.ExecuteNonQuery();
//
//                //Creating the reading input table
//                sqlite_cmd.CommandText = "CREATE TABLE Gas_Reading (Flat_No varchar(10) NOT NULL, Reading_Year varchar(04) NOT NULL, Reading_Month varchar(10) NOT NULL, Reading_Date date, Reading_Unit double, PRIMARY KEY (Flat_No, Reading_Year, Reading_Month), FOREIGN KEY(Flat_No) REFERENCES Resident_Detail(Flat_No));";
//                //Execute the query
//                sqlite_cmd.ExecuteNonQuery();
//
//                //Creating the reading input table
//                sqlite_cmd.CommandText = "CREATE TABLE Invoice_Detail (Flat_No varchar(10) NOT NULL, Reading_Year varchar(04) NOT NULL, Reading_Month varchar(10) NOT NULL, Current_Date date, Current_Unit varchar(06),Last_Date date, Last_Unit varchar(06),Subsidy_Unit varchar(06), NonSubsidy_Unit varchar(06), Span varchar(02),Unit varchar(06), Invoice_Date date, Paid_Date date, Invoice_Amount varchar(10), Paid_Amount varchar(10), PRIMARY KEY (Flat_No, Reading_Year, Reading_Month), FOREIGN KEY(Flat_No) REFERENCES Resident_Detail(Flat_No));";
//                //Execute the query
//                sqlite_cmd.ExecuteNonQuery();

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
