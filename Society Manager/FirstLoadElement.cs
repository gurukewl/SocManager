/*
 * Created by SharpDevelop.
 * User: Arijit Bhattacharyya
 * Date: 11/2/2014
 * Time: 6:44 PM
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
	/// Represents a single XML tag inside a ConfigurationSection
	/// or a ConfigurationElementCollection.
	/// </summary>
	public static class FirstLoadElement
	{
		public static SQLiteConnection sqlite_conn;
        public static SQLiteCommand sqlite_cmd;
        public static SQLiteDataReader sqlite_datareader;
        
		public static List<string> Retrieve_untdesc()
        {
            
            List<string> unitDesc = new List<string>();

            // create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=SocietyManagerDB.db;Version=3;New=False;Compress=True;;");

            // open the connection:
            sqlite_conn.Open();

            // create a new SQL command:
            sqlite_cmd = sqlite_conn.CreateCommand();

            // First lets build a SQL-Query again:
            sqlite_cmd.CommandText = "SELECT Unit_Type_Desc FROM UnitTypeDesc order by Unit_Type_Desc asc";

            // Now the SQLiteCommand object can give us a DataReader-Object:
            sqlite_datareader = sqlite_cmd.ExecuteReader();

            // The SQLiteDataReader allows us to run through the result lines:
            while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
            {
                // Print out the content of the text field:
                String result = sqlite_datareader.GetString(0);
                unitDesc.Add(result);
            }

            // We are ready, now lets cleanup and close our connection:
            sqlite_conn.Close();

            return (unitDesc);
        }
	}
	
}

