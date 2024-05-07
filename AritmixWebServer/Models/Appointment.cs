namespace AritmixWebServer.Models
{
    public class Appointment
    {
        public string Id { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public AppointmentType AppointmentType { get; set; }
        public Patient Patient { get; set; } = null;

    }
}
