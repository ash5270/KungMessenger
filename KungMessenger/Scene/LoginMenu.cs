using System.Diagnostics.Eventing.Reader;
using KungMessenger.Network;


namespace KungMessenger
{
    public partial class LoginMenu : Form
    {
        public LoginMenu()
        {
            InitializeComponent();
            PW_Textbox.PasswordChar = '*';
        }

        private void TextHint(TextBox textBox, string text, bool on = true)
        {
            if (!on)
            {
                textBox.Text = text;
                textBox.ForeColor = Color.Silver;
            }
            else
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void ID_Textbox_Enter(object sender, EventArgs e)
        {
            TextHint(ID_Textbox, "ID");
        }

        private void ID_Textbox_Leave(object sender, EventArgs e)
        {
            TextHint(ID_Textbox, "ID", false);
        }

        private void PW_Textbox_Enter(object sender, EventArgs e)
        {
            TextHint(PW_Textbox, "Password");
        }

        private void PW_Textbox_Leave(object sender, EventArgs e)
        {
            TextHint(PW_Textbox, "Password", false);
        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            MainScene mainScene = new MainScene();
            this.Visible = false;

            LoginData loginData = new LoginData();
            loginData.ID = ID_Textbox.Text;
            loginData.Password = PW_Textbox.Text;

            mainScene.StartClient(loginData.ID, loginData.Password);

            mainScene.Owner = this;
            mainScene.Show();

       



            Console.WriteLine(loginData.ID,loginData.Password);
        }
    }
}