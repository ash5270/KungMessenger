namespace KungMessenger
{
    partial class LoginMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login_Btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ID_Textbox = new System.Windows.Forms.TextBox();
            this.PW_Textbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_Btn
            // 
            this.Login_Btn.Location = new System.Drawing.Point(75, 165);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.Size = new System.Drawing.Size(223, 29);
            this.Login_Btn.TabIndex = 0;
            this.Login_Btn.Text = "Login";
            this.Login_Btn.UseVisualStyleBackColor = true;
            this.Login_Btn.Click += new System.EventHandler(this.Login_Btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ID_Textbox);
            this.panel1.Controls.Add(this.PW_Textbox);
            this.panel1.Controls.Add(this.Login_Btn);
            this.panel1.Location = new System.Drawing.Point(12, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 331);
            this.panel1.TabIndex = 1;
            // 
            // ID_Textbox
            // 
            this.ID_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.ID_Textbox.Location = new System.Drawing.Point(75, 99);
            this.ID_Textbox.Name = "ID_Textbox";
            this.ID_Textbox.Size = new System.Drawing.Size(223, 27);
            this.ID_Textbox.TabIndex = 2;
            this.ID_Textbox.Text = "ID";
            this.ID_Textbox.Enter += new System.EventHandler(this.ID_Textbox_Enter);
            this.ID_Textbox.Leave += new System.EventHandler(this.ID_Textbox_Leave);
            // 
            // PW_Textbox
            // 
            this.PW_Textbox.BackColor = System.Drawing.Color.White;
            this.PW_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.PW_Textbox.Location = new System.Drawing.Point(75, 132);
            this.PW_Textbox.Name = "PW_Textbox";
            this.PW_Textbox.Size = new System.Drawing.Size(223, 27);
            this.PW_Textbox.TabIndex = 1;
            this.PW_Textbox.Text = "Password";
            this.PW_Textbox.Enter += new System.EventHandler(this.PW_Textbox_Enter);
            this.PW_Textbox.Leave += new System.EventHandler(this.PW_Textbox_Leave);
            // 
            // LoginMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 576);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "LoginMenu";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Login_Btn;
        private Panel panel1;
        private TextBox ID_Textbox;
        private TextBox PW_Textbox;
    }
}