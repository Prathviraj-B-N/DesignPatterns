using System.ComponentModel.DataAnnotations;
public record Appointment
{
    private String Title;
    public DateTime Date { get; private set; }
    public bool HighPriority;
    public Appointment(String title, DateTime date)
    {
        Title = title;
        Date = date;
    }
    public override string ToString()
    {
        return $"{Title} on {Date}";
    }

}
class AppointmentCalendar
{
    public List<Appointment> HighPriorityAppointments { get; private set; }
    public LinkedList<Appointment> StandardAppointments { get; private set; }
    
    public AppointmentCalendar(List<Appointment> highPriorityAppointments, LinkedList<Appointment> standardAppointments)
    {
        HighPriorityAppointments = highPriorityAppointments;
        StandardAppointments = standardAppointments;
    }
}