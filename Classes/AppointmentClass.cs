using Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Source.Classes
{
    public class AppointmentClass : AppointmentModel
    {

        public AppointmentClass()
        {

        }
        public AppointmentClass(int customer, int employee, string title, string desc, bool complete, DateTime time)
        {
            CustomerId = customer;
            EmployeeId = employee;
            Title = title;
            Description = desc;
            Completed = complete;
            AppointmentTime = time;
        }
        public AppointmentClass CreateAppointment(int customer, int employee, string title, string desc, bool complete, DateTime time)
        {

            AppointmentClass newAppointment = new AppointmentClass(customer, employee, title, desc, complete, time);
            return newAppointment;
        }

        public DateTime CheckTime()
        {
            System.Console.WriteLine("Write the month: (MM)");
            string month = Console.ReadLine().ToUpper().Trim();

            System.Console.WriteLine("Write the day: (DD)");
            string day = Console.ReadLine().ToUpper().Trim();

            System.Console.WriteLine("Write the year: (YY)");
            string year = Console.ReadLine().ToUpper().Trim();

            System.Console.WriteLine("Write the hour: (HH)");
            string hour = Console.ReadLine().Trim();

            System.Console.WriteLine("Write the minutes: (MM)");
            string minutes = Console.ReadLine().Trim();

            System.Console.WriteLine("Write AM or PM: (PM))");
            string amOrPm = Console.ReadLine().ToUpper().Trim();

            string fullTime = $"{month}/{day}/{year} {hour}:{minutes} {amOrPm}";
            try
            {
                DateTime newTime = Convert.ToDateTime(fullTime);
                return newTime;

            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }

            DateTime nullTime = new DateTime();
            return nullTime;
        }


    }
}