namespace ProjectTask2
{
    partial class ChatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SendButton = new Button();
            label1 = new Label();
            MessageTextBox = new TextBox();
            ChatHistoryBox = new RichTextBox();
            SuspendLayout();
            // 
            // SendButton
            // 
            SendButton.Location = new Point(455, 466);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(75, 23);
            SendButton.TabIndex = 0;
            SendButton.Text = "Send";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 386);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter Your Message:";
            // 
            // MessageTextBox
            // 
            MessageTextBox.Location = new Point(21, 404);
            MessageTextBox.Multiline = true;
            MessageTextBox.Name = "MessageTextBox";
            MessageTextBox.Size = new Size(406, 87);
            MessageTextBox.TabIndex = 2;
            // 
            // ChatHistoryBox
            // 
            ChatHistoryBox.BackColor = SystemColors.ControlLight;
            ChatHistoryBox.Location = new Point(12, 12);
            ChatHistoryBox.Name = "ChatHistoryBox";
            ChatHistoryBox.ReadOnly = true;
            ChatHistoryBox.Size = new Size(415, 328);
            ChatHistoryBox.TabIndex = 3;
            ChatHistoryBox.Text = "";
            // 
            // ChatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 501);
            Controls.Add(ChatHistoryBox);
            Controls.Add(MessageTextBox);
            Controls.Add(label1);
            Controls.Add(SendButton);
            Name = "ChatForm";
            Text = "Awesome Chat";
            Load += ChatForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SendButton;
        private Label label1;
        private TextBox MessageTextBox;
        private RichTextBox ChatHistoryBox;
    }
}