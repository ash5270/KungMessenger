namespace KungMessenger.Scene
{
    partial class Popup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Popup_Textbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Popup_Textbox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 66);
            this.panel1.TabIndex = 0;
            // 
            // Popup_Textbox
            // 
            this.Popup_Textbox.BackColor = System.Drawing.SystemColors.Control;
            this.Popup_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Popup_Textbox.Location = new System.Drawing.Point(3, 22);
            this.Popup_Textbox.Name = "Popup_Textbox";
            this.Popup_Textbox.ReadOnly = true;
            this.Popup_Textbox.Size = new System.Drawing.Size(229, 20);
            this.Popup_Textbox.TabIndex = 1;
            this.Popup_Textbox.TabStop = false;
            this.Popup_Textbox.Text = "dddd";
            this.Popup_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 85);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Popup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Popup";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Popup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox Popup_Textbox;
    }
}