AppointmentCalendar appointmentCalendar = new AppointmentCalendar(
    new List<Appointment>
    {
        new Appointment("Doctor's appointment", new DateTime(2023, 10, 5)),
        new Appointment("Business meeting", new DateTime(2023, 10, 10)),
        new Appointment("Project deadline", new DateTime(2023, 10, 15))
    },
    new LinkedList<Appointment>(new[]
    {
        new Appointment("Grocery shopping", new DateTime(2023, 10, 6)),
        new Appointment("Gym session", new DateTime(2023, 10, 7)),
        new Appointment("Dinner with friends", new DateTime(2023, 10, 8))
    })
);

IAppointMentIterator iterator;

iterator = appointmentCalendar.CreatePriorityIterator();
while (iterator.HasNext())
{
    Console.WriteLine(iterator.Next());
}

iterator = appointmentCalendar.CreateDateRangeIterator(new DateTime(2023, 10, 5), new DateTime(2023, 10, 10));
while (iterator.HasNext())
{
    Console.WriteLine(iterator.Next());
}
