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
    public partial class Schedule : Form
    {
        private readonly LoginForm parent;
        private bool dateSet = false;

        public Schedule(LoginForm parent)
        {
            InitializeComponent();

            this.parent = parent;
            UpdateFilters();
        }
        
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            TicketOfficeApplication.GetInstance().CurrentUser = null;
            parent.Show();
            this.Close();
        }

        private void UpdateFilters()
        {
            //TODO: get data
        }

        private void ClearDateButton_Click(object sender, EventArgs e)
        {
            dateSet = false;
            DatePicker.Value = DateTime.Now;

            UpdateFilters();
        }

        private void ClearRouteButton_Click(object sender, EventArgs e)
        {
            FromTextBox.Text = "";
            ToTextBox.Text = "";

            UpdateFilters();
        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            string temp = FromTextBox.Text;
            FromTextBox.Text = ToTextBox.Text;
            ToTextBox.Text = temp;

            UpdateFilters();
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            dateSet = true;

            UpdateFilters();
        }
    }
}
