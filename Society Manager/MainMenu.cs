using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Society_Manager
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void createNewSocietyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
		void Panel1Paint(object sender, PaintEventArgs e)
		{
	
		}
		void NewDBToolStripMenuItemClick(object sender, EventArgs e)
		{
			DB dbForm = new DB();
			dbForm.Show();
		}
		void LedgerAccountsToolStripMenuItemClick(object sender, EventArgs e)
		{
	
		}
		void SocietyUnitTypesToolStripMenuItemClick(object sender, EventArgs e)
		{
			UnitDesc untDesc = new UnitDesc();
			untDesc.Show();
		}
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void SocietyWingsToolStripMenuItemClick(object sender, EventArgs e)
		{
			WingDesc wngDesc = new WingDesc();
			wngDesc.Show();
		}
		void AboutSocietyManagerToolStripMenuItemClick(object sender, EventArgs e)
		{
			About abt = new About();
			abt.Show();
		}
		void SocietyAreaInSqFtToolStripMenuItemClick(object sender, EventArgs e)
		{
			UnitArea untArea = new UnitArea();
			untArea.Show();
		}
    }
}
