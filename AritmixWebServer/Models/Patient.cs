namespace AritmixWebServer.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime? MeetingDate { get; set; }
        public string MeetingType { get; set; }
    }
}
