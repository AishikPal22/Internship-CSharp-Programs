using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement
{
    public class TicketDetail
    {
        //Implement the fields and properties as per description
        private string passengerId;
        private string passengerName;
        private string travelDate;
        private int distanceTravel;
        private double ticketCost;

        public string PassengerId
        {
            get { return passengerId; }
            set { this.passengerId = value; }
        }
        public string PassengerName
        {
            get { return passengerName; }
            set { this.passengerName = value; }
        }
        public string TravelDate
        {
            get { return travelDate; }
            set { this.travelDate = value; }
        }
        public int DistanceTravel
        {
            get { return distanceTravel; }
            set { this.distanceTravel = value; }
        }
        public double TicketCost
        {
            get { return ticketCost; }
            set { this.ticketCost = value; }
        }

        public TicketDetail() { }

        public TicketDetail(string passengerId, string passengerName, string travelDate, int distanceTravel)
        {
            this.PassengerId = passengerId;
            this.PassengerName = passengerName;
            this.TravelDate = travelDate;
            this.DistanceTravel = distanceTravel;
        }
    }
}