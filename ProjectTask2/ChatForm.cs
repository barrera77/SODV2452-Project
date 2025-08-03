using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTask2
{
    public partial class ChatForm : Form
    {
        private readonly string _username;
        public ChatForm(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {

        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string message = MessageTextBox.Text.Trim();

            if (string.IsNullOrEmpty(message))
            {
                return; 
            }

            
            string fullMessage = $"{_username}: {message}";
            byte[] messageBytes = Encoding.Unicode.GetBytes(fullMessage);

            byte[] responseBytes = SendMessageToServer(messageBytes);
            string response = Encoding.Unicode.GetString(responseBytes).TrimEnd('\0');

            string timestamp = DateTime.Now.ToString("hh:mm tt"); 

            string formatted = $"[{timestamp}] {response}";
            ChatHistoryBox.AppendText(formatted + Environment.NewLine);

            MessageTextBox.Clear();
        }


        private byte[] SendMessageToServer(byte[] messageBytes)
        {
            const int bytesize = 1024 * 1024;

            try
            {
                TcpClient client = new TcpClient("127.0.0.1", 1234);
                NetworkStream stream = client.GetStream();

                stream.Write(messageBytes, 0, messageBytes.Length);
                messageBytes = new byte[bytesize];
                stream.Read(messageBytes, 0, messageBytes.Length);

                stream.Close();
                client.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending message: {ex.Message}");
            }

            return messageBytes;
        }

    }
}
