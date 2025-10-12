class PriorityIterator : IAppointMentIterator
{
    private List<Appointment> _highPriorityAppointments;
    private LinkedList<Appointment> _standardAppointments;
    private int _hpPosition = 0;
    private LinkedListNode<Appointment>? _currentStdNode = null;
    public PriorityIterator(AppointmentCalendar calendar)
    {
        Console.WriteLine("Priority Iterator");
        _highPriorityAppointments = calendar.HighPriorityAppointments;
        _standardAppointments = calendar.StandardAppointments;
        _currentStdNode = _standardAppointments.First;
    }
    public bool HasNext()
    {
        if (_hpPosition < _highPriorityAppointments.Count)
        {
            return true;
        }

        if (_currentStdNode != null)
        {
            return true;
        }

        return false;
    }

    public Appointment Next()
    {
        if (_hpPosition < _highPriorityAppointments.Count)
        {
            return _highPriorityAppointments[_hpPosition++];
        }

        if (_currentStdNode != null)
        {
            var appointment = _currentStdNode.Value;
            _currentStdNode = _currentStdNode.Next;
            return appointment;
        }

        throw new InvalidOperationException("No more appointments.");
    }
}