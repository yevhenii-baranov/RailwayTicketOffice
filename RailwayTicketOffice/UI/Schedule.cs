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
        private readonly User currentUser = TicketOfficeApplication.GetInstance().CurrentUser;
        private bool dateSet;
        private List<Trip> currentTripList;

        public Schedule(LoginForm parent)
        {
            InitializeComponent();
            TrainsListView.View = View.Details;

            UsernameLabel.Text = $"You are now logged in as {currentUser.Username}";
            if(currentUser.UserRole == User.Role.ADMINISTRATOR)
            {
                AdminSettingsButton.Visible = true;
            }
            DatePicker.MinDate = DateTime.Now;

            dateSet = false;
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

            currentTripList = service.FindTrips(fromStation, toStation, departureDate);

            foreach (var trip in currentTripList)
            {
                string[] values = { trip.Train.DepartureStation.Name,
                                    trip.Train.ArrivalStation.Name,
                                    trip.TripDate.ToShortDateString(),
                                    trip.Train.DepartureTime.ToString(@"hh\:mm"),
                                    trip.Train.ArrivalTime.ToString(@"hh\:mm")};
                var item = new ListViewItem(values);
                TrainsListView.Items.Add(item);
            }

            TrainsListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            TrainsListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            TrainsListView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
            TrainsListView.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize);
            TrainsListView.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.HeaderSize);
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

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            TicketInfo infoWindow = new TicketInfo();
            infoWindow.ShowDialog();
        }

        private void AdminSettingsButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TrainsListView_DoubleClick(object sender, EventArgs e)
        {
            int position = TrainsListView.SelectedIndices[0];
            TicketChooseForm ticketForm = new TicketChooseForm(currentTripList[position]);
            ticketForm.ShowDialog();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            UpdateFilters();
        }
    }
}
