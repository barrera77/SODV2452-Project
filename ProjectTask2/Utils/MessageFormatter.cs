using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTask2.Utils
{
    public static class MessageFormatter
    {
        public static string Format(string username, string message, DateTime? time = null)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username is required");

            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentException("Message is required");

            var timestamp = (time ?? DateTime.Now).ToString("hh:mm tt");
            return $"[{timestamp}] {username}: {message}";
        }
    }
}
