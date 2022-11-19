using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Source.Models
{
    public class CustomerModel
    {
        public CustomerModel() { }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }

        ICollection<AppointmentModel> Appointments { get; set; }
    }
}
