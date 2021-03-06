using Microsoft.Extensions.Logging;

namespace LTest.Logging
{
    /// <summary>
    /// Class for a log event.
    /// </summary>
    public class ServerLogEvent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerLogEvent"/> class.
        /// </summary>
        /// <param name="categoryName">Category name.</param>
        /// <param name="level">Log level.</param>
        /// <param name="eventId">Event id.</param>
        /// <param name="message">Log message.</param>
        /// <param name="exception">Exception attached to the log.</param>
        public ServerLogEvent(string categoryName, LogLevel level, EventId eventId, string message, Exception? exception)
        {
            CategoryName = categoryName;
            EventId = eventId;
            Level = level;
            Message = message;
            Exception = exception;
        }

        /// <summary>
        /// Category name.
        /// </summary>
        public string CategoryName { get; }

        /// <summary>
        /// Event Id.
        /// </summary>
        public EventId EventId { get; }

        /// <summary>
        /// Log level.
        /// </summary>
        public LogLevel Level { get; }

        /// <summary>
        /// Log message.
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// Exception attached to the log event.
        /// </summary>
        public Exception? Exception { get; }

        /// <summary>
        /// ToString() override.
        /// </summary>
        public override string ToString()
        {
            return $"{Level.ToString()[0]}: {Message} [{CategoryName}] [{EventId}]";
        }
    }
}