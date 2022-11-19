using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Source.Classes
{
    public class UI
    {
        public AppointmentClass CreateAppointment()
        {
            AppointmentClass result = new AppointmentClass();
            Console.Clear();
            Console.WriteLine("New Appointment");
            Console.WriteLine("Enter the Title: ");
            string title = Console.ReadLine().Trim().ToUpper();

            Console.WriteLine("Enter the customer ID: ");

            int customerId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the employee ID: ");

            int employeeId = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter the Description: ");
            string description = Console.ReadLine().Trim();

            DateTime time = result.CheckTime();

            return result.CreateAppointment(customerId, employeeId, title, description, false, time);


        }
        public void PrintDetails(AppointmentClass app)
        {
            System.Console.WriteLine($"ID: {app.Id} Customer ID: {app.Id} \n{app.Title} ({app.Completed}) - {app.AppointmentTime.ToShortTimeString}\n\t{app.Description}");

        }

        public void ShowCustomerAppointments(List<AppointmentClass> appointments, int customerId)
        {
            // appointments = appointments.OrderBy(x => x.Description).ToList();

            appointments = appointments.Where(x => x.Id == customerId).ToList();
            appointments = appointments.OrderBy(x => x.AppointmentTime).ToList();

            foreach (AppointmentClass appointment in appointments)
            {
                System.Console.WriteLine($"{appointment.Id}\t{appointment.Title}\t{appointment.Id}\t{appointment.Description}\t{appointment.AppointmentTime}");
            }
        }

    }
}