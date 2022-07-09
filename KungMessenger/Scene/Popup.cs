using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KungMessenger.Scene
{
    public partial class Popup : Form
    {
        public Popup(Form callForm ,string head,string body)
        {
            InitializeComponent();
            Text=head;
            Popup_Textbox.Text=body;

            var callFormLocation = callForm.Location;
            var callFormSize= callForm.Bounds;
            var resultX = (callFormSize.Width / 5) + callFormLocation.X;
            var resultY = (callFormSize.Height / 3) + callFormLocation.Y;

            Point point = new Point(resultX,resultY);
            this.Location = point;
        }

        private void Popup_Load(object sender, EventArgs e)
        {

        }

        private void Popup_Label_Click(object sender, EventArgs e)
        {

        }
    }
}
