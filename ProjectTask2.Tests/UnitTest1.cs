using ProjectTask2.Utils;

namespace ProjectTask2.Tests
{
    public class MessageFormatterTests
    {
        [Test]
        public void Format_ValidInputs_ReturnsFormattedMessage()
        {
            var time = new DateTime(2025, 8, 2, 13, 30, 0); // 01:30 PM
            var result = MessageFormatter.Format("Alice", "Hello", time);

            Assert.AreEqual("[01:30 PM] Alice: Hello", result);
        }

        [Test]
        public void Format_EmptyUsername_ThrowsException()
        {
            var ex = Assert.Throws<ArgumentException>(() =>
                MessageFormatter.Format("", "Hello"));

            Assert.That(ex.Message, Is.EqualTo("Username is required"));
        }

        [Test]
        public void Format_EmptyMessage_ThrowsException()
        {
            var ex = Assert.Throws<ArgumentException>(() =>
                MessageFormatter.Format("Alice", ""));

            Assert.That(ex.Message, Is.EqualTo("Message is required"));
        }
    }
}