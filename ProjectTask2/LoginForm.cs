using ProjectTask2.Data;

namespace ProjectTask2

{
    public partial class LoginForm : Form
    {

        private readonly UserDataService _userDataService;

        public LoginForm()
        {
            InitializeComponent();
            _userDataService = new UserDataService();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            string? savedName = _userDataService.GetLastSavedUsername();
            if (!string.IsNullOrEmpty(savedName))
            {
                NameTxtBox.Text = savedName;
                CheckBoxRememberUser.Checked = true;
            }
        }

        private void EnterChatBtn(object sender, EventArgs e)
        {
            string username = NameTxtBox.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CheckBoxRememberUser.Checked)
            {
                _userDataService.SaveUsername(username);
            }
            
            var chatForm = new ChatForm(username);
            chatForm.Show();
            this.Hide();
        }

        private void CheckBoxRememberUser_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
