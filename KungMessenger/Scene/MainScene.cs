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

namespace KungMessenger
{
    public partial class MainScene : Form
    {
        private Client client;

        public MainScene()
        {
            InitializeComponent();
        }

        public void StartClient(string id, string passwd)
        {
            client = new Client();
            client.Start("127.0.0.1", 3000);

            Network.Buffer buffer = new Network.Buffer();
            buffer.Write("asdsadsad");
            
            while(true)
            {
                client.Send(buffer);
                Thread.Sleep(50);

            }
        }

        private void MainScene_Load(object sender, EventArgs e)
        {

        }
    }
}
