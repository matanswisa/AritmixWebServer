﻿namespace AritmixWebServer.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public List<Appointment>? Appointments { get; set; } 


    }
}
