using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KungMessenger.Network;
using KungMessenger.Network.Packet;


namespace KungMessenger.Scene
{
    public partial class MainScene : Form
    {
        private Client client;

        public MainScene(Client client)
        {
            InitializeComponent();
            this.client = client;   
        }

        public void StartClient(string id, string passwd)
        {
            LoginPacket loginPacket = new LoginPacket();
            LoginData loginData = new LoginData();
            loginData.ID = id;
            loginData.Password = passwd;
            loginPacket.LogingData = loginData;
            loginPacket.Serialize();
            
          //  while(true)
            {
                client.Send(loginPacket.Buffer);
                Thread.Sleep(50);
            }
        }

        private void MainScene_Load(object sender, EventArgs e)
        {

        }
    }
}
