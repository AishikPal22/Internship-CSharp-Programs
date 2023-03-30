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
    public class TicketBooking  //DO NOT change the class name
    {
        //Implement the property as per the description
        public SqlConnection Sqlcon { get; set; }
        public TicketBooking()
        {

        }

        //Implement the methods as per the description
        DBHandler d = new DBHandler();
        public void AddTicket(TicketDetail detail)
        {
            string query = "INSERT INTO TicketBooking VALUES(@id,@name,@date,@dist,@cost)";

            using (SqlConnection con = d.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = detail.PassengerId;

                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = detail.PassengerName;
                cmd.Parameters.Add("@date", SqlDbType.VarChar).Value = detail.TravelDate;
                cmd.Parameters.Add("@dist", SqlDbType.Int).Value = detail.DistanceTravel;
                cmd.Parameters.Add("@cost", SqlDbType.Float).Value = detail.TicketCost;

                con.Open();
                try
                {

                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
                finally
                {

                    con.Close();
                }
            }
        }

        //Implement the methods as per the description
        public void CalculateCost(TicketDetail detail)
        {

            if (detail.DistanceTravel <= 100)
            {
                detail.TicketCost = detail.DistanceTravel * 1;
            }
            else if (detail.DistanceTravel > 100 && detail.DistanceTravel <= 300)
            {
                detail.TicketCost = detail.DistanceTravel * 1.5;
            }
            else if (detail.DistanceTravel > 300 && detail.DistanceTravel <= 500)
            {
                detail.TicketCost = detail.DistanceTravel * 2.5;
            }
            else if (detail.DistanceTravel > 500)
            {
                detail.TicketCost = detail.DistanceTravel * 4.5;
            }
        }
    }
}