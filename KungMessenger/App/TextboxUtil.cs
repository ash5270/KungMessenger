using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KungMessenger
{
    public static class TextboxUtil
    {
        public static void Hint(TextBox textBox, string text, bool on = true)
        {
            if (!on)
            {
                if (textBox.Text == text || textBox.Text == "")
                {
                    textBox.Text = text;
                    textBox.ForeColor = Color.Silver;
                }
            }
            else
            {
                if (textBox.Text == text)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            }
        }
    }
}
