namespace ProjectTask2
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EnterChatButton = new Button();
            label1 = new Label();
            NameTxtBox = new TextBox();
            CheckBoxRememberUser = new CheckBox();
            SuspendLayout();
            // 
            // EnterChatButton
            // 
            EnterChatButton.Location = new Point(206, 195);
            EnterChatButton.Name = "EnterChatButton";
            EnterChatButton.Size = new Size(91, 36);
            EnterChatButton.TabIndex = 0;
            EnterChatButton.Text = "Enter Chat";
            EnterChatButton.UseVisualStyleBackColor = true;
            EnterChatButton.Click += EnterChatBtn;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 122);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // NameTxtBox
            // 
            NameTxtBox.Location = new Point(138, 117);
            NameTxtBox.Name = "NameTxtBox";
            NameTxtBox.Size = new Size(195, 23);
            NameTxtBox.TabIndex = 2;
            NameTxtBox.TextChanged += NameTxtBox_TextChanged;
            // 
            // CheckBoxRememberUser
            // 
            CheckBoxRememberUser.AutoSize = true;
            CheckBoxRememberUser.Location = new Point(362, 121);
            CheckBoxRememberUser.Name = "CheckBoxRememberUser";
            CheckBoxRememberUser.Size = new Size(104, 19);
            CheckBoxRememberUser.TabIndex = 3;
            CheckBoxRememberUser.Text = "Remember me";
            CheckBoxRememberUser.UseVisualStyleBackColor = true;
            CheckBoxRememberUser.CheckedChanged += CheckBoxRememberUser_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 357);
            Controls.Add(CheckBoxRememberUser);
            Controls.Add(NameTxtBox);
            Controls.Add(label1);
            Controls.Add(EnterChatButton);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EnterChatButton;
        private Label label1;
        private TextBox NameTxtBox;
        private CheckBox CheckBoxRememberUser;
    }
}
