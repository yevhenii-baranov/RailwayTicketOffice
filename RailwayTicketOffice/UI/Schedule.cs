using RailwayTicketOffice.Entity;
using RailwayTicketOffice.Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RailwayTicketOffice
{
    public partial class Schedule : Form
    {

        private readonly TrainFindingService service = TicketOfficeApplication.GetInstance().GetTrainFindingService();
        private readonly LoginForm parent;
        private readonly string currentUserName = TicketOfficeApplication.GetInstance().CurrentUser.Username;
        private bool dateSet = false;

        public Schedule(LoginForm parent)
        {
            InitializeComponent();
            TrainsListView.View = View.Details;

            UsernameLabel.Text = $"You are now logged in as {currentUserName}";
                
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
            TrainsListView.Items.Clear();

            List<Trip> filteredTrips;

            TrainStation fromStation = null;
            TrainStation toStation = null;
            DateTime? departureDate = null;

            if (FromTextBox.Text != "" && ToTextBox.Text != "")
            {
               fromStation = TrainFindingService.StationForName(FromTextBox.Text);
               toStation = TrainFindingService.StationForName(ToTextBox.Text);
            }
            if (dateSet)
            {
                departureDate = DatePicker.Value;
            }

            filteredTrips = service.FindTrips(fromStation, toStation, departureDate);

            foreach (var trip in filteredTrips)
            {
                string[] values = { trip.Train.DepartureStation.Name, trip.Train.ArrivalStation.Name };
                var item = new ListViewItem(values);
                TrainsListView.Items.Add(item);
            }
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
