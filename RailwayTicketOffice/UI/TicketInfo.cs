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
    public partial class TicketInfo : Form
    {
        private readonly TicketService ticketService = TicketOfficeApplication.GetInstance().GetTicketService();
        private readonly List<Ticket> ticketList;

        public TicketInfo()
        {
            InitializeComponent();
            ticketList = ticketService.GetTickets(TicketOfficeApplication.GetInstance().CurrentUser);

            if (ticketList.Count == 0)
            {
                EmptyListLabel.Visible = true;
                TicketComboBox.Enabled = false;
                DataPanel.Visible = false;
            }
            else
            {
                EmptyListLabel.Visible = false;

                foreach (var ticket in ticketList)
                {
                    TicketComboBox.Items.Add(ticket.ID);
                }
                TicketComboBox.SelectedIndex = 0;
                PrintData(ticketList.ElementAt(0));
            }
        }

        private void PrintData(Ticket ticket)
        {
            this.FromLabel.Text = ticket.Train.DepartureStation.Name;
            this.ToLabel.Text = ticket.Train.ArrivalStation.Name;
            this.PriceLabel.Text = ticket.Price.ToString();
            this.SeatNumLabel.Text = ticket.Seat.NumberInCarriage.ToString();
            this.CarriageTypeLabel.Text = ticket.Seat.Carriage.CarriageType.ToString();
            this.DepTimeLabel.Text = ticket.Train.DepartureTime.ToString(@"hh\:mm");
            this.ArrTimeLabel.Text = ticket.Train.ArrivalTime.ToString(@"hh\:mm");
            this.DateLabel.Text = ticket.Date.Date.ToShortDateString();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TicketComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
