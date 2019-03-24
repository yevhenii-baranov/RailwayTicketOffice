using RailwayTicketOffice.Entity;
using RailwayTicketOffice.Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RailwayTicketOffice
{
    public partial class TicketChooseForm : Form
    {
        private readonly TrainFindingService service = TicketOfficeApplication.GetInstance().GetTrainFindingService();
        private readonly Trip trip;
        private readonly List<Carriage> carriages;
        private List<CarriageSeat> seats;
        private readonly User currentUser = TicketOfficeApplication.GetInstance().CurrentUser;

        public TicketChooseForm(Trip trip)
        {
            InitializeComponent();

            this.trip = trip;
            this.carriages = service.GetCarriagesForTrain(trip.Train);

            CarriageBox.Items.AddRange(carriages.ToArray());
            UpdateFormData(carriages[0]);
            CarriageBox.SelectedIndex = 0;
        }

        private void UpdateFormData(Carriage carriage)
        {
            seats = service.GetAvailableSeats(carriage, trip);
            SeatBox.Items.Clear();
            SeatBox.Items.AddRange(seats.ToArray());
            SeatBox.SelectedIndex = 0;

            int value = Convert.ToInt32(carriage.CarriageType);
            PriceLabel.Text = (100 + value * 25).ToString();
        }

        private void CarriageBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int position = CarriageBox.SelectedIndex;
            UpdateFormData(carriages[position]);
        }

        private void BuyButton_click(object sender, EventArgs e)
        {
            int position = SeatBox.SelectedIndex;
            var currentSeat = seats[position];
            if(currentUser.PassportData == null)
            {
                PassportDataForm passportDataForm = new PassportDataForm();
                passportDataForm.ShowDialog();
            }
            service.BuyTicket(trip, currentSeat, TicketOfficeApplication.GetInstance().CurrentUser);
            MessageBox.Show("Purchase successful! \n You can see all of your purchased tickets in the corresponding menu.");
            this.Close();
        }

        private void CancelButton_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
