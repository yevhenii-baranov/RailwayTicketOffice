using RailwayTicketOffice.Entity;
using RailwayTicketOffice.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailwayTicketOffice
{
    public partial class PassportDataForm : Form
    {
        private readonly User currentUser = TicketOfficeApplication.GetInstance().CurrentUser;
        private readonly UserManagementService service = TicketOfficeApplication.GetInstance().GetUserManagementService();
        public PassportDataForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (PassportDataBox.Text == "")
            {
                MessageBox.Show("Please enter the data.");
                return;
            }

            TicketOfficeApplication.GetInstance().CurrentUser = 
                service.AddPassportData(currentUser, PassportDataBox.Text);

            this.Close();
        }
    }
}
