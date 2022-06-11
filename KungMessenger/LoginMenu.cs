namespace KungMessenger
{
    public partial class LoginMenu : Form
    {
        public LoginMenu()
        {
            InitializeComponent();
            PW_Textbox.PasswordChar= '*'; 
        }

        private void TextHint(TextBox textBox, string text,bool on=true)
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
            TextHint(ID_Textbox, "ID",false);
        }

        private void PW_Textbox_Enter(object sender, EventArgs e)
        {
            TextHint(PW_Textbox, "Password");
        }

        private void PW_Textbox_Leave(object sender, EventArgs e)
        {
            TextHint(PW_Textbox, "Password",false);
        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            MainScene mainScene = new MainScene();
            this.Visible = false;
            mainScene.Owner = this;
            mainScene.Show();
        }
    }
}