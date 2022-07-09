using System;
using KungMessenger.Network;
using KungMessenger.Network.Packet;

namespace KungMessenger.Scene
{
    public partial class Signup : Form
    {
        private Client client;

        public Signup(Client client)
        {
            InitializeComponent();
            Init();

            this.client = client;
        }

        public void Init()
        {
            PWCheck_Textbox.PasswordChar = '*';
            PWCheck_Textbox.MaxLength = 14;
            PW_Textbox.PasswordChar = '*';
            PW_Textbox.MaxLength = 14;

            ID_Label.Text = "";
            PW_Label.Text = "";
        }

        #region Button Hint Event
        private void ID_TextBox_Enter(object sender, EventArgs e)
        {
            TextboxUtil.Hint(ID_Textbox,"ID");
        }

        private void ID_TextBox_Leave(object sender, EventArgs e)
        {
            TextboxUtil.Hint(ID_Textbox, "ID",false);
        }

        private void PW_TextBox_Enter(object sender, EventArgs e)
        {
            TextboxUtil.Hint(PW_Textbox, "Password");
        }
        private void PW_TextBox_Leave(object sender, EventArgs e)
        {
            TextboxUtil.Hint(PW_Textbox, "Password", false);
        }

        private void PWCK_TextBox_Enter(object sender, EventArgs e)
        {
            TextboxUtil.Hint(PWCheck_Textbox, "Password");
        }

        private void PWCK_TextBox_Leave(object sender, EventArgs e)
        {
            TextboxUtil.Hint(PWCheck_Textbox, "Password", false);
        }

        private void Nickname_Textbox_Enter(object sender, EventArgs e)
        {
            TextboxUtil.Hint(Nickname_Textbox, "NickName");
        }

        private void Nickname_Textbox_Leave(object sender, EventArgs e)
        {
            TextboxUtil.Hint(Nickname_Textbox, "NickName", false);
        }
        #endregion

        private void IDCheck_Btn_Click(object sender, EventArgs e)
        {
            
        }

        private void Submit_Btn_Click(object sender, EventArgs e)
        {
            //데이터 보내기 
            if (ID_Textbox.Text.Length <= 5)
            {
                ID_Label.Text = "아이디 길이가 작습니다.";
                return;
            }

            if(PW_Textbox.Text.Length<=5|| PW_Textbox.Text.Length <= 5)
            {
                PW_Label.Text = "비밀번호 길이가 작습니다.";
                return;
            }

            if (!PasswordCheck(PW_Textbox.Text, PWCheck_Textbox.Text))
            {
                PW_Label.Text = "비밀번호가 같지 않습니다.";
                return;
            }

            SignupData data = new SignupData();
            data.ID= ID_Textbox.Text;
            data.Password = PWCheck_Textbox.Text;
            data.Nickname = Nickname_Textbox.Text;

            SignupPacket packet = new SignupPacket();
            packet.SignupData= data;
            packet.Serialize();

            client.Send(packet.Buffer);
            Console.WriteLine("d");
        }

        private bool PasswordCheck(string pw, string pw2) 
        {
            if (pw == pw2)
                return true;
            return false;
        }
    }
}
