class DateRangeIterator : IAppointMentIterator
{
    private List<Appointment> _highPriorityAppointments;
    private int _position = 0;
    public DateRangeIterator(AppointmentCalendar calendar, DateTime startDate, DateTime endDate)
    {
        Console.WriteLine("Date Range Iterator");
        _highPriorityAppointments = calendar.HighPriorityAppointments
            .Where(a => a.Date >= startDate && a.Date <= endDate)
            .ToList();
    }
    public bool HasNext()
    {
        return _position < _highPriorityAppointments.Count;
    }

    public Appointment Next()
    {
        return _highPriorityAppointments[_position++];
    }
}