

namespace Albert
{
    /// <summary>
    /// Record is designed to Log information from an Application
    /// </summary>
    public record LogRecord
    {
        public LogRecord(string _msg)
        {
            Message = _msg;
        }
        /// <summary>
        /// Get the Messge that is Logged
        /// </summary>
        public string? Message { get; init; }

        /// <summary>
        /// Get the Date and the Time
        /// </summary>
        public DateTime DateTime => DateTime.Now;
        /// <summary>
        /// Get the Date 
        /// </summary>
        public DateOnly Date => DateOnly.FromDateTime(DateTime);
        /// <summary>
        /// Get the Time of Day
        /// </summary>
        public TimeOnly Time => TimeOnly.FromDateTime(DateTime);

        public override string ToString()
        {
            return $"Message:{Message}\nDate:{Date}\nTime{Time}";
        }

    }
}
