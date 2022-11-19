/*
 * This project is mostly to get practice with LINQ, and interacting with databases
 * 
*/
using System;
using System.Collections.Generic;
using Source.Classes;
using System.Linq;
using Microsoft.EntityFrameworkCore.Design;
using Source.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        var context = new DataContext();

        List<AppointmentClass> appointments = new List<AppointmentClass>();
        AppointmentClass newAppointment = new AppointmentClass();
        UI ui = new UI();


        context.Add(ui.CreateAppointment());
        context.SaveChanges();

    }

}