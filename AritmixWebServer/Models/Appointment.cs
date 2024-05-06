namespace AritmixWebServer.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime? AppointmentgDate { get; set; }
        public AppointmentType AppointmentType { get; set; }
        public Patient Patient { get; set; } = null;

    }
}
