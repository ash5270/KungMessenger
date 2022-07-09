using System.Diagnostics.Eventing.Reader;
using KungMessenger.Network.Packet;
using KungMessenger.Network;

namespace KungMessenger.Scene
{
    public partial class LoginMenu : Form
    {
        private Client client;

        public LoginMenu()
        {
            InitializeComponent();
            PW_Textbox.PasswordChar = '*';

            InitClient();
        }

        private void InitClient()
        {
            client = new Client();
            client.Start("127.0.0.1", 3000);
            client.OnConnectingEvent += ConnectFailEvnet;
        }

        public void ConnectFailEvnet(object s,EventArgs e)
        {
            this.BeginInvoke((Action)delegate
            {
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.Name == "Popup")
                    {
                        return;
                    }
                }
                Popup popup = new Popup(this, "오류", "서버에 연결이 안되었습니다.");
                popup.Owner = this;
                popup.ShowDialog();
            });
        }

        #region Text Box Event


        private void ID_Textbox_Enter(object sender, EventArgs e)
        {
            TextboxUtil.Hint(ID_Textbox, "ID");
        }

        private void ID_Textbox_Leave(object sender, EventArgs e)
        {
            TextboxUtil.Hint(ID_Textbox, "ID", false);
        }

        private void PW_Textbox_Enter(object sender, EventArgs e)
        {
            TextboxUtil.Hint(PW_Textbox, "Password");
        }

        private void PW_Textbox_Leave(object sender, EventArgs e)
        {
            TextboxUtil.Hint(PW_Textbox, "Password", false);
        }

        #endregion

        #region Button Event
        private void Login_Btn_Click(object sender, EventArgs e)
        {
            MainScene mainScene = new MainScene(client);
            this.Visible = false;

            LoginData loginData = new LoginData();
            loginData.ID = ID_Textbox.Text;
            loginData.Password = PW_Textbox.Text;

            mainScene.StartClient(loginData.ID, loginData.Password);

            mainScene.Owner = this;
            mainScene.Show();

            Console.WriteLine(loginData.ID,loginData.Password);
        }

        private void Signup_Btn_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                Signup signup = new Signup(client);
                signup.StartPosition = FormStartPosition.Manual;
                signup.Location = new Point(this.Location.X + this.Bounds.Width, this.Location.Y);
                signup.Owner = this;
                signup.ShowDialog();
            }
        }
        #endregion 
    }
}