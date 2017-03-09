namespace CalendArt.Core.Domain
{
    public class Reminder
    {
        public int ReminderId { get; set; }
        public string TimeBeforeEvent { get; set; }
        public string EventId { get; set; }
        public string ReminderTypeId { get; set; }

    }
}
